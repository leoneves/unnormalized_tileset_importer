using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework.Content;

namespace TilesetPipeline
{
    public class TilesetReader : ContentTypeReader<List<CordinateTextRow>>
    {
        protected override List<CordinateTextRow> Read(ContentReader input, List<CordinateTextRow> existingInstance)
        {
            var txt = input.ReadString();
            List<CordinateTextRow> output_cols = new List<CordinateTextRow>();
            foreach (var line in txt.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (!line.StartsWith("#", StringComparison.Ordinal)) {
                    var cordinateTextRow = new CordinateTextRow()
                    {
                        Columns = line.Split(';')
                    };
                    output_cols.Add(cordinateTextRow);
                }
            }
            return output_cols;
        }
    }
}
