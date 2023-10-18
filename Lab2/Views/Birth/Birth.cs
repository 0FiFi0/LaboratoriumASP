using Lab2.Models;

namespace Lab2.Views.Birth
{
    public class Birth
    {
        public DateTime birth { get; set; }
        public string? name { get; set; }

        public double Calculate()
        {
            return DateTime.Now.Year - birth.Year;
        }
    }
}
