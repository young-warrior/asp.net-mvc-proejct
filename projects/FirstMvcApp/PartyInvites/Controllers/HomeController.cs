using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        /*Давайте представим себе, что подруга решила провести вечеринку в канун Нового года, 
         * и что она попросила нас создать веб сайт, который позволит ее друзьям и знакомым 
         * принять приглашение с RSVP (подпись на приглашении, призывающая получателя дать ответ
         * об участии в мероприятии). На сайте должно присутствовать следующее:

            1   Главная страница, где отображается информация о вечеринке
            2   Форма, которая может быть использована для RSVP
            3   Валидация RSVP формы, которая отобразит страницу с благодарностью
            4   Заполненный и отправленный ответ о согласии принять участие в вечеринке*/
        // GET: /Home/

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        //Добавление в контроллер нового метода действия
        public ViewResult RsvpForm()
        {
            return View();
        }

    }
}
