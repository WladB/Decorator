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
    public class Tree
    {
        public static Graphics g;
        public Point location;
        public Size size;
        public Tree()
        {
            location = new Point(75, 180);
            size = new Size(150, 210);
        }
        public virtual void draw()
        {
            g.DrawImage(new Bitmap(@"Tree.png"), new Rectangle(location, size));
        }
        public virtual void Consol()
        {
            Console.WriteLine("Створення дерева");
        }
    }
}
