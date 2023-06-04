namespace Homework_W8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box1 = new System.Windows.Forms.ComboBox();
            this.box2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.Label();
            this.nat = new System.Windows.Forms.Label();
            this.qn = new System.Windows.Forms.Label();
            this.kuning = new System.Windows.Forms.Label();
            this.merah = new System.Windows.Forms.Label();
            this.gol = new System.Windows.Forms.Label();
            this.pen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.matchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // matchDetailsToolStripMenuItem
            // 
            this.matchDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchDetailsToolStripMenuItem.Name = "matchDetailsToolStripMenuItem";
            this.matchDetailsToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.matchDetailsToolStripMenuItem.Text = "Match Details";
            this.matchDetailsToolStripMenuItem.Click += new System.EventHandler(this.matchDetailsToolStripMenuItem_Click);
            // 
            // box1
            // 
            this.box1.FormattingEnabled = true;
            this.box1.Location = new System.Drawing.Point(12, 81);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(185, 28);
            this.box1.TabIndex = 1;
            this.box1.Visible = false;
            this.box1.SelectionChangeCommitted += new System.EventHandler(this.box1_SelectionChangeCommitted);
            // 
            // box2
            // 
            this.box2.FormattingEnabled = true;
            this.box2.Location = new System.Drawing.Point(233, 81);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(230, 28);
            this.box2.TabIndex = 2;
            this.box2.Visible = false;
            this.box2.SelectionChangeCommitted += new System.EventHandler(this.box2_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Team";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Player";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(15, 55);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(127, 20);
            this.nama.TabIndex = 6;
            this.nama.Text = "Name                  :";
            // 
            // tim
            // 
            this.tim.AutoSize = true;
            this.tim.Location = new System.Drawing.Point(15, 86);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(129, 20);
            this.tim.TabIndex = 7;
            this.tim.Text = "Team                   :";
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.Location = new System.Drawing.Point(15, 117);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(129, 20);
            this.pos.TabIndex = 8;
            this.pos.Text = "Position               :";
            // 
            // nat
            // 
            this.nat.AutoSize = true;
            this.nat.Location = new System.Drawing.Point(15, 149);
            this.nat.Name = "nat";
            this.nat.Size = new System.Drawing.Size(130, 20);
            this.nat.TabIndex = 9;
            this.nat.Text = "Nationality           :";
            // 
            // qn
            // 
            this.qn.AutoSize = true;
            this.qn.Location = new System.Drawing.Point(15, 182);
            this.qn.Name = "qn";
            this.qn.Size = new System.Drawing.Size(132, 20);
            this.qn.TabIndex = 10;
            this.qn.Text = "Squad Number   :";
            // 
            // kuning
            // 
            this.kuning.AutoSize = true;
            this.kuning.Location = new System.Drawing.Point(15, 216);
            this.kuning.Name = "kuning";
            this.kuning.Size = new System.Drawing.Size(133, 20);
            this.kuning.TabIndex = 11;
            this.kuning.Text = "Yellow Cards       :";
            // 
            // merah
            // 
            this.merah.AutoSize = true;
            this.merah.Location = new System.Drawing.Point(15, 248);
            this.merah.Name = "merah";
            this.merah.Size = new System.Drawing.Size(133, 20);
            this.merah.TabIndex = 12;
            this.merah.Text = "Red Cards           :";
            // 
            // gol
            // 
            this.gol.AutoSize = true;
            this.gol.Location = new System.Drawing.Point(15, 282);
            this.gol.Name = "gol";
            this.gol.Size = new System.Drawing.Size(134, 20);
            this.gol.TabIndex = 13;
            this.gol.Text = "Goal Scored        :";
            // 
            // pen
            // 
            this.pen.AutoSize = true;
            this.pen.Location = new System.Drawing.Point(15, 376);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(135, 20);
            this.pen.TabIndex = 14;
            this.pen.Text = "Penalty Missed    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.nama);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tim);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.qn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.kuning);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.merah);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gol);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pen);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 413);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 376);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(160, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Penalty Scored    :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Goal Own             :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox box1;
        private System.Windows.Forms.ComboBox box2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label tim;
        private System.Windows.Forms.Label pos;
        private System.Windows.Forms.Label nat;
        private System.Windows.Forms.Label qn;
        private System.Windows.Forms.Label kuning;
        private System.Windows.Forms.Label merah;
        private System.Windows.Forms.Label gol;
        private System.Windows.Forms.Label pen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

