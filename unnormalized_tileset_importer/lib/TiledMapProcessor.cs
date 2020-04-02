using System;
using System.ComponentModel;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledMapPipeline
{
    [ContentProcessor(DisplayName = "Tiled Map Processor")]
    public class TiledMapProcessor : ContentProcessor<ContentImporterResult<string>, JsonContentProcessorResult>
    {
        public override JsonContentProcessorResult Process(ContentImporterResult<string> input, ContentProcessorContext context)
        {
            try
            {
                var output = new JsonContentProcessorResult
                {
                    Json = input.Data
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
