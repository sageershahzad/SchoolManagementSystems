using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Utilities
{
    public class ImageManipulations
    {
        public static byte[] GetPhoto(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.GetBuffer();
        }

        public static Image PutPhoto(byte[] photo)
        {
            MemoryStream memoryStream = new MemoryStream(photo);
            
            return Image.FromStream(memoryStream);
        }
    }
}
