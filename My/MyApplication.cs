// Decompiled with JetBrains decompiler
// Type: License.My.MyApplication
// Assembly: License, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6FD56FB-B46D-4870-BCF7-E8D83C1735D0
// Assembly location: License.dll inside C:\Users\sansk\Desktop\(Trial) Crypto Whale$\(Trial) Crypto Whale$.exe)

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows;

namespace License.My
{
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  [EditorBrowsable]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [STAThread]
    [DebuggerHidden]
    [EditorBrowsable]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    internal static void Main(string[] Args)
    {
      Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      this.IsSingleInstance = true;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
      this.HighDpiMode = HighDpiMode.DpiUnaware;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.Form1;

    [DebuggerStepThrough]
    protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
    {
      this.MinimumSplashScreenDisplayTime = 0;
      return base.OnInitialize(commandLineArgs);
    }
  }

  public partial class App : Application
  {
    [STAThread]
    public static void Main()
    {
      var app = new App();
      app.InitializeComponent();
      app.Run(new Form1());
    }
  }
}
