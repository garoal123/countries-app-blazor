using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLogin.Shared
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo es inválido.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Clave { get; set; }
    }

    public class LoginResult
    {
        public string uid { get; set; }
        public string email { get; set; }
        public string error { get; set; }
    }

     // Clase que modela el documento que esperas de Firestore
    public class UserDocument
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Continente { get; set; }
        public bool IsAdmin { get; set; }
    }
}
