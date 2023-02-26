namespace PCSUGGESTER
{
    partial class mainpage
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
            this.Selection = new System.Windows.Forms.Panel();
            this.yourpc = new System.Windows.Forms.Label();
            this.Graphics = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.storage = new System.Windows.Forms.Label();
            this.Programs = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Selection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC-SUGGESTER";
            // 
            // Selection
            // 
            this.Selection.Controls.Add(this.Programs);
            this.Selection.Location = new System.Drawing.Point(216, 37);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(673, 457);
            this.Selection.TabIndex = 1;
            // 
            // yourpc
            // 
            this.yourpc.AutoSize = true;
            this.yourpc.Location = new System.Drawing.Point(14, 57);
            this.yourpc.Name = "yourpc";
            this.yourpc.Size = new System.Drawing.Size(55, 13);
            this.yourpc.TabIndex = 2;
            this.yourpc.Text = "YOUR PC";
            // 
            // Graphics
            // 
            this.Graphics.AutoSize = true;
            this.Graphics.Location = new System.Drawing.Point(14, 84);
            this.Graphics.Name = "Graphics";
            this.Graphics.Size = new System.Drawing.Size(35, 13);
            this.Graphics.TabIndex = 3;
            this.Graphics.Text = "label2";
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(14, 112);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(35, 13);
            this.cpu.TabIndex = 4;
            this.cpu.Text = "label2";
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Location = new System.Drawing.Point(14, 138);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(35, 13);
            this.ram.TabIndex = 5;
            this.ram.Text = "label3";
            // 
            // storage
            // 
            this.storage.AutoSize = true;
            this.storage.Location = new System.Drawing.Point(14, 163);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(35, 13);
            this.storage.TabIndex = 6;
            this.storage.Text = "label2";
            // 
            // Programs
            // 
            this.Programs.FormattingEnabled = true;
            this.Programs.Location = new System.Drawing.Point(3, 3);
            this.Programs.Name = "Programs";
            this.Programs.Size = new System.Drawing.Size(202, 439);
            this.Programs.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programs";
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.storage);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.Graphics);
            this.Controls.Add(this.yourpc);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.label1);
            this.Name = "mainpage";
            this.Text = "PCS";
            this.Load += new System.EventHandler(this.mainpage_Load);
            this.Selection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Selection;
        private System.Windows.Forms.Label yourpc;
        private System.Windows.Forms.Label Graphics;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Label storage;
        private System.Windows.Forms.CheckedListBox Programs;
        private System.Windows.Forms.Label label2;
    }
}

