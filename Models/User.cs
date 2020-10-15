using System.ComponentModel.DataAnnotations;

namespace AS_DojoSurveyValidation.Models
{
    public class User
    {
        [Required]
        [MinLength(2,ErrorMessage="You need more characters")]
        public string Name {get;set;}

        [Required]
        public string Location {get;set;}

        [Required]
        public string Language {get;set;}

        [MinLength(20,ErrorMessage="Comment should be more than 20 characters")]
        public string Comment {get;set;}
    }
}