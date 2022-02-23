using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._34_SOSOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox[,] tbLer;
        int siradakiOyuncu = 1;
        int satirlar = 15, sutunlar = 20;

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLer = new TextBox[satirlar, sutunlar];

            //10x10 alana TextBox kontrolleri ekleyerek oyun alanı oluşturma
            for (int i=0; i < satirlar; i++)
            {
                for(int j = 0; j < sutunlar; j++)
                {
                    TextBox tb = new TextBox();
                    tb.Location = new System.Drawing.Point(50 + j * 25, i * 25 + 50);
                    tb.Name = i + " * " + j;
                    tb.Size = new System.Drawing.Size(20, 20);
                    tb.MaxLength = 1;
                    tb.BorderStyle = BorderStyle.FixedSingle;

                    tb.KeyUp += new KeyEventHandler(tb_KeyUp);
                    this.Controls.Add(tb);
                    tbLer[i, j] = tb;
                }
            }
            button1_Click(button1, new EventArgs());
        }

        private void tb_KeyUp(object sender, KeyEventArgs e)
        {
            //Giriş yapılan kontrolü tanımlama
            TextBox tb = sender as TextBox;
            tb.Text = tb.Text.ToUpper();

            //S ve O karakteri dışında girişler temizlenerek engellenir.
            if (tb.Text != "S" && tb.Text != "O") tb.Text = "";
            if (tb.Text.Length == 1) tb.Enabled = false;
            if (tb.Enabled == false)
            {
                if (siradakiOyuncu == 1)
                    siradakiOyuncu = 2;
                else
                    siradakiOyuncu = 1;
            }

            lSiradakiOyuncu.Text = siradakiOyuncu.ToString();

            int toplamSOSSayisi = 0;

            //SOS olup olmadığı kontrol edilir.
            for(int i = 0; i < satirlar; i++)
            {
                for(int j = 0; j < sutunlar; j++)
                {
                    //soldan sağa
                    try
                    {
                        if (tbLer[i, j].Text == "S" && tbLer[i, j + 1].Text == "O" && tbLer[i, j + 2].Text == "S") toplamSOSSayisi++;
                    }
                    catch { }
                    try
                    {
                        if (tbLer[i, j].Text == "S" && tbLer[i + 1, j].Text == "O" && tbLer[i + 2, j].Text == "S") toplamSOSSayisi++;
                    }
                    catch { }
                    try
                    {
                        if(tbLer[i,j].Text == "S" && tbLer[i + 1, j - 1].Text == "O" && tbLer[i + 2,j - 2].Text == "S") toplamSOSSayisi++;
                    }
                    catch { }
                    try
                    {
                        if(tbLer[i, j].Text == "S" && tbLer[i - 1, j - 1].Text == "O" && tbLer[i - 2, j - 2].Text == "S") toplamSOSSayisi++;
                    }
                    catch { }
                }
            }
            int olusanSOSSayisi = toplamSOSSayisi - Convert.ToInt32(lToplamSOSSayisi.Text);
            lToplamSOSSayisi.Text  = toplamSOSSayisi.ToString();
            if(siradakiOyuncu == 1)
            {
                int puan = Convert.ToInt32(lBirinciOyuncuPuani.Text) + olusanSOSSayisi;
                lBirinciOyuncuPuani.Text = puan.ToString();
            }
            else
            {
                int puan = Convert.ToInt32(lIkinciOyuncuPuani.Text) + olusanSOSSayisi;
                lIkinciOyuncuPuani.Text = puan.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lBirinciOyuncuPuani.Text = "0";
            lIkinciOyuncuPuani.Text = "0";
            lToplamSOSSayisi.Text = "0";
            lSiradakiOyuncu.Text = "1";
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    (item as TextBox).Text = "";

            }
        }
    }
}
