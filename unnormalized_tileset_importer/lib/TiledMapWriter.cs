using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

namespace TiledMapPipeline 
{
    public class TiledMapWriter : ContentTypeWriter<TiledMapProcessorResult>
    {
        protected override void Write(ContentWriter output, TiledMapProcessorResult value)
        {
            output.Write(value.TilesCoorinatesJson.Tiles.Length);

            foreach (var tile in value.TilesCoorinatesJson.Tiles)
            {
                output.Write(tile.FileName);
                output.Write(tile.Width);
                output.Write(tile.Length);
                output.Write(tile.X);
                output.Write(tile.Y);
                output.Write(tile.Anchor.X);
                output.Write(tile.Anchor.Y);
            }
        }

        public override string GetRuntimeType(TargetPlatform targetPlatform)
        {
            return typeof(TileCoordinates).AssemblyQualifiedName;
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "TiledMapPipeline.TiledMapReader, TiledMapPipeline";
        }
    }
}
