﻿namespace Monopoly_Bank
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
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.cbPlayerList = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.txtAddPlayer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPayPlayer = new System.Windows.Forms.Button();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.cbPlayerListPay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPassGo = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetPassGoAmount = new System.Windows.Forms.Button();
            this.txtPassGoAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetStartingMoney = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartingMoneyAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimesPassedGo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(6, 19);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(230, 147);
            this.lbPlayers.TabIndex = 0;
            this.lbPlayers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPlayers_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletePlayer);
            this.groupBox1.Controls.Add(this.cbPlayerList);
            this.groupBox1.Controls.Add(this.btnAddPlayer);
            this.groupBox1.Controls.Add(this.txtAddPlayer);
            this.groupBox1.Controls.Add(this.lbPlayers);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player List";
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(157, 199);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(79, 21);
            this.btnDeletePlayer.TabIndex = 4;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // cbPlayerList
            // 
            this.cbPlayerList.FormattingEnabled = true;
            this.cbPlayerList.Location = new System.Drawing.Point(7, 199);
            this.cbPlayerList.Name = "cbPlayerList";
            this.cbPlayerList.Size = new System.Drawing.Size(144, 21);
            this.cbPlayerList.TabIndex = 3;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(157, 173);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(79, 20);
            this.btnAddPlayer.TabIndex = 2;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtAddPlayer
            // 
            this.txtAddPlayer.Location = new System.Drawing.Point(7, 173);
            this.txtAddPlayer.Name = "txtAddPlayer";
            this.txtAddPlayer.Size = new System.Drawing.Size(144, 20);
            this.txtAddPlayer.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConsole);
            this.groupBox2.Location = new System.Drawing.Point(13, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 226);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtConsole.Location = new System.Drawing.Point(7, 20);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(740, 200);
            this.txtConsole.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimesPassedGo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(262, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 93);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBalance.Location = new System.Drawing.Point(102, 20);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(73, 20);
            this.txtBalance.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPayPlayer);
            this.groupBox4.Controls.Add(this.txtPayAmount);
            this.groupBox4.Controls.Add(this.cbPlayerListPay);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(261, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 131);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Player Bank";
            // 
            // btnPayPlayer
            // 
            this.btnPayPlayer.Location = new System.Drawing.Point(187, 16);
            this.btnPayPlayer.Name = "btnPayPlayer";
            this.btnPayPlayer.Size = new System.Drawing.Size(75, 20);
            this.btnPayPlayer.TabIndex = 8;
            this.btnPayPlayer.Text = "Send";
            this.btnPayPlayer.UseVisualStyleBackColor = true;
            this.btnPayPlayer.Click += new System.EventHandler(this.btnPayPlayer_Click);
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(136, 16);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(44, 20);
            this.txtPayAmount.TabIndex = 7;
            // 
            // cbPlayerListPay
            // 
            this.cbPlayerListPay.FormattingEnabled = true;
            this.cbPlayerListPay.Location = new System.Drawing.Point(37, 16);
            this.cbPlayerListPay.Name = "cbPlayerListPay";
            this.cbPlayerListPay.Size = new System.Drawing.Size(92, 21);
            this.cbPlayerListPay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pay";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPassGo);
            this.groupBox5.Location = new System.Drawing.Point(538, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 120);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Banker";
            // 
            // btnPassGo
            // 
            this.btnPassGo.Location = new System.Drawing.Point(10, 78);
            this.btnPassGo.Name = "btnPassGo";
            this.btnPassGo.Size = new System.Drawing.Size(223, 36);
            this.btnPassGo.TabIndex = 7;
            this.btnPassGo.Text = "Pass Go";
            this.btnPassGo.UseVisualStyleBackColor = true;
            this.btnPassGo.Click += new System.EventHandler(this.btnPassGo_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetPassGoAmount);
            this.groupBox6.Controls.Add(this.txtPassGoAmount);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.btnSetStartingMoney);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtStartingMoneyAmount);
            this.groupBox6.Location = new System.Drawing.Point(538, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(239, 103);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // btnSetPassGoAmount
            // 
            this.btnSetPassGoAmount.Location = new System.Drawing.Point(158, 46);
            this.btnSetPassGoAmount.Name = "btnSetPassGoAmount";
            this.btnSetPassGoAmount.Size = new System.Drawing.Size(75, 20);
            this.btnSetPassGoAmount.TabIndex = 5;
            this.btnSetPassGoAmount.Text = "Set";
            this.btnSetPassGoAmount.UseVisualStyleBackColor = true;
            this.btnSetPassGoAmount.Click += new System.EventHandler(this.txtSetPassGoAmount_Click);
            // 
            // txtPassGoAmount
            // 
            this.txtPassGoAmount.Location = new System.Drawing.Point(95, 46);
            this.txtPassGoAmount.Name = "txtPassGoAmount";
            this.txtPassGoAmount.Size = new System.Drawing.Size(56, 20);
            this.txtPassGoAmount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pass Go Amount";
            // 
            // btnSetStartingMoney
            // 
            this.btnSetStartingMoney.Location = new System.Drawing.Point(158, 20);
            this.btnSetStartingMoney.Name = "btnSetStartingMoney";
            this.btnSetStartingMoney.Size = new System.Drawing.Size(75, 20);
            this.btnSetStartingMoney.TabIndex = 2;
            this.btnSetStartingMoney.Text = "Set";
            this.btnSetStartingMoney.UseVisualStyleBackColor = true;
            this.btnSetStartingMoney.Click += new System.EventHandler(this.btnSetStartingMoney_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Starting Money";
            // 
            // txtStartingMoneyAmount
            // 
            this.txtStartingMoneyAmount.Location = new System.Drawing.Point(95, 20);
            this.txtStartingMoneyAmount.Name = "txtStartingMoneyAmount";
            this.txtStartingMoneyAmount.Size = new System.Drawing.Size(56, 20);
            this.txtStartingMoneyAmount.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Times Passed Go";
            // 
            // txtTimesPassedGo
            // 
            this.txtTimesPassedGo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTimesPassedGo.Location = new System.Drawing.Point(102, 46);
            this.txtTimesPassedGo.Name = "txtTimesPassedGo";
            this.txtTimesPassedGo.ReadOnly = true;
            this.txtTimesPassedGo.Size = new System.Drawing.Size(37, 20);
            this.txtTimesPassedGo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 547);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Monopoly Bank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox txtAddPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.ComboBox cbPlayerList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.ComboBox cbPlayerListPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPayPlayer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetStartingMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartingMoneyAmount;
        private System.Windows.Forms.Button btnSetPassGoAmount;
        private System.Windows.Forms.TextBox txtPassGoAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPassGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimesPassedGo;
    }
}

