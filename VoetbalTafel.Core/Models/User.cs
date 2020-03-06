using VoetbalTafel.Core;

namespace VoetbalTafel.Core.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}