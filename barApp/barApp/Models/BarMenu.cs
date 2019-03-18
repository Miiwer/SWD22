using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.Models
{
    public static class BarMenu
    {
        public static Models.MenuCard barMenuCard;

        static BarMenu()
        {
            barMenuCard = new Models.MenuCard();
        }
    }
}

