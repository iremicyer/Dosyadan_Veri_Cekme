using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // dosya işlemleri için gerekli kütüphanedir(StreamWriter sınıfı)
using System.Text.RegularExpressions;

namespace Kişisel_Bilgi_Form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent(); //dateTimerPicher incele.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seydişehir");
            comboBox1.Items.Add("Beyşehir");
            comboBox1.Items.Add("Selçuklu");
            comboBox1.Items.Add("Karatay");
            comboBox1.Items.Add("Meram");
            comboBox1.Items.Add("Karapınar");
            comboBox1.Items.Add("Bozkır");
            comboBox1.Items.Add("Ilgın");
            comboBox1.Items.Add("Sarayönü");
            comboBox1.Items.Add("Doğanhisar");
            comboBox1.SelectedIndex = 0; // ComboBox içindeki ilk veriyi seçili getirir.

        }

        private void textBoxTcKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // TextBox'a karakter girişi engellendi.
        }

        private void textBoxAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar); // TextBox'a dışarıdan harf girişi engellendi.

        }

        private void textBoxSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxDTarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // TextBox'a karakter girişi engellendi."
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string bilgiler;
            string[] kisiselBilgi = new string[9];

            kisiselBilgi[0] = (textBoxTcKimlik.Text);

            kisiselBilgi[1] = (textBoxAd.Text);

            kisiselBilgi[2] = (textBoxSoyad.Text);

            kisiselBilgi[3] = (dateTimePicker1.Text);

            kisiselBilgi[4] = (textBoxAdres.Text);

            var result = comboBox1.SelectedValue; // ComboBox'tan seçilen veriyi bir result değişkenine atıyoruz.        
            kisiselBilgi[5] = (comboBox1.Text);

            if (radioButtonKız.Checked == true)
            {
                kisiselBilgi[6] = (radioButtonKız.Text);
            }
            if (radioButtonErkek.Checked == true)
            {
                kisiselBilgi[6] = (radioButtonErkek.Text);
            }
            if (radioButtonIlkOgretim.Checked == true)
            {
                kisiselBilgi[7] = (radioButtonIlkOgretim.Text);
            }
            if (radioButtonLise.Checked == true)
            {
                kisiselBilgi[7] = (radioButtonLise.Text);
            }
            if (radioButtonOnLisans.Checked == true)
            {
                kisiselBilgi[7] = (radioButtonOnLisans.Text);
            }
            if (radioButtonLisans.Checked == true)
            {
                kisiselBilgi[7] = (radioButtonLisans.Text);
            }
            kisiselBilgi[8] = (textBoxId.Text); 



           
            string hobi = "";

            foreach (Control kontrol in this.groupBoxHobiler.Controls)
            //for (int i = 0; i < this.groupBoxHobiler.Controls.Count; i++)
            {
                if (kontrol is CheckBox)
                {

                    if (((CheckBox)kontrol).Checked == true)
                    {
                        var d = (((CheckBox)kontrol).Text.ToString());
                        hobi += d + ",";
                    }
                }
            }
          

            string bosluk = "/ "; 
            string bosluk1 = " ";
            string eleman = kisiselBilgi[8] + bosluk1 + kisiselBilgi[0] + bosluk + kisiselBilgi[1] + bosluk + kisiselBilgi[2] + bosluk + kisiselBilgi[3] + bosluk + kisiselBilgi[4] + bosluk + kisiselBilgi[5] + bosluk + kisiselBilgi[6] + bosluk + kisiselBilgi[7] + bosluk + hobi;
            listBox1.Items.Add(eleman);
        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        // dosyaya kaydetme
        private void buttonDosyaKaydet_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0) /* listBox bir dizi gibi çalıştığı için "listBox1.Text" yazarsak görmez ve hata verir. 
                                            bu yüzden Count yapmalıyız.*/
            {
                listBox1.BackColor = Color.Green;

                MessageBox.Show(" Dosya Kaydedilemedi !! \n ListBox'ın içi boş");
            }
            else
            {
                StreamWriter SW = new StreamWriter("C:\\dosyayaKaydet.txt");

                foreach (var veriler in listBox1.Items) // listBox^taki bütüm verileri teker teker dosyaya kaydeden döngü.
                {
                    SW.WriteLine(veriler.ToString());
                }
                SW.Close();


                MessageBox.Show("Kayıtlar Başarıyla Eklendi");
            }
        }

        private void buttonVarOlanKayıt_Click(object sender, EventArgs e) // Varolan kaydı getirme.
        {

            string Id;

            Id = Microsoft.VisualBasic.Interaction.InputBox("İd Numarası Giriniz:", "ID NO");

            string veriler = "";


            StreamReader SW = new StreamReader("C:\\dosyayaKaydet.txt");



            string satir;

            int sayac = 0;
            while ((satir = SW.ReadLine()) != null)
            {
                string[] veri = satir.ToString().Split(' ');

                if (veri[0] == Id)
                {
                    sayac++;
                    MessageBox.Show(satir);                 

                }
            }
            if (sayac == 0)
            {
                MessageBox.Show("Aradığınız Id ile kayıt bulunamadı!");
            }

            SW.Close();
        }

    }
}

