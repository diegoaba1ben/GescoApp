using System;
using System.Collections.Generic;

// Archivo: Validations.cs

public interface IValidatable
{
    bool EsValido();
}

public static class Validaciones
{
    public static bool EsValido<T>(T obj) where T : IValidatable
    {
        // Recorrer las propiedades de la clase
        foreach (var propiedad in obj.GetType().GetProperties())
        {
            // Obtener el valor de la propiedad
            var valorPropiedad = propiedad.GetValue(obj);

            // Validar si el valor es nulo o vacío
            if (valorPropiedad == null || string.IsNullOrEmpty(valorPropiedad.ToString()))
            {
                return false;
            }
        }

        return true;
    }
}

public class Usuario : IValidatable
{
    public string Nombre { get; set; }
    public string Correo {get; set;}
    public string Password {get; set;}
    public DateTime FechaCreacion {get; set;}

    public bool EsValido()
    {
        if (string.IsNullOrEmpty(Nombre)){
            return false;
        }
        if(string.IsNullOrEmpty(Correo)){
            return false;
        }
        if(string.IsNullOrEmpty(Password) || Password.Length < 12){
            return false;
        }
        return true;
    }
}

public class Rol : IValidatable
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }

    public bool EsValido()
    {
       if(string.IsNullOrEmpty(Nombre)){
        return false;
       }
       if(string.IsNullOrEmpty(Descripcion)){
        return false;
       }
       return true;
    }
}
public class Permiso : IValidatable
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }

    public bool EsValido()
    {
       if(string.IsNullOrEmpty(Nombre)){
        return false;
       }
       if(string.IsNullOrEmpty(Descripcion)){
        return false;
       }
       return true;
    }
}


