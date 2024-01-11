using System.ComponentModel.DataAnnotations;

namespace jwtAuth.Core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
    }
}
