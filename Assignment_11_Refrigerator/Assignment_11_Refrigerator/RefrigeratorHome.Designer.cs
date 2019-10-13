namespace Assignment_10_Vehicle
{
    partial class RefrigeratorHome
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
            this.textBoxMaximumWeight = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoOfItems = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWeightPerUnit = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCurrentWeight = new System.Windows.Forms.TextBox();
            this.textBoxRemainingWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum Weight It Can Take";
            // 
            // textBoxMaximumWeight
            // 
            this.textBoxMaximumWeight.Location = new System.Drawing.Point(571, 165);
            this.textBoxMaximumWeight.Name = "textBoxMaximumWeight";
            this.textBoxMaximumWeight.Size = new System.Drawing.Size(259, 26);
            this.textBoxMaximumWeight.TabIndex = 1;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(890, 159);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(87, 32);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. Of Items";
            // 
            // textBoxNoOfItems
            // 
            this.textBoxNoOfItems.Location = new System.Drawing.Point(329, 289);
            this.textBoxNoOfItems.Name = "textBoxNoOfItems";
            this.textBoxNoOfItems.Size = new System.Drawing.Size(130, 26);
            this.textBoxNoOfItems.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight (Kg)/Unit";
            // 
            // textBoxWeightPerUnit
            // 
            this.textBoxWeightPerUnit.Location = new System.Drawing.Point(716, 285);
            this.textBoxWeightPerUnit.Name = "textBoxWeightPerUnit";
            this.textBoxWeightPerUnit.Size = new System.Drawing.Size(130, 26);
            this.textBoxWeightPerUnit.TabIndex = 4;
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Location = new System.Drawing.Point(890, 282);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(96, 33);
            this.ButtonEnter.TabIndex = 5;
            this.ButtonEnter.Text = "Enter";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remaining Weight";
            // 
            // textBoxCurrentWeight
            // 
            this.textBoxCurrentWeight.Location = new System.Drawing.Point(329, 393);
            this.textBoxCurrentWeight.Name = "textBoxCurrentWeight";
            this.textBoxCurrentWeight.Size = new System.Drawing.Size(130, 26);
            this.textBoxCurrentWeight.TabIndex = 6;
            // 
            // textBoxRemainingWeight
            // 
            this.textBoxRemainingWeight.Location = new System.Drawing.Point(716, 389);
            this.textBoxRemainingWeight.Name = "textBoxRemainingWeight";
            this.textBoxRemainingWeight.Size = new System.Drawing.Size(130, 26);
            this.textBoxRemainingWeight.TabIndex = 7;
            // 
            // RefrigeratorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 648);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxRemainingWeight);
            this.Controls.Add(this.textBoxWeightPerUnit);
            this.Controls.Add(this.textBoxCurrentWeight);
            this.Controls.Add(this.textBoxNoOfItems);
            this.Controls.Add(this.textBoxMaximumWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RefrigeratorHome";
            this.Text = "RefrigeratorHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaximumWeight;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNoOfItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWeightPerUnit;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCurrentWeight;
        private System.Windows.Forms.TextBox textBoxRemainingWeight;
    }
}