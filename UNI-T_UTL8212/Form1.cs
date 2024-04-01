using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Collections;
using System.Xml.Linq;

namespace UNI_T_UTL8212
{
    public partial class Form1 : Form
    {
        string title = "UNI-T UTL8212+ PC Program V1.0";

        // Grafikle ilgili kısım
        GraphPane myPane;
        LineItem myCurve_1;
        LineItem myCurve_2;
        PointPairList list1 = new PointPairList();
        PointPairList list2 = new PointPairList();

        YAxis yAxis1 = new YAxis("Y1 Series");
        YAxis yAxis2 = new YAxis("Y2 Series");

        int X_Axis_Name = 1;
        int X_Axis_Scale = 3;
        int Y1_Axis_Name = 0;
        int Y1_Axis_Scale = 3;
        int Y2_Axis_Name = 0;
        int Y2_Axis_Scale = 3;
        string X_Name;
        string Y1_Name;
        string Y2_Name;
        string X_Scale;
        string Y1_Scale;
        string Y2_Scale;
        // Grafik ile ilgili alan sonu//

        // Degiskenler
        public static int MeasurementVout;
        public static int MeasurementIout;
        public static int MeasurementPower;
        public static int MeasurementResistance;

        int TestType1;
        int TestType2;
        int TestType3;
        int TestType4;
        int TestStartStopCommand;

        double X_MulDiv;
        double Y1_MulDiv;
        double Y2_MulDiv;
        // Degiskenler alan sonu

        public Form1()
        {
            InitializeComponent();

            // Grafik ile ilgili alan
            CreateGraph(zedGraphControl1);

            RefreshAxis();
            // Grafik ile ilgili alan sonu;

            DoDisconnect();

            StatusLabel1.Text = "Waiting to Connection";
            StatusLabel2.Text = "";
            StatusLabel3.Text = "";
            StatusLabel4.Text = "";
            StatusLabel5.Text = "";

            textBox1.Visible = false;

            this.Text = title;

            this.FormClosing += Form1_FormClosing;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.firatdeveci.com");
        }

        #region Connection Area
        private void Connect_Button_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                
                serialPort1.StopBits    = StopBits.One;
                serialPort1.Handshake   = Handshake.None;
                serialPort1.BaudRate    = Convert.ToInt32(BaudList.Text);
                serialPort1.PortName    = ComPortList.Text;

                serialPort1.Open();

