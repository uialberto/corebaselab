using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiWeb.DTOs
{
    public class FootbalTeamDto
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public DateTime CreateDate { get; set; }
        public string Manager { get; set; }
    }
}
