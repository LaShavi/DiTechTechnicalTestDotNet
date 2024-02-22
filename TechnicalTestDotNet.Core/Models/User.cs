namespace TechnicalTestDotNet.Core.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }        
        public string Email { get; set; }        
        public bool ResetPassword { get; set; }
        public DateTime? PasswordDate { get; set; }               
        public UserToken UserToken { get; set; }
    }
}
