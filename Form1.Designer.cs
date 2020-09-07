namespace Kişisel_Bilgi_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTcKimlik = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelIlce = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.groupBoxKisiselBilgi = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelDTarih = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTcKimlik = new System.Windows.Forms.TextBox();
            this.labelıd = new System.Windows.Forms.Label();
            this.groupBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.radioButtonKız = new System.Windows.Forms.RadioButton();
            this.groupBoxEgitimDurum = new System.Windows.Forms.GroupBox();
            this.radioButtonOnLisans = new System.Windows.Forms.RadioButton();
            this.radioButtonLisans = new System.Windows.Forms.RadioButton();
            this.radioButtonLise = new System.Windows.Forms.RadioButton();
            this.radioButtonIlkOgretim = new System.Windows.Forms.RadioButton();
            this.groupBoxHobiler = new System.Windows.Forms.GroupBox();
            this.checkBox1Resim = new System.Windows.Forms.CheckBox();
            this.checkBoxKitapO = new System.Windows.Forms.CheckBox();
            this.checkBoxOyun = new System.Windows.Forms.CheckBox();
            this.checkBoxSeyahat = new System.Windows.Forms.CheckBox();
            this.checkBoxResim = new System.Windows.Forms.CheckBox();
            this.checkBoxSpor = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonVarOlanKayıt = new System.Windows.Forms.Button();
            this.buttonDosyaKaydet = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.groupBoxKisiselBilgi.SuspendLayout();
            this.groupBoxCinsiyet.SuspendLayout();
            this.groupBoxEgitimDurum.SuspendLayout();
            this.groupBoxHobiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTcKimlik
            // 
            this.labelTcKimlik.AutoSize = true;
            this.labelTcKimlik.BackColor = System.Drawing.Color.AliceBlue;
            this.labelTcKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTcKimlik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTcKimlik.Location = new System.Drawing.Point(31, 80);
            this.labelTcKimlik.Name = "labelTcKimlik";
            this.labelTcKimlik.Size = new System.Drawing.Size(85, 16);
            this.labelTcKimlik.TabIndex = 0;
            this.labelTcKimlik.Text = "TC Kimlik No";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.BackColor = System.Drawing.Color.AliceBlue;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(31, 121);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(28, 16);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Adı";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.BackColor = System.Drawing.Color.AliceBlue;
            this.labelSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.Location = new System.Drawing.Point(31, 155);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(53, 18);
            this.labelSoyad.TabIndex = 0;
            this.labelSoyad.Text = "Soyadı";
            // 
            // labelIlce
            // 
            this.labelIlce.AutoSize = true;
            this.labelIlce.BackColor = System.Drawing.Color.AliceBlue;
            this.labelIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIlce.Location = new System.Drawing.Point(364, 193);
            this.labelIlce.Name = "labelIlce";
            this.labelIlce.Size = new System.Drawing.Size(30, 18);
            this.labelIlce.TabIndex = 0;
            this.labelIlce.Text = "İlçe";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.BackColor = System.Drawing.Color.AliceBlue;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres.Location = new System.Drawing.Point(348, 43);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(46, 18);
            this.labelAdres.TabIndex = 0;
            this.labelAdres.Text = "Adres";
            // 
            // groupBoxKisiselBilgi
            // 
            this.groupBoxKisiselBilgi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxKisiselBilgi.Controls.Add(this.dateTimePicker1);
            this.groupBoxKisiselBilgi.Controls.Add(this.comboBox1);
            this.groupBoxKisiselBilgi.Controls.Add(this.labelAdres);
            this.groupBoxKisiselBilgi.Controls.Add(this.textBoxSoyad);
            this.groupBoxKisiselBilgi.Controls.Add(this.textBoxAdres);
            this.groupBoxKisiselBilgi.Controls.Add(this.textBoxAd);
            this.groupBoxKisiselBilgi.Controls.Add(this.labelDTarih);
            this.groupBoxKisiselBilgi.Controls.Add(this.labelIlce);
            this.groupBoxKisiselBilgi.Controls.Add(this.textBoxId);
            this.groupBoxKisiselBilgi.Controls.Add(this.textBoxTcKimlik);
            this.groupBoxKisiselBilgi.Controls.Add(this.labelTcKimlik);
            this.groupBoxKisiselBilgi.Controls.Add(this.labelSoyad);
            this.groupBoxKisiselBilgi.Controls.Add(this.labelıd);
            this.groupBoxKisiselBilgi.Controls.Add(this.labelAd);
            this.groupBoxKisiselBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKisiselBilgi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKisiselBilgi.Name = "groupBoxKisiselBilgi";
            this.groupBoxKisiselBilgi.Size = new System.Drawing.Size(678, 240);
            this.groupBoxKisiselBilgi.TabIndex = 1;
            this.groupBoxKisiselBilgi.TabStop = false;
            this.groupBoxKisiselBilgi.Text = "Kişisel Bilgiler";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(140, 146);
            this.textBoxSoyad.Multiline = true;
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(123, 27);
            this.textBoxSoyad.TabIndex = 1;
            this.textBoxSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoyad_KeyPress);
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdres.Location = new System.Drawing.Point(418, 43);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(219, 130);
            this.textBoxAdres.TabIndex = 1;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(140, 110);
            this.textBoxAd.Multiline = true;
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(123, 27);
            this.textBoxAd.TabIndex = 1;
            this.textBoxAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdı_KeyPress);
            // 
            // labelDTarih
            // 
            this.labelDTarih.AutoSize = true;
            this.labelDTarih.BackColor = System.Drawing.Color.AliceBlue;
            this.labelDTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDTarih.Location = new System.Drawing.Point(31, 194);
            this.labelDTarih.Name = "labelDTarih";
            this.labelDTarih.Size = new System.Drawing.Size(97, 18);
            this.labelDTarih.TabIndex = 0;
            this.labelDTarih.Text = "Doğum Tarihi";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxId.Location = new System.Drawing.Point(140, 34);
            this.textBoxId.MaxLength = 11;
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(123, 27);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTcKimlik_KeyPress);
            // 
            // textBoxTcKimlik
            // 
            this.textBoxTcKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTcKimlik.Location = new System.Drawing.Point(140, 69);
            this.textBoxTcKimlik.MaxLength = 11;
            this.textBoxTcKimlik.Multiline = true;
            this.textBoxTcKimlik.Name = "textBoxTcKimlik";
            this.textBoxTcKimlik.Size = new System.Drawing.Size(123, 27);
            this.textBoxTcKimlik.TabIndex = 1;
            this.textBoxTcKimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTcKimlik_KeyPress);
            // 
            // labelıd
            // 
            this.labelıd.AutoSize = true;
            this.labelıd.BackColor = System.Drawing.Color.AliceBlue;
            this.labelıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelıd.Location = new System.Drawing.Point(31, 43);
            this.labelıd.Name = "labelıd";
            this.labelıd.Size = new System.Drawing.Size(21, 16);
            this.labelıd.TabIndex = 0;
            this.labelıd.Text = "ID";
            // 
            // groupBoxCinsiyet
            // 
            this.groupBoxCinsiyet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxCinsiyet.Controls.Add(this.radioButtonErkek);
            this.groupBoxCinsiyet.Controls.Add(this.radioButtonKız);
            this.groupBoxCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxCinsiyet.Location = new System.Drawing.Point(12, 268);
            this.groupBoxCinsiyet.Name = "groupBoxCinsiyet";
            this.groupBoxCinsiyet.Size = new System.Drawing.Size(230, 118);
            this.groupBoxCinsiyet.TabIndex = 2;
            this.groupBoxCinsiyet.TabStop = false;
            this.groupBoxCinsiyet.Text = "Cinsiyet";
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.BackColor = System.Drawing.Color.AliceBlue;
            this.radioButtonErkek.Location = new System.Drawing.Point(66, 64);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(61, 20);
            this.radioButtonErkek.TabIndex = 0;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = false;
            // 
            // radioButtonKız
            // 
            this.radioButtonKız.AutoSize = true;
            this.radioButtonKız.BackColor = System.Drawing.Color.AliceBlue;
            this.radioButtonKız.Location = new System.Drawing.Point(66, 38);
            this.radioButtonKız.Name = "radioButtonKız";
            this.radioButtonKız.Size = new System.Drawing.Size(43, 20);
            this.radioButtonKız.TabIndex = 0;
            this.radioButtonKız.TabStop = true;
            this.radioButtonKız.Text = "Kız";
            this.radioButtonKız.UseVisualStyleBackColor = false;
            // 
            // groupBoxEgitimDurum
            // 
            this.groupBoxEgitimDurum.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxEgitimDurum.Controls.Add(this.radioButtonOnLisans);
            this.groupBoxEgitimDurum.Controls.Add(this.radioButtonLisans);
            this.groupBoxEgitimDurum.Controls.Add(this.radioButtonLise);
            this.groupBoxEgitimDurum.Controls.Add(this.radioButtonIlkOgretim);
            this.groupBoxEgitimDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxEgitimDurum.Location = new System.Drawing.Point(276, 268);
            this.groupBoxEgitimDurum.Name = "groupBoxEgitimDurum";
            this.groupBoxEgitimDurum.Size = new System.Drawing.Size(414, 118);
            this.groupBoxEgitimDurum.TabIndex = 3;
            this.groupBoxEgitimDurum.TabStop = false;
            this.groupBoxEgitimDurum.Text = "Eğitim Durumu";
            // 
            // radioButtonOnLisans
            // 
            this.radioButtonOnLisans.AutoSize = true;
            this.radioButtonOnLisans.BackColor = System.Drawing.Color.AliceBlue;
            this.radioButtonOnLisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOnLisans.Location = new System.Drawing.Point(246, 83);
            this.radioButtonOnLisans.Name = "radioButtonOnLisans";
            this.radioButtonOnLisans.Size = new System.Drawing.Size(78, 20);
            this.radioButtonOnLisans.TabIndex = 0;
            this.radioButtonOnLisans.TabStop = true;
            this.radioButtonOnLisans.Text = "Önlisans";
            this.radioButtonOnLisans.UseVisualStyleBackColor = false;
            // 
            // radioButtonLisans
            // 
            this.radioButtonLisans.AutoSize = true;
            this.radioButtonLisans.BackColor = System.Drawing.Color.AliceBlue;
            this.radioButtonLisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonLisans.Location = new System.Drawing.Point(246, 41);
            this.radioButtonLisans.Name = "radioButtonLisans";
            this.radioButtonLisans.Size = new System.Drawing.Size(65, 20);
            this.radioButtonLisans.TabIndex = 0;
            this.radioButtonLisans.TabStop = true;
            this.radioButtonLisans.Text = "Lisans";
            this.radioButtonLisans.UseVisualStyleBackColor = false;
            // 
            // radioButtonLise
            // 
            this.radioButtonLise.AutoSize = true;
            this.radioButtonLise.BackColor = System.Drawing.Color.AliceBlue;
            this.radioButtonLise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonLise.Location = new System.Drawing.Point(103, 83);
            this.radioButtonLise.Name = "radioButtonLise";
            this.radioButtonLise.Size = new System.Drawing.Size(51, 20);
            this.radioButtonLise.TabIndex = 0;
            this.radioButtonLise.TabStop = true;
            this.radioButtonLise.Text = "Lise";
            this.radioButtonLise.UseVisualStyleBackColor = false;
            // 
            // radioButtonIlkOgretim
            // 
            this.radioButtonIlkOgretim.AutoSize = true;
            this.radioButtonIlkOgretim.BackColor = System.Drawing.Color.AliceBlue;
            this.radioButtonIlkOgretim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonIlkOgretim.Location = new System.Drawing.Point(103, 38);
            this.radioButtonIlkOgretim.Name = "radioButtonIlkOgretim";
            this.radioButtonIlkOgretim.Size = new System.Drawing.Size(89, 20);
            this.radioButtonIlkOgretim.TabIndex = 0;
            this.radioButtonIlkOgretim.TabStop = true;
            this.radioButtonIlkOgretim.Text = "İlk Öğretim";
            this.radioButtonIlkOgretim.UseVisualStyleBackColor = false;
            // 
            // groupBoxHobiler
            // 
            this.groupBoxHobiler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxHobiler.Controls.Add(this.checkBox1Resim);
            this.groupBoxHobiler.Controls.Add(this.checkBoxKitapO);
            this.groupBoxHobiler.Controls.Add(this.checkBoxOyun);
            this.groupBoxHobiler.Controls.Add(this.checkBoxSeyahat);
            this.groupBoxHobiler.Controls.Add(this.checkBoxResim);
            this.groupBoxHobiler.Controls.Add(this.checkBoxSpor);
            this.groupBoxHobiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxHobiler.Location = new System.Drawing.Point(12, 402);
            this.groupBoxHobiler.Name = "groupBoxHobiler";
            this.groupBoxHobiler.Size = new System.Drawing.Size(533, 103);
            this.groupBoxHobiler.TabIndex = 4;
            this.groupBoxHobiler.TabStop = false;
            this.groupBoxHobiler.Text = "Hobiler";
            // 
            // checkBox1Resim
            // 
            this.checkBox1Resim.AutoSize = true;
            this.checkBox1Resim.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBox1Resim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1Resim.Location = new System.Drawing.Point(308, 73);
            this.checkBox1Resim.Name = "checkBox1Resim";
            this.checkBox1Resim.Size = new System.Drawing.Size(61, 20);
            this.checkBox1Resim.TabIndex = 1;
            this.checkBox1Resim.Text = "Müzik";
            this.checkBox1Resim.UseVisualStyleBackColor = false;
            // 
            // checkBoxKitapO
            // 
            this.checkBoxKitapO.AutoSize = true;
            this.checkBoxKitapO.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxKitapO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxKitapO.Location = new System.Drawing.Point(308, 31);
            this.checkBoxKitapO.Name = "checkBoxKitapO";
            this.checkBoxKitapO.Size = new System.Drawing.Size(103, 20);
            this.checkBoxKitapO.TabIndex = 0;
            this.checkBoxKitapO.Text = "Kitap Okuma";
            this.checkBoxKitapO.UseVisualStyleBackColor = false;
            // 
            // checkBoxOyun
            // 
            this.checkBoxOyun.AutoSize = true;
            this.checkBoxOyun.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOyun.Location = new System.Drawing.Point(166, 73);
            this.checkBoxOyun.Name = "checkBoxOyun";
            this.checkBoxOyun.Size = new System.Drawing.Size(58, 20);
            this.checkBoxOyun.TabIndex = 0;
            this.checkBoxOyun.Text = "Oyun";
            this.checkBoxOyun.UseVisualStyleBackColor = false;
            // 
            // checkBoxSeyahat
            // 
            this.checkBoxSeyahat.AutoSize = true;
            this.checkBoxSeyahat.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxSeyahat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSeyahat.Location = new System.Drawing.Point(166, 31);
            this.checkBoxSeyahat.Name = "checkBoxSeyahat";
            this.checkBoxSeyahat.Size = new System.Drawing.Size(77, 20);
            this.checkBoxSeyahat.TabIndex = 0;
            this.checkBoxSeyahat.Text = "Seyahat";
            this.checkBoxSeyahat.UseVisualStyleBackColor = false;
            // 
            // checkBoxResim
            // 
            this.checkBoxResim.AutoSize = true;
            this.checkBoxResim.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxResim.Location = new System.Drawing.Point(34, 73);
            this.checkBoxResim.Name = "checkBoxResim";
            this.checkBoxResim.Size = new System.Drawing.Size(66, 20);
            this.checkBoxResim.TabIndex = 0;
            this.checkBoxResim.Text = "Resim";
            this.checkBoxResim.UseVisualStyleBackColor = false;
            // 
            // checkBoxSpor
            // 
            this.checkBoxSpor.AutoSize = true;
            this.checkBoxSpor.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxSpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSpor.Location = new System.Drawing.Point(34, 31);
            this.checkBoxSpor.Name = "checkBoxSpor";
            this.checkBoxSpor.Size = new System.Drawing.Size(56, 20);
            this.checkBoxSpor.TabIndex = 0;
            this.checkBoxSpor.Text = "Spor";
            this.checkBoxSpor.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Silver;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.Location = new System.Drawing.Point(580, 402);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 103);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "ListBoxa Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 522);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(678, 121);
            this.listBox1.TabIndex = 6;
            // 
            // buttonVarOlanKayıt
            // 
            this.buttonVarOlanKayıt.BackColor = System.Drawing.Color.Silver;
            this.buttonVarOlanKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVarOlanKayıt.Image = ((System.Drawing.Image)(resources.GetObject("buttonVarOlanKayıt.Image")));
            this.buttonVarOlanKayıt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVarOlanKayıt.Location = new System.Drawing.Point(580, 659);
            this.buttonVarOlanKayıt.Name = "buttonVarOlanKayıt";
            this.buttonVarOlanKayıt.Size = new System.Drawing.Size(110, 99);
            this.buttonVarOlanKayıt.TabIndex = 7;
            this.buttonVarOlanKayıt.Text = "Varolan Kaydı Getir";
            this.buttonVarOlanKayıt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVarOlanKayıt.UseVisualStyleBackColor = false;
            this.buttonVarOlanKayıt.Click += new System.EventHandler(this.buttonVarOlanKayıt_Click);
            // 
            // buttonDosyaKaydet
            // 
            this.buttonDosyaKaydet.BackColor = System.Drawing.Color.Silver;
            this.buttonDosyaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDosyaKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonDosyaKaydet.Image")));
            this.buttonDosyaKaydet.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDosyaKaydet.Location = new System.Drawing.Point(320, 659);
            this.buttonDosyaKaydet.Name = "buttonDosyaKaydet";
            this.buttonDosyaKaydet.Size = new System.Drawing.Size(110, 99);
            this.buttonDosyaKaydet.TabIndex = 7;
            this.buttonDosyaKaydet.Text = "Dosyaya Kaydet";
            this.buttonDosyaKaydet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDosyaKaydet.UseVisualStyleBackColor = false;
            this.buttonDosyaKaydet.Click += new System.EventHandler(this.buttonDosyaKaydet_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.Silver;
            this.buttonTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTemizle.Location = new System.Drawing.Point(437, 659);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(108, 99);
            this.buttonTemizle.TabIndex = 7;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(702, 785);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonDosyaKaydet);
            this.Controls.Add(this.buttonVarOlanKayıt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBoxHobiler);
            this.Controls.Add(this.groupBoxEgitimDurum);
            this.Controls.Add(this.groupBoxCinsiyet);
            this.Controls.Add(this.groupBoxKisiselBilgi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Kişisel Bilgiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxKisiselBilgi.ResumeLayout(false);
            this.groupBoxKisiselBilgi.PerformLayout();
            this.groupBoxCinsiyet.ResumeLayout(false);
            this.groupBoxCinsiyet.PerformLayout();
            this.groupBoxEgitimDurum.ResumeLayout(false);
            this.groupBoxEgitimDurum.PerformLayout();
            this.groupBoxHobiler.ResumeLayout(false);
            this.groupBoxHobiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTcKimlik;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelIlce;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.GroupBox groupBoxKisiselBilgi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelDTarih;
        private System.Windows.Forms.TextBox textBoxTcKimlik;
        private System.Windows.Forms.GroupBox groupBoxCinsiyet;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.RadioButton radioButtonKız;
        private System.Windows.Forms.GroupBox groupBoxEgitimDurum;
        private System.Windows.Forms.RadioButton radioButtonOnLisans;
        private System.Windows.Forms.RadioButton radioButtonLisans;
        private System.Windows.Forms.RadioButton radioButtonLise;
        private System.Windows.Forms.RadioButton radioButtonIlkOgretim;
        private System.Windows.Forms.GroupBox groupBoxHobiler;
        private System.Windows.Forms.CheckBox checkBox1Resim;
        private System.Windows.Forms.CheckBox checkBoxKitapO;
        private System.Windows.Forms.CheckBox checkBoxOyun;
        private System.Windows.Forms.CheckBox checkBoxSeyahat;
        private System.Windows.Forms.CheckBox checkBoxResim;
        private System.Windows.Forms.CheckBox checkBoxSpor;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonVarOlanKayıt;
        private System.Windows.Forms.Button buttonDosyaKaydet;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelıd;
    }
}

