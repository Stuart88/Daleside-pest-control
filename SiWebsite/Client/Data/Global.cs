using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiWebsite.Data
{
    public static class Global
    {
        public static readonly string SiteName = "Daleside Pest Control";
        public static readonly string Slogan = "Local pest control for you";
        public static readonly string ContactNum = "07875 687 790";

        public static string[] PestsList =
        {
            "Rabbits", 
            "Rats", 
            "Moles", 
            "Squirrels", 
            //"Pigeons", 
            //"Corvids", 
            "Mink",
        };

        public static string selectedPestItem = "";

        public static void SetSelectedPestItem(string pest)
        {
            selectedPestItem = pest;
        }

        public static int HeaderHeight = 60;
        public static int FooterHeight = 100;
        
    }
}
