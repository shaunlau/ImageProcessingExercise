using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class ImageHandler
    {
        public static Bitmap ProcessImage(Bitmap bmp)
        {
            byte[,] rArray, gArray, bArray;

            BToArray(bmp, out rArray, out gArray, out bArray);

            DoProcess(ref rArray, ref gArray, ref bArray);

            return ArrayToBmp(bmp, rArray, gArray, bArray);
        }

        public static void BToArray(Bitmap bmp, out byte[,] rArray, out byte[,] gArray, out byte[,] bArray)
        {
            rArray = new byte[bmp.Width, bmp.Height];
            gArray = new byte[bmp.Width, bmp.Height];
            bArray = new byte[bmp.Width, bmp.Height];

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    rArray[x, y] = c.R;
                    gArray[x, y] = c.G;
                    bArray[x, y] = c.B;
                }
            }
        }

        public static Bitmap ArrayToBmp(Bitmap bmp, byte[,] rArray, byte[,] gArray, byte[,] bArray)
        {
            for (int x = 0; x < rArray.GetLength(0); x++)
            {
                for (int y = 0; y < rArray.GetLength(1); y++)
                {
                    Color c = Color.FromArgb(rArray[x, y], gArray[x, y], bArray[x, y]);
                    bmp.SetPixel(x, y, c);
                }
            }

            return bmp;
        }

        public static void DoProcess(ref byte[,] rArray, ref byte[,] gArray, ref byte[,] bArray)
        {
            //YOUR CODE HERE

        }
    }
}
