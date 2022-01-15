using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public class Fuze:Atesliler
    {
        public Fuze():base()
        {
            this.AudioPathFire = @"..\..\Sesler\TopAtis.wav";
            this.AudioPathReload = @"..\..\Sesler\Taramali2.wav";
            this.MAxMermiSayisi = 1;
        }
        public Fuze(string silahAdi,bool durbunluMu):base(silahAdi,durbunluMu)
        {
            this.AudioPathFire = @"..\..\Sesler\TopAtis.wav";
            this.AudioPathReload = @"..\..\Sesler\Taramali2.wav";
            this.MAxMermiSayisi = 1;
        }
        public override string Doldur()
        {
            return "";
        }
    }
}
