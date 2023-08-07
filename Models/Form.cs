using System.ComponentModel.DataAnnotations;

public class Form{
    [Required]
    [Display(Name = "Correo Electronico")]
    public string Mail { get; set; }
    [Required]
    [Display(Name = "Contraseña")]
    public string Password { get; set; }
}