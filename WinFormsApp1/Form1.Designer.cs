namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxTea = new System.Windows.Forms.TextBox();
            this.textBoxCoffee = new System.Windows.Forms.TextBox();
            this.textBoxSandwich = new System.Windows.Forms.TextBox();
            this.textBoxBurger = new System.Windows.Forms.TextBox();
            this.clearTeabutton = new System.Windows.Forms.Button();
            this.clearCoffeebutton = new System.Windows.Forms.Button();
            this.clearSandwichbutton = new System.Windows.Forms.Button();
            this.clearBurgerbutton = new System.Windows.Forms.Button();
            this.textBoxPrint = new System.Windows.Forms.TextBox();
            this.Totalbutton = new System.Windows.Forms.Button();
            this.textBoxtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Printbutton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 124);
            this.button2.TabIndex = 1;
            this.button2.Text = "Coffee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 248);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 124);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sandwich";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(237, 248);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 124);
            this.button4.TabIndex = 3;
            this.button4.Text = "Burger";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxTea
            // 
            this.textBoxTea.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTea.Location = new System.Drawing.Point(537, 112);
            this.textBoxTea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTea.Multiline = true;
            this.textBoxTea.Name = "textBoxTea";
            this.textBoxTea.Size = new System.Drawing.Size(303, 60);
            this.textBoxTea.TabIndex = 4;
            this.textBoxTea.TextChanged += new System.EventHandler(this.textBoxTea_TextChanged);
            // 
            // textBoxCoffee
            // 
            this.textBoxCoffee.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCoffee.Location = new System.Drawing.Point(537, 181);
            this.textBoxCoffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCoffee.Multiline = true;
            this.textBoxCoffee.Name = "textBoxCoffee";
            this.textBoxCoffee.Size = new System.Drawing.Size(303, 60);
            this.textBoxCoffee.TabIndex = 5;
            this.textBoxCoffee.TextChanged += new System.EventHandler(this.textBoxCoffee_TextChanged);
            // 
            // textBoxSandwich
            // 
            this.textBoxSandwich.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSandwich.Location = new System.Drawing.Point(537, 255);
            this.textBoxSandwich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSandwich.Multiline = true;
            this.textBoxSandwich.Name = "textBoxSandwich";
            this.textBoxSandwich.Size = new System.Drawing.Size(303, 60);
            this.textBoxSandwich.TabIndex = 6;
            this.textBoxSandwich.TextChanged += new System.EventHandler(this.textBoxSandwich_TextChanged);
            // 
            // textBoxBurger
            // 
            this.textBoxBurger.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBurger.Location = new System.Drawing.Point(537, 325);
            this.textBoxBurger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBurger.Multiline = true;
            this.textBoxBurger.Name = "textBoxBurger";
            this.textBoxBurger.Size = new System.Drawing.Size(303, 60);
            this.textBoxBurger.TabIndex = 7;
            this.textBoxBurger.TextChanged += new System.EventHandler(this.textBoxBurger_TextChanged);
            // 
            // clearTeabutton
            // 
            this.clearTeabutton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearTeabutton.ForeColor = System.Drawing.Color.Red;
            this.clearTeabutton.Location = new System.Drawing.Point(861, 112);
            this.clearTeabutton.Name = "clearTeabutton";
            this.clearTeabutton.Size = new System.Drawing.Size(105, 60);
            this.clearTeabutton.TabIndex = 8;
            this.clearTeabutton.Text = "Clear";
            this.clearTeabutton.UseVisualStyleBackColor = true;
            this.clearTeabutton.Click += new System.EventHandler(this.clearTeabutton_Click);
            // 
            // clearCoffeebutton
            // 
            this.clearCoffeebutton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearCoffeebutton.ForeColor = System.Drawing.Color.Red;
            this.clearCoffeebutton.Location = new System.Drawing.Point(861, 184);
            this.clearCoffeebutton.Name = "clearCoffeebutton";
            this.clearCoffeebutton.Size = new System.Drawing.Size(105, 60);
            this.clearCoffeebutton.TabIndex = 9;
            this.clearCoffeebutton.Text = "Clear";
            this.clearCoffeebutton.UseVisualStyleBackColor = true;
            this.clearCoffeebutton.Click += new System.EventHandler(this.clearCoffeebutton_Click);
            // 
            // clearSandwichbutton
            // 
            this.clearSandwichbutton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearSandwichbutton.ForeColor = System.Drawing.Color.Red;
            this.clearSandwichbutton.Location = new System.Drawing.Point(861, 253);
            this.clearSandwichbutton.Name = "clearSandwichbutton";
            this.clearSandwichbutton.Size = new System.Drawing.Size(105, 60);
            this.clearSandwichbutton.TabIndex = 10;
            this.clearSandwichbutton.Text = "Clear";
            this.clearSandwichbutton.UseVisualStyleBackColor = true;
            this.clearSandwichbutton.Click += new System.EventHandler(this.clearSandwichbutton_Click);
            // 
            // clearBurgerbutton
            // 
            this.clearBurgerbutton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBurgerbutton.ForeColor = System.Drawing.Color.Red;
            this.clearBurgerbutton.Location = new System.Drawing.Point(861, 325);
            this.clearBurgerbutton.Name = "clearBurgerbutton";
            this.clearBurgerbutton.Size = new System.Drawing.Size(105, 60);
            this.clearBurgerbutton.TabIndex = 11;
            this.clearBurgerbutton.Text = "Clear";
            this.clearBurgerbutton.UseVisualStyleBackColor = true;
            this.clearBurgerbutton.Click += new System.EventHandler(this.clearBurgerbutton_Click);
            // 
            // textBoxPrint
            // 
            this.textBoxPrint.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxPrint.Location = new System.Drawing.Point(515, 16);
            this.textBoxPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrint.Multiline = true;
            this.textBoxPrint.Name = "textBoxPrint";
            this.textBoxPrint.Size = new System.Drawing.Size(463, 465);
            this.textBoxPrint.TabIndex = 12;
            this.textBoxPrint.TextChanged += new System.EventHandler(this.textBoxPrint_TextChanged);
            // 
            // Totalbutton
            // 
            this.Totalbutton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Totalbutton.Location = new System.Drawing.Point(590, 409);
            this.Totalbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Totalbutton.Name = "Totalbutton";
            this.Totalbutton.Size = new System.Drawing.Size(106, 45);
            this.Totalbutton.TabIndex = 13;
            this.Totalbutton.Text = "Total";
            this.Totalbutton.UseVisualStyleBackColor = true;
            this.Totalbutton.Click += new System.EventHandler(this.Totalbutton_Click);
            // 
            // textBoxtotal
            // 
            this.textBoxtotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxtotal.Location = new System.Drawing.Point(734, 408);
            this.textBoxtotal.Multiline = true;
            this.textBoxtotal.Name = "textBoxtotal";
            this.textBoxtotal.Size = new System.Drawing.Size(159, 47);
            this.textBoxtotal.TabIndex = 14;
            this.textBoxtotal.TextChanged += new System.EventHandler(this.textBoxtotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(681, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Bill";
            // 
            // Printbutton
            // 
            this.Printbutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Printbutton.Location = new System.Drawing.Point(703, 519);
            this.Printbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(114, 51);
            this.Printbutton.TabIndex = 16;
            this.Printbutton.Text = "Print";
            this.Printbutton.UseVisualStyleBackColor = true;
            this.Printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1010, 604);
            this.Controls.Add(this.Printbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxtotal);
            this.Controls.Add(this.Totalbutton);
            this.Controls.Add(this.clearBurgerbutton);
            this.Controls.Add(this.clearSandwichbutton);
            this.Controls.Add(this.clearCoffeebutton);
            this.Controls.Add(this.clearTeabutton);
            this.Controls.Add(this.textBoxBurger);
            this.Controls.Add(this.textBoxSandwich);
            this.Controls.Add(this.textBoxCoffee);
            this.Controls.Add(this.textBoxTea);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPrint);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Asterisc Chai ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBoxTea;
        private TextBox textBoxCoffee;
        private TextBox textBoxSandwich;
        private TextBox textBoxBurger;
        private Button clearTeabutton;
        private Button clearCoffeebutton;
        private Button clearSandwichbutton;
        private Button clearBurgerbutton;
        private TextBox textBoxPrint;
        private Button Totalbutton;
        private TextBox textBoxtotal;
        private Label label1;
        private Button Printbutton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}