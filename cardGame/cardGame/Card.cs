using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cardGame.Common;
using System.Drawing;

namespace cardGame
{
    class Card : cardBase
    {
        public int hp;
        public int attack;
        public int defense;
        public int price;
        public string god;
        public string spec;
        public string text;
        public GroupBox sheet;
        public PictureBox pic;

        public Card()
        {
            this.sheet = new GroupBox();
            this.pic = new PictureBox();
            //pic.ImageLocation = "C:/Users/hp/Downloads/bandit.png";
            
            Bitmap objBitmap1 = new Bitmap(Image.FromFile("C:/Users/hp/Downloads/bandit.png"), new Size(120, 160));
            pic.Image = objBitmap1;
            sheet.Size = new Size(150, 300);
            Bitmap objBitmap = new Bitmap(Image.FromFile("C:/Users/hp/Downloads/sheet.png"), new Size(150, 300));
            sheet.AutoSize = true;
            sheet.BackgroundImage = objBitmap;
            sheet.Controls.Add(pic);

        }
    }
}
