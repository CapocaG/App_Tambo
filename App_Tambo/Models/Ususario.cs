using System;
using System.Collections.Generic;

#nullable disable

namespace App_Tambo.Models
{
    public partial class Ususario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
