using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace браузерок
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WebBrowser());
            TreeNode groupnode = new TreeNode("Группы");
            groupnode.Nodes.Add(new TreeNode("09-121"));
            groupnode.Nodes.Add(new TreeNode("09-122"));
            groupnode.ExpandAll();
        }
    }
}
