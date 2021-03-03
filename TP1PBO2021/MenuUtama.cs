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
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            status.Text = Convert.ToString(JenisBarangCb.Text) + " " + Convert.ToString(HargaCb.Text) +" "+ Convert.ToString(status.Dock.GetType());
            status.Dock = DockStyle.Left;
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
