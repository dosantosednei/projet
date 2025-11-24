using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LEDSBOLADOS
{
    internal class Paralela
    {
        [DllImport("Inpout32.dll", EntryPoint = "Out32")]
        public static extern void EnviarSinal(int enderecoPorta, byte valorParaEscrever);
    }
}
