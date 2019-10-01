using SaTechPiesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaTechPiesShop.ViewModels
{
    public class HomeViewModel
    {
        public List<Pie> Pies { get; set; }
        public string Title { get; set; }
    }
}
