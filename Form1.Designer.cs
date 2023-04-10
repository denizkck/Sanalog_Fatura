namespace Ogrencıler
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ELEKTRONİK");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MOBİLYA");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("AKSESUAR");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("İŞ ALETLERİ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ÜRÜNLER", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("");
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGırısAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDevamEt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FATURA SİSTEM MERKEZİNE HOŞGELDİNİZ ";
            // 
            // TxtGırısAdı
            // 
            this.TxtGırısAdı.Location = new System.Drawing.Point(364, 328);
            this.TxtGırısAdı.Name = "TxtGırısAdı";
            this.TxtGırısAdı.Size = new System.Drawing.Size(144, 20);
            this.TxtGırısAdı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı Giriniz : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(300, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "\'\' GELECEK BURADA \'\'";
            // 
            // BtnDevamEt
            // 
            this.BtnDevamEt.BackColor = System.Drawing.Color.Blue;
            this.BtnDevamEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDevamEt.ForeColor = System.Drawing.Color.White;
            this.BtnDevamEt.Location = new System.Drawing.Point(409, 365);
            this.BtnDevamEt.Name = "BtnDevamEt";
            this.BtnDevamEt.Size = new System.Drawing.Size(119, 38);
            this.BtnDevamEt.TabIndex = 5;
            this.BtnDevamEt.Text = "DEVAM ET ";
            this.BtnDevamEt.UseVisualStyleBackColor = false;
            this.BtnDevamEt.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ogrencıler.Properties.Resources.YÖN;
            this.pictureBox2.Location = new System.Drawing.Point(364, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ogrencıler.Properties.Resources.SANALOGİ;
            this.pictureBox1.Location = new System.Drawing.Point(279, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 197);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(231, 347);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "ELEKTRONİK";
            treeNode2.Name = "Node3";
            treeNode2.Text = "MOBİLYA";
            treeNode3.Name = "Node6";
            treeNode3.Text = "AKSESUAR";
            treeNode4.Name = "Node7";
            treeNode4.Text = "İŞ ALETLERİ";
            treeNode5.Name = "Node0";
            treeNode5.Text = "ÜRÜNLER";
            treeNode6.Name = "Node1";
            treeNode6.Text = "";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(127, 75);
            this.treeView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(738, 434);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnDevamEt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtGırısAdı);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGırısAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDevamEt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

