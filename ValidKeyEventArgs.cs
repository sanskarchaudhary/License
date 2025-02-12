// Decompiled with JetBrains decompiler
// Type: License.ValidKeyEventArgs
// Assembly: License, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6FD56FB-B46D-4870-BCF7-E8D83C1735D0
// Assembly location: License.dll inside C:\Users\sansk\Desktop\(Trial) Crypto Whale$\(Trial) Crypto Whale$.exe)

using System;

namespace License
{
  public class ValidKeyEventArgs : EventArgs
  {
    public string EnteredKey { get; set; }

    public ValidKeyEventArgs(string key) => this.EnteredKey = key;
  }
}
