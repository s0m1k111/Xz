namespace Xz
{
    public partial class Form1 : Form
    {
        private List<Button> listButton;
        public Form1()
        {
            InitializeComponent();
            listButton = new()
            {
                button1,
                button2,
                button3,
                button4,
                button5
            };
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listButton.Count; i++)
            {
                listButton[i].Size = new Size((new Random().Next(70, 200)), (new Random().Next(100, 200)));
            }
            listButton = listButton.OrderBy(button => button.Size.Height).ToList();
            for (int i = 0; i < listButton.Count; i++) 
            {
                listButton[i].Text = i.ToString();
                //listButton[i].Size = new(100, 100);
            }
            for(int i = 1;i < listButton.Count;i++)
            {
                listButton[i].Location = new(listButton[i - 1].Location.X + listButton[i - 1].Size.Width, listButton[0].Location.Y - listButton[i].Size.Height + listButton[0].Size.Height);
            }
            
        }
    }

}

