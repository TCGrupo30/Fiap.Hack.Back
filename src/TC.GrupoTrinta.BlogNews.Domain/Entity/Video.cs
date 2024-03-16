
using TC.GrupoTrinta.BlogNews.Domain.SeedWork;

namespace TC.GrupoTrinta.BlogNews.Domain.Entity
{
    public class Video : AggregateRoot
    {
        public Guid VideoId { get; set; }
        public string NameZip { get; set; }
        public string PathZip { get; set; }
        public DateTime CreateAt { get; private set; }


        public Video(Guid videoId, string nameZip, string pathZip, DateTime createAt) : base()
        {
            VideoId = videoId;
            NameZip = nameZip;
            PathZip = pathZip;
            CreateAt = createAt;
        }
    }
}
