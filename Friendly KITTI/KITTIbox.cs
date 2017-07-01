using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly_KITTI
{

    // this class ist used only when reading and multiplying images and labels
    class KITTIbox : ICloneable
    {
        public string className;
        public float truncated;
        public int left;
        public int top;
        public int right;
        public int bottom;
        private int imageWidth;
        private int imageHeight;
        

        public KITTIbox(string KITTIstring, int imageWidth, int imageHeight)
        {
            string[]  KITTIstringElements = KITTIstring.Split(" "[0]);
            this.className = KITTIstringElements[0];
            this.truncated= float.Parse(KITTIstringElements[1], CultureInfo.InvariantCulture);
            this.left = (Int32)float.Parse(KITTIstringElements[4], CultureInfo.InvariantCulture);
            this.top = (Int32)float.Parse(KITTIstringElements[5], CultureInfo.InvariantCulture);
            this.right = (Int32)float.Parse(KITTIstringElements[6], CultureInfo.InvariantCulture);
            this.bottom = (Int32)float.Parse(KITTIstringElements[7], CultureInfo.InvariantCulture);
            this.imageWidth = imageWidth;
            this.imageHeight = imageHeight;
        }

        public KITTIbox()  //Standard constructor
        {           
            this.className = "";
            this.truncated = 0f;
            this.left = 0;
            this.top = 0;
            this.right = 0;
            this.bottom = 0;
            this.imageWidth = 0;
            this.imageHeight = 0;
        }

        public override string ToString() {
            string singleKITTI = className + " "    //label
                + truncated + " "
                + "0 0 "                      // truncation float (from 1 for fully truncated to 0 for untruncated) and angle
                + left + " " //
                + top + " " //
                + right + " " //
                + bottom + " " //
                + "0 0 0 0 0 0 0";   // values unused by NVIDIA DIGITS

            return singleKITTI;
        }

        public void FlipX()
        {
            int tempLeft=left;
            int tempRight=right;
            this.left = this.imageWidth - tempRight;
            this.right = this.imageWidth - tempLeft;
        }
        public void FlipY()
        {
            int tempTop = top;
            int tempBottom = bottom;
            this.top = this.imageHeight - tempBottom;
            this.bottom = this.imageHeight - tempTop;
        }

        public void Rotate90()
        {
            int tmpleft = this.left;
            int tmptop = this.top;
            int tmpright = this.right;
            int tmpbottom = this.bottom;
            int tmpimageWidth = this.imageWidth;
            int tmpimageHeight = this.imageHeight;

            this.left = tmpimageHeight -tmpbottom;
            this.top = tmpleft;
            this.right = tmpimageHeight - tmptop;
            this.bottom = tmpright;

            this.imageWidth= tmpimageHeight;
            this.imageHeight= tmpimageWidth;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    
}
