// Decompiled with JetBrains decompiler
// Type: License.Form1
// Assembly: License, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6FD56FB-B46D-4870-BCF7-E8D83C1735D0
// Assembly location: License.dll inside C:\Users\sansk\Desktop\(Trial) Crypto Whale$\(Trial) Crypto Whale$.exe)


using Microsoft.VisualBasic.CompilerServices;
using System;
using License;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace License
{
  [DesignerGenerated]
  public partial class Form1 : Form
  {
    private IContainer components=new Container();
    private Form2 _form2Instance;
    private bool isGenerating;
    private int maxLines = 11;
    private List<string> wordList=new List<string>()  ;
    private int lineCount;
    private int lineCountListBox2;
    private List<Tuple<string, string>> linkValueSymbolList=new List<Tuple<string, string>>();
    private List<Tuple<string, string>> secondTupleList=new List<Tuple<string, string>>();

    public Form1()
    {
      InitializeComponent();
      this.Load += new EventHandler(this.Form1_Load);
    }

    [STAThread] // Ensure the application runs in a single-threaded apartment
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Start the application with Form1
        }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        ((IDisposable) this.components).Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
      this.Button3 = new Button();
      this.Label4 = new Label();
      this.ListBox1 = new ListBox();
      this.Label3 = new Label();
      this.Button2 = new Button();
      this.Button1 = new Button();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.CheckBox6 = new CheckBox();
      this.CheckBox5 = new CheckBox();
      this.CheckBox4 = new CheckBox();
      this.CheckBox3 = new CheckBox();
      this.CheckBox2 = new CheckBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.CheckBox1 = new CheckBox();
      this.ListBox2 = new ListBox();
      this.Button4 = new Button();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.Button3.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button3.Location = new Point(204, 6);
      this.Button3.Margin = new Padding(4, 3, 4, 3);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(52, 23);
      this.Button3.TabIndex = 48;
      this.Button3.Text = "Info";
      this.Button3.UseVisualStyleBackColor = true;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label4.ForeColor = Color.Green;
      this.Label4.Location = new Point(68, 240);
      this.Label4.Margin = new Padding(4, 0, 4, 0);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(19, 21);
      this.Label4.TabIndex = 47;
      this.Label4.Text = "0";
      this.ListBox1.BackColor = SystemColors.InfoText;
      this.ListBox1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point);
      this.ListBox1.ForeColor = SystemColors.Window;
      this.ListBox1.FormattingEnabled = true;
      this.ListBox1.ItemHeight = 17;
      this.ListBox1.Location = new Point(13, 32);
      this.ListBox1.Margin = new Padding(4, 3, 4, 3);
      this.ListBox1.Name = "ListBox1";
      this.ListBox1.Size = new Size(243, 191);
      this.ListBox1.TabIndex = 45;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label3.ForeColor = Color.Black;
      this.Label3.Location = new Point(89, 8);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(19, 21);
      this.Label3.TabIndex = 44;
      this.Label3.Text = "0";
      this.Button2.BackColor = Color.FromArgb(192, 0, 0);
      this.Button2.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button2.ForeColor = Color.Black;
      this.Button2.Location = new Point(13, 592);
      this.Button2.Margin = new Padding(4, 3, 4, 3);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(243, 37);
      this.Button2.TabIndex = 43;
      this.Button2.Text = "STOP";
      this.Button2.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.Green;
      this.Button1.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(13, 548);
      this.Button1.Margin = new Padding(4, 3, 4, 3);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(243, 37);
      this.Button1.TabIndex = 42;
      this.Button1.Text = "START";
      this.Button1.UseVisualStyleBackColor = false;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label2.ForeColor = Color.Black;
      this.Label2.Location = new Point(13, 8);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(83, 21);
      this.Label2.TabIndex = 41;
      this.Label2.Text = "Checked: ";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label1.ForeColor = Color.Green;
      this.Label1.Location = new Point(13, 240);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(66, 21);
      this.Label1.TabIndex = 40;
      this.Label1.Text = "Found: ";
      this.CheckBox6.AutoSize = true;
      this.CheckBox6.Location = new Point(220, 511);
      this.CheckBox6.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox6.Name = "CheckBox6";
      this.CheckBox6.Size = new Size(15, 14);
      this.CheckBox6.TabIndex = 39;
      this.CheckBox6.UseVisualStyleBackColor = true;
      this.CheckBox5.AutoSize = true;
      this.CheckBox5.Location = new Point((int) sbyte.MaxValue, 509);
      this.CheckBox5.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox5.Name = "CheckBox5";
      this.CheckBox5.Size = new Size(15, 14);
      this.CheckBox5.TabIndex = 38;
      this.CheckBox5.UseVisualStyleBackColor = true;
      this.CheckBox4.AutoSize = true;
      this.CheckBox4.Location = new Point(34, 511);
      this.CheckBox4.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox4.Name = "CheckBox4";
      this.CheckBox4.Size = new Size(15, 14);
      this.CheckBox4.TabIndex = 37;
      this.CheckBox4.UseVisualStyleBackColor = true;
      this.CheckBox3.AutoSize = true;
      this.CheckBox3.Location = new Point(220, 427);
      this.CheckBox3.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox3.Name = "CheckBox3";
      this.CheckBox3.Size = new Size(15, 14);
      this.CheckBox3.TabIndex = 36;
      this.CheckBox3.UseVisualStyleBackColor = true;
      this.CheckBox2.AutoSize = true;
      this.CheckBox2.Location = new Point((int) sbyte.MaxValue, 428);
      this.CheckBox2.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox2.Name = "CheckBox2";
      this.CheckBox2.Size = new Size(15, 14);
      this.CheckBox2.TabIndex = 35;
      this.CheckBox2.UseVisualStyleBackColor = true;
      this.PictureBox6.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox6.Image");
      this.PictureBox6.Location = new Point(199, 448);
      this.PictureBox6.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox6.Name = "PictureBox6";
      this.PictureBox6.Size = new Size(57, 57);
      this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox6.TabIndex = 34;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox5.Image");
      this.PictureBox5.Location = new Point(106, 448);
      this.PictureBox5.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox5.Name = "PictureBox5";
      this.PictureBox5.Size = new Size(57, 57);
      this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox5.TabIndex = 33;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox4.Image");
      this.PictureBox4.Location = new Point(13, 448);
      this.PictureBox4.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox4.Name = "PictureBox4";
      this.PictureBox4.Size = new Size(57, 57);
      this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox4.TabIndex = 32;
      this.PictureBox4.TabStop = false;
      this.PictureBox3.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox3.Image");
      this.PictureBox3.Location = new Point(199, 366);
      this.PictureBox3.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox3.Name = "PictureBox3";
      this.PictureBox3.Size = new Size(57, 57);
      this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox3.TabIndex = 31;
      this.PictureBox3.TabStop = false;
      this.PictureBox2.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox2.Image");
      this.PictureBox2.Location = new Point(106, 366);
      this.PictureBox2.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox2.Name = "PictureBox2";
      this.PictureBox2.Size = new Size(57, 57);
      this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox2.TabIndex = 30;
      this.PictureBox2.TabStop = false;
      this.PictureBox1.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(13, 366);
      this.PictureBox1.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(57, 57);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 29;
      this.PictureBox1.TabStop = false;
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Location = new Point(34, 427);
      this.CheckBox1.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(15, 14);
      this.CheckBox1.TabIndex = 28;
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.ListBox2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point);
      this.ListBox2.ForeColor = Color.FromArgb(0, 192, 0);
      this.ListBox2.FormattingEnabled = true;
      this.ListBox2.ItemHeight = 17;
      this.ListBox2.Location = new Point(13, 264);
      this.ListBox2.Margin = new Padding(4, 3, 4, 3);
      this.ListBox2.Name = "ListBox2";
      this.ListBox2.Size = new Size(243, 89);
      this.ListBox2.TabIndex = 46;
      this.Button4.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button4.Location = new Point(204, 238);
      this.Button4.Margin = new Padding(4, 3, 4, 3);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(52, 23);
      this.Button4.TabIndex = 49;
      this.Button4.Text = "Export";
      this.Button4.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(271, 644);
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.ListBox1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.CheckBox6);
      this.Controls.Add((Control) this.CheckBox5);
      this.Controls.Add((Control) this.CheckBox4);
      this.Controls.Add((Control) this.CheckBox3);
      this.Controls.Add((Control) this.CheckBox2);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.ListBox2);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) ((ResourceManager) componentResourceManager).GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "BrutoForce Seed";
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

        private Button _Button3;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Label _Label4;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Label Label4
        {
          get => this._Label4;
          [MethodImpl(MethodImplOptions.Synchronized)] set
          {
            EventHandler eventHandler = new EventHandler(this.Label4_TextChanged);
            Label label4_1 = this._Label4;
            if (label4_1 != null)
              label4_1.TextChanged -= eventHandler;
            this._Label4 = value;
            Label label4_2 = this._Label4;
            if (label4_2 == null)
              return;
            label4_2.TextChanged += eventHandler;
          }
        }

    [field: AccessedThroughProperty("ListBox1")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    private Button _Button2;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Button _Button1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox6")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox5")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox4")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox3")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox2")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox6")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox5")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox4")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox3")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox2")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox1")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private ListBox _ListBox2;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual ListBox ListBox2
    {
      get => this._ListBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ListBox2_MouseDown);
        ListBox listBox2_1 = this._ListBox2;
        if (listBox2_1 != null)
          listBox2_1.MouseDown -= mouseEventHandler;
        this._ListBox2 = value;
        ListBox listBox2_2 = this._ListBox2;
        if (listBox2_2 == null)
          return;
        listBox2_2.MouseDown += mouseEventHandler;
      }
    }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Button _Button4;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual Button Button4
    {
      get => this._Button4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        Button button4_1 = this._Button4;
        if (button4_1 != null)
          button4_1.Click -= eventHandler;
        this._Button4 = value;
        Button button4_2 = this._Button4;
        if (button4_2 == null)
          return;
        button4_2.Click += eventHandler;
      }
    }

        [field: AccessedThroughProperty("BackgroundWorker")]
        protected BackgroundWorker _backgroundWorker;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal virtual BackgroundWorker BackgroundWorker
    {
      get => this._backgroundWorker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker_DoWork);
        BackgroundWorker backgroundWorker1 = this._backgroundWorker;
        if (backgroundWorker1 != null)
          backgroundWorker1.DoWork -= workEventHandler;
        this._backgroundWorker = value;
        BackgroundWorker backgroundWorker2 = this._backgroundWorker;
        if (backgroundWorker2 == null)
          return;
        backgroundWorker2.DoWork += workEventHandler;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (this.BackgroundWorker.IsBusy)
        return;
      if (!this.IsAnyCheckBoxChecked())
      {
        int num1 = (int) MessageBox.Show("Please choose at least one blockchain before starting!", "Blockchain Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (this.CheckInternetConnection())
      {
        this.isGenerating = true;
        this.Button1.ForeColor = Color.Black;
        this.Button2.ForeColor = Color.White;
        this.Button1.Enabled = false;
        this.BackgroundWorker.RunWorkerAsync();
      }
      else
      {
        int num2 = (int) MessageBox.Show("No internet connection. Please check your network connection!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private bool CheckInternetConnection()
    {
      bool flag;
      try
      {
        flag = new System.Net.NetworkInformation.Ping().Send("8.8.8.8").Status == System.Net.NetworkInformation.IPStatus.Success;
      }
      catch (PingException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool IsAnyCheckBoxChecked()
    {
      int num = 1;
      bool flag;
      while (!((CheckBox) this.Controls["CheckBox" + Conversions.ToString(num)]).Checked)
      {
        checked { ++num; }
        if (num > 6)
        {
          flag = false;
          goto label_5;
        }
      }
      flag = true;
label_5:
      return flag;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      License.Form1 form1 = this;
      object obj = sender;
      EventArgs e1 = e;
      if (this.InvokeRequired)
      {
        this.Invoke((Action) ([SpecialName] () => form1.Button2_Click(RuntimeHelpers.GetObjectValue(obj), e1)));
      }
      else
      {
        this.isGenerating = false;
        this.Button2.ForeColor = Color.Black;
        this.Invoke((Action) ([SpecialName] () => this.Button1.ForeColor = Color.White));
        this.Invoke((Action) ([SpecialName] () => this.Button1.Enabled = true));
      }
    }

    private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      while (this.isGenerating)
      {
        if (this.IsAnyCheckBoxChecked())
        {
          if (this.IsAnyCheckboxEnabled())
          {
            this.GenerateLinesForListBox1();
            this.lineCountListBox2 = 0;
          }
          else
          {
            this.GenerateLinesForListBox1();
            this.GenerateLinesForListBox2();
          }
          if (this.IsAnyCheckboxEnabled())
            Thread.Sleep(35);
          else
            Thread.Sleep(70);
        }
        else
        {
          this.isGenerating = false;
          this.Button2_Click((object) null, (EventArgs) null);
          break;
        }
      }
    }

    private void GenerateLinesForListBox1()
    {
      // ISSUE: variable of a compiler-generated type
      var closure1100 = new { 
          VBMe = this,
          LocalRandomLine = this.GenerateRandomLine(6, "Wallet check:", this.wordList)
      };
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.ListBox1.Invoke((Action)(() =>
      {
          this.ListBox1.Items.Add(closure1100.LocalRandomLine);
      }));
      while (this.ListBox1.Items.Count > this.maxLines)
        this.ListBox1.Invoke((Action) ([SpecialName] () => this.ListBox1.Items.RemoveAt(checked (this.ListBox1.Items.Count - 1))));
      if (this.IsAnyCheckboxEnabled())
      {
        // ISSUE: variable of a reference type
        this.lineCount = checked(this.lineCount + 67);
      }
      else
      {
        // ISSUE: variable of a reference type
        this.lineCount = checked(this.lineCount + 13);
      }
      this.Label3.Invoke((Action) ([SpecialName] () => this.Label3.Text = this.lineCount.ToString()));
    }

    private void GenerateLinesForListBox2()
    {
      if (this.lineCount >= 124832 && this.ListBox2.Items.Count == 0)
      {
        License.Form1 form1 = this;
        Tuple<string, string> linkValueSymbol = this.linkValueSymbolList[this.GetRandomIndex(this.linkValueSymbolList.Count)];
        string randomWords = this.GenerateRandomWords();
        string str = string.Format("{0} | {1}", (object) linkValueSymbol.Item2, (object) randomWords);
        this.ListBox2.Invoke((Action) ([SpecialName] () => form1.ListBox2.Items.Add((object) Tuple.Create<string, string>(str, linkValueSymbol.Item1))));
        // ISSUE: variable of a reference type

        int num = checked(this.lineCountListBox2 + 1);
        this.lineCountListBox2 = num;

      }
      if (this.lineCount >= 301482 && this.ListBox2.Items.Count == 1)
      {
        License.Form1 form1 = this;
        Tuple<string, string> secondTuple = this.secondTupleList[this.GetRandomIndex(this.secondTupleList.Count)];
        string randomWords = this.GenerateRandomWords();
        string str = string.Format("{0} | {1}", (object) secondTuple.Item2, (object) randomWords);
        this.ListBox2.Invoke((Action) ([SpecialName] () => form1.ListBox2.Items.Add((object) Tuple.Create<string, string>(str, secondTuple.Item1))));
        // ISSUE: variable of a reference type

        int num = checked(this.lineCountListBox2 + 1);
        this.lineCountListBox2 = num;

      }
      this.Label4.Invoke((Action) ([SpecialName] () => this.Label4.Text = this.lineCountListBox2.ToString()));
    }

    private bool IsAnyCheckboxEnabled()
    {
      int num = 1;
      bool flag;
      while (!this.Controls["CheckBox" + Conversions.ToString(num)].Enabled)
      {
        checked { ++num; }
        if (num > 6)
        {
          flag = false;
          goto label_5;
        }
      }
      flag = true;
label_5:
      return flag;
    }

    private int GetRandomIndex(int maxIndex) => new Random().Next(0, maxIndex);

    private string GenerateRandomWords()
    {
      Random random = new Random();
      // ISSUE: reference to a compiler-generated method
      return string.Format("{0}", string.Join(" ", this.wordList.OrderBy(_ => random.Next()).Take(8)));
    }

    private string GenerateRandomLine(int count, string prefix, List<string> words)
    {
      Random random = new Random();
      // ISSUE: reference to a compiler-generated method
      IEnumerable<string> strings = words.OrderBy(_ => random.Next()).Take(count);
      return string.Format("{0} {1}", (object) prefix, (object) string.Join(" ", strings));
    }

    private void ListBox2_MouseDown(object sender, MouseEventArgs e)
    {
      int index = this.ListBox2.IndexFromPoint(e.Location);
      if (index == -1)
        return;
      Tuple<string, string> tuple = (Tuple<string, string>) this.ListBox2.Items[index];
      string str1 = tuple.Item1;
      string str2 = tuple.Item2;
      try
      {
        Process.Start(new ProcessStartInfo(str2)
        {
          UseShellExecute = true
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(string.Format("An error occurred while trying to open the link: {0}", (object) ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      Form2 form2Instance = this.GetForm2Instance();
      form2Instance.TextLabel2Text = "You need a license key in order to get the\r\nSeed Phrases of the wallet(s) you found!";
      form2Instance.Show();
      form2Instance.Activate();
    }

    private void Label4_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.Label4.Text.Trim(), "", false) != 0 && this.ListBox2.Items.Count > 0)
        this.Button4.Visible = true;
      else
        this.Button4.Visible = false;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      Form2 form2Instance = this.GetForm2Instance();
      form2Instance.TextLabel2Text = "You need a license key in order to get the\r\nSeed Phrases of the wallet(s) you found!";
      form2Instance.Show();
      form2Instance.BringToFront();
    }

    private Form2 GetForm2Instance()
    {
        if (this._form2Instance == null || this._form2Instance.IsDisposed)
        {
            this._form2Instance = new Form2();
            this._form2Instance.ValidKeyEntered += new EventHandler<License.Form2.ValidKeyEventArgs>(this.Form2_ValidKeyEntered);
        }
        return this._form2Instance;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.DisableAllCheckboxes();
      this.CheckAndEnableCheckboxes();
      this.CheckBox1.Checked = true;
      this.CheckBox3.Checked = true;
    }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
    {
      Control childAtPoint = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
      if (!(childAtPoint is CheckBox))
        return;
      this.HandleCheckboxClick((CheckBox) childAtPoint);
    }

    private void HandleCheckboxClick(CheckBox clickedCheckbox)
    {
      if (clickedCheckbox.Enabled)
        return;
      this.GetForm2Instance().Show();
      this.GetForm2Instance().BringToFront();
    }

    private void DisableAllCheckboxes()
    {
      try
      {
        foreach (Control control in Enumerable.OfType<CheckBox>((IEnumerable) this.Controls))
          control.Enabled = false;
      }
      finally
      {

      }
    }

    public void SaveCheckboxKeys()
    {
      string str = Path.Combine(Application.StartupPath, "License.lic");
      IEnumerable<CheckBox> checkBoxes1 = Enumerable.OfType<CheckBox>((IEnumerable) this.Controls);
      IEnumerable<CheckBox> checkBoxes2 = checkBoxes1.Where(checkbox => checkbox.Checked);
      List<string> list = checkBoxes2.Select(checkbox => checkbox.Text).ToList();
      File.WriteAllLines(str, (IEnumerable<string>) list);
    }

    private void EnableCheckboxByKey(string enteredKey)
    {
      string Left = enteredKey;
      if (Operators.CompareString(Left, "KeyBTC|UAvtJEYkQnT47JBDfCpDmpq2Rx5z7VAF", false) != 0)
      {
        if (Operators.CompareString(Left, "KeyETH|cjpWPFhVEfDWcMZf5DLm6WDZstEsg2Fn", false) != 0)
        {
          if (Operators.CompareString(Left, "KeyLTC|fBTGtan8qnDn9RSwyrLEAjrgjJuabhjP", false) != 0)
          {
            if (Operators.CompareString(Left, "KeyBNB|HUqDfUzzsshjHTm8PF8qhxMDwZBy4Hn6", false) != 0)
            {
              if (Operators.CompareString(Left, "KeySOL|2FcARFVyDWWVUtcxFGDw9AKGMRsr25S4", false) != 0)
              {
                if (Operators.CompareString(Left, "KeyUSDT|DkJcSdffnH26RA6YpQAEhxSjAkds8RYG", false) != 0)
                  return;
                this.CheckBox6.Enabled = true;
              }
              else
                this.CheckBox5.Enabled = true;
            }
            else
              this.CheckBox4.Enabled = true;
          }
          else
            this.CheckBox3.Enabled = true;
        }
        else
          this.CheckBox2.Enabled = true;
      }
      else
        this.CheckBox1.Enabled = true;
    }

    private void Form2_ValidKeyEntered(object sender, Form2.ValidKeyEventArgs e)
    {
      this.EnableCheckboxByKey(e.EnteredKey);
    }

    private void CheckAndEnableCheckboxes()
    {
      string str1 = Path.Combine(Application.StartupPath, "License.lic");
      if (!File.Exists(str1))
        return;
      string str2 = File.ReadAllText(str1);
      if (str2.Contains("KeyBTC|UAvtJEYkQnT47JBDfCpDmpq2Rx5z7VAF"))
        this.CheckBox1.Enabled = true;
      if (str2.Contains("KeyETH|cjpWPFhVEfDWcMZf5DLm6WDZstEsg2Fn"))
        this.CheckBox2.Enabled = true;
      if (str2.Contains("KeyLTC|fBTGtan8qnDn9RSwyrLEAjrgjJuabhjP"))
        this.CheckBox3.Enabled = true;
      if (str2.Contains("KeyBNB|HUqDfUzzsshjHTm8PF8qhxMDwZBy4Hn6"))
        this.CheckBox4.Enabled = true;
      if (str2.Contains("KeySOL|2FcARFVyDWWVUtcxFGDw9AKGMRsr25S4"))
        this.CheckBox5.Enabled = true;
      if (!str2.Contains("KeyUSDT|DkJcSdffnH26RA6YpQAEhxSjAkds8RYG"))
        return;
      this.CheckBox6.Enabled = true;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      Form2 form2 = Enumerable.FirstOrDefault<Form2>(Enumerable.OfType<Form2>((IEnumerable) Application.OpenForms));
      if (form2 != null)
        form2.BringToFront();
      else
        new Form2().Show();
    }
  }
}
