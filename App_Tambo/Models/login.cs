using System.ComponentModel.DataAnnotations;

namespace App_Tambo.Models
{
    public class login
    {
        [Key]
        public string nombre { get; set; }
        public string password { get; set; }
    }
}
