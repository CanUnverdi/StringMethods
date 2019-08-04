using System;
using System.Collections.Generic;
using System.Text;

namespace StringMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ornekMetin;
        private void btnCompareTo_Click(object sender, EventArgs e)
        {
           
            ornekMetin = txtGirisAlani.Text;
            int sonuc = ornekMetin.CompareTo("burak");

            MessageBox.Show(sonuc.ToString());

        }

        private void btnConstain_Click(object sender, EventArgs e)
        {
          
            ornekMetin = txtGirisAlani.Text;
            bool VarMi = ornekMetin.Contains("burak");
            MessageBox.Show(VarMi ? "Aradığınız değer bulunmaktadır" : "Aradığınız değer bulunmamaktadır");
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
          
            ornekMetin = txtGirisAlani.Text;
            bool sonuc = ornekMetin.StartsWith("burak");

            MessageBox.Show(sonuc ? "Kelime \"bur\" ile başlamaktadır" : "Kelime \"bur\" ile başlamamaktadır");
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
           
            ornekMetin = txtGirisAlani.Text;
            bool sonuc = ornekMetin.EndsWith("ak");

            MessageBox.Show(sonuc ? "Kelime \"ak\" ile bitmektedir" : "Kelime \"ak\" ile bilmektedir.");
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
           
            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.IndexOf('a');
            MessageBox.Show(index.ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
          
            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.LastIndexOf('a');
            MessageBox.Show(index.ToString());

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
       
            ornekMetin = txtGirisAlani.Text;
        
            ornekMetin = ornekMetin.Remove(3, 2);//3.index'ten başla 2 index sil


        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
           
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Replace("adam", "kadın");
            MessageBox.Show(ornekMetin);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            
            string mailAdresleri = txtGirisAlani.Text;
            string[] adresler = mailAdresleri.Split(';', ',');

            foreach (string item in adresler)
            {
                MessageBox.Show(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Insert(5, "cik");

            MessageBox.Show(ornekMetin);
        }

        private void btnLowerUpper_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            Text = ornekMetin.ToLower();
            MessageBox.Show(ornekMetin.ToUpper());
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
           
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Substring(5);

          
            ornekMetin = ornekMetin.Substring(3, 2);

            MessageBox.Show(ornekMetin);
        }

        private void btnCharray_Click(object sender, EventArgs e)
        {
           

            ornekMetin = txtGirisAlani.Text;
            char[] karakter = ornekMetin.ToCharArray();

            MessageBox.Show(karakter[5].ToString());
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
           

            ornekMetin = txtGirisAlani.Text;

            string yeniMetin = ornekMetin.Trim();

            MessageBox.Show(string.Format("Boşluklarla hesaplnankarakter sayısı: {0}\nBoşluklar temizlendikten sonra hesaplanan karakter sayısı: {1}", ornekMetin.Length, yeniMetin.Length));
        }

        private void Form1_Load(object sender, EventArgs e)
}
