using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    public class prizma
    {
        nokta3d merkez;
        int en;
        int boy;
        int gen;

        public prizma()
        {
            merkez = new nokta3d();
            en = 0;
            boy = 0;
            gen = 0;
        }
        public nokta3d Merkez { get => merkez; set => merkez = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        public int Gen { get => gen; set => gen = value; }
    }
}