                DoConnect();
            }
            catch (System.Exception)
            {
                MessageBox.Show("An Error Accure");

                DoDisconnect();
            }
        }

        private void disConnect_Button_Click(object sender, EventArgs e)
        {
            CloseConnectionFlag                 = 1;

            Ch1DummyLoadStopButton.PerformClick();
            Ch2DummyLoadStopButton.PerformClick();
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void DoConnect()
        {
            GonderimSayaci                      = 0;

            timer2.Enabled                      = true;

            Connect_Button.Enabled              = false;
            disConnect_Button.Enabled           = true;

            ComPortList.Enabled                 = false;
            BaudList.Enabled                    = false;

            StatusLabel1.Enabled                = true;
            StatusLabel2.Enabled                = true;
            StatusLabel3.Enabled                = true;

            Ch1Measurements.Enabled             = true;
            Ch2Measurements.Enabled             = true;

            GraphicSettingsGroupBox.Enabled     = true;

            Ch1ClassicalGroupBox.Enabled        = true;
            Ch2ClassicalGroupBox.Enabled        = true;

            Ch1DummyLoadGroupBox.Enabled        = true;
            Ch2DummyLoadGroupBox.Enabled        = true;

            zedGraphControl1.Enabled            = true;

            this.Text                           = title + " - Connected";

            StatusLabel1.Text                   = "Connected!";
            StatusLabel2.Text                   = "";
            StatusLabel3.Text                   = "";

            StatusLabel1.ForeColor              = Color.DarkGreen;

            timer1.Enabled                      = true;
            timer3.Enabled                      = true;
        }

        private void DoDisconnect()
        {
            timer2.Enabled                      = false;
            timer3.Enabled                      = false;

            Connect_Button.Enabled              = true;
            disConnect_Button.Enabled           = false;

            ComPortList.Enabled                 = true;
            BaudList.Enabled                    = true;

            StatusLabel1.Enabled                = true;
            StatusLabel2.Enabled                = false;
            StatusLabel3.Enabled                = false;

            Ch1Measurements.Enabled             = false;
            Ch2Measurements.Enabled             = false;

            GraphicSettingsGroupBox.Enabled     = false;

            Ch1ClassicalGroupBox.Enabled        = false;
            Ch2ClassicalGroupBox.Enabled        = false;

            Ch1DummyLoadGroupBox.Enabled        = false;
            Ch2DummyLoadGroupBox.Enabled        = false;

            zedGraphControl1.Enabled            = false;

            this.Text                           = title + " - Disconnected";

            StatusLabel1.Text                   = "Disconnected!";
            StatusLabel2.Text                   = "";
            StatusLabel3.Text                   = "";
            StatusLabel4.Text                   = "";
            StatusLabel5.Text                   = "";

            StatusLabel1.ForeColor              = Color.Red;

            Kanal_1_StepStartStop               = 0;
            Kanal_2_StepStartStop               = 0;

            Kanal_1_StepCounter                 = 0;
            Kanal_2_StepCounter                 = 0;

            Kanal_1_StepWaitCounter             = 0;
            Kanal_2_StepWaitCounter             = 0;

            StepIntervalCounter                 = 0;
            
            Kanal_1_StepStartStop               = 0;
            Kanal_2_StepStartStop               = 0;

            Kanal_1_LoadModelFlag               = 0;
            Kanal_2_LoadModelFlag               = 0;

            Ch1_VoltSegment.Value               = "-------";
            Ch1_AmpSegment.Value                = "-------";
            Ch1_ResSegment.Value                = "-------";
            Ch1_PowSegment.Value                = "-------";

            Ch2_VoltSegment.Value               = "-------";
            Ch2_AmpSegment.Value                = "-------";
            Ch2_ResSegment.Value                = "-------";
            Ch2_PowSegment.Value                = "-------";
        }

        int CurrentSerialPortNumber, BeforeSerialPortNumber;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string COM_NAME;

            foreach (string s in SerialPort.GetPortNames())
            {
                CurrentSerialPortNumber++;
            }

            if (CurrentSerialPortNumber != BeforeSerialPortNumber)
            {
                BeforeSerialPortNumber = CurrentSerialPortNumber;
                ComPortList.Items.Clear();
                foreach (string s in SerialPort.GetPortNames())
                {
                    COM_NAME = Regex.Match(s, @"COM\d+").Value;

                    COM_NAME = "";
                    foreach (char C in s)
                    {
                        if (C == 'C' || C == 'O' || C == 'M' || C == '0' || C == '1' || C == '2' || C == '3' || C == '4' || C == '5' || C == '6' || C == '7' || C == '8' || C == '9')
                            COM_NAME = COM_NAME + C;
                    }

                    ComPortList.Items.Add(COM_NAME);
                }

                if (CurrentSerialPortNumber > 0)
                {
                    ComPortList.Sorted = true;
                    ComPortList.SelectedIndex = 0;
                }
            }

            CurrentSerialPortNumber = 0;
        }

        private void BaudList_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt32(BaudList.Text);
        }

        private void ComPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = ComPortList.Text;
        }

        #endregion

        #region Graphic Area
        // ZedGraph'in tüm ayarları buradan yapılıyor
        private void CreateGraph(ZedGraphControl zgc)
        {
            // Grafik alanı için referans alınıyor
            myPane = zedGraphControl1.GraphPane;

            // Buradan başlıklar düzenleniyor
            myPane.Title.Text = "Voltage-Current Graphic";
            myPane.XAxis.Title.Text = "Current (A)";
            myPane.Title.FontSpec.FontColor = Color.Green;
            myPane.Title.FontSpec.Size = 12;
            myPane.Title.FontSpec.IsBold = true;

            // Curve ekleniyor
            myCurve_1 = myPane.AddCurve("Y1 Series", list1, Color.Red, SymbolType.Circle);
            myCurve_1.Line.Width = 2f;
            myCurve_1.IsVisible = true;

            yAxis1.Color = Color.Red;
            yAxis1.Title.FontSpec.Size = 14;
            yAxis1.IsVisible = true;
            myCurve_1.YAxisIndex = 0;
            myPane.YAxisList.Add(yAxis1);

            myCurve_2 = myPane.AddCurve("Y2 Series", list2, Color.Green, SymbolType.Triangle);
            myCurve_2.Line.Width = 2f;
            myCurve_2.IsVisible = true;

            yAxis2.Color = Color.Green;
            yAxis2.Title.FontSpec.Size = 14;
            yAxis2.IsVisible = true;
            myCurve_1.YAxisIndex = 1;
            myPane.YAxisList.Add(yAxis2);

            myPane.YAxisList[0].IsVisible = false;

            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;

            myPane.XAxis.MinorGrid.IsVisible = true;
            myPane.YAxis.MinorGrid.IsVisible = true;

            myPane.Legend.Position = ZedGraph.LegendPos.TopFlushLeft;
            myPane.Legend.IsShowLegendSymbols = true;

            // Fill the axis background with a gradient
            //myPane.Chart.Fill = new Fill(Color.White, Color.LimeGreen, 90.0f);

            myCurve_1.Symbol.Size = 7;
            myCurve_2.Symbol.Size = 7;

            myCurve_1.Line.IsSmooth = true;     // Cizgnin kesikli kesikli olmamasi icin bu true oluyor
            myCurve_2.Line.IsSmooth = true;

            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();

            RefreshAxis();
        }

        private void RefreshAxis()
        {
            switch (X_Axis_Name)
            {
                case 0: X_Name = "Voltage [V]"; break;
                default:
                case 1: X_Name = "Current [A]"; break;
                case 2: X_Name = "Power [W]"; break;
                case 3: X_Name = "Resistance [Ω]"; break;
            }

            switch (Y1_Axis_Name)
            {
                case 0: Y1_Name = "Voltage [V]"; break;
                default:
                case 1: Y1_Name = "Current [A]"; break;
                case 2: Y1_Name = "Power [W]"; break;
                case 3: Y1_Name = "Resistance [Ω]"; break;
            }

            switch (Y2_Axis_Name)
            {
                default:
                case 0: Y2_Name = ""; break;
                case 1: Y2_Name = "Voltage [V]"; break;
                case 2: Y2_Name = "Current [A]"; break;
                case 3: Y2_Name = "Power [W]"; break;
                case 4: Y2_Name = "Resistance [Ω]"; break;
            }

            switch (X_Axis_Scale)
            {
                case 0: X_Scale = "[/1000]"; X_MulDiv = 0.001; break;
                case 1: X_Scale = "[/100]"; X_MulDiv = 0.01; break;
                case 2: X_Scale = "/10]"; X_MulDiv = 0.1; break;
                default:
                case 3: X_Scale = "[x1]"; X_MulDiv = 1; break;
                case 4: X_Scale = "[x10]"; X_MulDiv = 10; break;
                case 5: X_Scale = "[x100]"; X_MulDiv = 100; break;
                case 6: X_Scale = "[x1000]"; X_MulDiv = 1000; break;
            }

            switch (Y1_Axis_Scale)
            {
                case 0: Y1_Scale = "[/1000]"; Y1_MulDiv = 0.001; break;
                case 1: Y1_Scale = "[/100]"; Y1_MulDiv = 0.01; break;
                case 2: Y1_Scale = "/10]"; Y1_MulDiv = 0.1; break;
                default:
                case 3: Y1_Scale = "[x1]"; Y1_MulDiv = 1; break;
                case 4: Y1_Scale = "[x10]"; Y1_MulDiv = 10; break;
                case 5: Y1_Scale = "[x100]"; Y1_MulDiv = 100; break;
                case 6: Y1_Scale = "[x1000]"; Y1_MulDiv = 1000; break;
            }

            switch (Y2_Axis_Scale)
            {
                case 0: Y2_Scale = "[/1000]"; Y2_MulDiv = 0.001; break;
                case 1: Y2_Scale = "[/100]"; Y2_MulDiv = 0.01; break;
                case 2: Y2_Scale = "/10]"; Y2_MulDiv = 0.1; break;
                default:
                case 3: Y2_Scale = "[x1]"; Y2_MulDiv = 1; break;
                case 4: Y2_Scale = "[x10]"; Y2_MulDiv = 10; break;
                case 5: Y2_Scale = "[x100]"; Y2_MulDiv = 100; break;
                case 6: Y2_Scale = "[x1000]"; Y2_MulDiv = 1000; break;
            }

            if (Y2_Name == "")
            {
                myPane.YAxisList[2].IsVisible = false;
                myCurve_2.IsVisible = false;

                // Buradan başlıklar düzenleniyor
                myPane.Title.Text = X_Name + " / " + Y1_Name + " Graphic";
            }
            else
            {
                myPane.YAxisList[2].IsVisible = true;
                myCurve_2.IsVisible = true;

                // Buradan başlıklar düzenleniyor
                myPane.Title.Text = X_Name + " / " + Y1_Name + " - " + Y2_Name + " Graphic";
            }

            myPane.XAxis.Title.Text = X_Name;
            yAxis1.Title.Text = Y1_Name;
            yAxis2.Title.Text = Y2_Name;

            yAxis1.Scale.Min = 0;
            yAxis2.Scale.Min = 0;

            myCurve_1.Label.Text = Y1_Name;
            myCurve_2.Label.Text = Y2_Name;

            list1.Clear();
            list2.Clear();

            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void Thickness_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCurve_1.Line.Width = Convert.ToUInt32(Thickness_Select.Text);
            myCurve_2.Line.Width = myCurve_1.Line.Width;

            myCurve_1.Symbol.Size = myCurve_2.Line.Width + 5;
            myCurve_2.Symbol.Size = myCurve_2.Line.Width + 5;

            if (TestStartStopCommand == 0)
                zedGraphControl1.Refresh();
        }
        private void X_Axis_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            X_Axis_Name = X_Axis_Select.SelectedIndex;

            RefreshAxis();
        }
        private void X_Gain_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            X_Axis_Scale = X_Gain_Select.SelectedIndex;

            RefreshAxis();
        }

        private void Y1_Axis_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y1_Axis_Name = Y1_Axis_Select.SelectedIndex;

            RefreshAxis();
        }

        private void Y1_Gain_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y1_Axis_Scale = Y1_Gain_Select.SelectedIndex;

            RefreshAxis();
        }

        private void Y2_Axis_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y2_Axis_Name = Y2_Axis_Select.SelectedIndex;

            RefreshAxis();
        }

        private void Y2_Gain_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y2_Axis_Scale = Y2_Gain_Select.SelectedIndex;

            RefreshAxis();
        }

        private void Grid_Select_CheckedChanged(object sender, EventArgs e)
        {
            myPane.XAxis.MajorGrid.IsVisible = Grid_Select.Checked;
            myPane.YAxis.MajorGrid.IsVisible = Grid_Select.Checked;

            myPane.XAxis.MinorGrid.IsVisible = Grid_Select.Checked;
            myPane.YAxis.MinorGrid.IsVisible = Grid_Select.Checked;

            if (TestStartStopCommand == 0)
            {
                zedGraphControl1.Invalidate();
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
            }
        }

        int TextBoxShowCounter;

        private void Symb_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (Symb_Select.Checked == true)
            {
                myCurve_1.Symbol.IsVisible = true;
                myCurve_2.Symbol.IsVisible = true;

                myCurve_1.Symbol.Size = myCurve_2.Line.Width + 5;
                myCurve_2.Symbol.Size = myCurve_2.Line.Width + 5;
            }
            else
            {
                myCurve_1.Symbol.IsVisible = false;
                myCurve_2.Symbol.IsVisible = false;

                myCurve_1.Symbol.Size = 0;
                myCurve_2.Symbol.Size = 0;
            }

            if (TestStartStopCommand == 0)
            {
                zedGraphControl1.Invalidate();
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
            }
           
            /// Kacak yoldan textbox gosterme
            if (TextBoxShowCounter == 5)
            {
                textBox1.Visible = true;
                TextBoxShowCounter = 0;
            }
            else
                textBox1.Visible = false;

            TextBoxShowCounter++;
        }
        #endregion

        #region SendCommandValue

        string Kanal1Dummy;
        string Kanal2Dummy;

        int ID_Counter;

        int Kanal1_Start_Counter;
        int Kanal2_Start_Counter;

        int Kanal1_Stop_Counter;
        int Kanal2_Stop_Counter;

        int DisplayCounter;

        int Kanal_1_CurrRefValue;

        int Kanal_1_LoadModelFlag;
        int Kanal_1_StartStopFlag;
        int Kanal_1_RefSendFlag;

        int Kanal_2_CurrRefValue;

        int Kanal_2_LoadModelFlag;
        int Kanal_2_StartStopFlag;
        int Kanal_2_RefSendFlag;

        int GonderimSayaci;

        int Kanal_1_RefFinalDeger;
        int Kanal_2_RefFinalDeger;

        int Kanal_1_RefAdimDeger;
        int Kanal_2_RefAdimDeger;

        int Kanal_1_RefAnlikDeger;
        int Kanal_2_RefAnlikDeger;

        string Kanal_1_RefAnlikDegerString;
        string Kanal_2_RefAnlikDegerString;

        int Kanal_1_StepStartStop;
        int Kanal_2_StepStartStop;

        int Kanal_1_StepCounter;
        int Kanal_2_StepCounter;

        int Kanal_1_StepWaitCounter;
        int Kanal_2_StepWaitCounter;

        int StepIntervalCounter;

        int CloseConnectionFlag;
        int CloseIntervalCounter;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(CloseConnectionFlag==1)
            {
                if (CloseIntervalCounter == 3)
                {
                    CloseIntervalCounter = 0;
                    CloseConnectionFlag = 0;

                    try
                    {
                        if (serialPort1.IsOpen == true)
                        {
                            DoDisconnect();
                            serialPort1.Close();
                        }
                        else
                        {
                            MessageBox.Show("An Error Accure");

                            DoDisconnect();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An Error Accure");

                        DoDisconnect();
                    }
                }
                else
                {
                    serialPort1.Write("INP CH1,0\r\n");
                    serialPort1.Write("INP CH2,0\r\n");
                    CloseIntervalCounter++;
                }
            }
            else if (Kanal_1_LoadModelFlag==1)
            {
                serialPort1.Write("MODE CH1,CURR\r\n");
                Kanal_1_LoadModelFlag = 0;
            }
            else if (Kanal_1_LoadModelFlag == 2)
            {               
                serialPort1.Write("MODE CH1,RES\r\n");
                Kanal_1_LoadModelFlag = 0;
            }
            else if (Kanal_1_LoadModelFlag == 3)
            {
                serialPort1.Write("MODE CH1,POW\r\n");
                Kanal_1_LoadModelFlag = 0;
            }
            else if (Kanal_1_LoadModelFlag == 4)
            {
                serialPort1.Write("MODE CH1,VOLT\r\n");
                Kanal_1_LoadModelFlag = 0;
            }
            else if (Kanal_1_LoadModelFlag == 5)
            {
                serialPort1.Write("MODE CH1,DYN\r\n");
                Kanal_1_LoadModelFlag = 0;
            }
            else if (Kanal_1_LoadModelFlag == 6)
            {
                serialPort1.Write("MODE CH1,CURR\r\n");
                serialPort1.Write("INP:SHOR CH1,1\r\n");
                Kanal_1_LoadModelFlag = 0;
            }
            else if (Kanal_1_LoadModelFlag == 7)
            {
                serialPort1.Write("INP:SHOR CH1,0\r\n");
                Kanal_1_LoadModelFlag = 0;
            }
            else if (Kanal_2_LoadModelFlag == 1)
            {
                serialPort1.Write("MODE CH2,CURR\r\n");
                Kanal_2_LoadModelFlag = 0;
            }
            else if (Kanal_2_LoadModelFlag == 2)
            {
                serialPort1.Write("MODE CH2,RES\r\n");
                Kanal_2_LoadModelFlag = 0;
            }
            else if (Kanal_2_LoadModelFlag == 3)
            {
                serialPort1.Write("MODE CH2,POW\r\n");
                Kanal_2_LoadModelFlag = 0;
            }
            else if (Kanal_2_LoadModelFlag == 4)
            {
                serialPort1.Write("MODE CH2,VOLT\r\n");
                Kanal_2_LoadModelFlag = 0;
            }
            else if (Kanal_2_LoadModelFlag == 5)
            {
                serialPort1.Write("MODE CH2,DYN\r\n");
                Kanal_2_LoadModelFlag = 0;
            }
            else if (Kanal_2_LoadModelFlag == 6)
            {
                serialPort1.Write("MODE CH2,CURR\r\n");
                serialPort1.Write("INP:SHOR CH2,1\r\n");
                Kanal_2_LoadModelFlag = 0;
            }
            else if (Kanal_2_LoadModelFlag == 7)
            {
                serialPort1.Write("INP:SHOR CH2,0\r\n");
                Kanal_2_LoadModelFlag = 0;
            }
            else if (Kanal_1_RefSendFlag == 1)
            {
                Kanal_1_CurrRefValue = Convert.ToInt32(Ch1RefValue.Value * 1000);
                Kanal1Dummy = (Kanal_1_CurrRefValue / 1000).ToString() + "." + ((Kanal_1_CurrRefValue % 1000) / 100).ToString() + ((Kanal_1_CurrRefValue % 100) / 10).ToString() + (Kanal_1_CurrRefValue % 10).ToString();

                     if (Ch1LoadModel.SelectedIndex == 0) { serialPort1.Write("CURR CH1," + Kanal1Dummy + "\r\n"); Ch1RefValue.Maximum = 20; }
                else if (Ch1LoadModel.SelectedIndex == 1) { serialPort1.Write("RES CH1," +  Kanal1Dummy + "\r\n"); Ch1RefValue.Maximum = 1500; }
                else if (Ch1LoadModel.SelectedIndex == 2) { serialPort1.Write("POW CH1," +  Kanal1Dummy + "\r\n"); Ch1RefValue.Maximum = 200; }
                else if (Ch1LoadModel.SelectedIndex == 3) { serialPort1.Write("VOLT CH1," + Kanal1Dummy + "\r\n"); Ch1RefValue.Maximum = 150; }

                Kanal_1_RefSendFlag = 0;
            }
            else if (Kanal_1_StartStopFlag == 1)
            {
                serialPort1.Write("INP CH1,1\r\n");

                if (Kanal1_Start_Counter < 2)
                    Kanal1_Start_Counter++;
                else
                {
                    Kanal_1_StartStopFlag = 0;
                    Kanal1_Start_Counter = 0;
                }
            }
            else if (Kanal_1_StartStopFlag == 2)
            {
                serialPort1.Write("INP CH1,0\r\n");

                if (Kanal1_Stop_Counter < 2)
                    Kanal1_Stop_Counter++;
                else
                {
                    Kanal_1_StartStopFlag   = 0;
                    Kanal1_Stop_Counter     = 0;
                }
            }
            else if (Kanal_2_RefSendFlag == 1)
            {
                Kanal_2_CurrRefValue = Convert.ToInt32(Ch2RefValue.Value * 1000);
                Kanal2Dummy = (Kanal_2_CurrRefValue / 1000).ToString() + "." + ((Kanal_2_CurrRefValue % 1000) / 100).ToString() + ((Kanal_2_CurrRefValue % 100) / 10).ToString() + (Kanal_2_CurrRefValue % 10).ToString();

                     if (Ch2LoadModel.SelectedIndex == 0) { serialPort1.Write("CURR CH2," + Kanal2Dummy + "\r\n"); Ch2RefValue.Maximum = 20; }
                else if (Ch2LoadModel.SelectedIndex == 1) { serialPort1.Write("RES CH2,"  + Kanal2Dummy + "\r\n"); Ch2RefValue.Maximum = 1500; }
                else if (Ch2LoadModel.SelectedIndex == 2) { serialPort1.Write("POW CH2,"  + Kanal2Dummy + "\r\n"); Ch2RefValue.Maximum = 200; }
                else if (Ch2LoadModel.SelectedIndex == 3) { serialPort1.Write("VOLT CH2," + Kanal2Dummy + "\r\n"); Ch2RefValue.Maximum = 150; }

                Kanal_2_RefSendFlag = 0;
            }
            else if (Kanal_2_StartStopFlag == 1)
            {
                serialPort1.Write("INP CH2,1\r\n");

                if (Kanal2_Start_Counter < 2)
                    Kanal2_Start_Counter++;
                else
                {
                    Kanal_2_StartStopFlag = 0;
                    Kanal2_Start_Counter = 0;
                }
            }
            else if (Kanal_2_StartStopFlag == 2)
            {
                serialPort1.Write("INP CH2,0\r\n");

                if (Kanal2_Stop_Counter < 2)
                    Kanal2_Stop_Counter++;
                else
                {
                    Kanal_2_StartStopFlag   = 0;
                    Kanal2_Stop_Counter     = 0;
                }
            }
            else if (DisplayCounter == 1)
            {
                DisplayCounter = 0;

                if (GonderimSayaci == 0)
                {
                    serialPort1.Write("*IDN?\r\n");

                    if (ID_Counter > 2)
                    {
                        GonderimSayaci = 1;
                        ID_Counter = 0;
                    }
                    else
                        ID_Counter++;
                }
                else if (GonderimSayaci == 1)
                {
                    serialPort1.Write("CHANnel:SHORtcut ON\r\n");
                    GonderimSayaci = 2;
                }
                else if (GonderimSayaci == 2)
                {
                    serialPort1.Write("INP:SHOR CH1,0\r\n");
                    GonderimSayaci = 3;
                }
                else if (GonderimSayaci == 3)
                {
                    serialPort1.Write("INP:SHOR CH2,0\r\n");
                    GonderimSayaci = 4;
                }
                else if (GonderimSayaci == 4)
                {
                    serialPort1.Write("MODE?\r\n");
                    GonderimSayaci = 5;
                }
                else if (GonderimSayaci == 5)
                {
                    GonderimSayaci = 6;
                    serialPort1.Write("MEASure:REAL?\r\n");
                }
                else if (GonderimSayaci == 6)
                {
                    if (StepIntervalCounter == 3)
                        GonderimSayaci = 7;
                    else
                    {
                        GonderimSayaci = 4;

                        if (Kanal_1_StepStartStop == 1 || Kanal_2_StepStartStop == 1)
                            StepIntervalCounter++;
                        else
                            StepIntervalCounter = 0;
                    }

                    serialPort1.Write("INP?\r\n");
                }
                else if(GonderimSayaci == 7)
                {
                    StepIntervalCounter = 0;
                    GonderimSayaci = 4;
                    Ch1StepLoadTest();
                    Ch2StepLoadTest();

                    if(Kanal_1_StepStartStop==1)
                    {
                        MeasurementVout         = Kanal_1_Gerilim;
                        MeasurementIout         = Kanal_1_Akim;
                        MeasurementPower        = Kanal_1_Guc;
                        MeasurementResistance   = Kanal_1_Ohm;

                        Graphic_Refresh_Values();
                    }
                    else if(Kanal_2_StepStartStop == 1)
                    {
                        MeasurementVout         = Kanal_2_Gerilim;
                        MeasurementIout         = Kanal_2_Akim;
                        MeasurementPower        = Kanal_2_Guc;
                        MeasurementResistance   = Kanal_2_Ohm;
                        
                        Graphic_Refresh_Values();
                    }
                }
            }
            else
                DisplayCounter++;
        }
        private void Ch1StepLoadTest()
        {
            if (Kanal_1_StepStartStop == 1)
            {
                if (Kanal_1_StepCounter == 0 || Kanal_1_StepCounter == 1)
                {
                    Kanal_1_StepWaitCounter = 0;
                    Kanal_1_RefAnlikDeger = 0;
                    serialPort1.Write("CURR CH1," + Kanal_1_RefAnlikDeger.ToString() + "\r\n");

                    Kanal_1_StepCounter++;
                }
                else if (Kanal_1_StepCounter == 2)
                {
                    serialPort1.Write("INP CH1,1\r\n");
                    Kanal_1_StepCounter = 3;
                }
                else if (Kanal_1_StepCounter == 3)
                {
                    if (Kanal_1_RefFinalDeger > (Kanal_1_RefAnlikDeger + Kanal_1_RefAdimDeger))
                    {
                        Kanal_1_RefAnlikDeger += Kanal_1_RefAdimDeger;
                    }
                    else
                    {
                        Kanal_1_RefAnlikDeger = Kanal_1_RefFinalDeger;
                        Kanal_1_StepCounter = 4;
                    }

                    Kanal_1_RefAnlikDegerString = (Kanal_1_RefAnlikDeger / 1000).ToString() + "." + ((Kanal_1_RefAnlikDeger % 1000) / 100).ToString() + ((Kanal_1_RefAnlikDeger % 100) / 10).ToString() + (Kanal_1_RefAnlikDeger % 10).ToString();

                    serialPort1.Write("CURR CH1," + Kanal_1_RefAnlikDegerString + "\r\n");
                }
                else if (Kanal_1_StepCounter == 4)
                {
                    if (Kanal_1_StepWaitCounter > 0)
                    {
                        Kanal_1_StepCounter = 5;
                        Kanal_1_StepWaitCounter = 0;
                    }
                    else
                    {
                        Kanal_1_StepWaitCounter++;
                    }
                }
                else if (Kanal_1_StepCounter == 5)
                {
                    serialPort1.Write("INP CH1,0\r\n");
                    Kanal_1_StepStartStop   = 0;
                    Kanal_1_StepCounter     = 0;

                    Ch1DummyLoadStopButton.PerformClick();
                }
            }
        }

        private void Ch2StepLoadTest()
        {
            if (Kanal_2_StepStartStop == 1)
            {
                if (Kanal_2_StepCounter == 0 || Kanal_2_StepCounter == 1)
                {
                    Kanal_2_StepWaitCounter     = 0;
                    Kanal_2_RefAnlikDeger       = 0;
                    serialPort1.Write("CURR CH2," + Kanal_2_RefAnlikDeger.ToString() + "\r\n");

                    Kanal_2_StepCounter++;
                }
                else if (Kanal_2_StepCounter == 2)
                {
                    serialPort1.Write("INP CH2,1\r\n");
                    Kanal_2_StepCounter = 3;
                }
                else if (Kanal_2_StepCounter == 3)
                {
                    if (Kanal_2_RefFinalDeger > (Kanal_2_RefAnlikDeger + Kanal_2_RefAdimDeger))
                    {
                        Kanal_2_RefAnlikDeger += Kanal_2_RefAdimDeger;
                    }
                    else
                    {
                        Kanal_2_RefAnlikDeger = Kanal_2_RefFinalDeger;
                        Kanal_2_StepCounter = 4;
                    }

                    Kanal_2_RefAnlikDegerString = (Kanal_2_RefAnlikDeger / 1000).ToString() + "." + ((Kanal_2_RefAnlikDeger % 1000) / 100).ToString() + ((Kanal_2_RefAnlikDeger % 100) / 10).ToString() + (Kanal_2_RefAnlikDeger % 10).ToString();

                    serialPort1.Write("CURR CH2," + Kanal_2_RefAnlikDegerString + "\r\n");
                }
                else if (Kanal_2_StepCounter == 4)
                {
                    if (Kanal_2_StepWaitCounter > 0)
                    {
                        Kanal_2_StepCounter = 5;
                        Kanal_2_StepWaitCounter = 0;
                    }
                    else
                    {
                        Kanal_2_StepWaitCounter++;
                    }
                }
                else if (Kanal_2_StepCounter == 5)
                {
                    serialPort1.Write("INP CH2,0\r\n");
                    Kanal_2_StepStartStop = 0;
                    Kanal_2_StepCounter = 0;

                    Ch2DummyLoadStopButton.PerformClick();
                }
            }
        }
        private void Ch1DummyLoadStartButton_Click(object sender, EventArgs e)
        {
            if (Ch1ShortSec.Checked == true)
            {
                Kanal_1_LoadModelFlag   = 6;
                Kanal_1_StartStopFlag   = 1;
            }
            else if(Ch1LoadingSec.Checked == true)
            {
                Kanal_1_RefFinalDeger   = Convert.ToInt32(Ch1LoadingTestValue.Value * 1000);
                Kanal_1_RefAdimDeger    = Convert.ToInt32(Ch1StepSize.Value * 1000);

                Kanal_1_StepStartStop   = 1;
                Kanal_1_StepCounter     = 0;

                yAxis1.Scale.Min = 0;
                yAxis2.Scale.Min = 0;

                list1.Clear();
                list2.Clear();

                Kanal_1_KesimGerilimi = Convert.ToInt32(Ch1CutoffRef.Value * 1000);
            }
            else
            {
                Kanal_1_RefSendFlag     = 1;
                Kanal_1_StartStopFlag   = 1;

                     if (Ch1LoadModel.SelectedIndex == 0) { Kanal_1_LoadModelFlag = 1; }
                else if (Ch1LoadModel.SelectedIndex == 1) { Kanal_1_LoadModelFlag = 2; }
                else if (Ch1LoadModel.SelectedIndex == 2) { Kanal_1_LoadModelFlag = 3; }
                else if (Ch1LoadModel.SelectedIndex == 3) { Kanal_1_LoadModelFlag = 4; }

                Kanal_1_KesimGerilimi = Convert.ToInt32(Ch1CutoffRef.Value * 1000);
            }

            Ch1DummyLoadStartButton.Enabled = false;
            Ch1DummyLoadStopButton.Enabled  = true;
            Ch1DummyLoadGroupBox.Enabled = false;
        }

        private void Ch1DummyLoadStopButton_Click(object sender, EventArgs e)
        {
            if (Ch1ShortSec.Checked == true)
            {
                Kanal_1_LoadModelFlag = 7;
                Kanal_1_StartStopFlag = 2;
            }
            else
            {
                Kanal_1_StepCounter   = 0;
                Kanal_1_StepStartStop = 0;

                Kanal_1_StartStopFlag = 2;
            }

            Ch1DummyLoadStartButton.Enabled = true;
            Ch1DummyLoadStopButton.Enabled = false;
            Ch1DummyLoadGroupBox.Enabled = true;
        }

        private void Ch2DummyLoadStartButton_Click(object sender, EventArgs e)
        {
            if (Ch2ShortSec.Checked == true)
            {
                Kanal_2_LoadModelFlag   = 6;
                Kanal_2_StartStopFlag   = 1;
            }
            else if(Ch2LoadingSec.Checked==true)
            {
                Kanal_2_RefFinalDeger = Convert.ToInt32(Ch2LoadingTestValue.Value * 1000);
                Kanal_2_RefAdimDeger = Convert.ToInt32(Ch2StepSize.Value * 1000);

                Kanal_2_StepStartStop   = 1;
                Kanal_2_StepCounter     = 0;

                yAxis1.Scale.Min = 0;
                yAxis2.Scale.Min = 0;

                list1.Clear();
                list2.Clear();

                Kanal_2_KesimGerilimi = Convert.ToInt32(Ch2CutoffRef.Value * 1000);
            }
            else
            {
                Kanal_2_RefSendFlag     = 1;
                Kanal_2_StartStopFlag   = 1;

                     if (Ch2LoadModel.SelectedIndex == 0) { Kanal_2_LoadModelFlag = 1; }
                else if (Ch2LoadModel.SelectedIndex == 1) { Kanal_2_LoadModelFlag = 2; }
                else if (Ch2LoadModel.SelectedIndex == 2) { Kanal_2_LoadModelFlag = 3; }
                else if (Ch2LoadModel.SelectedIndex == 3) { Kanal_2_LoadModelFlag = 4; }

                Kanal_2_KesimGerilimi = Convert.ToInt32(Ch2CutoffRef.Value * 1000);
            }

            Ch2DummyLoadStartButton.Enabled = false;
            Ch2DummyLoadStopButton.Enabled = true;
            Ch2DummyLoadGroupBox.Enabled = false;
        }

        private void Ch2DummyLoadStopButton_Click(object sender, EventArgs e)
        {
            if (Ch2ShortSec.Checked == true)
            {
                Kanal_2_LoadModelFlag = 7;
                Kanal_2_StartStopFlag = 2;
            }
            else
            {
                Kanal_2_StepCounter   = 0;
                Kanal_2_StepStartStop = 0;

                Kanal_2_StartStopFlag = 2;
            }

            Ch2DummyLoadStartButton.Enabled = true;
            Ch2DummyLoadStopButton.Enabled = false;
            Ch2DummyLoadGroupBox.Enabled = true;
        }

        private void Ch1LoadModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCh1LoadModelChange();
        }

        private void CheckCh1LoadModelChange()
        {
            if (Ch1LoadModel.SelectedIndex == 0) { Kanal_1_LoadModelFlag = 1; Ch1ConstantSec.Text = "Constant Current"; label23.Text = "A"; Ch1RefValue.Maximum = 20; if (Ch2LoadingSec.Checked == false) Ch1LoadingSec.Enabled = true; else Ch1LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = true; label22.Enabled = true; }
            else if (Ch1LoadModel.SelectedIndex == 1) { Kanal_1_LoadModelFlag = 2; Ch1ConstantSec.Text = "Constant Resist."; label23.Text = "Ω"; Ch1RefValue.Maximum = 1500; Ch1LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = false; label22.Enabled = false; if (Ch1LoadingSec.Checked == true) Ch1ConstantSec.Checked = true; }
            else if (Ch1LoadModel.SelectedIndex == 2) { Kanal_1_LoadModelFlag = 3; Ch1ConstantSec.Text = "Constant Power"; label23.Text = "W"; Ch1RefValue.Maximum = 200; Ch1LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = false; label22.Enabled = false; if (Ch1LoadingSec.Checked == true) Ch1ConstantSec.Checked = true; }
            else if (Ch1LoadModel.SelectedIndex == 3) { Kanal_1_LoadModelFlag = 4; Ch1ConstantSec.Text = "Constant Volt"; label23.Text = "V"; Ch1RefValue.Maximum = 150; Ch1LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = false; label22.Enabled = false; if (Ch1LoadingSec.Checked == true) Ch1ConstantSec.Checked = true; }
        }

        private void Ch2LoadModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCh2LoadModelChange();
        }

        private void CheckCh2LoadModelChange()
        {
            if (Ch2LoadModel.SelectedIndex == 0) { Kanal_2_LoadModelFlag = 1; Ch2ConstantSec.Text = "Constant Current"; label57.Text = "A"; Ch2RefValue.Maximum = 20; if (Ch1LoadingSec.Checked == false) Ch2LoadingSec.Enabled = true; else Ch2LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = true; label56.Enabled = true; }
            else if (Ch2LoadModel.SelectedIndex == 1) { Kanal_2_LoadModelFlag = 2; Ch2ConstantSec.Text = "Constant Resist."; label57.Text = "Ω"; Ch2RefValue.Maximum = 1500; Ch2LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = false; label56.Enabled = false; if (Ch2LoadingSec.Checked == true) Ch2ConstantSec.Checked = true; }
            else if (Ch2LoadModel.SelectedIndex == 2) { Kanal_2_LoadModelFlag = 3; Ch2ConstantSec.Text = "Constant Power"; label57.Text = "W"; Ch2RefValue.Maximum = 200; Ch2LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = false; label56.Enabled = false; if (Ch2LoadingSec.Checked == true) Ch2ConstantSec.Checked = true; }
            else if (Ch2LoadModel.SelectedIndex == 3) { Kanal_2_LoadModelFlag = 4; Ch2ConstantSec.Text = "Constant Volt"; label57.Text = "V"; Ch2RefValue.Maximum = 150; Ch2LoadingSec.Enabled = false; Ch1LoadingTestValue.Enabled = false; label56.Enabled = false; if (Ch2LoadingSec.Checked == true) Ch2ConstantSec.Checked = true; }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (Ch1ShortSec.Checked == true)
            {
                Ch1CutoffRef.Enabled = false;
                Ch1StepSize.Enabled = false;
                Ch1LoadModel.Enabled = false;
                Ch1RefValue.Enabled = false;
                Ch1LoadingTestValue.Enabled = false;
            }

            CheckCh1LoadModelChange();
            CheckCh2LoadModelChange();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (Ch1LoadingSec.Checked == true)
            {
                Ch1CutoffRef.Enabled = true;
                Ch1StepSize.Enabled = true;
                Ch1LoadModel.Enabled = true;
                Ch1RefValue.Enabled = true;
                Ch1LoadingTestValue.Enabled = true;

                label22.Visible = true;
                label23.Visible = false;
                Ch1RefValue.Visible = false;
                Ch1LoadingTestValue.Visible = true;

                if (Ch2LoadingSec.Checked == true)
                {
                    Ch1ConstantSec.Checked = true;
                }
                else
                {
                    Ch2LoadingSec.Enabled = false;
                }
            }
            else
            {
                Ch2LoadingSec.Enabled = true;

                label22.Visible = false;
                label23.Visible = true;
                Ch1RefValue.Visible = true;
                Ch1LoadingTestValue.Visible = false;
            }

            CheckCh1LoadModelChange();
            CheckCh2LoadModelChange();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (Ch1ConstantSec.Checked == true)
            {
                Ch1CutoffRef.Enabled = true;
                Ch1StepSize.Enabled = false;
                Ch1LoadModel.Enabled = true;
                Ch1RefValue.Enabled = true;
                Ch1LoadingTestValue.Enabled = true;
            }

            CheckCh1LoadModelChange();
            CheckCh2LoadModelChange();
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (Ch2ShortSec.Checked == true)
            {
                Ch2CutoffRef.Enabled = false;
                Ch2StepSize.Enabled = false;
                Ch2LoadModel.Enabled = false;
                Ch2RefValue.Enabled = false;
                Ch2LoadingTestValue.Enabled = false;
            }

            CheckCh1LoadModelChange();
            CheckCh2LoadModelChange();
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (Ch2ConstantSec.Checked == true)
            {
                Ch2CutoffRef.Enabled = true;
                Ch2StepSize.Enabled = false;
                Ch2LoadModel.Enabled = true;
                Ch2RefValue.Enabled = true;
                Ch2LoadingTestValue.Enabled = true;
            }

            CheckCh1LoadModelChange();
            CheckCh2LoadModelChange();
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (Ch2LoadingSec.Checked == true)
            {
                Ch2CutoffRef.Enabled = true;
                Ch2StepSize.Enabled = true;
                Ch2LoadModel.Enabled = true;
                Ch2RefValue.Enabled = true;
                Ch2LoadingTestValue.Enabled = true;

                label56.Visible = true;
                label57.Visible = false;
                Ch2RefValue.Visible = false;
                Ch2LoadingTestValue.Visible = true;

                if (Ch1LoadingSec.Checked == true)
                {
                    Ch2ConstantSec.Checked = true;
                }
                else
                {
                    Ch1LoadingSec.Enabled = false;
                }
            }
            else
            {
                Ch1LoadingSec.Enabled = true;

                label56.Visible = false;
                label57.Visible = true;
                Ch2RefValue.Visible = true;
                Ch2LoadingTestValue.Visible = false;
            }

            CheckCh1LoadModelChange();
            CheckCh2LoadModelChange();
        }
        #endregion

        string SerialPortReceivedText ="deneme";
        int DataGeldiFlag = 0;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SerialPortReceivedText = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
                //SetText(serialPort1.ReadExisting());

                DataGeldiFlag = 1;
            }
        }
        private void DisplayText(object sender, EventArgs e)
        {
            //textBox1.AppendText(SerialPortReceivedText);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (SerialPortReceivedText.Length>=5 && DataGeldiFlag==1)
            {
                DataGeldiFlag = 0;
                if ((SerialPortReceivedText[0]=='0' || SerialPortReceivedText[0]=='1') & (SerialPortReceivedText[1] == ';') & (SerialPortReceivedText[2] == '0' || SerialPortReceivedText[2] == '1'))
                {
                    StringParcala(1, SerialPortReceivedText);
                }
                else if (SerialPortReceivedText.Length>5 && SerialPortReceivedText.Length <= 15)
                {
                    if (SerialPortReceivedText[0]=='R' || SerialPortReceivedText[0]=='C' || SerialPortReceivedText[0] == 'V' || SerialPortReceivedText[0] == 'P')
                        StringParcala(2, SerialPortReceivedText);
                }
                else if (SerialPortReceivedText[0] == 'U' && SerialPortReceivedText[1] == 'N' && SerialPortReceivedText[2] == 'I')
                {
                    StringParcala(3, SerialPortReceivedText);
                }
                else if(SerialPortReceivedText.Length>55 && (SerialPortReceivedText[5]=='V' || SerialPortReceivedText[6] == 'V' || SerialPortReceivedText[7] == 'V'))
                {
                    StringParcala(4, SerialPortReceivedText);
                    textBox1.AppendText(SerialPortReceivedText);
                }
            }
        }

        private void StringParcala(int MesajTipi, string Mesaj)
        {
            int DummyCount;
            string Dummy1, Dummy2;

            if (MesajTipi == 1)
            {
                if (Mesaj[0] == '0') { ledBulb1.On = false; StatusLabel4.Text = "CH1: Off"; }
                else { ledBulb1.On = true; StatusLabel4.Text = "CH1: On"; }

                if (Mesaj[2] == '0') { ledBulb2.On = false; StatusLabel5.Text = "CH2: Off"; }
                else { ledBulb2.On = true; StatusLabel5.Text = "CH2: On"; }
            }
            else if (MesajTipi == 2)
            {
                StatusLabel3.ForeColor = Color.DarkGreen;

                if (Mesaj[0]=='C')
                {
                         if (Mesaj[5] == 'C') StatusLabel3.Text = "CH1: CURR - CH2: CURR";   // CURR;CURR
                    else if (Mesaj[5] == 'V') StatusLabel3.Text = "CH1: CURR - CH2: VOLT";   // CURR;VOLT
                    else if (Mesaj[5] == 'R') StatusLabel3.Text = "CH1: CURR - CH2: RES";    // CURR;RES
                    else if (Mesaj[5] == 'P') StatusLabel3.Text = "CH1: CURR - CH2: POW";    // CURR;POW
                    else if (Mesaj[5] == 'D') StatusLabel3.Text = "CH1: CURR - CH2: DYN";    // CURR;DYN
                }
                else if (Mesaj[0] == 'V')
                {
                         if (Mesaj[5] == 'C') StatusLabel3.Text = "CH1: VOLT - CH2: CURR";   // VOLT;CURR
                    else if (Mesaj[5] == 'V') StatusLabel3.Text = "CH1: VOLT - CH2: VOLT";   // VOLT;VOLT
                    else if (Mesaj[5] == 'R') StatusLabel3.Text = "CH1: VOLT - CH2: RES";    // VOLT;RES
                    else if (Mesaj[5] == 'P') StatusLabel3.Text = "CH1: VOLT - CH2: POW";    // VOLT;POW
                    else if (Mesaj[5] == 'D') StatusLabel3.Text = "CH1: VOLT - CH2: DYN";    // VOLT;DYN
                }
                else if (Mesaj[0] == 'R')
                {
                         if (Mesaj[4] == 'C') StatusLabel3.Text = "CH1: RES - CH2: CURR";    // RES;CURR
                    else if (Mesaj[4] == 'V') StatusLabel3.Text = "CH1: RES - CH2: VOLT";    // RES;VOLT
                    else if (Mesaj[4] == 'R') StatusLabel3.Text = "CH1: RES - CH2: RES";     // RES;RES
                    else if (Mesaj[4] == 'P') StatusLabel3.Text = "CH1: RES - CH2: POW";     // RES;POW
                    else if (Mesaj[5] == 'D') StatusLabel3.Text = "CH1: RES - CH2: DYN";     // RES;DYN
                }
                else if (Mesaj[0] == 'P')
                {
                         if (Mesaj[4] == 'C') StatusLabel3.Text = "CH1: POW - CH2: CURR";    // POW;CURR
                    else if (Mesaj[4] == 'V') StatusLabel3.Text = "CH1: POW - CH2: VOLT";    // POW;VOLT
                    else if (Mesaj[4] == 'R') StatusLabel3.Text = "CH1: POW - CH2: RES";     // POW;RES
                    else if (Mesaj[4] == 'P') StatusLabel3.Text = "CH1: POW - CH2: POW";     // POW;POW
                    else if (Mesaj[5] == 'D') StatusLabel3.Text = "CH1: POW - CH2: DYN";     // POW;DYN
                }
                else if (Mesaj[0] == 'D')
                {
                         if (Mesaj[4] == 'C') StatusLabel3.Text = "CH1: DYN - CH2: CURR";    // DYN;CURR
                    else if (Mesaj[4] == 'V') StatusLabel3.Text = "CH1: DYN - CH2: VOLT";    // DYN;VOLT
                    else if (Mesaj[4] == 'R') StatusLabel3.Text = "CH1: DYN - CH2: RES";     // DYN;RES
                    else if (Mesaj[4] == 'P') StatusLabel3.Text = "CH1: DYN - CH2: POW";     // DYN;POW
                    else if (Mesaj[5] == 'D') StatusLabel3.Text = "CH1: DYN - CH2: DYN";     // DYN;DYN
                }
            }
            else if (MesajTipi == 3)
            {
                StatusLabel2.Text = Mesaj.Split('\r')[0];
            }
            else if (MesajTipi == 4)
            {
                OlcumDegerleriStringParcala(Mesaj);
            }
        }

        Int32 Kanal_1_Gerilim;
        Int32 Kanal_1_Akim;
        Int32 Kanal_1_Guc;
        Int32 Kanal_1_Ohm;

        Int32 Kanal_2_Gerilim;
        Int32 Kanal_2_Akim;
        Int32 Kanal_2_Guc;
        Int32 Kanal_2_Ohm;
        private void OlcumDegerleriStringParcala(string Mesaj)
        {
            int DummyCounter_Volt1 = 0 ;
            int DummyCounter_Akim1 = 0 ;
            int DummyCounter_Guc1 = 0;
            int DummyCounter_Ohm1 = 0;

            int DummyCounter_Volt2 = 0;
            int DummyCounter_Akim2 = 0;
            int DummyCounter_Guc2 = 0;
            int DummyCounter_Ohm2 = 0;

            int OffsetData = 0;

            int DegerFault = 0;

            #region Kanal1 Olcumler

            for (; ; )
            {
                if (Mesaj[DummyCounter_Volt1] == 'V' && Mesaj[DummyCounter_Volt1 + 1] == ',')
                    break;
                else
                    DummyCounter_Volt1++;

                if(DummyCounter_Volt1 > 7)
                {
                    DegerFault = 1;
                    break;
                }
            }

            if (DummyCounter_Volt1 == 5)
                Kanal_1_Gerilim = (Convert.ToInt32(Mesaj[0] - 48) * 1000) + (Convert.ToInt32(Mesaj[2] - 48) * 100) + (Convert.ToInt32(Mesaj[3] - 48) * 10) + (Convert.ToInt32(Mesaj[4] - 48));
            else if (DummyCounter_Volt1 == 6)
                Kanal_1_Gerilim = (Convert.ToInt32(Mesaj[0] - 48) * 10000) + (Convert.ToInt32(Mesaj[1] - 48) * 1000) + (Convert.ToInt32(Mesaj[3] - 48) * 100) + (Convert.ToInt32(Mesaj[4] - 48) * 10) + (Convert.ToInt32(Mesaj[5] - 48));
            else if (DummyCounter_Volt1 == 7)
                Kanal_1_Gerilim = (Convert.ToInt32(Mesaj[0] - 48) * 100000) + (Convert.ToInt32(Mesaj[1] - 48) * 10000) + (Convert.ToInt32(Mesaj[2] - 48) * 1000) + (Convert.ToInt32(Mesaj[4] - 48) * 100) + (Convert.ToInt32(Mesaj[5] - 48) * 10) + (Convert.ToInt32(Mesaj[6] - 48));
            else
                Kanal_1_Gerilim = 0;

            Ch1_VoltSegment.Value = (Kanal_1_Gerilim / 100000).ToString() + ((Kanal_1_Gerilim % 100000) / 10000).ToString() + ((Kanal_1_Gerilim % 10000) / 1000).ToString() + "." + ((Kanal_1_Gerilim % 1000) / 100).ToString() + ((Kanal_1_Gerilim % 100) / 10).ToString() + (Kanal_1_Gerilim % 10).ToString();

            OffsetData = DummyCounter_Volt1 + 2;

            for (; ; )
            {
                if (Mesaj[DummyCounter_Akim1 + OffsetData] == 'A' && Mesaj[DummyCounter_Akim1 + OffsetData + 1] == ',')
                    break;
                else
                    DummyCounter_Akim1++;

                if (DummyCounter_Akim1 > 7)
                {
                    DegerFault = 1;
                    break;
                }
            }

            if (DummyCounter_Akim1 == 5)
                Kanal_1_Akim = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48));
            else if (DummyCounter_Akim1 == 6)
                Kanal_1_Akim = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48));
            else
                Kanal_1_Akim = 0;

            Ch1_AmpSegment.Value = ((Kanal_1_Akim % 100000) / 10000).ToString() + ((Kanal_1_Akim % 10000) / 1000).ToString() + "." + ((Kanal_1_Akim % 1000) / 100).ToString() + ((Kanal_1_Akim % 100) / 10).ToString() + (Kanal_1_Akim % 10).ToString();

            OffsetData = (DummyCounter_Volt1 + DummyCounter_Akim1 + 4);

            for (; ; )
            {
                if (Mesaj[DummyCounter_Guc1 + OffsetData] == 'W' && Mesaj[DummyCounter_Guc1 + OffsetData + 1] == ',')
                    break;
                else
                    DummyCounter_Guc1++;

                if (DummyCounter_Guc1 > 8)
                {
                    DegerFault = 1;
                    break;
                }
            }

            if (DummyCounter_Guc1 == 4)
                Kanal_1_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48));
            else if (DummyCounter_Guc1 == 5)
                Kanal_1_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48));
            else if (DummyCounter_Guc1 == 6)
                Kanal_1_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48));
            else if (DummyCounter_Guc1 == 7)
                Kanal_1_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 6] - 48));
            else
                Kanal_1_Guc = 0;

            Ch1_PowSegment.Value = ((Kanal_1_Guc % 100000) / 10000).ToString() + ((Kanal_1_Guc % 10000) / 1000).ToString() + ((Kanal_1_Guc % 1000) / 100).ToString() + "." + ((Kanal_1_Guc % 100) / 10).ToString() + (Kanal_1_Guc % 10).ToString();

            OffsetData = (DummyCounter_Volt1 + DummyCounter_Akim1 + DummyCounter_Guc1 + 6);

            for (; ; )
            {
                if (Mesaj[DummyCounter_Ohm1 + OffsetData] == 'o' && Mesaj[DummyCounter_Ohm1 + OffsetData + 1] == 'h' && Mesaj[DummyCounter_Ohm1 + OffsetData + 2]=='m')
                    break;
                else
                    DummyCounter_Ohm1++;

                if (DummyCounter_Ohm1 > 8)
                {
                    DegerFault = 1;
                    break;
                }
            }

            if (DummyCounter_Ohm1 == 4)
                Kanal_1_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48));
            else if (DummyCounter_Ohm1 == 5)
                Kanal_1_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48));
            else if (DummyCounter_Ohm1 == 6)
                Kanal_1_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48));
            else if (DummyCounter_Ohm1 == 7)
                Kanal_1_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 6] - 48));
            else
                Kanal_1_Ohm = 0;

            Ch1_ResSegment.Value = (Kanal_1_Ohm / 100000).ToString() + ((Kanal_1_Ohm % 100000) / 10000).ToString() + ((Kanal_1_Ohm % 10000) / 1000).ToString() + ((Kanal_1_Ohm % 1000) / 100).ToString() + "." + ((Kanal_1_Ohm % 100) / 10).ToString() + (Kanal_1_Ohm % 10).ToString();

            #endregion

            #region Kanal2 Olcumler

            OffsetData = (DummyCounter_Volt1 + DummyCounter_Akim1 + DummyCounter_Guc1 + DummyCounter_Ohm1 + 10);

            for (; ; )
            {
                if (Mesaj[DummyCounter_Volt2 + OffsetData] == 'V' && Mesaj[DummyCounter_Volt2 + OffsetData + 1] == ',')
                    break;
                else
                    DummyCounter_Volt2++;

                if (DummyCounter_Volt2 > 7)
                {
                    DegerFault = 1;
                    break;
                }
            }

            if (DummyCounter_Volt2 == 5)
                Kanal_2_Gerilim = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48));
            else if (DummyCounter_Volt2 == 6)
                Kanal_2_Gerilim = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48));
            else if (DummyCounter_Volt2 == 7)
                Kanal_2_Gerilim = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 6] - 48));
            else
                Kanal_2_Gerilim = 0;

            Ch2_VoltSegment.Value = (Kanal_2_Gerilim / 100000).ToString() + ((Kanal_2_Gerilim % 100000) / 10000).ToString() + ((Kanal_2_Gerilim % 10000) / 1000).ToString() + "." + ((Kanal_2_Gerilim % 1000) / 100).ToString() + ((Kanal_2_Gerilim % 100) / 10).ToString() + (Kanal_2_Gerilim % 10).ToString();

            OffsetData = (DummyCounter_Volt1 + DummyCounter_Akim1 + DummyCounter_Guc1 + DummyCounter_Ohm1 + DummyCounter_Volt2 + 12);

            for (; ; )
            {
                if (Mesaj[DummyCounter_Akim2 + OffsetData] == 'A' && Mesaj[DummyCounter_Akim2 + OffsetData + 1] == ',')
                    break;
                else
                    DummyCounter_Akim2++;

                if (DummyCounter_Akim2 > 7)
                {
                    DegerFault = 1;
                    break;
                }
            }

            if (DummyCounter_Akim2 == 5)
                Kanal_2_Akim = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48));
            else if (DummyCounter_Akim2 == 6)
                Kanal_2_Akim = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48));
            else
                Kanal_2_Akim = 0;

            Ch2_AmpSegment.Value = ((Kanal_2_Akim % 100000) / 10000).ToString() + ((Kanal_2_Akim % 10000) / 1000).ToString() + "." + ((Kanal_2_Akim % 1000) / 100).ToString() + ((Kanal_2_Akim % 100) / 10).ToString() + (Kanal_2_Akim % 10).ToString();

            OffsetData = (DummyCounter_Volt1 + DummyCounter_Akim1 + DummyCounter_Guc1 + DummyCounter_Ohm1 + DummyCounter_Volt2 + DummyCounter_Akim2 + 14);

            for (; ; )
            {
                if (Mesaj[DummyCounter_Guc2 + OffsetData] == 'W' && Mesaj[DummyCounter_Guc2 + OffsetData + 1] == ',')
                    break;
                else
                    DummyCounter_Guc2++;

                if (DummyCounter_Guc2 > 8)
                {
                    DegerFault = 1;
                    break;
                }
            }

            if (DummyCounter_Guc2 == 4)
                Kanal_2_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48));
            else if (DummyCounter_Guc2 == 5)
                Kanal_2_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48));
            else if (DummyCounter_Guc2 == 6)
                Kanal_2_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48));
            else if (DummyCounter_Guc2 == 7)
                Kanal_2_Guc = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 6] - 48));
            else
                Kanal_2_Guc = 0;

            Ch2_PowSegment.Value = ((Kanal_2_Guc % 100000) / 10000).ToString() + ((Kanal_2_Guc % 10000) / 1000).ToString() + ((Kanal_2_Guc % 1000) / 100).ToString() + "." + ((Kanal_2_Guc % 100) / 10).ToString() + (Kanal_2_Guc % 10).ToString();

            OffsetData = (DummyCounter_Volt1 + DummyCounter_Akim1 + DummyCounter_Guc1 + DummyCounter_Ohm1 + DummyCounter_Volt2 + DummyCounter_Akim2 + DummyCounter_Guc2 + 16);

            if (Mesaj.Length > (OffsetData + 7))
            {
                for (; ; )
                {
                    if (Mesaj[DummyCounter_Ohm2 + OffsetData] == 'o')// && Mesaj[DummyCounter_Ohm2 + OffsetData + 1] == 'h' && Mesaj[DummyCounter_Ohm2 + OffsetData + 2] == 'm')
                        break;
                    else
                        DummyCounter_Ohm2++;

                    if (DummyCounter_Ohm2 > 8)
                    {
                        DegerFault = 1;
                        break;
                    }
                }
            }

            if (DummyCounter_Ohm2 == 4)
                Kanal_2_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48));
            else if (DummyCounter_Ohm2 == 5)
                Kanal_2_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48));
            else if (DummyCounter_Ohm2 == 6)
                Kanal_2_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 4] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48));
            else if (DummyCounter_Ohm2 == 7)
                Kanal_2_Ohm = (Convert.ToInt32(Mesaj[OffsetData + 0] - 48) * 100000) + (Convert.ToInt32(Mesaj[OffsetData + 1] - 48) * 10000) + (Convert.ToInt32(Mesaj[OffsetData + 2] - 48) * 1000) + (Convert.ToInt32(Mesaj[OffsetData + 3] - 48) * 100) + (Convert.ToInt32(Mesaj[OffsetData + 5] - 48) * 10) + (Convert.ToInt32(Mesaj[OffsetData + 6] - 48));
            else
                Kanal_2_Ohm = 0;

            Ch2_ResSegment.Value = (Kanal_2_Ohm / 100000).ToString() + ((Kanal_2_Ohm % 100000) / 10000).ToString() + ((Kanal_2_Ohm % 10000) / 1000).ToString() + ((Kanal_2_Ohm % 1000) / 100).ToString() + "." + ((Kanal_2_Ohm % 100) / 10).ToString() + (Kanal_2_Ohm % 10).ToString();

            #endregion

            if(Kanal_1_KesimGerilimi> Kanal_1_Gerilim)
            {
                Ch1DummyLoadStopButton.PerformClick();
            }

            if (Kanal_2_KesimGerilimi > Kanal_2_Gerilim)
            {
                Ch2DummyLoadStopButton.PerformClick();
            }
        }

        int Kanal_1_KesimGerilimi;
        int Kanal_2_KesimGerilimi;
        private void Ch1CutoffRef_ValueChanged(object sender, EventArgs e)
        {
            Kanal_1_KesimGerilimi = Convert.ToInt32(Ch1CutoffRef.Value * 1000);
        }

        private void Ch2CutoffRef_ValueChanged(object sender, EventArgs e)
        {
            Kanal_2_KesimGerilimi = Convert.ToInt32(Ch2CutoffRef.Value * 1000);
        }

        private void Graphic_Refresh_Values()
        {
            double X_Value;
            double Y1_Value;
            double Y2_Value;

                 if (X_Name == "Current [A]")       X_Value = (Convert.ToDouble(MeasurementIout)       / 1000  ) * X_MulDiv;
            else if (X_Name == "Power [W]")         X_Value = (Convert.ToDouble(MeasurementPower)      / 100   ) * X_MulDiv;
            else if (X_Name == "Resistance [Ω]")    X_Value = (Convert.ToDouble(MeasurementResistance) / 100   ) * X_MulDiv;
            else                                    X_Value = (Convert.ToDouble(MeasurementVout)       / 1000  ) * X_MulDiv;

                 if (Y1_Name == "Current [A]")      Y1_Value = (Convert.ToDouble(MeasurementIout)       / 1000) * Y1_MulDiv;
            else if (Y1_Name == "Power [W]")        Y1_Value = (Convert.ToDouble(MeasurementPower)      / 100)  * Y1_MulDiv;
            else if (Y1_Name == "Resistance [Ω]")   Y1_Value = (Convert.ToDouble(MeasurementResistance) / 100)  * Y1_MulDiv;
            else                                    Y1_Value = (Convert.ToDouble(MeasurementVout)       / 1000) * Y1_MulDiv;
            
                 if (Y2_Name == "Current [A]")      Y2_Value = (Convert.ToDouble(MeasurementIout)       / 1000) * Y2_MulDiv;
            else if (Y2_Name == "Power [W]")        Y2_Value = (Convert.ToDouble(MeasurementPower)      / 100)  * Y2_MulDiv;
            else if (Y2_Name == "Resistance [Ω]")   Y2_Value = (Convert.ToDouble(MeasurementResistance) / 100)  * Y2_MulDiv;
            else                                    Y2_Value = (Convert.ToDouble(MeasurementVout)       / 1000) * Y2_MulDiv;

            list1.Add(X_Value, Y1_Value);
            list2.Add(X_Value, Y2_Value);

            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }
    }
}
