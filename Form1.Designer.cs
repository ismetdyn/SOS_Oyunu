
namespace Proje5._34_SOSOyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lBirinciOyuncuPuani = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lToplamSOSSayisi = new System.Windows.Forms.Label();
            this.lIkinciOyuncuPuani = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lSiradakiOyuncu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(-1, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1066, 16);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(942, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Baştan Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birinci Oyuncu Puanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplam SOS Sayısı:";
            // 
            // lBirinciOyuncuPuani
            // 
            this.lBirinciOyuncuPuani.AutoSize = true;
            this.lBirinciOyuncuPuani.Location = new System.Drawing.Point(149, 653);
            this.lBirinciOyuncuPuani.Name = "lBirinciOyuncuPuani";
            this.lBirinciOyuncuPuani.Size = new System.Drawing.Size(44, 16);
            this.lBirinciOyuncuPuani.TabIndex = 4;
            this.lBirinciOyuncuPuani.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 653);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "İkinci Oyuncu Puanı:";
            // 
            // lToplamSOSSayisi
            // 
            this.lToplamSOSSayisi.AutoSize = true;
            this.lToplamSOSSayisi.Location = new System.Drawing.Point(586, 653);
            this.lToplamSOSSayisi.Name = "lToplamSOSSayisi";
            this.lToplamSOSSayisi.Size = new System.Drawing.Size(44, 16);
            this.lToplamSOSSayisi.TabIndex = 6;
            this.lToplamSOSSayisi.Text = "label6";
            // 
            // lIkinciOyuncuPuani
            // 
            this.lIkinciOyuncuPuani.AutoSize = true;
            this.lIkinciOyuncuPuani.Location = new System.Drawing.Point(358, 653);
            this.lIkinciOyuncuPuani.Name = "lIkinciOyuncuPuani";
            this.lIkinciOyuncuPuani.Size = new System.Drawing.Size(44, 16);
            this.lIkinciOyuncuPuani.TabIndex = 7;
            this.lIkinciOyuncuPuani.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sıradaki Oyuncu:";
            // 
            // lSiradakiOyuncu
            // 
            this.lSiradakiOyuncu.AutoSize = true;
            this.lSiradakiOyuncu.Location = new System.Drawing.Point(790, 653);
            this.lSiradakiOyuncu.Name = "lSiradakiOyuncu";
            this.lSiradakiOyuncu.Size = new System.Drawing.Size(44, 16);
            this.lSiradakiOyuncu.TabIndex = 9;
            this.lSiradakiOyuncu.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 688);
            this.Controls.Add(this.lSiradakiOyuncu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lIkinciOyuncuPuani);
            this.Controls.Add(this.lToplamSOSSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lBirinciOyuncuPuani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lBirinciOyuncuPuani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lToplamSOSSayisi;
        private System.Windows.Forms.Label lIkinciOyuncuPuani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lSiradakiOyuncu;
    }
}

