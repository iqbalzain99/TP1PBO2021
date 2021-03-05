
namespace TP1PBO2021
{
    partial class ItemBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.nama_Barang = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.beliBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pb1.Location = new System.Drawing.Point(29, 21);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(153, 136);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // nama_Barang
            // 
            this.nama_Barang.AutoSize = true;
            this.nama_Barang.Location = new System.Drawing.Point(47, 160);
            this.nama_Barang.Name = "nama_Barang";
            this.nama_Barang.Size = new System.Drawing.Size(97, 17);
            this.nama_Barang.TabIndex = 1;
            this.nama_Barang.Text = "nama_Barang";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(47, 177);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(30, 17);
            this.harga.TabIndex = 2;
            this.harga.Text = "Rp.";
            // 
            // beliBtn
            // 
            this.beliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliBtn.Location = new System.Drawing.Point(50, 197);
            this.beliBtn.Name = "beliBtn";
            this.beliBtn.Size = new System.Drawing.Size(75, 23);
            this.beliBtn.TabIndex = 3;
            this.beliBtn.Text = "BELI";
            this.beliBtn.UseVisualStyleBackColor = true;
            this.beliBtn.Click += new System.EventHandler(this.beliBtn_Click);
            // 
            // ItemBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.beliBtn);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.nama_Barang);
            this.Controls.Add(this.pb1);
            this.Name = "ItemBox";
            this.Size = new System.Drawing.Size(213, 248);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label nama_Barang;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Button beliBtn;
    }
}
