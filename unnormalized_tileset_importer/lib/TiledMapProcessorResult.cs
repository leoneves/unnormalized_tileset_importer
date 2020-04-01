using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledMapPipeline
{
    public class TiledMapProcessorResult
    {
        public TilesCoorinatesJson TilesCoorinatesJson;
        public ContentBuildLogger Logger;

        public TiledMapProcessorResult(TilesCoorinatesJson tileCoordinates, ContentBuildLogger logger)
        {
            TilesCoorinatesJson = tileCoordinates;
            Logger = logger;
        }
    }
}
