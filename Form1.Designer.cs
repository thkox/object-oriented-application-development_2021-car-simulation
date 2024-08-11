
namespace P20094_FirstProject
{
    partial class GamePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whyNotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trafficLightRight = new System.Windows.Forms.PictureBox();
            this.carRed = new System.Windows.Forms.PictureBox();
            this.carGreen = new System.Windows.Forms.PictureBox();
            this.carYellowish = new System.Windows.Forms.PictureBox();
            this.carOrange = new System.Windows.Forms.PictureBox();
            this.carPurple = new System.Windows.Forms.PictureBox();
            this.carBlue = new System.Windows.Forms.PictureBox();
            this.crossroad = new System.Windows.Forms.PictureBox();
            this.startTheGame = new System.Windows.Forms.Button();
            this.roadUp = new System.Windows.Forms.PictureBox();
            this.roadRight = new System.Windows.Forms.PictureBox();
            this.trafficLightLeft = new System.Windows.Forms.PictureBox();
            this.trafficLight = new System.Windows.Forms.Timer(this.components);
            this.carSpeed = new System.Windows.Forms.Timer(this.components);
            this.roadLeft = new System.Windows.Forms.PictureBox();
            this.roadDown = new System.Windows.Forms.PictureBox();
            this.Credit = new System.Windows.Forms.Label();
            this.changeState = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLightRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carYellowish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossroad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLightLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whyNotToolStripMenuItem});
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            // 
            // whyNotToolStripMenuItem
            // 
            this.whyNotToolStripMenuItem.Name = "whyNotToolStripMenuItem";
            this.whyNotToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.whyNotToolStripMenuItem.Text = "Why not?";
            this.whyNotToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // trafficLightRight
            // 
            this.trafficLightRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(130)))));
            this.trafficLightRight.Location = new System.Drawing.Point(579, 472);
            this.trafficLightRight.Name = "trafficLightRight";
            this.trafficLightRight.Size = new System.Drawing.Size(50, 50);
            this.trafficLightRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trafficLightRight.TabIndex = 12;
            this.trafficLightRight.TabStop = false;
            // 
            // carRed
            // 
            this.carRed.BackColor = System.Drawing.Color.DimGray;
            this.carRed.Image = ((System.Drawing.Image)(resources.GetObject("carRed.Image")));
            this.carRed.Location = new System.Drawing.Point(471, 656);
            this.carRed.Name = "carRed";
            this.carRed.Size = new System.Drawing.Size(53, 86);
            this.carRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carRed.TabIndex = 10;
            this.carRed.TabStop = false;
            // 
            // carGreen
            // 
            this.carGreen.BackColor = System.Drawing.Color.DimGray;
            this.carGreen.Image = ((System.Drawing.Image)(resources.GetObject("carGreen.Image")));
            this.carGreen.Location = new System.Drawing.Point(471, 472);
            this.carGreen.Name = "carGreen";
            this.carGreen.Size = new System.Drawing.Size(53, 86);
            this.carGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carGreen.TabIndex = 9;
            this.carGreen.TabStop = false;
            // 
            // carYellowish
            // 
            this.carYellowish.BackColor = System.Drawing.Color.DimGray;
            this.carYellowish.Image = global::P20094_FirstProject.Properties.Resources.car6;
            this.carYellowish.Location = new System.Drawing.Point(309, 353);
            this.carYellowish.Name = "carYellowish";
            this.carYellowish.Size = new System.Drawing.Size(88, 53);
            this.carYellowish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carYellowish.TabIndex = 8;
            this.carYellowish.TabStop = false;
            // 
            // carOrange
            // 
            this.carOrange.BackColor = System.Drawing.Color.DimGray;
            this.carOrange.Image = ((System.Drawing.Image)(resources.GetObject("carOrange.Image")));
            this.carOrange.Location = new System.Drawing.Point(471, 564);
            this.carOrange.Name = "carOrange";
            this.carOrange.Size = new System.Drawing.Size(53, 86);
            this.carOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carOrange.TabIndex = 7;
            this.carOrange.TabStop = false;
            // 
            // carPurple
            // 
            this.carPurple.BackColor = System.Drawing.Color.DimGray;
            this.carPurple.Image = global::P20094_FirstProject.Properties.Resources.car5;
            this.carPurple.Location = new System.Drawing.Point(201, 353);
            this.carPurple.Name = "carPurple";
            this.carPurple.Size = new System.Drawing.Size(88, 53);
            this.carPurple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPurple.TabIndex = 4;
            this.carPurple.TabStop = false;
            // 
            // carBlue
            // 
            this.carBlue.BackColor = System.Drawing.Color.DimGray;
            this.carBlue.Image = global::P20094_FirstProject.Properties.Resources.car4;
            this.carBlue.Location = new System.Drawing.Point(98, 353);
            this.carBlue.Name = "carBlue";
            this.carBlue.Size = new System.Drawing.Size(88, 53);
            this.carBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carBlue.TabIndex = 3;
            this.carBlue.TabStop = false;
            // 
            // crossroad
            // 
            this.crossroad.BackColor = System.Drawing.Color.PaleTurquoise;
            this.crossroad.Image = ((System.Drawing.Image)(resources.GetObject("crossroad.Image")));
            this.crossroad.Location = new System.Drawing.Point(1, 27);
            this.crossroad.Name = "crossroad";
            this.crossroad.Size = new System.Drawing.Size(1308, 738);
            this.crossroad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crossroad.TabIndex = 2;
            this.crossroad.TabStop = false;
            // 
            // startTheGame
            // 
            this.startTheGame.BackColor = System.Drawing.Color.MintCream;
            this.startTheGame.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTheGame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.startTheGame.Location = new System.Drawing.Point(1012, 531);
            this.startTheGame.Name = "startTheGame";
            this.startTheGame.Size = new System.Drawing.Size(154, 78);
            this.startTheGame.TabIndex = 14;
            this.startTheGame.Text = "Start The Game";
            this.startTheGame.UseVisualStyleBackColor = false;
            this.startTheGame.Click += new System.EventHandler(this.startTheGame_Click);
            // 
            // roadUp
            // 
            this.roadUp.BackColor = System.Drawing.Color.DimGray;
            this.roadUp.Location = new System.Drawing.Point(419, -207);
            this.roadUp.Name = "roadUp";
            this.roadUp.Size = new System.Drawing.Size(142, 654);
            this.roadUp.TabIndex = 15;
            this.roadUp.TabStop = false;
            // 
            // roadRight
            // 
            this.roadRight.BackColor = System.Drawing.Color.DimGray;
            this.roadRight.Location = new System.Drawing.Point(419, 312);
            this.roadRight.Name = "roadRight";
            this.roadRight.Size = new System.Drawing.Size(1100, 135);
            this.roadRight.TabIndex = 16;
            this.roadRight.TabStop = false;
            // 
            // trafficLightLeft
            // 
            this.trafficLightLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(130)))));
            this.trafficLightLeft.Location = new System.Drawing.Point(345, 240);
            this.trafficLightLeft.Name = "trafficLightLeft";
            this.trafficLightLeft.Size = new System.Drawing.Size(50, 50);
            this.trafficLightLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trafficLightLeft.TabIndex = 17;
            this.trafficLightLeft.TabStop = false;
            // 
            // trafficLight
            // 
            this.trafficLight.Interval = 1000;
            this.trafficLight.Tick += new System.EventHandler(this.trafficLight_Tick);
            // 
            // carSpeed
            // 
            this.carSpeed.Interval = 10;
            this.carSpeed.Tick += new System.EventHandler(this.carSpeed_Tick);
            // 
            // roadLeft
            // 
            this.roadLeft.BackColor = System.Drawing.Color.DimGray;
            this.roadLeft.Location = new System.Drawing.Point(-199, 312);
            this.roadLeft.Name = "roadLeft";
            this.roadLeft.Size = new System.Drawing.Size(622, 135);
            this.roadLeft.TabIndex = 18;
            this.roadLeft.TabStop = false;
            // 
            // roadDown
            // 
            this.roadDown.BackColor = System.Drawing.Color.DimGray;
            this.roadDown.Location = new System.Drawing.Point(419, 444);
            this.roadDown.Name = "roadDown";
            this.roadDown.Size = new System.Drawing.Size(142, 502);
            this.roadDown.TabIndex = 19;
            this.roadDown.TabStop = false;
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.Credit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Credit.Location = new System.Drawing.Point(1095, 291);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(214, 18);
            this.Credit.TabIndex = 20;
            this.Credit.Text = "Created By: Theodore Koxanoglou";
            // 
            // changeState
            // 
            this.changeState.BackColor = System.Drawing.Color.MintCream;
            this.changeState.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.changeState.Location = new System.Drawing.Point(942, 633);
            this.changeState.Name = "changeState";
            this.changeState.Size = new System.Drawing.Size(294, 119);
            this.changeState.TabIndex = 21;
            this.changeState.Text = "What if... a car crosses the road when the light is red?";
            this.changeState.UseVisualStyleBackColor = false;
            this.changeState.Click += new System.EventHandler(this.changeState_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1309, 764);
            this.Controls.Add(this.changeState);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.trafficLightLeft);
            this.Controls.Add(this.startTheGame);
            this.Controls.Add(this.trafficLightRight);
            this.Controls.Add(this.carRed);
            this.Controls.Add(this.carGreen);
            this.Controls.Add(this.carYellowish);
            this.Controls.Add(this.carOrange);
            this.Controls.Add(this.carPurple);
            this.Controls.Add(this.carBlue);
            this.Controls.Add(this.roadRight);
            this.Controls.Add(this.roadDown);
            this.Controls.Add(this.roadLeft);
            this.Controls.Add(this.roadUp);
            this.Controls.Add(this.crossroad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossroad Game";
            this.Load += new System.EventHandler(this.GamePanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLightRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carYellowish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossroad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLightLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox crossroad;
        private System.Windows.Forms.PictureBox carBlue;
        private System.Windows.Forms.PictureBox carPurple;
        private System.Windows.Forms.PictureBox carOrange;
        private System.Windows.Forms.PictureBox carYellowish;
        private System.Windows.Forms.PictureBox carGreen;
        private System.Windows.Forms.PictureBox carRed;
        private System.Windows.Forms.PictureBox trafficLightRight;
        private System.Windows.Forms.Button startTheGame;
        private System.Windows.Forms.PictureBox roadUp;
        private System.Windows.Forms.PictureBox roadRight;
        private System.Windows.Forms.PictureBox trafficLightLeft;
        private System.Windows.Forms.Timer trafficLight;
        private System.Windows.Forms.Timer carSpeed;
        private System.Windows.Forms.PictureBox roadLeft;
        private System.Windows.Forms.PictureBox roadDown;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.Button changeState;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whyNotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

