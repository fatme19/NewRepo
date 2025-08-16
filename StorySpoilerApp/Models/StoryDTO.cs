using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StorySpoilerApp.Models
{
    internal class StoryDTO
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }


        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("url")]
        public string? URL { get; set; }
    }
}
