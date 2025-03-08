﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Entities
{
    public class AuditLogsEntity
    {
        public int LogId { get; set; }
        public string Action { get; set; } = string.Empty;
        public int UserId {  get; set; }
        public UserEntity User { get; set; }
        public DateTime LogTime { get; set; }
    }
}
