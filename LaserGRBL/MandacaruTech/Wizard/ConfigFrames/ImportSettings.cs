using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    public partial class ImportSettings : Form
    {
        private readonly GrblCore mCore;

        public ImportSettings(GrblCore mCore)
        {
            InitializeComponent();
            this.mCore = mCore;
        }

        private void Btn_ImportSettings_Click(object sender, EventArgs e)
        {
            string filename = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "GCODE Files|*.nc;*.gcode";
                ofd.CheckFileExists = true;
                ofd.Multiselect = false;
                ofd.RestoreDirectory = true;

                DialogResult dialogResult = DialogResult.Cancel;
                try
                {
                    dialogResult = ofd.ShowDialog(this);
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    ofd.AutoUpgradeEnabled = false;
                    dialogResult = ofd.ShowDialog(this);
                }

                if (dialogResult == DialogResult.OK)
                    filename = ofd.FileName;
            }

            if (filename != null)
            {
                if (!System.IO.File.Exists(filename))
                {
                    MessageBox.Show("O arquivo selecionado não existe", "Importar configurações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        List<GrblConfST.GrblConfParam> conf = new List<GrblConfST.GrblConfParam>();
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(filename))
                        {
                            string rline = null;
                            while ((rline = sr.ReadLine()) != null)
                            {
                                string msg = rline; //"$0=10 (Step pulse time)"
                                int num = int.Parse(msg.Split('=')[0].Substring(1));
                                string val = msg.Split('=')[1].Trim();
                                conf.Add(new GrblConfST.GrblConfParam(num, val));
                            }
                        }

                        if (conf.Count == 0)
                            throw new System.IO.InvalidDataException("File does not contain a valid configuration");
                        else
                            WriteConf(conf, true);

                        mCore.RefreshConfig();
                        MessageBox.Show("Configurações importadas com sucesso", "Importar configurações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogException("ImportConfig", ex);
                        MessageBox.Show(Strings.BoxImportConfigFileError, Strings.BoxExportConfigErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool WriteConf(List<GrblConfST.GrblConfParam> conf, bool import)
        {
            bool noerror = false;

            try
            {
                Cursor = Cursors.WaitCursor;
                mCore.WriteConfig(conf);
                Cursor = DefaultCursor;
                //ActionResult(String.Format(import ? Strings.BoxImportConfigWithoutError : Strings.BoxWriteConfigWithoutError, conf.Count));

                noerror = true;
            }
            catch (GrblCore.WriteConfigException ex)
            {
                Cursor = DefaultCursor;
                MessageBox.Show(String.Format(import ? Strings.BoxImportConfigWithError : Strings.BoxWriteConfigWithError, conf.Count, ex.Errors.Count) + "\n" + ex.Message, Strings.BoxExportConfigErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                Cursor = DefaultCursor;
                MessageBox.Show(String.Format(import ? Strings.BoxImportConfigWithError : Strings.BoxWriteConfigWithError, conf.Count, "unknown"), Strings.BoxExportConfigErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try { mCore.RefreshConfig(); } //ensure to have the last conf at least in core
                catch { }
            }


            return noerror;
        }
    }
}
