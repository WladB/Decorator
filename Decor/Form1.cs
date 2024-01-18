using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            Tree.g = g;
        }
        Graphics g;
        Tree tree;
        CheckBox contrl;
        private void button1_Click(object sender, EventArgs e)
        {
            tree = new Tree();
            g.Clear(Color.WhiteSmoke);
            Console.WriteLine("------------------------------------");
            for (int i = 1; i < 5; i++)
            {
                contrl = ((CheckBox)panel3.Controls.Find("checkBox" + i, true)[0]);
                if (contrl.Checked) {
                    switch (Convert.ToInt32(((CheckBox)contrl).Tag))
                    {
                        case 1: tree = new LeafDecorat(tree); break;
                        case 2: tree = new FloweringDecorat(tree); break;
                        case 3: tree = new AppleDecorat(tree); break;
                        case 4: tree = new AutumnDecorat(tree);break;
                    }
                }
            }
            tree.draw();
            tree.Consol();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Console.WriteLine("------------------------------------");
            g.Clear(Color.WhiteSmoke);
            if (tree != null)
            {
                switch (trackBar1.Value)
                {
                    case 0: tree = new Tree(); break;
                    case 1: tree = new LeafDecorat(tree); break;
                    case 2: tree = new FloweringDecorat(tree); break;
                    case 3: tree = new AppleDecorat(tree); break;
                    case 4: tree = new AutumnDecorat(tree); break;
                    case 5: trackBar1.Value = 0; trackBar1_Scroll(sender, e); break;
                }
                tree.draw();
                tree.Consol();
            }
            else {
                MessageBox.Show("Дерево не створено");
            }
        }
    }
}
