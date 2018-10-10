namespace cashRegister
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
            this.fryBox = new System.Windows.Forms.TextBox();
            this.burgBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.burgLabel = new System.Windows.Forms.Label();
            this.fryLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.subTotLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tendLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.totalLine = new System.Windows.Forms.Label();
            this.tendBox = new System.Windows.Forms.TextBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.tendErrorLabel = new System.Windows.Forms.Label();
            this.subTotDisplayLabel = new System.Windows.Forms.Label();
            this.taxDisplayLabel = new System.Windows.Forms.Label();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.calcErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fryBox
            // 
            this.fryBox.Location = new System.Drawing.Point(170, 86);
            this.fryBox.Name = "fryBox";
            this.fryBox.Size = new System.Drawing.Size(52, 20);
            this.fryBox.TabIndex = 0;
            // 
            // burgBox
            // 
            this.burgBox.Location = new System.Drawing.Point(170, 51);
            this.burgBox.Name = "burgBox";
            this.burgBox.Size = new System.Drawing.Size(52, 20);
            this.burgBox.TabIndex = 1;
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(170, 120);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(52, 20);
            this.drinkBox.TabIndex = 2;
            // 
            // burgLabel
            // 
            this.burgLabel.AutoSize = true;
            this.burgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgLabel.Location = new System.Drawing.Point(33, 51);
            this.burgLabel.Name = "burgLabel";
            this.burgLabel.Size = new System.Drawing.Size(128, 16);
            this.burgLabel.TabIndex = 3;
            this.burgLabel.Text = "Number of Burger(s)";
            // 
            // fryLabel
            // 
            this.fryLabel.AutoSize = true;
            this.fryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryLabel.Location = new System.Drawing.Point(33, 86);
            this.fryLabel.Name = "fryLabel";
            this.fryLabel.Size = new System.Drawing.Size(103, 16);
            this.fryLabel.TabIndex = 4;
            this.fryLabel.Text = "Number of Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(33, 120);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(119, 16);
            this.drinkLabel.TabIndex = 5;
            this.drinkLabel.Text = "Number of Drink(s)";
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Gainsboro;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(36, 146);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(186, 25);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subTotLabel
            // 
            this.subTotLabel.AutoSize = true;
            this.subTotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotLabel.Location = new System.Drawing.Point(33, 207);
            this.subTotLabel.Name = "subTotLabel";
            this.subTotLabel.Size = new System.Drawing.Size(66, 16);
            this.subTotLabel.TabIndex = 7;
            this.subTotLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(33, 233);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(31, 16);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(33, 260);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(39, 16);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // tendLabel
            // 
            this.tendLabel.AutoSize = true;
            this.tendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendLabel.Location = new System.Drawing.Point(33, 305);
            this.tendLabel.Name = "tendLabel";
            this.tendLabel.Size = new System.Drawing.Size(68, 16);
            this.tendLabel.TabIndex = 10;
            this.tendLabel.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(33, 387);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(55, 16);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Text = "Change";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(36, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(186, 25);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Gainsboro;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(36, 412);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(186, 26);
            this.receiptButton.TabIndex = 13;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.titleLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(566, 39);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "Generic Food Place";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLine
            // 
            this.totalLine.AutoSize = true;
            this.totalLine.Location = new System.Drawing.Point(33, 276);
            this.totalLine.Name = "totalLine";
            this.totalLine.Size = new System.Drawing.Size(193, 13);
            this.totalLine.TabIndex = 15;
            this.totalLine.Text = "_______________________________";
            // 
            // tendBox
            // 
            this.tendBox.Location = new System.Drawing.Point(164, 301);
            this.tendBox.Name = "tendBox";
            this.tendBox.Size = new System.Drawing.Size(58, 20);
            this.tendBox.TabIndex = 16;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Gainsboro;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(288, 412);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(176, 26);
            this.newOrderButton.TabIndex = 17;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            // 
            // tendErrorLabel
            // 
            this.tendErrorLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.tendErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.tendErrorLabel.Location = new System.Drawing.Point(37, 329);
            this.tendErrorLabel.Name = "tendErrorLabel";
            this.tendErrorLabel.Size = new System.Drawing.Size(185, 17);
            this.tendErrorLabel.TabIndex = 18;
            // 
            // subTotDisplayLabel
            // 
            this.subTotDisplayLabel.AutoSize = true;
            this.subTotDisplayLabel.Location = new System.Drawing.Point(187, 207);
            this.subTotDisplayLabel.Name = "subTotDisplayLabel";
            this.subTotDisplayLabel.Size = new System.Drawing.Size(35, 13);
            this.subTotDisplayLabel.TabIndex = 19;
            this.subTotDisplayLabel.Text = "label1";
            this.subTotDisplayLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // taxDisplayLabel
            // 
            this.taxDisplayLabel.AutoSize = true;
            this.taxDisplayLabel.Location = new System.Drawing.Point(187, 236);
            this.taxDisplayLabel.Name = "taxDisplayLabel";
            this.taxDisplayLabel.Size = new System.Drawing.Size(35, 13);
            this.taxDisplayLabel.TabIndex = 20;
            this.taxDisplayLabel.Text = "label2";
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.AutoSize = true;
            this.totalDisplayLabel.Location = new System.Drawing.Point(187, 263);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(35, 13);
            this.totalDisplayLabel.TabIndex = 21;
            this.totalDisplayLabel.Text = "label3";
            // 
            // calcErrorLabel
            // 
            this.calcErrorLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.calcErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.calcErrorLabel.Location = new System.Drawing.Point(37, 181);
            this.calcErrorLabel.Name = "calcErrorLabel";
            this.calcErrorLabel.Size = new System.Drawing.Size(185, 17);
            this.calcErrorLabel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.calcErrorLabel);
            this.Controls.Add(this.totalDisplayLabel);
            this.Controls.Add(this.taxDisplayLabel);
            this.Controls.Add(this.subTotDisplayLabel);
            this.Controls.Add(this.tendErrorLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.tendBox);
            this.Controls.Add(this.totalLine);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tendLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.fryLabel);
            this.Controls.Add(this.burgLabel);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.burgBox);
            this.Controls.Add(this.fryBox);
            this.Name = "Form1";
            this.Text = "Kashi Rejisutaa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fryBox;
        private System.Windows.Forms.TextBox burgBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Label burgLabel;
        private System.Windows.Forms.Label fryLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subTotLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tendLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label totalLine;
        private System.Windows.Forms.TextBox tendBox;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label tendErrorLabel;
        private System.Windows.Forms.Label subTotDisplayLabel;
        private System.Windows.Forms.Label taxDisplayLabel;
        private System.Windows.Forms.Label totalDisplayLabel;
        private System.Windows.Forms.Label calcErrorLabel;
    }
}

