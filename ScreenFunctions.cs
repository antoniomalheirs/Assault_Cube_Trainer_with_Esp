using Swed32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public void showPlayerMatrix(ViewMatrix view,ListView ltview)
        {
            if (ltview.InvokeRequired)
            {
                ltview.Invoke((MethodInvoker)delegate
                {
                    showPlayerMatrix(view, ltview);
                });
                return;
            }

            ltview.Items.Clear();

            ListViewItem item = new ListViewItem(view.m11.ToString());
            item.SubItems.Add(view.m12.ToString());
            item.SubItems.Add(view.m13.ToString());
            item.SubItems.Add(view.m14.ToString());
            item.SubItems.Add(view.m21.ToString());
            item.SubItems.Add(view.m22.ToString());
            item.SubItems.Add(view.m23.ToString());
            item.SubItems.Add(view.m24.ToString());
            item.SubItems.Add(view.m31.ToString());
            item.SubItems.Add(view.m32.ToString());
            item.SubItems.Add(view.m33.ToString());
            item.SubItems.Add(view.m34.ToString());
            item.SubItems.Add(view.m41.ToString());
            item.SubItems.Add(view.m42.ToString());
            item.SubItems.Add(view.m43.ToString());
            item.SubItems.Add(view.m44.ToString());

            ltview.Items.Add(item);
        }

        public ViewMatrix Readmatrix()
        {
            var matriz = game.ReadMatrix(game.GetModuleBase(".exe") + 0x17DFD0); //17DFE8 //17DFD0 //17DFFC //17DF90

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

        public Point WorldToScreen(ViewMatrix mtx, Vector3 pos, int width, int height)
        {
            var ponto = new Point();

            float screenW = (mtx.m14 * pos.X) + (mtx.m24 * pos.Y) + (mtx.m34 * pos.Z) + mtx.m44;

            if (screenW > 0.001f)
            {
                float screenX = (mtx.m11 * pos.X) + (mtx.m21 * pos.Y) + (mtx.m31 * pos.Z) + mtx.m41;

                float screenY = (mtx.m12 * pos.X) + (mtx.m22 * pos.Y) + (mtx.m32 * pos.Z) + mtx.m42;

                float camX = width / 2f;
                float camY = height / 2f;

                float X = camX + (camX * screenX / screenW);
                float Y = camY - (camY * screenY / screenW);

                ponto.X = (int)X;
                ponto.Y = (int)Y;

                return ponto;
            }
            else
            {
                return new Point(-99, -99);
            }
        }
    }
}
