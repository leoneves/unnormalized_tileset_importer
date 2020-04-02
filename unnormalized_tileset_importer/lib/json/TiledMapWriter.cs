using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using UnnormalizedTilesetImporter;

namespace TiledMapPipeline 
{
    [ContentTypeWriter]
    public class TiledMapWriter : ContentTypeWriter<ContentProcessorResult>
    {
        protected override void Write(ContentWriter output, ContentProcessorResult value)
        {
            value.ContentProcessorContext.Logger.LogMessage("Starting Writer");
            output.Write(value.ContentValue);
            value.ContentProcessorContext.Logger.LogMessage("Json {0}:", value.ContentValue);
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
