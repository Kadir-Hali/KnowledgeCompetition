﻿using System;
using System.Windows.Forms;

namespace KnowledgeCompetition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int soruNo = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnİleri.Enabled = true;

            label5.Text = BtnB.Text;
            if (LblDogruCevap.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnİleri.Enabled = true;

            label5.Text = BtnC.Text;
            if (LblDogruCevap.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnİleri.Enabled = true;

            label5.Text = BtnD.Text;
            if (LblDogruCevap.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnİleri.Enabled = true;

            label5.Text = BtnA.Text;
            if (LblDogruCevap.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Btnİleri_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            Btnİleri.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            LblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                LblDogruCevap.Text = "1923";
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Attila İlhan";
                BtnD.Text = "Reşat Nuri";
                LblDogruCevap.Text = "Sait Faik";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Hangi ilimiz Ege bölgesinde yer almaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Antalya";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                LblDogruCevap.Text = "Antalya";
                Btnİleri.Text = "Sonuçlar";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Yarışma Sonlanmıştır...";
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                Btnİleri.Enabled = false;
                MessageBox.Show("Doğru : " + dogru + "\n" + "Yanlış : " + yanlis);
            }
        }
    }
}