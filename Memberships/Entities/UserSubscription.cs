﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("UserSubscription")]
    public class UserSubscription
    {
        [Required]
        [Key,Column(Order = 1)]
        public int UserSubscriptionId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        [MaxLength(128)]
        public string UserIs { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
    }
}