using System;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace PrintInf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Populate the ComboBox with installed printers
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                comboBoxPrinters.Items.Add(printerName);
            }
        }
        private void buttonCheckPageCount_Click(object sender, EventArgs e)
        { 
        }
        private void comboBoxPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the information TextBox
            textBox1.Clear();
            pArea.Clear();
            pRes.Clear();
            pDefault.Clear();
            pDuplex.Clear();
            pCol.Clear();

            // Clear and repopulate the ComboBox containing paper sizes
            comboBoxPaperSizes.Items.Clear();

            // Get the selected printer from the ComboBox
            string selectedPrinter = comboBoxPrinters.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedPrinter))
            {
                MessageBox.Show("Please select a printer.");
                return;
            }

            // Create a PrinterSettings object for the selected printer
            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.PrinterName = selectedPrinter;

            // Get the maximum supported resolution
            PrinterResolution maxResolution = printerSettings.PrinterResolutions
                .Cast<PrinterResolution>()
                .OrderByDescending(pr => pr.X * pr.Y)
                .FirstOrDefault();

            // Get and display various properties of the selected printer
            textBox1.AppendText($"{printerSettings.PrinterName}\r\n");
            pArea.AppendText($"{Math.Round(printerSettings.DefaultPageSettings.PrintableArea.Width, 2)} Width x {Math.Round(printerSettings.DefaultPageSettings.PrintableArea.Height, 2)} Height\r\n");
            pDefault.AppendText($"{printerSettings.IsDefaultPrinter}\r\n");
            pDuplex.AppendText($"{printerSettings.CanDuplex}\r\n");
            pCol.AppendText($"{printerSettings.SupportsColor}\r\n");
            if (maxResolution != null)
            {
                pRes.AppendText($"{maxResolution.X}x{maxResolution.Y}\r\n");
            }
            else
            {
                pRes.AppendText("Resolution information not available\r\n");
            }

            // Populate the ComboBox with supported paper sizes
            foreach (PaperSize paperSize in printerSettings.PaperSizes.Cast<PaperSize>())
            {
                comboBoxPaperSizes.Items.Add(paperSize.PaperName);
            }
        }

        // Handle the selection change in the paper size ComboBox
        private void comboBoxPaperSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve and display the selected paper size
            string selectedPaperSize = comboBoxPaperSizes.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedPaperSize))
            {
                // You can display or use the selected paper size as needed
                MessageBox.Show($"Selected Paper Size: {selectedPaperSize}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pDefault_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pDuplex_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pCol_TextChanged(object sender, EventArgs e)
        {

        }


    }

}
