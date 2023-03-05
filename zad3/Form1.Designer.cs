
namespace zad3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siec_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_prUczace = new System.Windows.Forms.Button();
            this.wagi_kon = new System.Windows.Forms.TextBox();
            this.wagi_pocz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_crSiec = new System.Windows.Forms.Button();
            this.wygWagi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.epoki = new System.Windows.Forms.TextBox();
            this.ni = new System.Windows.Forms.TextBox();
            this.beta = new System.Windows.Forms.TextBox();
            this.ucz = new System.Windows.Forms.Button();
            this.koniec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siec_text
            // 
            this.siec_text.Location = new System.Drawing.Point(12, 39);
            this.siec_text.Name = "siec_text";
            this.siec_text.Size = new System.Drawing.Size(125, 27);
            this.siec_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj sieć";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj przedział dla wag:";
            // 
            // btn_prUczace
            // 
            this.btn_prUczace.Enabled = false;
            this.btn_prUczace.Location = new System.Drawing.Point(6, 90);
            this.btn_prUczace.Name = "btn_prUczace";
            this.btn_prUczace.Size = new System.Drawing.Size(197, 29);
            this.btn_prUczace.TabIndex = 3;
            this.btn_prUczace.Text = "Wczytaj próbki uczące";
            this.btn_prUczace.UseVisualStyleBackColor = true;
            this.btn_prUczace.Click += new System.EventHandler(this.btn_prUczace_Click);
            // 
            // wagi_kon
            // 
            this.wagi_kon.Location = new System.Drawing.Point(108, 160);
            this.wagi_kon.Name = "wagi_kon";
            this.wagi_kon.Size = new System.Drawing.Size(69, 27);
            this.wagi_kon.TabIndex = 4;
            // 
            // wagi_pocz
            // 
            this.wagi_pocz.Location = new System.Drawing.Point(12, 160);
            this.wagi_pocz.Name = "wagi_pocz";
            this.wagi_pocz.Size = new System.Drawing.Size(69, 27);
            this.wagi_pocz.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // btn_crSiec
            // 
            this.btn_crSiec.Location = new System.Drawing.Point(147, 39);
            this.btn_crSiec.Name = "btn_crSiec";
            this.btn_crSiec.Size = new System.Drawing.Size(71, 29);
            this.btn_crSiec.TabIndex = 7;
            this.btn_crSiec.Text = "Utwórz";
            this.btn_crSiec.UseVisualStyleBackColor = true;
            this.btn_crSiec.Click += new System.EventHandler(this.btn_crSiec_Click);
            // 
            // wygWagi
            // 
            this.wygWagi.Enabled = false;
            this.wygWagi.Location = new System.Drawing.Point(12, 205);
            this.wygWagi.Name = "wygWagi";
            this.wygWagi.Size = new System.Drawing.Size(191, 29);
            this.wygWagi.TabIndex = 8;
            this.wygWagi.Text = "Wygeneruj wagi";
            this.wygWagi.UseVisualStyleBackColor = true;
            this.wygWagi.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Podaj liczbę epok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Podaj wsp. uczenia(ni)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Beta:";
            // 
            // epoki
            // 
            this.epoki.Location = new System.Drawing.Point(171, 260);
            this.epoki.Name = "epoki";
            this.epoki.Size = new System.Drawing.Size(47, 27);
            this.epoki.TabIndex = 13;
            // 
            // ni
            // 
            this.ni.Location = new System.Drawing.Point(171, 300);
            this.ni.Name = "ni";
            this.ni.Size = new System.Drawing.Size(47, 27);
            this.ni.TabIndex = 14;
            // 
            // beta
            // 
            this.beta.Location = new System.Drawing.Point(171, 337);
            this.beta.Name = "beta";
            this.beta.Size = new System.Drawing.Size(47, 27);
            this.beta.TabIndex = 15;
            // 
            // ucz
            // 
            this.ucz.Enabled = false;
            this.ucz.Location = new System.Drawing.Point(12, 384);
            this.ucz.Name = "ucz";
            this.ucz.Size = new System.Drawing.Size(191, 29);
            this.ucz.TabIndex = 16;
            this.ucz.Text = "Ucz";
            this.ucz.UseVisualStyleBackColor = true;
            this.ucz.Click += new System.EventHandler(this.ucz_Click);
            // 
            // koniec
            // 
            this.koniec.AutoSize = true;
            this.koniec.Location = new System.Drawing.Point(268, 23);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(50, 20);
            this.koniec.TabIndex = 17;
            this.koniec.Text = "wyniki";
            this.koniec.Click += new System.EventHandler(this.koniec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.ucz);
            this.Controls.Add(this.beta);
            this.Controls.Add(this.ni);
            this.Controls.Add(this.epoki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wygWagi);
            this.Controls.Add(this.btn_crSiec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wagi_pocz);
            this.Controls.Add(this.wagi_kon);
            this.Controls.Add(this.btn_prUczace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siec_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox siec_text;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wagi_kon;
        private System.Windows.Forms.TextBox wagi_pocz;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_crSiec;
        private System.Windows.Forms.Button wygWagi;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox epoki;
        private System.Windows.Forms.TextBox ni;
        private System.Windows.Forms.TextBox beta;
        private System.Windows.Forms.Button ucz;
        public System.Windows.Forms.Button btn_prUczace;
        public System.Windows.Forms.Label koniec;
    }
}

