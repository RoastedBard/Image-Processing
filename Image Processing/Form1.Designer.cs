namespace Image_Processing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApplyGaussian = new System.Windows.Forms.Button();
            this.numericUpDownConvolutionKernelSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownConvolutionKernelDeviation = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConvolutionKernelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConvolutionKernelDeviation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.heightmapToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // heightmapToolStripMenuItem
            // 
            this.heightmapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.heightmapToolStripMenuItem.Name = "heightmapToolStripMenuItem";
            this.heightmapToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.heightmapToolStripMenuItem.Text = "Heightmap";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianFilterToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // gaussianFilterToolStripMenuItem
            // 
            this.gaussianFilterToolStripMenuItem.Name = "gaussianFilterToolStripMenuItem";
            this.gaussianFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gaussianFilterToolStripMenuItem.Text = "Gaussian Filter";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.Black;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(6, 27);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownConvolutionKernelDeviation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownConvolutionKernelSize);
            this.panel1.Controls.Add(this.buttonApplyGaussian);
            this.panel1.Location = new System.Drawing.Point(524, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 166);
            this.panel1.TabIndex = 2;
            // 
            // buttonApplyGaussian
            // 
            this.buttonApplyGaussian.Location = new System.Drawing.Point(54, 119);
            this.buttonApplyGaussian.Name = "buttonApplyGaussian";
            this.buttonApplyGaussian.Size = new System.Drawing.Size(91, 23);
            this.buttonApplyGaussian.TabIndex = 0;
            this.buttonApplyGaussian.Text = "Apply Gaussian";
            this.buttonApplyGaussian.UseVisualStyleBackColor = true;
            this.buttonApplyGaussian.Click += new System.EventHandler(this.buttonApplyGaussian_Click);
            // 
            // numericUpDownConvolutionKernelSize
            // 
            this.numericUpDownConvolutionKernelSize.Location = new System.Drawing.Point(66, 25);
            this.numericUpDownConvolutionKernelSize.Name = "numericUpDownConvolutionKernelSize";
            this.numericUpDownConvolutionKernelSize.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownConvolutionKernelSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convolution Kernel Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convolution Kernel Deviation";
            // 
            // numericUpDownConvolutionKernelDeviation
            // 
            this.numericUpDownConvolutionKernelDeviation.DecimalPlaces = 1;
            this.numericUpDownConvolutionKernelDeviation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownConvolutionKernelDeviation.Location = new System.Drawing.Point(66, 81);
            this.numericUpDownConvolutionKernelDeviation.Name = "numericUpDownConvolutionKernelDeviation";
            this.numericUpDownConvolutionKernelDeviation.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownConvolutionKernelDeviation.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConvolutionKernelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConvolutionKernelDeviation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ToolStripMenuItem gaussianFilterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownConvolutionKernelDeviation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownConvolutionKernelSize;
        private System.Windows.Forms.Button buttonApplyGaussian;
    }
}

