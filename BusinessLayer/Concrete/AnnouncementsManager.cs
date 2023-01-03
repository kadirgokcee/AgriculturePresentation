using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementsManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementsManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Delete(Announcements t)
        {
            _announcementDal.Delete(t);
        }

        public Announcements GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcements> GetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void Insert(Announcements t)
        {
            _announcementDal.Insert(t);
        }

        public void Update(Announcements t)
        {
            _announcementDal.Update(t);
        }
    }
}
