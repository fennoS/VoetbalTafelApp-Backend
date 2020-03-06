using System;
using System.ComponentModel.DataAnnotations;

namespace VoetbalTafel.Core.Models
{
    public class BaseModel : BaseModel<int>
    { }
    
    public class BaseModel<TKey>
    {
        public BaseModel()
        {
            DateCreated = DateTime.UtcNow;
        }

        [Key]
        public TKey Id { get; set; }

        public DateTime DateCreated { get; set; }
    }
}