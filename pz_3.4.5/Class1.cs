using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_32
{
    class PrivatePhone : Phone
    {
        public string Availability;
        public PrivatePhone(string prefix, int code, string number, string type,string Availability) : base(prefix,code,number,type)
        {
            this.Availability = Availability;
        }
        public override void GetPhoneNumber()
        {
            char[] num = Number.ToCharArray();
            Console.WriteLine(Prefix + $"({Code})" + num[0] + num[1] + num[2] + '-' + num[3] + num[4] + '-' + num[5] + num[6]+"  Список абонентов с доступом к этому номеру: "+Availability);
        }
    }
}
