using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Globalization;

namespace Friendly_KITTI
{
    public class ResizableRectangle
    {
        private PictureBox mPictureBox;
        public Rectangle rect;
        public bool allowDeformingDuringMovement = true;
        public bool mIsClick = false;
        private int oldX;
        private int oldY;
        public int sizeNodeRect = 10;        
        public PosSizableRect nodeSelected = PosSizableRect.None;
        public string className;
        public Color boxColor;
        public CurrentObjectClass currentObjectClass;
        public float truncated;

        public enum PosSizableRect
        {
            UpMiddle,
            LeftMiddle,
            LeftBottom,
            LeftUp,
            RightUp,
            RightMiddle,
            RightBottom,
            BottomMiddle,
            None

        };

        public ResizableRectangle(Rectangle r)
        {
            rect = r;
            mIsClick = false;
            truncated = 0f;
        }

        public ResizableRectangle(string KITTIstring)
        {
            string[] KITTIstringElements = KITTIstring.Split(" "[0]);
            this.className = KITTIstringElements[0];
            this.truncated = float.Parse(KITTIstringElements[1], CultureInfo.InvariantCulture);
            this.rect.X = (int)float.Parse(KITTIstringElements[4], CultureInfo.InvariantCulture);
            this.rect.Y = (int)float.Parse(KITTIstringElements[5], CultureInfo.InvariantCulture);
            this.rect.Width = (int)float.Parse(KITTIstringElements[6], CultureInfo.InvariantCulture)- rect.X;
            this.rect.Height = (int)float.Parse(KITTIstringElements[7], CultureInfo.InvariantCulture)- rect.Y;            
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(boxColor), rect);

            foreach (PosSizableRect pos in Enum.GetValues(typeof(PosSizableRect)))
            {
                g.DrawRectangle(new Pen(boxColor), GetRect(pos));
            }
        }
              
        
        public void SetPictureBox(PictureBox p)
        {
            this.mPictureBox = p;
            mPictureBox.MouseDown += new MouseEventHandler(mPictureBox_MouseDown);
            mPictureBox.MouseUp += new MouseEventHandler(mPictureBox_MouseUp);
            mPictureBox.MouseMove += new MouseEventHandler(mPictureBox_MouseMove);
            mPictureBox.Paint += new PaintEventHandler(mPictureBox_Paint);            
        }

        public void UnSetPictureBox()
        {
            
            mPictureBox.MouseDown -= new MouseEventHandler(mPictureBox_MouseDown);
            mPictureBox.MouseUp -= new MouseEventHandler(mPictureBox_MouseUp);
            mPictureBox.MouseMove -= new MouseEventHandler(mPictureBox_MouseMove);
            mPictureBox.Paint -= new PaintEventHandler(mPictureBox_Paint);
            this.mPictureBox = null;
        }

