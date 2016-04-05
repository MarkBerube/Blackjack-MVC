namespace BlackjackMVC
{
    partial class BlackjackMVC
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
            this.resetButton = new System.Windows.Forms.Button();
            this.listMyHand = new System.Windows.Forms.ListView();
            this.FaceM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuitM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listDealerHand = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(376, 322);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Start/Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // listMyHand
            // 
            this.listMyHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FaceM,
            this.SuitM,
            this.ValueM});
            this.listMyHand.Location = new System.Drawing.Point(3, 39);
            this.listMyHand.Name = "listMyHand";
            this.listMyHand.Size = new System.Drawing.Size(178, 265);
            this.listMyHand.TabIndex = 2;
            this.listMyHand.UseCompatibleStateImageBehavior = false;
            this.listMyHand.View = System.Windows.Forms.View.Details;
            // 
            // FaceM
            // 
            this.FaceM.DisplayIndex = 1;
            this.FaceM.Text = "Face";
            this.FaceM.Width = 36;
            // 
            // SuitM
            // 
            this.SuitM.DisplayIndex = 0;
            this.SuitM.Text = "Suit";
            this.SuitM.Width = 52;
            // 
            // ValueM
            // 
            this.ValueM.Text = "Value";
            this.ValueM.Width = 39;
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(187, 89);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "HIT ME!";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(187, 146);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "STOP!";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dealer Hand";
            // 
            // listDealerHand
            // 
            this.listDealerHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listDealerHand.Location = new System.Drawing.Point(268, 39);
            this.listDealerHand.Name = "listDealerHand";
            this.listDealerHand.Size = new System.Drawing.Size(178, 265);
            this.listDealerHand.TabIndex = 7;
            this.listDealerHand.UseCompatibleStateImageBehavior = false;
            this.listDealerHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Face";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Suit";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 39;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(85, 331);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Ready";
            // 
            // BlackjackMVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 348);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.listDealerHand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.listMyHand);
            this.Controls.Add(this.resetButton);
            this.Name = "BlackjackMVC";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListView listMyHand;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader FaceM;
        private System.Windows.Forms.ColumnHeader SuitM;
        private System.Windows.Forms.ColumnHeader ValueM;
        private System.Windows.Forms.ListView listDealerHand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label statusLabel;
    }
}

