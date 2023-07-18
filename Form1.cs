namespace Esp_Hack
{
    public partial class Form1 : Form
    {
        static bool healthrun;

        static FunctionsHack injetor;

        static CancellationTokenSource heatlhtask;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Infitelife_CheckedChanged(object sender, EventArgs e)
        {
            if (Infitelife.Checked == true)
            {
                injetor = new FunctionsHack();
                Healthrun();
            }
            else
            {
                StopHealthrun();
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
    }
}