using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public abstract class Atesliler : Silah, IAtesli, IYakinlastir
    {
        public bool DurbunluMu { get; set; }
        public int MermiAdet { get; set; }
        public int MAxMermiSayisi { get; set; }
        public string AudioPathFire { get; set; }
        public string AudioPathReload { get; set; }


        private Random Olasilik = new Random();
        public Atesliler() : base()
        {
            this.AtesliMi = true;
        }
        public Atesliler(string SilahAdi, bool DurbunluMu) : base
            (SilahAdi, true)
        {
            this.DurbunluMu = DurbunluMu;
            this.AtesliMi = true;
        }

        public virtual string AtesEt()
        {
            int oldururMu = Olasilik.Next(1, 3);
            if (this.MermiAdet > 0)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioPathFire;
                sp.PlaySync();
                this.MermiAdet--;
                if (oldururMu==1)
                {
                    return "Ateş edildi ve " + Yarala();
                }
                else
                {
                    return "Ateş edildi ve " + Oldur();
                }
            }
            else
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"..\..\Sesler\GunEmpty.wav";
                sp.Play();
                return "Merminiz Bitti";
            }
        }


        public abstract string Doldur();



        public string Yakinlastir()
        {
            if (this.DurbunluMu==true)
            {
                return "Yakınlaştırıldı";
            }
            else
            {
                return "Silahınız dürbünsüzdür";
            }
        }

        public string Uzaklastir()
        {
            if (this.DurbunluMu==true)
            {
                return "Uzaklaştırıldı";
            }
            else
            {
                return "Silahınız dürbünsüzdür";
            }
        }
    }
}
