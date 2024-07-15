using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    public class silindir
    {
        nokta3d merkez;
        int r;
        int h;

        public silindir()
        {
            merkez = new nokta3d();
            r = 0;
            h = 0;
        }

        public nokta3d Merkez { get => merkez; set => merkez = value; }
        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }
    }
}
