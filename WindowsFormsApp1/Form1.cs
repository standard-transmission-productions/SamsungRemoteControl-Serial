using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort sp;
        byte[] bytestosend = new byte[6];
        Button[] buttonLists;
        Panel[] pages;
        byte header, command, id, dataLength, data, checksum;
        bool inputError = true;
        string portNum = "";
        int boundRate = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void connectTV(string port,int rate) {
            sp = new SerialPort();
            sp.PortName = port;
            sp.BaudRate = rate;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Open();

        }

        private void close() {
            if (sp.IsOpen) {
                sp.Close();
                sp.Dispose();
                sp = null;
            }
        }

        void SendCommandLine(string port, int rate, byte head, byte com, byte id, byte datalength, byte data, byte sum) {
            connectTV(port,rate);
            //byte[] bytestosend = { 0xAA, 0x11, 0x00, 0x01, 0x01, 0x13 };
            //sp.Write(bytestosend, 0, bytestosend.Length);
            senCommand(header, command, id, dataLength, data, checksum);
            
            close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonLists =new Button[5] {connect,off,hdmi1,hdmi2,hdmi3};
            pages = new Panel[2] {page1,page2};
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                //Debug.WriteLine(port);
                comPortList.Items.Add(port);
            }
            //connectTV();
            header = 0xAA;
            command = 0x11;
            id = 0x00;
            dataLength = 0x01;
            data = 0x01;
            //Debug.WriteLine(Convert.ToString(header, 16));
            checksum = getchecksum(command,id,dataLength,data);
            //Debug.WriteLine("checksum: " + Convert.ToString(checksum, 16));
        }

        private void connectTV()
        {
            throw new NotImplementedException();
        }

        byte getchecksum(byte com,byte id,byte datalength,byte data) {
            byte all = 0x00;
            byte[] list = {com,id,datalength,data};
            for (int i = 0; i < list.Length; i++) {
                all += list[i];
            }
            int total = all % ((int)Math.Pow(16, 2));
            all = decToHex(total);
            return all;
        }

        byte decToHex(int input) {
            byte outdata = 0;
            string hexval = input.ToString("X3");
            //Debug.WriteLine(hexval);
            outdata = byte.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            return outdata;
        }

        void senCommand(byte head,byte com, byte id, byte datalength, byte data,byte sum)
        {
            //Debug.WriteLine("inputError: " + inputError);
            if (inputError)
            {
                MessageBox.Show("Please Enter TV ID First!");
                for (int i = 0; i < buttonLists.Length; i++)
                {
                    buttonLists[i].Enabled = true;
                }
            }
            else {
                sum = getchecksum(command, id, dataLength, data);
                byte[] line = { head, com, id, dataLength, data, sum };
                //byte[] test = { 0xAA, 0x11, 0x00, 0x01, 0x01, 0x13 };
                for (int i = 0; i < line.Length; i ++ ) {
                    //if (line[i] == test[i]) {
                        Debug.WriteLine(line[i].ToString("X3"));
                    //}  
                }
                
                sp.Write(line, 0, line.Length);
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            command = 0x11;
            data = 0x01;
            SendCommandLine(portNum, boundRate, header, command, id, dataLength, data, checksum);

            //byte[] bytestosend = { 0xAA, 0x11, id, 0x01, command, checksum };
            ////bytestosend = commandLine(header, command, id, dataLength, data, checksum);
            //sp.Write(bytestosend, 0, bytestosend.Length);
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(comPortList.SelectedItem);
            Debug.WriteLine(inputRate.Text);
            if (comPortList.SelectedItem != null && inputRate.Text != string.Empty)
            {
                //connectTV(comPortList.SelectedItem.ToString(), Int32.Parse(inputRate.Text));
                portNum = comPortList.SelectedItem.ToString();
                
                boundRate = Int32.Parse(inputRate.Text);
                pages[1].BringToFront();
                //if (sp.IsOpen)
                //{
                //    pages[1].BringToFront();
                //}
                //else
                //{
                //    MessageBox.Show("Port is not connected, Please choose the right port!");
                //}
            }
            else {
                MessageBox.Show("Please fill in port and rate!");
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            //close();
            comPortList.SelectedItem = null;
            comPortList.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                //Debug.WriteLine(port);
                comPortList.Items.Add(port);
            }
            
            //comPortList.SelectedText = "test";
            inputRate.Text = string.Empty;
            pages[0].BringToFront();
        }


        private void off_Click(object sender, EventArgs e)
        {
            //sp = new SerialPort();
            //sp.PortName = "COM4";
            //sp.BaudRate = 9600;
            //sp.Parity = Parity.None;
            //sp.StopBits = StopBits.One;
            //sp.Open();
            //byte[] bytestosend = { 0xAA, 0x11, 0x01, 0x01, 0x00, 0x13 };
            
            //sp.Write(bytestosend, 0, bytestosend.Length);
            command = 0x11;
            data = 0x00;
            SendCommandLine(portNum, boundRate, header, command, id, dataLength, data, checksum);
            //senCommand(header, command, id, dataLength, data, checksum);
            //close();

        }


        private void hdmi1_Click(object sender, EventArgs e)
        {
            //sp = new SerialPort();
            //sp.PortName = "COM4";
            //sp.BaudRate = 9600;
            //sp.Parity = Parity.None;
            //sp.StopBits = StopBits.One;
            //sp.Open();
            //byte[] bytestosend = { 0xAA, 0x14, 0x01, 0x01, 0x21, 0x37 };
            //sp.Write(bytestosend, 0, bytestosend.Length);
            command = 0x14;
            data = 0x21;
            //senCommand(header, command, id, dataLength, data, checksum);
            SendCommandLine(portNum, boundRate, header, command, id, dataLength, data, checksum);
            //sp.Close();
            //sp.Dispose();
            //sp = null;
        }

        private void hdmi2_Click(object sender, EventArgs e)
        {
            //sp = new SerialPort();
            //sp.PortName = "COM4";
            //sp.BaudRate = 9600;
            //sp.Parity = Parity.None;
            //sp.StopBits = StopBits.One;
            //sp.Open();
            //byte[] bytestosend = { 0xAA, 0x14, 0x01, 0x01, 0x23, 0x39 };
            //sp.Write(bytestosend, 0, bytestosend.Length);
            command = 0x14;
            data = 0x23;
            SendCommandLine(portNum, boundRate, header, command, id, dataLength, data, checksum);
            //senCommand(header, command, id, dataLength, data, checksum);

            //sp.Close();
            //sp.Dispose();
            //sp = null;
        }

        private void hdmi3_Click(object sender, EventArgs e)
        {
            //sp = new SerialPort();
            //sp.PortName = "COM4";
            //sp.BaudRate = 9600;
            //sp.Parity = Parity.None;
            //sp.StopBits = StopBits.One;
            //sp.Open();
            //byte[] bytestosend = { 0xAA, 0x14, 0x01, 0x01, 0x31, 0x47 };
            //sp.Write(bytestosend, 0, bytestosend.Length);
            command = 0x14;
            data = 0x31;
            //senCommand(header, command, id, dataLength, data, checksum);
            SendCommandLine(portNum, boundRate, header, command, id, dataLength, data, checksum);
            //sp.Close();
            //sp.Dispose();
            //sp = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (textBox1.Text != null)
            {
                if (int.TryParse(textBox1.Text, out number))
                {
                    inputError = false;
                    id = decToHex(number);
                    //Debug.WriteLine("id: " + id);
                    
                }
                else
                {
                    MessageBox.Show("Please Enter TV ID number!");
                    textBox1.Text = string.Empty;
                    inputError = true;
                }
            }
            else {
                inputError = true;
            }
            //Debug.WriteLine(id);
        }
    }
}
