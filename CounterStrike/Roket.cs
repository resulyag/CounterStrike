using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public class Roket : Atesliler, IYakinlastir
    {
        public Roket():base()
        {
            this.AudioPathFire = @"..\..\Sesler\TopAtis.wav";
            this.AudioPathReload = @"..\..\Sesler\Taramali2.wav";
            this.MAxMermiSayisi = 1;
        }
        public Roket(string silahAdi,bool durbunluMu):base(silahAdi, durbunluMu)
        {
            this.AudioPathFire = @"..\..\Sesler\TopAtis.wav";
            this.AudioPathReload = @"..\..\Sesler\Taramali2.wav";
            this.MAxMermiSayisi = 1;
        }
        public override string Doldur()
        {
            if (this.MermiAdet<this.MAxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet = this.MAxMermiSayisi;
                return "Roket atışa hazır";
            }
            else
            {
                return "Roket zaten dolu";
            }
        }
    }
}
