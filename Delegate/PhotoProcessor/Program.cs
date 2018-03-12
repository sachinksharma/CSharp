using System;

namespace PhotoProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcess();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHanlder = filters.ApplyBrightness;
            filterHanlder += filters.ApplyContrast;
            filterHanlder += RemoveRedEyeFilter;
            processor.Process(@"C:\First.jpeg", filterHanlder);
            Console.ReadLine();
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove red eye filter applied");
        }
    }
}
