using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public class Makinali : Atesliler, IYakinlastir
    {
        public Makinali():base()
        {
            this.AudioPathFire = @"..\..\Sesler\Taramali.wav";
            this.AudioPathReload = @"..\..\Sesler\Taramali1.wav";
            this.MAxMermiSayisi = 30;
        }
        public Makinali(string silahAdi,bool durbunluMu):base(silahAdi,durbunluMu)
        {
            this.AudioPathFire = @"..\..\Sesler\Taramali.wav";
            this.AudioPathReload = @"..\..\Sesler\Taramali1.wav";
            this.MAxMermiSayisi = 30;
        }
        public override string Doldur()
        {
            if (this.MermiAdet<this.MAxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet = this.MAxMermiSayisi;
                return " Taramalı tüfek şarjorü fullendi";
            }
            else
            {
                return "Mermi Full";
            }
        }
    }
}
