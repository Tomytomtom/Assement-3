using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;




namespace Assesment_3_Hooks
{
    public partial class Form1 : Form
    {
        //used for deserializing json 
        JasonReader JayRead = new JasonReader();
        // create a global list of colours 
        List<Colour> ColoursList;

        public Form1()
        {
            InitializeComponent();
            // read the information from the json file in to a list of Colours 
            ColoursList = JayRead.LoadJson();
        }



        // get mouse clicks on the form
        private void MouseClickForm(object sender, MouseEventArgs e)
        {
            // if the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
               
             
                // New random number generater
                Random rad = new Random();
                // get a random number that is less or the same as the size of the array than 
                int RandomCol = rad.Next(ColoursList.Count);
                // Create a colour from the RBGA Colour code. The R,B,G needs to be feed in separately(The postion is random so it should be a random color from what is avalibe)
                Color myColor = Color.FromArgb(ColoursList[RandomCol].rgba[0], ColoursList[RandomCol].rgba[1], ColoursList[RandomCol].rgba[2]);
                // Set the color created as this forms backgound color
                this.BackColor = myColor;
                // Print colour name on screen
                ColourLable.Text = "Colour: " + ColoursList[RandomCol].color;

            }
            // if the right mouse button is clicked
            if (e.Button == MouseButtons.Right)
            {
                // create a list of the Colour class with the infmation read in from the json file
               
                //New random number generater
                Random rad = new Random();
                // get a random number that is less or the same as the size of the array than 
                int RandomCol = rad.Next(ColoursList.Count);
                // set the this forms background colour as the hex code in Colours list(The postion is random so it should be a random color from what is avalibe)
                this.BackColor = ColorTranslator.FromHtml(ColoursList[RandomCol].hex);
                // Print colour name on screen
                ColourLable.Text = "Colour: " + ColoursList[RandomCol].color;

            }
        }
        // Get keyboard presses on the form
        private void FormKeyDown_Event(object sender, KeyEventArgs e)
        {
            // so all the cases can see it 
            Colour Col;
            // get the key that was pre
            switch (e.KeyCode)
            {
                // each case is looking for a different letter or key 
                case Keys.Escape :
                    //quit the aplication
                    Application.Exit();
                    break;
                case Keys.R:
                    // get the a colour from the list that has this name
                    Col = ColoursList.Find(x => x.color == "red");
                    // and set the background colour on the form as it
                    this.BackColor = ColorTranslator.FromHtml(Col.hex);
                    break;
                case Keys.B:
                    // get the a colour from the list that has this name
                    Col = ColoursList.Find(x => x.color == "blue");
                    // and set the background colour on the form as it
                    this.BackColor = ColorTranslator.FromHtml(Col.hex);
                    break;
                case Keys.G:
                    // get the a colour from the list that has this name
                    Col = ColoursList.Find(x => x.color == "green");
                    // and set the background colour on the form as it
                    this.BackColor = ColorTranslator.FromHtml(Col.hex);
                    break;
                case Keys.Y:
                    // get the a colour from the list that has this name
                    Col = ColoursList.Find(x => x.color == "yellow");
                    // and set the background colour on the form as it
                    this.BackColor = ColorTranslator.FromHtml(Col.hex);
                    break;
                case Keys.P:
                    // get the a colour from the list that has this name
                    Col = ColoursList.Find(x => x.color == "purple");
                    // and set the background colour on the form as it
                    this.BackColor = ColorTranslator.FromHtml(Col.hex);
                    break;
                case Keys.O:
                    // get the a colour from the list that has this name
                    Col = ColoursList.Find(x => x.color == "orange");
                    // and set the background colour on the form as it
                    this.BackColor = ColorTranslator.FromHtml(Col.hex);
                    break;
                 
            }

        }
    }
}
