﻿namespace JoycePrint.Domain.Models
{
    public class Contact
    {
        /// <summary>
        /// The company the contact represents
        /// </summary>
        public string Company { get; set; }
        
        /// <summary>
        /// The name of the contact
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the contact
        /// </summary>        
        public string Phone { get; set; }
        
        /// <summary>
        /// The contacts email address
        /// </summary>        
        public string Email { get; set; }
    }
}