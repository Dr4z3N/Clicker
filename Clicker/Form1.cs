namespace Clicker
{
    public partial class Form1 : Form
    {
        int buttonlvl;
        int cash;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonlvl = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash ++;
            label1.Text = "Kremowki:" + cash.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int upgradeCost = (int)Math.Pow(10, buttonlvl);
            if(cash >= upgradeCost)
            {

                buttonlvl++;
                button1.Text = "Respekt Papieski:" + buttonlvl.ToString();
                cash -= upgradeCost;
                label1.Text = "Kremowki:$" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonlvl).ToString() + ")";
                button2.Text = "Upgrade\n" + nextUpgradeCost;

            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}