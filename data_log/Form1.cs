using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace data_log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            dgv_LoggedData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 149, 179, 215);
            dgv_LoggedData.EnableHeadersVisualStyles = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            int count = 0; //count of number of items we have found
            string[] ID_Array = txtbx_values.Text.Split(','); //put data into an array
            string[,] DataArray = new string[10,5]; //2D array to hold the data for the datagridview table


            try
            {
                int freq_value = int.Parse(txtbx_data.Text) % 1000;
                int num_items = int.Parse(txtbx_num_items.Text) / 4;

                if (ID_Array.Length == num_items) //Only do if we have enough Values
                {
                    do
                    {
                        rchtxtbx_output.SelectionFont = new Font(rchtxtbx_output.SelectionFont,
                            FontStyle.Underline | FontStyle.Bold);
                        rchtxtbx_output.AppendText(txtbx_data.Text + "\r");
                        rchtxtbx_output.SelectionFont = new Font(rchtxtbx_output.SelectionFont, FontStyle.Regular);

                        if (chkbx_1000hz.Checked) //log every time if checked.
                        {
                            if (txtbx_id_1000hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_1000hz.Text);
                            if (chkbx_1000hz.Checked)
                                rchtxtbx_output.AppendText(" : 1000Hz : " + ID_Array[count] + "\r"); //always req

                            // add items if empty or condition is right
                            if (DataArray[0, 0] == null) DataArray[0, 0] = txtbx_id_1000hz.Text;
                            if (DataArray[0, 1] == null) DataArray[0, 1] = txtbx_data.Text;
                            if (DataArray[0, 2] == null) DataArray[0, 2] = "1000Hz";
                            DataArray[0, 3] = (DataArray[0, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[0, 3]) + 1).ToString();
                            DataArray[0, 4] = (DataArray[0, 4] == null)
                                ? ID_Array[count]
                                : DataArray[0, 4] + "," + ID_Array[count];

                            count++;
                        }

                        if ((chkbx_500hz.Checked) && (freq_value % 2 == 0)) // even
                        {
                            if (txtbx_id_500hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_500hz.Text);
                            rchtxtbx_output.AppendText(" :  500Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[1, 0] == null) DataArray[1, 0] = txtbx_id_500hz.Text;
                            if (DataArray[1, 1] == null) DataArray[1, 1] = txtbx_data.Text;
                            if (DataArray[1, 2] == null) DataArray[1, 2] = "500Hz";
                            DataArray[1, 3] = (DataArray[1, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[1, 3]) + 1).ToString();
                            DataArray[1, 4] = (DataArray[1, 4] == null) ? ID_Array[count] : DataArray[1, 4] + "," + ID_Array[count];

                            count++;
                        }

                        if ((chkbx_200hz.Checked) && (freq_value % 5 == 0)) //div by 5
                        {
                            if (txtbx_id_200hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_200hz.Text);
                            rchtxtbx_output.AppendText(" :  200Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[2, 0] == null) DataArray[2, 0] = txtbx_id_200hz.Text;
                            if (DataArray[2, 1] == null) DataArray[2, 1] = txtbx_data.Text;
                            if (DataArray[2, 2] == null) DataArray[2, 2] = "200Hz";
                            DataArray[2, 3] = (DataArray[2, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[2, 3]) + 1).ToString();
                            DataArray[2, 4] = (DataArray[2, 4] == null) ? ID_Array[count] : DataArray[2, 4] + "," + ID_Array[count];

                            count++;
                        }


                        //section by 10s
                        if ((chkbx_100hz.Checked) && (freq_value % 10 == 0))
                        {
                            if (txtbx_id_100hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_100hz.Text);
                            rchtxtbx_output.AppendText(" :  100Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[3, 0] == null) DataArray[3, 0] = txtbx_id_100hz.Text;
                            if (DataArray[3, 1] == null) DataArray[3, 1] = txtbx_data.Text;
                            if (DataArray[3, 2] == null) DataArray[3, 2] = "100Hz";
                            DataArray[3, 3] = (DataArray[3, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[3, 3]) + 1).ToString();
                            DataArray[3, 4] = (DataArray[3, 4] == null) ? ID_Array[count] : DataArray[3, 4] + "," + ID_Array[count];

                            count++;
                        }

                        if ((chkbx_50hz.Checked) && (freq_value % 20 == 0))
                        {
                            if (txtbx_id_50hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_50hz.Text);
                            rchtxtbx_output.AppendText(" :   50Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[4, 0] == null) DataArray[4, 0] = txtbx_id_50hz.Text;
                            if (DataArray[4, 1] == null) DataArray[4, 1] = txtbx_data.Text;
                            if (DataArray[4, 2] == null) DataArray[4, 2] = "50Hz";
                            DataArray[4, 3] = (DataArray[4, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[4, 3]) + 1).ToString();
                            DataArray[4, 4] = (DataArray[4, 4] == null) ? ID_Array[count] : DataArray[4, 4] + "," + ID_Array[count];

                            count++;
                        }

                        if ((chkbx_20hz.Checked) && (freq_value % 50 == 0))
                        {
                            if (txtbx_id_20hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_20hz.Text);
                            rchtxtbx_output.AppendText(" :   20Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[5, 0] == null) DataArray[5, 0] = txtbx_id_20hz.Text;
                            if (DataArray[5, 1] == null) DataArray[5, 1] = txtbx_data.Text;
                            if (DataArray[5, 2] == null) DataArray[5, 2] = "20Hz";
                            DataArray[5, 3] = (DataArray[5, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[5, 3]) + 1).ToString();
                            DataArray[5, 4] = (DataArray[5, 4] == null) ? ID_Array[count] : DataArray[5, 4] + "," + ID_Array[count];

                            count++;
                        }

                        if ((chkbx_10hz.Checked) && (freq_value % 100 == 0))
                        {
                            if (txtbx_id_10hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_10hz.Text);
                            rchtxtbx_output.AppendText(" :   10Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[6, 0] == null) DataArray[6, 0] = txtbx_id_10hz.Text;
                            if (DataArray[6, 1] == null) DataArray[6, 1] = txtbx_data.Text;
                            if (DataArray[6, 2] == null) DataArray[6, 2] = "10Hz";
                            DataArray[6, 3] = (DataArray[6, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[6, 3]) + 1).ToString();
                            DataArray[6, 4] = (DataArray[6, 4] == null) ? ID_Array[count] : DataArray[6, 4] + "," + ID_Array[count];

                            count++;
                        }

                        if ((chkbx_5hz.Checked) && (freq_value % 200 == 0))
                        {
                            if (txtbx_id_5hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_5hz.Text);
                            rchtxtbx_output.AppendText(" :    5Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[7, 0] == null) DataArray[7, 0] = txtbx_id_5hz.Text;
                            if (DataArray[7, 1] == null) DataArray[7, 1] = txtbx_data.Text;
                            if (DataArray[7, 2] == null) DataArray[7, 2] = "5Hz";
                            DataArray[7, 3] = (DataArray[7, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[7, 3]) + 1).ToString();
                            DataArray[7, 4] = (DataArray[7, 4] == null) ? ID_Array[count] : DataArray[7, 4] + "," + ID_Array[count];


                            count++;
                        }

                        if ((chkbx_2hz.Checked) && (freq_value % 500 == 0))
                        {
                            if (txtbx_id_2hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_2hz.Text);
                            rchtxtbx_output.AppendText(" :    2Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[8, 0] == null) DataArray[8, 0] = txtbx_id_2hz.Text;
                            if (DataArray[8, 1] == null) DataArray[8, 1] = txtbx_data.Text;
                            if (DataArray[8, 2] == null) DataArray[8, 2] = "2Hz";
                            DataArray[8, 3] = (DataArray[8, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[8, 3]) + 1).ToString();
                            DataArray[8, 4] = (DataArray[8, 4] == null) ? ID_Array[count] : DataArray[8, 4] + "," + ID_Array[count];

                            count++;
                        }

                        if ((chkbx_1hz.Checked) && (freq_value % 1000 == 0))
                        {
                            if (txtbx_id_1hz.Text != "") rchtxtbx_output.AppendText(txtbx_id_1hz.Text);
                            rchtxtbx_output.AppendText(" :    1Hz : " + ID_Array[count] + "\r");

                            // add items if empty or condition is right
                            if (DataArray[9, 0] == null) DataArray[9, 0] = txtbx_id_1hz.Text;
                            if (DataArray[9, 1] == null) DataArray[9, 1] = txtbx_data.Text;
                            if (DataArray[9, 2] == null) DataArray[9, 2] = "1Hz";
                            DataArray[9, 3] = (DataArray[9, 3] == null)
                                ? "1"
                                : (int.Parse(DataArray[9, 3]) + 1).ToString();
                            DataArray[9, 4] = (DataArray[9, 4] == null) ? ID_Array[count] : DataArray[9, 4] + "," + ID_Array[count];

                            count++;
                        }

                        rchtxtbx_output.AppendText("\r\r");
                        rchtxtbx_output.ScrollToCaret(); //put cursor at the bottom

                        freq_value++; //next tick
                        txtbx_data.Text = (int.Parse(txtbx_data.Text) + 1).ToString();

                    } while (count < num_items);

                    txtbx_data.Text = (int.Parse(txtbx_data.Text) - 1).ToString();

                }
                else
                {
                    MessageBox.Show("Check that you have the same number of values as the number required", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                PopulateTable(DataArray); // Create the table
            }
            catch (Exception exception)
            {
                //something not correct but for this example
                //do nothing just carry on.
            }


        }

        private void PopulateTable(string[,] Data)
        {
            for (int i = 0; i < 10; i++) //we have 10 different frequencies
            {
                if (Data[i,0] != null)
                {
                    dgv_LoggedData.Rows.Add();

                    dgv_LoggedData.Rows[i].Cells[0].Value = int.Parse(Data[i,0]);
                    dgv_LoggedData.Rows[i].Cells[1].Value = Data[i,1];
                    dgv_LoggedData.Rows[i].Cells[2].Value = Data[i,2];
                    dgv_LoggedData.Rows[i].Cells[3].Value = Data[i,3];
                    dgv_LoggedData.Rows[i].Cells[4].Value = Data[i,4];
                }

            }

            dgv_LoggedData.Sort(dgv_LoggedData.Columns[0], ListSortDirection.Ascending); //Sort the data to col 0

            dgv_LoggedData.CurrentCell.Selected = false; //remove the highlight from cell

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxtbx_output.Text = "";
            txtbx_data.Text = "";
            txtbx_num_items.Text = "";

            chkbx_1000hz.Checked =
                chkbx_200hz.Checked = chkbx_500hz.Checked = chkbx_100hz.Checked =
                    chkbx_20hz.Checked = chkbx_50hz.Checked = chkbx_10hz.Checked =
                        chkbx_2hz.Checked = chkbx_5hz.Checked = chkbx_1hz.Checked = false;


            txtbx_id_1000hz.Text =
                txtbx_id_500hz.Text = txtbx_id_200hz.Text = txtbx_id_100hz.Text =
                    txtbx_id_50hz.Text = txtbx_id_20hz.Text = txtbx_id_10hz.Text =
                        txtbx_id_5hz.Text = txtbx_id_2hz.Text = txtbx_id_1hz.Text = "";


            txtbx_values.Text = "";

            dgv_LoggedData.Rows.Clear();
            dgv_LoggedData.Refresh();
        }

        private void btn_populate_Click(object sender, EventArgs e)
        {
            if (rdobtn_438.Checked)
            {
                txtbx_data.Text = "456438";
                txtbx_num_items.Text = "24";

                chkbx_200hz.Checked = true;
                chkbx_500hz.Checked = true;
                chkbx_1000hz.Checked = true;

                txtbx_id_500hz.Text = "2";
                txtbx_id_200hz.Text = "1";
                txtbx_id_1000hz.Text = "0";

                txtbx_values.Text = "A,B,C,D,E,F";
            }
            else
            {
                txtbx_data.Text = "0";
                txtbx_num_items.Text = "72";

                chkbx_1000hz.Checked =
                    chkbx_200hz.Checked = chkbx_500hz.Checked = chkbx_100hz.Checked =
                        chkbx_20hz.Checked = chkbx_50hz.Checked = chkbx_10hz.Checked =
                            chkbx_2hz.Checked = chkbx_5hz.Checked = chkbx_1hz.Checked = true;


                txtbx_id_1000hz.Text = "0";
                txtbx_id_500hz.Text = "4";
                txtbx_id_200hz.Text = "7";
                txtbx_id_100hz.Text = "1";
                txtbx_id_50hz.Text = "5";
                txtbx_id_20hz.Text = "8";
                txtbx_id_10hz.Text = "2";
                txtbx_id_5hz.Text = "6";
                txtbx_id_2hz.Text = "9";
                txtbx_id_1hz.Text = "3";

                txtbx_values.Text = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R";
            }
        }
    }
}
