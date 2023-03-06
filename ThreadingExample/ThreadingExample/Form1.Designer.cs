namespace ThreadingExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_do = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lb_done = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_do
            // 
            this.btn_do.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_do.Location = new System.Drawing.Point(310, 166);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(179, 79);
            this.btn_do.TabIndex = 0;
            this.btn_do.Text = "START";
            this.btn_do.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_stop.Location = new System.Drawing.Point(310, 166);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(179, 79);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Visible = false;
            // 
            // lb_done
            // 
            this.lb_done.AutoSize = true;
            this.lb_done.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_done.Location = new System.Drawing.Point(332, 98);
            this.lb_done.Name = "lb_done";
            this.lb_done.Size = new System.Drawing.Size(120, 32);
            this.lb_done.TabIndex = 2;
            this.lb_done.Text = "LEFUTOTT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_done);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_do);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_do;
        private Button btn_stop;
        private Label lb_done;
    }
}