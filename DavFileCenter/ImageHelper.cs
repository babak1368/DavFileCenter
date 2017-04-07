using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavFileCenter
{
    public static class ImageHelper
    {
        public static byte[] ResizeImage(byte[] photo, int width = 100, int height = 100)
        {
            Image i;
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(photo, 0, photo.Length);
                i = Image.FromStream(ms);
            }
            return ImageToByteArray(i.GetThumbnailImage(width, height, () => false, IntPtr.Zero));
        }

        private static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

    }
}
