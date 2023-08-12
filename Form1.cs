namespace Reloj
{
    public partial class Form1 : Form
    {

        private TimeZoneService _TimeZoneService;
        
        public Form1()
        {
            InitializeComponent();
            _TimeZoneService = new TimeZoneService();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora1.Text = DateTime.Now.ToString("HH:mm");
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
            var zonaHoraria = _TimeZoneService.obtenerTimeZone("Romance Standard Time");   

            lblHora2.Text = zonaHoraria.ToString("HH:mm");
            lblSegundo2.Text = zonaHoraria.ToString("ss");
            lblFecha2.Text = zonaHoraria.ToString("dd MMMM yyyy");
            lblDia2.Text = zonaHoraria.ToString("dddd");

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var zonaHoraria = _TimeZoneService.obtenerTimeZone("W. Europe Standard Time");

            lblHora3.Text = zonaHoraria.ToString("HH:mm");
            lblSegundo3.Text = zonaHoraria.ToString("ss");
            lblFecha3.Text = zonaHoraria.ToString("dd MMMM yyyy");
            lblDia3.Text = zonaHoraria.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var zonaHoraria = _TimeZoneService.obtenerTimeZone("FLE Standard Time");

            lblHora4.Text = zonaHoraria.ToString("HH:mm");
            lblSegundo4.Text = zonaHoraria.ToString("ss");
            lblFecha4.Text = zonaHoraria.ToString("dd MMMM yyyy");
            lblDia4.Text = zonaHoraria.ToString("dddd");
        }
    }
}