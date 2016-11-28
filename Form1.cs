using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            label1.Text = textBox1.Text;//รับข้อมูล จาก label1.text มาแสดง textBox1.text
            if (radioButton1.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton1.Checked
            {
                label2.Text = "ชาย"; //label2.text จะแสดงค่าา เพศชาย
            }
            if (radioButton2.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton2.Checked
            {
                label2.Text = "หญิง";//label2.text จะแสดงค่าา เพศหญิง
            }
            {
                string userSelected = null;
                userSelected = dpt1.Value.ToString();
                dpt1.Format = DateTimePickerFormat.Custom;
                dpt1.CustomFormat = "dd mm yyyy hh mm";//

                
                
                label16.Text = dpt1.Value.ToString();//แสดงdpt1 ให้มีค่าเท่ากับ label16.text
            }
            {
                string userSelected = null;//ช่องว่าง
                userSelected = dpt2.Value.ToString();//แปลงค่าจากช่องว่างเป็น dpt2
                dpt2.Format = DateTimePickerFormat.Custom;//กำหนดวันที่ที่ลูกค้ามาคืนรถ
                dpt2.CustomFormat = "dd mm yyyy hh mm";//วัน เดือน ปี ชั่วโมง นาที  

               
                {

                    
                    string d1 = "";//กำหนด d1
                    
                    
                    d1 = dpt1.Value.ToString();//แปลงค่าจากตัวเลขเป็นตัวอักษร
                    

                    
                    string d2 = "";//กำหนด d2
                    int h = Convert.ToInt32(textBox2.Text);//แปลงข้อมูลเป็นตัวเลข
                    d2 = dpt2.Value.AddHours(h).ToString();//เพิ่มชั่วโมง

                    
                    string day = (d1 + d2);//คำนวน
                    label18.Text = Convert.ToString(d2);//แสดง label18 ให้แปลงเป็นตัวเลขแล้วแสดงใน label18

                    
                }

               
            }
                
                
                 

            double rakah = 0, kun = 0, pub = 0;//กำหนดตัวแปร
            kun = Convert.ToDouble(textBox3.Text);//แปลงค่า kon ให้มีค่าเท่ากับ textBox2.Text
            if (radioButton3.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton1.Checked
            {
                switch (textBox2.Text)// เงื่อนไขของ textBox2.Text
                {
                    case "1": rakah = 50;  break;//กำหนด case 1 rakah จะมีค่าเท่ากับ 50
                    case "2": rakah = 100; break;//กำหนด case 2 rakah จะมีค่าเท่ากับ 100
                    case "3": rakah = 150; break;//กำหนด case 3 rakah จะมีค่าเท่ากับ 150                   
                    case "4": rakah = 200; break;//กำหนด case 4 rakah จะมีค่าเท่ากับ 200
                    case "5": rakah = 250; break;//กำหนด case 5 rakah จะมีค่าเท่ากับ 250
                    case "6": rakah = 300; break;//กำหนด case 6 rakah จะมีค่าเท่ากับ 300
                    case "7": rakah = 350; break;//กำหนด case 7 rakah จะมีค่าเท่ากับ 350
                    case "8": rakah = 400; break;//กำหนด case 8 rakah จะมีค่าเท่ากับ 400
                    case "9": rakah = 450; break;//กำหนด case 9 rakah จะมีค่าเท่ากับ 450
                    case "10": rakah = 500; break;//กำหนด case 10 rakah จะมีค่าเท่ากับ 500
                    case "11": rakah = 550; break;//กำหนด case 11 rakah จะมีค่าเท่ากับ 550
                    case "12": rakah = 600; break;//กำหนด case 12 rakahจะมีค่าเท่ากับ 600
                    
                }
                switch (textBox4.Text)// เงื่อนไขของ combobox1.Text
                {
                    case "1": pub = 50; break;//กำหนด case 1 pub จะมีค่าเท่ากับ 50
                    case "2": pub = 100; break;//กำหนด case 2 pub จะมีค่าเท่ากับ 100
                    case "3": pub = 150; break;//กำหนด case 3 pub จะมีค่าเท่ากับ 150
                    case "4": pub = 200; break;//กำหนด case 4 pub จะมีค่าเท่ากับ 200
                    case "5": pub = 250; break;//กำหนด case 5 pub จะมีค่าเท่ากับ 250
                    case "6": pub = 300; break;//กำหนด case 6 pub จะมีค่าเท่ากับ  300
                    
                }
                double raka = (rakah * kun);//รับข้อมูลที่ได้มาคำนวน
                double raka1 = (pub * kun);//รับขอมูลที่ได้มาคำนวน
                double raka2 = (raka + raka1);//รับข้อมูลที่ได้มาคำนวน
                rom.Text = Convert.ToString(raka2);//แสดง rom ใน raka2


                

            }
            if (radioButton4.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton4.Checked
            {
                switch (textBox2.Text)// เงื่อนไขของ textbox2.Text
                {
                    case "1": rakah = 250; break;//กำหนด case 1 rakah จะมีค่าเท่ากับ 250
                    case "2": rakah = 500; break;//กำหนด case 2 rakah จะมีค่าเท่ากับ 500
                    case "3": rakah = 750; break;//กำหนด case 3 rakah จะมีค่าเท่ากับ 750
                    case "4": rakah = 1000; break;//กำหนด case 4 rakah จะมีค่าเท่ากับ 1000
                    case "5": rakah = 1250; break;//กำหนด case 5 rakah จะมีค่าเท่ากับ 1250
                    
                }
                switch (textBox4.Text)// เงื่อนไขของ combobox1.Text
                {
                    case "1": pub = 50; break;//กำหนด case 1 pub จะมีค่าเท่ากับ 50
                    case "2": pub = 100; break;//กำหนด case 2 pub จะมีค่าเท่ากับ 100
                    case "3": pub = 150; break;//กำหนด case 3 pub จะมีค่าเท่ากับ 150
                    case "4": pub = 200; break;//กำหนด case 4 pub จะมีค่าเท่ากับ 200
                    case "5": pub = 250; break;//กำหนด case 5 pub จะมีค่าเท่ากับ 250
                    case "6": pub = 300; break;//กำหนด case 6 pub จะมีค่าเท่ากับ  300
                    
                }
                double raka = (rakah * kun);//รับข้อมูลที่ได้มาคำนวน
                double raka1 = (pub * kun);//รับขอมูลที่ได้มาคำนวน
                double raka2 = (raka + raka1);//รับข้อมูลที่ได้มาคำนวน
                rom.Text = Convert.ToString(raka2);//แสดง rom ใน raka2

            } 
                    if (radioButton5.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton5.Checked
            {
                        switch (textBox2.Text)// เงื่อนไขของ textbox2.Text
                { 
                        case "1": rakah = 150; break;//กำหนด case 1 rakah จะมีค่าเท่ากับ 150
                    case "2": rakah = 300; break;//กำหนด case 2 rakah จะมีค่าเท่ากับ 300
                    case "3": rakah = 450; break;//กำหนด case 3 rakah จะมีค่าเท่ากับ 450
                    case "4": rakah = 600; break;//กำหนด case 4 rakah จะมีค่าเท่ากับ 600
                    case "5": rakah = 750; break;//กำหนด case 5 rakah จะมีค่าเท่ากับ 750
                    case "6": rakah = 900; break;//กำหนด case 6 rakah จะมีค่าเท่ากับ 900
                    case "7": rakah = 1050; break;//กำหนด case 7 rakah จะมีค่าเท่ากับ 1050
                    case "8": rakah = 1200; break;//กำหนด case 8 rakah จะมีค่าเท่ากับ 1200
                    case "9": rakah = 1350; break;//กำหนด case 9 rakah จะมีค่าเท่ากับ 1350
                    case "10": rakah = 1500; break;//กำหนด case 10 rakah จะมีค่าเท่ากับ 1500
                    case "11": rakah = 1650; break;//กำหนด case 11 rakah จะมีค่าเท่ากับ 1650
                    case "12": rakah = 1800; break;//กำหนด case 12 rakah จะมีค่าเท่ากับ 1800
                    
                }
                switch (textBox4.Text)// เงื่อนไขของ combobox1.Text
                {
                    case "1": pub = 50; break;//กำหนด case 1 pub จะมีค่าเท่ากับ 50
                    case "2": pub = 100; break;//กำหนด case 2 pub จะมีค่าเท่ากับ 100
                    case "3": pub = 150; break;//กำหนด case 3 pub จะมีค่าเท่ากับ 150
                    case "4": pub = 200; break;//กำหนด case 4 pub จะมีค่าเท่ากับ 200
                    case "5": pub = 250; break;//กำหนด case 5 pub จะมีค่าเท่ากับ 250
                    case "6": pub = 300; break;//กำหนด case 6 pub จะมีค่าเท่ากับ  300
                    
                }
                double raka = (rakah * kun);//รับข้อมูลที่ได้มาคำนวน
                double raka1 = (pub * kun);//รับขอมูลที่ได้มาคำนวน
                double raka2 = (raka + raka1);//รับข้อมูลที่ได้มาคำนวน
                rom.Text = Convert.ToString(raka2);//แสดง rom ใน raka2

            }
            if (radioButton6.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton6.Checked
            {
                        switch (textBox2.Text)// เงื่อนไขของ textbox2.Text
                {
                    case "1": rakah = 400; break;//กำหนด case 1 rakah จะมีค่าเท่ากับ 400
                    case "2": rakah = 800; break;//กำหนด case 2 rakah จะมีค่าเท่ากับ 800
                    case "3": rakah = 1200; break;//กำหนด case 3 rakah จะมีค่าเท่ากับ 1200
                    case "4": rakah = 1600; break;//กำหนด case 4 rakah จะมีค่าเท่ากับ 1600
                    case "5": rakah = 2000; break;//กำหนด case 5 rakah จะมีค่าเท่ากับ 2000
                    
                }
                switch (textBox4.Text)// เงื่อนไขของ combobox1.Text
                {
                    case "1": pub = 50; break;//กำหนด case 1 pub จะมีค่าเท่ากับ 50
                    case "2": pub = 100; break;//กำหนด case 2 pub จะมีค่าเท่ากับ 100
                    case "3": pub = 150; break;//กำหนด case 3 pub จะมีค่าเท่ากับ 150
                    case "4": pub = 200; break;//กำหนด case 4 pub จะมีค่าเท่ากับ 200
                    case "5": pub = 250; break;//กำหนด case 5 pub จะมีค่าเท่ากับ 250
                    case "6": pub = 300; break;//กำหนด case 6 pub จะมีค่าเท่ากับ  300
                    
                }
                double raka = (rakah * kun);//รับข้อมูลที่ได้มาคำนวน
                double raka1 = (pub * kun);//รับขอมูลที่ได้มาคำนวน
                double raka2 = (raka + raka1);//รับข้อมูลที่ได้มาคำนวน
                rom.Text = Convert.ToString(raka2);//แสดง rom ใน raka2
            }
                     if  (radioButton7.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton7.Checked
            {
                        switch (textBox2.Text)// เงื่อนไขของ textbox2.Text
                {
                            case "1": rakah = 300; break;//กำหนด case 1 rakah จะมีค่าเท่ากับ 300
                    case "2": rakah = 600; break;//กำหนด case 2 rakah จะมีค่าเท่ากับ 600
                    case "3": rakah = 900; break;//กำหนด case 3 rakah จะมีค่าเท่ากับ 900
                    case "4": rakah = 1200; break;//กำหนด case 4 rakah จะมีค่าเท่ากับ 1200
                    case "5": rakah = 1500; break;//กำหนด case 5 rakah จะมีค่าเท่ากับ 1500
                    case "6": rakah = 1800; break;//กำหนด case 6 rakah จะมีค่าเท่ากับ 1800
                    case "7": rakah = 2100; break;//กำหนด case 7 rakah จะมีค่าเท่ากับ 2100
                    case "8": rakah = 2400; break;//กำหนด case 8 rakah จะมีค่าเท่ากับ 2400
                    case "9": rakah = 2700; break;//กำหนด case 9 rakah จะมีค่าเท่ากับ 2700
                    case "10": rakah = 3000; break;//กำหนด case 10 rakah จะมีค่าเท่ากับ 3000
                    case "11": rakah = 3300; break;//กำหนด case 11 rakah จะมีค่าเท่ากับ 3300
                    case "12": rakah = 3600; break;//กำหนด case 12 rakah จะมีค่าเท่ากับ 3600
                    
                }
                switch (textBox4.Text)// เงื่อนไขของ combobox1.Text
                {
                    case "1": pub = 50; break;//กำหนด case 1 pub จะมีค่าเท่ากับ 50
                    case "2": pub = 100; break;//กำหนด case 2 pub จะมีค่าเท่ากับ 100
                    case "3": pub = 150; break;//กำหนด case 3 pub จะมีค่าเท่ากับ 150
                    case "4": pub = 200; break;//กำหนด case 4 pub จะมีค่าเท่ากับ 200
                    case "5": pub = 250; break;//กำหนด case 5 pub จะมีค่าเท่ากับ 250
                    case "6": pub = 300; break;//กำหนด case 6 pub จะมีค่าเท่ากับ  300
                    
                }
                double raka = (rakah * kun);//รับข้อมูลที่ได้มาคำนวน
                double raka1 = (pub * kun);//รับขอมูลที่ได้มาคำนวน
                double raka2 = (raka + raka1);//รับข้อมูลที่ได้มาคำนวน
                rom.Text = Convert.ToString(raka2);//แสดง rom ใน raka2
            }
                     if (radioButton8.Checked == true)//กำหนดเงื่อนไขและเช็คเงื่อนไข radioButton7.Checked
            {
                        switch (textBox2.Text)// เงื่อนไขของ textbox2.Text
                {
                           case "1": rakah = 700; break;//กำหนด case 1 rakah จะมีค่าเท่ากับ 400
                           case "2": rakah = 1400; break;//กำหนด case 2 rakah จะมีค่าเท่ากับ 800
                           case "3": rakah = 2100; break;//กำหนด case 3 rakah จะมีค่าเท่ากับ 1200
                           case "4": rakah = 2800; break;//กำหนด case 4 rakah จะมีค่าเท่ากับ 1600
                           case "5": rakah = 3500; break;//กำหนด case 5 rakah จะมีค่าเท่ากับ 2000
                        
                }
                switch (textBox4.Text)// เงื่อนไขของ combobox1.Text
                {
                    case "1": pub = 50; break;//กำหนด case 1 pub จะมีค่าเท่ากับ 50
                    case "2": pub = 100; break;//กำหนด case 2 pub จะมีค่าเท่ากับ 100
                    case "3": pub = 150; break;//กำหนด case 3 pub จะมีค่าเท่ากับ 150
                    case "4": pub = 200; break;//กำหนด case 4 pub จะมีค่าเท่ากับ 200
                    case "5": pub = 250; break;//กำหนด case 5 pub จะมีค่าเท่ากับ 250
                    case "6": pub = 300; break;//กำหนด case 6 pub จะมีค่าเท่ากับ  300
                    
                }
                double raka = (rakah * kun);//รับข้อมูลที่ได้มาคำนวน
                double raka1 = (pub * kun);//รับขอมูลที่ได้มาคำนวน
                double raka2 = (raka + raka1);//รับข้อมูลที่ได้มาคำนวน
                rom.Text = Convert.ToString(raka2);//แสดง rom ใน raka2
               
            }
                }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//ปิดโปรแกรม
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}