namespace CáuculoCombustível
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";
                string modelo = Convert.ToString(txt_modelo.Text);
                string marca = Convert.ToString(txt_marca.Text);

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando mais para o seu(ua) " + modelo + " " + marca;
                }
                else
                {
                    msg = "A gasolina está compensando mais para o seu(ua) " + modelo + " " + marca;
                }

                DisplayAlert("Calculado", msg, "OK");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } 
    } 
} 
