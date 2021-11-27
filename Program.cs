using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace Webclient
{
    
    internal class Program
    {
        static async void Main(string[] args)

        {
                WebClient webClient = new WebClient();
                {
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/879550291773648957/913989307713343529/ReadMe.md", "ReadMe.md");
                }
                //esto puede ser utilizado para diferentes proyectos de c sharp como windows forms etc.

            
        }
    }
}
