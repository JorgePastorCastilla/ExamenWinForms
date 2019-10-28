using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Films
    {

        public int film_id { get; set; }
        public string title { get; set; }

        public string description { get; set; }

        public int length { get; set; }

        public string rating { get; set; }

        public string language { get; set; }

        public string ShowTitle
        {
            get
            {
                return title;
            }
        }

        /*
        public string FullInfo
        {
            get
            {
                return film_id + ":\t" + title;
            }
        }*/

    }
}
