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
            vmatrix = new ViewMatrix();
        }

        public ViewMatrix Readmatrix()
        {
            var matriz = game.ReadMatrix(game.GetModuleBase(".exe") + 0x000);
            
            vmatrix.m11 = matriz[0];
            vmatrix.m12 = matriz[1];
            vmatrix.m13 = matriz[2];
            vmatrix.m14 = matriz[3];

            vmatrix.m21 = matriz[4];
            vmatrix.m22 = matriz[5];
            vmatrix.m23 = matriz[6];
            vmatrix.m24 = matriz[7];

            vmatrix.m31 = matriz[8];
            vmatrix.m32 = matriz[9];
            vmatrix.m33 = matriz[10];
            vmatrix.m34 = matriz[11];

            vmatrix.m41 = matriz[12];
            vmatrix.m42 = matriz[13];
            vmatrix.m43 = matriz[14];
            vmatrix.m44 = matriz[15];

            return vmatrix;
        }
    }
}
