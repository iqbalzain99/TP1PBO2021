
namespace TP1PBO2021
{
    partial class DetailPage
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
            this.chartBtn = new System.Windows.Forms.Button();
            this.panelPencarian = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.panelBarang = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.WebCatalogBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPencarian.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartBtn
            // 
            this.chartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.chartBtn.FlatAppearance.BorderSize = 0;
            this.chartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartBtn.ForeColor = System.Drawing.Color.White;
            this.chartBtn.Location = new System.Drawing.Point(0, 408);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(150, 47);
            this.chartBtn.TabIndex = 11;
            this.chartBtn.Text = "Back";
            this.chartBtn.UseVisualStyleBackColor = false;
            this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
            // 
            // panelPencarian
            // 
            this.panelPencarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.panelPencarian.Controls.Add(this.chartBtn);
            this.panelPencarian.Controls.Add(this.panelLogo);
            this.panelPencarian.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPencarian.Location = new System.Drawing.Point(0, 0);
            this.panelPencarian.Name = "panelPencarian";
            this.panelPencarian.Size = new System.Drawing.Size(150, 522);
            this.panelPencarian.TabIndex = 17;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 70);
            this.panelLogo.TabIndex = 10;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logo.Image = global::TP1PBO2021.Properties.Resources.iconfinder_logo_brand_brands_logos_sketch_app_2993662;
            this.Logo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logo.Location = new System.Drawing.Point(24, 20);
            this.Logo.Name = "Logo";
            this.Logo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Logo.Size = new System.Drawing.Size(99, 25);
            this.Logo.TabIndex = 15;
            this.Logo.Text = "    RM D";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBarang
            // 
            this.panelBarang.AutoScroll = true;
            this.panelBarang.Location = new System.Drawing.Point(156, 144);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(724, 369);
            this.panelBarang.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(156, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Detail Keranjang :";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.panelHeader.Controls.Add(this.LogOutBtn);
            this.panelHeader.Controls.Add(this.WebCatalogBt);
            this.panelHeader.Controls.Add(this.label5);
            this.panelHeader.Controls.Add(this.HomeBtn);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(150, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(754, 70);
            this.panelHeader.TabIndex = 22;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.LogOutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Image = global::TP1PBO2021.Properties.Resources.iconfinder_logout_account_exit_door_3005766;
            this.LogOutBtn.Location = new System.Drawing.Point(344, 0);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(172, 70);
            this.LogOutBtn.TabIndex = 13;
            this.LogOutBtn.Text = "LOG OUT";
            this.LogOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // WebCatalogBt
            // 
            this.WebCatalogBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.WebCatalogBt.Dock = System.Windows.Forms.DockStyle.Left;
            this.WebCatalogBt.FlatAppearance.BorderSize = 0;
            this.WebCatalogBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebCatalogBt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCatalogBt.ForeColor = System.Drawing.Color.White;
            this.WebCatalogBt.Image = global::TP1PBO2021.Properties.Resources.iconfinder_language_326663;
            this.WebCatalogBt.Location = new System.Drawing.Point(172, 0);
            this.WebCatalogBt.Name = "WebCatalogBt";
            this.WebCatalogBt.Size = new System.Drawing.Size(172, 70);
            this.WebCatalogBt.TabIndex = 12;
            this.WebCatalogBt.Text = "WEB CATALOG";
            this.WebCatalogBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WebCatalogBt.UseVisualStyleBackColor = false;
            this.WebCatalogBt.Click += new System.EventHandler(this.WebCatalogBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(522, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "NAMA: M Iqbal Zain";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::TP1PBO2021.Properties.Resources.iconfinder_Home_01_19760531;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(172, 70);
            this.HomeBtn.TabIndex = 11;
            this.HomeBtn.Text = "HOME";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(522, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIM: 1901423";
            // 
            // DetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 522);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelPencarian);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.label1);
            this.Name = "DetailPage";
            this.Text = "DetailPage";
            this.panelPencarian.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.Panel panelPencarian;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.FlowLayoutPanel panelBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button WebCatalogBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label label4;
    }
}