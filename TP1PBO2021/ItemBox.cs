using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class ItemBox : UserControl
    {
        private string _nama;
        private int _harga;
        private string _jenisBarang;
        private int _jumlahBarang;

        public string Nama 
        {
            get { return this._nama; }
            set { this._nama = value; }
        }

        public int Harga 
        {
            get { return this._harga; }
            set { this._harga = value; }
        }

        public string JenisBarang
        {
            get { return this._jenisBarang; }
            set { this._jenisBarang = value; }
        }

        public int JumlahBarang
        {
            get { return this._jumlahBarang; }
            set { this._jumlahBarang = value; }
        }

        public ItemBox()
        {
            InitializeComponent();
        }

        
        private void UserControl1_Load(object sender, EventArgs e)
        {
            nama_Barang.Text = this._nama;
            harga.Text = "Rp. " + this._harga.ToString();
            totalHarga.Text = "Total : " + this._jumlahBarang.ToString();
            /*Elektronik
            Baju
            Makanan*/
            if (this._jenisBarang == "Elektronik")
            {
                pb1.BackColor = Color.Red;
                pb1.Image = TP1PBO2021.Properties.Resources.iconfinder_language_326663;
            }
            if (this._jenisBarang == "Baju")
            {
                pb1.BackColor = Color.Blue;
                pb1.Image = TP1PBO2021.Properties.Resources.iconfinder_logout_account_exit_door_3005766;
            }
            if (this._jenisBarang == "Makanan")
            {
                pb1.BackColor = Color.Green;
                pb1.Image = TP1PBO2021.Properties.Resources.iconfinder_logo_brand_brands_logos_sketch_app_2993662;
            }
        }

        private void beliBtn_Click(object sender, EventArgs e)
        {
            this._jumlahBarang = 1+this._jumlahBarang;
            UserControl1_Load(sender, e);
        }

        
    }
}
