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
    public partial class DetailPage : Form
    {
        ItemBox[] items = new ItemBox[15];
        public DetailPage(ItemBox[] filtered)
        {
            InitializeComponent();
            items = filtered;
            tampilIsiData();
        }

        private void status_Click(object sender, EventArgs e)
        {

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
                if(x.JumlahBarang > 0)
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
        private void chartBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
