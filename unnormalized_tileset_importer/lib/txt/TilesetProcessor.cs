using System;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TilesetPipeline
{
    [ContentProcessor(DisplayName = "Tileset Processor")]
    public class TilesetProcessor : ContentProcessor<string, TextContentProcessorResult>
    {
        public override TextContentProcessorResult Process(string input, ContentProcessorContext context)
        {
            try
            {
                context.Logger.LogMessage("Starting Processor");
                var output = new TextContentProcessorResult
                {
                    Text = input,
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
