namespace HesapMakinesi
{
    partial class frm_HesapMakinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HesapMakinesi));
            this.tb_Sonuc = new System.Windows.Forms.TextBox();
            this.btn_Esittir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Toplama = new System.Windows.Forms.Button();
            this.btn_Cikarma = new System.Windows.Forms.Button();
            this.btn_Bolme = new System.Windows.Forms.Button();
            this.btn_Carpma = new System.Windows.Forms.Button();
            this.btn_Virgul = new System.Windows.Forms.Button();
            this.btn_Uc = new System.Windows.Forms.Button();
            this.btn_Alti = new System.Windows.Forms.Button();
            this.btn_Dokuz = new System.Windows.Forms.Button();
            this.btn_Sifir = new System.Windows.Forms.Button();
            this.btn_Iki = new System.Windows.Forms.Button();
            this.btn_Bes = new System.Windows.Forms.Button();
            this.btn_Sekiz = new System.Windows.Forms.Button();
            this.btn_Bir = new System.Windows.Forms.Button();
            this.btn_Dort = new System.Windows.Forms.Button();
            this.btn_Yedi = new System.Windows.Forms.Button();
            this.lbl_IslemAkis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Sonuc
            // 
            this.tb_Sonuc.BackColor = System.Drawing.Color.LightGray;
            this.tb_Sonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Sonuc.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tb_Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Sonuc.Location = new System.Drawing.Point(12, 49);
            this.tb_Sonuc.Name = "tb_Sonuc";
            this.tb_Sonuc.ReadOnly = true;
            this.tb_Sonuc.Size = new System.Drawing.Size(529, 91);
            this.tb_Sonuc.TabIndex = 0;
            this.tb_Sonuc.Text = "0";
            this.tb_Sonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Sonuc.UseWaitCursor = true;
            this.tb_Sonuc.Enter += new System.EventHandler(this.ImlecGizle);
            // 
            // btn_Esittir
            // 
            this.btn_Esittir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Esittir.BackColor = System.Drawing.Color.White;
            this.btn_Esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Esittir.Location = new System.Drawing.Point(452, 290);
            this.btn_Esittir.Name = "btn_Esittir";
            this.btn_Esittir.Size = new System.Drawing.Size(89, 141);
            this.btn_Esittir.TabIndex = 1;
            this.btn_Esittir.Text = "=";
            this.btn_Esittir.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(452, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(452, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_Toplama
            // 
            this.btn_Toplama.BackColor = System.Drawing.Color.White;
            this.btn_Toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Toplama.Location = new System.Drawing.Point(342, 362);
            this.btn_Toplama.Name = "btn_Toplama";
            this.btn_Toplama.Size = new System.Drawing.Size(104, 69);
            this.btn_Toplama.TabIndex = 4;
            this.btn_Toplama.Text = "+";
            this.btn_Toplama.UseVisualStyleBackColor = false;
            this.btn_Toplama.Click += new System.EventHandler(this.OperatorOlay);
            // 
            // btn_Cikarma
            // 
            this.btn_Cikarma.BackColor = System.Drawing.Color.White;
            this.btn_Cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikarma.Location = new System.Drawing.Point(342, 290);
            this.btn_Cikarma.Name = "btn_Cikarma";
            this.btn_Cikarma.Size = new System.Drawing.Size(104, 66);
            this.btn_Cikarma.TabIndex = 5;
            this.btn_Cikarma.Text = "-";
            this.btn_Cikarma.UseVisualStyleBackColor = false;
            this.btn_Cikarma.Click += new System.EventHandler(this.OperatorOlay);
            // 
            // btn_Bolme
            // 
            this.btn_Bolme.BackColor = System.Drawing.Color.White;
            this.btn_Bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bolme.Location = new System.Drawing.Point(342, 218);
            this.btn_Bolme.Name = "btn_Bolme";
            this.btn_Bolme.Size = new System.Drawing.Size(104, 66);
            this.btn_Bolme.TabIndex = 6;
            this.btn_Bolme.Text = "/";
            this.btn_Bolme.UseVisualStyleBackColor = false;
            this.btn_Bolme.Click += new System.EventHandler(this.OperatorOlay);
            // 
            // btn_Carpma
            // 
            this.btn_Carpma.BackColor = System.Drawing.Color.White;
            this.btn_Carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Carpma.Location = new System.Drawing.Point(342, 146);
            this.btn_Carpma.Name = "btn_Carpma";
            this.btn_Carpma.Size = new System.Drawing.Size(104, 66);
            this.btn_Carpma.TabIndex = 7;
            this.btn_Carpma.Text = "X";
            this.btn_Carpma.UseVisualStyleBackColor = false;
            this.btn_Carpma.Click += new System.EventHandler(this.OperatorOlay);
            // 
            // btn_Virgul
            // 
            this.btn_Virgul.BackColor = System.Drawing.Color.White;
            this.btn_Virgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Virgul.Location = new System.Drawing.Point(232, 362);
            this.btn_Virgul.Name = "btn_Virgul";
            this.btn_Virgul.Size = new System.Drawing.Size(104, 69);
            this.btn_Virgul.TabIndex = 8;
            this.btn_Virgul.Text = ",";
            this.btn_Virgul.UseVisualStyleBackColor = false;
            // 
            // btn_Uc
            // 
            this.btn_Uc.BackColor = System.Drawing.Color.White;
            this.btn_Uc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Uc.Location = new System.Drawing.Point(232, 290);
            this.btn_Uc.Name = "btn_Uc";
            this.btn_Uc.Size = new System.Drawing.Size(104, 66);
            this.btn_Uc.TabIndex = 9;
            this.btn_Uc.Text = "3";
            this.btn_Uc.UseVisualStyleBackColor = false;
            this.btn_Uc.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Alti
            // 
            this.btn_Alti.BackColor = System.Drawing.Color.White;
            this.btn_Alti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Alti.Location = new System.Drawing.Point(232, 218);
            this.btn_Alti.Name = "btn_Alti";
            this.btn_Alti.Size = new System.Drawing.Size(104, 66);
            this.btn_Alti.TabIndex = 10;
            this.btn_Alti.Text = "6";
            this.btn_Alti.UseVisualStyleBackColor = false;
            this.btn_Alti.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Dokuz
            // 
            this.btn_Dokuz.BackColor = System.Drawing.Color.White;
            this.btn_Dokuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Dokuz.Location = new System.Drawing.Point(232, 146);
            this.btn_Dokuz.Name = "btn_Dokuz";
            this.btn_Dokuz.Size = new System.Drawing.Size(104, 66);
            this.btn_Dokuz.TabIndex = 11;
            this.btn_Dokuz.Text = "9";
            this.btn_Dokuz.UseVisualStyleBackColor = false;
            this.btn_Dokuz.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Sifir
            // 
            this.btn_Sifir.BackColor = System.Drawing.Color.White;
            this.btn_Sifir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sifir.Location = new System.Drawing.Point(12, 362);
            this.btn_Sifir.Name = "btn_Sifir";
            this.btn_Sifir.Size = new System.Drawing.Size(214, 69);
            this.btn_Sifir.TabIndex = 12;
            this.btn_Sifir.Text = "0";
            this.btn_Sifir.UseVisualStyleBackColor = false;
            this.btn_Sifir.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Iki
            // 
            this.btn_Iki.BackColor = System.Drawing.Color.White;
            this.btn_Iki.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Iki.Location = new System.Drawing.Point(122, 290);
            this.btn_Iki.Name = "btn_Iki";
            this.btn_Iki.Size = new System.Drawing.Size(104, 66);
            this.btn_Iki.TabIndex = 13;
            this.btn_Iki.Text = "2";
            this.btn_Iki.UseVisualStyleBackColor = false;
            this.btn_Iki.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Bes
            // 
            this.btn_Bes.BackColor = System.Drawing.Color.White;
            this.btn_Bes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bes.Location = new System.Drawing.Point(122, 218);
            this.btn_Bes.Name = "btn_Bes";
            this.btn_Bes.Size = new System.Drawing.Size(104, 66);
            this.btn_Bes.TabIndex = 14;
            this.btn_Bes.Text = "5";
            this.btn_Bes.UseVisualStyleBackColor = false;
            this.btn_Bes.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Sekiz
            // 
            this.btn_Sekiz.BackColor = System.Drawing.Color.White;
            this.btn_Sekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sekiz.Location = new System.Drawing.Point(122, 146);
            this.btn_Sekiz.Name = "btn_Sekiz";
            this.btn_Sekiz.Size = new System.Drawing.Size(104, 66);
            this.btn_Sekiz.TabIndex = 15;
            this.btn_Sekiz.Text = "8";
            this.btn_Sekiz.UseVisualStyleBackColor = false;
            this.btn_Sekiz.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Bir
            // 
            this.btn_Bir.BackColor = System.Drawing.Color.White;
            this.btn_Bir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bir.Location = new System.Drawing.Point(12, 290);
            this.btn_Bir.Name = "btn_Bir";
            this.btn_Bir.Size = new System.Drawing.Size(104, 66);
            this.btn_Bir.TabIndex = 16;
            this.btn_Bir.Text = "1";
            this.btn_Bir.UseVisualStyleBackColor = false;
            this.btn_Bir.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Dort
            // 
            this.btn_Dort.BackColor = System.Drawing.Color.White;
            this.btn_Dort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Dort.Location = new System.Drawing.Point(12, 218);
            this.btn_Dort.Name = "btn_Dort";
            this.btn_Dort.Size = new System.Drawing.Size(104, 66);
            this.btn_Dort.TabIndex = 17;
            this.btn_Dort.Text = "4";
            this.btn_Dort.UseVisualStyleBackColor = false;
            this.btn_Dort.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_Yedi
            // 
            this.btn_Yedi.BackColor = System.Drawing.Color.White;
            this.btn_Yedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yedi.Location = new System.Drawing.Point(12, 146);
            this.btn_Yedi.Name = "btn_Yedi";
            this.btn_Yedi.Size = new System.Drawing.Size(104, 66);
            this.btn_Yedi.TabIndex = 18;
            this.btn_Yedi.Text = "7";
            this.btn_Yedi.UseVisualStyleBackColor = false;
            this.btn_Yedi.Click += new System.EventHandler(this.RakamOlay);
            // 
            // lbl_IslemAkis
            // 
            this.lbl_IslemAkis.AutoSize = true;
            this.lbl_IslemAkis.Location = new System.Drawing.Point(539, 30);
            this.lbl_IslemAkis.Name = "lbl_IslemAkis";
            this.lbl_IslemAkis.Size = new System.Drawing.Size(0, 16);
            this.lbl_IslemAkis.TabIndex = 19;
            // 
            // frm_HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(553, 443);
            this.Controls.Add(this.lbl_IslemAkis);
            this.Controls.Add(this.btn_Yedi);
            this.Controls.Add(this.btn_Dort);
            this.Controls.Add(this.btn_Bir);
            this.Controls.Add(this.btn_Sekiz);
            this.Controls.Add(this.btn_Bes);
            this.Controls.Add(this.btn_Iki);
            this.Controls.Add(this.btn_Sifir);
            this.Controls.Add(this.btn_Dokuz);
            this.Controls.Add(this.btn_Alti);
            this.Controls.Add(this.btn_Uc);
            this.Controls.Add(this.btn_Virgul);
            this.Controls.Add(this.btn_Carpma);
            this.Controls.Add(this.btn_Bolme);
            this.Controls.Add(this.btn_Cikarma);
            this.Controls.Add(this.btn_Toplama);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Esittir);
            this.Controls.Add(this.tb_Sonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HesapMakinesi";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.frm_HesapMakinesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Sonuc;
        private System.Windows.Forms.Button btn_Esittir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Toplama;
        private System.Windows.Forms.Button btn_Cikarma;
        private System.Windows.Forms.Button btn_Bolme;
        private System.Windows.Forms.Button btn_Carpma;
        private System.Windows.Forms.Button btn_Virgul;
        private System.Windows.Forms.Button btn_Uc;
        private System.Windows.Forms.Button btn_Alti;
        private System.Windows.Forms.Button btn_Dokuz;
        private System.Windows.Forms.Button btn_Sifir;
        private System.Windows.Forms.Button btn_Iki;
        private System.Windows.Forms.Button btn_Bes;
        private System.Windows.Forms.Button btn_Sekiz;
        private System.Windows.Forms.Button btn_Bir;
        private System.Windows.Forms.Button btn_Dort;
        private System.Windows.Forms.Button btn_Yedi;
        private System.Windows.Forms.Label lbl_IslemAkis;
    }
}

