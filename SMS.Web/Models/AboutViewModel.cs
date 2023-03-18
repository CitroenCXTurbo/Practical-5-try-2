using System;

namespace SMS.Web.Models
{
    public class AboutViewModel
    {
        public string Title { get; set; }
        public string Messageout { get; set; }
        public DateTime Formed { get; set; } = DateTime.Now;
        public string FormedString => Formed.ToShortDateString();
        public int Days => (DateTime.Now - Formed).Days;
    }
}