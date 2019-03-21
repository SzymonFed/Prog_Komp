using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Zad_2
{
    public partial class Form1 : Form
    {
        private Task<Decimal> taskQuote;
        private Task<double> taskTemperature;
        private Task<String> taskResolve;
        private Task<String> taskTime;
        private Task<String> taskEcho;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuotes_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            var serviceClient = new ServiceReferenceQuotes.DelayedStockQuoteSoapClient("DelayedStockQuoteSoap");
            txtQuotesOutput.Text = serviceClient.GetQuickQuote(txtQuotesInput.Text,"0").ToString();
            watch.Stop();
            txtQuotesWatch.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            var serviceClient = new ServiceResolve.P2GeoSoapClient("IP2GeoSoap");
            var ipData = serviceClient.ResolveIP(txtResolveInput.Text, "0");
            txtResolveOutput.Text = ipData.City;
            watch.Stop();
            txtResolveWatch.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btnEcho_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            var serviceClient = new ServiceEcho.ServiceSoapClient("ServiceSoap");
            txtEchoOutput.Text = serviceClient.Echo(txtEchoInput.Text).ToString();
            watch.Stop();
            txtEchoWatch.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            var serviceClient = new ServiceTime.ServiceSoapClient("ServiceSoap1");
            txtTimeOutput.Text = serviceClient.GetTime().ToString();
            watch.Stop();
            txtTimeWatch.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btnPublic_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            var service = new ServicePublic.BZP_PublicWebServiceSoapClient("BZP_PublicWebServiceSoap");
            var rodzajZamawiajacego = Convert.ToInt32(txtPublicInputZamawiajacy.Text);
            var rodzajZamowienia = Convert.ToInt32(txtPublicInputZamowienie.Text);
            var wojewodztwo = txtPublicInputWojewodztwo.Text;
            var ds = service.ogloszeniaZP400KryteriaWyszukiwaniaDataSet(rodzajZamawiajacego, rodzajZamowienia, 99, "",
                "", "", "", "", 99, "", "", wojewodztwo, -1, -1);
            txtPublicOutput.Text = ds.ToString();
            watch.Stop();
            txtPublicWatch.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            var serviceClient = new ServiceW
            watch.Stop();
            txtWeatherWatch.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (txtQuotesInput.Text == "")
            {
                MessageBox.Show("Nie wypełnione pole ze wskazaniem akcji (Quotes)", "Brak danych", MessageBoxButtons.OK);
 return;
            }
            if (txtResolveInput.Text == "")
            {
                MessageBox.Show("Nie wypełnione pole ze wskazaniem akcji do pobrania pełnej informacji(Resolve)", "Brak danych", MessageBoxButtons.OK);
            return;
            }
            if (txtEchoInput.Text == "")
            {
                MessageBox.Show("Nie wypełnione pole ze wskazaniem akcji do pobrania pełnej informacji(Echo)", "Brak danych", MessageBoxButtons.OK);
                return;
            }
            if (txtWeatherInput.Text == "")
            {
                MessageBox.Show("Nie wypełnione pole ze wskazaniem akcji do pobrania pełnej informacji(Weather)", "Brak danych", MessageBoxButtons.OK);
                return;
            }
            if (txtPublicInputZamawiajacy.Text == ""|| txtPublicInputZamowienie.Text == "" || txtPublicInputWojewodztwo.Text == "")
            {
                MessageBox.Show("Nie wypełnione pole ze wskazaniem akcji do pobrania pełnej informacji(PublicOrder)", "Brak danych", MessageBoxButtons.OK);
                return;
            }

            btnQuotes_Click(sender, e);
            btnResolve_Click(sender, e);
            btnEcho_Click(sender, e);
            btnTime_Click(sender, e);
            btnPublic_Click(sender, e);
            btnWeather_Click(sender, e);

        }

        //private void btnAsynchronous_Click(object sender, EventArgs e)
        //{
        //    var watch = new Stopwatch();
        //    watch.Start();
        //    StartTasks();
        //    FinishTasks();
        //    watch.Stop();
        //    txtAsynchronousWatch.Text = watch.ElapsedMilliseconds.ToString();
        //}

        //private void StartTasks()
        //{
        //    ServiceReferenceQuotes.DelayedStockQuoteSoapClient clientQuote = new ServiceReferenceQuotes.DelayedStockQuoteSoapClient("DelayedStockQuoteSoap");//1
        //    taskQuote = clientQuote.GetQuickQuoteAsync(textBox2.Text, "0");//2

        //    ServiceSomething.SomethingSoapClient clientSomething = new ServiceSomething.SomethingSoapClient("SomethingSoap");//1
        //    taskSomething = client.ConvertSomethingAsync(Convert.ToDouble(textBox3.Text));//2
        //}
        //private void FinishTasks()
        //{
        //    labelQuote.Text = taskQuote.Result.ToString();
        //    labelSomething.Text = taskSomething.Result.ToString();
        //}

    }
}
