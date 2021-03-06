﻿namespace ChestionarAuto
{
    partial class QuestionForm
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
            this.picBoxQImage = new System.Windows.Forms.PictureBox();
            this.lblQTitle = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblWA = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.btnExitQForm = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnResetAnswer = new System.Windows.Forms.Button();
            this.btnAnswerLater = new System.Windows.Forms.Button();
            this.lblIQ = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.lblInitialQuestions = new System.Windows.Forms.Label();
            this.lblRemainingQuestions = new System.Windows.Forms.Label();
            this.lblRT = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.timerRemaining = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxQImage
            // 
            this.picBoxQImage.Location = new System.Drawing.Point(692, 223);
            this.picBoxQImage.Name = "picBoxQImage";
            this.picBoxQImage.Size = new System.Drawing.Size(512, 384);
            this.picBoxQImage.TabIndex = 0;
            this.picBoxQImage.TabStop = false;
            // 
            // lblQTitle
            // 
            this.lblQTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTitle.Location = new System.Drawing.Point(79, 102);
            this.lblQTitle.Name = "lblQTitle";
            this.lblQTitle.Size = new System.Drawing.Size(1125, 94);
            this.lblQTitle.TabIndex = 1;
            this.lblQTitle.Text = "intrebare";
            this.lblQTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(82, 223);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(567, 114);
            this.btnA.TabIndex = 2;
            this.btnA.Tag = "1";
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(82, 359);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(567, 114);
            this.btnB.TabIndex = 3;
            this.btnB.Tag = "2";
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(82, 493);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(567, 114);
            this.btnC.TabIndex = 4;
            this.btnC.Tag = "3";
            this.btnC.Text = "button3";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(36, 256);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(37, 36);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(36, 391);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(36, 36);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(36, 526);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(37, 36);
            this.lblC.TabIndex = 9;
            this.lblC.Text = "C";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(837, 61);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(131, 17);
            this.lblCA.TabIndex = 10;
            this.lblCA.Text = "Raspunsuri corecte";
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.ForeColor = System.Drawing.Color.Green;
            this.lblCorrectAnswers.Location = new System.Drawing.Point(892, 31);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(19, 20);
            this.lblCorrectAnswers.TabIndex = 11;
            this.lblCorrectAnswers.Text = "0";
            // 
            // lblWA
            // 
            this.lblWA.AutoSize = true;
            this.lblWA.Location = new System.Drawing.Point(1050, 61);
            this.lblWA.Name = "lblWA";
            this.lblWA.Size = new System.Drawing.Size(127, 17);
            this.lblWA.TabIndex = 12;
            this.lblWA.Text = "Raspunsuri gresite";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.ForeColor = System.Drawing.Color.Red;
            this.lblWrongAnswers.Location = new System.Drawing.Point(1101, 31);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(19, 20);
            this.lblWrongAnswers.TabIndex = 13;
            this.lblWrongAnswers.Text = "0";
            // 
            // btnExitQForm
            // 
            this.btnExitQForm.Location = new System.Drawing.Point(1023, 648);
            this.btnExitQForm.Name = "btnExitQForm";
            this.btnExitQForm.Size = new System.Drawing.Size(181, 65);
            this.btnExitQForm.TabIndex = 14;
            this.btnExitQForm.Text = "Iesire";
            this.btnExitQForm.UseVisualStyleBackColor = true;
            this.btnExitQForm.Click += new System.EventHandler(this.btnExitQForm_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Enabled = false;
            this.btnAnswer.Location = new System.Drawing.Point(465, 648);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(181, 65);
            this.btnAnswer.TabIndex = 15;
            this.btnAnswer.Text = "Trimite raspunsul";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnResetAnswer
            // 
            this.btnResetAnswer.Enabled = false;
            this.btnResetAnswer.Location = new System.Drawing.Point(273, 648);
            this.btnResetAnswer.Name = "btnResetAnswer";
            this.btnResetAnswer.Size = new System.Drawing.Size(181, 65);
            this.btnResetAnswer.TabIndex = 16;
            this.btnResetAnswer.Text = "Modifica raspunsul";
            this.btnResetAnswer.UseVisualStyleBackColor = true;
            this.btnResetAnswer.Click += new System.EventHandler(this.btnResetAnswer_Click);
            // 
            // btnAnswerLater
            // 
            this.btnAnswerLater.Location = new System.Drawing.Point(82, 648);
            this.btnAnswerLater.Name = "btnAnswerLater";
            this.btnAnswerLater.Size = new System.Drawing.Size(181, 65);
            this.btnAnswerLater.TabIndex = 17;
            this.btnAnswerLater.Text = "Raspunde mai tarziu";
            this.btnAnswerLater.UseVisualStyleBackColor = true;
            this.btnAnswerLater.Click += new System.EventHandler(this.btnAnswerLater_Click);
            // 
            // lblIQ
            // 
            this.lblIQ.AutoSize = true;
            this.lblIQ.Location = new System.Drawing.Point(79, 61);
            this.lblIQ.Name = "lblIQ";
            this.lblIQ.Size = new System.Drawing.Size(104, 17);
            this.lblIQ.TabIndex = 18;
            this.lblIQ.Text = "Intrebari initiale";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(282, 61);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(111, 17);
            this.lblRA.TabIndex = 19;
            this.lblRA.Text = "Intrebari ramase";
            // 
            // lblInitialQuestions
            // 
            this.lblInitialQuestions.AutoSize = true;
            this.lblInitialQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialQuestions.Location = new System.Drawing.Point(120, 31);
            this.lblInitialQuestions.Name = "lblInitialQuestions";
            this.lblInitialQuestions.Size = new System.Drawing.Size(19, 20);
            this.lblInitialQuestions.TabIndex = 20;
            this.lblInitialQuestions.Text = "0";
            // 
            // lblRemainingQuestions
            // 
            this.lblRemainingQuestions.AutoSize = true;
            this.lblRemainingQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingQuestions.Location = new System.Drawing.Point(327, 31);
            this.lblRemainingQuestions.Name = "lblRemainingQuestions";
            this.lblRemainingQuestions.Size = new System.Drawing.Size(19, 20);
            this.lblRemainingQuestions.TabIndex = 21;
            this.lblRemainingQuestions.Text = "0";
            // 
            // lblRT
            // 
            this.lblRT.AutoSize = true;
            this.lblRT.Location = new System.Drawing.Point(612, 61);
            this.lblRT.Name = "lblRT";
            this.lblRT.Size = new System.Drawing.Size(82, 17);
            this.lblRT.TabIndex = 22;
            this.lblRT.Text = "Timp ramas";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTime.Location = new System.Drawing.Point(616, 31);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(67, 20);
            this.lblRemainingTime.TabIndex = 23;
            this.lblRemainingTime.Text = "30 : 00";
            // 
            // timerRemaining
            // 
            this.timerRemaining.Tick += new System.EventHandler(this.timerRemaining_Tick);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.lblRT);
            this.Controls.Add(this.lblRemainingQuestions);
            this.Controls.Add(this.lblInitialQuestions);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.lblIQ);
            this.Controls.Add(this.btnAnswerLater);
            this.Controls.Add(this.btnResetAnswer);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnExitQForm);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.lblWA);
            this.Controls.Add(this.lblCorrectAnswers);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQTitle);
            this.Controls.Add(this.picBoxQImage);
            this.Name = "QuestionForm";
            this.Text = "Intrebari";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxQImage;
        private System.Windows.Forms.Label lblQTitle;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblWA;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Button btnExitQForm;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnResetAnswer;
        private System.Windows.Forms.Button btnAnswerLater;
        private System.Windows.Forms.Label lblIQ;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Label lblInitialQuestions;
        private System.Windows.Forms.Label lblRemainingQuestions;
        private System.Windows.Forms.Label lblRT;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Timer timerRemaining;
    }
}