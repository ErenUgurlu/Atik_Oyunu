namespace NDP_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBarOrgA = new System.Windows.Forms.ProgressBar();
            this.btnBsltOrg = new System.Windows.Forms.Button();
            this.lstbOrganikA = new System.Windows.Forms.ListBox();
            this.btnOrgnkA = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBarCam = new System.Windows.Forms.ProgressBar();
            this.lstbCam = new System.Windows.Forms.ListBox();
            this.btnBsltCam = new System.Windows.Forms.Button();
            this.btnCamA = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBarKgt = new System.Windows.Forms.ProgressBar();
            this.lstbKagit = new System.Windows.Forms.ListBox();
            this.btnBsltKgt = new System.Windows.Forms.Button();
            this.btnKagitA = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.lstbMetal = new System.Windows.Forms.ListBox();
            this.btnBsltMtl = new System.Windows.Forms.Button();
            this.btnMetalA = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 164);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPuan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSure);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.btnYeniOyun);
            this.panel2.Location = new System.Drawing.Point(15, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 359);
            this.panel2.TabIndex = 1;
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.Color.SpringGreen;
            this.lblPuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(13, 222);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(149, 68);
            this.lblPuan.TabIndex = 8;
            this.lblPuan.Text = "0";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(13, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "PUAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.Color.SpringGreen;
            this.lblSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(13, 117);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(149, 65);
            this.lblSure.TabIndex = 6;
            this.lblSure.Text = "60";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "SURE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(13, 293);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(149, 50);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "CIKIS";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.Location = new System.Drawing.Point(13, 14);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(149, 70);
            this.btnYeniOyun.TabIndex = 2;
            this.btnYeniOyun.Text = "YENI OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.progressBarOrgA);
            this.panel4.Controls.Add(this.btnBsltOrg);
            this.panel4.Controls.Add(this.lstbOrganikA);
            this.panel4.Controls.Add(this.btnOrgnkA);
            this.panel4.Location = new System.Drawing.Point(197, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 238);
            this.panel4.TabIndex = 3;
            // 
            // progressBarOrgA
            // 
            this.progressBarOrgA.Location = new System.Drawing.Point(4, 181);
            this.progressBarOrgA.Name = "progressBarOrgA";
            this.progressBarOrgA.Size = new System.Drawing.Size(125, 23);
            this.progressBarOrgA.TabIndex = 5;
            // 
            // btnBsltOrg
            // 
            this.btnBsltOrg.Enabled = false;
            this.btnBsltOrg.Location = new System.Drawing.Point(3, 210);
            this.btnBsltOrg.Name = "btnBsltOrg";
            this.btnBsltOrg.Size = new System.Drawing.Size(126, 23);
            this.btnBsltOrg.TabIndex = 2;
            this.btnBsltOrg.Text = "BOSALT";
            this.btnBsltOrg.UseVisualStyleBackColor = true;
            this.btnBsltOrg.Click += new System.EventHandler(this.btnBsltOrg_Click);
            // 
            // lstbOrganikA
            // 
            this.lstbOrganikA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbOrganikA.FormattingEnabled = true;
            this.lstbOrganikA.Location = new System.Drawing.Point(3, 29);
            this.lstbOrganikA.Name = "lstbOrganikA";
            this.lstbOrganikA.Size = new System.Drawing.Size(126, 147);
            this.lstbOrganikA.TabIndex = 1;
            // 
            // btnOrgnkA
            // 
            this.btnOrgnkA.Enabled = false;
            this.btnOrgnkA.Location = new System.Drawing.Point(3, 3);
            this.btnOrgnkA.Name = "btnOrgnkA";
            this.btnOrgnkA.Size = new System.Drawing.Size(126, 23);
            this.btnOrgnkA.TabIndex = 0;
            this.btnOrgnkA.Text = "ORGANIK ATIK";
            this.btnOrgnkA.UseVisualStyleBackColor = true;
            this.btnOrgnkA.Click += new System.EventHandler(this.btnOrgnkA_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.progressBarCam);
            this.panel3.Controls.Add(this.lstbCam);
            this.panel3.Controls.Add(this.btnBsltCam);
            this.panel3.Controls.Add(this.btnCamA);
            this.panel3.Location = new System.Drawing.Point(198, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 241);
            this.panel3.TabIndex = 4;
            // 
            // progressBarCam
            // 
            this.progressBarCam.Location = new System.Drawing.Point(3, 184);
            this.progressBarCam.Name = "progressBarCam";
            this.progressBarCam.Size = new System.Drawing.Size(125, 23);
            this.progressBarCam.TabIndex = 4;
            // 
            // lstbCam
            // 
            this.lstbCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbCam.FormattingEnabled = true;
            this.lstbCam.Location = new System.Drawing.Point(3, 32);
            this.lstbCam.Name = "lstbCam";
            this.lstbCam.Size = new System.Drawing.Size(126, 147);
            this.lstbCam.TabIndex = 3;
            // 
            // btnBsltCam
            // 
            this.btnBsltCam.Enabled = false;
            this.btnBsltCam.Location = new System.Drawing.Point(3, 213);
            this.btnBsltCam.Name = "btnBsltCam";
            this.btnBsltCam.Size = new System.Drawing.Size(126, 23);
            this.btnBsltCam.TabIndex = 2;
            this.btnBsltCam.Text = "BOSALT";
            this.btnBsltCam.UseVisualStyleBackColor = true;
            this.btnBsltCam.Click += new System.EventHandler(this.btnBsltCam_Click);
            // 
            // btnCamA
            // 
            this.btnCamA.Enabled = false;
            this.btnCamA.Location = new System.Drawing.Point(2, 3);
            this.btnCamA.Name = "btnCamA";
            this.btnCamA.Size = new System.Drawing.Size(126, 23);
            this.btnCamA.TabIndex = 1;
            this.btnCamA.Text = "CAM";
            this.btnCamA.UseVisualStyleBackColor = true;
            this.btnCamA.Click += new System.EventHandler(this.BtnCamA_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.progressBarKgt);
            this.panel5.Controls.Add(this.lstbKagit);
            this.panel5.Controls.Add(this.btnBsltKgt);
            this.panel5.Controls.Add(this.btnKagitA);
            this.panel5.Location = new System.Drawing.Point(337, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 238);
            this.panel5.TabIndex = 5;
            // 
            // progressBarKgt
            // 
            this.progressBarKgt.Location = new System.Drawing.Point(3, 182);
            this.progressBarKgt.Name = "progressBarKgt";
            this.progressBarKgt.Size = new System.Drawing.Size(125, 23);
            this.progressBarKgt.TabIndex = 5;
            // 
            // lstbKagit
            // 
            this.lstbKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbKagit.FormattingEnabled = true;
            this.lstbKagit.Location = new System.Drawing.Point(3, 29);
            this.lstbKagit.Name = "lstbKagit";
            this.lstbKagit.Size = new System.Drawing.Size(126, 147);
            this.lstbKagit.TabIndex = 3;
            // 
            // btnBsltKgt
            // 
            this.btnBsltKgt.Enabled = false;
            this.btnBsltKgt.Location = new System.Drawing.Point(3, 210);
            this.btnBsltKgt.Name = "btnBsltKgt";
            this.btnBsltKgt.Size = new System.Drawing.Size(126, 23);
            this.btnBsltKgt.TabIndex = 2;
            this.btnBsltKgt.Text = "BOSALT";
            this.btnBsltKgt.UseVisualStyleBackColor = true;
            this.btnBsltKgt.Click += new System.EventHandler(this.btnBsltKgt_Click);
            // 
            // btnKagitA
            // 
            this.btnKagitA.Enabled = false;
            this.btnKagitA.Location = new System.Drawing.Point(3, 3);
            this.btnKagitA.Name = "btnKagitA";
            this.btnKagitA.Size = new System.Drawing.Size(126, 23);
            this.btnKagitA.TabIndex = 1;
            this.btnKagitA.Text = "KAGIT";
            this.btnKagitA.UseVisualStyleBackColor = true;
            this.btnKagitA.Click += new System.EventHandler(this.btnKagitA_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.progressBarMetal);
            this.panel6.Controls.Add(this.lstbMetal);
            this.panel6.Controls.Add(this.btnBsltMtl);
            this.panel6.Controls.Add(this.btnMetalA);
            this.panel6.Location = new System.Drawing.Point(338, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 241);
            this.panel6.TabIndex = 6;
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(3, 185);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(125, 23);
            this.progressBarMetal.TabIndex = 5;
            // 
            // lstbMetal
            // 
            this.lstbMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbMetal.FormattingEnabled = true;
            this.lstbMetal.Location = new System.Drawing.Point(3, 32);
            this.lstbMetal.Name = "lstbMetal";
            this.lstbMetal.Size = new System.Drawing.Size(126, 147);
            this.lstbMetal.TabIndex = 3;
            // 
            // btnBsltMtl
            // 
            this.btnBsltMtl.Enabled = false;
            this.btnBsltMtl.Location = new System.Drawing.Point(3, 213);
            this.btnBsltMtl.Name = "btnBsltMtl";
            this.btnBsltMtl.Size = new System.Drawing.Size(126, 23);
            this.btnBsltMtl.TabIndex = 2;
            this.btnBsltMtl.Text = "BOSALT";
            this.btnBsltMtl.UseVisualStyleBackColor = true;
            this.btnBsltMtl.Click += new System.EventHandler(this.btnBsltMtl_Click);
            // 
            // btnMetalA
            // 
            this.btnMetalA.Enabled = false;
            this.btnMetalA.Location = new System.Drawing.Point(3, 3);
            this.btnMetalA.Name = "btnMetalA";
            this.btnMetalA.Size = new System.Drawing.Size(126, 23);
            this.btnMetalA.TabIndex = 1;
            this.btnMetalA.Text = "METAL";
            this.btnMetalA.UseVisualStyleBackColor = true;
            this.btnMetalA.Click += new System.EventHandler(this.BtnMetalA_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(486, 549);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBsltOrg;
        private System.Windows.Forms.ListBox lstbOrganikA;
        private System.Windows.Forms.Button btnOrgnkA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstbCam;
        private System.Windows.Forms.Button btnBsltCam;
        private System.Windows.Forms.Button btnCamA;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lstbKagit;
        private System.Windows.Forms.Button btnBsltKgt;
        private System.Windows.Forms.Button btnKagitA;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox lstbMetal;
        private System.Windows.Forms.Button btnBsltMtl;
        private System.Windows.Forms.Button btnMetalA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarOrgA;
        private System.Windows.Forms.ProgressBar progressBarCam;
        private System.Windows.Forms.ProgressBar progressBarKgt;
        private System.Windows.Forms.ProgressBar progressBarMetal;
    }
}

