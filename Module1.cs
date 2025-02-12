// Decompiled with JetBrains decompiler
// Type: License.Module1
// Assembly: License, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6FD56FB-B46D-4870-BCF7-E8D83C1735D0
// Assembly location: License.dll inside C:\Users\sansk\Desktop\(Trial) Crypto Whale$\(Trial) Crypto Whale$.exe)

using License.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace License
{
  [StandardModule]
  internal sealed class Module1
  {
    public static void SubscribeToApplicationExit()
    {
      Application.ApplicationExit += new EventHandler(Module1.ApplicationExitHandler);
    }

    public static void ApplicationExitHandler(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.SaveCheckboxKeys();
    }
  }
}
