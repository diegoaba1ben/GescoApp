using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace CoreDomain
{
    public class Usuario{
        //Propiedades
        public int Id {get; set;}

        [Required]
        [MaxLength(30, ErrorMessage = "El nombre de usuario debe tener máximo 30 caracteres")]
        public string  Nombre {get; set;} = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(25, ErrorMessage = "El password debe tener máximo 25 caracteres")]
        public string Correo {get; set;} = string.Empty;

        [Required]
        [MinLength(8, ErrorMessage = "La contraseña debe tener mínimo 8 caracteres")]
        [MaxLength(12, ErrorMessage ="La contraseña debe tener maximo 12 caracteres")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")]
        public string Contrasena {get; set;} = string.Empty;

        [Required]
        [CustomValidation(typeof(Usuario),"ValidateEstadoProperty")]
        public bool Estado {get; set;} 

        [Required]
        public DateTimeOffset FechaCreacion {get; set;} 

        //Propiedad para crear una colección de objetos tipo list
        public List<Rol> Roles {get; set;} = new List<Rol>();
        public DateTime FechaImplementacion {get; set;}

        public int RolId {get; set;}
        public Rol Rol {get; set;} = new Rol();

        //Métodos
        public Usuario(){
            //Constructor vacío por defecto
        } 

        public Usuario(String Nombre, string Correo, string Contrasena, bool Estado,
          List<Rol> roles, DateTimeOffset FechaCreacion, DateTime FechaImplementacion )
          {
            this.Nombre = Nombre;
            this.Correo = Correo;
            this.Contrasena = Contrasena;
            this.FechaCreacion = FechaCreacion;
            this.FechaImplementacion = FechaImplementacion;
            Roles = roles;
          }

        //Validación para el atributo Estado
        public static ValidationResult ValidateEstadoProperty(object estado, ValidationContext context)
        {
            if((bool) estado !=true && (bool) estado != false)
            {
                return new ValidationResult("El estado debe ser activo o inactivo", new[]{
                nameof(Estado)});
            }
            return ValidationResult.Success;
        }  
    }
}