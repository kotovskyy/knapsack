using ProblemPlecakowy;

namespace Knapsack_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            int itemsNum = Int32.Parse(itemsNumTextBox.Text);
            int seed = Int32.Parse(seedTextBox.Text);
            int capacity = Int32.Parse(capacityTextBox.Text);

            Problem problem = new Problem(itemsNum, seed);
            Result result = problem.Solve(capacity);

            string problem_string = problem.ToString();
            string result_string = result.ToString();

            programTextBox.Text = problem_string;
            resultTextBox.Text = result_string;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static void errorWarning(object sender)
        {
            TextBox textBox = (TextBox)sender;
            int data;
            textBox.BackColor = Color.White;
            if (!int.TryParse(textBox.Text, out data) || data <= 0)
            {
                textBox.BackColor = Color.Red;
            }
        }

        private void capacityTextBox_TextChanged(object sender, EventArgs e)
        {
            errorWarning(sender);
        }


        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {
            errorWarning(sender);
        }

        private void itemsNumTextBox_TextChanged(object sender, EventArgs e)
        {
            errorWarning(sender);
        }
    }
}
