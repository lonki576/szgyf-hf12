using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhf1
{
    class Class1
    {
        public static double résszösszeg;
        public static double jelenlegi_szám;
        public static void összeadás()
        {
            résszösszeg = résszösszeg + jelenlegi_szám;
        }
        public static void kivonás()
        {
            résszösszeg = résszösszeg - jelenlegi_szám;
        }
        public static void szorzás()
        {
            résszösszeg = résszösszeg * jelenlegi_szám; ;
        }
        public static void osztás()
        {
            résszösszeg = résszösszeg + jelenlegi_szám; ;
        }
        public static void c()
        {
            résszösszeg = 0;
            jelenlegi_szám= 0;
        }
        public static void ce()
        {
            jelenlegi_szám = 0;
            
        }
    }
}
