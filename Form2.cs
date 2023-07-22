using ezOverLay;
using Timer = System.Windows.Forms.Timer;

namespace Esp_Hack
{
    public partial class Form2 : Form
    {
        static Player cplayer;
        static Entitylist clist;
        static ScreenFunctions screeninjetor;
        static ez ez;

        static Graphics g;
        private Timer timer;
        static Pen red = new Pen(Color.Red, 2);
        static Pen green = new Pen(Color.PaleGreen, 2);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cplayer = new Player();
            clist = new Entitylist();
            screeninjetor = new ScreenFunctions();
            ez = new ez();

            Control.CheckForIllegalCrossThreadCalls = false;
            ez.SetInvi(this);
            ez.StartLoop(10, "AssaultCube", this);

            timer = new Timer();
            timer.Interval = 23;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            List<Enemy> entityList = clist.getEntitybotList(cplayer);

            foreach (var enemy in entityList)
            {
                var feet = screeninjetor.WorldToScreen(screeninjetor.Readmatrix(), enemy.getPlayerfeet(), 800, 600);
                var head = screeninjetor.WorldToScreen(screeninjetor.Readmatrix(), enemy.getPlayerhead(), 800, 600);
                var team = cplayer.getTeam();

                if (feet.X > 0)
                {
                    var box = screeninjetor.Entitybox(feet, head);

                    if (team != enemy.getTeam())
                    {
                        g.DrawLine(red, new Point(800 / 2, 600), feet);
                        g.DrawRectangle(red, box);
                    }
                    else
                    {
                        g.DrawLine(green, new Point(800 / 2, 600), feet);
                        g.DrawRectangle(green, box);
                    }
                }
            }
        }
    }
}
