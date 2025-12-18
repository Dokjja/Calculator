namespace Calculator_App;

partial class CalculatorForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        btnAdd = new Button();
        btnEqual = new Button();
        btnColumn = new Button();
        btnZero = new Button();
        btnSub = new Button();
        btnThree = new Button();
        btnTwo = new Button();
        btnOne = new Button();
        btnMultiply = new Button();
        btnSix = new Button();
        btnFive = new Button();
        btnFour = new Button();
        btnDevide = new Button();
        btnNine = new Button();
        btnEight = new Button();
        btnSeven = new Button();
        btnDelete = new Button();
        btnPercent = new Button();
        btnPower = new Button();
        btnClearAll = new Button();
        richTextBox1 = new RichTextBox();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0620022F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.9379959F));
        tableLayoutPanel1.Size = new Size(441, 453);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.Controls.Add(btnAdd, 3, 4);
        tableLayoutPanel2.Controls.Add(btnEqual, 2, 4);
        tableLayoutPanel2.Controls.Add(btnColumn, 1, 4);
        tableLayoutPanel2.Controls.Add(btnZero, 0, 4);
        tableLayoutPanel2.Controls.Add(btnSub, 3, 3);
        tableLayoutPanel2.Controls.Add(btnThree, 2, 3);
        tableLayoutPanel2.Controls.Add(btnTwo, 1, 3);
        tableLayoutPanel2.Controls.Add(btnOne, 0, 3);
        tableLayoutPanel2.Controls.Add(btnMultiply, 3, 2);
        tableLayoutPanel2.Controls.Add(btnSix, 2, 2);
        tableLayoutPanel2.Controls.Add(btnFive, 1, 2);
        tableLayoutPanel2.Controls.Add(btnFour, 0, 2);
        tableLayoutPanel2.Controls.Add(btnDevide, 3, 1);
        tableLayoutPanel2.Controls.Add(btnNine, 2, 1);
        tableLayoutPanel2.Controls.Add(btnEight, 1, 1);
        tableLayoutPanel2.Controls.Add(btnSeven, 0, 1);
        tableLayoutPanel2.Controls.Add(btnDelete, 3, 0);
        tableLayoutPanel2.Controls.Add(btnPercent, 2, 0);
        tableLayoutPanel2.Controls.Add(btnPower, 1, 0);
        tableLayoutPanel2.Controls.Add(btnClearAll, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 93);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 5;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.Size = new Size(435, 357);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // btnAdd
        // 
        btnAdd.Dock = DockStyle.Fill;
        btnAdd.Location = new Point(327, 287);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(105, 67);
        btnAdd.TabIndex = 19;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // btnEqual
        // 
        btnEqual.BackColor = Color.DarkSlateBlue;
        btnEqual.Dock = DockStyle.Fill;
        btnEqual.ForeColor = Color.Plum;
        btnEqual.Location = new Point(219, 287);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new Size(102, 67);
        btnEqual.TabIndex = 18;
        btnEqual.Text = "=";
        btnEqual.UseVisualStyleBackColor = false;
        // 
        // btnColumn
        // 
        btnColumn.BackColor = Color.DarkSlateBlue;
        btnColumn.Dock = DockStyle.Fill;
        btnColumn.ForeColor = Color.Plum;
        btnColumn.Location = new Point(111, 287);
        btnColumn.Name = "btnColumn";
        btnColumn.Size = new Size(102, 67);
        btnColumn.TabIndex = 17;
        btnColumn.Text = ".";
        btnColumn.UseVisualStyleBackColor = false;
        // 
        // btnZero
        // 
        btnZero.Dock = DockStyle.Fill;
        btnZero.Location = new Point(3, 287);
        btnZero.Name = "btnZero";
        btnZero.Size = new Size(102, 67);
        btnZero.TabIndex = 16;
        btnZero.Text = "0";
        btnZero.UseVisualStyleBackColor = true;
        // 
        // btnSub
        // 
        btnSub.Dock = DockStyle.Fill;
        btnSub.Location = new Point(327, 216);
        btnSub.Name = "btnSub";
        btnSub.Size = new Size(105, 65);
        btnSub.TabIndex = 15;
        btnSub.Text = "-";
        btnSub.UseVisualStyleBackColor = true;
        // 
        // btnThree
        // 
        btnThree.Dock = DockStyle.Fill;
        btnThree.Location = new Point(219, 216);
        btnThree.Name = "btnThree";
        btnThree.Size = new Size(102, 65);
        btnThree.TabIndex = 14;
        btnThree.Text = "3";
        btnThree.UseVisualStyleBackColor = true;
        // 
        // btnTwo
        // 
        btnTwo.Dock = DockStyle.Fill;
        btnTwo.Location = new Point(111, 216);
        btnTwo.Name = "btnTwo";
        btnTwo.Size = new Size(102, 65);
        btnTwo.TabIndex = 13;
        btnTwo.Text = "2";
        btnTwo.UseVisualStyleBackColor = true;
        // 
        // btnOne
        // 
        btnOne.Dock = DockStyle.Fill;
        btnOne.Location = new Point(3, 216);
        btnOne.Name = "btnOne";
        btnOne.Size = new Size(102, 65);
        btnOne.TabIndex = 12;
        btnOne.Text = "1";
        btnOne.UseVisualStyleBackColor = true;
        // 
        // btnMultiply
        // 
        btnMultiply.Dock = DockStyle.Fill;
        btnMultiply.Location = new Point(327, 145);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new Size(105, 65);
        btnMultiply.TabIndex = 11;
        btnMultiply.Text = "*";
        btnMultiply.UseVisualStyleBackColor = true;
        // 
        // btnSix
        // 
        btnSix.Dock = DockStyle.Fill;
        btnSix.Location = new Point(219, 145);
        btnSix.Name = "btnSix";
        btnSix.Size = new Size(102, 65);
        btnSix.TabIndex = 10;
        btnSix.Text = "6";
        btnSix.UseVisualStyleBackColor = true;
        // 
        // btnFive
        // 
        btnFive.Dock = DockStyle.Fill;
        btnFive.Location = new Point(111, 145);
        btnFive.Name = "btnFive";
        btnFive.Size = new Size(102, 65);
        btnFive.TabIndex = 9;
        btnFive.Text = "5";
        btnFive.UseVisualStyleBackColor = true;
        // 
        // btnFour
        // 
        btnFour.Dock = DockStyle.Fill;
        btnFour.Location = new Point(3, 145);
        btnFour.Name = "btnFour";
        btnFour.Size = new Size(102, 65);
        btnFour.TabIndex = 8;
        btnFour.Text = "4";
        btnFour.UseVisualStyleBackColor = true;
        // 
        // btnDevide
        // 
        btnDevide.Dock = DockStyle.Fill;
        btnDevide.Location = new Point(327, 74);
        btnDevide.Name = "btnDevide";
        btnDevide.Size = new Size(105, 65);
        btnDevide.TabIndex = 7;
        btnDevide.Text = "/";
        btnDevide.UseVisualStyleBackColor = true;
        // 
        // btnNine
        // 
        btnNine.Dock = DockStyle.Fill;
        btnNine.Location = new Point(219, 74);
        btnNine.Name = "btnNine";
        btnNine.Size = new Size(102, 65);
        btnNine.TabIndex = 6;
        btnNine.Text = "9";
        btnNine.UseVisualStyleBackColor = true;
        // 
        // btnEight
        // 
        btnEight.Dock = DockStyle.Fill;
        btnEight.Location = new Point(111, 74);
        btnEight.Name = "btnEight";
        btnEight.Size = new Size(102, 65);
        btnEight.TabIndex = 5;
        btnEight.Text = "8";
        btnEight.UseVisualStyleBackColor = true;
        // 
        // btnSeven
        // 
        btnSeven.Dock = DockStyle.Fill;
        btnSeven.Location = new Point(3, 74);
        btnSeven.Name = "btnSeven";
        btnSeven.Size = new Size(102, 65);
        btnSeven.TabIndex = 4;
        btnSeven.Text = "7";
        btnSeven.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.DarkSlateBlue;
        btnDelete.Dock = DockStyle.Fill;
        btnDelete.ForeColor = Color.Plum;
        btnDelete.Location = new Point(327, 3);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(105, 65);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "←";
        btnDelete.UseVisualStyleBackColor = false;
        // 
        // btnPercent
        // 
        btnPercent.Dock = DockStyle.Fill;
        btnPercent.Location = new Point(219, 3);
        btnPercent.Name = "btnPercent";
        btnPercent.Size = new Size(102, 65);
        btnPercent.TabIndex = 2;
        btnPercent.Text = "%";
        btnPercent.UseVisualStyleBackColor = true;
        // 
        // btnPower
        // 
        btnPower.Dock = DockStyle.Fill;
        btnPower.Location = new Point(111, 3);
        btnPower.Name = "btnPower";
        btnPower.Size = new Size(102, 65);
        btnPower.TabIndex = 1;
        btnPower.Text = "x^2";
        btnPower.UseVisualStyleBackColor = true;
        // 
        // btnClearAll
        // 
        btnClearAll.BackColor = Color.DarkSlateBlue;
        btnClearAll.Dock = DockStyle.Fill;
        btnClearAll.ForeColor = Color.Plum;
        btnClearAll.Location = new Point(3, 3);
        btnClearAll.Name = "btnClearAll";
        btnClearAll.Size = new Size(102, 65);
        btnClearAll.TabIndex = 0;
        btnClearAll.Text = "C";
        btnClearAll.UseVisualStyleBackColor = false;
        // 
        // richTextBox1
        // 
        richTextBox1.Dock = DockStyle.Fill;
        richTextBox1.Font = new Font("Segoe UI", 13F);
        richTextBox1.Location = new Point(3, 3);
        richTextBox1.Multiline = false;
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.Size = new Size(435, 84);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // CalculatorForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(441, 453);
        Controls.Add(tableLayoutPanel1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(550, 600);
        MinimumSize = new Size(440, 500);
        Name = "CalculatorForm";
        Text = "Calculator";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button btnAdd;
    private Button btnEqual;
    private Button btnColumn;
    private Button btnZero;
    private Button btnSub;
    private Button btnThree;
    private Button btnTwo;
    private Button btnOne;
    private Button btnMultiply;
    private Button btnSix;
    private Button btnFive;
    private Button btnFour;
    private Button btnDevide;
    private Button btnNine;
    private Button btnEight;
    private Button btnSeven;
    private Button btnDelete;
    private Button btnPercent;
    private Button btnPower;
    private Button btnClearAll;
    private RichTextBox richTextBox1;
}