namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBadHabits = new System.Windows.Forms.TextBox();
            this.numericUpDownDy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelHabits = new System.Windows.Forms.Label();
            this.labelWalked = new System.Windows.Forms.Label();
            this.numericUpDownLastDayWalked = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLastMonthWalkedMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLastWallkedYear = new System.Windows.Forms.NumericUpDown();
            this.listBoxAnimalsNotReserved = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxAnimalsReserved = new System.Windows.Forms.ListBox();
            this.Reserved = new System.Windows.Forms.Label();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.buttonUnReserve = new System.Windows.Forms.Button();
            this.comboBoxFindAnimal = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastDayWalked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastMonthWalkedMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWallkedYear)).BeginInit();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(28, 27);
            this.animalTypeComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(277, 37);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(324, 22);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(7);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(149, 51);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(488, 22);
            this.showInfoButton.Margin = new System.Windows.Forms.Padding(7);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(175, 51);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(28, 112);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(277, 35);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxBadHabits
            // 
            this.textBoxBadHabits.Location = new System.Drawing.Point(28, 253);
            this.textBoxBadHabits.Name = "textBoxBadHabits";
            this.textBoxBadHabits.Size = new System.Drawing.Size(428, 35);
            this.textBoxBadHabits.TabIndex = 5;
            // 
            // numericUpDownDy
            // 
            this.numericUpDownDy.Location = new System.Drawing.Point(28, 186);
            this.numericUpDownDy.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDy.Name = "numericUpDownDy";
            this.numericUpDownDy.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownDy.TabIndex = 6;
            this.numericUpDownDy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(185, 186);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownMonth.TabIndex = 7;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(336, 186);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Birthday";
            // 
            // LabelHabits
            // 
            this.LabelHabits.AutoSize = true;
            this.LabelHabits.Location = new System.Drawing.Point(23, 224);
            this.LabelHabits.Name = "LabelHabits";
            this.LabelHabits.Size = new System.Drawing.Size(130, 29);
            this.LabelHabits.TabIndex = 11;
            this.LabelHabits.Text = "Bda Habits";
            // 
            // labelWalked
            // 
            this.labelWalked.AutoSize = true;
            this.labelWalked.Location = new System.Drawing.Point(23, 224);
            this.labelWalked.Name = "labelWalked";
            this.labelWalked.Size = new System.Drawing.Size(146, 29);
            this.labelWalked.TabIndex = 12;
            this.labelWalked.Text = "Last walked:";
            // 
            // numericUpDownLastDayWalked
            // 
            this.numericUpDownLastDayWalked.Location = new System.Drawing.Point(33, 254);
            this.numericUpDownLastDayWalked.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownLastDayWalked.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLastDayWalked.Name = "numericUpDownLastDayWalked";
            this.numericUpDownLastDayWalked.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownLastDayWalked.TabIndex = 13;
            this.numericUpDownLastDayWalked.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLastMonthWalkedMonth
            // 
            this.numericUpDownLastMonthWalkedMonth.Location = new System.Drawing.Point(175, 253);
            this.numericUpDownLastMonthWalkedMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownLastMonthWalkedMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLastMonthWalkedMonth.Name = "numericUpDownLastMonthWalkedMonth";
            this.numericUpDownLastMonthWalkedMonth.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownLastMonthWalkedMonth.TabIndex = 14;
            this.numericUpDownLastMonthWalkedMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLastWallkedYear
            // 
            this.numericUpDownLastWallkedYear.Location = new System.Drawing.Point(336, 254);
            this.numericUpDownLastWallkedYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownLastWallkedYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDownLastWallkedYear.Name = "numericUpDownLastWallkedYear";
            this.numericUpDownLastWallkedYear.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownLastWallkedYear.TabIndex = 15;
            this.numericUpDownLastWallkedYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // listBoxAnimalsNotReserved
            // 
            this.listBoxAnimalsNotReserved.FormattingEnabled = true;
            this.listBoxAnimalsNotReserved.ItemHeight = 29;
            this.listBoxAnimalsNotReserved.Location = new System.Drawing.Point(739, 56);
            this.listBoxAnimalsNotReserved.Name = "listBoxAnimalsNotReserved";
            this.listBoxAnimalsNotReserved.Size = new System.Drawing.Size(634, 584);
            this.listBoxAnimalsNotReserved.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Not reserved:";
            // 
            // listBoxAnimalsReserved
            // 
            this.listBoxAnimalsReserved.FormattingEnabled = true;
            this.listBoxAnimalsReserved.ItemHeight = 29;
            this.listBoxAnimalsReserved.Location = new System.Drawing.Point(1402, 56);
            this.listBoxAnimalsReserved.Name = "listBoxAnimalsReserved";
            this.listBoxAnimalsReserved.Size = new System.Drawing.Size(634, 584);
            this.listBoxAnimalsReserved.TabIndex = 18;
            // 
            // Reserved
            // 
            this.Reserved.AutoSize = true;
            this.Reserved.Location = new System.Drawing.Point(1407, 9);
            this.Reserved.Name = "Reserved";
            this.Reserved.Size = new System.Drawing.Size(123, 29);
            this.Reserved.TabIndex = 19;
            this.Reserved.Text = "Reserved:";
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Location = new System.Drawing.Point(748, 661);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(179, 56);
            this.ButtonReserve.TabIndex = 20;
            this.ButtonReserve.Text = "Reserve";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // buttonUnReserve
            // 
            this.buttonUnReserve.Location = new System.Drawing.Point(1402, 661);
            this.buttonUnReserve.Name = "buttonUnReserve";
            this.buttonUnReserve.Size = new System.Drawing.Size(179, 56);
            this.buttonUnReserve.TabIndex = 21;
            this.buttonUnReserve.Text = "Unreserve";
            this.buttonUnReserve.UseVisualStyleBackColor = true;
            this.buttonUnReserve.Click += new System.EventHandler(this.buttonUnReserve_Click);
            // 
            // comboBoxFindAnimal
            // 
            this.comboBoxFindAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFindAnimal.FormattingEnabled = true;
            this.comboBoxFindAnimal.Location = new System.Drawing.Point(16, 647);
            this.comboBoxFindAnimal.Margin = new System.Windows.Forms.Padding(7);
            this.comboBoxFindAnimal.Name = "comboBoxFindAnimal";
            this.comboBoxFindAnimal.Size = new System.Drawing.Size(277, 37);
            this.comboBoxFindAnimal.TabIndex = 22;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(336, 639);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(7);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(149, 51);
            this.buttonFind.TabIndex = 23;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(514, 639);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 51);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2168, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxFindAnimal);
            this.Controls.Add(this.buttonUnReserve);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.Reserved);
            this.Controls.Add(this.listBoxAnimalsReserved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxAnimalsNotReserved);
            this.Controls.Add(this.numericUpDownLastWallkedYear);
            this.Controls.Add(this.numericUpDownLastMonthWalkedMonth);
            this.Controls.Add(this.numericUpDownLastDayWalked);
            this.Controls.Add(this.labelWalked);
            this.Controls.Add(this.LabelHabits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.numericUpDownDy);
            this.Controls.Add(this.textBoxBadHabits);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastDayWalked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastMonthWalkedMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWallkedYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBadHabits;
        private System.Windows.Forms.NumericUpDown numericUpDownDy;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelHabits;
        private System.Windows.Forms.Label labelWalked;
        private System.Windows.Forms.NumericUpDown numericUpDownLastDayWalked;
        private System.Windows.Forms.NumericUpDown numericUpDownLastMonthWalkedMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownLastWallkedYear;
        private System.Windows.Forms.ListBox listBoxAnimalsNotReserved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAnimalsReserved;
        private System.Windows.Forms.Label Reserved;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.Button buttonUnReserve;
        private System.Windows.Forms.ComboBox comboBoxFindAnimal;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
    }
}

