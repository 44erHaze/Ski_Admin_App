using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Admin_App
{
    public class ServiceAuftrag
    {
        public int AuftragsID { get; set; }
        public string Kundenname { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int Priorität { get; set; }
        public string Dienstleistung { get; set; }
        public string Status { get; set; }
    }

}
