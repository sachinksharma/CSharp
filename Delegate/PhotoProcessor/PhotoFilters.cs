using System;

namespace PhotoProcessor
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness applied to photo");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast applied to photo");
        }

        public void ApplySharp(Photo photo)
        {
            Console.WriteLine("Sharpness applied to photo");
        }
    }
}