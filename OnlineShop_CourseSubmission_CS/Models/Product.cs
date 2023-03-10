using System.Text.Json.Serialization;

namespace OnlineShop_CourseSubmission_CS.Components
{
    public class Products
    {
		[JsonPropertyName("id")]
		public int Id { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
		[JsonPropertyName("price")]
		public decimal Price { get; set; }
		[JsonPropertyName("description")]
		public string? Description { get; set; }
		[JsonPropertyName("category")]
		public string? Category { get; set; }
		[JsonPropertyName("image")]
		public string? Image { get; set; }
		[JsonPropertyName("rating")]
		public Rating? Rating { get; set; }
    }
}