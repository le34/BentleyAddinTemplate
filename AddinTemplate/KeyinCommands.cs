using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Application = Bentley.Interop.MicroStationDGN.Application;

namespace $safeprojectname$
{
    public static class KeyinCommands
    {
        public static void Start(System.String unparsed)
        {
            Application comApp = Bentley.MicroStation.InteropServices.Utilities.ComApp;

            MessageBox.Show("Start-keyin called.");

        }

        public static void Debug(System.String unparsed)
        {
            Application comApp = Bentley.MicroStation.InteropServices.Utilities.ComApp;

            MessageBox.Show("Debug-keyin called.");
        }
    }
}
