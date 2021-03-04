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


        public ItemBox()
        {
            InitializeComponent();
        }

        
        private void UserControl1_Load(object sender, EventArgs e)
        {
            nama_Barang.Text = this._nama + this._jenisBarang;
            harga.Text = this._harga.ToString();
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
    }
}
