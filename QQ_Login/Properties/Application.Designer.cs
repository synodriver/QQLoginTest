﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为,并且如果
//     重新生成代码,这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------



//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace QQ_Login
{
	namespace My
	{

		//注意:此文件是自动生成的；请勿直接进行修改。若要更改,
		// 或者如果您在此文件中遇到生成错误,请转至项目设计器
		// (转至“项目属性”或在解决方案资源管理器中双击“我的项目”节点),
		// 然后在“应用程序”选项卡中进行更改。
		//
		internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{

			[System.Diagnostics.DebuggerStepThroughAttribute()]
			public MyApplication() : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
			{
				this.IsSingleInstance = false;
				this.EnableVisualStyles = true;
				this.SaveMySettingsOnExit = true;
				this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
			}

			[System.Diagnostics.DebuggerStepThroughAttribute()]
			protected override void OnCreateMainForm()
			{
				this.MainForm = global::QQ_Login.Form1.DefaultInstance;
			}

			private static MyApplication MyApp;
			internal static MyApplication Application
			{
				get
				{
					return MyApp;
				}
			}

			[STAThread]
			static void Main(string[] args)
			{
				MyApp = new MyApplication();
				MyApp.Run(args);
			}

		}
	}

}