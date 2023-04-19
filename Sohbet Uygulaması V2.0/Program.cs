using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sohbet_Uygulaması_V2._0
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
            string ApiKey = config.DocumentElement.SelectSingleNode("/Firebase/ApiKey").InnerText.Trim();
            string AuthDomain = config.DocumentElement.SelectSingleNode("/Firebase/AuthDomain").InnerText.Trim();
            MessageBox.Show(ApiKey);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
