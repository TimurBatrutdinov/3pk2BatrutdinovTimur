using System;
using System.Drawing;
using System.Xml.Linq;

namespace PZ_5
{
    class ZVER : ICloneable, IComparable<ZVER>
    {
        string _type;
        int _vozr;
        PAXAN _paxan;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Vozr
        {
            get { return _vozr; }
            set { _vozr = value; }
        }
        public PAXAN Paxan
        {
            get { return _paxan; }
            set { _paxan = value; }
        }
        public ZVER(string type, int vozr, PAXAN paxan)
        {
            _type = type;
            _vozr = vozr;
            _paxan = paxan;
        }


        public override string ToString() //Переопределение 
        {
            return $"ЭТОМУ ЛЬВУ - {_type} - {_vozr} ГОДОВ - ПАХАН - {_paxan.Name}";
        }

        public object Clone()  // IClonable 
        {
            return new ZVER(_type, _vozr, new PAXAN(_paxan.Name));
        }

        public int CompareTo(ZVER? ZVER)
        {
            if (ZVER is null)
                throw new ArgumentException("Корректнее, пожалуйста!");
            return Vozr.CompareTo(ZVER.Vozr);
        }
    }

    internal class PAXAN
    {
        string _imya;

        public PAXAN(string imya)
        {
            _imya = imya;
        }

        public string Name
        {
            get { return _imya; }
            set { _imya = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var paxan1 = new PAXAN("ЭД");
            var paxan2 = new PAXAN("ТИМУР");
            var zver = new ZVER("ВАЦОК", 18, paxan1);
            var clone = (ZVER)zver.Clone();
            clone.Paxan = paxan2;

            Console.WriteLine(zver.ToString());
            Console.WriteLine(clone.ToString());

            Console.WriteLine(zver.CompareTo(clone));
        }
    }
}
