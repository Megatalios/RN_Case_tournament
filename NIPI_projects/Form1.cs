using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NIPI_projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DeltaP.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            JD.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            k.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            h.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            muN.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            muW.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            muG.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            BG.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            BW.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            BN.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            Rs.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            target_W.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            target_G.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);

            OFP_WN.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            OFP_WN.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DataGridView_EditingControlShowing);            //dataGridView1.Columns.CollectionChanged += new KeyPressEventHandler(NumericTextBox_KeyPress);
            OFP_GN.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);

            MessageBox.Show("В комментариях к коду в файле Program.cs расписано, как задача была понята, а также другой алгоритм (который уже не был реализован)");
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { 
            // Разрешаем цифры, точку и управляющие символы (например, Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            } 
            // Если введена точка, проверить, что точка уже не введена
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) 
        { 
            if (e.Control is System.Windows.Forms.TextBox textBox) 
            { 
                textBox.KeyPress -= new KeyPressEventHandler(NumericTextBox_KeyPress); 
                textBox.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            } 
        }

        private double[] ConvertColumnToDoubleArray(DataGridView dgv, int columnIndex) 
        { 
            List<double> columnData = new List<double>(); 
            foreach (DataGridViewRow row in dgv.Rows) 
            { 
                if (row.Cells[columnIndex].Value != null) 
                {
                    if (double.TryParse(row.Cells[columnIndex].Value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                    { 
                        columnData.Add(result); 
                    }
                } 
            } 
            return columnData.ToArray(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DeltaP.Text != "" &&
                JD.Text != "" &&
                k.Text != "" &&
                h.Text != "" &&
                muN.Text != "" &&
                muW.Text != "" &&
                muG.Text != "" &&
                BN.Text != "" &&
                BW.Text != "" &&
                BG.Text != "" &&
                Rs.Text != "" &&
                target_W.Text != "" &&
                target_G.Text != "")
            {
                double[] S_w = ConvertColumnToDoubleArray(OFP_WN, 0);
                double[] ofp_w = ConvertColumnToDoubleArray(OFP_WN, 1);
                double[] ofp_wn = ConvertColumnToDoubleArray(OFP_WN, 2);

                double[] S_g = ConvertColumnToDoubleArray(OFP_GN, 0);
                double[] ofp_g = ConvertColumnToDoubleArray(OFP_GN, 1);
                double[] ofp_gn = ConvertColumnToDoubleArray(OFP_GN, 2);

                

               Solution solution = new Solution(S_w, ofp_w, ofp_wn, S_g, ofp_g, ofp_gn);

               solution.set_parameters(double.Parse(DeltaP.Text, CultureInfo.InvariantCulture), double.Parse(JD.Text, CultureInfo.InvariantCulture), double.Parse(k.Text, CultureInfo.InvariantCulture), double.Parse(h.Text, CultureInfo.InvariantCulture), double.Parse(muN.Text, CultureInfo.InvariantCulture), double.Parse(muW.Text, CultureInfo.InvariantCulture), double.Parse(muG.Text, CultureInfo.InvariantCulture), double.Parse(BN.Text, CultureInfo.InvariantCulture), double.Parse(BW.Text, CultureInfo.InvariantCulture), double.Parse(BG.Text, CultureInfo.InvariantCulture), double.Parse(Rs.Text, CultureInfo.InvariantCulture)); 
               var result = solution.SimulatedAnnealing(double.Parse(target_W.Text, CultureInfo.InvariantCulture), double.Parse(target_G.Text, CultureInfo.InvariantCulture));
               MessageBox.Show("S_w = " + result.S_w.ToString() + ",\nS_g = " + result.S_g.ToString() + "\n Вычисленные показатели обводненности и газового фактора будут написаны вместо целевых значений");
               target_G.Text = solution.gas_factor(result.S_w, result.S_g).ToString();
               target_W.Text = solution.water_factor(result.S_w, result.S_g).ToString();
                
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }

        }

        // Тестовая кнопка (не используется)
        private void button2_Click(object sender, EventArgs e)
        {
            double[] S_w = ConvertColumnToDoubleArray(OFP_WN, 0);
            double[] ofp_w = ConvertColumnToDoubleArray(OFP_WN, 1);
            double[] ofp_wn = ConvertColumnToDoubleArray(OFP_WN, 2);

            double[] S_g = ConvertColumnToDoubleArray(OFP_GN, 0);
            double[] ofp_g = ConvertColumnToDoubleArray(OFP_GN, 1);
            double[] ofp_gn = ConvertColumnToDoubleArray(OFP_GN, 2);

            MessageBox.Show("S_w " + S_w.Length.ToString() + 
                "\nS_g " + S_g.Length.ToString() + 
                "\nofp_w" + ofp_w.Length.ToString() +
                "\nofp_g" + ofp_g.Length.ToString() +
                "\nofp_wn" + ofp_wn.Length.ToString() +
                "\nofp_gn" + ofp_gn.Length.ToString()); 
        }

        private void test_button_click(object sender, EventArgs e)
        {
            Solution sol = new Solution();
            var res = sol.SimulatedAnnealing(0.1, 120);
            MessageBox.Show("S_w = " + res.S_w.ToString() + "\nS_g = " + res.S_g.ToString() + "\nВычисленные показатели обводненности и газового фактора будут написаны вместо целевых значений");
            target_W.Text = sol.water_factor(res.S_w, res.S_g).ToString();
            target_G.Text = sol.gas_factor(res.S_w, res.S_g).ToString();

        }
    }
}              
               
               
               
               
               
               
               