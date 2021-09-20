
namespace RandomStudent2
{
    partial class RSG
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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_available = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_random = new System.Windows.Forms.ListBox();
            this.btn_getNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Students";
            // 
            // lst_available
            // 
            this.lst_available.FormattingEnabled = true;
            this.lst_available.ItemHeight = 37;
            this.lst_available.Items.AddRange(new object[] {
            "Alejandro",
            "Austin",
            "Cuong",
            "Daniel",
            "Dennis",
            "Erik",
            "Joe",
            "Joshua",
            "Lumiere",
            "Michael",
            "Precious",
            "Scott",
            "William",
            "Yohan"});
            this.lst_available.Location = new System.Drawing.Point(37, 84);
            this.lst_available.Name = "lst_available";
            this.lst_available.Size = new System.Drawing.Size(274, 522);
            this.lst_available.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Random Students";
            // 
            // lst_random
            // 
            this.lst_random.FormattingEnabled = true;
            this.lst_random.ItemHeight = 37;
            this.lst_random.Location = new System.Drawing.Point(455, 84);
            this.lst_random.Name = "lst_random";
            this.lst_random.Size = new System.Drawing.Size(276, 522);
            this.lst_random.TabIndex = 3;
            // 
            // btn_getNext
            // 
            this.btn_getNext.Location = new System.Drawing.Point(897, 84);
            this.btn_getNext.Name = "btn_getNext";
            this.btn_getNext.Size = new System.Drawing.Size(221, 86);
            this.btn_getNext.TabIndex = 5;
            this.btn_getNext.Text = "Get Next";
            this.btn_getNext.UseVisualStyleBackColor = true;
            this.btn_getNext.Click += new System.EventHandler(this.btn_getNext_Click);
            // 
            // RSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 838);
            this.Controls.Add(this.btn_getNext);
            this.Controls.Add(this.lst_random);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_available);
            this.Controls.Add(this.label1);
            this.Name = "RSG";
            this.Text = "Random Student Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_available;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_random;
        private System.Windows.Forms.Button btn_getNext;
    }
}

