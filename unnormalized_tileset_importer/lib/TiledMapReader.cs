using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace TiledMapPipeline
{
    public class TiledMapReader : ContentTypeReader<TileCoordinates[]>
    {
        protected override TileCoordinates[] Read(ContentReader input, TileCoordinates[] existingInstance)
        {
            Debug.WriteLine("Starting TiledMapReader");
            try {
                var tilesAmount = input.ReadInt32();
                var tiles = new List<TileCoordinates>();

                for (var i = 0; i < tilesAmount; i++)
                {
                    var tile = new TileCoordinates
                    {
                        FileName = input.ReadString(),
                        Width = input.ReadInt32(),
                        Length = input.ReadInt32(),
                        X = input.ReadInt32(),
                        Y = input.ReadInt32()
                    };
                    var anchor = new Anchor
                    {
                        X = input.ReadInt32(),
                        Y = input.ReadInt32()
                    };
                    tile.Anchor = anchor;
                    tiles.Add(tile);
                }

                return tiles.ToArray();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error {e.Message}");
                Debug.WriteLine($"params: {input.ReadString()}");
                throw;
            }
        }
    }
}
