namespace MDK01._04.Kursach
{
    public partial class Form1 : Form
    {
        int userNumber, number, upLimit, downLimit;
        Random r;
        public Form1()
        {
            InitializeComponent();
            startForm();
        }

        private void startForm()
        {
            nudLimit.Enabled = false;
            btnStart.Enabled = false;
            btnCheck.Enabled = false;
            nudNumber.Enabled = false;
            r = new Random();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            nudLimit.Enabled = true;
            btnStart.Enabled = true;
            nudNumber.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            nudLimit.Enabled = false;
            nudNumber.Enabled = true;
            btnCheck.Enabled = true;
            upLimit = Convert.ToInt32(nudLimit.Value);
            number = r.Next(1, upLimit);
            lblTask.Text = $"� ������� ����� �� 1 �� {upLimit}. �������� �������:";
            nudNumber.Maximum = upLimit;
            nudNumber.Minimum = 1;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            userNumber = Convert.ToInt32(nudNumber.Value);
            if (userNumber == number)
            {
                lblInfo.Text = $"������������! �� �������! � ������� ����� {number}";
                startForm();
                return;
            }
            if (userNumber < number)
            {
                lblInfo.Text = $"�� ������, ��� ����� ������ {userNumber}. �������� ���!";
                changeLimits(userNumber, Convert.ToInt32(nudNumber.Maximum));
            }
            else
            {
                lblInfo.Text = $"�� ������, ��� ����� ������ {userNumber}. �������� ���!";
                changeLimits(Convert.ToInt32(nudNumber.Minimum), userNumber);
            }
        }

        private void changeLimits(int down, int up)
        {
            lblTask.Text = $"� ������� ����� �� {down} �� {up}. �������� �������:";
            nudNumber.Minimum = down;
            nudNumber.Maximum = up;
        }

    }
}
