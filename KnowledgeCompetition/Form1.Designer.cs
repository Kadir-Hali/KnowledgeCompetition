namespace KnowledgeCompetition
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSoruNo = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.Btnİleri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblDogruCevap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 239);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(25, 288);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(226, 59);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(280, 288);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(226, 59);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(26, 371);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(226, 59);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(280, 371);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(226, 59);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış:";
            // 
            // LblSoruNo
            // 
            this.LblSoruNo.AutoSize = true;
            this.LblSoruNo.Location = new System.Drawing.Point(644, 36);
            this.LblSoruNo.Name = "LblSoruNo";
            this.LblSoruNo.Size = new System.Drawing.Size(24, 28);
            this.LblSoruNo.TabIndex = 8;
            this.LblSoruNo.Text = "0";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.Location = new System.Drawing.Point(644, 89);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(24, 28);
            this.LblDogru.TabIndex = 9;
            this.LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(644, 136);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(24, 28);
            this.LblYanlis.TabIndex = 10;
            this.LblYanlis.Text = "0";
            // 
            // Btnİleri
            // 
            this.Btnİleri.Location = new System.Drawing.Point(547, 205);
            this.Btnİleri.Name = "Btnİleri";
            this.Btnİleri.Size = new System.Drawing.Size(226, 59);
            this.Btnİleri.TabIndex = 11;
            this.Btnİleri.Text = "İleri";
            this.Btnİleri.UseVisualStyleBackColor = true;
            this.Btnİleri.Click += new System.EventHandler(this.Btnİleri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(649, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // LblDogruCevap
            // 
            this.LblDogruCevap.AutoSize = true;
            this.LblDogruCevap.Location = new System.Drawing.Point(718, 36);
            this.LblDogruCevap.Name = "LblDogruCevap";
            this.LblDogruCevap.Size = new System.Drawing.Size(68, 28);
            this.LblDogruCevap.TabIndex = 14;
            this.LblDogruCevap.Text = "label4";
            this.LblDogruCevap.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDogruCevap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btnİleri);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblSoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.Button Btnİleri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblDogruCevap;
        private System.Windows.Forms.Label label5;
    }
}

