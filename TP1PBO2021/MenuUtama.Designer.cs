﻿
namespace TP1PBO2021
{
    partial class MenuUtama
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
            this.JenisBarangCb = new System.Windows.Forms.ComboBox();
            this.HargaCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCari = new System.Windows.Forms.Button();
            this.panelPencarian = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.panelBarang = new System.Windows.Forms.FlowLayoutPanel();
            this.chartBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.WebCatalogBt = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.panelPencarian.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // JenisBarangCb
            // 
            this.JenisBarangCb.FormattingEnabled = true;
            this.JenisBarangCb.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.JenisBarangCb.Location = new System.Drawing.Point(6, 106);
            this.JenisBarangCb.Name = "JenisBarangCb";
            this.JenisBarangCb.Size = new System.Drawing.Size(141, 24);
            this.JenisBarangCb.TabIndex = 2;
            this.JenisBarangCb.Text = "Jenis Barang";
            // 
            // HargaCb
            // 
            this.HargaCb.FormattingEnabled = true;
            this.HargaCb.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.HargaCb.Location = new System.Drawing.Point(6, 168);
            this.HargaCb.Name = "HargaCb";
            this.HargaCb.Size = new System.Drawing.Size(138, 24);
            this.HargaCb.TabIndex = 3;
            this.HargaCb.Text = "Harga";
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
            // BtnCari
            // 
            this.BtnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.BtnCari.FlatAppearance.BorderSize = 0;
            this.BtnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCari.ForeColor = System.Drawing.Color.White;
            this.BtnCari.Location = new System.Drawing.Point(0, 239);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(150, 47);
            this.BtnCari.TabIndex = 8;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = false;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // panelPencarian
            // 
            this.panelPencarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.panelPencarian.Controls.Add(this.chartBtn);
            this.panelPencarian.Controls.Add(this.panelLogo);
            this.panelPencarian.Controls.Add(this.HargaCb);
            this.panelPencarian.Controls.Add(this.BtnCari);
            this.panelPencarian.Controls.Add(this.JenisBarangCb);
            this.panelPencarian.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPencarian.Location = new System.Drawing.Point(0, 0);
            this.panelPencarian.Name = "panelPencarian";
            this.panelPencarian.Size = new System.Drawing.Size(150, 493);
            this.panelPencarian.TabIndex = 9;
            this.panelPencarian.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panelHeader.Size = new System.Drawing.Size(750, 70);
            this.panelHeader.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(156, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Semua Barang :";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.status.Location = new System.Drawing.Point(184, 124);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(65, 18);
            this.status.TabIndex = 15;
            this.status.Text = "Statusz";
            // 
            // panelBarang
            // 
            this.panelBarang.AutoScroll = true;
            this.panelBarang.Location = new System.Drawing.Point(187, 155);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(701, 317);
            this.panelBarang.TabIndex = 16;
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
            this.chartBtn.Text = "Show Chart";
            this.chartBtn.UseVisualStyleBackColor = false;
            this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
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
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 493);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelPencarian);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.Load += new System.EventHandler(this.MenuUtama_Load);
            this.panelPencarian.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox JenisBarangCb;
        private System.Windows.Forms.ComboBox HargaCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.Panel panelPencarian;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button WebCatalogBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.FlowLayoutPanel panelBarang;
        private System.Windows.Forms.Button chartBtn;
    }
}