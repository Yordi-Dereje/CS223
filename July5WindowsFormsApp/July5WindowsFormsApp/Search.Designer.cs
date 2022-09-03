namespace July5WindowsFormsApp
{
    partial class Search
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComp = new System.Windows.Forms.TextBox();
            this.tbAvail = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.lblObjName = new System.Windows.Forms.Label();
            this.dpt = new System.Windows.Forms.DateTimePicker();
            this.tbInvNum = new System.Windows.Forms.TextBox();
            this.lblinvnum = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(152, 26);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(288, 22);
            this.tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(456, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbComp);
            this.panel1.Controls.Add(this.tbAvail);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbCount);
            this.panel1.Controls.Add(this.tbObjName);
            this.panel1.Controls.Add(this.lblObjName);
            this.panel1.Controls.Add(this.dpt);
            this.panel1.Controls.Add(this.tbInvNum);
            this.panel1.Controls.Add(this.lblinvnum);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Location = new System.Drawing.Point(90, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 489);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Completed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Availability";
            // 
            // tbComp
            // 
            this.tbComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComp.Location = new System.Drawing.Point(404, 292);
            this.tbComp.Name = "tbComp";
            this.tbComp.Size = new System.Drawing.Size(100, 28);
            this.tbComp.TabIndex = 55;
            // 
            // tbAvail
            // 
            this.tbAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAvail.Location = new System.Drawing.Point(404, 241);
            this.tbAvail.Name = "tbAvail";
            this.tbAvail.Size = new System.Drawing.Size(100, 28);
            this.tbAvail.TabIndex = 54;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(291, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 39);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(106, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 39);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 51;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(45, 304);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 22);
            this.lblPrice.TabIndex = 50;
            this.lblPrice.Text = "Price";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(38, 253);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(58, 22);
            this.lblCount.TabIndex = 49;
            this.lblCount.Text = "Count";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(152, 298);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 28);
            this.tbPrice.TabIndex = 48;
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCount.Location = new System.Drawing.Point(152, 247);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 28);
            this.tbCount.TabIndex = 47;
            // 
            // tbObjName
            // 
            this.tbObjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjName.Location = new System.Drawing.Point(224, 174);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(270, 28);
            this.tbObjName.TabIndex = 46;
            // 
            // lblObjName
            // 
            this.lblObjName.AutoSize = true;
            this.lblObjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjName.Location = new System.Drawing.Point(54, 180);
            this.lblObjName.Name = "lblObjName";
            this.lblObjName.Size = new System.Drawing.Size(114, 22);
            this.lblObjName.TabIndex = 45;
            this.lblObjName.Text = "Object Name";
            // 
            // dpt
            // 
            this.dpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpt.Location = new System.Drawing.Point(224, 64);
            this.dpt.Name = "dpt";
            this.dpt.Size = new System.Drawing.Size(314, 28);
            this.dpt.TabIndex = 44;
            // 
            // tbInvNum
            // 
            this.tbInvNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvNum.Location = new System.Drawing.Point(224, 122);
            this.tbInvNum.Name = "tbInvNum";
            this.tbInvNum.Size = new System.Drawing.Size(315, 28);
            this.tbInvNum.TabIndex = 43;
            // 
            // lblinvnum
            // 
            this.lblinvnum.AutoSize = true;
            this.lblinvnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvnum.Location = new System.Drawing.Point(17, 125);
            this.lblinvnum.Name = "lblinvnum";
            this.lblinvnum.Size = new System.Drawing.Size(151, 22);
            this.lblinvnum.TabIndex = 42;
            this.lblinvnum.Text = "Inventory Number";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(120, 70);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 22);
            this.lbldate.TabIndex = 41;
            this.lbldate.Text = "Date";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(95, 16);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(73, 22);
            this.lblNum.TabIndex = 40;
            this.lblNum.Text = "Number";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(751, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.Label lblObjName;
        private System.Windows.Forms.DateTimePicker dpt;
        private System.Windows.Forms.TextBox tbInvNum;
        private System.Windows.Forms.Label lblinvnum;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbComp;
        private System.Windows.Forms.TextBox tbAvail;
    }
}