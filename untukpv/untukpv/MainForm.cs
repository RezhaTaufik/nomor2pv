/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 6/9/2022
 * Time: 12:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace untukpv
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("SI");
			comboBox1.Items.Add("PV");
			comboBox1.Items.Add("KDJK");			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string jk="";
			if(radioButton1.Checked)
			{
				jk =radioButton1.Text;
			}
			if(radioButton2.Checked)
			{
				jk =radioButton2.Text;
			}
			MessageBox.Show(jk);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string halo = "";
			
			if (checkBox1.CheckState == CheckState.Checked)
			{
				halo +="A";
			}
			if (checkBox2.CheckState == CheckState.Checked)
			{
				halo +="B";
			}
			if (checkBox3.CheckState == CheckState.Checked)
			{
				halo +="C";
			}
			MessageBox.Show(halo);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
				string hai = "";
			
			if (checkBox4.CheckState == CheckState.Checked)
			{
				hai +="Pagi";
			}
			if (checkBox2.CheckState == CheckState.Checked)
			{
				hai +="Siang";
			}
			
			MessageBox.Show(hai);		
		}
	}
}
