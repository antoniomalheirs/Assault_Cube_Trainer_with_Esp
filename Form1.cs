namespace Esp_Hack
{
    public partial class Form1 : Form
    {
        static bool healthrun, shieldrun, bulletsrun, pbulletsrun;

        static FunctionsHack injetor;

        static CancellationTokenSource heatlhtask, shieldtask, bulletstask, pbulletstask;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            injetor = new FunctionsHack();
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
    }
}