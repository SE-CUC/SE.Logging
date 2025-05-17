using Sandbox.ModAPI.Ingame;
using System;
using VRage.Game.GUI.TextPanel;
using VRageMath;

namespace IngameScript
{
    public class SurfaceLogger : ILoggable
    {
        private readonly IMyTextSurface _surface;

        public SurfaceLogger(IMyTextSurface surface, Action<IMyTextSurface> configuration = null)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            _surface = surface;

            Configure(surface, configuration);
        }

        public void Clear() => _surface.WriteText(string.Empty);

        public void Log(string message) => _surface.WriteText(message, true);

        public void LogLine(string message) => _surface.WriteText("\n" + message, true);

        protected virtual void Configure(IMyTextSurface surface, Action<IMyTextSurface> configuration)
        {

            if (configuration != null)
            {
                configuration(surface);
                return;
            }

            surface.ContentType = ContentType.TEXT_AND_IMAGE;
            surface.Alignment = TextAlignment.LEFT;
            surface.FontColor = Color.White;
            surface.BackgroundColor = Color.Black;
            surface.TextPadding = 0.1f;
        }

    }
}
