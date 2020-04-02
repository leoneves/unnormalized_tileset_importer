using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;
using Newtonsoft.Json;

namespace TiledMapPipeline
{
    [ContentImporter(".json", DefaultProcessor = "TiledMapProcessor", DisplayName = "Tiled Map Importer")]
    public class TiledMapImporter : ContentImporter<ContentImporterResult<string>>
    {
        public override ContentImporterResult<string> Import(string filename, ContentImporterContext context)
        {
            context.Logger.LogMessage("Importing JSON map: {0}", filename);
            string json = File.ReadAllText(filename);
            return new ContentImporterResult<string>(filename, json);
        }
    }
}
