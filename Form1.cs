namespace Esp_Hack
{
    public partial class Form1 : Form
    {
        static bool healthrun, shieldrun, bulletsrun, pbulletsrun, explosiverun, locationrun, listarun, enemyliferun, enemylocationrun, readmatrixrun, aimbotrun;

        static CancellationTokenSource heatlhtask, shieldtask, bulletstask, pbulletstask, explosivetask, locationtask, listatask, enemylifetask, enemylocationtask, readmatrixtask, aimbottask;
        private SynchronizationContext synchronizationContext;

        static FunctionsHack injetor;
        static Player cplayer;
        static Entitylist clist;
        static ListView listview;
        static ScreenFunctions screeninjetor;

        private Form2 Form;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            injetor = new FunctionsHack();
            cplayer = new Player();
            clist = new Entitylist();
            listview = new ListView();
            screeninjetor = new ScreenFunctions();

            Controls.Add(listview);
            listview.Location = new Point(379, 12);
            listview.Size = new Size(570, 300);

            synchronizationContext = SynchronizationContext.Current;
        }

        private void Infitelife_CheckedChanged(object sender, EventArgs e)
        {
            if (Infitelife.Checked == true)
            {
                Healthrun();
            }
            else
            {
                StopHealthrun();
            }
        }

        private void Infiniteshield_CheckedChanged(object sender, EventArgs e)
        {
            if (Infiniteshield.Checked == true)
            {

                Shieldrun();
            }
            else
            {
                StopShieldrun();
            }
        }

        private void Infinitebullets_CheckedChanged(object sender, EventArgs e)
        {
            if (Infinitebullets.Checked == true)
            {

                Bulletsrun();
            }
            else
            {
                StopBulletsrun();
            }
        }

        private void Infinitepbullets_CheckedChanged(object sender, EventArgs e)
        {
            if (Infinitepbullets.Checked == true)
            {

                Pbulletsrun();
            }
            else
            {
                StopPbulletsrun();
            }
        }

        private void Infiteexplosive_CheckedChanged(object sender, EventArgs e)
        {
            if (Infiteexplosive.Checked == true)
            {

                Explosiverun();
            }
            else
            {
                StopExplosiverun();
            }
        }

        private void Frezzyposition_CheckedChanged(object sender, EventArgs e)
        {
            if (Frezzyposition.Checked == true)
            {

                Locationrun(cplayer.getX(), cplayer.getY(), cplayer.getZ());
            }
            else
            {
                StopLocationrun();
            }
        }

        private void Showlistview_CheckedChanged(object sender, EventArgs e)
        {
            if (Showlistview.Checked == true)
            {
                Listarun();
            }
            else
            {
                StopListarun();
            }
        }

        private void Setentitylife_CheckedChanged(object sender, EventArgs e)
        {
            if (Setentitylife.Checked == true)
            {
                Enemyliferun();
            }
            else
            {
                StopEnemyliferun();
            }
        }

        private void Enemyfrezzy_CheckedChanged(object sender, EventArgs e)
        {
            if (Enemyfrezzy.Checked == true)
            {
                Enemylocationrun();
            }
            else
            {
                StopEnemylocationrun();
            }
        }

        private void Esphack_CheckedChanged(object sender, EventArgs e)
        {
            if (Esphack.Checked == true)
            {
                if (Form == null || Form.IsDisposed)
                {
                    Form = new Form2();
                }

                Readmatrix();
                Form.Show();
            }
            else
            {
                StopReadmatrix();
                Form?.Close();
            }
        }

        private void Aimbot_CheckedChanged(object sender, EventArgs e)
        {
            if (Aimbot.Checked == true)
            {
                Aimbotf();
            }
            else
            {
                StopAimbotf();
            }
        }

        private static void Healthrun()
        {
            heatlhtask = new CancellationTokenSource();
            CancellationToken Kcancel = heatlhtask.Token;
            healthrun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.Frezhealth(570);
                    Thread.Sleep(100);
                }

                healthrun = false;
            });
        }

        private static void StopHealthrun()
        {
            if (healthrun)
            {
                injetor.Frezhealth(100);
                heatlhtask.Cancel();
                heatlhtask.Dispose();
                heatlhtask = null;
            }
        }

        private static void Shieldrun()
        {
            shieldtask = new CancellationTokenSource();
            CancellationToken Kcancel = shieldtask.Token;
            shieldrun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.Frezshield(100);
                    Thread.Sleep(100);
                }

                shieldrun = false;
            });
        }

        private static void StopShieldrun()
        {
            if (shieldrun)
            {
                injetor.Frezshield(0);
                shieldtask.Cancel();
                shieldtask.Dispose();
                shieldtask = null;
            }
        }

        private static void Bulletsrun()
        {
            bulletstask = new CancellationTokenSource();
            CancellationToken Kcancel = bulletstask.Token;
            bulletsrun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.Frezbullets(30);
                    Thread.Sleep(100);
                }

                bulletsrun = false;
            });
        }

        private static void StopBulletsrun()
        {
            if (bulletsrun)
            {
                injetor.Frezbullets(20);
                bulletstask.Cancel();
                bulletstask.Dispose();
                bulletstask = null;
            }
        }

        private static void Pbulletsrun()
        {
            pbulletstask = new CancellationTokenSource();
            CancellationToken Kcancel = pbulletstask.Token;
            pbulletsrun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.Frezpbullets(10);
                    Thread.Sleep(100);
                }

                pbulletsrun = false;
            });
        }

        private static void StopPbulletsrun()
        {
            if (pbulletsrun)
            {
                injetor.Frezpbullets(5);
                pbulletstask.Cancel();
                pbulletstask.Dispose();
                pbulletstask = null;
            }
        }

        private static void Explosiverun()
        {
            explosivetask = new CancellationTokenSource();
            CancellationToken Kcancel = explosivetask.Token;
            explosiverun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.Frezexplosive(10);
                    Thread.Sleep(100);
                }

                explosiverun = false;
            });
        }

        private static void StopExplosiverun()
        {
            if (explosiverun)
            {
                injetor.Frezexplosive(0);
                explosivetask.Cancel();
                explosivetask.Dispose();
                explosivetask = null;
            }
        }

        private static void Locationrun(float x, float y, float z)
        {
            locationtask = new CancellationTokenSource();
            CancellationToken Kcancel = locationtask.Token;
            locationrun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.FrezX(x); injetor.FrezY(y); injetor.FrezZ(z);
                    Thread.Sleep(500);
                }

                locationrun = false;
            });
        }

        private static void StopLocationrun()
        {
            if (locationrun)
            {
                locationtask.Cancel();
                locationtask.Dispose();
                locationtask = null;
            }
        }

        private void Listarun()
        {
            listatask = new CancellationTokenSource();
            CancellationToken Kcancel = listatask.Token;
            listarun = true;

            listview.View = View.Details;

            listview.Columns.Add("Pointer", 80);
            listview.Columns.Add("Name", 80);
            listview.Columns.Add("Heatlh", 80);
            listview.Columns.Add("Team", 80);
            listview.Columns.Add("X", 80);
            listview.Columns.Add("Y", 80);
            listview.Columns.Add("Z", 85);

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    synchronizationContext.Post(new SendOrPostCallback((state) =>
                    {
                        injetor.showEntitylist(clist.getEntitybotList(cplayer), listview);
                    }), null);

                    Thread.Sleep(100);
                }

                listarun = false;
            });
        }

        private static void StopListarun()
        {
            if (listarun)
            {
                listatask.Cancel();
                listatask.Dispose();
                listatask = null;

                listview.Items.Clear();
                listview.Columns.Clear();
            }
        }

        private static void Enemyliferun()
        {
            enemylifetask = new CancellationTokenSource();
            CancellationToken Kcancel = enemylifetask.Token;
            enemyliferun = true;

            List<Enemy> entityList = clist.getEntitybotList(cplayer);

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.setEntitylife(clist.getEntitybotList(cplayer), 10);
                    Thread.Sleep(500);
                }
                enemyliferun = false;
            });
        }

        private static void StopEnemyliferun()
        {
            if (enemyliferun)
            {
                enemylifetask.Cancel();
                enemylifetask.Dispose();
                enemylifetask = null;
            }
        }

        private static void Enemylocationrun()
        {
            enemylocationtask = new CancellationTokenSource();
            CancellationToken Kcancel = enemylocationtask.Token;
            List<Enemy> enemy = new List<Enemy>();
            enemy = clist.getEntitybotList(cplayer);
            enemylocationrun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.setEntitylocation(enemy);
                    Thread.Sleep(10);
                }

                enemylocationrun = false;
            });
        }

        private static void StopEnemylocationrun()
        {
            if (enemylocationrun)
            {
                enemylocationtask.Cancel();
                enemylocationtask.Dispose();
                enemylocationtask = null;
            }
        }

        private static void Readmatrix()
        {
            readmatrixtask = new CancellationTokenSource();
            CancellationToken Kcancel = readmatrixtask.Token;
            readmatrixrun = true;

            listview.View = View.Details;

            listview.Columns.Add("0", 80);
            listview.Columns.Add("1", 80);
            listview.Columns.Add("2", 80);
            listview.Columns.Add("3", 80);
            listview.Columns.Add("4", 80);
            listview.Columns.Add("5", 80);
            listview.Columns.Add("6", 85);
            listview.Columns.Add("7", 80);
            listview.Columns.Add("8", 80);
            listview.Columns.Add("9", 80);
            listview.Columns.Add("10", 80);
            listview.Columns.Add("11", 80);
            listview.Columns.Add("12", 80);
            listview.Columns.Add("13", 85);
            listview.Columns.Add("14", 85);
            listview.Columns.Add("15", 85);

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    screeninjetor.showPlayerMatrix(screeninjetor.Readmatrix(), listview);
                    Thread.Sleep(150);
                }

                readmatrixrun = false;
            });
        }

        private static void StopReadmatrix()
        {
            if (readmatrixrun)
            {
                readmatrixtask.Cancel();
                readmatrixtask.Dispose();
                readmatrixtask = null;

                listview.Items.Clear();
                listview.Columns.Clear();
            }
        }

        private static void Aimbotf()
        {
            aimbottask = new CancellationTokenSource();
            CancellationToken Kcancel = aimbottask.Token;
            aimbotrun = true;

            Task.Run(() =>
            {
                while (!Kcancel.IsCancellationRequested)
                {
                    injetor.Aimex(clist.getEntitybotList(cplayer));
                    Thread.Sleep(23);
                }

                aimbotrun = false;
            });
        }

        private static void StopAimbotf()
        {
            if (aimbotrun)
            {
                aimbottask.Cancel();
                aimbottask.Dispose();
                aimbottask = null;
            }

        }
    }
}