using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class CheeseListViewModel
    {
        public string Title { get; set; } = "全部";
        public List<Cheese> Cheeses { get; set; }

    }
}
