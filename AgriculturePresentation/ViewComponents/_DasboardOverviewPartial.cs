using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DasboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.urunPazarlama = c.Teams.Where(x => x.Title == "Süt ve süt ürünleri").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.toprakYönetimi = c.Teams.Where(x => x.Title == "Toprak Mahsulleri").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYonetimi = c.Teams.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.gubreYonetimi = c.Teams.Where(x => x.Title == "Gübre Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
