using System.ComponentModel.DataAnnotations;


namespace ECommerce.API.Contracts
{
    public record LoginUserRequest
       (
           [Required] string Login,
           [Required] string Password
       );
}
