using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreDomain
{
    public class Permiso{
       public int Id {get; set;}

       [Required]
       [MaxLength(20, ErrorMessage = "El nombre del permiso debe tener máximo 20 caracteres")]
       [RegularExpression(@"^[a-zA-Z]+$")]
       public string Nombre { get; set; } 

       [Required]
       [MaxLength(30, ErrorMessage = "La descripción del permiso debe tener máximo 30 caracteres")]
       [RegularExpression(@"^[a-zA-Z]+$")]
       public string Descripcion {get; set;} 
       public bool Estado {get; set;}  

       //Propiedad para crear una colección de objetos tipo list
       public List<Rol> Roles {get; set;} = new List<Rol>();  

       //Fecha de implementación de un permiso
       public DateTime FechaImplementacion {get; set;}


       //Métodos
       public Permiso()
       {
        //Constructor por defecto
       }   
       public Permiso(string Nombre, string Descripcion, List<Rol> roles, DateTime FechaImplmentacion)
       {
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        Roles = Roles; //Asigna la lista de roles
        FechaImplementacion = FechaImplementacion;// Asigna la fecha de implementación
       }
    }
}