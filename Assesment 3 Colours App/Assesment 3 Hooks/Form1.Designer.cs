namespace Assesment_3_Hooks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ColourLable = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColourLable
            // 
            this.ColourLable.AutoSize = true;
            this.ColourLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourLable.Location = new System.Drawing.Point(372, 145);
            this.ColourLable.Name = "ColourLable";
            this.ColourLable.Size = new System.Drawing.Size(207, 37);
            this.ColourLable.TabIndex = 2;
            this.ColourLable.Text = "Colour: None";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(177, 219);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(650, 100);
            this.I.TabIndex = 3;
            this.I.Text = resources.GetString("I.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 501);
            this.Controls.Add(this.I);
            this.Controls.Add(this.ColourLable);
            this.Name = "Form1";
            this.Text = "jyq";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown_Event);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ColourLable;
        private System.Windows.Forms.Label I;
    }
}

