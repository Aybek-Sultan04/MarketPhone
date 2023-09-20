using Domain.Entity;
using Infrastructure.PictureDb;

namespace Infrastructure
{
    public class PictureService
    {
        readonly ImagesDb n;
        public PictureService()
        {
            n = new ImagesDb();
        }
        public void AddImages(byte[] images,string description="new Phone")
        {
            n.Images.Add(new ImagesClass
            {
                Image = images,
                Description = description
            });
            n.SaveChanges();
        }
    }
}
