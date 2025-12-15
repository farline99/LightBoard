namespace LightBoard
{
    public enum BulbState
    {
        Off = 0,      // Выключено
        On = 1,       // Включено
        Blink = 2     // Мигает
    }

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawBulb(PictureBox pb, BulbState state)
        {
            switch (state)
            {
                case BulbState.Off:
                    pb.BackColor = Color.Gray;
                    break;
                case BulbState.On:
                    pb.BackColor = Color.Yellow;
                    break;
                case BulbState.Blink:
                    pb.BackColor = Color.Orange;
                    break;
            }
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
