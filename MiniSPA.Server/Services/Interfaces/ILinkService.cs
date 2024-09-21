using MiniSPA.Server.Models;

namespace MiniSPA.Server.Services.Interfaces
{
    public interface ILinkService
    {
        List<LinkModel> Get();
        LinkModel Get(int id);
        LinkModel Create(LinkModel model);
        LinkModel Update(LinkModel model);
        void Delete(int id);
    }
}
