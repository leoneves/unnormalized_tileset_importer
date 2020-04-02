using System;
using Microsoft.Xna.Framework.Content.Pipeline;
using UnnormalizedTilesetImporter;

namespace TiledMapPipeline
{
    [ContentProcessor(DisplayName = "Tiled Map Processor")]
    public class TiledMapProcessor : ContentProcessor<string, ContentProcessorResult>
    {
        public override ContentProcessorResult Process(string input, ContentProcessorContext context)
        {
            try
            {
                context.Logger.LogMessage("Starting Processor");
                var output = new ContentProcessorResult
                {
                    ContentValue = input,
                    ContentProcessorContext = context
                };
                context.Logger.LogMessage("Processor Finished");
                return output;
            }
            catch (Exception ex)
            {
                context.Logger.LogMessage("Error {0}", ex);
                throw;
            }
        }
    }
}
