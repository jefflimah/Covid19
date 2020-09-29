using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class Paciente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public bool flComorbidade { get; set; }
        public DateTime DataRegistro { get ; set; }
}
}
