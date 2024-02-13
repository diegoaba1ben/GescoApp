using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

//1. Bloque de validaciones generales


/// <summary>
/// Verifica que una propiedad en un objeto no sea nula ni vacía.
/// </summary>
/// <typeparam name="T">Tipo del objeto</typeparam>
/// <param name="objeto">Objeto a validar</param>
/// <param name="nombrePropiedad">Nombre de la propiedad a verificar</param>
/// <returns>True si la propiedad no es nula ni vacía; de lo contrario, false.</returns>
namespace CoreDomain
{
   //1.1   Validación que un campo no sea nula o vacía 
   public static class ValidacionesVacio
   {
      public static bool CampoNuloNiVacio<T>(T objeto, string nombrePropiedad)
      {
         try
         {
            var propiedad = typeof(T).GetProperty(nombrePropiedad);
            if (propiedad == null)
            {
               throw new ArgumentException($"La propiedad llamada '{nombrePropiedad}' no existe en la clase '{typeof(T)}'");
            }

            var valor = propiedad.GetValue(objeto);
            if (valor == null)
            {
               throw new ArgumentException($"El campo '{nombrePropiedad}' no puede ser nulo");
            }

            if (valor is string text && string.IsNullOrWhiteSpace(text))
            {
               throw new ArgumentException($"El campo '{nombrePropiedad}' no puede ser una cadena vacía o con espacios en blanco");
            }
            return true; //Porque el campo no es ni nulo ni vacío
         }
         catch (Exception ex)
         {
            throw new Exception($"Error al validar la propiedad '{nombrePropiedad}' en la clase '{typeof(T)}'", ex);
         }
      }
   }
   //1.2   Validación del formato correcto en la fecha para Colombia
   // Función pública que verifica si una fecha es válida
   public class ValidaFecha
   {
      public static bool ValidDate(string textoFecha, out DateTime fecha)
      {
         try
         {
            // Verifica la longitud del string
            if (textoFecha.Length != 10)
            {
               fecha = default; // Asigna un valor por defecto a 'fecha'
               return false; // Longitud no válida
            }

            // Intenta convertir el string a un objeto DateTime
            if (!DateTime.TryParseExact(textoFecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
               return false; // No se pudo convertir a una fecha válida
            }

            // La fecha es válida
            return true;
         }
         catch (Exception ex)
         {
            throw new Exception($"Error al validar la fecha: {ex.Message}");
         }
      }
   }
  //2. Validaciones específicas para la clase usuario


}







//2.4   Verificar que las contraseñas sean iguales (validarPassword)
//2.5   Validar que los usuarios no contengan caracteres especiales o palabras reservadas
//2.6   Verificar la unicidad del correo
//2.7   Verificar la unicidad del rol
//2.8   Validar en la clase RolPermiso que rol y permiso sean válidos

//3. Validaciones adicionales
//3.1   Validar que los espacios del estado o la fecha esté diligenciados  
//3.2   Validar que un usuario tenga los permisos para realizar una acción
//3.3   Verificar que la creación del id de la tabla navegacional se correcta
//3.4   Verifica que un usuario solo tenga roles válidos y y rol permisos válidos 


