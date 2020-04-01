using System.Diagnostics;
using Newtonsoft.Json;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledMapPipeline
{
    [ContentProcessor(DisplayName = "Tiled Map Processor")]
    public class TiledMapProcessor : ContentProcessor<string, TiledMapProcessorResult>
    {
        public ContentBuildLogger Logger;

        public override TiledMapProcessorResult Process(string input, ContentProcessorContext context)
        {
            context.Logger.LogMessage("Processing TiledCoordenates");
            TilesCoorinatesJson tilesCoorinatesJson  = JsonConvert.DeserializeObject<TilesCoorinatesJson>(input);
            return new TiledMapProcessorResult(tilesCoorinatesJson, context.Logger);
        }
    }
}
