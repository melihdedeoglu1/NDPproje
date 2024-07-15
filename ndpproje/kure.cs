using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    public class kure
    {
        nokta3d merkez;
        int r;

        public kure()
        {
            merkez = new nokta3d();
            r = 0;
        }
        public nokta3d Merkez { get => merkez; set => merkez = value; }
        public int R { get => r; set => r = value; }
    }
}
