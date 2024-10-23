/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 22/10/2024
 * Time: 03:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace w
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
		string [] s = new string[5];
		string d;
		void Button2Click(object sender, EventArgs e)
		{
			int a=comboBox1.SelectedIndex;
			s[a]=string.Empty;
			s[a]=textBox1.Text;
			textBox1.Text=string.Empty;
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			string a,b,c;
			a=s[0];
			b=s[1];
			c=s[2];
			d+=b[0];
			d+=b[1];
			d+=c[0];
			d+=a[0];
			DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
			int  numeroDelaño = fechaSeleccionada.Year;
			string f=numeroDelaño.ToString();
			d+=f[2];
			d+=f[3];
			int numeroDelmes = fechaSeleccionada.Month;
			if(numeroDelmes<10){
				d+='0';
			}
			f=numeroDelmes.ToString();
			d+=f;
			int numeroDeldia = fechaSeleccionada.Day;
			if(numeroDeldia<10){
				d+='0';
			}
			f=numeroDeldia.ToString();
			d+=f;
			MessageBox.Show(d);
			d=string.Empty;
		}
	}
}
