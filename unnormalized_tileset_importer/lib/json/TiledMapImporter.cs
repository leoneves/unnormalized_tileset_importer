using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;
using Newtonsoft.Json;

namespace TiledMapPipeline
{
    [ContentImporter(".json", DefaultProcessor = "TiledMapProcessor", DisplayName = "Tiled Map Importer")]
    public class TiledMapImporter : ContentImporter<string>
    {
        public override string Import(string filename, ContentImporterContext context)
        {
            context.Logger.LogMessage("Importing JSON map: {0}", filename);
            return File.ReadAllText(filename);
        }
    }
}
