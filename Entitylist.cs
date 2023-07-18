using System;
using Swed32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Esp_Hack
{
    internal class Entitylist
    {
        private Swed game;

        public int entitylist = 0x0018AC04;
        public int botnumber = 0x0018AC0C;
        public int bot0 = 0x4;
        public int name = 0x205;
        public int health = 0xEC;
        public int team = 0x30C;
        public int X = 0x2C;
        public int Y = 0x28;
        public int Z = 0x30;

        private int botnumberr;
        private IntPtr fundPtr;
        private IntPtr basePtr;
        private IntPtr entityPtr;
        private int teamm;
        private string namee = "";
        private int healthh;
        private float Yy;
        private float Xx;
        private float Zz;

        public Entitylist()
        {
            game = new Swed("ac_client");
            fundPtr = game.GetModuleBase(".exe");
            basePtr = game.ReadPointer(fundPtr, 0x0018AC04);
        }
    }

    internal class Enemy
    {
        public IntPtr enemyPtr;
        private string namee = "";
        public int healthh;
        private int teamm;
        public float Xx;
        public float Yy;
        public float Zz;

        public int name = 0x205;
        public int health = 0xEC;
        public int team = 0x30C;
        public int X = 0x2C;
        public int Y = 0x28;
        public int Z = 0x30;

        public Enemy(String name, int health, int teammm, float x, float y, float z, IntPtr enemyPtr)
        {
            this.enemyPtr = enemyPtr;
            this.namee = name;
            this.healthh = health;
            this.teamm = teammm;
            this.Xx = x;
            this.Yy = y;
            this.Zz = z;
        }
    }
}
