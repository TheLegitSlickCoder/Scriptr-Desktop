using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Scriptr
{
  public class Form1 : Form
  {
    private FileManager fm = new FileManager();
    private IContainer components = (IContainer) null;
    private Label title;
    private Label label1;
    private RichTextBox codeInput;
    private Button button1;
    private Button button2;
    private Label lengthLabel;
    private Label label2;
    private Button button3;
    private Button button4;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.codeInput.AcceptsTab = true;
    }

    private string getCode()
    {
      return this.codeInput.Text;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.fm.saveJSFile(this.getCode());
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.codeInput.Text = "";
    }

    private void codeInput_TextChanged(object sender, EventArgs e)
    {
      this.lengthLabel.Text = "Length: " + this.getCode().Length.ToString();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.title.ForeColor = Color.Black;
      this.label1.ForeColor = Color.Black;
      this.label2.ForeColor = Color.Black;
      this.lengthLabel.ForeColor = Color.Black;
      this.BackColor = Color.White;
      this.button1.ForeColor = Color.Black;
      this.button2.ForeColor = Color.Black;
      this.button3.ForeColor = Color.Black;
      this.button4.ForeColor = Color.Black;
      this.button1.BackColor = Color.White;
      this.button2.BackColor = Color.White;
      this.button3.BackColor = Color.White;
      this.button4.BackColor = Color.White;
      this.codeInput.ForeColor = Color.Black;
      this.codeInput.BackColor = Color.White;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.title.ForeColor = Color.White;
      this.label1.ForeColor = Color.White;
      this.label2.ForeColor = Color.White;
      this.lengthLabel.ForeColor = Color.White;
      this.BackColor = Color.FromArgb(50, 50, 50);
      this.button1.ForeColor = Color.White;
      this.button2.ForeColor = Color.White;
      this.button3.ForeColor = Color.White;
      this.button4.ForeColor = Color.White;
      this.button1.BackColor = Color.FromArgb(50, 50, 50);
      this.button2.BackColor = Color.FromArgb(50, 50, 50);
      this.button3.BackColor = Color.FromArgb(50, 50, 50);
      this.button4.BackColor = Color.FromArgb(50, 50, 50);
      this.codeInput.ForeColor = Color.White;
      this.codeInput.BackColor = Color.FromArgb(50, 50, 50);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.title = new Label();
      this.label1 = new Label();
      this.codeInput = new RichTextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.lengthLabel = new Label();
      this.label2 = new Label();
      this.button3 = new Button();
      this.button4 = new Button();
      this.SuspendLayout();
      this.title.AutoSize = true;
      this.title.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.title.ForeColor = Color.White;
      this.title.Location = new Point(12, 9);
      this.title.Name = "title";
      this.title.Size = new Size(74, 25);
      this.title.TabIndex = 0;
      this.title.Text = "Scriptr";
      this.label1.AutoSize = true;
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(14, 55);
      this.label1.Name = "label1";
      this.label1.Size = new Size(86, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Javascript Code:";
      this.codeInput.BackColor = Color.FromArgb(50, 50, 50);
      this.codeInput.Font = new Font("Courier New", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.codeInput.ForeColor = Color.White;
      this.codeInput.Location = new Point(17, 71);
      this.codeInput.Name = "codeInput";
      this.codeInput.Size = new Size(452, 333);
      this.codeInput.TabIndex = 2;
      this.codeInput.Text = "";
      this.codeInput.TextChanged += new EventHandler(this.codeInput_TextChanged);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(17, 410);
      this.button1.Name = "button1";
      this.button1.Size = new Size(98, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Execute Code";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.ForeColor = Color.White;
      this.button2.Location = new Point(121, 410);
      this.button2.Name = "button2";
      this.button2.Size = new Size(99, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Clear Console";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.lengthLabel.AutoSize = true;
      this.lengthLabel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lengthLabel.ForeColor = Color.White;
      this.lengthLabel.Location = new Point(226, 413);
      this.lengthLabel.Name = "lengthLabel";
      this.lengthLabel.Size = new Size(48, 15);
      this.lengthLabel.TabIndex = 5;
      this.lengthLabel.Text = "Length:";
      this.label2.AutoSize = true;
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(475, 55);
      this.label2.Name = "label2";
      this.label2.Size = new Size(86, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Theme Changer:";
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(478, 71);
      this.button3.Name = "button3";
      this.button3.Size = new Size(106, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "Light Theme";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = Color.White;
      this.button4.Location = new Point(478, 100);
      this.button4.Name = "button4";
      this.button4.Size = new Size(106, 23);
      this.button4.TabIndex = 8;
      this.button4.Text = "Dark Theme";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(50, 50, 50);
      this.ClientSize = new Size(602, 442);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.lengthLabel);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.codeInput);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.title);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form1";
      this.Opacity = 0.9;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Scriptr";
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
