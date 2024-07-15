using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    public class cember
    {
        nokta merkez;
        int r;

        public cember()
        {
            merkez = new nokta();
            r = 0;
        }

        public nokta Merkez { get => merkez; set => merkez = value; }
        public int R { get => r; set => r = value; }


    }
}
