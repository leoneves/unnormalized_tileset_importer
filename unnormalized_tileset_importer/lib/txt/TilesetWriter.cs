using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

namespace TilesetPipeline
{
    [ContentTypeWriter]
    public class TilesetWriter : ContentTypeWriter<TextContentProcessorResult>
    {
        protected override void Write(ContentWriter output, TextContentProcessorResult value)
        {
            value.ContentProcessorContext.Logger.LogMessage("Starting Writer");
            output.Write(value.Text);
            value.ContentProcessorContext.Logger.LogMessage("Writer Finished!");
        }

        public override string GetRuntimeType(TargetPlatform targetPlatform)
        {
            return typeof(string[]).AssemblyQualifiedName;
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "TilesetPipeline.TilesetReader, unnormalized_tileset_importer";
        }
    }
}
