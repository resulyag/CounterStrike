using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public class Bicak : Kesiciler
    {
        public Bicak()
        {
            this.AtesliMi = false;
        }
        public Bicak(string silahAdi):base(silahAdi)
        {
            this.AtesliMi = false;
        }
    }
}
