using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//1. Bloque de validaciones generales
//1.1   Validación que una cadena no sea nula o vacía
   namespace CoreDomain{} 
//1.2   Validación del formato correcto, en fecha
//1.3   Limitación de la longitud de los campos
//1.4   Validación que una cadena sea alfabética, incluso en otros idiomas
//1.5   Validar que un correo electrónico sea válido

//2. Validaciones específicas para la clase usuario
//2.1   Verificar si el nombre es diferentes a nulo o vacío
//2.2   Validar que la propiedad password tenga una esté dentro de la longitud requerida
//2.3   Verificar que la contraseña exija caracteres especiales, números y letras minúsculas y mayúsculas
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

 
