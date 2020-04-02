using System;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledMapPipeline
{
    [ContentProcessor(DisplayName = "Tiled Map Processor")]
    public class TiledMapProcessor : ContentProcessor<string, JsonContentProcessorResult>
    {
        public override JsonContentProcessorResult Process(string input, ContentProcessorContext context)
        {
            try
            {
                context.Logger.LogMessage("Starting Processor");
                var output = new JsonContentProcessorResult
                {
                    Json = input,
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
