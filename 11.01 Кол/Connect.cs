using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._01_Кол
{
    internal class Connect
    {
        public static Database1Entities c;
        public static Database1Entities context
        {
            get
            {
                if (c == null)
                    c = new Database1Entities();
                return c;
            }
        }
    }
}
