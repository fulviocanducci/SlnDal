using Models.Base;
using System.ComponentModel.DataAnnotations;
namespace Models
{
   public class People : KeyBase<long>
   {
      [Required(ErrorMessage = "Digite o nome")]
      [MaxLength(100, ErrorMessage = "Até 100 caracteres")]
      public string Name { get; set; }

      [Required(ErrorMessage = "Digite o e-mail")]
      [EmailAddress(ErrorMessage = "E-mail inválido")]
      public string Email { get; set; }
   }
}