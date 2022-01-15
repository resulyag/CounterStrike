namespace CounterStrike
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxKesiciler = new System.Windows.Forms.GroupBox();
            this.btnBileyle = new System.Windows.Forms.Button();
            this.btnBicakla = new System.Windows.Forms.Button();
            this.groupBoxAtesliler = new System.Windows.Forms.GroupBox();
            this.btnUzaklastir = new System.Windows.Forms.Button();
            this.btnYakinlastir = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblsayigirinUyari = new System.Windows.Forms.Label();
            this.groupBoxSarjor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxKesiciler.SuspendLayout();
            this.groupBoxAtesliler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxSarjor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 265);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxKesiciler
            // 
            this.groupBoxKesiciler.Controls.Add(this.btnBileyle);
            this.groupBoxKesiciler.Controls.Add(this.btnBicakla);
            this.groupBoxKesiciler.Location = new System.Drawing.Point(12, 312);
            this.groupBoxKesiciler.Name = "groupBoxKesiciler";
            this.groupBoxKesiciler.Size = new System.Drawing.Size(165, 177);
            this.groupBoxKesiciler.TabIndex = 1;
            this.groupBoxKesiciler.TabStop = false;
            this.groupBoxKesiciler.Text = "Kesiciler";
            // 
            // btnBileyle
            // 
            this.btnBileyle.Location = new System.Drawing.Point(27, 84);
            this.btnBileyle.Name = "btnBileyle";
            this.btnBileyle.Size = new System.Drawing.Size(87, 34);
            this.btnBileyle.TabIndex = 1;
            this.btnBileyle.Text = "Bileyle";
            this.btnBileyle.UseVisualStyleBackColor = true;
            this.btnBileyle.Click += new System.EventHandler(this.btnBileyle_Click);
            // 
            // btnBicakla
            // 
            this.btnBicakla.Location = new System.Drawing.Point(27, 26);
            this.btnBicakla.Name = "btnBicakla";
            this.btnBicakla.Size = new System.Drawing.Size(87, 34);
            this.btnBicakla.TabIndex = 0;
            this.btnBicakla.Text = "Bıçakla";
            this.btnBicakla.UseVisualStyleBackColor = true;
            this.btnBicakla.Click += new System.EventHandler(this.btnBicakla_Click);
            // 
            // groupBoxAtesliler
            // 
            this.groupBoxAtesliler.Controls.Add(this.btnUzaklastir);
            this.groupBoxAtesliler.Controls.Add(this.btnYakinlastir);
            this.groupBoxAtesliler.Controls.Add(this.btnReload);
            this.groupBoxAtesliler.Controls.Add(this.btnAtesEt);
            this.groupBoxAtesliler.Location = new System.Drawing.Point(183, 312);
            this.groupBoxAtesliler.Name = "groupBoxAtesliler";
            this.groupBoxAtesliler.Size = new System.Drawing.Size(203, 177);
            this.groupBoxAtesliler.TabIndex = 2;
            this.groupBoxAtesliler.TabStop = false;
            this.groupBoxAtesliler.Text = "Ateşliler";
            // 
            // btnUzaklastir
            // 
            this.btnUzaklastir.Location = new System.Drawing.Point(110, 84);
            this.btnUzaklastir.Name = "btnUzaklastir";
            this.btnUzaklastir.Size = new System.Drawing.Size(87, 34);
            this.btnUzaklastir.TabIndex = 5;
            this.btnUzaklastir.Text = "Uzaklaştır";
            this.btnUzaklastir.UseVisualStyleBackColor = true;
            this.btnUzaklastir.Click += new System.EventHandler(this.btnUzaklastir_Click);
            // 
            // btnYakinlastir
            // 
            this.btnYakinlastir.Location = new System.Drawing.Point(110, 26);
            this.btnYakinlastir.Name = "btnYakinlastir";
            this.btnYakinlastir.Size = new System.Drawing.Size(87, 34);
            this.btnYakinlastir.TabIndex = 4;
            this.btnYakinlastir.Text = "Yakınlaştır";
            this.btnYakinlastir.UseVisualStyleBackColor = true;
            this.btnYakinlastir.Click += new System.EventHandler(this.btnYakinlastir_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(6, 84);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(87, 34);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Location = new System.Drawing.Point(6, 26);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(87, 34);
            this.btnAtesEt.TabIndex = 2;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CounterStrike.Properties.Resources.ammo;
            this.pictureBox2.Location = new System.Drawing.Point(18, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(66, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(135, 34);
            this.progressBar1.TabIndex = 4;
            // 
            // lblsayigirinUyari
            // 
            this.lblsayigirinUyari.AutoSize = true;
            this.lblsayigirinUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayigirinUyari.Location = new System.Drawing.Point(185, 9);
            this.lblsayigirinUyari.Name = "lblsayigirinUyari";
            this.lblsayigirinUyari.Size = new System.Drawing.Size(261, 20);
            this.lblsayigirinUyari.TabIndex = 5;
            this.lblsayigirinUyari.Text = "Lütfen 1 ile 6 arasında bir sayı giriniz";
            // 
            // groupBoxSarjor
            // 
            this.groupBoxSarjor.Controls.Add(this.pictureBox2);
            this.groupBoxSarjor.Controls.Add(this.progressBar1);
            this.groupBoxSarjor.Location = new System.Drawing.Point(392, 312);
            this.groupBoxSarjor.Name = "groupBoxSarjor";
            this.groupBoxSarjor.Size = new System.Drawing.Size(207, 100);
            this.groupBoxSarjor.TabIndex = 6;
            this.groupBoxSarjor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 501);
            this.Controls.Add(this.groupBoxSarjor);
            this.Controls.Add(this.lblsayigirinUyari);
            this.Controls.Add(this.groupBoxAtesliler);
            this.Controls.Add(this.groupBoxKesiciler);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxKesiciler.ResumeLayout(false);
            this.groupBoxAtesliler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxSarjor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxKesiciler;
        private System.Windows.Forms.GroupBox groupBoxAtesliler;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBileyle;
        private System.Windows.Forms.Button btnBicakla;
        private System.Windows.Forms.Button btnUzaklastir;
        private System.Windows.Forms.Button btnYakinlastir;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblsayigirinUyari;
        private System.Windows.Forms.GroupBox groupBoxSarjor;
    }
}

