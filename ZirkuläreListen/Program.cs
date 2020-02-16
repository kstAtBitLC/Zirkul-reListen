using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZirkuläreListen {
    class Program {
        static void Main ( string [] args ) {
            Zirkulator zl = new Zirkulator ();
            zl.ShowValues ();

            Console.ReadLine ();
        }
    }
}
