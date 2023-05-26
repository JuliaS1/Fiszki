using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiszki.Models
{
    public class Fiszkii
    {   [Key]
        public int id_fiszki { get; set; }
        [DisplayName("Nazwa")]
        public string Nazwa_fiszki { get; set; }
        public string Opis { get; set; }
        public string Przedmiot { get; set; }
        public string Kategoria { get; set; }
        public bool Zrobione { get; set; }
        public bool Done { get; internal set; }
    }
}
