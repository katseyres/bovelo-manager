using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            InternalApp internalApp = new InternalApp();
            internalApp.Run();
        }
    }
}
