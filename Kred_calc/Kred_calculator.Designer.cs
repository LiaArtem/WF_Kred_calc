using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace Kred_calc
{
	public partial class Kred_calculator : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kred_calculator));
            this.Button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ЭкспортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox_rasrochka = new System.Windows.Forms.GroupBox();
            this.kurs_start = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.kurs_year_3 = new System.Windows.Forms.TextBox();
            this.year_3 = new System.Windows.Forms.Label();
            this.kurs_year_2 = new System.Windows.Forms.TextBox();
            this.year_2 = new System.Windows.Forms.Label();
            this.kurs_year_1 = new System.Windows.Forms.TextBox();
            this.year_1 = new System.Windows.Forms.Label();
            this.kurs_year_0 = new System.Windows.Forms.TextBox();
            this.year_0 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.sum_plat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.srok_cred_new = new System.Windows.Forms.TextBox();
            this.srok_kred_year_new = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.proc_stavka = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.srok_kred = new System.Windows.Forms.TextBox();
            this.srok_kred_year = new System.Windows.Forms.TextBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.priv_proc_stavka = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.priv_srok_kred = new System.Windows.Forms.TextBox();
            this.priv_srok_kred_year = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.curr_code = new System.Windows.Forms.ComboBox();
            this.kurs = new System.Windows.Forms.TextBox();
            this.summa = new System.Windows.Forms.TextBox();
            this.date_cred = new System.Windows.Forms.DateTimePicker();
            this.Label38 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.type_r_stavka = new System.Windows.Forms.ComboBox();
            this.Label36 = new System.Windows.Forms.Label();
            this.type_proc = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.sum_kred = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.proc_perv_vznos = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.perv_vznos = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.summa_ekv = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.pereplata = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comiss_bank = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.comiss_strah1 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.comiss_strah2 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.comiss_strah3 = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.sum_dop_plat = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.strax_itog = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.notar_itog = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.rieltor_itog = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.bank_itog = new System.Windows.Forms.TextBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label45 = new System.Windows.Forms.Label();
            this.monthly_comiss_bank = new System.Windows.Forms.TextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Label15 = new System.Windows.Forms.Label();
            this.comiss_notar4 = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.comiss_notar5 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.comiss_notar3 = new System.Windows.Forms.TextBox();
            this.comiss_notar1 = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.comiss_notar2 = new System.Windows.Forms.TextBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.Label18 = new System.Windows.Forms.Label();
            this.comiss_rieltor2 = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.comiss_rieltor3 = new System.Windows.Forms.TextBox();
            this.comiss_rieltor1 = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label23 = new System.Windows.Forms.Label();
            this.on_dop_rasx = new System.Windows.Forms.CheckBox();
            this.dop_rasx_month_or_all = new System.Windows.Forms.CheckBox();
            this.type_rasch = new System.Windows.Forms.ComboBox();
            this.Label39 = new System.Windows.Forms.Label();
            this.kurs_year_4 = new System.Windows.Forms.TextBox();
            this.year_4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupbox_rasrochka.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(628, 603);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(300, 28);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Расчитать";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.DataGridView1.Location = new System.Drawing.Point(365, 27);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(573, 538);
            this.DataGridView1.TabIndex = 2;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЭкспортВExcelToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // ЭкспортВExcelToolStripMenuItem
            // 
            this.ЭкспортВExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ЭкспортВExcelToolStripMenuItem.Image")));
            this.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem";
            this.ЭкспортВExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в CSV";
            this.ЭкспортВExcelToolStripMenuItem.Click += new System.EventHandler(this.ЭкспортВCSVToolStripMenuItem_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.groupbox_rasrochka);
            this.GroupBox1.Controls.Add(this.groupBox6);
            this.GroupBox1.Controls.Add(this.groupBox5);
            this.GroupBox1.Controls.Add(this.groupBox4);
            this.GroupBox1.Controls.Add(this.curr_code);
            this.GroupBox1.Controls.Add(this.kurs);
            this.GroupBox1.Controls.Add(this.summa);
            this.GroupBox1.Controls.Add(this.date_cred);
            this.GroupBox1.Controls.Add(this.Label38);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.type_r_stavka);
            this.GroupBox1.Controls.Add(this.Label36);
            this.GroupBox1.Controls.Add(this.type_proc);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.sum_kred);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.proc_perv_vznos);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.perv_vznos);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.summa_ekv);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 1);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(347, 407);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Условия кредитования";
            // 
            // groupbox_rasrochka
            // 
            this.groupbox_rasrochka.Controls.Add(this.kurs_year_4);
            this.groupbox_rasrochka.Controls.Add(this.year_4);
            this.groupbox_rasrochka.Controls.Add(this.kurs_start);
            this.groupbox_rasrochka.Controls.Add(this.label34);
            this.groupbox_rasrochka.Controls.Add(this.kurs_year_3);
            this.groupbox_rasrochka.Controls.Add(this.year_3);
            this.groupbox_rasrochka.Controls.Add(this.kurs_year_2);
            this.groupbox_rasrochka.Controls.Add(this.year_2);
            this.groupbox_rasrochka.Controls.Add(this.kurs_year_1);
            this.groupbox_rasrochka.Controls.Add(this.year_1);
            this.groupbox_rasrochka.Controls.Add(this.kurs_year_0);
            this.groupbox_rasrochka.Controls.Add(this.year_0);
            this.groupbox_rasrochka.Location = new System.Drawing.Point(9, 336);
            this.groupbox_rasrochka.Name = "groupbox_rasrochka";
            this.groupbox_rasrochka.Size = new System.Drawing.Size(330, 65);
            this.groupbox_rasrochka.TabIndex = 43;
            this.groupbox_rasrochka.TabStop = false;
            this.groupbox_rasrochka.Text = "Раcсрочка изменение курса USD";
            this.groupbox_rasrochka.Visible = false;
            // 
            // kurs_start
            // 
            this.kurs_start.Location = new System.Drawing.Point(65, 13);
            this.kurs_start.Name = "kurs_start";
            this.kurs_start.Size = new System.Drawing.Size(44, 20);
            this.kurs_start.TabIndex = 51;
            this.kurs_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 13);
            this.label34.TabIndex = 52;
            this.label34.Text = "Нач. курс";
            // 
            // kurs_year_3
            // 
            this.kurs_year_3.Location = new System.Drawing.Point(201, 39);
            this.kurs_year_3.Name = "kurs_year_3";
            this.kurs_year_3.Size = new System.Drawing.Size(44, 20);
            this.kurs_year_3.TabIndex = 49;
            this.kurs_year_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // year_3
            // 
            this.year_3.AutoSize = true;
            this.year_3.Location = new System.Drawing.Point(169, 42);
            this.year_3.Name = "year_3";
            this.year_3.Size = new System.Drawing.Size(31, 13);
            this.year_3.TabIndex = 50;
            this.year_3.Text = "2021";
            // 
            // kurs_year_2
            // 
            this.kurs_year_2.Location = new System.Drawing.Point(125, 39);
            this.kurs_year_2.Name = "kurs_year_2";
            this.kurs_year_2.Size = new System.Drawing.Size(44, 20);
            this.kurs_year_2.TabIndex = 47;
            this.kurs_year_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // year_2
            // 
            this.year_2.AutoSize = true;
            this.year_2.Location = new System.Drawing.Point(92, 42);
            this.year_2.Name = "year_2";
            this.year_2.Size = new System.Drawing.Size(31, 13);
            this.year_2.TabIndex = 48;
            this.year_2.Text = "2020";
            // 
            // kurs_year_1
            // 
            this.kurs_year_1.Location = new System.Drawing.Point(42, 39);
            this.kurs_year_1.Name = "kurs_year_1";
            this.kurs_year_1.Size = new System.Drawing.Size(44, 20);
            this.kurs_year_1.TabIndex = 45;
            this.kurs_year_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // year_1
            // 
            this.year_1.AutoSize = true;
            this.year_1.Location = new System.Drawing.Point(9, 42);
            this.year_1.Name = "year_1";
            this.year_1.Size = new System.Drawing.Size(31, 13);
            this.year_1.TabIndex = 46;
            this.year_1.Text = "2019";
            // 
            // kurs_year_0
            // 
            this.kurs_year_0.Location = new System.Drawing.Point(141, 13);
            this.kurs_year_0.Name = "kurs_year_0";
            this.kurs_year_0.Size = new System.Drawing.Size(44, 20);
            this.kurs_year_0.TabIndex = 44;
            this.kurs_year_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // year_0
            // 
            this.year_0.AutoSize = true;
            this.year_0.Location = new System.Drawing.Point(108, 16);
            this.year_0.Name = "year_0";
            this.year_0.Size = new System.Drawing.Size(31, 13);
            this.year_0.TabIndex = 44;
            this.year_0.Text = "2018";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.sum_plat);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.srok_cred_new);
            this.groupBox6.Controls.Add(this.srok_kred_year_new);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Location = new System.Drawing.Point(10, 270);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(329, 60);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Досрочное погашение";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(49, 16);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(130, 13);
            this.label46.TabIndex = 31;
            this.label46.Text = "Сумма платежей ручная";
            // 
            // sum_plat
            // 
            this.sum_plat.Location = new System.Drawing.Point(185, 13);
            this.sum_plat.Name = "sum_plat";
            this.sum_plat.Size = new System.Drawing.Size(137, 20);
            this.sum_plat.TabIndex = 32;
            this.sum_plat.Text = "0";
            this.sum_plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Новый срок кредита (мес.)";
            // 
            // srok_cred_new
            // 
            this.srok_cred_new.Enabled = false;
            this.srok_cred_new.Location = new System.Drawing.Point(185, 36);
            this.srok_cred_new.Name = "srok_cred_new";
            this.srok_cred_new.Size = new System.Drawing.Size(48, 20);
            this.srok_cred_new.TabIndex = 34;
            this.srok_cred_new.Text = "0";
            this.srok_cred_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // srok_kred_year_new
            // 
            this.srok_kred_year_new.Enabled = false;
            this.srok_kred_year_new.Location = new System.Drawing.Point(235, 36);
            this.srok_kred_year_new.Name = "srok_kred_year_new";
            this.srok_kred_year_new.Size = new System.Drawing.Size(47, 20);
            this.srok_kred_year_new.TabIndex = 36;
            this.srok_kred_year_new.Text = "0";
            this.srok_kred_year_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(284, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "(лет)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Label1);
            this.groupBox5.Controls.Add(this.proc_stavka);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.srok_kred);
            this.groupBox5.Controls.Add(this.srok_kred_year);
            this.groupBox5.Controls.Add(this.Label37);
            this.groupBox5.Location = new System.Drawing.Point(6, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 42);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Обычные условия";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "% ставка";
            // 
            // proc_stavka
            // 
            this.proc_stavka.Location = new System.Drawing.Point(61, 14);
            this.proc_stavka.Name = "proc_stavka";
            this.proc_stavka.Size = new System.Drawing.Size(56, 20);
            this.proc_stavka.TabIndex = 1;
            this.proc_stavka.Text = "0";
            this.proc_stavka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(121, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 13);
            this.label26.TabIndex = 33;
            this.label26.Text = "Период (мес.)";
            // 
            // srok_kred
            // 
            this.srok_kred.Location = new System.Drawing.Point(204, 13);
            this.srok_kred.Name = "srok_kred";
            this.srok_kred.Size = new System.Drawing.Size(48, 20);
            this.srok_kred.TabIndex = 11;
            this.srok_kred.Text = "0";
            this.srok_kred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.srok_kred.TextChanged += new System.EventHandler(this.Srok_kred_TextChanged);
            // 
            // srok_kred_year
            // 
            this.srok_kred_year.Enabled = false;
            this.srok_kred_year.Location = new System.Drawing.Point(255, 13);
            this.srok_kred_year.Name = "srok_kred_year";
            this.srok_kred_year.Size = new System.Drawing.Size(47, 20);
            this.srok_kred_year.TabIndex = 19;
            this.srok_kred_year.Text = "0";
            this.srok_kred_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(303, 16);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(30, 13);
            this.Label37.TabIndex = 18;
            this.Label37.Text = "(лет)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.priv_proc_stavka);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.priv_srok_kred);
            this.groupBox4.Controls.Add(this.priv_srok_kred_year);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Location = new System.Drawing.Point(6, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 45);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Льготные условия";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 20);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(53, 13);
            this.label41.TabIndex = 25;
            this.label41.Text = "% ставка";
            // 
            // priv_proc_stavka
            // 
            this.priv_proc_stavka.Location = new System.Drawing.Point(63, 17);
            this.priv_proc_stavka.Name = "priv_proc_stavka";
            this.priv_proc_stavka.Size = new System.Drawing.Size(54, 20);
            this.priv_proc_stavka.TabIndex = 26;
            this.priv_proc_stavka.Text = "0";
            this.priv_proc_stavka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(123, 20);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 13);
            this.label43.TabIndex = 27;
            this.label43.Text = "Период (мес.)";
            // 
            // priv_srok_kred
            // 
            this.priv_srok_kred.Location = new System.Drawing.Point(202, 17);
            this.priv_srok_kred.Name = "priv_srok_kred";
            this.priv_srok_kred.Size = new System.Drawing.Size(48, 20);
            this.priv_srok_kred.TabIndex = 28;
            this.priv_srok_kred.Text = "0";
            this.priv_srok_kred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priv_srok_kred.TextChanged += new System.EventHandler(this.Priv_srok_kred_TextChanged);
            // 
            // priv_srok_kred_year
            // 
            this.priv_srok_kred_year.Enabled = false;
            this.priv_srok_kred_year.Location = new System.Drawing.Point(255, 17);
            this.priv_srok_kred_year.Name = "priv_srok_kred_year";
            this.priv_srok_kred_year.Size = new System.Drawing.Size(47, 20);
            this.priv_srok_kred_year.TabIndex = 30;
            this.priv_srok_kred_year.Text = "0";
            this.priv_srok_kred_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(305, 20);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(30, 13);
            this.label42.TabIndex = 29;
            this.label42.Text = "(лет)";
            // 
            // curr_code
            // 
            this.curr_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curr_code.FormattingEnabled = true;
            this.curr_code.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "GBP"});
            this.curr_code.Location = new System.Drawing.Point(69, 51);
            this.curr_code.Name = "curr_code";
            this.curr_code.Size = new System.Drawing.Size(54, 21);
            this.curr_code.TabIndex = 24;
            this.curr_code.SelectedIndexChanged += new System.EventHandler(this.Curr_code_SelectedIndexChanged);
            // 
            // kurs
            // 
            this.kurs.Location = new System.Drawing.Point(210, 51);
            this.kurs.Name = "kurs";
            this.kurs.Size = new System.Drawing.Size(44, 20);
            this.kurs.TabIndex = 23;
            this.kurs.Text = "0";
            this.kurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // summa
            // 
            this.summa.Location = new System.Drawing.Point(126, 51);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(78, 20);
            this.summa.TabIndex = 22;
            this.summa.Text = "0";
            this.summa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // date_cred
            // 
            this.date_cred.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_cred.Location = new System.Drawing.Point(208, 21);
            this.date_cred.Name = "date_cred";
            this.date_cred.Size = new System.Drawing.Size(127, 20);
            this.date_cred.TabIndex = 21;
            this.date_cred.Value = new System.DateTime(2011, 8, 23, 0, 0, 0, 0);
            this.date_cred.ValueChanged += new System.EventHandler(this.Date_cred_ValueChanged);
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.Location = new System.Drawing.Point(7, 26);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(144, 13);
            this.Label38.TabIndex = 20;
            this.Label38.Text = "Дата оформления кредита";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(177, 103);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(125, 17);
            this.CheckBox1.TabIndex = 17;
            this.CheckBox1.Text = "Расчет по сумме/%";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(13, 96);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(153, 23);
            this.Button2.TabIndex = 16;
            this.Button2.Text = "Пересчитать";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // type_r_stavka
            // 
            this.type_r_stavka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_r_stavka.FormattingEnabled = true;
            this.type_r_stavka.Items.AddRange(new object[] {
            "30/360",
            "факт/360",
            "факт/факт"});
            this.type_r_stavka.Location = new System.Drawing.Point(248, 243);
            this.type_r_stavka.Name = "type_r_stavka";
            this.type_r_stavka.Size = new System.Drawing.Size(89, 21);
            this.type_r_stavka.TabIndex = 15;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(216, 246);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(26, 13);
            this.Label36.TabIndex = 14;
            this.Label36.Text = "Тип";
            // 
            // type_proc
            // 
            this.type_proc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_proc.FormattingEnabled = true;
            this.type_proc.Items.AddRange(new object[] {
            "классика",
            "аннуитетная",
            "рассрочка"});
            this.type_proc.Location = new System.Drawing.Point(117, 242);
            this.type_proc.Name = "type_proc";
            this.type_proc.Size = new System.Drawing.Size(92, 21);
            this.type_proc.TabIndex = 13;
            this.type_proc.SelectedIndexChanged += new System.EventHandler(this.Type_proc_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 246);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(102, 13);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Форма погашения";
            // 
            // sum_kred
            // 
            this.sum_kred.Enabled = false;
            this.sum_kred.Location = new System.Drawing.Point(199, 126);
            this.sum_kred.Name = "sum_kred";
            this.sum_kred.Size = new System.Drawing.Size(136, 20);
            this.sum_kred.TabIndex = 9;
            this.sum_kred.Text = "0";
            this.sum_kred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(107, 129);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(85, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Сумма кредита";
            // 
            // proc_perv_vznos
            // 
            this.proc_perv_vznos.Location = new System.Drawing.Point(177, 77);
            this.proc_perv_vznos.Name = "proc_perv_vznos";
            this.proc_perv_vznos.Size = new System.Drawing.Size(78, 20);
            this.proc_perv_vznos.TabIndex = 7;
            this.proc_perv_vznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(147, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(24, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "в %";
            // 
            // perv_vznos
            // 
            this.perv_vznos.Location = new System.Drawing.Point(259, 77);
            this.perv_vznos.Name = "perv_vznos";
            this.perv_vznos.Size = new System.Drawing.Size(80, 20);
            this.perv_vznos.TabIndex = 5;
            this.perv_vznos.Text = "0";
            this.perv_vznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(127, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Первоначальный взнос";
            // 
            // summa_ekv
            // 
            this.summa_ekv.Enabled = false;
            this.summa_ekv.Location = new System.Drawing.Point(260, 51);
            this.summa_ekv.Name = "summa_ekv";
            this.summa_ekv.Size = new System.Drawing.Size(78, 20);
            this.summa_ekv.TabIndex = 3;
            this.summa_ekv.Text = "0";
            this.summa_ekv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Стоимость";
            // 
            // pereplata
            // 
            this.pereplata.Enabled = false;
            this.pereplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pereplata.Location = new System.Drawing.Point(238, 190);
            this.pereplata.Name = "pereplata";
            this.pereplata.Size = new System.Drawing.Size(94, 20);
            this.pereplata.TabIndex = 39;
            this.pereplata.Text = "0";
            this.pereplata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(174, 193);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 13);
            this.label29.TabIndex = 38;
            this.label29.Text = "Переплата";
            // 
            // comiss_bank
            // 
            this.comiss_bank.Location = new System.Drawing.Point(208, 25);
            this.comiss_bank.Name = "comiss_bank";
            this.comiss_bank.Size = new System.Drawing.Size(100, 20);
            this.comiss_bank.TabIndex = 15;
            this.comiss_bank.Text = "0";
            this.comiss_bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_bank.TextChanged += new System.EventHandler(this.Comiss_bank_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 25);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(182, 13);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Комиссия банка за обслуживание";
            // 
            // comiss_strah1
            // 
            this.comiss_strah1.Location = new System.Drawing.Point(208, 24);
            this.comiss_strah1.Name = "comiss_strah1";
            this.comiss_strah1.Size = new System.Drawing.Size(100, 20);
            this.comiss_strah1.TabIndex = 17;
            this.comiss_strah1.Text = "0";
            this.comiss_strah1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_strah1.TextChanged += new System.EventHandler(this.Comiss_strah1_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 27);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(168, 13);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "Страхование предмета ипотеки";
            // 
            // comiss_strah2
            // 
            this.comiss_strah2.Location = new System.Drawing.Point(208, 51);
            this.comiss_strah2.Name = "comiss_strah2";
            this.comiss_strah2.Size = new System.Drawing.Size(100, 20);
            this.comiss_strah2.TabIndex = 19;
            this.comiss_strah2.Text = "0";
            this.comiss_strah2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_strah2.TextChanged += new System.EventHandler(this.Comiss_strah2_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 53);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(172, 13);
            this.Label10.TabIndex = 18;
            this.Label10.Text = "По договору страхования жизни";
            // 
            // comiss_strah3
            // 
            this.comiss_strah3.Location = new System.Drawing.Point(208, 77);
            this.comiss_strah3.Name = "comiss_strah3";
            this.comiss_strah3.Size = new System.Drawing.Size(100, 20);
            this.comiss_strah3.TabIndex = 21;
            this.comiss_strah3.Text = "0";
            this.comiss_strah3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_strah3.TextChanged += new System.EventHandler(this.Comiss_strah3_TextChanged);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 80);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(182, 13);
            this.Label11.TabIndex = 20;
            this.Label11.Text = "Страхование от нещасного случая";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Location = new System.Drawing.Point(9, 19);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(326, 169);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.sum_dop_plat);
            this.TabPage5.Controls.Add(this.label44);
            this.TabPage5.Controls.Add(this.strax_itog);
            this.TabPage5.Controls.Add(this.Label16);
            this.TabPage5.Controls.Add(this.Label25);
            this.TabPage5.Controls.Add(this.notar_itog);
            this.TabPage5.Controls.Add(this.Label27);
            this.TabPage5.Controls.Add(this.rieltor_itog);
            this.TabPage5.Controls.Add(this.Label24);
            this.TabPage5.Controls.Add(this.bank_itog);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(318, 143);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Итоги";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // sum_dop_plat
            // 
            this.sum_dop_plat.Enabled = false;
            this.sum_dop_plat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_dop_plat.Location = new System.Drawing.Point(208, 112);
            this.sum_dop_plat.Name = "sum_dop_plat";
            this.sum_dop_plat.Size = new System.Drawing.Size(100, 20);
            this.sum_dop_plat.TabIndex = 15;
            this.sum_dop_plat.Text = "0";
            this.sum_dop_plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 38);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(113, 13);
            this.label44.TabIndex = 49;
            this.label44.Text = "Страховая компания";
            // 
            // strax_itog
            // 
            this.strax_itog.Enabled = false;
            this.strax_itog.Location = new System.Drawing.Point(208, 35);
            this.strax_itog.Name = "strax_itog";
            this.strax_itog.Size = new System.Drawing.Size(100, 20);
            this.strax_itog.TabIndex = 48;
            this.strax_itog.Text = "0";
            this.strax_itog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label16.Location = new System.Drawing.Point(6, 115);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(42, 13);
            this.Label16.TabIndex = 14;
            this.Label16.Text = "Всего";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(6, 63);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(55, 13);
            this.Label25.TabIndex = 22;
            this.Label25.Text = "Нотариус";
            // 
            // notar_itog
            // 
            this.notar_itog.Enabled = false;
            this.notar_itog.Location = new System.Drawing.Point(208, 60);
            this.notar_itog.Name = "notar_itog";
            this.notar_itog.Size = new System.Drawing.Size(100, 20);
            this.notar_itog.TabIndex = 23;
            this.notar_itog.Text = "0";
            this.notar_itog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(6, 89);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(49, 13);
            this.Label27.TabIndex = 24;
            this.Label27.Text = "Риелтор";
            // 
            // rieltor_itog
            // 
            this.rieltor_itog.Enabled = false;
            this.rieltor_itog.Location = new System.Drawing.Point(208, 86);
            this.rieltor_itog.Name = "rieltor_itog";
            this.rieltor_itog.Size = new System.Drawing.Size(100, 20);
            this.rieltor_itog.TabIndex = 25;
            this.rieltor_itog.Text = "0";
            this.rieltor_itog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(6, 12);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(32, 13);
            this.Label24.TabIndex = 16;
            this.Label24.Text = "Банк";
            // 
            // bank_itog
            // 
            this.bank_itog.Enabled = false;
            this.bank_itog.Location = new System.Drawing.Point(208, 9);
            this.bank_itog.Name = "bank_itog";
            this.bank_itog.Size = new System.Drawing.Size(100, 20);
            this.bank_itog.TabIndex = 17;
            this.bank_itog.Text = "0";
            this.bank_itog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.label45);
            this.TabPage1.Controls.Add(this.monthly_comiss_bank);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.comiss_bank);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(318, 143);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Банк";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 54);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(163, 13);
            this.label45.TabIndex = 50;
            this.label45.Text = "Ежемесячная комиссия банка";
            // 
            // monthly_comiss_bank
            // 
            this.monthly_comiss_bank.Location = new System.Drawing.Point(208, 51);
            this.monthly_comiss_bank.Name = "monthly_comiss_bank";
            this.monthly_comiss_bank.Size = new System.Drawing.Size(100, 20);
            this.monthly_comiss_bank.TabIndex = 16;
            this.monthly_comiss_bank.Text = "0";
            this.monthly_comiss_bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Label9);
            this.TabPage2.Controls.Add(this.comiss_strah3);
            this.TabPage2.Controls.Add(this.comiss_strah1);
            this.TabPage2.Controls.Add(this.Label11);
            this.TabPage2.Controls.Add(this.Label10);
            this.TabPage2.Controls.Add(this.comiss_strah2);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(318, 143);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Страховая компания";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.Label15);
            this.TabPage3.Controls.Add(this.comiss_notar4);
            this.TabPage3.Controls.Add(this.Label17);
            this.TabPage3.Controls.Add(this.comiss_notar5);
            this.TabPage3.Controls.Add(this.Label12);
            this.TabPage3.Controls.Add(this.comiss_notar3);
            this.TabPage3.Controls.Add(this.comiss_notar1);
            this.TabPage3.Controls.Add(this.Label13);
            this.TabPage3.Controls.Add(this.Label14);
            this.TabPage3.Controls.Add(this.comiss_notar2);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(318, 143);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Нотариус";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(6, 94);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(100, 13);
            this.Label15.TabIndex = 28;
            this.Label15.Text = "Пенсионный фонд";
            // 
            // comiss_notar4
            // 
            this.comiss_notar4.Location = new System.Drawing.Point(208, 91);
            this.comiss_notar4.Name = "comiss_notar4";
            this.comiss_notar4.Size = new System.Drawing.Size(100, 20);
            this.comiss_notar4.TabIndex = 29;
            this.comiss_notar4.Text = "0";
            this.comiss_notar4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_notar4.TextChanged += new System.EventHandler(this.Comiss_notar4_TextChanged);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(6, 120);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(199, 13);
            this.Label17.TabIndex = 30;
            this.Label17.Text = "Оформление догов. покупки-продажи";
            // 
            // comiss_notar5
            // 
            this.comiss_notar5.Location = new System.Drawing.Point(208, 118);
            this.comiss_notar5.Name = "comiss_notar5";
            this.comiss_notar5.Size = new System.Drawing.Size(100, 20);
            this.comiss_notar5.TabIndex = 31;
            this.comiss_notar5.Text = "0";
            this.comiss_notar5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_notar5.TextChanged += new System.EventHandler(this.Comiss_notar5_TextChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(6, 14);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(198, 13);
            this.Label12.TabIndex = 22;
            this.Label12.Text = "Внесение в реестр залог. имущества";
            // 
            // comiss_notar3
            // 
            this.comiss_notar3.Location = new System.Drawing.Point(208, 64);
            this.comiss_notar3.Name = "comiss_notar3";
            this.comiss_notar3.Size = new System.Drawing.Size(100, 20);
            this.comiss_notar3.TabIndex = 27;
            this.comiss_notar3.Text = "0";
            this.comiss_notar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_notar3.TextChanged += new System.EventHandler(this.Comiss_notar3_TextChanged);
            // 
            // comiss_notar1
            // 
            this.comiss_notar1.Location = new System.Drawing.Point(208, 11);
            this.comiss_notar1.Name = "comiss_notar1";
            this.comiss_notar1.Size = new System.Drawing.Size(100, 20);
            this.comiss_notar1.TabIndex = 23;
            this.comiss_notar1.Text = "0";
            this.comiss_notar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_notar1.TextChanged += new System.EventHandler(this.Comiss_notar1_TextChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(6, 67);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(69, 13);
            this.Label13.TabIndex = 26;
            this.Label13.Text = "Госпошлина";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(6, 40);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(161, 13);
            this.Label14.TabIndex = 24;
            this.Label14.Text = "Оформление договора залога";
            // 
            // comiss_notar2
            // 
            this.comiss_notar2.Location = new System.Drawing.Point(208, 38);
            this.comiss_notar2.Name = "comiss_notar2";
            this.comiss_notar2.Size = new System.Drawing.Size(100, 20);
            this.comiss_notar2.TabIndex = 25;
            this.comiss_notar2.Text = "0";
            this.comiss_notar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_notar2.TextChanged += new System.EventHandler(this.Comiss_notar2_TextChanged);
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.Label18);
            this.TabPage4.Controls.Add(this.comiss_rieltor2);
            this.TabPage4.Controls.Add(this.Label19);
            this.TabPage4.Controls.Add(this.comiss_rieltor3);
            this.TabPage4.Controls.Add(this.comiss_rieltor1);
            this.TabPage4.Controls.Add(this.Label20);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(318, 143);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Риелтор";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(9, 55);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(196, 13);
            this.Label18.TabIndex = 34;
            this.Label18.Text = "Консультация и оформл. документов";
            // 
            // comiss_rieltor2
            // 
            this.comiss_rieltor2.Location = new System.Drawing.Point(211, 52);
            this.comiss_rieltor2.Name = "comiss_rieltor2";
            this.comiss_rieltor2.Size = new System.Drawing.Size(100, 20);
            this.comiss_rieltor2.TabIndex = 35;
            this.comiss_rieltor2.Text = "0";
            this.comiss_rieltor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_rieltor2.TextChanged += new System.EventHandler(this.Comiss_rieltor2_TextChanged);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(9, 81);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(156, 13);
            this.Label19.TabIndex = 36;
            this.Label19.Text = "Регистрация договора в БТИ";
            // 
            // comiss_rieltor3
            // 
            this.comiss_rieltor3.Location = new System.Drawing.Point(211, 79);
            this.comiss_rieltor3.Name = "comiss_rieltor3";
            this.comiss_rieltor3.Size = new System.Drawing.Size(100, 20);
            this.comiss_rieltor3.TabIndex = 37;
            this.comiss_rieltor3.Text = "0";
            this.comiss_rieltor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_rieltor3.TextChanged += new System.EventHandler(this.Comiss_rieltor3_TextChanged);
            // 
            // comiss_rieltor1
            // 
            this.comiss_rieltor1.Location = new System.Drawing.Point(211, 25);
            this.comiss_rieltor1.Name = "comiss_rieltor1";
            this.comiss_rieltor1.Size = new System.Drawing.Size(100, 20);
            this.comiss_rieltor1.TabIndex = 33;
            this.comiss_rieltor1.Text = "0";
            this.comiss_rieltor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.comiss_rieltor1.TextChanged += new System.EventHandler(this.Comiss_rieltor1_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(9, 28);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(184, 13);
            this.Label20.TabIndex = 32;
            this.Label20.Text = "Экспертная оценка недвижимости";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TabControl1);
            this.GroupBox2.Controls.Add(this.pereplata);
            this.GroupBox2.Controls.Add(this.label29);
            this.GroupBox2.Location = new System.Drawing.Point(12, 414);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(347, 217);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Дополнительные расходы";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(6, 8);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(130, 13);
            this.Label21.TabIndex = 8;
            this.Label21.Text = "%S - % с суммы кредита";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(142, 8);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(161, 13);
            this.Label22.TabIndex = 9;
            this.Label22.Text = "%F - % от стоимости квартиры";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Button4);
            this.GroupBox3.Controls.Add(this.Button3);
            this.GroupBox3.Controls.Add(this.Label21);
            this.GroupBox3.Controls.Add(this.Label23);
            this.GroupBox3.Controls.Add(this.Label22);
            this.GroupBox3.Location = new System.Drawing.Point(365, 560);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(573, 41);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(381, 14);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "Обновить";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(462, 14);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 11;
            this.Button3.Text = "INI файл";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(4, 22);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(228, 13);
            this.Label23.TabIndex = 10;
            this.Label23.Text = "%YEAR - ежегодно, %MONTH - ежемесячно";
            // 
            // on_dop_rasx
            // 
            this.on_dop_rasx.AutoSize = true;
            this.on_dop_rasx.Checked = true;
            this.on_dop_rasx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.on_dop_rasx.Location = new System.Drawing.Point(368, 603);
            this.on_dop_rasx.Name = "on_dop_rasx";
            this.on_dop_rasx.Size = new System.Drawing.Size(102, 17);
            this.on_dop_rasx.TabIndex = 12;
            this.on_dop_rasx.Text = "+ доп. расходы";
            this.on_dop_rasx.UseVisualStyleBackColor = true;
            this.on_dop_rasx.Visible = false;
            // 
            // dop_rasx_month_or_all
            // 
            this.dop_rasx_month_or_all.AutoSize = true;
            this.dop_rasx_month_or_all.Checked = true;
            this.dop_rasx_month_or_all.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dop_rasx_month_or_all.Location = new System.Drawing.Point(465, 603);
            this.dop_rasx_month_or_all.Name = "dop_rasx_month_or_all";
            this.dop_rasx_month_or_all.Size = new System.Drawing.Size(157, 17);
            this.dop_rasx_month_or_all.TabIndex = 13;
            this.dop_rasx_month_or_all.Text = "+ перв. мес.- весь период";
            this.dop_rasx_month_or_all.UseVisualStyleBackColor = true;
            this.dop_rasx_month_or_all.Visible = false;
            // 
            // type_rasch
            // 
            this.type_rasch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_rasch.FormattingEnabled = true;
            this.type_rasch.Location = new System.Drawing.Point(439, 4);
            this.type_rasch.Name = "type_rasch";
            this.type_rasch.Size = new System.Drawing.Size(499, 21);
            this.type_rasch.TabIndex = 14;
            this.type_rasch.SelectedIndexChanged += new System.EventHandler(this.Type_rasch_SelectedIndexChanged);
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.Location = new System.Drawing.Point(365, 8);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(72, 13);
            this.Label39.TabIndex = 15;
            this.Label39.Text = "Тип расчета:";
            // 
            // kurs_year_4
            // 
            this.kurs_year_4.Location = new System.Drawing.Point(280, 39);
            this.kurs_year_4.Name = "kurs_year_4";
            this.kurs_year_4.Size = new System.Drawing.Size(44, 20);
            this.kurs_year_4.TabIndex = 53;
            this.kurs_year_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // year_4
            // 
            this.year_4.AutoSize = true;
            this.year_4.Location = new System.Drawing.Point(248, 42);
            this.year_4.Name = "year_4";
            this.year_4.Size = new System.Drawing.Size(31, 13);
            this.year_4.TabIndex = 54;
            this.year_4.Text = "2022";
            // 
            // Kred_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 639);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label39);
            this.Controls.Add(this.type_rasch);
            this.Controls.Add(this.dop_rasx_month_or_all);
            this.Controls.Add(this.on_dop_rasx);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kred_calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредитный калькулятор";
            this.Load += new System.EventHandler(this.Kred_calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupbox_rasrochka.ResumeLayout(false);
            this.groupbox_rasrochka.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox proc_stavka;
		internal System.Windows.Forms.TextBox summa_ekv;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox perv_vznos;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox proc_perv_vznos;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox sum_kred;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox srok_kred;
		internal System.Windows.Forms.ComboBox type_proc;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox comiss_bank;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox comiss_strah3;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox comiss_strah2;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox comiss_strah1;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox comiss_notar4;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.TextBox comiss_notar5;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox comiss_notar3;
		internal System.Windows.Forms.TextBox comiss_notar1;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox comiss_notar2;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.TextBox sum_dop_plat;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.TextBox comiss_rieltor2;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox comiss_rieltor3;
		internal System.Windows.Forms.TextBox comiss_rieltor1;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.TabPage TabPage5;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.TextBox notar_itog;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.TextBox rieltor_itog;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.TextBox bank_itog;
		internal System.Windows.Forms.ComboBox type_r_stavka;
		internal System.Windows.Forms.Label Label36;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.TextBox srok_kred_year;
		internal System.Windows.Forms.Label Label37;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.CheckBox on_dop_rasx;
		internal System.Windows.Forms.CheckBox dop_rasx_month_or_all;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.DateTimePicker date_cred;
		internal System.Windows.Forms.Label Label38;
		internal System.Windows.Forms.ComboBox type_rasch;
		internal System.Windows.Forms.Label Label39;
		internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem ЭкспортВExcelToolStripMenuItem;
		internal System.Windows.Forms.TextBox kurs;
		internal System.Windows.Forms.TextBox summa;

		private static Kred_calculator _DefaultInstance;
        internal ComboBox curr_code;
        internal TextBox priv_srok_kred_year;
        internal Label label42;
        internal TextBox priv_srok_kred;
        internal Label label43;
        internal TextBox priv_proc_stavka;
        internal Label label41;
        internal Label label44;
        internal TextBox strax_itog;
        internal Label label45;
        internal TextBox monthly_comiss_bank;
        internal TextBox sum_plat;
        internal Label label46;
        internal Label label26;
        internal TextBox pereplata;
        internal Label label29;
        internal Label label6;
        internal TextBox srok_kred_year_new;
        internal Label label28;
        internal TextBox srok_cred_new;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private GroupBox groupbox_rasrochka;
        internal TextBox kurs_year_3;
        internal Label year_3;
        internal TextBox kurs_year_2;
        internal Label year_2;
        internal TextBox kurs_year_1;
        internal Label year_1;
        internal TextBox kurs_year_0;
        internal Label year_0;
        internal TextBox kurs_start;
        internal Label label34;
        internal TextBox kurs_year_4;
        internal Label year_4;

        public static Kred_calculator DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new Kred_calculator();

				return _DefaultInstance;
			}
		}
	}

}