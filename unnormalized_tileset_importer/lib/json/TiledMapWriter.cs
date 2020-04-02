using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using Newtonsoft.Json;

namespace TiledMapPipeline 
{
    [ContentTypeWriter]
    public class TiledMapWriter : ContentTypeWriter<JsonContentProcessorResult>
    {
        protected override void Write(ContentWriter output, JsonContentProcessorResult value)
        {
            value.ContentProcessorContext.Logger.LogMessage("Starting Writer");
            output.Write(value.Json);
            value.ContentProcessorContext.Logger.LogMessage("Json {0}:", value.Json);
            value.ContentProcessorContext.Logger.LogMessage("Writer Finished!");
        }

        public override string GetRuntimeType(TargetPlatform targetPlatform)
        {
            return typeof(TilesCoorinatesJson).AssemblyQualifiedName;
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "TiledMapPipeline.TiledMapReader, unnormalized_tileset_importer";
        }
    }
}
