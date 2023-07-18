using Swed32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Esp_Hack
{
    internal class ScreenFunctions
    {
        Swed game;

        ViewMatrix vmatrix;

        public ScreenFunctions()
        {
            game = new Swed("ac_client");
        }
    }
}
