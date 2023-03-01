namespace project
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.drillLabel = new System.Windows.Forms.Label();
            this.screwLabel = new System.Windows.Forms.Label();
            this.sawLabel = new System.Windows.Forms.Label();
            this.headerlabel = new System.Windows.Forms.Label();
            this.whiskeyInput = new System.Windows.Forms.TextBox();
            this.cigarInput = new System.Windows.Forms.TextBox();
            this.ammoInput = new System.Windows.Forms.TextBox();
            this.subTotallabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.recieptOutput = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(31, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(245, 30);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(31, 569);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(244, 26);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // drillLabel
            // 
            this.drillLabel.BackColor = System.Drawing.Color.Transparent;
            this.drillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drillLabel.Location = new System.Drawing.Point(-1, 38);
            this.drillLabel.Name = "drillLabel";
            this.drillLabel.Size = new System.Drawing.Size(127, 39);
            this.drillLabel.TabIndex = 3;
            this.drillLabel.Text = "Whiskey:";
            this.drillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // screwLabel
            // 
            this.screwLabel.BackColor = System.Drawing.Color.Transparent;
            this.screwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screwLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.screwLabel.Location = new System.Drawing.Point(-1, 88);
            this.screwLabel.Name = "screwLabel";
            this.screwLabel.Size = new System.Drawing.Size(127, 39);
            this.screwLabel.TabIndex = 4;
            this.screwLabel.Text = "Cigars:";
            this.screwLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sawLabel
            // 
            this.sawLabel.BackColor = System.Drawing.Color.Transparent;
            this.sawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sawLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sawLabel.Location = new System.Drawing.Point(-11, 141);
            this.sawLabel.Name = "sawLabel";
            this.sawLabel.Size = new System.Drawing.Size(143, 32);
            this.sawLabel.TabIndex = 5;
            this.sawLabel.Text = "Revolver Ammo:";
            this.sawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // headerlabel
            // 
            this.headerlabel.BackColor = System.Drawing.Color.Transparent;
            this.headerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerlabel.Location = new System.Drawing.Point(-1, 3);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(333, 39);
            this.headerlabel.TabIndex = 6;
            this.headerlabel.Text = "Mid West Saloon";
            this.headerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whiskeyInput
            // 
            this.whiskeyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whiskeyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiskeyInput.Location = new System.Drawing.Point(132, 45);
            this.whiskeyInput.Name = "whiskeyInput";
            this.whiskeyInput.Size = new System.Drawing.Size(144, 26);
            this.whiskeyInput.TabIndex = 7;
            // 
            // cigarInput
            // 
            this.cigarInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cigarInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cigarInput.Location = new System.Drawing.Point(132, 95);
            this.cigarInput.Name = "cigarInput";
            this.cigarInput.Size = new System.Drawing.Size(144, 26);
            this.cigarInput.TabIndex = 8;
            // 
            // ammoInput
            // 
            this.ammoInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoInput.Location = new System.Drawing.Point(132, 145);
            this.ammoInput.Name = "ammoInput";
            this.ammoInput.Size = new System.Drawing.Size(144, 26);
            this.ammoInput.TabIndex = 9;
            // 
            // subTotallabel
            // 
            this.subTotallabel.BackColor = System.Drawing.Color.Transparent;
            this.subTotallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotallabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotallabel.Location = new System.Drawing.Point(-1, 255);
            this.subTotallabel.Name = "subTotallabel";
            this.subTotallabel.Size = new System.Drawing.Size(127, 39);
            this.subTotallabel.TabIndex = 10;
            this.subTotallabel.Text = "Sub Total";
            this.subTotallabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.Location = new System.Drawing.Point(-1, 311);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(127, 39);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax:";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(-1, 367);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(127, 39);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(132, 260);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(144, 28);
            this.subTotalOutput.TabIndex = 13;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(132, 316);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(144, 28);
            this.taxOutput.TabIndex = 14;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(132, 372);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(144, 28);
            this.totalOutput.TabIndex = 15;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenderedLabel.Location = new System.Drawing.Point(-1, 421);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(127, 39);
            this.tenderedLabel.TabIndex = 17;
            this.tenderedLabel.Text = "Tendered:";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(132, 523);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(144, 28);
            this.changeOutput.TabIndex = 18;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(31, 474);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(245, 30);
            this.changeButton.TabIndex = 19;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeLabel.Location = new System.Drawing.Point(-1, 517);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(127, 39);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change:";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenderedInput
            // 
            this.tenderedInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(132, 428);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(144, 26);
            this.tenderedInput.TabIndex = 21;
            // 
            // recieptOutput
            // 
            this.recieptOutput.BackColor = System.Drawing.Color.PapayaWhip;
            this.recieptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptOutput.Location = new System.Drawing.Point(308, 28);
            this.recieptOutput.Name = "recieptOutput";
            this.recieptOutput.Size = new System.Drawing.Size(447, 528);
            this.recieptOutput.TabIndex = 22;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(385, 569);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(293, 26);
            this.restartButton.TabIndex = 23;
            this.restartButton.Text = "New Order";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 607);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.recieptOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotallabel);
            this.Controls.Add(this.ammoInput);
            this.Controls.Add(this.cigarInput);
            this.Controls.Add(this.whiskeyInput);
            this.Controls.Add(this.headerlabel);
            this.Controls.Add(this.sawLabel);
            this.Controls.Add(this.screwLabel);
            this.Controls.Add(this.drillLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.tenderedLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Variety Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label drillLabel;
        private System.Windows.Forms.Label screwLabel;
        private System.Windows.Forms.Label sawLabel;
        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.TextBox whiskeyInput;
        private System.Windows.Forms.TextBox cigarInput;
        private System.Windows.Forms.TextBox ammoInput;
        private System.Windows.Forms.Label subTotallabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label recieptOutput;
        private System.Windows.Forms.Button restartButton;
    }
}

