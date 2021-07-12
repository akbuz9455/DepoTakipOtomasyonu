using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoTakipOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rdm = new Random();
        Random rdm1 = new Random();
        Random rdm2 = new Random();
        int toplam;
        int cikart;
        char c;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (c == '+')
                {
                    if (int.Parse(textBox1.Text) == toplam)
                    {
                        Form2 frm1 = new Form2();
                        frm1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş !");
                    }
                }
                else if (c == '-')
                {
                    if (int.Parse(textBox1.Text) == cikart)
                    {

                        Form2 frm1 = new Form2();
                        frm1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş !");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata "+hata.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int sayi1 = rdm.Next(1, 20);
            for (int i = 0; i < 99999; i++)
            {
                //randomda ayni sayi uzantıları bulmasın diye programimizi yavaşlatiyoruz
                //3-13 6-16 7-17 gibi gelir düzeltmezsek 

            }

            int sayi2 = rdm1.Next(1, 10);
            toplam = sayi1 + sayi2;
            cikart = sayi1 - sayi2;
            int islemim = rdm.Next(0, 2);
            if (islemim == 0)
            {
                c = '+';
            }
            else if (islemim == 1)
            {
                c = '-';
            }
            label2.Text = sayi1.ToString();
            label3.Text = c.ToString();
            label4.Text = sayi2.ToString();
        }
    }
}
