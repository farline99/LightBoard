namespace LightBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int signalsNeeded = 18;
            int statesPerBulb = 3;
            int bulbs = 0;
            int currentCombinations = 1;

            while (currentCombinations < signalsNeeded)
            {
                bulbs++;
                currentCombinations *= statesPerBulb;
            }

            lblResult.Text = $"Для {signalsNeeded} сигналов нужно {bulbs} лампочки (комбинаций: {currentCombinations})";
        }
    }
}
