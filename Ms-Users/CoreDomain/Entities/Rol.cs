using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace CoreDomain{
    public class Rol{
       public int Id {get; set;}
       public string Nombre { get; set; }
       public string Descripcion {get; set;}
       public bool Estado {get; set;}
       public DateTime FechaModificacion {get; set;}

       //Métodos
       public Rol(string Nombre, string Descripcion){
        Nombre = Nombre;
        Descripcion = Descripcion;
        Estado=true;
        FechaModificacion = DateTime.Now;
       }
    }
}