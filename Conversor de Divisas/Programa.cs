using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Conversor_de_Divisas
{
    public partial class fr_Programa : Form
    {
        /* Datos Programa */
        const string titulo = "Conversor de Divisas";
        const string version = "v1.0 Beta";
        const string actualizacion = "12/06/2023";

        float[] listavalores;
        char[] simbolos;

        public fr_Programa()
        {
            /* Divisas */
            float usd, cad, aud, eur, chf, gbp, cny, pen, jpy;
            string fecha;

            using (var client = new HttpClient())
            {
                string url = "http://data.fixer.io/api/latest?access_key=8e8fb96864b789a7eba0f271e681d241";

                var response = client.GetAsync(url).Result;

                var res = response.Content.ReadAsStringAsync().Result;
                JObject r = JObject.Parse(res);

                usd = float.Parse(string.Format("{0:N4}", r["rates"]["USD"]));
                cad = float.Parse(string.Format("{0:N4}", r["rates"]["CAD"]));
                aud = float.Parse(string.Format("{0:N4}", r["rates"]["AUD"]));
                eur = float.Parse(string.Format("{0:N4}", r["rates"]["EUR"]));
                chf = float.Parse(string.Format("{0:N4}", r["rates"]["CHF"]));
                gbp = float.Parse(string.Format("{0:N4}", r["rates"]["GBP"]));
                cny = float.Parse(string.Format("{0:N4}", r["rates"]["CNY"]));
                pen = float.Parse(string.Format("{0:N4}", r["rates"]["PEN"]));
                jpy = float.Parse(string.Format("{0:N4}", r["rates"]["JPY"]));

                fecha = Convert.ToString(r["date"]);
            }

            listavalores = new float[] { usd, cad, aud, eur, chf, gbp, cny, pen, jpy };
            simbolos = new char[] { '$', '$', '$', '€', 'F', '£', '¥', 'S', '¥' };

            InitializeComponent();

            this.Text = titulo + " " + version;
            lb_Actualizacion.Text = "Última Actualización: " + actualizacion;
            lb_Cotizaciones.Text = "1 € = " + usd + " $ USD (Dólar Estadounidense)" +
                                   "\n1 € = " + cad + " $ CAD (Dólar Canadiense)" +
                                   "\n1 € = " + aud + " $ AUD (Dólar Australiano)" +
                                   "\n1 € = " + eur + " € EUR (Euro)" +
                                   "\n1 € = " + chf + " F CHF (Franco Suizo)" +
                                   "\n1 € = " + gbp + " £ GBP (Libra Esterlina)" +
                                   "\n1 € = " + cny + " ¥ CNY (Renminbi Chino)" +
                                   "\n1 € = " + pen + " S PEN (Sol Peruano)" +
                                   "\n1 € = " + jpy + " ¥ JPY (Yen Japonés)" +
                                   "\n\n Cotización: " + fecha;

            cb_Moneda1.SelectedIndex = 3;
            cb_Moneda2.SelectedIndex = 0;
        }

        private void bt_Convertir_Click(object sender, EventArgs e)
        {
            int sw;
            float resultado;

            try
            {
                sw = 1;
                resultado = float.Parse(tb_Cantidad.Text);
            }
            catch (FormatException)
            {
                sw = 0;
                MessageBox.Show("La cantidad debe ser un número valido");
                tb_Cantidad.Clear();
            }
            if (sw == 1)
            {
                resultado = (float.Parse(tb_Cantidad.Text) * listavalores[cb_Moneda2.SelectedIndex]) / listavalores[cb_Moneda1.SelectedIndex];
                lb_Resultado2.Text = string.Format("{0:N2}", resultado) + " " + simbolos[cb_Moneda2.SelectedIndex];
            }
        }

        private void bt_ChangeLog_Click(object sender, EventArgs e)
        {
            if (File.Exists("ChangeLog.txt"))
            {
                Process.Start("notepad.exe", "ChangeLog.txt");
            }
            else
            {
                MessageBox.Show("Archivo ChangeLog.txt no disponible", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void bt_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(titulo + "\nVersión: " + version + "\n\nCreado por: Daniel Amores (TheShadow)\nGrupo Desarrollo: Sinister Software\nPágina Web: http://theshadow500.blogspot.com \n\nUltima Fecha Revisión: 12/06/2023", "Sobre");
        }
    }
}