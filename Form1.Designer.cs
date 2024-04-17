namespace fitnesa_aplikācija
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
            this.components = new System.ComponentModel.Container();
            this.B_SS = new System.Windows.Forms.Button();
            this.rtb_taimers = new System.Windows.Forms.RichTextBox();
            this.B_pauz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.B_Step = new System.Windows.Forms.Button();
            this.rtb_step = new System.Windows.Forms.RichTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // B_SS
            // 
            this.B_SS.Location = new System.Drawing.Point(63, 32);
            this.B_SS.Name = "B_SS";
            this.B_SS.Size = new System.Drawing.Size(75, 23);
            this.B_SS.TabIndex = 0;
            this.B_SS.Text = "Start";
            this.B_SS.UseVisualStyleBackColor = true;
            this.B_SS.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_taimers
            // 
            this.rtb_taimers.Location = new System.Drawing.Point(263, 12);
            this.rtb_taimers.Name = "rtb_taimers";
            this.rtb_taimers.Size = new System.Drawing.Size(139, 43);
            this.rtb_taimers.TabIndex = 1;
            this.rtb_taimers.Text = "";
            this.rtb_taimers.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // B_pauz
            // 
            this.B_pauz.Location = new System.Drawing.Point(168, 32);
            this.B_pauz.Name = "B_pauz";
            this.B_pauz.Size = new System.Drawing.Size(75, 23);
            this.B_pauz.TabIndex = 2;
            this.B_pauz.Text = "pauze";
            this.B_pauz.UseVisualStyleBackColor = true;
            this.B_pauz.Click += new System.EventHandler(this.B_pauz_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // B_Step
            // 
            this.B_Step.Location = new System.Drawing.Point(99, 160);
            this.B_Step.Name = "B_Step";
            this.B_Step.Size = new System.Drawing.Size(75, 23);
            this.B_Step.TabIndex = 3;
            this.B_Step.Text = "button1";
            this.B_Step.UseVisualStyleBackColor = true;
            this.B_Step.Click += new System.EventHandler(this.B_Step_Click);
            // 
            // rtb_step
            // 
            this.rtb_step.Location = new System.Drawing.Point(263, 102);
            this.rtb_step.Name = "rtb_step";
            this.rtb_step.Size = new System.Drawing.Size(100, 96);
            this.rtb_step.TabIndex = 4;
            this.rtb_step.Text = "";
            this.rtb_step.TextChanged += new System.EventHandler(this.rtb_step_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(493, 117);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 154);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.rtb_step);
            this.Controls.Add(this.B_Step);
            this.Controls.Add(this.B_pauz);
            this.Controls.Add(this.rtb_taimers);
            this.Controls.Add(this.B_SS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_SS;
        private System.Windows.Forms.RichTextBox rtb_taimers;
        private System.Windows.Forms.Button B_pauz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button B_Step;
        private System.Windows.Forms.RichTextBox rtb_step;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

