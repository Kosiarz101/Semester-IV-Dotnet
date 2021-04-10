using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjection.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        [MaxLength(300)]
        public string Image { get; set; }
        [MaxLength(300)]
        public string Url { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
