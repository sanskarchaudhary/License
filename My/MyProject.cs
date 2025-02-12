// Decompiled with JetBrains decompiler
// Type: License.My.MyProject
// Assembly: License, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6FD56FB-B46D-4870-BCF7-E8D83C1735D0
// Assembly location: License.dll inside C:\Users\sansk\Desktop\(Trial) Crypto Whale$\(Trial) Crypto Whale$.exe)

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace License.My
{
  [StandardModule]
  [HideModuleName]
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [EditorBrowsable]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;
      [EditorBrowsable]
      public Form1 m_Form1;
      [EditorBrowsable]
      public Form2 m_Form2;

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        T instance;
        if ((object) Instance == null || Instance.IsDisposed)
        {
          if (MyProject.MyForms.m_FormBeingCreated != null)
          {
            if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
              throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
          }
          else
            MyProject.MyForms.m_FormBeingCreated = new Hashtable();
          MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
          TargetInvocationException invocationException;
          try
          {
            instance = new T();
          }
          catch (TargetInvocationException ex) when (
          {
            // ISSUE: unable to correctly present filter
            ProjectData.SetProjectError((Exception) ex);
            invocationException = ex;
            if (((Exception) invocationException).InnerException != null)
            {
              SuccessfulFiltering;
            }
            else
              throw;
          }
          )
          {
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ((Exception) invocationException).InnerException.Message), ((Exception) invocationException).InnerException);
          }
          finally
          {
            MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
          }
        }
        else
          instance = Instance;
        return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable]
      public MyForms()
      {
      }

      [EditorBrowsable]
      public virtual bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable]
      public virtual int GetHashCode() => base.GetHashCode();

      [EditorBrowsable]
      internal System.Type GetType() => typeof (MyProject.MyForms);

      [EditorBrowsable]
      public virtual string ToString() => base.ToString();

      public Form1 Form1
      {
        get
        {
          this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
          return this.m_Form1;
        }
        set
        {
          if (value == this.m_Form1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form1>(ref this.m_Form1);
        }
      }

      public Form2 Form2
      {
        get
        {
          this.m_Form2 = MyProject.MyForms.Create__Instance__<Form2>(this.m_Form2);
          return this.m_Form2;
        }
        set
        {
          if (value == this.m_Form2)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form2>(ref this.m_Form2);
        }
      }
    }

    [EditorBrowsable]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
      [EditorBrowsable]
      [DebuggerHidden]
      public virtual bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable]
      [DebuggerHidden]
      public virtual int GetHashCode() => base.GetHashCode();

      [EditorBrowsable]
      [DebuggerHidden]
      internal System.Type GetType() => typeof (MyProject.MyWebServices);

      [EditorBrowsable]
      [DebuggerHidden]
      public virtual string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        return (object) instance != null ? instance : new T();
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [DebuggerHidden]
      [EditorBrowsable]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
