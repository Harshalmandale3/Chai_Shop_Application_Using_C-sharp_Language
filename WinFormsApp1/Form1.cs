using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int quantityTea = 1;
        String total1;
        private void button1_Click(object sender, EventArgs e)
        {
            int total = quantityTea * 10;
            total1 = total.ToString();
            textBoxTea.Text = "Tea " + "10" + "*" + quantityTea + "=" + total1;
            quantityTea++;
        }

        int quantityCoffee = 1;
        String total2;
        private void button2_Click(object sender, EventArgs e)
        {
            int total = quantityCoffee * 15;
            total2 = total.ToString();
            textBoxCoffee.Text = "Coffee " + "15" + "*" + quantityCoffee + "=" + total2;
            quantityCoffee++;
        }

        int quantitySandwich = 1;
        String total3;
        private void button3_Click(object sender, EventArgs e)
        {
            int total = quantitySandwich * 30;
            total3 = total.ToString();
            textBoxSandwich.Text = "Sandwich " + "30" + "*" + quantitySandwich + "=" + total3;
            quantitySandwich++;

        }

        int quantityBurger = 1;
        String total4;
        private void button4_Click(object sender, EventArgs e)
        {
            int total = quantityBurger * 80;
            total4 = total.ToString();
            textBoxBurger.Text = "Burger " + "80" + "*" + quantityBurger + "=" + total4;
            quantityBurger++;
        }

        private void clearTeabutton_Click(object sender, EventArgs e)
        {
            textBoxTea.Text = string.Empty;
            textBoxTea.Clear();
            quantityTea = 1;
        }

        private void clearCoffeebutton_Click(object sender, EventArgs e)
        {
            textBoxCoffee.Text = string.Empty;
            textBoxCoffee.Clear();
            quantityCoffee = 1;
        }

        private void clearSandwichbutton_Click(object sender, EventArgs e)
        {
            textBoxSandwich.Text = string.Empty;
            textBoxSandwich.Clear();
            quantitySandwich = 1;
        }

        private void clearBurgerbutton_Click(object sender, EventArgs e)
        {
            textBoxBurger.Text = string.Empty;
            textBoxBurger.Clear();
            quantityBurger = 1;
        }

        int tot;
        private void Totalbutton_Click(object sender, EventArgs e)
        {
            String[] arr = new string[4];

            arr[0] = textBoxTea.Text;
            arr[1] = textBoxCoffee.Text;
            arr[2] = textBoxSandwich.Text;
            arr[3] = textBoxBurger.Text;


            //ListViewItem lvi =new ListViewItem(arr);

            //textBoxPrint.Text = textBoxTea.Text;
            //textBoxPrint.Text += "\n";
            //textBoxPrint.Text += textBoxCoffee.Text;
            //textBoxPrint.Text += "\n";
            //textBoxPrint.Text += textBoxSandwich.Text;
            //textBoxPrint.Text += "\n";
            //textBoxPrint.Text += textBoxBurger.Text;


            int t1= Convert.ToInt32(total1);
            int t2= Convert.ToInt32(total2);
            int t3= Convert.ToInt32(total3);
            int t4= Convert.ToInt32(total4);

            tot = t1 + t2 + t3 + t4;

            textBoxtotal.Text = "Rs. "+ tot.ToString();
            //textBoxPrint.Text = "tot";

           
            
        }

        private void textBoxPrint_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0); 
        }

        Bitmap bitmap;

        private void Printbutton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();

            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();

            Size size = this.ClientSize;

            bitmap = new Bitmap(size.Width, size.Height, graphics);

            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);

            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }

        private void textBoxTea_TextChanged(object sender, EventArgs e)
        {
            textBoxTea.ReadOnly= true;
        }

        private void textBoxCoffee_TextChanged(object sender, EventArgs e)
        {
            textBoxCoffee.ReadOnly= true;
        }

        private void textBoxSandwich_TextChanged(object sender, EventArgs e)
        {
            textBoxSandwich.ReadOnly= true;
        }

        private void textBoxBurger_TextChanged(object sender, EventArgs e)
        {
            textBoxBurger.ReadOnly= true;
        }

        private void textBoxtotal_TextChanged(object sender, EventArgs e)
        {
            textBoxtotal.ReadOnly= true;
        }
    }
   
}