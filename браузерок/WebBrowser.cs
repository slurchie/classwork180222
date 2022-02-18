using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace браузерок
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void browser_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\talda\source\repos\classwork180222\браузерок\bin\Debug\прога.txt";
            string[] str;
            нижняятабл.ColumnCount = 3;
            нижняятабл.RowCount = 3;
            using (System.IO.StreamReader read = new System.IO.StreamReader(path, System.Text.Encoding.Default))
            {
                str = read.ReadToEnd().Split(new Char[] { ' ', '\n', '\r' }); // и n

                int pos = 0;

                for (int i = 0; i < нижняятабл.RowCount; i++)
                {
                    for (int j = 0; j < нижняятабл.ColumnCount; j++)
                    {
                        while (str[pos] == "")
                        {
                            pos++;
                        }

                        нижняятабл[j, i].Value = str[pos];

                        pos++;
                    }

                }
            }
        }

    }
}
