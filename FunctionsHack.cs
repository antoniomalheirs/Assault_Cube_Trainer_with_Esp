using Swed32;
using System;
using System.Numerics;

namespace Esp_Hack
{
    internal class FunctionsHack
    {
        private Swed game;

        private readonly Player player = new Player();
        private readonly ScreenFunctions injetor = new ScreenFunctions();


        public FunctionsHack()
        {
            game = new Swed("ac_client");
        }

        public void Frezhealth(int health)
        {
            game.WriteInt(player.basePtr + player.health, health);
        }

        public void Unfrezhealth()
        {
            game.WriteInt(player.basePtr + player.health, 100);
        }

        public void Frezshield(int shield)
        {
            game.WriteInt(player.basePtr + player.shield, shield);
        }

        public void Unfrezshield()
        {
            game.WriteInt(player.basePtr + player.shield, 0);
        }

        public void Frezbullets(int bullets)
        {
            game.WriteInt(player.basePtr + player.bullets, bullets);
        }

        public void Unfrezbullets()
        {
            game.WriteInt(player.basePtr + player.bullets, 30);
        }

        public void Frezpbullets(int pbullets)
        {
            game.WriteInt(player.basePtr + player.pbullets, pbullets);
        }

        public void Unfrezpbullets()
        {
            game.WriteInt(player.basePtr + player.pbullets, 10);
        }

        public void Frezexplosive(int explosive)
        {
            game.WriteInt(player.basePtr + player.explosive, explosive);
        }

        public void Unfrezexplosive()
        {
            game.WriteInt(player.basePtr + player.explosive, 0);
        }

        public void FrezX(float x)
        {
            game.WriteFloat(player.basePtr + player.X, x);
        }

        public void UnfrezX()
        {
            game.WriteFloat(player.basePtr + player.X, player.getX());
        }

        public void FrezY(float y)
        {
            game.WriteFloat(player.basePtr + player.Y, y);
        }

        public void UnfrezY()
        {
            game.WriteFloat(player.basePtr + player.Y, player.getY());
        }

        public void FrezZ(float z)
        {
            game.WriteFloat(player.basePtr + player.Z, z);
        }

        public void UnfrezZ()
        {
            game.WriteFloat(player.basePtr + player.Z, player.getZ());
        }

        public void showEntitylist(List<Enemy> list, ListView ltview)
        {
            if (ltview.InvokeRequired)
            {
                ltview.Invoke(new Action<List<Enemy>, ListView>(showEntitylist), list, ltview);
                return;
            }

            ltview.Items.Clear();

            foreach (Enemy enemy in list)
            {
                ListViewItem item = new ListViewItem(enemy.getPointer().ToString());
                item.SubItems.Add(enemy.getName().ToString());
                item.SubItems.Add(enemy.getHealth().ToString());
                item.SubItems.Add(enemy.getTeam().ToString());
                item.SubItems.Add(enemy.getX().ToString());
                item.SubItems.Add(enemy.getY().ToString());
                item.SubItems.Add(enemy.getZ().ToString());

                ltview.Items.Add(item);
            }
        }

        public void setEntitylife(List<Enemy> list, int life)
        {
            foreach (Enemy enemy in list)
            {
                if (enemy.getTeam() != player.getTeam())
                {
                    game.WriteInt(enemy.enemyPtr, enemy.health, life);
                }
            }
        }

        public void setEntitylocation(List<Enemy> list)
        {
            foreach (Enemy enemy in list)
            {
                if (enemy.getTeam() != player.getTeam())
                {
                    game.WriteFloat(enemy.enemyPtr, enemy.X, enemy.Xx);
                    game.WriteFloat(enemy.enemyPtr, enemy.Y, enemy.Yy);
                    game.WriteFloat(enemy.enemyPtr, enemy.Z, enemy.Zz);
                }
                Thread.Sleep(10);
            }
        }

        public Vector2 Calcangulo(Enemy target)
        {
            float x, y;

            var deltaX = target.headd.X - player.getPlayerhead().X;
            var deltaY = target.headd.Y - player.getPlayerhead().Y;

            x = (float)(Math.Atan2(deltaY, deltaX) * 180 / Math.PI) + 90;

            float deltaZ = target.headd.Z - player.getPlayerhead().Z;
            float dist = CalculoDist(target);

            y = (float)(Math.Atan2(deltaZ, dist) * 180 / Math.PI);

            return new Vector2(x, y);
        }

        public float CalculoDist(Enemy target)
        {
            return (float)
            Math.Sqrt(Math.Pow(target.feett.X - player.getPlayerfeet().X, 2) + Math.Pow(target.feett.Y - player.getPlayerfeet().Y, 2));
        }

        public void Mira( float x, float y)
        {
            game.WriteFloat(player.basePtr, player.Angulo, x);
            game.WriteFloat(player.basePtr, player.Angulo + 0x4, y);
        }

        public void Aimex(List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                var feet = injetor.WorldToScreen(injetor.Readmatrix(), enemy.getPlayerfeet(), 800, 600);

                if (feet.X > 0 )
                {
                    if (CalculoDist(enemy) < 10)
                    {
                        if (enemy.teamm != player.getTeam() && enemy.getHealth() >= 0 && enemy.getHealth() <= 100)
                        {
                            var angulo = Calcangulo(enemy);
                            Mira(angulo.X, angulo.Y);
                            break;
                        }
                    }
                }
            }
        }
    }
}
