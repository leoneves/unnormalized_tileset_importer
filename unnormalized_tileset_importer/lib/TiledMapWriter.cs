using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using Newtonsoft.Json;

namespace TiledMapPipeline 
{
    [ContentTypeWriter]
    public class TiledMapWriter : ContentTypeWriter<string>
    {
        protected override void Write(ContentWriter output, string value)
        {
            output.Write(value);

            /*foreach (var tile in value.Tiles)
            {
                output.Write(tile.FileName);
                output.Write(tile.Width);
                output.Write(tile.Length);
                output.Write(tile.X);
                output.Write(tile.Y);
                output.Write(tile.Anchor.X);
                output.Write(tile.Anchor.Y);
            }*/
        }

        public override string GetRuntimeType(TargetPlatform targetPlatform)
        {
            return "System.Object";
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "TiledMapPipeline.TiledMapReader, TiledMapPipeline";
        }
    }
}
