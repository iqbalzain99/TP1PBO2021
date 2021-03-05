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
            nama_Barang.Text = this._nama + "Total : " + this._jumlahBarang.ToString();
            harga.Text = "Rp. " + this._harga.ToString();
            /*Elektronik
            Baju
            Makanan*/
            if (this._jenisBarang == "Elektronik")
            {
                pb1.BackColor = Color.Red;
            }
            if (this._jenisBarang == "Baju")
            {
                pb1.BackColor = Color.Blue;
            }
            if (this._jenisBarang == "Makanan")
            {
                pb1.BackColor = Color.Green;
            }
        }

        private void beliBtn_Click(object sender, EventArgs e)
        {
            this._jumlahBarang = 1+this._jumlahBarang;
        }
    }
}
