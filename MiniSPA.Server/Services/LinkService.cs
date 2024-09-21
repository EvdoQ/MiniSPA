using MiniSPA.Server.Data;
using MiniSPA.Server.Models;
using MiniSPA.Server.Services.Interfaces;

namespace MiniSPA.Server.Services
{
    public class LinkService : ILinkService
    {
        private MyDataContext _dataContext;
        public LinkService(MyDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public LinkModel Create(LinkModel model)
        {
            var lastLink = _dataContext.Links.LastOrDefault();
            var newId = lastLink is null ? 1 : lastLink.Id + 1;
            model.Id = newId;
            _dataContext.Links.Add(model);
            return model;
        }

        public List<LinkModel> Get()
        {
            return _dataContext.Links;
        }

        public LinkModel Get(int id)
        {
            return _dataContext.Links.FirstOrDefault(x => x.Id == id);
        }

        public LinkModel Update(LinkModel model)
        {
            var linkToUpdate = _dataContext.Links.FirstOrDefault(x => x.Id == model.Id);
            linkToUpdate.Host = model.Host;
            linkToUpdate.Url = model.Url;
            return linkToUpdate;
        }
        public void Delete(int id)
        {
            var linkToDelete = _dataContext.Links.FirstOrDefault(x => x.Id == id);
            _dataContext.Links.Remove(linkToDelete);
        }
    }
}
