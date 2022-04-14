using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static Android.Provider.CalendarContract;

namespace ÔneSend.Models
{
    public class Product
    {

        public Product()
        {
            this.Colors = new List<Colors>();
            this.Id = Guid.NewGuid().ToString();
        }

        public List<Colors> Colors { get;  set; }
        public string Id { get;  set; }
        public string description { get; set; }
        public double rating { get; set; }

        public int review { get; set; }
        public double oldPrice { get; set; }
        public double newprice { get; set; }
        public bool favorite { get; set; }
        public double discount { get; set; }
        public string image { get; set; }
        public string createBy { get; set; }
         public string overview { get; set; }
    }

    public class color
    {
        public string color { get; set; }

    }
}
