using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ort_hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Liste_adSoyad = new List<string>();
        List<string> Liste_numara = new List<string>();
        List<string> Liste_vize = new List<string>();
        List<string> Liste_final = new List<string>();
        List<string> Liste_ort = new List<string>();
        List<string> Liste_durum = new List<string>();
        

        private void button1_Click(object sender, EventArgs e)
        {
            double adSoyad, numara, vize, final, ortalama;

            adSoyad = Convert.ToDouble(textBox4.Text);
            numara = Convert.ToDouble(textBox3.Text);
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            ortalama = vize * 0.4 + final * 0.6;
            labelort.Text = ortalama.ToString();
            if (ortalama > 50 || final >= 50)
            {
                labelDurum.Text = "Geçtiniz";

            }
            else
            {
                labelDurum.Text = "Kaldýnýz";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deger = textBox3.Text + " " + textBox4.Text + " " + labelort.Text + " " + labelDurum.Text;
            listBilgi.Items.Add(deger);
        }
    }
}



/*
 Kullanýcýdan vize ve final notunu textbox'lara girmesini isteyerek ortalamayý ve geçme kalma durumunu hesaplayan program
vize=%40
final=%60
geçme durumu ise ort 50 ve üstü ise geçti
ek olarak final notunun 50den küçük olmama þartý var!
 
 */

