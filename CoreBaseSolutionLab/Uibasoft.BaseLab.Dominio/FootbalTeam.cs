using System;

namespace Uibasoft.BaseLab.Dominio
{
    public class FootbalTeam : Entity
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public DateTime CreateDate { get; set; }
        public string Manager { get; set; }
    }
}
