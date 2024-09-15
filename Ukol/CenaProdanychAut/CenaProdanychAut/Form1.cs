using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace CenaProdanychAut
{
    public partial class Form1 : Form
    {
        // vytvoøení pomocné promìnné
        double totalPriceOktavia = 0;  
        double totalPriceFelicia = 0;
        double totalPriceFabia = 0;
        double totalPriceForman = 0;
        double totalPriceFavorit = 0;
        string oktavia = "Škoda Oktávia";
        string felicia = "Škoda Felicia";
        string fabia = "Škoda Fabia";
        string forman = "Škoda Forman";
        string favorit = "Škoda Favorit";

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnVybratSoubor_Click(object sender, EventArgs e)
        {
            // pro otevøení okna pro výbìr souboru
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // filtruji jaký soubor vybrat
            openFileDialog.Filter = "Xml files (*.xml) | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // nahraju soubor Xml do setu
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(openFileDialog.FileName);

                // pro zobrazení tabulky aut 
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                try
                {
                    // Vytvoøení nové tabulky
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Název Modelu\nCena s Dph");
                    dataTable.Columns.Add("Cena bez Dph");

                    // Výpoèet celkové ceny vozù prodaných o víkendu a s DPH 
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        DateTime saleDate = DateTime.Parse(row["DatumProdeje"].ToString());
                        string model = row["NazevModelu"].ToString();
                        if ((oktavia == model) && (saleDate.DayOfWeek == DayOfWeek.Saturday || saleDate.DayOfWeek == DayOfWeek.Sunday))
                        {
                            double price = double.Parse(row["Cena"].ToString());
                            totalPriceOktavia += price;
                        }
                        if ((felicia == model) && (saleDate.DayOfWeek == DayOfWeek.Saturday || saleDate.DayOfWeek == DayOfWeek.Sunday))
                        {
                            double price = double.Parse(row["Cena"].ToString());
                            totalPriceFelicia += price;
                        }
                        if ((fabia == model) && (saleDate.DayOfWeek == DayOfWeek.Saturday || saleDate.DayOfWeek == DayOfWeek.Sunday))
                        {
                            double price = double.Parse(row["Cena"].ToString());
                            totalPriceFabia += price;
                        }
                        if ((forman == model) && (saleDate.DayOfWeek == DayOfWeek.Saturday || saleDate.DayOfWeek == DayOfWeek.Sunday))
                        {
                            double price = double.Parse(row["Cena"].ToString());
                            totalPriceForman += price;
                        }
                        if ((favorit == model) && (saleDate.DayOfWeek == DayOfWeek.Saturday || saleDate.DayOfWeek == DayOfWeek.Sunday))
                        {
                            double price = double.Parse(row["Cena"].ToString());
                            totalPriceFavorit += price;
                        }
                    }

                    // spoèítání ceny bez Dph
                    double totalPriceWithoutDPHOktavia = totalPriceOktavia / (1 + 0.20); // Pøedpokládáme DPH 21%
                    double totalPriceWithoutDPHFelicia = totalPriceFelicia / (1 + 0.2);
                    double totalPriceWithoutDPHFabia = totalPriceFabia / (1 + 0.2);
                    double totalPriceWithoutDPHForman = totalPriceForman / (1 + 0.2);
                    double totalPriceWithoutDPHFavorit = totalPriceFavorit / (1 + 0.2);

                    // Vložení øádkù do tabulky
                    dataTable.Rows.Add(oktavia);
                    dataTable.Rows.Add(totalPriceOktavia, totalPriceWithoutDPHOktavia);
                    dataTable.Rows.Add(felicia);
                    dataTable.Rows.Add(totalPriceFelicia, totalPriceWithoutDPHFelicia);
                    dataTable.Rows.Add(fabia);
                    dataTable.Rows.Add(totalPriceFabia, totalPriceWithoutDPHFabia);
                    dataTable.Rows.Add(forman);
                    dataTable.Rows.Add(totalPriceForman, totalPriceWithoutDPHForman);
                    dataTable.Rows.Add(favorit);
                    dataTable.Rows.Add(totalPriceFavorit, totalPriceWithoutDPHFavorit);
                   
                    // Zobrazení Tabulky
                    dataGridView2.DataSource = dataTable.DefaultView;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
