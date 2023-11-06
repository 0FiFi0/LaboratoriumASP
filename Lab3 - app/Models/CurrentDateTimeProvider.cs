namespace Lab3___app.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        { 
            return DateTime.Now; 
        }  
    }
}
