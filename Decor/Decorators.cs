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
        public override void draw() { }
        public override void Consol() { }
    }
  
    public class LeafDecorat : AbstractDecorator
    {
        public LeafDecorat(Tree tree) : base(tree)
        {
            Obj = tree;
     
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Leaf.png"), new Rectangle(new Point(29, 68), new Size(244, 235)));
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
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Flowers.png"), new Rectangle(new Point(32, 70), new Size(239, 230)));
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
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Apple.png"), new Rectangle(new Point(32, 70), new Size(239, 230)));
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
        }
        public override void draw()
        {
            Obj.draw();
            g.DrawImage(new Bitmap(@"Autumn.png"), new Rectangle(new Point(29, 68), new Size(244, 235)));
        }
        public override void Consol()
        {
            Obj.Consol();
            Console.WriteLine("Створення жовтого листя");
        }
    }
}
