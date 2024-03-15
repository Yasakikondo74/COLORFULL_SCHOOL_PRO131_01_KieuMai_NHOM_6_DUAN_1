using System.Windows.Forms;

namespace Ứng_Dụng_Quản_Lý_Bán_Sơn_COLORFULL
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            button11 = new Button();
            button10 = new Button();
            numericUpDown1 = new NumericUpDown();
            label20 = new Label();
            pictureBox2 = new PictureBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
            dataGridView2 = new DataGridView();
            tabPage4 = new TabPage();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            tabPage9 = new TabPage();
            tabPage10 = new TabPage();
            textBox11 = new TextBox();
            comboBox2 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.CausesValidation = false;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Controls.Add(tabPage10);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(50, 100);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 506);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseClick += tabControl1_MouseClick;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Location = new Point(104, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(892, 498);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "USER";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(104, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(892, 498);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Main Page";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSteelBlue;
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(numericUpDown1);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(104, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(892, 498);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cart";
            // 
            // button11
            // 
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(199, 347);
            button11.Name = "button11";
            button11.Size = new Size(36, 36);
            button11.TabIndex = 113;
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(157, 347);
            button10.Name = "button10";
            button10.Size = new Size(36, 36);
            button10.TabIndex = 112;
            button10.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 365);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 111;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(6, 345);
            label20.Name = "label20";
            label20.Size = new Size(80, 17);
            label20.TabIndex = 110;
            label20.Text = "How many?";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 335);
            pictureBox2.TabIndex = 108;
            pictureBox2.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(111, 450);
            label16.Name = "label16";
            label16.Size = new Size(44, 17);
            label16.TabIndex = 107;
            label16.Text = "0.00 $";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(9, 450);
            label17.Name = "label17";
            label17.Size = new Size(96, 17);
            label17.TabIndex = 106;
            label17.Text = "Estimate Cost:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(72, 413);
            label18.Name = "label18";
            label18.Size = new Size(108, 17);
            label18.TabIndex = 105;
            label18.Text = "100.000.000.00 $";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(15, 413);
            label19.Name = "label19";
            label19.Size = new Size(51, 17);
            label19.TabIndex = 104;
            label19.Text = "Wallet:";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(319, 447);
            button8.Name = "button8";
            button8.Size = new Size(72, 46);
            button8.TabIndex = 103;
            button8.Text = "↓";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(319, 394);
            button9.Name = "button9";
            button9.Size = new Size(72, 47);
            button9.TabIndex = 102;
            button9.Text = "↑";
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(319, 347);
            button7.Name = "button7";
            button7.Size = new Size(72, 36);
            button7.TabIndex = 71;
            button7.Text = "Order";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(241, 347);
            button6.Name = "button6";
            button6.Size = new Size(72, 36);
            button6.TabIndex = 70;
            button6.Text = "Remove";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(397, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(489, 486);
            dataGridView2.TabIndex = 69;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightSteelBlue;
            tabPage4.Controls.Add(comboBox2);
            tabPage4.Controls.Add(textBox11);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(textBox8);
            tabPage4.Controls.Add(textBox9);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(textBox7);
            tabPage4.Controls.Add(textBox6);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Controls.Add(textBox3);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(104, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(892, 498);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Browse";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(167, 455);
            label15.Name = "label15";
            label15.Size = new Size(44, 17);
            label15.TabIndex = 101;
            label15.Text = "0.00 $";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(100, 446);
            label14.Name = "label14";
            label14.Size = new Size(61, 34);
            label14.TabIndex = 100;
            label14.Text = "Estimate\r\nvalue:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(163, 409);
            label13.Name = "label13";
            label13.Size = new Size(108, 17);
            label13.TabIndex = 99;
            label13.Text = "100.000.000.00 $";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(106, 409);
            label12.Name = "label12";
            label12.Size = new Size(51, 17);
            label12.TabIndex = 98;
            label12.Text = "Wallet:";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(324, 446);
            button5.Name = "button5";
            button5.Size = new Size(67, 46);
            button5.TabIndex = 97;
            button5.Text = "↓";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(324, 396);
            button4.Name = "button4";
            button4.Size = new Size(67, 44);
            button4.TabIndex = 96;
            button4.Text = "↑";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 446);
            button3.Name = "button3";
            button3.Size = new Size(72, 46);
            button3.TabIndex = 95;
            button3.Text = "Add to cart";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(6, 396);
            button2.Name = "button2";
            button2.Size = new Size(71, 44);
            button2.TabIndex = 94;
            button2.Text = "Buy";
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(195, 365);
            label11.Name = "label11";
            label11.Size = new Size(41, 17);
            label11.TabIndex = 92;
            label11.Text = "Type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 365);
            label10.Name = "label10";
            label10.Size = new Size(48, 17);
            label10.TabIndex = 90;
            label10.Text = "Brand:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(226, 333);
            label8.Name = "label8";
            label8.Size = new Size(21, 17);
            label8.TabIndex = 89;
            label8.Text = "to";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 333);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 88;
            label9.Text = "Size filter:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(253, 332);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "999kg";
            textBox8.Size = new Size(138, 23);
            textBox8.TabIndex = 87;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(84, 332);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "0kg";
            textBox9.Size = new Size(137, 23);
            textBox9.TabIndex = 86;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(226, 304);
            label7.Name = "label7";
            label7.Size = new Size(21, 17);
            label7.TabIndex = 85;
            label7.Text = "to";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 304);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 84;
            label6.Text = "RGB filter:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(253, 303);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "#FFFFFF";
            textBox7.Size = new Size(138, 23);
            textBox7.TabIndex = 83;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(84, 303);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "#000000";
            textBox6.Size = new Size(137, 23);
            textBox6.TabIndex = 82;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(84, 269);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Color Name";
            textBox5.Size = new Size(307, 23);
            textBox5.TabIndex = 81;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 262);
            button1.Name = "button1";
            button1.Size = new Size(72, 35);
            button1.TabIndex = 80;
            button1.Text = "Search";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(262, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 23);
            textBox4.TabIndex = 79;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 364);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 78;
            comboBox1.Text = "Select Brand Name";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(262, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 23);
            textBox3.TabIndex = 77;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(263, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 76;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(263, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(263, 162);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 74;
            label5.Text = "Brand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(263, 216);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 73;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 109);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 72;
            label3.Text = "Type of Paint:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 57);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 71;
            label2.Text = "RGB:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 6);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 70;
            label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(489, 486);
            dataGridView1.TabIndex = 68;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(104, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(892, 498);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Receipt";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(104, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(892, 498);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Voucher";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(104, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(892, 498);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Employee";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(104, 4);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(892, 498);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Customer";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(104, 4);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(892, 498);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "Statistic";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Location = new Point(104, 4);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(892, 498);
            tabPage10.TabIndex = 9;
            tabPage10.Text = "Exit";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(263, 182);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(129, 23);
            textBox11.TabIndex = 102;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(242, 364);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 23);
            comboBox2.TabIndex = 103;
            comboBox2.Text = "Select Type of Paint";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1017, 523);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label7;
        private Label label6;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button1;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button7;
        private Button button6;
        private PictureBox pictureBox2;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button8;
        private Button button9;
        private NumericUpDown numericUpDown1;
        private Label label20;
        private Button button10;
        private Button button11;
        private TextBox textBox11;
        private ComboBox comboBox2;
    }
}
