using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnTurPåBibloteket
{
    class Bog
    {
        public string bogNavn { get; set; }

        public DateTime bogUdlåningsDato { get; set; }

        public Bog(string _bogNavn, DateTime _bogUdlåningsDato)
        {
            bogNavn = _bogNavn;
            bogUdlåningsDato = _bogUdlåningsDato;
        }
    }
}
