
using TC.GrupoTrinta.BlogNews.Domain.SeedWork;

namespace TC.GrupoTrinta.BlogNews.Domain.Entity
{
    public class Video : AggregateRoot
    {
        public Guid VideoId { get; set; }
        public string NameZip { get; set; }
        public string PathZip { get; set; }
        public DateTime CreateAt { get; private set; }
        public IEnumerable<Image> Images { get; set; }


        public Video(Guid videoId, string nameZip, string pathZip, DateTime createAt, IEnumerable<Image> images) : base()
        {
            VideoId = videoId;
            NameZip = nameZip;
            PathZip = pathZip;
            CreateAt = createAt;
            Images = images;
        }
    }
}
