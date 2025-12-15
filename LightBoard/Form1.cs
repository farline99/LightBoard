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
        private int currentSignalIndex = 0;

        public Form1()
        {
            InitializeComponent();

            DrawBulb(bulb1, BulbState.Off);
            DrawBulb(bulb2, BulbState.Off);
            DrawBulb(bulb3, BulbState.Off);
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

            btnNextSignal.Enabled = true;
            currentSignalIndex = 0;
        }

        private void btnNextSignal_Click(object sender, EventArgs e)
        {
            if (currentSignalIndex >= 18) currentSignalIndex = 0;

            int temp = currentSignalIndex;

            int state1 = temp % 3;
            temp /= 3;

            int state2 = temp % 3;
            temp /= 3;

            int state3 = temp % 3;

            DrawBulb(bulb1, (BulbState)state1);
            DrawBulb(bulb2, (BulbState)state2);
            DrawBulb(bulb3, (BulbState)state3);

            lblResult.Text = $"Сигнал № {currentSignalIndex}";

            currentSignalIndex++;
        }
    }
}
