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
   
    public abstract class AbstractDecorator : Tree
    {
        protected Tree Obj;

        public AbstractDecorator(Tree tree)
        {
            Obj = tree;
        }
    }
  
    public class LeafDecorat : AbstractDecorator
    {
        public LeafDecorat(Tree tree) : base(tree)
        {
            Obj = tree;
            location.X = 29;
            location.Y = 68;
            size = new Size(244, 235);
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Leaf.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            Obj.Consol();
            Console.WriteLine("Створення зеленого листя");
        }
    }
    public class FloweringDecorat : AbstractDecorator
    {
        public FloweringDecorat(Tree tree) : base(tree)
        {
            Obj = tree;
            location.X = 32;
            location.Y = 70;
            size = new Size(239, 230);
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Flowers.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            Obj.Consol();
            Console.WriteLine("Створення квітів");
        }
    }
    public class AppleDecorat : AbstractDecorator
    {
        public AppleDecorat(Tree tree) : base(tree)
        {
            Obj = tree;
            location.X = 32;
            location.Y = 70;
            size = new Size(239, 230);
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Apple.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            Obj.Consol();
            Console.WriteLine("Створення яблук");
        }
    }
    public class AutumnDecorat : AbstractDecorator
    {
        public AutumnDecorat(Tree tree) : base(tree)
        {
            Obj = tree;
            location.X = 29;
            location.Y = 68;
            size = new Size(244, 235);
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Autumn.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            Obj.Consol();
            Console.WriteLine("Створення жовтого листя");
        }
    }
}
