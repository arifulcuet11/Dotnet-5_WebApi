using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static WebApp.Domain.Auth.IdentityModels;

namespace WebApp.Domain.Auth
{
    public class ApplicationUser : IdentityUser<long>
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string MiddleName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(512)]
        public string Address { get; set; }

        public string ProfilePicSrc { get; set; }

        [Required]
        public int AccountStatus { get; set; }

        [Required]
        public DateTime CreatedDateUtc { get; set; }

        public DateTime? UpdatedDateUtc { get; set; }

    }
}
