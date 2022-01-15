using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public abstract class Silah
    {
        public string SilahAdi { get; set; }
        public bool AtesliMi { get; set; }

        public Silah()
        {

        }
        public Silah(string SilahAdi,bool AtesliMi)
        {
            this.SilahAdi = SilahAdi;
            this.AtesliMi = AtesliMi;
        }
        protected string Oldur()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"..\..\Sesler\death.wav";
            sp.PlaySync();
            return "Öldürüldü";
        }
        protected string Yarala()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"..\..\Sesler\scream.wav";
            sp.Play();
            return "Yaralandı";
        }
    }
}
