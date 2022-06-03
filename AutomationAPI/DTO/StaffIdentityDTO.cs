using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.DTO
{
    public class StaffIdentityDTO
    {
        public string IdentityJwt { get; set; }
        public long TimeToLiveSeconds { get; set; }
    }
}
