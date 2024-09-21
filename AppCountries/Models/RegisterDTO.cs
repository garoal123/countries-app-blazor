using System.ComponentModel.DataAnnotations;

public class RegisterDTO
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "Los apellidos son obligatorios.")]
    public string Apellidos { get; set; }

   /*[Required(ErrorMessage = "El teléfono es obligatorio.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Número de teléfono no válido.")]
    public string Telefono { get; set; }*/

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Correo electrónico no válido.")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [StringLength(100, ErrorMessage = "La contraseña debe tener al menos {2} caracteres.", MinimumLength = 6)]
    public string Contrasena { get; set; }

    [Required(ErrorMessage = "La confirmación de contraseña es obligatoria.")]
    [Compare("Contrasena", ErrorMessage = "Las contraseñas no coinciden.")]
    public string ConfirmarContrasena { get; set; }

    [Required(ErrorMessage = "El continente es obligatorio.")]
    public string Continente { get; set; }

    /*[Required(ErrorMessage = "El país es obligatorio.")]
    public string Pais { get; set; }*/
}
