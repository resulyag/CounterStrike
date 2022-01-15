using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cephanem Envanter;
        private void Form1_Load(object sender, EventArgs e)
        {
            Envanter = new Cephanem();
            Envanter.MyWeapons[0] = new Bicak("Rambo");
            Envanter.MyWeapons[1] = new Tabanca("Magnum", false);
            Envanter.MyWeapons[2] = new Pompali("SuperPoze", false);
            Envanter.MyWeapons[3] = new Makinali("Uzi", true);
            Envanter.MyWeapons[4] = new Roket("Ares1", false);
            Envanter.MyWeapons[5] = new Fuze("Tank Savar", true);
            pictureBox1.Image = Envanter.SilahDegis(1);
            Form1_KeyPress(this, new KeyPressEventArgs('2'));
            this.Focus();
        }
        private void RefreshProgressBar()
        {
            progressBar1.Maximum = (Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as Atesliler).MAxMermiSayisi;
            progressBar1.Value = (Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as Atesliler).MermiAdet;
            progressBar1.Refresh();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar.ToString()) < 7 && Convert.ToInt32(e.KeyChar.ToString()) > 0)
                {
                    pictureBox1.Image = Envanter.SilahDegis(Convert.ToInt32(e.KeyChar.ToString()));
                    pictureBox1.Tag = Convert.ToInt32(e.KeyChar.ToString()) - 1;
                    if (e.KeyChar.ToString() == "1")
                    {
                        groupBoxKesiciler.Visible = true;
                        groupBoxAtesliler.Visible = false;
                        groupBoxSarjor.Visible = false;
                    }
                    else
                    {
                        groupBoxAtesliler.Visible = true;
                        groupBoxKesiciler.Visible = false;
                        groupBoxSarjor.Visible = true;
                        RefreshProgressBar();
                        if ((Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).DurbunluMu)
                        {
                            btnYakinlastir.Visible = true;
                            btnUzaklastir.Visible = true;
                        }
                        else
                        {
                            btnYakinlastir.Visible = false;
                            btnUzaklastir.Visible = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lutfen 1 ile 6 arasında seçim yapınız!!!");
                }
            }
            catch
            {
                MessageBox.Show("Lutfen 1 ile 6 arasında seçim yapınız!!!");
            }
        }

        private void btnBicakla_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IKesici).Bicakla());

        }

        private void btnBileyle_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IKesici).Bileyle());
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IAtesli).AtesEt());
            RefreshProgressBar();
        }

        private void btnYakinlastir_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).Yakinlastir());
        }

        private void btnUzaklastir_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).Uzaklastir());
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Envanter.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IAtesli).Doldur()); 
            RefreshProgressBar();
        }
    }
}
