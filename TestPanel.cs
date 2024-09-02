using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Testing.Program;

namespace Testing
{
    public partial class frmTestPanel : Form
    {
        public static frmTestPanel instance = new frmTestPanel();
        public StringBuilder sb = new StringBuilder();

        public frmTestPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instance = (frmTestPanel)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            
           
           
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {
        
           
            myCasting(); // Manual Casting
           
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
         
            myArrayWithLoop();
           
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            myVariable(); // Variable DataTypes
           
        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
           
            myParameter(1001, "Ram", true); // Method Parameter
           
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
           
            myEnum(Shape.circle);
           
        }

        private void btnConstant_Click(object sender, EventArgs e)
        {
           
            myConst();  // Constant value tesing.
            
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
           
            mySwitchCase(3);
           
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
           
            myMath();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            
            myClass();
           
        }

        public void WriteOutput(object robject)
        {
            string output = robject.ToString();
            sb.AppendLine(output);
            rtxtOutput.Text = sb.ToString();
        }

        public void myMath()
        {
            double myvar = 123.456;
            WriteOutput(Math.Abs(myvar));
            WriteOutput(Math.Ceiling(myvar));
            WriteOutput(Math.Round(myvar));
            WriteOutput(Math.Floor(myvar));
            WriteOutput("== ** == ");
        }

        public enum Shape
        {
            circle = 1,
            rectangle = 2,
            triangle = 3
        }

        void myEnum(Shape shape)
        {
            WriteOutput(shape.ToString());
            WriteOutput("== ** == ");
        }

        public void myArrayWithLoop()
        {
            int[] myVar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int i = 0; i < myVar.Length; i++)
            {
                WriteOutput(myVar[i] + " Index: " + i.ToString());
            }
            WriteOutput("== ** == ");
            string[] myColor = { "Red", "White", "Blue", "Yellow", "Green" };
            int j = 0;
            while (j < myColor.Length)
            {
                WriteOutput(myColor[j]);
                j++;
            }
            WriteOutput("== ** == ");
        }


        public class Car
        {
            // Fields (attributes)
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            // Method
            public void Start()
            {
                frmTestPanel.instance.WriteOutput("The car has started.");
                frmTestPanel.instance.WriteOutput("== ** == ");
            }
        }

        public void myClass()
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2022;

            myCar.Start(); // Calls the Start method on the myCar object
        }

        public void myPrintMessage()
        {
            WriteOutput("Hello World..");
            WriteOutput("== ** == ");
        }


         public void myVariable()
        {
            int myNum = 5;
            double myDoubleNum = 5.99D; 
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            WriteOutput(myNum);
            WriteOutput(myDoubleNum);
            WriteOutput(myLetter);
            WriteOutput(myBool);
            WriteOutput(myText);
            WriteOutput("== ** == ");
        }
         public void myConst()
        {
            const int myConsNum = 15;
            WriteOutput(myConsNum);
            WriteOutput("== ** == ");
        }
         public void myCasting()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble; // Manual casting: double to int 
            WriteOutput(myDouble); // Outputs 9.78 
            WriteOutput(myInt); // Outputs 9 
            WriteOutput("== ** == ");
        }
         public void myParameter(int Num, string Msg, bool IsValid)
        {
            if (IsValid)
            {
                WriteOutput("My name is " + Msg + " and my ID number is " + Num + "Valid");
            }
            else
            {
                WriteOutput("My name is " + Msg + " and my ID number is " + Num + "Invalid");
            }
            WriteOutput("== ** == ");
        }
         public void mySwitchCase(int Value)
        {
            string Result = "";
            switch (Value)
            {
                case 1:
                    Result = "One";
                    break;
                case 2:
                    Result = "Two";
                    break;
                case 3:
                    Result = "Three";
                    break;
                case 4:
                    Result = "Four";
                    break;
                case 5:
                    Result = "Five";
                    break;
            }
            WriteOutput(Result);
            WriteOutput("== ** == ");
        }

        public struct MyDataStruct
        {
            public int ID;
            public string Name;
            public string Department;
            public int Sem;
        }


        public void myStruct()
        {
            MyDataStruct myDataStruct = new MyDataStruct();
            myDataStruct.ID = 1;
            myDataStruct.Name = "Ram";
            myDataStruct.Department = "CS";
            myDataStruct.Sem = 2;

            WriteOutput(myDataStruct.ID);
            WriteOutput(myDataStruct.Name);
            WriteOutput(myDataStruct.Department);
            WriteOutput(myDataStruct.Sem);
            WriteOutput("== ** == ");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            myPrintMessage(); // Print Message
        }
    }


}
