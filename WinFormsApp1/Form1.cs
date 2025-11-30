namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Checked == false)
            {
                MessageBox.Show("Please enter values in both text boxes.");
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToShortDateString());
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Checked = false;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit); 
                bool secilib = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (secilib)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                
            }
            
        }
    }
}
