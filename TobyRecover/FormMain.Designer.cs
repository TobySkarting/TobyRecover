namespace TobyRecover
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbLists = new System.Windows.Forms.ListBox();
            this.lvCards = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbHistory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbLists
            // 
            this.lbLists.FormattingEnabled = true;
            this.lbLists.ItemHeight = 12;
            this.lbLists.Location = new System.Drawing.Point(12, 29);
            this.lbLists.Name = "lbLists";
            this.lbLists.Size = new System.Drawing.Size(139, 520);
            this.lbLists.TabIndex = 2;
            this.lbLists.SelectedIndexChanged += new System.EventHandler(this.lbLists_SelectedIndexChanged);
            // 
            // lvCards
            // 
            this.lvCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCards.HideSelection = false;
            this.lvCards.Location = new System.Drawing.Point(157, 29);
            this.lvCards.Name = "lvCards";
            this.lvCards.Size = new System.Drawing.Size(395, 520);
            this.lvCards.TabIndex = 3;
            this.lvCards.UseCompatibleStateImageBehavior = false;
            this.lvCards.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Url";
            this.columnHeader3.Width = 180;
            // 
            // cbHistory
            // 
            this.cbHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHistory.FormattingEnabled = true;
            this.cbHistory.Location = new System.Drawing.Point(81, 3);
            this.cbHistory.Name = "cbHistory";
            this.cbHistory.Size = new System.Drawing.Size(121, 20);
            this.cbHistory.TabIndex = 5;
            this.cbHistory.SelectedIndexChanged += new System.EventHandler(this.cbHistory_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 555);
            this.Controls.Add(this.cbHistory);
            this.Controls.Add(this.lvCards);
            this.Controls.Add(this.lbLists);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "TobyRecover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbLists;
        private System.Windows.Forms.ListView lvCards;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbHistory;
    }
}

