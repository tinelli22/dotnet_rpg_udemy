using System.Text.Json.Serialization;

namespace dotnet_rpg_udemy.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnumRpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}