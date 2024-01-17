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
        protected Tree obj;

        public AbstractDecorator(Tree a)
        {
            obj = a;
        }
    }
  
    public class LeafDecorat : AbstractDecorator
    {
        public LeafDecorat(Tree a) : base(a)
        {
            obj = a;
            location.X = 29;
            location.Y = 68;
            size = new Size(244, 235);
        }
        public override void draw()
        {
            obj.draw();
            g.DrawImage(new Bitmap(@"Leaf.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            obj.Consol();
            Console.WriteLine("Створення зеленого листя");
        }
    }
    public class FloweringDecorat : AbstractDecorator
    {
        public FloweringDecorat(Tree a) : base(a)
        {
            obj = a;
            location.X = 32;
            location.Y = 70;
            size = new Size(239, 230);
        }
        public override void draw()
        {
            obj.draw();
            g.DrawImage(new Bitmap(@"Flowers.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            obj.Consol();
            Console.WriteLine("Створення квітів");
        }
    }
    public class AppleDecorat : AbstractDecorator
    {
        public AppleDecorat(Tree a) : base(a)
        {
            obj = a;
            location.X = 32;
            location.Y = 70;
            size = new Size(239, 230);
        }
        public override void draw()
        {
            obj.draw();
            g.DrawImage(new Bitmap(@"Apple.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            obj.Consol();
            Console.WriteLine("Створення яблук");
        }
    }
    public class AutumnDecorat : AbstractDecorator
    {
        public AutumnDecorat(Tree a) : base(a)
        {
            obj = a;
            location.X = 29;
            location.Y = 68;
            size = new Size(244, 235);
        }
        public override void draw()
        {
            obj.draw();
            g.DrawImage(new Bitmap(@"Autumn.png"), new Rectangle(location, size));
        }
        public override void Consol()
        {
            obj.Consol();
            Console.WriteLine("Створення жовтого листя");
        }
    }
}
