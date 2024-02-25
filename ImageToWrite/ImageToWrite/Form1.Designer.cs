
namespace ImageToWrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageSelectGrup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.copyBTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ımageSelecet = new System.Windows.Forms.PictureBox();
            this.ımageSelectGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSelecet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(107, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Picture To Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(235, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "#coderpsycho";
            // 
            // ımageSelectGrup
            // 
            this.ımageSelectGrup.Controls.Add(this.label3);
            this.ımageSelectGrup.Controls.Add(this.copyBTN);
            this.ımageSelectGrup.Controls.Add(this.richTextBox1);
            this.ımageSelectGrup.Controls.Add(this.ımageSelecet);
            this.ımageSelectGrup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ımageSelectGrup.Location = new System.Drawing.Point(12, 57);
            this.ımageSelectGrup.Name = "ımageSelectGrup";
            this.ımageSelectGrup.Size = new System.Drawing.Size(438, 175);
            this.ımageSelectGrup.TabIndex = 2;
            this.ımageSelectGrup.TabStop = false;
            this.ımageSelectGrup.DragDrop += new System.Windows.Forms.DragEventHandler(this.ımageSelectGrup_DragDrop);
            this.ımageSelectGrup.DragEnter += new System.Windows.Forms.DragEventHandler(this.ımageSelectGrup_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(343, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metin";
            // 
            // copyBTN
            // 
            this.copyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.copyBTN.FlatAppearance.BorderSize = 0;
            this.copyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBTN.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.copyBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.copyBTN.Location = new System.Drawing.Point(316, 142);
            this.copyBTN.Name = "copyBTN";
            this.copyBTN.Size = new System.Drawing.Size(107, 23);
            this.copyBTN.TabIndex = 2;
            this.copyBTN.Text = "KOPYALA";
            this.copyBTN.UseVisualStyleBackColor = false;
            this.copyBTN.Click += new System.EventHandler(this.copyBTN_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(302, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(130, 111);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // ımageSelecet
            // 
            this.ımageSelecet.Image = ((System.Drawing.Image)(resources.GetObject("ımageSelecet.Image")));
            this.ımageSelecet.Location = new System.Drawing.Point(148, 25);
            this.ımageSelecet.Name = "ımageSelecet";
            this.ımageSelecet.Size = new System.Drawing.Size(128, 128);
            this.ımageSelecet.TabIndex = 0;
            this.ımageSelecet.TabStop = false;
            this.ımageSelecet.Click += new System.EventHandler(this.ımageSelecet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(462, 244);
            this.Controls.Add(this.ımageSelectGrup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageToWrite / Abdül Kerim BOZTEPE";
            this.ımageSelectGrup.ResumeLayout(false);
            this.ımageSelectGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSelecet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ımageSelectGrup;
        private System.Windows.Forms.PictureBox ımageSelecet;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button copyBTN;
        private System.Windows.Forms.Label label3;
    }
}

