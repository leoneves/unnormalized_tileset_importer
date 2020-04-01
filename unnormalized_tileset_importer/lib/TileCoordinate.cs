using Newtonsoft.Json;

namespace TiledMapPipeline
{
    public class TilesCoorinatesJson
    {
        [JsonProperty("tiles")]
        public TileCoordinates[] Tiles { get; set; }
    }

    public class TileCoordinates
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("anchor")]
        public Anchor Anchor { get; set; }
    }

    public class Anchor
    {
        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }
    }
}
