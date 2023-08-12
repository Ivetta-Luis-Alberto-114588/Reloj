namespace Reloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora1.Text = DateTime.Now.ToString("hh:mm");
            lblSegundo1.Text = DateTime.Now.ToString("ss");
            lblFecha1.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblDia1.Text = DateTime.Now.ToString("dddd");
        }

        private void form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var spainTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
            var espana = TimeZoneInfo.ConvertTime(DateTime.Now, spainTimeZone);

            lblHora2.Text = espana.ToString("hh:mm");
            lblSegundo2.Text = espana.ToString("ss");
            lblFecha2.Text = espana.ToString("dd MMMM yyyy");
            lblDia2.Text = espana.ToString("dddd");

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var alemaniaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var alemania = TimeZoneInfo.ConvertTime(DateTime.Now, alemaniaTimeZone);

            lblHora3.Text = alemania.ToString("hh:mm");
            lblSegundo3.Text = alemania.ToString("ss");
            lblFecha3.Text = alemania.ToString("dd MMMM yyyy");
            lblDia3.Text = alemania.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var norwayTimeZone = TimeZoneInfo.FindSystemTimeZoneById("FLE Standard Time");
            var noruega = TimeZoneInfo.ConvertTime(DateTime.Now, norwayTimeZone);

            lblHora4.Text = noruega.ToString("hh:mm");
            lblSegundo4.Text = noruega.ToString("ss");
            lblFecha4.Text = noruega.ToString("dd MMMM yyyy");
            lblDia4.Text = noruega.ToString("dddd");
        }
    }
}