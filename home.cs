using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class home
    {
        private int id;
        private String name;
        private String zone;
        private String status;
        private int currentPlace;

        public home(string name, string zone, string status, int currentPlace)
        {
            this.name = name;
            this.zone = zone;
            this.status = status;
            this.currentPlace = currentPlace;
        }

        public home(int id, string name, string zone, string status, int currentPlace)
        {
            this.id = id;
            this.name = name;
            this.zone = zone;
            this.status = status;
            this.currentPlace = currentPlace;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Zone { get => zone; set => zone = value; }
        public int CurrentPlace { get => currentPlace; set => currentPlace = value; }
        public string Status { get => status; set => status = value; }
    }
}
