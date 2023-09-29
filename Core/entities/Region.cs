using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.entities
{
    public class Region
    {
    [Key]
    public  string ? codRegion {get; set;}
    public  string ? NombreRegion {get; set;}

    public string ? codEstado{get; set;}

    public Estado estado {get; set;}
    
    }
}