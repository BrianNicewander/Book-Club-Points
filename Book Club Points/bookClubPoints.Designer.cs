namespace Book_Club_Points
{
    partial class bookClubPoints
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
            this.btnEnterbooks = new System.Windows.Forms.Button();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnterbooks
            // 
            this.btnEnterbooks.Location = new System.Drawing.Point(184, 102);
            this.btnEnterbooks.Name = "btnEnterbooks";
            this.btnEnterbooks.Size = new System.Drawing.Size(100, 37);
            this.btnEnterbooks.TabIndex = 0;
            this.btnEnterbooks.Text = "Enter amount of books";
            this.btnEnterbooks.UseVisualStyleBackColor = true;
            this.btnEnterbooks.Click += new System.EventHandler(this.btnEnterbooks_Click);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.Location = new System.Drawing.Point(82, 35);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(312, 16);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Please enter the number of books being purchased";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(181, 169);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(109, 16);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Number of points";
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(184, 65);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(100, 20);
            this.txtBooks.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(184, 199);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 23);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookClubPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 257);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.btnEnterbooks);
            this.Name = "bookClubPoints";
            this.Text = "Book Club Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterbooks;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label lblOutput;
    }
}

