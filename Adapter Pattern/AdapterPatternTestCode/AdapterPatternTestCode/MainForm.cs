namespace AdapterPatternTestCode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            var windowsButton = new WindowsButton();

            IButton buttonAdapter = new ButtonAdapter(windowsButton);

            Button myButton = new Button();
            myButton.Text = "Click";
            myButton.Click += (sender, e) => buttonAdapter.Click();
            myButton.Location = new Point(150, 105);

            this.Controls.Add(myButton);
        }
    }
}
