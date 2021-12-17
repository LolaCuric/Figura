
namespace Domaci_Lola_Curic_forma
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.lbl_brtemena = new System.Windows.Forms.Label();
            this.lbl_forpov = new System.Windows.Forms.Label();
            this.lbl_forob = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_brtem = new System.Windows.Forms.TextBox();
            this.txt_forpov = new System.Windows.Forms.TextBox();
            this.txt_forob = new System.Windows.Forms.TextBox();
            this.napred = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.izmeni = new System.Windows.Forms.Button();
            this.unesi = new System.Windows.Forms.Button();
            this.kraj = new System.Windows.Forms.Button();
            this.pocetak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(272, 27);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Location = new System.Drawing.Point(272, 66);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(34, 13);
            this.lbl_naziv.TabIndex = 1;
            this.lbl_naziv.Text = "Naziv";
            // 
            // lbl_brtemena
            // 
            this.lbl_brtemena.AutoSize = true;
            this.lbl_brtemena.Location = new System.Drawing.Point(272, 105);
            this.lbl_brtemena.Name = "lbl_brtemena";
            this.lbl_brtemena.Size = new System.Drawing.Size(63, 13);
            this.lbl_brtemena.TabIndex = 2;
            this.lbl_brtemena.Text = "Broj temena";
            // 
            // lbl_forpov
            // 
            this.lbl_forpov.AutoSize = true;
            this.lbl_forpov.Location = new System.Drawing.Point(272, 149);
            this.lbl_forpov.Name = "lbl_forpov";
            this.lbl_forpov.Size = new System.Drawing.Size(90, 13);
            this.lbl_forpov.TabIndex = 3;
            this.lbl_forpov.Text = "Formula- povrsina";
            // 
            // lbl_forob
            // 
            this.lbl_forob.AutoSize = true;
            this.lbl_forob.Location = new System.Drawing.Point(272, 189);
            this.lbl_forob.Name = "lbl_forob";
            this.lbl_forob.Size = new System.Drawing.Size(72, 13);
            this.lbl_forob.TabIndex = 4;
            this.lbl_forob.Text = "Formula- obim";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(368, 24);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(184, 20);
            this.txt_ID.TabIndex = 5;
            // 
            // txt_naziv
            // 
            this.txt_naziv.Location = new System.Drawing.Point(368, 63);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(184, 20);
            this.txt_naziv.TabIndex = 6;
            // 
            // txt_brtem
            // 
            this.txt_brtem.Location = new System.Drawing.Point(368, 102);
            this.txt_brtem.Name = "txt_brtem";
            this.txt_brtem.Size = new System.Drawing.Size(184, 20);
            this.txt_brtem.TabIndex = 7;
            // 
            // txt_forpov
            // 
            this.txt_forpov.Location = new System.Drawing.Point(368, 146);
            this.txt_forpov.Name = "txt_forpov";
            this.txt_forpov.Size = new System.Drawing.Size(184, 20);
            this.txt_forpov.TabIndex = 8;
            // 
            // txt_forob
            // 
            this.txt_forob.Location = new System.Drawing.Point(368, 186);
            this.txt_forob.Name = "txt_forob";
            this.txt_forob.Size = new System.Drawing.Size(184, 20);
            this.txt_forob.TabIndex = 9;
            // 
            // napred
            // 
            this.napred.Location = new System.Drawing.Point(481, 315);
            this.napred.Name = "napred";
            this.napred.Size = new System.Drawing.Size(78, 32);
            this.napred.TabIndex = 10;
            this.napred.Text = ">";
            this.napred.UseVisualStyleBackColor = true;
            this.napred.Click += new System.EventHandler(this.napred_Click);
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(368, 315);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(80, 32);
            this.nazad.TabIndex = 11;
            this.nazad.Text = "<";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // brisi
            // 
            this.brisi.Location = new System.Drawing.Point(287, 239);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(88, 40);
            this.brisi.TabIndex = 12;
            this.brisi.Text = "Brisi";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.brisi_Click);
            // 
            // izmeni
            // 
            this.izmeni.Location = new System.Drawing.Point(421, 242);
            this.izmeni.Name = "izmeni";
            this.izmeni.Size = new System.Drawing.Size(92, 36);
            this.izmeni.TabIndex = 13;
            this.izmeni.Text = "Izmeni";
            this.izmeni.UseVisualStyleBackColor = true;
            this.izmeni.Click += new System.EventHandler(this.izmeni_Click);
            // 
            // unesi
            // 
            this.unesi.Location = new System.Drawing.Point(547, 239);
            this.unesi.Name = "unesi";
            this.unesi.Size = new System.Drawing.Size(89, 39);
            this.unesi.TabIndex = 14;
            this.unesi.Text = "Unesi";
            this.unesi.UseVisualStyleBackColor = true;
            this.unesi.Click += new System.EventHandler(this.unesi_Click);
            // 
            // kraj
            // 
            this.kraj.Location = new System.Drawing.Point(574, 315);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(62, 31);
            this.kraj.TabIndex = 15;
            this.kraj.Text = ">>";
            this.kraj.UseVisualStyleBackColor = true;
            this.kraj.Click += new System.EventHandler(this.kraj_Click);
            // 
            // pocetak
            // 
            this.pocetak.Location = new System.Drawing.Point(287, 315);
            this.pocetak.Name = "pocetak";
            this.pocetak.Size = new System.Drawing.Size(61, 31);
            this.pocetak.TabIndex = 16;
            this.pocetak.Text = "<<";
            this.pocetak.UseVisualStyleBackColor = true;
            this.pocetak.Click += new System.EventHandler(this.pocetak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pocetak);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.unesi);
            this.Controls.Add(this.izmeni);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.napred);
            this.Controls.Add(this.txt_forob);
            this.Controls.Add(this.txt_forpov);
            this.Controls.Add(this.txt_brtem);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_forob);
            this.Controls.Add(this.lbl_forpov);
            this.Controls.Add(this.lbl_brtemena);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.lbl_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Label lbl_brtemena;
        private System.Windows.Forms.Label lbl_forpov;
        private System.Windows.Forms.Label lbl_forob;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_brtem;
        private System.Windows.Forms.TextBox txt_forpov;
        private System.Windows.Forms.TextBox txt_forob;
        private System.Windows.Forms.Button napred;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button izmeni;
        private System.Windows.Forms.Button unesi;
        private System.Windows.Forms.Button kraj;
        private System.Windows.Forms.Button pocetak;
    }
}

