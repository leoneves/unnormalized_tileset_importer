using System.Diagnostics;
using Newtonsoft.Json;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledMapPipeline
{
    [ContentProcessor(DisplayName = "Tiled Map Processor")]
    public class TiledMapProcessor : ContentProcessor<string, TilesCoorinatesJson>
    {
        public ContentBuildLogger Logger;

        public override TilesCoorinatesJson Process(string input, ContentProcessorContext context)
        {
            context.Logger.LogMessage("Processing TiledCoordenates");
            TilesCoorinatesJson tilesCoorinatesJson  = JsonConvert.DeserializeObject<TilesCoorinatesJson>(input);
            return tilesCoorinatesJson;
        }
    }
}
