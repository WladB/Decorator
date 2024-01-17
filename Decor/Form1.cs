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
        Tree air;
        CheckBox contrl;
        private void button1_Click(object sender, EventArgs e)
        {
            air = new Tree();
            g.Clear(Color.WhiteSmoke);
            Console.WriteLine("------------------------------------");
            for (int i = 1; i < 5; i++)
            {
                contrl = ((CheckBox)panel3.Controls.Find("checkBox" + i, true)[0]);
                if (contrl.Checked) {
                    switch (Convert.ToInt32(((CheckBox)contrl).Tag))
                    {
                        case 1: air = new LeafDecorat(air); break;
                        case 2: air = new FloweringDecorat(air); break;
                        case 3: air = new AppleDecorat(air); break;
                        case 4: air = new AutumnDecorat(air);break;
                    }
                }
            }
            air.draw();
            air.Consol();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Console.WriteLine("------------------------------------");
            g.Clear(Color.WhiteSmoke);
            if (air != null)
            {
                switch (trackBar1.Value)
                {
                    case 0: air = new Tree(); break;
                    case 1: air = new LeafDecorat(air); break;
                    case 2: air = new FloweringDecorat(air); break;
                    case 3: air = new AppleDecorat(air); break;
                    case 4: air = new AutumnDecorat(air); break;
                    case 5: trackBar1.Value = 0; trackBar1_Scroll(sender, e); break;
                }
                air.draw();
                air.Consol();
            }
            else {
                MessageBox.Show("Дерево не створено");
            }
        }
    }
}
