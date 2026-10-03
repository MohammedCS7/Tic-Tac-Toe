namespace Tic_Tac_Toe
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Aqua;
            this.lbl1.Location = new System.Drawing.Point(11, 122);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 45);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Turn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(11, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Winner:";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Aqua;
            this.lblTurn.Location = new System.Drawing.Point(10, 178);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(160, 45);
            this.lblTurn.TabIndex = 11;
            this.lblTurn.Text = "Player1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Rubik", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblWinner.Location = new System.Drawing.Point(11, 353);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(224, 44);
            this.lblWinner.TabIndex = 12;
            this.lblWinner.Text = "InProgress";
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestart.Location = new System.Drawing.Point(20, 439);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(196, 77);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 72);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tic-Tac-Toe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(497, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 125);
            this.button1.TabIndex = 15;
            this.button1.Tag = "Q";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(685, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 125);
            this.button2.TabIndex = 16;
            this.button2.Tag = "Q";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(883, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 125);
            this.button3.TabIndex = 17;
            this.button3.Tag = "Q";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(497, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 125);
            this.button4.TabIndex = 18;
            this.button4.Tag = "Q";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button4.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(685, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 125);
            this.button5.TabIndex = 19;
            this.button5.Tag = "Q";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button5.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(883, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 125);
            this.button6.TabIndex = 20;
            this.button6.Tag = "Q";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button6.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(497, 353);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 125);
            this.button7.TabIndex = 21;
            this.button7.Tag = "Q";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button7.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(685, 353);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 125);
            this.button8.TabIndex = 22;
            this.button8.Tag = "Q";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            this.button8.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(883, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(162, 125);
            this.button9.TabIndex = 23;
            this.button9.Tag = "Q";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            this.button9.MouseEnter += new System.EventHandler(this.Buttons_Mouse_Enter);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_Mouse_Up);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 545);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

