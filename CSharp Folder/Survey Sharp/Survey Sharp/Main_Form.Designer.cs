namespace Survey_Sharp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.new_surveyButton = new System.Windows.Forms.Button();
            this.surveysButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySurveysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_surveyButton
            // 
            this.new_surveyButton.BackColor = System.Drawing.Color.Coral;
            this.new_surveyButton.Location = new System.Drawing.Point(335, 145);
            this.new_surveyButton.Name = "new_surveyButton";
            this.new_surveyButton.Size = new System.Drawing.Size(187, 69);
            this.new_surveyButton.TabIndex = 0;
            this.new_surveyButton.Text = "New Survey";
            this.new_surveyButton.UseVisualStyleBackColor = false;
            this.new_surveyButton.Click += new System.EventHandler(this.new_surveyButton_Click);
            // 
            // surveysButton
            // 
            this.surveysButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.surveysButton.Location = new System.Drawing.Point(335, 220);
            this.surveysButton.Name = "surveysButton";
            this.surveysButton.Size = new System.Drawing.Size(187, 69);
            this.surveysButton.TabIndex = 1;
            this.surveysButton.Text = "My Surveys";
            this.surveysButton.UseVisualStyleBackColor = false;
            this.surveysButton.Click += new System.EventHandler(this.surveysButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Azure;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.ExitLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(411, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(411, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // ExitLabel
            // 
            this.ExitLabel.IsLink = true;
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(25, 17);
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSurveyToolStripMenuItem,
            this.mySurveysToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // newSurveyToolStripMenuItem
            // 
            this.newSurveyToolStripMenuItem.Name = "newSurveyToolStripMenuItem";
            this.newSurveyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newSurveyToolStripMenuItem.Text = "New Survey";
            this.newSurveyToolStripMenuItem.Click += new System.EventHandler(this.newSurveyToolStripMenuItem_Click);
            // 
            // mySurveysToolStripMenuItem
            // 
            this.mySurveysToolStripMenuItem.Name = "mySurveysToolStripMenuItem";
            this.mySurveysToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mySurveysToolStripMenuItem.Text = "My Surveys";
            this.mySurveysToolStripMenuItem.Click += new System.EventHandler(this.mySurveysToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(863, 479);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.surveysButton);
            this.Controls.Add(this.new_surveyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Survey Sharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_surveyButton;
        private System.Windows.Forms.Button surveysButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySurveysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ExitLabel;
    }
}

