using Swed32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Esp_Hack
{
    internal class FunctionsHack
    {

        private Swed game;

        private readonly Player player = new Player();

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
    }
}
