namespace newPaint
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.selectedColor = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.brushIco = new System.Windows.Forms.PictureBox();
            this.eraseAll = new System.Windows.Forms.Button();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.pinkBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.cyanBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.canvas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canvas.Controls.Add(this.panel1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1115, 596);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.selectedColor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.brushIco);
            this.panel1.Controls.Add(this.eraseAll);
            this.panel1.Controls.Add(this.blackBox);
            this.panel1.Controls.Add(this.pinkBox);
            this.panel1.Controls.Add(this.blueBox);
            this.panel1.Controls.Add(this.cyanBox);
            this.panel1.Controls.Add(this.greenBox);
            this.panel1.Controls.Add(this.yellowBox);
            this.panel1.Controls.Add(this.orangeBox);
            this.panel1.Controls.Add(this.redBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 596);
            this.panel1.TabIndex = 0;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(27, 451);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(94, 23);
            this.save_button.TabIndex = 15;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // selectedColor
            // 
            this.selectedColor.Location = new System.Drawing.Point(21, 261);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(100, 50);
            this.selectedColor.TabIndex = 16;
            this.selectedColor.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Wybierz Kolor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(44, 346);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.UseWaitCursor = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // brushIco
            // 
            this.brushIco.BackColor = System.Drawing.Color.White;
            this.brushIco.Image = ((System.Drawing.Image)(resources.GetObject("brushIco.Image")));
            this.brushIco.Location = new System.Drawing.Point(44, 372);
            this.brushIco.Name = "brushIco";
            this.brushIco.Size = new System.Drawing.Size(52, 45);
            this.brushIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brushIco.TabIndex = 1;
            this.brushIco.TabStop = false;
            this.brushIco.Click += new System.EventHandler(this.brushIco_Click);
            // 
            // eraseAll
            // 
            this.eraseAll.Location = new System.Drawing.Point(44, 423);
            this.eraseAll.Name = "eraseAll";
            this.eraseAll.Size = new System.Drawing.Size(52, 22);
            this.eraseAll.TabIndex = 10;
            this.eraseAll.Text = "ERASE ALL";
            this.eraseAll.UseVisualStyleBackColor = true;
            this.eraseAll.Click += new System.EventHandler(this.eraseAll_Click);
            // 
            // blackBox
            // 
            this.blackBox.BackColor = System.Drawing.Color.Black;
            this.blackBox.Location = new System.Drawing.Point(108, 32);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(23, 23);
            this.blackBox.TabIndex = 9;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pinkBox
            // 
            this.pinkBox.BackColor = System.Drawing.Color.Fuchsia;
            this.pinkBox.Location = new System.Drawing.Point(79, 32);
            this.pinkBox.Name = "pinkBox";
            this.pinkBox.Size = new System.Drawing.Size(23, 23);
            this.pinkBox.TabIndex = 8;
            this.pinkBox.TabStop = false;
            this.pinkBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Location = new System.Drawing.Point(50, 32);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(23, 23);
            this.blueBox.TabIndex = 7;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // cyanBox
            // 
            this.cyanBox.BackColor = System.Drawing.Color.Cyan;
            this.cyanBox.Location = new System.Drawing.Point(21, 32);
            this.cyanBox.Name = "cyanBox";
            this.cyanBox.Size = new System.Drawing.Size(23, 23);
            this.cyanBox.TabIndex = 6;
            this.cyanBox.TabStop = false;
            this.cyanBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Lime;
            this.greenBox.Location = new System.Drawing.Point(108, 3);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(23, 23);
            this.greenBox.TabIndex = 4;
            this.greenBox.TabStop = false;
            this.greenBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // yellowBox
            // 
            this.yellowBox.BackColor = System.Drawing.Color.Yellow;
            this.yellowBox.Location = new System.Drawing.Point(79, 3);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(23, 23);
            this.yellowBox.TabIndex = 3;
            this.yellowBox.TabStop = false;
            this.yellowBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeBox.Location = new System.Drawing.Point(50, 3);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(23, 23);
            this.orangeBox.TabIndex = 2;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(21, 3);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(23, 23);
            this.redBox.TabIndex = 1;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 596);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Rysownik";
            this.canvas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox blackBox;
        private System.Windows.Forms.PictureBox pinkBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.PictureBox cyanBox;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.PictureBox yellowBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.Button eraseAll;
        private System.Windows.Forms.PictureBox brushIco;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox selectedColor;
        private System.Windows.Forms.Button save_button;
    }
}

