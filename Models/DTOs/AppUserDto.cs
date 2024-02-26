﻿namespace DevsTutorialCenterAPI.Models.DTOs
{
    public class AppUserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public string Stack { get; set; }

        public string Squad { get; set; }

        public string ImageUrl { get; set; }

        public IList<string> RoleName { get; set; }
    }
}
