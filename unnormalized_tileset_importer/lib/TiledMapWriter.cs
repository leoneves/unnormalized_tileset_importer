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
            output.Write(value.Json);
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
