using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3___app.Models
{
    public class Photo
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę autora!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Nazwa autora zbyt długa, maksymalnie 30 znaków.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Musisz podać opis!")]
        [StringLength(maximumLength: 120, ErrorMessage = "Opis zbyt długie, maksymalnie 120 znaków.")]
        public string Description { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "Model apartatu zbyt długi, maksymalnie 50 znaków.")]
        public string Camera { get; set; }

        [StringLength(maximumLength: 20, ErrorMessage = "Podana rozdzielczość jest zbyt długi, maksymalnie 20 znaków.")]
        public string Resolution { get; set; }

        [Required(ErrorMessage = "Musisz podać format!")]
        [StringLength(maximumLength: 10, ErrorMessage = "Podany format jest zbyt długi, maksymalnie 10 znaków.")]
        public string Format { get; set; }

        public DateTime? DateAndTime { get; set; }
    }
}
