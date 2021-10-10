using System.Text.Json.Serialization;

namespace dotnet_rpg.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
         Knight,
         Mage,
         Cleric
        
    }
}