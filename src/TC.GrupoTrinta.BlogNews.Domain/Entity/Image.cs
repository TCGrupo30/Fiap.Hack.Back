
using TC.GrupoTrinta.BlogNews.Domain.SeedWork;

namespace TC.GrupoTrinta.BlogNews.Domain.Entity
{
    public class Image : AggregateRoot
    {
        public Guid ImageId { get; set; }
        public Guid VideoId { get; set; }        
        public string NameImage { get; set; }
        public string PathImagem { get; set; }
        public DateTime CreateAt { get; private set; }

        public Image(Guid imageId, Guid videoId, string nameImage, string pathImagem, DateTime createAt)
        {
            ImageId = imageId;
            VideoId = videoId;
            NameImage = nameImage;
            PathImagem = pathImagem;
            CreateAt = createAt;
        }
    }
}
