using MiniSPA.Server.Models;

namespace MiniSPA.Server.Data
{
    public class MyDataContext
    {
        public List<LinkModel> Links { get; set; }
        public MyDataContext()
        {
            Links = new List<LinkModel>();
        }
    }
}
