using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Pais
    {
    [Key]
    public  string ? codPais {get; set;}
    public  string ? NombrePais {get; set;}

    public ICollection<Estado> estados {get; set;}
    
    }
}