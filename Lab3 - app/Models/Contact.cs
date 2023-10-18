using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3___app.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
       
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Imię zbyt długie, maksymalnie 50 znaków.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Musisz podać poprawny email!")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Numer telefonu powienien zawierać cyfry!")]
        public string Phone { get; set; }
       
        public DateTime? Birth { get; set; }

    }
}
