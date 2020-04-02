using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TilesetPipeline
{
    [ContentImporter(".txt", DefaultProcessor = "TilesetProcessor", DisplayName = "Tileset Importer")]
    public class TilesetImporter : ContentImporter<string>
    {
        public override string Import(string filename, ContentImporterContext context)
        {
            context.Logger.LogMessage("Importing txt tileset: {0}", filename);
            return File.ReadAllText(filename);
        }
    }
}
