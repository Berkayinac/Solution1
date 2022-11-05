using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflarim
{
    public class Kahve
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        private int fiyat;
        public int Fiyat
        {
            get
            {
                return fiyat;
            }

            set
            {
                if (value > 100)
                {
                    value = 100;
                    fiyat = value;
                }
            }
        }
    }
}
