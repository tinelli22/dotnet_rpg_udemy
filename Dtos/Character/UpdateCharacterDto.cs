using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg_udemy.Models;

namespace dotnet_rpg_udemy.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public EnumRpgClass Class { get; set; } = EnumRpgClass.Knight;
    }
}