using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    [Bentley.MicroStation.AddInAttribute(MdlTaskID = "$safeprojectname$", KeyinTree = "$safeprojectname$.Commands.xml")]
    public class Addin : Bentley.MicroStation.AddIn
    {
        internal static Bentley.MicroStation.AddIn MainAddin { get; set; }

        private Addin(System.IntPtr mdlDesc)
            : base(mdlDesc)
        {
            MainAddin = this;
        }

        protected override int Run(string[] commandLine)
        {
            return 0;
        }
    }
}
