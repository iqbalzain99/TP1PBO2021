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
                items[i] = new ItemBox();
                items[i].Nama = "Yooz";
                items[i].Harga = _rand.Next(3, 5) * 100000;
                items[i].JenisBarang = a[_rand.Next(0, 3)];
                if (i % 3 == 0)
                {
                    panelBarang.SetFlowBreak(items[i], true);
                }
                panelBarang.Controls.Add(items[i]);
                //items[i].Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
            }
        }

        private void filterBarang(string jenis)
        {
            int i = 0;
            foreach(ItemBox x in items)
            {
                panelBarang.SetFlowBreak(x, false);
            }
            foreach(ItemBox x in items)
            {
                if (x.JenisBarang.Contains(jenis))
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
            status.Text = Convert.ToString(JenisBarangCb.Text) + " " + Convert.ToString(HargaCb.Text) +" "+ Convert.ToString(status.Dock.GetType());
            //status.Dock = DockStyle.Left;
            panelBarang.Controls.Clear();
            filterBarang(JenisBarangCb.Text);

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            //LoginPage.Show();
            this.Close();
            
        }

        private void WebCatalogBt_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("tokopedia.com");
        }
    }
}
