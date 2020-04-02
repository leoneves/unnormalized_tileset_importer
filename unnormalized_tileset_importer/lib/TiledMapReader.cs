using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Newtonsoft.Json;

namespace TiledMapPipeline
{
    public class TiledMapReader : ContentTypeReader<TilesCoorinatesJson>
    {
        protected override TilesCoorinatesJson Read(ContentReader input, TilesCoorinatesJson existingInstance)
        {
            var json = input.ReadString();
            using (var stringReader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<TilesCoorinatesJson>(jsonReader);
            }

            // return JsonConvert.DeserializeObject<TilesCoorinatesJson>(input.ReadString());
        }
    }
}
