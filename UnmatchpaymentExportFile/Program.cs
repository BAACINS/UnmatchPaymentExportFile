using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmatchpaymentExportFile
{
    class Program
    {
        static void Main(string[] args)
        {
            SPIN _spin = new SPIN();
            _spin.ExportSPIN();

            GL _gl = new GL();
            _gl.ExportGL();

            Management mn = new Management();
            mn.UpdateMatchinfID();
        }
    }
}