        private void mPictureBox_Paint(object sender, PaintEventArgs e)
        {

            try
            {
                Draw(e.Graphics);
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message);
            }

        }

        private void mPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mIsClick = true;

            nodeSelected = PosSizableRect.None;
            nodeSelected = GetNodeSelectable(e.Location);
                       
            oldX = e.X;
            oldY = e.Y;
        }

        private void mPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mIsClick = false;            
        }

        private void mPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeCursor(e.Location);
            if (mIsClick == false)
            {
                return;
            }

            Rectangle backupRect = rect;

            switch (nodeSelected)
            {
                case PosSizableRect.LeftUp:
                    if (e.X > 0) rect.X += e.X - oldX;
                    if (e.X > 0) rect.Width -= e.X - oldX;
                    if (e.Y > 0) rect.Y += e.Y - oldY;
                    if (e.Y > 0) rect.Height -= e.Y - oldY;
                    break;
                case PosSizableRect.LeftMiddle:
                    if (e.X > 0) rect.X += e.X - oldX;
                    if (e.X > 0) rect.Width -= e.X - oldX;
                    break;
                case PosSizableRect.LeftBottom:
                    if (e.X > 0) rect.Width -= e.X - oldX;
                    if (e.X > 0) rect.X += e.X - oldX;
                    if (e.Y > 0) rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.BottomMiddle:
                    if (e.Y > 0) rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.RightUp:
                    if (e.X > 0) rect.Width += e.X - oldX;
                    if (e.Y > 0) rect.Y += e.Y - oldY;
                    if (e.Y > 0) rect.Height -= e.Y - oldY;
                    break;
                case PosSizableRect.RightBottom:
                    if (e.X > 0) rect.Width += e.X - oldX;
                    if (e.Y > 0) rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.RightMiddle:
                    if (e.X > 0) rect.Width += e.X - oldX;
                    break;

                case PosSizableRect.UpMiddle:
                    if (e.Y > 0) rect.Y += e.Y - oldY;
                    if (e.Y > 0) rect.Height -= e.Y - oldY;
                    break;                
            }
            oldX = e.X;
            oldY = e.Y;

            if (rect.Width < 5 || rect.Height < 5)
            {
                rect = backupRect;
            }

            TestIfRectInsideArea();

            mPictureBox.Invalidate();
        }

        private void TestIfRectInsideArea()
        {
            // Test if rectangle still inside the area.
            if (rect.X < 0) rect.X = 0;
            if (rect.Y < 0) rect.Y = 0;
            if (rect.Width <= 0) rect.Width = 1;
            if (rect.Height <= 0) rect.Height = 1;

            if (rect.X + rect.Width > mPictureBox.Image.Width)
            {
                rect.Width = mPictureBox.Image.Width - rect.X - 1; // -1 to be still show 
                if (allowDeformingDuringMovement == false)
                {
                    mIsClick = false;
                }
            }
            if (rect.Y + rect.Height > mPictureBox.Image.Height)
            {
                rect.Height = mPictureBox.Image.Height - rect.Y - 1;// -1 to be still show 
                if (allowDeformingDuringMovement == false)
                {
                    mIsClick = false;
                }
            }
        }

        private Rectangle CreateRectSizableNode(int x, int y)
        {
            return new Rectangle(x - sizeNodeRect / 2, y - sizeNodeRect / 2, sizeNodeRect, sizeNodeRect);
        }

        private Rectangle GetRect(PosSizableRect p)
        {
            switch (p)
            {
                case PosSizableRect.LeftUp:
                    return CreateRectSizableNode(rect.X, rect.Y);

                case PosSizableRect.LeftMiddle:
                    return CreateRectSizableNode(rect.X, rect.Y + +rect.Height / 2);

                case PosSizableRect.LeftBottom:
                    return CreateRectSizableNode(rect.X, rect.Y + rect.Height);

                case PosSizableRect.BottomMiddle:
                    return CreateRectSizableNode(rect.X + rect.Width / 2, rect.Y + rect.Height);

                case PosSizableRect.RightUp:
                    return CreateRectSizableNode(rect.X + rect.Width, rect.Y);

                case PosSizableRect.RightBottom:
                    return CreateRectSizableNode(rect.X + rect.Width, rect.Y + rect.Height);

                case PosSizableRect.RightMiddle:
                    return CreateRectSizableNode(rect.X + rect.Width, rect.Y + rect.Height / 2);

                case PosSizableRect.UpMiddle:
                    return CreateRectSizableNode(rect.X + rect.Width / 2, rect.Y);
                default:
                    return new Rectangle();
            }
        }

        private PosSizableRect GetNodeSelectable(Point p)
        {
            foreach (PosSizableRect r in Enum.GetValues(typeof(PosSizableRect)))
            {
                if (GetRect(r).Contains(p))
                {
                    return r;
                }
            }
            return PosSizableRect.None;
        }

        private void ChangeCursor(Point p)
        {
            mPictureBox.Cursor = GetCursor(GetNodeSelectable(p));
        }

        /// <summary>
        /// Get cursor for the handle
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private Cursor GetCursor(PosSizableRect p)
        {
            switch (p)
            {
                case PosSizableRect.LeftUp:
                    return Cursors.SizeNWSE;

                case PosSizableRect.LeftMiddle:
                    return Cursors.SizeWE;

                case PosSizableRect.LeftBottom:
                    return Cursors.SizeNESW;

                case PosSizableRect.BottomMiddle:
                    return Cursors.SizeNS;

                case PosSizableRect.RightUp:
                    return Cursors.SizeNESW;

                case PosSizableRect.RightBottom:
                    return Cursors.SizeNWSE;

                case PosSizableRect.RightMiddle:
                    return Cursors.SizeWE;

                case PosSizableRect.UpMiddle:
                    return Cursors.SizeNS;
                default:
                    return Cursors.Default;
            }
        }

        public override string ToString()
        {
            string singleKITTI = className + " "    //label
                + truncated + " "
                + "0 0 "                      // truncation float (from 1 for fully truncated to 0 for untruncated) and angle
                + rect.X + " " //
                + rect.Y + " " //
                + (rect.X+ rect.Width) + " " //
                + (rect.Y+rect.Height) + " " //
                + "0 0 0 0 0 0 0";   // values unused by NVIDIA DIGITS

            return singleKITTI;
        }

    }
}
