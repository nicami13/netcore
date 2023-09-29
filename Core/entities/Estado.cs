using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Estado
    {
        [Key]
        public  string ? codEstado {get; set;}
        public  string ? NombreEstado {get; set;}

        public string ? codPais {get; set;}

        public Pais pais {get; set;}
        public ICollection<Region> Regiones {get; set;}
    }
}