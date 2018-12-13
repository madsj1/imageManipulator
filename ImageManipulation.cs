using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class ImageEventArgs : EventArgs
    {
        public Bitmap bmap { get; set; }
    }
    class ImageManipulation
    {
        public void Manipulate(Bitmap bmap)
        {
            //Manipulate method (takes a bitmap)

            Color theColor = new Color();

            for (int i = 0; i < bmap.Width; i++)
            {
                for(int j = 0; j < bmap.Height; j++)
                {
                    theColor = bmap.GetPixel(i, j);

                    Color newColor = Color.FromArgb(theColor.R, theColor.B, 0);

                    bmap.SetPixel(i, j, newColor);
                }
            }
            OnImageFinished(bmap);
        }

        public event EventHandler<ImageEventArgs> ImageFinished;

        protected virtual void OnImageFinished(Bitmap bmap)
        {
            ImageFinished?.Invoke(this, new ImageEventArgs() { bmap = bmap });
        }
    }
}
