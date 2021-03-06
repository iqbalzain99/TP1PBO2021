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
    public partial class MenuUtama : Form
    {
        private ItemBox[] items = new ItemBox[15];
        public MenuUtama()
        {
            InitializeComponent();
            isiData();
            tampilIsiData();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void isiData()
        {
            string[] a = new string[] { "Makanan", "Baju", "Elektronik" };
            Random _rand = new Random();
            for (int i = 0; i < items.Length; ++i)
            {
                int hasil_rand = _rand.Next(0, 3);
                items[i] = new ItemBox();
                items[i].Nama = a[hasil_rand] +"-" + (i+1).ToString();
                items[i].Harga = _rand.Next(1, 9) * 100000 + _rand.Next(5, 100) * 1000;
                items[i].JenisBarang = a[hasil_rand];
                items[i].JumlahBarang = 0 ;
                //items[i].Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
            }
            

        }

        private void tampilIsiData()
        {
            int i = 0;
            panelBarang.Controls.Clear();
            foreach (ItemBox x in items)
            {
                panelBarang.SetFlowBreak(x, false);
            }
            foreach (ItemBox x in items)
            {
                if (i % 3 == 2)
                {
                    panelBarang.SetFlowBreak(x, true);
                }
                panelBarang.Controls.Add(x);
                i++;
            }
        }


        private void filterBarang(string jenis, int batasBwhHarga, int batasAtsHarga)
        {
            int i = 0;
            foreach(ItemBox x in items)
            {
                panelBarang.SetFlowBreak(x, false);
            }
            foreach(ItemBox x in items)
            {
                if (x.JenisBarang.Contains(jenis) && x.Harga >= batasBwhHarga &&  x.Harga <=batasAtsHarga)
                {
                    if (i % 3 == 2)
                    {
                        panelBarang.SetFlowBreak(x, true);
                    }
                    panelBarang.Controls.Add(x);
                    i++;
                }
            }
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            //status.Text = Convert.ToString(JenisBarangCb.Text) + " " + Convert.ToString(HargaCb.Text) +" "+ Convert.ToString(status.Dock.GetType());
            //status.Dock = DockStyle.Left;
            /*100rb - 200rb
            200rb - 500rb
            500rb - 1jt*/
            panelBarang.Controls.Clear();
            int k = 1000;
            int batasBawah = 0, batasAtas = 100*k*k;
            
            if(Convert.ToString(HargaCb.Text) == "100rb - 200rb")
            {
                batasBawah = 100*k;
                batasAtas = 200*k;
            }
            else if(Convert.ToString(HargaCb.Text) == "200rb - 500rb")
            {
                batasBawah = 200 * k;
                batasAtas = 500 * k;
            }
            else if (Convert.ToString(HargaCb.Text) == "500rb - 1jt")
            {
                batasBawah = 500 * k;
                batasAtas = 1000 * k;
            }
            if(Convert.ToString(JenisBarangCb.Text) == "Jenis Barang") filterBarang("", batasBawah, batasAtas);
            else filterBarang(JenisBarangCb.Text,batasBawah ,batasAtas);

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            //LoginPage.Show();
            this.Close();
            
        }

        private void WebCatalogBt_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("tokopedia.com");
            System.Diagnostics.Process.Start("http://www.tokopedia.com");
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            tampilIsiData();
        }

        private void chartBtn_Click(object sender, EventArgs e)
        {
            DetailPage detil = new DetailPage(items);
            this.Hide();
            detil.ShowDialog();
            this.Show();
            tampilIsiData();
        }
    }
}
