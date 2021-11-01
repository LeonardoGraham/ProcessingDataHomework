using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessingDataHomework
{
    public partial class EstimatorForm : Form
    {
        public EstimatorForm()
        {
            InitializeComponent();
        }

        private void EstimateButton_Click(object sender, EventArgs e)
        {
            // Constants
            const int SQ_FT_TO_EVALUATE = 15;
            const int GALLONS_PER_15 = 1;
            const int HOURS_PER_15 = 8;
            const double LABOR_COST_PER_HOUR = 20.00;

            // Input
            Console.Write("Square Feet of Wall Space to Paint: ");
            double sqFtToPaint = Convert.ToDouble(WallSpaceSizeTextBox.Text);
            Console.Write("Price of Paint per Gallon: ");
            double paintPrice = Convert.ToDouble(PaintPriceTextBox.Text);

            // Calculations
            double numOfSections = sqFtToPaint / SQ_FT_TO_EVALUATE;
            double gallonsOfPaint = numOfSections * GALLONS_PER_15;
            double hoursOfLabor = numOfSections * HOURS_PER_15;
            double costOfPaint = gallonsOfPaint * paintPrice;
            double laborCharges = hoursOfLabor * LABOR_COST_PER_HOUR;
            double totalCost = costOfPaint + laborCharges;

            // Output
            PaintRequiredLabel.Text = String.Format("{0} Gallons", gallonsOfPaint.ToString("F"));
            LaborRequiredLabel.Text = String.Format("{0} Hours", hoursOfLabor.ToString("F"));
            PaintCostLabel.Text = costOfPaint.ToString("C");
            LaborChargesLabel.Text = laborCharges.ToString("C");
            TotalCostLabel.Text = totalCost.ToString("C");;
        }
    }
}
