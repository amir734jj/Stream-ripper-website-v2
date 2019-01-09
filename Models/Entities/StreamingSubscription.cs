using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Models.Enums;
using Models.Interfaces;

namespace Models.Entities
{
    /// <summary>
    /// Streaming Subscription
    /// </summary>
    public class StreamingSubscription : IBasicModel
    {
        [Key]
        public int Id { get; set; }
        
        public string Url { get; set; }
        
        public string Token { get; set; }
        
        /// <summary>
        /// User reference
        /// </summary>
        public IdentityUser User { get; set; }
        
        /// <summary>
        /// Service type
        /// </summary>
        public ServiceTypeEnum ServiceType { get; set; }
    }
}