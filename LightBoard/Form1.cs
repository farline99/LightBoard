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
                    pb.BackColor = Color.Gray; // Серый - выкл
                    break;
                case BulbState.On:
                    pb.BackColor = Color.Yellow; // Желтый - вкл
                    break;
                case BulbState.Blink:
                    pb.BackColor = Color.Orange; // Оранжевый - условно "мигает"
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int signalsNeeded = 18;
            int statesPerBulb = 3;
            int bulbs = 0;
            int currentCombinations = 1;

            // Цикл пока комбинаций меньше чем нужно сигналов
            while (currentCombinations < signalsNeeded)
            {
                bulbs++;
                currentCombinations *= statesPerBulb;
            }

            lblResult.Text = $"Для {signalsNeeded} сигналов нужно {bulbs} лампочки (комбинаций: {currentCombinations})";

            btnNextSignal.Enabled = true;
            currentSignalIndex = 0; // Сброс при новом расчете
        }

        private void btnNextSignal_Click(object sender, EventArgs e)
        {
            // Ограничиваем 18 сигналами (0..17)
            if (currentSignalIndex >= 18) currentSignalIndex = 0;

            int temp = currentSignalIndex;

            // Получаем состояния для 3 лампочек (деление с остатком на 3)
            int digitForRight = temp % 3;
            temp /= 3;

            int digitForMiddle = temp % 3;
            temp /= 3;

            int digitForLeft = temp % 3;

            // Отрисовываем
            DrawBulb(bulb3, (BulbState)digitForRight);
            DrawBulb(bulb2, (BulbState)digitForMiddle);
            DrawBulb(bulb1, (BulbState)digitForLeft);

            lblResult.Text = $"Сигнал № {currentSignalIndex}";

            currentSignalIndex++;
        }
    }
}
