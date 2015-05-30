using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBERPOINTERIZER
{
    public class ConnectionTrait
    {
        public String token;
        public String advertisingID;
        public String uberID;
        public String fileMD5;

        public ConnectionTrait(String t, String a, String u, String f)
        {
            token = t;
            advertisingID = a;
            uberID = u;
            fileMD5 = f;
        }
    }
}
