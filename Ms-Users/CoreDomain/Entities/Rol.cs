using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace CoreDomain
{
    public class Rol{
       public int Id {get; set;}

       [Required]
       [MaxLength(20, ErrorMessage = "El nombre del rol debe tener máximo 20 caracteres")]
       [RegularExpression(@"^[a-zA-Z]+$")]
       public string Nombre { get; set; } = string.Empty;

       [Required]
       [MaxLength(30, ErrorMessage = "La descripción del rol debe tener máximo 30 caracteres")]
       [RegularExpression(@"^[a-zA-Z]+$")] 
       public string Descripcion {get; set;} = string.Empty;
       public bool Estado {get; set;} [Required]
       public DateTime FechaModificacion {get; set;} 

       //Propiedad para crear una colección de objetos tipo list
       public List<Permiso> Permisos {get; set;} = new List<Permiso>(); 

       //Métodos
       public Rol(string Nombre, string Descripcion ,DateTime FechaModificacion, List<Permiso>permisos){
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.FechaModificacion = FechaModificacion;
        Permisos = permisos;

       }

        public Rol()
        {
            //Constructor vacío por defecto
        }
    }
}