using System.ComponentModel.DataAnnotations;

namespace RS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}