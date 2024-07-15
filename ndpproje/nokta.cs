using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    public class nokta
    {
        int x;
        int y;

        public nokta()
        {
            x = 0;
            y = 0;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
    public class nokta3d : nokta
    {
        int z;

        public nokta3d() : base()
        {
            z = 0;
        }

        public int Z { get => z; set => z = value; }

    }
}

