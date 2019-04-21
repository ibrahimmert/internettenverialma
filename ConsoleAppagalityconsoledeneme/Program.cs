using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppagalityconsoledeneme
{
    class Program
    {
        static void Main(string[] args)
        {

            HtmlAgilityPack.HtmlWeb hweb = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument hdoc = hweb.Load("https://www.sozcu.com.tr/2017/otomotiv/boeing-777-ucak-degil-surucusuz-araba-1670919/");
            for (int i = 1; i < 40; i++)
            {
                foreach (HtmlAgilityPack.HtmlNode item in hdoc.DocumentNode.SelectNodes("//*[@id=printable]/div[1]/div/div[1]/div[2][" + i + "]"))
                {
                    
                    Console.WriteLine( item.InnerText.ToString);

                }
            }
        }



    }
}
