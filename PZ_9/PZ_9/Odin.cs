using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_9
{
    internal class Odin
    {
        private Dva _odin;

        public Odin()
        {
            this._odin = new Dva();
        }

        public void ClientDb(double valueDouble)
        {
            this._odin.OdinDouble(valueDouble);
        }

        public void ClientInt(int valueInt)
        {
            this._odin.OdinInt(valueInt * 2);
        }

        public void ClientChr(char valueChar)
        {
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.Write(valueChar);
            }
            Console.WriteLine();
        }
    }
}