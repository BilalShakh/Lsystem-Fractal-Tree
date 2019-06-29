using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace LSystem
{
    public partial class Form1 : Form
    {
        //All global variables used in this program.
        private static string axiom = "F";
        private static float length = 75.0f;
        private static Rule makeBranches = new Rule("F", "FF+[+F-F-F]-[-F+F+F]");

        private static string LSystemString;
        private static Bitmap LSystemBitmap = new Bitmap(400, 400);
        private static Graphics LSystemDrawingCanvas;
        private static Pen WhitePen = new Pen(Color.White);

        //struct used to create Rules for the Lsystem string creation.
        private struct Rule
        {
            public string A, B;

            public Rule(string a, string b)
            {
                A = a;
                B = b;
            }
        }


        public Form1()
        {
            InitializeComponent();

            LSystemString = axiom;
            LSystemDrawingCanvas = Graphics.FromImage(LSystemBitmap);
        }

        //Event raised for changing the paintbox using the Bitmap.
        private void LSystemPictureBox_Paint(object sender, PaintEventArgs e)
        {
            //SaveRestore1(e);
            e.Graphics.DrawImage(LSystemBitmap, 0, 0);
        }

        //Event for when the user presses the Generate Button.
        private void GenerateButton_Click(object sender, EventArgs e)
        {

            length *= 0.56f;

            //To prevent the user from causing the program to create too small lines and go through very long instructions.
            if (length > 4)
            {
                //Initialize transformation state
                LSystemDrawingCanvas.ResetTransform();
                LSystemDrawingCanvas.TranslateTransform(200, 400);

                LSystemString = GenerateLSystemString(LSystemString);
                Turtle(LSystemString);
                InstructionsTextbox.Text = LSystemString;
            }
            else
                MessageBox.Show("Lines are too small to show","Error");

        }

        //Generates the string which has the instructions for the turtle method to follow.
        private static string GenerateLSystemString(string currentLSystemString)
        {
            string NewLSystemString = "";

            for (int i = 0; i < currentLSystemString.Length; i++)
            {
                string CurrentSymbol = currentLSystemString.Substring(i, 1);

                if (CurrentSymbol == makeBranches.A)
                {
                    NewLSystemString += makeBranches.B;
                }
                else
                {
                    NewLSystemString += CurrentSymbol;
                }
            }

            return NewLSystemString;
        }

        //The turtle which executes the instructions encoded in the LSystemString created by GenerateLSystem.
        private void Turtle(string LSystemString)
        {
            //Stack which holds all the saved Information.
            List<GraphicsState> transformationStateStack = new List<GraphicsState>();
            
            //Loop for checking the whole string, letter by letter and execute the instructions associated with it.
            for (int i = 0; i < LSystemString.Length; i++)
            {
                string CurrentSymbol = LSystemString.Substring(i, 1);

                if (CurrentSymbol == "F")
                {
                    LSystemDrawingCanvas.DrawLine(WhitePen, 0, 0, 0, -length);
                    LSystemDrawingCanvas.TranslateTransform(0, -length);
                }
                else if (CurrentSymbol == "+")
                {
                    LSystemDrawingCanvas.RotateTransform(30);
                }
                else if (CurrentSymbol == "-")
                {
                    LSystemDrawingCanvas.RotateTransform(-30);
                }
                else if (CurrentSymbol == "[")
                {
                    Push(LSystemDrawingCanvas.Save(), transformationStateStack);
                }
                else if (CurrentSymbol == "]")
                {
                    LSystemDrawingCanvas.Restore(Pop(transformationStateStack));
                }
            }

            //After all instructions have been executed refresh the PictureBox to start the paint event.
            LSystemPictureBox.Refresh();
        }

        //Push data into a stack in the form of an item in a list. Essentially put something on top of a stack.
        private static void Push(GraphicsState transformationState, List<GraphicsState> stack)
        {
            stack.Add(transformationState);
        }

        // A try...catch statement is used here just in case this method attempts to 
        // "pop" an item from an empty stack.

        //Pop out the last item out of a list, so what ever enters the List first is last out. 
        private static GraphicsState Pop(List<GraphicsState> stack)
        {
            try
            {
                GraphicsState transformationState = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return transformationState;
            }
            catch (System.IndexOutOfRangeException exception)
            {
                throw new System.ArgumentException("Cannot pop a value from an empty stack.", "stack", exception);
            }
        }

        //Event for resetting the program.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            LSystemString = axiom;
            LSystemDrawingCanvas.ResetTransform();
            LSystemDrawingCanvas.TranslateTransform(200, 400);
            LSystemDrawingCanvas.Clear(LSystemPictureBox.BackColor);
            LSystemPictureBox.Refresh();
            InstructionsTextbox.Text = "";
            length = 75.0f;
        }
    }
}
