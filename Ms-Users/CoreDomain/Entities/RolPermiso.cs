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
        RolId = RolId;
        PermisoId = PermisoId;
       }
    }
}