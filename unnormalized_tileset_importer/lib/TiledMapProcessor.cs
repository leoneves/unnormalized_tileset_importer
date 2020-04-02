using System.Diagnostics;
using Newtonsoft.Json;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledMapPipeline
{
    [ContentProcessor(DisplayName = "Tiled Map Processor")]
    public class TiledMapProcessor : ContentProcessor<string, string>
    {
        public ContentBuildLogger Logger;

        public override string Process(string input, ContentProcessorContext context)
        {
            context.Logger.LogMessage("Processing TiledCoordenates 7");
            return input;
        }
    }
}
