using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledMapPipeline
{
    public class JsonContentProcessorResult
    {
        public ContentProcessorContext ContentProcessorContext { get; set; }
        public string Json { get; set; }
    }
}
