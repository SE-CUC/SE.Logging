using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using VRage;
using VRage.Collections;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ModAPI.Ingame.Utilities;
using VRage.Game.ObjectBuilders.Definitions;

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
