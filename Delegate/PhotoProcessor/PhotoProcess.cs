namespace PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);
    public class PhotoProcess
    {
        public void Process(string path, PhotoFilterHandler filterHanlder)
        {
            var photo = Photo.Load(path);
            filterHanlder(photo);
        }
    }
}