namespace SehirTahminOyunu
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yourremainingentitlement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enteredletters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpredict = new System.Windows.Forms.Button();
            this.txt_word = new System.Windows.Forms.TextBox();
            this.btn_letterenter = new System.Windows.Forms.Button();
            this.txt_letter = new System.Windows.Forms.TextBox();
            this.grpgame = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(232, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yourremainingentitlement);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.enteredletters);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnpredict);
            this.groupBox2.Controls.Add(this.txt_word);
            this.groupBox2.Controls.Add(this.btn_letterenter);
            this.groupBox2.Controls.Add(this.txt_letter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(232, 264);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(336, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answer";
            // 
            // yourremainingentitlement
            // 
            this.yourremainingentitlement.AutoSize = true;
            this.yourremainingentitlement.Location = new System.Drawing.Point(220, 98);
            this.yourremainingentitlement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yourremainingentitlement.Name = "yourremainingentitlement";
            this.yourremainingentitlement.Size = new System.Drawing.Size(19, 20);
            this.yourremainingentitlement.TabIndex = 6;
            this.yourremainingentitlement.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "your remaining entitlement:";
            // 
            // enteredletters
            // 
            this.enteredletters.AutoSize = true;
            this.enteredletters.Location = new System.Drawing.Point(135, 62);
            this.enteredletters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enteredletters.Name = "enteredletters";
            this.enteredletters.Size = new System.Drawing.Size(0, 20);
            this.enteredletters.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "entered letters:";
            // 
            // btnpredict
            // 
            this.btnpredict.Location = new System.Drawing.Point(224, 21);
            this.btnpredict.Margin = new System.Windows.Forms.Padding(2);
            this.btnpredict.Name = "btnpredict";
            this.btnpredict.Size = new System.Drawing.Size(102, 33);
            this.btnpredict.TabIndex = 3;
            this.btnpredict.Text = "Predict";
            this.btnpredict.UseVisualStyleBackColor = true;
            this.btnpredict.Click += new System.EventHandler(this.btnpredict_Click);
            // 
            // txt_word
            // 
            this.txt_word.Location = new System.Drawing.Point(164, 26);
            this.txt_word.Margin = new System.Windows.Forms.Padding(2);
            this.txt_word.Name = "txt_word";
            this.txt_word.Size = new System.Drawing.Size(56, 26);
            this.txt_word.TabIndex = 2;
            // 
            // btn_letterenter
            // 
            this.btn_letterenter.Location = new System.Drawing.Point(64, 21);
            this.btn_letterenter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_letterenter.Name = "btn_letterenter";
            this.btn_letterenter.Size = new System.Drawing.Size(95, 33);
            this.btn_letterenter.TabIndex = 1;
            this.btn_letterenter.Text = "letter enter";
            this.btn_letterenter.UseVisualStyleBackColor = true;
            this.btn_letterenter.Click += new System.EventHandler(this.btn_letterenter_Click);
            // 
            // txt_letter
            // 
            this.txt_letter.Location = new System.Drawing.Point(4, 26);
            this.txt_letter.Margin = new System.Windows.Forms.Padding(2);
            this.txt_letter.Name = "txt_letter";
            this.txt_letter.Size = new System.Drawing.Size(56, 26);
            this.txt_letter.TabIndex = 0;
            // 
            // grpgame
            // 
            this.grpgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpgame.Location = new System.Drawing.Point(232, 112);
            this.grpgame.Margin = new System.Windows.Forms.Padding(2);
            this.grpgame.Name = "grpgame";
            this.grpgame.Padding = new System.Windows.Forms.Padding(2);
            this.grpgame.Size = new System.Drawing.Size(336, 128);
            this.grpgame.TabIndex = 3;
            this.grpgame.TabStop = false;
            this.grpgame.Text = "Question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpgame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label yourremainingentitlement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label enteredletters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpredict;
        private System.Windows.Forms.TextBox txt_word;
        private System.Windows.Forms.Button btn_letterenter;
        private System.Windows.Forms.TextBox txt_letter;
        private System.Windows.Forms.GroupBox grpgame;
    }
}

