using System;

namespace pz_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone ph = new Phone("+7");
            Phone ph1 = new Phone("+7", 898, "3572381", "личный");
            Phone ph2 = new Phone(345, "1234567");
            Phone ph3 = new Phone("+1");
            ph.GetPhoneNumber();
            ph1.GetPhoneNumber();
            ph2.GetPhoneNumber();
            ph3.GetPhoneNumber();
        }
    }
    class Phone
    {
        string prefix;
        int code;
        string number;
        string type;

        public Phone(string prefix)
        {
            this.prefix = prefix;
            code = 123;
            number = "0000000";
        }
        public Phone(string prefix, int code, string number, string type)
        {
            this.prefix = prefix;
            this.code = code;
            this.number = number;
            this.type = type;
        }
        public Phone(int code, string number)
        {
            prefix = "+7";
            this.code = code;
            this.number = number;

        }
        public void GetPhoneNumber()
        {
            char[] num = number.ToCharArray();
            Console.WriteLine(prefix + "(" + code + ")" + num[0] + num[1] + num[2] + '-' + num[3] + num[4] + '-' + num[5] + num[6]);
        }
    }
}
