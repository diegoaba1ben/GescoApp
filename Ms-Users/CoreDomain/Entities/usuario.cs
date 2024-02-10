using System;
using System.Collections.Generic;

namespace CoreDomain{
    public class Usuario{
        //Ptopiedades
        public int Id {get; set;}
        public string  Nombre {get; set;}
        public string Correo {get; set;}
        public string Password {get; set;}
        public bool Estado {get; set;}
        public DateTime FechaCreacion {get; set;}


        private int RolId {get; set;}
        private Rol Rol {get; set;}

        //Métodos
        public Usuario(){
            //Constructor vacío por defecto
        }    
       
       
    }
}