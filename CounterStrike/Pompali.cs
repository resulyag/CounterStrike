using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public class Pompali:Atesliler
    {
        public Pompali():base()
        {
            this.AudioPathFire = @"..\..\Sesler\Pompali.wav";
            this.AudioPathReload = @"..\..\Sesler\PompaliSarjor.wav";
            this.MAxMermiSayisi = 6;
        }
        public Pompali(string silahAdi,bool durbunluMu):base(silahAdi,durbunluMu)
        {
            this.AudioPathFire = @"..\..\Sesler\Pompali.wav";
            this.AudioPathReload = @"..\..\Sesler\PompaliSarjor.wav";
            this.MAxMermiSayisi = 6;
        }
        public override string Doldur()
        {
            if (this.MermiAdet < this.MAxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet++;
                return "Pompalıya bir fişek konuldu";
            }
            else
            {
                return "Pompalının mermi full";
            }
        }

    }
}
