using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public abstract class Kesiciler : Silah, IKesici
    {
        Random random = new Random();
        public Kesiciler()
        {
            this.AtesliMi = false;
        }
        public Kesiciler(string silahAdi):base(silahAdi,false)
        {
            this.AtesliMi = false;
        }
        public string Bicakla()
        {
            int oldururMu = random.Next(1,3);
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"..\..\Sesler\StabKnife.wav";
            sp.PlaySync();
            if (oldururMu==1)
            {
                return "Bıçaklandı ve " + this.Oldur();
            }
            else
            {
                return "Bıçaklandı ve " + this.Yarala();
            }
        }

        public string Bileyle()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"..\..\Sesler\SharpenKnife.wav";
            sp.PlaySync();
            return "Bıçak bileylendi";
        }
    }
}
