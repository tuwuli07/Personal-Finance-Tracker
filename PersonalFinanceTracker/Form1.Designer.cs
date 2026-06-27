namespace PersonalFinanceTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // =========================
        // Summary Labels
        // =========================
        private Label lblTotalIncomeTitle;
        private Label lblTotalIncomeValue;

        private Label lblTotalExpensesTitle;
        private Label lblTotalExpensesValue;

        private Label lblNetBalanceTitle;
        private Label lblNetBalanceValue;

        // =========================
        // Transaction Entry Controls
        // =========================
        private TextBox txtAmount;
        private TextBox txtNotes;

        private ComboBox cmbCategory;

        private RadioButton rbIncome;
        private RadioButton rbExpense;

        private DateTimePicker dtDate;

        private Button btnAdd;
        private Button btnDelete;

        // =========================
        // Data Grid
        // =========================
        private DataGridView dgvTransactions;

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
        /// Required method for Designer support.
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTotalIncomeTitle = new Label();
            lblTotalIncomeValue = new Label();
            lblTotalExpensesTitle = new Label();
            lblTotalExpensesValue = new Label();
            lblNetBalanceTitle = new Label();
            lblNetBalanceValue = new Label();
            txtAmount = new TextBox();
            txtNotes = new TextBox();
            cmbCategory = new ComboBox();
            rbIncome = new RadioButton();
            rbExpense = new RadioButton();
            dtDate = new DateTimePicker();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblTotalIncomeTitle
            // 
            lblTotalIncomeTitle.AutoSize = true;
            lblTotalIncomeTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalIncomeTitle.ForeColor = Color.DimGray;
            lblTotalIncomeTitle.Location = new Point(35, 25);
            lblTotalIncomeTitle.Name = "lblTotalIncomeTitle";
            lblTotalIncomeTitle.Size = new Size(112, 23);
            lblTotalIncomeTitle.TabIndex = 0;
            lblTotalIncomeTitle.Text = "Total Income";
            // 
            // lblTotalIncomeValue
            // 
            lblTotalIncomeValue.AutoSize = true;
            lblTotalIncomeValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalIncomeValue.ForeColor = Color.ForestGreen;
            lblTotalIncomeValue.Location = new Point(35, 55);
            lblTotalIncomeValue.Name = "lblTotalIncomeValue";
            lblTotalIncomeValue.Size = new Size(94, 41);
            lblTotalIncomeValue.TabIndex = 1;
            lblTotalIncomeValue.Text = "$0.00";
            // 
            // lblTotalExpensesTitle
            // 
            lblTotalExpensesTitle.AutoSize = true;
            lblTotalExpensesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalExpensesTitle.ForeColor = Color.DimGray;
            lblTotalExpensesTitle.Location = new Point(370, 25);
            lblTotalExpensesTitle.Name = "lblTotalExpensesTitle";
            lblTotalExpensesTitle.Size = new Size(125, 23);
            lblTotalExpensesTitle.TabIndex = 2;
            lblTotalExpensesTitle.Text = "Total Expenses";
            // 
            // lblTotalExpensesValue
            // 
            lblTotalExpensesValue.AutoSize = true;
            lblTotalExpensesValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalExpensesValue.ForeColor = Color.Firebrick;
            lblTotalExpensesValue.Location = new Point(370, 55);
            lblTotalExpensesValue.Name = "lblTotalExpensesValue";
            lblTotalExpensesValue.Size = new Size(94, 41);
            lblTotalExpensesValue.TabIndex = 3;
            lblTotalExpensesValue.Text = "$0.00";
            // 
            // lblNetBalanceTitle
            // 
            lblNetBalanceTitle.AutoSize = true;
            lblNetBalanceTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNetBalanceTitle.ForeColor = Color.DimGray;
            lblNetBalanceTitle.Location = new Point(760, 25);
            lblNetBalanceTitle.Name = "lblNetBalanceTitle";
            lblNetBalanceTitle.Size = new Size(105, 23);
            lblNetBalanceTitle.TabIndex = 4;
            lblNetBalanceTitle.Text = "Net Balance";
            // 
            // lblNetBalanceValue
            // 
            lblNetBalanceValue.AutoSize = true;
            lblNetBalanceValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNetBalanceValue.ForeColor = Color.DodgerBlue;
            lblNetBalanceValue.Location = new Point(760, 55);
            lblNetBalanceValue.Name = "lblNetBalanceValue";
            lblNetBalanceValue.Size = new Size(94, 41);
            lblNetBalanceValue.TabIndex = 5;
            lblNetBalanceValue.Text = "$0.00";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(35, 135);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Enter Amount";
            txtAmount.Size = new Size(180, 30);
            txtAmount.TabIndex = 6;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(35, 180);
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Notes";
            txtNotes.Size = new Size(560, 30);
            txtNotes.TabIndex = 11;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(235, 135);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(190, 31);
            cmbCategory.TabIndex = 7;
            // 
            // rbIncome
            // 
            rbIncome.AutoSize = true;
            rbIncome.Checked = true;
            rbIncome.Location = new Point(620, 137);
            rbIncome.Name = "rbIncome";
            rbIncome.Size = new Size(88, 27);
            rbIncome.TabIndex = 9;
            rbIncome.TabStop = true;
            rbIncome.Text = "Income";
            rbIncome.UseVisualStyleBackColor = true;
            // 
            // rbExpense
            // 
            rbExpense.AutoSize = true;
            rbExpense.Location = new Point(715, 137);
            rbExpense.Name = "rbExpense";
            rbExpense.Size = new Size(93, 27);
            rbExpense.TabIndex = 10;
            rbExpense.Text = "Expense";
            rbExpense.UseVisualStyleBackColor = true;
            // 
            // dtDate
            // 
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(445, 135);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(150, 30);
            dtDate.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(620, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(755, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToResizeRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.ColumnHeadersHeight = 40;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.GridColor = Color.Gainsboro;
            dgvTransactions.Location = new Point(35, 240);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.RowTemplate.Height = 34;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(1130, 440);
            dgvTransactions.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1200, 720);
            Controls.Add(lblTotalIncomeTitle);
            Controls.Add(lblTotalIncomeValue);
            Controls.Add(lblTotalExpensesTitle);
            Controls.Add(lblTotalExpensesValue);
            Controls.Add(lblNetBalanceTitle);
            Controls.Add(lblNetBalanceValue);
            Controls.Add(txtAmount);
            Controls.Add(cmbCategory);
            Controls.Add(dtDate);
            Controls.Add(rbIncome);
            Controls.Add(rbExpense);
            Controls.Add(txtNotes);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvTransactions);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Finance Tracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}