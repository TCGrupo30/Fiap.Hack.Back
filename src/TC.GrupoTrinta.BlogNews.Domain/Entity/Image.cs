
using TC.GrupoTrinta.BlogNews.Domain.SeedWork;

namespace TC.GrupoTrinta.BlogNews.Domain.Entity
{
    public class Image : AggregateRoot
    {
        public Guid ImageId { get; set; }
        public Guid VideoId { get; set; }        
        public string NameImage { get; set; }
        public string PathImage { get; set; }
        public DateTime CreateAt { get; private set; }

        public Image(Guid imageId, Guid videoId, string nameImage, string pathImage, DateTime createAt)
        {
            ImageId = imageId;
            VideoId = videoId;
            NameImage = nameImage;
            PathImage = pathImage;
            CreateAt = createAt;
        }
    }
}
