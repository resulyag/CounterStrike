using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public class Cephanem
    {
        public Silah[] MyWeapons { get; set; }

        public Cephanem()
        {
            MyWeapons = new Silah[6];
        }

        public Image SilahDegis(int Hangisi)
        {
            switch (Hangisi)
            {
                case 1:
                    return Image.FromFile(@"..\..\Resimler\Knife.jpg");
                case 2:
                    return Image.FromFile(@"..\..\Resimler\Pistol.jpg");
                case 3:
                    return Image.FromFile(@"..\..\Resimler\ShotGun.jpg");
                case 4:
                    return Image.FromFile(@"..\..\Resimler\MachineGun.gif");
                case 5:
                    return Image.FromFile(@"..\..\Resimler\KF1500.jpg");
                case 6:
                    return Image.FromFile(@"..\..\Resimler\RGP.jpg");
                default:
                    return Image.FromFile(@"..\..\Resimler\Knife.jpg");
            }
        }
    }
}
