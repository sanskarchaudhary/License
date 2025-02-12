// Decompiled with JetBrains decompiler
// Type: License.Form2
// Assembly: License, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6FD56FB-B46D-4870-BCF7-E8D83C1735D0
// Assembly location: License.dll inside C:\Users\sansk\Desktop\(Trial) Crypto Whale$\(Trial) Crypto Whale$.exe)

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace License
{
  [DesignerGenerated]
  public class Form2 : Form
  {
    private IContainer components;
    private DateTime? firstKeyEntryDate;
    private const int validityPeriodInDays = 30;

    public Form2()
    {
      this.Load += new EventHandler(this.Form2_Load);
      this.InitializeComponent();
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.TextBox1 = new TextBox();
      this.Button1 = new Button();
      this.LinkLabel1 = new LinkLabel();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox8 = new PictureBox();
      this.PictureBox9 = new PictureBox();
      this.PictureBox10 = new PictureBox();
      this.PictureBox11 = new PictureBox();
      this.PictureBox12 = new PictureBox();
      this.ToolTip1 = new ToolTip(this.components);
      this.ToolTip2 = new ToolTip(this.components);
      this.ToolTip3 = new ToolTip(this.components);
      this.ToolTip4 = new ToolTip(this.components);
      this.ToolTip5 = new ToolTip(this.components);
      this.ToolTip6 = new ToolTip(this.components);
      this.Label3 = new Label();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      ((ISupportInitialize) this.PictureBox9).BeginInit();
      ((ISupportInitialize) this.PictureBox10).BeginInit();
      ((ISupportInitialize) this.PictureBox11).BeginInit();
      ((ISupportInitialize) this.PictureBox12).BeginInit();
      this.SuspendLayout();
      this.TextBox1.Location = new Point(12, 62);
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.Size = new Size(382, 23);
      this.TextBox1.TabIndex = 0;
      this.Button1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button1.Location = new Point(12, 91);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(382, 36);
      this.Button1.TabIndex = 1;
      this.Button1.Text = "Validate License Key";
      this.Button1.UseVisualStyleBackColor = true;
      this.LinkLabel1.AutoSize = true;
      this.LinkLabel1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point);
      this.LinkLabel1.Location = new Point(12, 488);
      this.LinkLabel1.Name = "LinkLabel1";
      this.LinkLabel1.Size = new Size(65, 17);
      this.LinkLabel1.TabIndex = 2;
      this.LinkLabel1.TabStop = true;
      this.LinkLabel1.Text = "Telegram";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label1.Location = new Point(12, 193);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(48, 17);
      this.Label1.TabIndex = 3;
      this.Label1.Text = "Label1";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label2.ForeColor = Color.DarkRed;
      this.Label2.Location = new Point(12, 9);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(0, 25);
      this.Label2.TabIndex = 4;
      this.PictureBox6.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox6.Image");
      this.PictureBox6.Location = new Point(337, 133);
      this.PictureBox6.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox6.Name = "PictureBox6";
      this.PictureBox6.Size = new Size(57, 57);
      this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox6.TabIndex = 40;
      this.PictureBox6.TabStop = false;
      this.ToolTip6.SetToolTip((Control) this.PictureBox6, "Active");
      this.PictureBox5.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox5.Image");
      this.PictureBox5.Location = new Point(272, 133);
      this.PictureBox5.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox5.Name = "PictureBox5";
      this.PictureBox5.Size = new Size(57, 57);
      this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox5.TabIndex = 39;
      this.PictureBox5.TabStop = false;
      this.ToolTip5.SetToolTip((Control) this.PictureBox5, "Active");
      this.PictureBox4.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox4.Image");
      this.PictureBox4.Location = new Point(207, 133);
      this.PictureBox4.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox4.Name = "PictureBox4";
      this.PictureBox4.Size = new Size(57, 57);
      this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox4.TabIndex = 38;
      this.PictureBox4.TabStop = false;
      this.ToolTip4.SetToolTip((Control) this.PictureBox4, "Active");
      this.PictureBox3.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox3.Image");
      this.PictureBox3.Location = new Point(142, 133);
      this.PictureBox3.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox3.Name = "PictureBox3";
      this.PictureBox3.Size = new Size(57, 57);
      this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox3.TabIndex = 37;
      this.PictureBox3.TabStop = false;
      this.ToolTip3.SetToolTip((Control) this.PictureBox3, "Active");
      this.PictureBox2.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox2.Image");
      this.PictureBox2.Location = new Point(77, 133);
      this.PictureBox2.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox2.Name = "PictureBox2";
      this.PictureBox2.Size = new Size(57, 57);
      this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox2.TabIndex = 36;
      this.PictureBox2.TabStop = false;
      this.ToolTip2.SetToolTip((Control) this.PictureBox2, "Active");
      this.PictureBox1.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(12, 133);
      this.PictureBox1.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(57, 57);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 35;
      this.PictureBox1.TabStop = false;
      this.ToolTip1.SetToolTip((Control) this.PictureBox1, "Active");
      this.PictureBox7.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox7.Image");
      this.PictureBox7.Location = new Point(337, 133);
      this.PictureBox7.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox7.Name = "PictureBox7";
      this.PictureBox7.Size = new Size(57, 57);
      this.PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox7.TabIndex = 46;
      this.PictureBox7.TabStop = false;
      this.ToolTip6.SetToolTip((Control) this.PictureBox7, "Inactive");
      this.PictureBox8.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox8.Image");
      this.PictureBox8.Location = new Point(272, 133);
      this.PictureBox8.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox8.Name = "PictureBox8";
      this.PictureBox8.Size = new Size(57, 57);
      this.PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox8.TabIndex = 45;
      this.PictureBox8.TabStop = false;
      this.ToolTip5.SetToolTip((Control) this.PictureBox8, "Inactive");
      this.PictureBox9.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox9.Image");
      this.PictureBox9.Location = new Point(207, 133);
      this.PictureBox9.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox9.Name = "PictureBox9";
      this.PictureBox9.Size = new Size(57, 57);
      this.PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox9.TabIndex = 44;
      this.PictureBox9.TabStop = false;
      this.ToolTip4.SetToolTip((Control) this.PictureBox9, "Inactive");
      this.PictureBox10.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox10.Image");
      this.PictureBox10.Location = new Point(142, 133);
      this.PictureBox10.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox10.Name = "PictureBox10";
      this.PictureBox10.Size = new Size(57, 57);
      this.PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox10.TabIndex = 43;
      this.PictureBox10.TabStop = false;
      this.ToolTip3.SetToolTip((Control) this.PictureBox10, "Active/Slow");
      this.PictureBox11.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox11.Image");
      this.PictureBox11.Location = new Point(77, 133);
      this.PictureBox11.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox11.Name = "PictureBox11";
      this.PictureBox11.Size = new Size(57, 57);
      this.PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox11.TabIndex = 42;
      this.PictureBox11.TabStop = false;
      this.ToolTip2.SetToolTip((Control) this.PictureBox11, "Inactive");
      this.PictureBox12.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox12.Image");
      this.PictureBox12.Location = new Point(12, 133);
      this.PictureBox12.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox12.Name = "PictureBox12";
      this.PictureBox12.Size = new Size(57, 57);
      this.PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox12.TabIndex = 41;
      this.PictureBox12.TabStop = false;
      this.ToolTip1.SetToolTip((Control) this.PictureBox12, "Active/Slow");
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(352, 488);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(43, 15);
      this.Label3.TabIndex = 48;
      this.Label3.Text = "v12.6.1";
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(407, 514);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.LinkLabel1);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.PictureBox11);
      this.Controls.Add((Control) this.PictureBox9);
      this.Controls.Add((Control) this.PictureBox8);
      this.Controls.Add((Control) this.PictureBox7);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.PictureBox10);
      this.Controls.Add((Control) this.PictureBox12);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) ((ResourceManager) componentResourceManager).GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form2);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "License";
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      ((ISupportInitialize) this.PictureBox9).EndInit();
      ((ISupportInitialize) this.PictureBox10).EndInit();
      ((ISupportInitialize) this.PictureBox11).EndInit();
      ((ISupportInitialize) this.PictureBox12).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox TextBox1
    {
      get => this._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
        TextBox textBox1_1 = this._TextBox1;
        if (textBox1_1 != null)
          textBox1_1.TextChanged -= eventHandler;
        this._TextBox1 = value;
        TextBox textBox1_2 = this._TextBox1;
        if (textBox1_2 == null)
          return;
        textBox1_2.TextChanged += eventHandler;
      }
    }

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

    internal virtual LinkLabel LinkLabel1
    {
      get => this._LinkLabel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
        LinkLabel linkLabel1_1 = this._LinkLabel1;
        if (linkLabel1_1 != null)
          linkLabel1_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel1 = value;
        LinkLabel linkLabel1_2 = this._LinkLabel1;
        if (linkLabel1_2 == null)
          return;
        linkLabel1_2.LinkClicked += clickedEventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox6")]
    internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox5")]
    internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox4")]
    internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox3")]
    internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox2")]
    internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox7")]
    internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox8")]
    internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox9")]
    internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox10")]
    internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox11")]
    internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox12")]
    internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip3")]
    internal virtual ToolTip ToolTip3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip2")]
    internal virtual ToolTip ToolTip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip1")]
    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip4")]
    internal virtual ToolTip ToolTip4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip6")]
    internal virtual ToolTip ToolTip6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip5")]
    internal virtual ToolTip ToolTip5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public event EventHandler<Form2.ValidKeyEventArgs> ValidKeyEntered;

    private void Form2_Load(object sender, EventArgs e)
    {
      string str = Path.Combine(Application.StartupPath, "License.lic");
      if (File.Exists(str))
      {
        List<string> list = Enumerable.ToList<string>((IEnumerable<string>) File.ReadAllLines(str));
        if (Enumerable.Any<string>((IEnumerable<string>) list))
        {
          this.firstKeyEntryDate = new DateTime?(File.GetCreationTime(str));
          this.PictureBox1.Visible = list.Contains("KeyBTC|UAvtJEYkQnT47JBDfCpDmpq2Rx5z7VAF");
          this.PictureBox2.Visible = list.Contains("KeyETH|cjpWPFhVEfDWcMZf5DLm6WDZstEsg2Fn");
          this.PictureBox3.Visible = list.Contains("KeyLTC|fBTGtan8qnDn9RSwyrLEAjrgjJuabhjP");
          this.PictureBox4.Visible = list.Contains("KeyBNB|HUqDfUzzsshjHTm8PF8qhxMDwZBy4Hn6");
          this.PictureBox5.Visible = list.Contains("KeySOL|2FcARFVyDWWVUtcxFGDw9AKGMRsr25S4");
          this.PictureBox6.Visible = list.Contains("KeyUSDT|DkJcSdffnH26RA6YpQAEhxSjAkds8RYG");
          this.Label1.Text = "This is a licensed version of the software. \r\n\r\nYou have unlock over 120 million checks \r\nper 24h for the above listed blockchains.\r\n\r\nTo unlock more blockchains, please contact us on \r\nTelegram at the link below!";
          this.DisplayRemainingDaysMessage();
        }
        else
        {
          this.SetDefaultLabelTextAndHidePictureBoxes();
          File.Delete(str);
        }
      }
      else
        this.SetDefaultLabelTextAndHidePictureBoxes();
      this.LinkLabel1.Text = "Telegram";
      this.LinkLabel1.Links.Add(checked (this.LinkLabel1.Text.Length - 8), 8, (object) "https://t.me/ownercryptowhales");
    }

    private DateTime? GetKeyEntryDate(string key)
    {
      string[] strArray = key.Split('|', (StringSplitOptions) 0);
      DateTime? keyEntryDate;
      if (strArray.Length == 2)
      {
        string str = strArray[1];
        DateTime minValue = DateTime.MinValue;
        ref DateTime local = ref minValue;
        if (DateTime.TryParse(str, ref local))
        {
          keyEntryDate = new DateTime?(DateTime.Parse(strArray[1]));
          goto label_4;
        }
      }
      keyEntryDate = new DateTime?();
label_4:
      return keyEntryDate;
    }

    private void UpdateLicenseFile(List<string> keys)
    {
      string str = Path.Combine(Application.StartupPath, "License.lic");
      try
      {
        File.WriteAllLines(str, (IEnumerable<string>) keys);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private bool IsKeyExpired(string key)
    {
      DateTime? keyEntryDate = this.GetKeyEntryDate(key);
      return keyEntryDate.HasValue && DateTime.op_Subtraction(DateTime.Now, keyEntryDate.Value).TotalDays > 30.0;
    }

    private void DisplayRemainingDaysMessage()
    {
      if (!this.firstKeyEntryDate.HasValue)
        return;
      string firstKey = this.GetFirstKey();
      if (!string.IsNullOrEmpty(firstKey) && !this.IsKeyExpired(firstKey))
      {
        int num = checked ((int) Math.Round(DateTime.op_Subtraction(this.firstKeyEntryDate.Value.AddDays(30.0), DateTime.Now).TotalDays));
        if (num > 0)
        {
          this.Label2.Text = string.Format("    Your license will expiere in {0} day(s).", (object) num);
        }
        else
        {
          string str = Path.Combine(Application.StartupPath, "License.lic");
          if (!File.Exists(str))
            return;
          File.Delete(str);
        }
      }
      else
      {
        if (this.RemoveAndSaveExpiredKeys(Enumerable.ToList<string>((IEnumerable<string>) File.ReadAllLines(Path.Combine(Application.StartupPath, "License.lic")))).Count != 0)
          return;
        string str = Path.Combine(Application.StartupPath, "License.lic");
        if (!File.Exists(str))
          return;
        File.Delete(str);
      }
    }

    private string GetFirstKey()
    {
      string str = Path.Combine(Application.StartupPath, "License.lic");
      string firstKey;
      if (File.Exists(str))
      {
        List<string> list = Enumerable.ToList<string>((IEnumerable<string>) File.ReadAllLines(str));
        if (Enumerable.Any<string>((IEnumerable<string>) list))
        {
          firstKey = Enumerable.First<string>((IEnumerable<string>) list);
          goto label_4;
        }
      }
      firstKey = string.Empty;
label_4:
      return firstKey;
    }

    private List<string> RemoveAndSaveExpiredKeys(List<string> keys) => keys;

    private void SetDefaultLabelTextAndHidePictureBoxes()
    {
      this.Label1.Text = "This is a limited version of the software.\r\n\r\nThe limited version:\r\nOver 12 million checks per 24h.\r\nLimited and locked to 2 blockchains only.\r\n\r\nThe licensed version:\r\nOver 120 million checks per 24h.\r\nCheck up to 6 blockchains in the same time.\r\n\r\nWhat the licensed version does in 1 day,\r\nthe limited version will do in 10 days!\r\n\r\nTo get the licensed version, please contact us on \r\nTelegram at the link below.";
      this.PictureBox1.Visible = false;
      this.PictureBox2.Visible = false;
      this.PictureBox3.Visible = false;
      this.PictureBox4.Visible = false;
      this.PictureBox5.Visible = false;
      this.PictureBox6.Visible = false;
    }

    public void SetPictureBoxProperties(string text, string enteredKey)
    {
      this.Label2.Text = text;
      this.PictureBox1.Visible = Operators.CompareString(enteredKey, "KeyBTC|UAvtJEYkQnT47JBDfCpDmpq2Rx5z7VAF", false) == 0;
      this.PictureBox2.Visible = Operators.CompareString(enteredKey, "KeyETH|cjpWPFhVEfDWcMZf5DLm6WDZstEsg2Fn", false) == 0;
      this.PictureBox3.Visible = Operators.CompareString(enteredKey, "KeyLTC|fBTGtan8qnDn9RSwyrLEAjrgjJuabhjP", false) == 0;
      this.PictureBox4.Visible = Operators.CompareString(enteredKey, "KeyBNB|HUqDfUzzsshjHTm8PF8qhxMDwZBy4Hn6", false) == 0;
      this.PictureBox5.Visible = Operators.CompareString(enteredKey, "KeySOL|2FcARFVyDWWVUtcxFGDw9AKGMRsr25S4", false) == 0;
      this.PictureBox6.Visible = Operators.CompareString(enteredKey, "KeyUSDT|DkJcSdffnH26RA6YpQAEhxSjAkds8RYG", false) == 0;
    }

    private void SetPictureBoxStateAndTooltip(PictureBox pictureBox, ToolTip toolTip, string state)
    {
      pictureBox.Tag = (object) state;
      toolTip.SetToolTip((Control) pictureBox, state);
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string linkData = e.Link.LinkData as string;
      if (string.IsNullOrEmpty(linkData))
        return;
      try
      {
        Process.Start(new ProcessStartInfo(linkData)
        {
          UseShellExecute = true
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(string.Format("An error occurred: {0}", (object) ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }

    public string TextLabel2Text
    {
      set => this.Label2.Text = value;
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      string str = this.TextBox1.Text.Trim();
      if (this.IsValidKey(str))
      {
        if (!this.KeyExistsInLicenseFile(str))
        {
          // ISSUE: reference to a compiler-generated field
          EventHandler<Form2.ValidKeyEventArgs> validKeyEnteredEvent = this.ValidKeyEnteredEvent;
          if (validKeyEnteredEvent != null)
            validKeyEnteredEvent((object) this, new Form2.ValidKeyEventArgs(str));
          this.SaveTextToFile(str);
          int num = (int) MessageBox.Show("Valid license key. The blockchain has been enabled.", "Valid license key", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          Application.Restart();
          this.Close();
        }
        else
        {
          int num1 = (int) MessageBox.Show("License key is already in use. Please enter a different blockchain license key.", "License key in use", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("Invalid license key. Please enter a valid license key.", "Invalid license key", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void SaveTextToFile(string textToSave)
    {
      string str = Path.Combine(Application.StartupPath, "License.lic");
      try
      {
        List<string> stringList = File.Exists(str) ? Enumerable.ToList<string>((IEnumerable<string>) File.ReadAllLines(str)) : new List<string>();
        if (!this.IsValidKey(textToSave) || stringList.Contains(textToSave))
          return;
        File.AppendAllText(str, textToSave + Environment.NewLine);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private bool KeyExistsInLicenseFile(string enteredKey)
    {
      string str = Path.Combine(Application.StartupPath, "License.lic");
      return File.Exists(str) && Enumerable.ToList<string>((IEnumerable<string>) File.ReadAllLines(str)).Contains(enteredKey);
    }

    private bool IsValidKey(string enteredKey)
    {
      bool flag;
      if (!string.IsNullOrEmpty(enteredKey) && enteredKey.StartsWith("Key") && enteredKey.Length >= 10)
      {
        if (!this.IsKeyExpired(enteredKey))
        {
          flag = true;
          goto label_5;
        }
        else
        {
          int num = (int) MessageBox.Show("Entered key is expired. Please enter a valid, non-expired license key.", "Expired license key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      flag = false;
label_5:
      return flag;
    }

    public class ValidKeyEventArgs : EventArgs
    {
      public string EnteredKey { get; set; }

      public ValidKeyEventArgs(string key) => this.EnteredKey = key;
    }
  }
}
