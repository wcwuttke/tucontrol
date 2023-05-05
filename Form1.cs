using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tucontrol
{
    public partial class Form1 : Form
    {
        bool startup = false;
        string[] ST8000_Commands = {"FRPAN    : FP  : Set Front Panel Mode",
                                    "DIRCONT  : DC  : Set Direct Control Mode",
                                    "HELP     : H   : List All Commands",
                                    "ECHO     : EC  : ON,OFF : Remote Terminal Echo",
                                    "STATUS   : ST  : List All Parameters",
                                    "STB      : STB : List Q and BW Parameters",
                                    "STC      : STC : List Switch Settings",
                                    "STM      : STM : List Memory Parameters",
                                    "STQ      : STQ : List Q and BW Parameters",
                                    "STT      : STT : List Tone Parameters",
                                    "DETMODE  : DM  : *AM,FM,MS,MP,MO,SO : Set Detector Mode",
                                    "ANTSPACE : AS  : *ON,OFF : Set Antispace Mode",
                                    "POLARITY : PO  : *NORM,REV : Set Polarity",
                                    "REGEN    : REG : *OFF,AA,AB,BA,BB : Set Regen Mode",
                                    "TRACK    : TR  : *ON,OFF : Set Track Mode",
                                    "MARK     : MA  : *[xxxx] : Set RX Mark Frequency",
                                    "SPACE    : SP  : *[xxxx] : Set RX Space Frequency",
                                    "CENTER   : C   : *[xxxx] : Set RX Center Frequency",
                                    "SHIFT    : SH  : *[xxxx] : Set RX Shift Frequency",
                                    "EXCHANGE : EX  : Exchange RX Mark/Space",
                                    "TX MARK  : XMA : *[xxxx] : Set TX Mark Frequency",
                                    "TX SPACE : XSP : *[xxxx] : Set TX Space Frequency",
                                    "TX CNTR  : XC  : *[xxxx] : Set TX Center Frequency",
                                    "TX SHIFT : XSH : *[xxxx] : Set TX Shift Frequency",
                                    "TX=RX    : TX= : Set TX=RX Frequencies",
                                    "RX=TX    : RX= : Set RXTX Frequencies",
                                    "TXLOCK   : TXL : ON,OFF : Lock TX to RX Frequencies",
                                    "MARK Q   : QM  : *[xxxx] : Set RX Mark Filter Q",
                                    "SPACE Q  : QS  : *[xxxx] : Set RX Space Filter Q",
                                    "INPUT Q  : QI  : *[xxxx] : Set RX Input Filter Q",
                                    "LOWPASS  : LP  : *[xxxx] : Set RX Lowpass Frequency",
                                    "INBAUD   : IB  : *[xxxx] : Set Input Baud Rate",
                                    "OUTBAUD  : OB  : *[xxxx] : Set Output Baud Rate",
                                    "LOADMEM  : LM  : *1-8 : Load Memory Parameters",
                                    "SAVEMEM  : SM  : *1-8 : Save Memory Parameters",
                                    "QBF      : QBF : ON,OFF : Send QBF Test Message",
                                    "RY       : RY  : ON,OFF : Send RYRY... Test Message",
                                    "SEL-CAL  : SC  : *ON,OFF : Turn SEL-CAL On/Off",
                                    "SEL-CAL  : SCON  : *[zzzz] : Set SEL-CAL ON Char.",
                                    "SEL-CAL  : SCOFF : *[wwww] : Set SEL-CAL OFF Char.",
                                    "SEL-CAL  : SCC : A,B : Select ASCII/Baudot SC",
                                    "PRINT    : PR  : *ON,AUTO : ON=Defeat SC and PR SQ",
                                    "CRT      : CRT : *ON,AUTO : ON=Defeat Auto CRT Control",
                                    "BYE      : BYE : No Change Exit",
                                    "RESET    : RES : Full uP Reset"
        };

        string[] ST8000A_Commands = {"A0 : Disable Receive AMH",
                                     "A1 : Enable Receive AMH",
                                     "B  : Bxxxx : Set Baud Rate",
                                     "C  : Cxx : Select Channel",
                                     "G  : Show Channel Status",
                                     "G1 : Show Channel 1 Status",
                                     "G2 : Show Channel 2 Status",
                                     "G3 : Show Jumper & Switch Settings",
                                     "G4 : Show Modem Status",
                                     "G5 : Show System Information",
                                     "H0 : Disable channel HOLD",
                                     "H1 : Enable Channel HOLD",
                                     "J0 : Select FSK Mode",
                                     "J1 : Select MARK ONLY Receive Mode (DEMOD ONLY)",
                                     "J2 : Select SPACE ONLY Receive Mode (DEMOD ONLY)",
                                     "J3 : Select FSK Mode",
                                     "K  : Kxxxx : Set CENTER Frequency",
                                     "N0 : NORMAL Channel Polarity",
                                     "N1 : REVERSE Channel Polarity",
                                     "P0 : Set Channel 1 & 2 To Factory Defaults",
                                     "P1 : COPY channel 1 Parameters into Channel 2",
                                     "P2 : COPY channel 2 Parameters into Channel 1",
                                     "Q0 : Select MARK/SPACE Display Mode",
                                     "Q1 : Select CENTER/SHIFT Display Mode",
                                     "R0 : LOCAL Mode",
                                     "R1 : REMOTE Mode",
                                     "S  : Sxxxx : Set SPACE Frequency",
                                     "T  : Show TEST Status",
                                     "T0 : Stop all BIT Tests",
                                     "T1 : Activate Automatic BIT",
                                     "T2 : Transmit Constant MARK Tone",
                                     "T3 : Transmit Constant SPACE Tone",
                                     "T4 : Transmit Alternating MARK/SPACE At BAUD Rate",
                                     "T5 : Enable Analog Loopback At 0 dBm",
                                     "T6 : Enable Analog Loopback At -20 dBm",
                                     "T7 : Enable Analog Loopback At -45 dBm",
                                     "T9 : Activate the BIT Menu",
                                     "U0 : Disable Transmit Tone MUTE",
                                     "U1 : Enable Transmit Tone MUTE",
                                     "V  : Vxxxx : Set SHIFT",
                                     "W0 : Select SYNCHRONOUS Mode",
                                     "W5 : Select ASYNCHRONOUS Mode, 5 Bit Chars.",
                                     "W6 : Select ASYNCHRONOUS Mode, 6 Bit Chars.",
                                     "W7 : Select ASYNCHRONOUS Mode, 7 Bit Chars.",
                                     "W8 : Select ASYNCHRONOUS Mode, 8 Bit Chars.",
                                     "X0 : Disable Remote Port ECHO",
                                     "X1 : Enable Remote Port ECHO",
                                     "Y0 : Disable Receive REGENERATION",
                                     "Y1 : Enable Receive REGENERATION"
        };
        public Form1()
        {
            InitializeComponent();
            rbToneHI.Checked = true;
            rbShift170.Checked = true;
            rb45.Checked = true;
            rbNorm.Checked = true;
            rbST8000.Checked = true;
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceivedHandler);
            var ports = SerialPort.GetPortNames();
            comboBox1.DataSource = ports;
            cbCmdList.DataSource = ST8000_Commands;
            startup = true;
        }

        private void rbToneLO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNorm.Checked == true)     // Normal Polarity
            {
                if (rbToneHI.Checked) lMark.Text = "2125";
                else lMark.Text = "1275";
                if (rbShift170.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 170).ToString();
                else if (rbShift425.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 425).ToString();
                else if (rbShift450.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 450).ToString();
                else if (rbShift850.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 850).ToString();
            }
            else  // Reverse Polarity
            {
                if (rbToneHI.Checked) lSpace.Text = "2125";
                else lSpace.Text = "1275";
                if (rbShift170.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 170).ToString();
                else if (rbShift425.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 425).ToString();
                else if (rbShift450.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 450).ToString();
                else if (rbShift850.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 850).ToString();
            }
            updateModem();
        }

        private void rbShift170_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShift170.Checked == true)
            {
                if(rbNorm.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 170).ToString();
                else
                    lMark.Text = (Int16.Parse(lSpace.Text) + 170).ToString();
                updateModem();
            }
        }

        private void rbShift425_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShift425.Checked == true)
            {
                if (rbNorm.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 425).ToString();
                else
                    lMark.Text = (Int16.Parse(lSpace.Text) + 425).ToString();
                updateModem();
            }
        }

        private void rbShift450_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShift450.Checked == true)
            {
                if (rbNorm.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 450).ToString();
                else
                    lMark.Text = (Int16.Parse(lSpace.Text) + 450).ToString();
                updateModem();
            }
        }

        private void rbShift850_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShift850.Checked == true)
            {
                if (rbNorm.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 850).ToString();
                else
                    lMark.Text = (Int16.Parse(lSpace.Text) + 850).ToString();
                updateModem();
            }
        }

        private void updateModem()
        {
            string cmd_string = "";
            if (rbST8000.Checked == true)
            {
                // TRACKING OFF, RX MARK, RX SPACE, TX = RX, IN BAUD, OUT BAUD
                cmd_string = "TR OFF; MA" + lMark.Text + ";SP" + lSpace.Text + ";TX=; " +
                             "IB" + lBaud.Text + ";OB" + lBaud.Text + "\r";
            }
            else  // ST-8000A
            {
                // Ch1 (demod), MARK Freq, SPACE Freq, BAUD, Copy Ch1 to Ch2
                cmd_string = "C1M" + lMark.Text + "S" + lSpace.Text + "B" + lBaud.Text + "P1\r";
            }
            if(serialPort1.IsOpen)
                serialPort1.WriteLine(cmd_string);
        }

        private void updateBaud()
        {
            string cmd_string = "";
            if (rbST8000.Checked == true)
            {
                cmd_string = "IB" + lBaud.Text + ";OB" + lBaud.Text + "\r";
            }
            else // ST-8000A
            {
                cmd_string = "C1B" + lBaud.Text + "P1\r";
            }
            Console.WriteLine(cmd_string);
            if (serialPort1.IsOpen)
                serialPort1.WriteLine(cmd_string);
        }
        private void DisplayText(object sender, EventArgs e)
        {
        }

        private void DataReceivedHandler(
            object sender,
            SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.Write(indata);
            this.Invoke(new MethodInvoker(() => textBox1.AppendText(indata)));
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
            // COM PORT 9600,N,1
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            if (startup == true)
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    groupBox3.ForeColor = Color.Red;
                    groupBox3.Text = "Modem - Error: " + ex.Message;
                }
            }
            else
                startup = false;
            if (serialPort1.IsOpen == true)
            {
                groupBox3.ForeColor = Color.Black;
                groupBox3.Text = "Modem - Connected";
                // Send modem startup parameters
                String cmd_string;
                if (rbST8000.Checked == true)
                {
                    // FRONT PANEL MODE, ECHO ON, TRACK OFF, TXLOCK OFF
                    cmd_string = "FP;EC ON;TR OFF;TXL OFF\r";
                }
                else  //ST-8000A
                {
                    // REMOTE Mode, CHANNEL 1 (demod), ECHO ON
                    cmd_string = "R1C1X1\r";
                }
                serialPort1.WriteLine(cmd_string);
                updateModem();
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.WriteLine(textBox2.Text + "\r");
        }

        private void bStatus_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (rbST8000.Checked == true)
                    serialPort1.WriteLine("STATUS\r");
                else  //ST-8000A
                    serialPort1.WriteLine("C1G1G2\r");
            }
        }

        private void rbNorm_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNorm.Checked == true)  // Normal Polarity
            {
                if (rbToneHI.Checked) lMark.Text = "2125";
                else lMark.Text = "1275";
                if (rbShift170.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 170).ToString();
                else if (rbShift425.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 425).ToString();
                else if (rbShift450.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 450).ToString();
                else if (rbShift850.Checked == true)
                    lSpace.Text = (Int16.Parse(lMark.Text) + 850).ToString();
            }
            else // Reverse Polarity
            {
                if (rbToneHI.Checked) lSpace.Text = "2125";
                else lSpace.Text = "1275";
                if (rbShift170.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 170).ToString();
                else if (rbShift425.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 425).ToString();
                else if (rbShift450.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 450).ToString();
                else if (rbShift850.Checked == true)
                    lMark.Text = (Int16.Parse(lSpace.Text) + 850).ToString();
            }
            updateModem();
        }

        private void rb45_CheckedChanged(object sender, EventArgs e)
        {
            if (rb45.Checked == true)
            {
                lBaud.Text = "045";
                updateBaud();
            }
        }

        private void rb50_CheckedChanged(object sender, EventArgs e)
        {
            if (rb50.Checked == true)
            {
                lBaud.Text = "050";
                updateBaud();
            }
        }

        private void rb57_CheckedChanged(object sender, EventArgs e)
        {
            if (rb57.Checked == true)
            {
                lBaud.Text = "057";
                updateBaud();
            }
        }

        private void rb75_CheckedChanged(object sender, EventArgs e)
        {
            if (rb75.Checked == true)
            {
                lBaud.Text = "075";
                updateBaud();
            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string cmd_string = "";

            if (rbST8000.Checked == true) cmd_string = "BYE";   // ST-8000 No Change Quit
            else cmd_string = "R0";     // ST-8000A LOCAL mode
            {
                if (serialPort1.IsOpen)
                    serialPort1.WriteLine(cmd_string + "\r");
                else
                {
                    serialPort1.Open();
                    serialPort1.WriteLine(cmd_string + "\r");
                    serialPort1.Close();
                }
            }
        }

        private void bCmdList_Click(object sender, EventArgs e)
        {
            if (rbST8000.Checked == true)
                cbCmdList.DataSource = ST8000_Commands;
            else
                cbCmdList.DataSource = ST8000A_Commands;
            cbCmdList.SelectedItem = null;
            cbCmdList.Visible = true;
        }

        private void cbCmdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCmdList.Visible == true)
            {
                string cmd = cbCmdList.SelectedItem.ToString();
                if(rbST8000.Checked == true)    //ST-8000
                    textBox2.Text = cmd.Split(':')[1].Trim();
                else                            // ST-8000A
                    textBox2.Text = cmd.Split(':')[0].Trim();
                cbCmdList.Visible = false;
            }
        }
    }
}
