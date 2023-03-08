﻿//Copyright (c) 2016-2021 Diego Settimi - https://github.com/arkypita/

// This program is free software; you can redistribute it and/or modify  it under the terms of the GPLv3 General Public License as published by  the Free Software Foundation; either version 3 of the License, or (at  your option) any later version.
// This program is distributed in the hope that it will be useful, but  WITHOUT ANY WARRANTY; without even the implied warranty of  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GPLv3  General Public License for more details.
// You should have received a copy of the GPLv3 General Public License  along with this program; if not, write to the Free Software  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307,  USA. using System;

using System;
using System.Text;

namespace LaserGRBL.ComWrapper
{
    public static class ComLogger
    {
        private static string lockstr = "--- TX RX LOG LOCK ---";
        private static AsyncLogFile file;
        private static int logcnt = 0;

        public static void StartLog(string filename)
        {
            try
            {
                if (filename != null)
                {
                    StopLog();
                    file = new AsyncLogFile(filename, 0);
                    Log("log", $"Recording session started @ {DateTime.Now}");
                }
            }
            catch { }
        }

        public static void StopLog()
        {
            try
            {
                if (Enabled)
                {
                    Log("log", $"Recording session stopped @ {DateTime.Now}");
                    file.Stop();
                }
            }
            finally { file = null; logcnt = 0; }
        }

        public static bool Enabled => file != null;
        public static void Log(string operation, string line)
        {
            if (Enabled)
            {
                lock (lockstr)
                {
                    try
                    {
                        line = line?.Replace("\r", "\\r");
                        line = line?.Replace("\n", "\\n");
                        line = string.Format("{0:00000}\t{1:00000000}\t{2}\t{3}\r\n", logcnt, Tools.TimingBase.TimeFromApplicationStartup().TotalMilliseconds, operation, line);
                        //System.Diagnostics.Debug.Write(line);
                        file.Log(line);
                    }
                    catch { }
                    logcnt++;
                }
            }
        }

        internal static void Log(string operation, byte b)
        {
            if (Enabled)
                Log(operation, string.Format("[{0:X2}]", b));
        }

        internal static void Log(string operation, byte[] arr)
        {
            if (Enabled)
            {
                StringBuilder sb = new StringBuilder("[");

                for (int i = 0; i < arr.Length; i++)
                {
                    sb.Append(string.Format("{0:X2}", arr[i]));
                    if (i < arr.Length - 1) sb.Append(", ");
                }

                sb.Append("]");

                Log(operation, sb.ToString());
            }
        }
    }
}
