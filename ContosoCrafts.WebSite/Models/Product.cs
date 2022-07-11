using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.Website.Models
{
	public class Product
    {
        public sting Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; }

        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}