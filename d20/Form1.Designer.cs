
namespace d20
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
            this.rollbutton = new System.Windows.Forms.Button();
            this.lblChangeText = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.bruh1 = new System.Windows.Forms.Label();
            this.bruh2 = new System.Windows.Forms.Label();
            this.buttonPlus1 = new System.Windows.Forms.Button();
            this.buttonMinus1 = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Label();
            this.modifierLabel = new System.Windows.Forms.Label();
            this.modifierResetButton = new System.Windows.Forms.Button();
            this.modplusroll = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.movingPanel = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.d20Gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.movingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d20Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // rollbutton
            // 
            this.rollbutton.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.rollbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rollbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.rollbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rollbutton.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rollbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(93)))), ((int)(((byte)(46)))));
            this.rollbutton.Location = new System.Drawing.Point(138, 317);
            this.rollbutton.Name = "rollbutton";
            this.rollbutton.Size = new System.Drawing.Size(180, 65);
            this.rollbutton.TabIndex = 1;
            this.rollbutton.Text = "ROLL";
            this.rollbutton.UseVisualStyleBackColor = true;
            this.rollbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblChangeText
            // 
            this.lblChangeText.AutoSize = true;
            this.lblChangeText.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeText.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChangeText.ForeColor = System.Drawing.Color.Black;
            this.lblChangeText.Location = new System.Drawing.Point(235, 118);
            this.lblChangeText.Name = "lblChangeText";
            this.lblChangeText.Size = new System.Drawing.Size(0, 23);
            this.lblChangeText.TabIndex = 3;
            this.lblChangeText.Tag = "";
            this.lblChangeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChangeText.Click += new System.EventHandler(this.lblChangeText_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(93)))), ((int)(((byte)(46)))));
            this.btn_exit.Location = new System.Drawing.Point(325, 239);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 143);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "X";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bruh1
            // 
            this.bruh1.AutoSize = true;
            this.bruh1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.bruh1.Location = new System.Drawing.Point(180, 157);
            this.bruh1.Name = "bruh1";
            this.bruh1.Size = new System.Drawing.Size(0, 13);
            this.bruh1.TabIndex = 11;
            this.bruh1.Click += new System.EventHandler(this.bruh1_Click);
            // 
            // bruh2
            // 
            this.bruh2.AutoSize = true;
            this.bruh2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.bruh2.Location = new System.Drawing.Point(250, 158);
            this.bruh2.Name = "bruh2";
            this.bruh2.Size = new System.Drawing.Size(0, 13);
            this.bruh2.TabIndex = 12;
            // 
            // buttonPlus1
            // 
            this.buttonPlus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus1.Location = new System.Drawing.Point(268, 240);
            this.buttonPlus1.Name = "buttonPlus1";
            this.buttonPlus1.Size = new System.Drawing.Size(50, 50);
            this.buttonPlus1.TabIndex = 14;
            this.buttonPlus1.Text = "+1";
            this.buttonPlus1.UseVisualStyleBackColor = true;
            this.buttonPlus1.Click += new System.EventHandler(this.buttonPlus1_Click);
            // 
            // buttonMinus1
            // 
            this.buttonMinus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus1.Location = new System.Drawing.Point(138, 240);
            this.buttonMinus1.Name = "buttonMinus1";
            this.buttonMinus1.Size = new System.Drawing.Size(50, 50);
            this.buttonMinus1.TabIndex = 15;
            this.buttonMinus1.Text = "-1";
            this.buttonMinus1.UseVisualStyleBackColor = true;
            this.buttonMinus1.Click += new System.EventHandler(this.buttonMinus1_Click);
            // 
            // mod
            // 
            this.mod.AutoSize = true;
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mod.Location = new System.Drawing.Point(223, 267);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(14, 13);
            this.mod.TabIndex = 16;
            this.mod.Text = "0";
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // modifierLabel
            // 
            this.modifierLabel.AutoSize = true;
            this.modifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modifierLabel.Location = new System.Drawing.Point(205, 240);
            this.modifierLabel.Name = "modifierLabel";
            this.modifierLabel.Size = new System.Drawing.Size(49, 20);
            this.modifierLabel.TabIndex = 17;
            this.modifierLabel.Text = "MOD";
            // 
            // modifierResetButton
            // 
            this.modifierResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modifierResetButton.Location = new System.Drawing.Point(138, 291);
            this.modifierResetButton.Name = "modifierResetButton";
            this.modifierResetButton.Size = new System.Drawing.Size(180, 25);
            this.modifierResetButton.TabIndex = 18;
            this.modifierResetButton.Text = "RESET MODIFIER";
            this.modifierResetButton.UseVisualStyleBackColor = true;
            this.modifierResetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // modplusroll
            // 
            this.modplusroll.AutoSize = true;
            this.modplusroll.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modplusroll.Location = new System.Drawing.Point(213, 88);
            this.modplusroll.Name = "modplusroll";
            this.modplusroll.Size = new System.Drawing.Size(0, 14);
            this.modplusroll.TabIndex = 19;
            // 
            // btn_History
            // 
            this.btn_History.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btn_History.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_History.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.btn_History.Location = new System.Drawing.Point(138, 384);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(180, 22);
            this.btn_History.TabIndex = 20;
            this.btn_History.Text = "H   I   S   T   O   R   Y";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(39)))), ((int)(((byte)(27)))));
            this.movingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.movingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movingPanel.Location = new System.Drawing.Point(0, 0);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(500, 17);
            this.movingPanel.TabIndex = 13;
            this.movingPanel.TabStop = false;
            this.movingPanel.Click += new System.EventHandler(this.movingPanel_Click);
            this.movingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movingPanel_MouseDown);
            this.movingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movingPanel_MouseMove);
            this.movingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movingPanel_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::d20.Properties.Resources.long_flag1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, -74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 364);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::d20.Properties.Resources.long_flag;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(370, -74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 364);
            this.panel4.TabIndex = 9;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::d20.Properties.Resources.border60_2;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 100);
            this.panel6.TabIndex = 8;
            // 
            // d20Gif
            // 
            this.d20Gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.d20Gif.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.d20Gif.ErrorImage = global::d20.Properties.Resources.ezgif_3_82f1eb50ba87;
            this.d20Gif.Image = global::d20.Properties.Resources._150x150d20;
            this.d20Gif.ImageLocation = "";
            this.d20Gif.Location = new System.Drawing.Point(157, 60);
            this.d20Gif.Name = "d20Gif";
            this.d20Gif.Size = new System.Drawing.Size(223, 167);
            this.d20Gif.TabIndex = 2;
            this.d20Gif.TabStop = false;
            this.d20Gif.WaitOnLoad = true;
            this.d20Gif.Click += new System.EventHandler(this.d20Gif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.modplusroll);
            this.Controls.Add(this.modifierResetButton);
            this.Controls.Add(this.modifierLabel);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.buttonMinus1);
            this.Controls.Add(this.buttonPlus1);
            this.Controls.Add(this.bruh1);
            this.Controls.Add(this.movingPanel);
            this.Controls.Add(this.bruh2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lblChangeText);
            this.Controls.Add(this.d20Gif);
            this.Controls.Add(this.rollbutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d20";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d20Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rollbutton;
        private System.Windows.Forms.Label lblChangeText;
        private System.Windows.Forms.PictureBox d20Gif;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label bruh1;
        private System.Windows.Forms.Label bruh2;
        private System.Windows.Forms.PictureBox movingPanel;
        private System.Windows.Forms.Button buttonPlus1;
        private System.Windows.Forms.Button buttonMinus1;
        private System.Windows.Forms.Label mod;
        private System.Windows.Forms.Label modifierLabel;
        private System.Windows.Forms.Button modifierResetButton;
        private System.Windows.Forms.Label modplusroll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_History;
    }
}

