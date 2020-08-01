﻿namespace MusicGenerator
{
    partial class FormMain
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
            this.groupBoxOctave = new System.Windows.Forms.GroupBox();
            this.radioButtonFirst = new System.Windows.Forms.RadioButton();
            this.radioButtonSecond = new System.Windows.Forms.RadioButton();
            this.buttonDo = new System.Windows.Forms.Button();
            this.buttonDoS = new System.Windows.Forms.Button();
            this.buttonRe = new System.Windows.Forms.Button();
            this.buttonReS = new System.Windows.Forms.Button();
            this.buttonMi = new System.Windows.Forms.Button();
            this.buttonFa = new System.Windows.Forms.Button();
            this.buttonFaS = new System.Windows.Forms.Button();
            this.buttonSol = new System.Windows.Forms.Button();
            this.buttonSolS = new System.Windows.Forms.Button();
            this.buttonLa = new System.Windows.Forms.Button();
            this.buttonLaS = new System.Windows.Forms.Button();
            this.buttonSi = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.groupBoxLength = new System.Windows.Forms.GroupBox();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.radioButtonTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonFour = new System.Windows.Forms.RadioButton();
            this.radioButtonEight = new System.Windows.Forms.RadioButton();
            this.radioButtonSixteen = new System.Windows.Forms.RadioButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.radioButtonThird = new System.Windows.Forms.RadioButton();
            this.textBoxBpm = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonDelLastNote = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBoxOctave.SuspendLayout();
            this.groupBoxLength.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOctave
            // 
            this.groupBoxOctave.Controls.Add(this.radioButtonThird);
            this.groupBoxOctave.Controls.Add(this.radioButtonSecond);
            this.groupBoxOctave.Controls.Add(this.radioButtonFirst);
            this.groupBoxOctave.ForeColor = System.Drawing.Color.Black;
            this.groupBoxOctave.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOctave.Name = "groupBoxOctave";
            this.groupBoxOctave.Size = new System.Drawing.Size(108, 97);
            this.groupBoxOctave.TabIndex = 0;
            this.groupBoxOctave.TabStop = false;
            this.groupBoxOctave.Text = "Октава";
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(7, 21);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(63, 17);
            this.radioButtonFirst.TabIndex = 1;
            this.radioButtonFirst.TabStop = true;
            this.radioButtonFirst.Text = "Первая";
            this.radioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecond
            // 
            this.radioButtonSecond.AutoSize = true;
            this.radioButtonSecond.Location = new System.Drawing.Point(7, 44);
            this.radioButtonSecond.Name = "radioButtonSecond";
            this.radioButtonSecond.Size = new System.Drawing.Size(61, 17);
            this.radioButtonSecond.TabIndex = 2;
            this.radioButtonSecond.TabStop = true;
            this.radioButtonSecond.Text = "Вторая";
            this.radioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(149, 40);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(75, 98);
            this.buttonDo.TabIndex = 1;
            this.buttonDo.Text = "До";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonDoS
            // 
            this.buttonDoS.Location = new System.Drawing.Point(192, 11);
            this.buttonDoS.Name = "buttonDoS";
            this.buttonDoS.Size = new System.Drawing.Size(75, 23);
            this.buttonDoS.TabIndex = 2;
            this.buttonDoS.Text = "До#";
            this.buttonDoS.UseVisualStyleBackColor = true;
            this.buttonDoS.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonRe
            // 
            this.buttonRe.Location = new System.Drawing.Point(241, 40);
            this.buttonRe.Name = "buttonRe";
            this.buttonRe.Size = new System.Drawing.Size(75, 98);
            this.buttonRe.TabIndex = 3;
            this.buttonRe.Text = "Ре";
            this.buttonRe.UseVisualStyleBackColor = true;
            this.buttonRe.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonReS
            // 
            this.buttonReS.Location = new System.Drawing.Point(290, 11);
            this.buttonReS.Name = "buttonReS";
            this.buttonReS.Size = new System.Drawing.Size(75, 23);
            this.buttonReS.TabIndex = 4;
            this.buttonReS.Text = "Ре#";
            this.buttonReS.UseVisualStyleBackColor = true;
            this.buttonReS.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonMi
            // 
            this.buttonMi.Location = new System.Drawing.Point(333, 40);
            this.buttonMi.Name = "buttonMi";
            this.buttonMi.Size = new System.Drawing.Size(75, 98);
            this.buttonMi.TabIndex = 5;
            this.buttonMi.Text = "Ми";
            this.buttonMi.UseVisualStyleBackColor = true;
            this.buttonMi.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonFa
            // 
            this.buttonFa.Location = new System.Drawing.Point(425, 40);
            this.buttonFa.Name = "buttonFa";
            this.buttonFa.Size = new System.Drawing.Size(75, 98);
            this.buttonFa.TabIndex = 6;
            this.buttonFa.Text = "Фа";
            this.buttonFa.UseVisualStyleBackColor = true;
            this.buttonFa.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonFaS
            // 
            this.buttonFaS.Location = new System.Drawing.Point(471, 11);
            this.buttonFaS.Name = "buttonFaS";
            this.buttonFaS.Size = new System.Drawing.Size(75, 23);
            this.buttonFaS.TabIndex = 7;
            this.buttonFaS.Text = "Фа#";
            this.buttonFaS.UseVisualStyleBackColor = true;
            this.buttonFaS.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonSol
            // 
            this.buttonSol.Location = new System.Drawing.Point(517, 40);
            this.buttonSol.Name = "buttonSol";
            this.buttonSol.Size = new System.Drawing.Size(75, 98);
            this.buttonSol.TabIndex = 8;
            this.buttonSol.Text = "Соль";
            this.buttonSol.UseVisualStyleBackColor = true;
            this.buttonSol.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonSolS
            // 
            this.buttonSolS.Location = new System.Drawing.Point(562, 11);
            this.buttonSolS.Name = "buttonSolS";
            this.buttonSolS.Size = new System.Drawing.Size(75, 23);
            this.buttonSolS.TabIndex = 9;
            this.buttonSolS.Text = "Соль#";
            this.buttonSolS.UseVisualStyleBackColor = true;
            this.buttonSolS.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonLa
            // 
            this.buttonLa.Location = new System.Drawing.Point(609, 40);
            this.buttonLa.Name = "buttonLa";
            this.buttonLa.Size = new System.Drawing.Size(75, 98);
            this.buttonLa.TabIndex = 10;
            this.buttonLa.Text = "Ля";
            this.buttonLa.UseVisualStyleBackColor = true;
            this.buttonLa.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonLaS
            // 
            this.buttonLaS.Location = new System.Drawing.Point(655, 11);
            this.buttonLaS.Name = "buttonLaS";
            this.buttonLaS.Size = new System.Drawing.Size(75, 23);
            this.buttonLaS.TabIndex = 11;
            this.buttonLaS.Text = "Ля#";
            this.buttonLaS.UseVisualStyleBackColor = true;
            this.buttonLaS.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonSi
            // 
            this.buttonSi.Location = new System.Drawing.Point(701, 40);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(75, 98);
            this.buttonSi.TabIndex = 12;
            this.buttonSi.Text = "Си";
            this.buttonSi.UseVisualStyleBackColor = true;
            this.buttonSi.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(149, 159);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(627, 23);
            this.buttonPause.TabIndex = 13;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // groupBoxLength
            // 
            this.groupBoxLength.Controls.Add(this.radioButtonSixteen);
            this.groupBoxLength.Controls.Add(this.radioButtonEight);
            this.groupBoxLength.Controls.Add(this.radioButtonFour);
            this.groupBoxLength.Controls.Add(this.radioButtonTwo);
            this.groupBoxLength.Controls.Add(this.radioButtonOne);
            this.groupBoxLength.Location = new System.Drawing.Point(13, 132);
            this.groupBoxLength.Name = "groupBoxLength";
            this.groupBoxLength.Size = new System.Drawing.Size(108, 152);
            this.groupBoxLength.TabIndex = 14;
            this.groupBoxLength.TabStop = false;
            this.groupBoxLength.Text = "Длительность";
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Location = new System.Drawing.Point(7, 20);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(57, 17);
            this.radioButtonOne.TabIndex = 0;
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.Text = "Целая";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwo
            // 
            this.radioButtonTwo.AutoSize = true;
            this.radioButtonTwo.Location = new System.Drawing.Point(7, 44);
            this.radioButtonTwo.Name = "radioButtonTwo";
            this.radioButtonTwo.Size = new System.Drawing.Size(87, 17);
            this.radioButtonTwo.TabIndex = 1;
            this.radioButtonTwo.TabStop = true;
            this.radioButtonTwo.Text = "Половинная";
            this.radioButtonTwo.UseVisualStyleBackColor = true;
            // 
            // radioButtonFour
            // 
            this.radioButtonFour.AutoSize = true;
            this.radioButtonFour.Location = new System.Drawing.Point(7, 68);
            this.radioButtonFour.Name = "radioButtonFour";
            this.radioButtonFour.Size = new System.Drawing.Size(85, 17);
            this.radioButtonFour.TabIndex = 2;
            this.radioButtonFour.TabStop = true;
            this.radioButtonFour.Text = "Четвертная";
            this.radioButtonFour.UseVisualStyleBackColor = true;
            // 
            // radioButtonEight
            // 
            this.radioButtonEight.AutoSize = true;
            this.radioButtonEight.Location = new System.Drawing.Point(7, 92);
            this.radioButtonEight.Name = "radioButtonEight";
            this.radioButtonEight.Size = new System.Drawing.Size(70, 17);
            this.radioButtonEight.TabIndex = 3;
            this.radioButtonEight.TabStop = true;
            this.radioButtonEight.Text = "Восьмая";
            this.radioButtonEight.UseVisualStyleBackColor = true;
            // 
            // radioButtonSixteen
            // 
            this.radioButtonSixteen.AutoSize = true;
            this.radioButtonSixteen.Location = new System.Drawing.Point(7, 116);
            this.radioButtonSixteen.Name = "radioButtonSixteen";
            this.radioButtonSixteen.Size = new System.Drawing.Size(98, 17);
            this.radioButtonSixteen.TabIndex = 4;
            this.radioButtonSixteen.TabStop = true;
            this.radioButtonSixteen.Text = "Шестнадцатая";
            this.radioButtonSixteen.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(149, 204);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(627, 20);
            this.textBoxResult.TabIndex = 15;
            // 
            // radioButtonThird
            // 
            this.radioButtonThird.AutoSize = true;
            this.radioButtonThird.Location = new System.Drawing.Point(7, 68);
            this.radioButtonThird.Name = "radioButtonThird";
            this.radioButtonThird.Size = new System.Drawing.Size(61, 17);
            this.radioButtonThird.TabIndex = 3;
            this.radioButtonThird.TabStop = true;
            this.radioButtonThird.Text = "Третья";
            this.radioButtonThird.UseVisualStyleBackColor = true;
            // 
            // textBoxBpm
            // 
            this.textBoxBpm.Location = new System.Drawing.Point(65, 298);
            this.textBoxBpm.Name = "textBoxBpm";
            this.textBoxBpm.Size = new System.Drawing.Size(56, 20);
            this.textBoxBpm.TabIndex = 16;
            this.textBoxBpm.Text = "120";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 301);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 17;
            this.label.Text = "Уд/мин";
            // 
            // buttonDelLastNote
            // 
            this.buttonDelLastNote.Location = new System.Drawing.Point(149, 244);
            this.buttonDelLastNote.Name = "buttonDelLastNote";
            this.buttonDelLastNote.Size = new System.Drawing.Size(158, 23);
            this.buttonDelLastNote.TabIndex = 18;
            this.buttonDelLastNote.Text = "Удалить последнюю ноту";
            this.buttonDelLastNote.UseVisualStyleBackColor = true;
            this.buttonDelLastNote.Click += new System.EventHandler(this.buttonDelLastNote_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(320, 244);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(63, 23);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(396, 244);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(99, 23);
            this.buttonGenerate.TabIndex = 20;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(508, 244);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 23);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPlay.Location = new System.Drawing.Point(641, 244);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(133, 23);
            this.buttonPlay.TabIndex = 22;
            this.buttonPlay.Text = "Вопроизвести";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelLastNote);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxBpm);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBoxLength);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonSi);
            this.Controls.Add(this.buttonLaS);
            this.Controls.Add(this.buttonLa);
            this.Controls.Add(this.buttonSolS);
            this.Controls.Add(this.buttonSol);
            this.Controls.Add(this.buttonFaS);
            this.Controls.Add(this.buttonFa);
            this.Controls.Add(this.buttonMi);
            this.Controls.Add(this.buttonReS);
            this.Controls.Add(this.buttonRe);
            this.Controls.Add(this.buttonDoS);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.groupBoxOctave);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор музыки";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOctave.ResumeLayout(false);
            this.groupBoxOctave.PerformLayout();
            this.groupBoxLength.ResumeLayout(false);
            this.groupBoxLength.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOctave;
        private System.Windows.Forms.RadioButton radioButtonSecond;
        private System.Windows.Forms.RadioButton radioButtonFirst;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Button buttonDoS;
        private System.Windows.Forms.Button buttonRe;
        private System.Windows.Forms.Button buttonReS;
        private System.Windows.Forms.Button buttonMi;
        private System.Windows.Forms.Button buttonFa;
        private System.Windows.Forms.Button buttonFaS;
        private System.Windows.Forms.Button buttonSol;
        private System.Windows.Forms.Button buttonSolS;
        private System.Windows.Forms.Button buttonLa;
        private System.Windows.Forms.Button buttonLaS;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.GroupBox groupBoxLength;
        private System.Windows.Forms.RadioButton radioButtonSixteen;
        private System.Windows.Forms.RadioButton radioButtonEight;
        private System.Windows.Forms.RadioButton radioButtonFour;
        private System.Windows.Forms.RadioButton radioButtonTwo;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RadioButton radioButtonThird;
        private System.Windows.Forms.TextBox textBoxBpm;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonDelLastNote;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPlay;
    }
}