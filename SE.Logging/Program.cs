using Sandbox.ModAPI.Ingame;

namespace IngameScript
{
    partial class Program : MyGridProgram
    {

        public Program()
        {
            _logger = new SurfaceLogger(Me.GetSurface(0));//will use PB screen as logger surface

            _logger.Clear();
        }

        public void Main(string argument, UpdateType updateSource)
        {
            _logger.LogLine(argument);
        }
    }
}
