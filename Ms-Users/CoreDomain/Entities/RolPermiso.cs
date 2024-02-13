using System;
using System.Collections.Generic;

namespace CoreDomain{
    public class RolPermiso{
      public int RolId {get; set;}
      public int PermisoId {get; set;}
      public Rol Rol {get; set;}
      public Permiso Permiso {get; set;}

       //Métodos
       public RolPermiso(string Nombre, string Descripcion){
        RolId = 0; //Asigna del valor válido para RolId
        PermisoId = 0; //Asigna del valor válido para Permiso
        Rol = new Rol();//Inicializa la propiedad Rol con un objeto del tipo Rol
        Permiso = new Permiso();//Inicializa la propiedad  Permiso con un objeto del tipo Permiso

        RolId = RolId;
        PermisoId = PermisoId;
       }
       public RolPermiso()
       {
        //Constructor vacío
       }
       //Validación que el  rol y el permiso no sean nulos
       public bool Validar()
       {
        if(Rol == null)
        {
          return false;
        }
        if (Permiso == null)
        {
          return false;
        }
        return true;
       }
    }
}