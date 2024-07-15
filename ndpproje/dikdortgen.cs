using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    public class dikdortgen
    {
        nokta merkez;
        int en;
        int boy;

        public dikdortgen()
        {
            merkez = new nokta();
            en = 0;
            boy = 0;
        }

        public nokta Merkez { get => merkez; set => merkez = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
    }
}
