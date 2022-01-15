using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public class Tabanca : Atesliler
    {
        public Tabanca() : base()
        {
            this.AudioPathFire = @"..\..\Sesler\Tabanca.wav";
            this.AudioPathReload = @"..\..\Sesler\silah1.wav";
            this.MAxMermiSayisi = 14;
        }
        public Tabanca(string silahAdi,bool durbunluMu):base(silahAdi,durbunluMu)
        {
            this.AudioPathFire = @"..\..\Sesler\Tabanca.wav";
            this.AudioPathReload = @"..\..\Sesler\silah1.wav";
            this.MAxMermiSayisi = 14;
        }

        public override string Doldur()
        {
            if (this.MermiAdet<this.MAxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet = this.MAxMermiSayisi;
                return "Tabancaya 14 mermilik şarjor takıldı";
            }
            else
            {
                return "Tabancanın şarjoru dolu";
            }
        }
    }
}
