namespace PersonalFinanceTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSummary = new System.Windows.Forms.Panel();
            pnlIncomeCard = new System.Windows.Forms.Panel();
            lblTotalIncomeTitle = new System.Windows.Forms.Label();
            lblTotalIncomeValue = new System.Windows.Forms.Label();
            pnlExpenseCard = new System.Windows.Forms.Panel();
            lblTotalExpensesTitle = new System.Windows.Forms.Label();
            lblTotalExpensesValue = new System.Windows.Forms.Label();
            pnlBalanceCard = new System.Windows.Forms.Panel();
            lblNetBalanceTitle = new System.Windows.Forms.Label();
            lblNetBalanceValue = new System.Windows.Forms.Label();
            pnlBody = new System.Windows.Forms.Panel();
            pnlLeft = new System.Windows.Forms.Panel();
            lblFormTitle = new System.Windows.Forms.Label();
            lblAmount = new System.Windows.Forms.Label();
            txtAmount = new System.Windows.Forms.TextBox();
            lblCategory = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            lblType = new System.Windows.Forms.Label();
            pnlTypeRow = new System.Windows.Forms.Panel();
            rbIncome = new System.Windows.Forms.RadioButton();
            rbExpense = new System.Windows.Forms.RadioButton();
            lblDate = new System.Windows.Forms.Label();
            dtDate = new System.Windows.Forms.DateTimePicker();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            pnlRight = new System.Windows.Forms.Panel();
            pnlDeleteRow = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            dgvTransactions = new System.Windows.Forms.DataGridView();
            pnlSummary.SuspendLayout();
            pnlIncomeCard.SuspendLayout();
            pnlExpenseCard.SuspendLayout();
            pnlBalanceCard.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlTypeRow.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlDeleteRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();

            // pnlSummary
            pnlSummary.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            pnlSummary.Controls.Add(pnlBalanceCard);
            pnlSummary.Controls.Add(pnlExpenseCard);
            pnlSummary.Controls.Add(pnlIncomeCard);
            pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSummary.Height = 110;
            pnlSummary.Name = "pnlSummary";
            pnlSummary.TabIndex = 0;

            // pnlIncomeCard
            pnlIncomeCard.BackColor = System.Drawing.Color.White;
            pnlIncomeCard.Controls.Add(lblTotalIncomeValue);
            pnlIncomeCard.Controls.Add(lblTotalIncomeTitle);
            pnlIncomeCard.Location = new System.Drawing.Point(16, 12);
            pnlIncomeCard.Name = "pnlIncomeCard";
            pnlIncomeCard.Size = new System.Drawing.Size(300, 82);
            pnlIncomeCard.TabIndex = 0;

            // lblTotalIncomeTitle
            lblTotalIncomeTitle.AutoSize = true;
            lblTotalIncomeTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblTotalIncomeTitle.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblTotalIncomeTitle.Location = new System.Drawing.Point(16, 14);
            lblTotalIncomeTitle.Name = "lblTotalIncomeTitle";
            lblTotalIncomeTitle.TabIndex = 0;
            lblTotalIncomeTitle.Text = "\u2191  TOTAL INCOME";

            // lblTotalIncomeValue
            lblTotalIncomeValue.AutoSize = true;
            lblTotalIncomeValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTotalIncomeValue.ForeColor = System.Drawing.Color.FromArgb(27, 145, 75);
            lblTotalIncomeValue.Location = new System.Drawing.Point(14, 36);
            lblTotalIncomeValue.Name = "lblTotalIncomeValue";
            lblTotalIncomeValue.TabIndex = 1;
            lblTotalIncomeValue.Text = "\u09F3 0";

            // pnlExpenseCard
            pnlExpenseCard.BackColor = System.Drawing.Color.White;
            pnlExpenseCard.Controls.Add(lblTotalExpensesValue);
            pnlExpenseCard.Controls.Add(lblTotalExpensesTitle);
            pnlExpenseCard.Location = new System.Drawing.Point(328, 12);
            pnlExpenseCard.Name = "pnlExpenseCard";
            pnlExpenseCard.Size = new System.Drawing.Size(300, 82);
            pnlExpenseCard.TabIndex = 1;

            // lblTotalExpensesTitle
            lblTotalExpensesTitle.AutoSize = true;
            lblTotalExpensesTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblTotalExpensesTitle.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblTotalExpensesTitle.Location = new System.Drawing.Point(16, 14);
            lblTotalExpensesTitle.Name = "lblTotalExpensesTitle";
            lblTotalExpensesTitle.TabIndex = 0;
            lblTotalExpensesTitle.Text = "\u2193  TOTAL EXPENSES";

            // lblTotalExpensesValue
            lblTotalExpensesValue.AutoSize = true;
            lblTotalExpensesValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTotalExpensesValue.ForeColor = System.Drawing.Color.FromArgb(200, 50, 50);
            lblTotalExpensesValue.Location = new System.Drawing.Point(14, 36);
            lblTotalExpensesValue.Name = "lblTotalExpensesValue";
            lblTotalExpensesValue.TabIndex = 1;
            lblTotalExpensesValue.Text = "\u09F3 0";

            // pnlBalanceCard
            pnlBalanceCard.BackColor = System.Drawing.Color.White;
            pnlBalanceCard.Controls.Add(lblNetBalanceValue);
            pnlBalanceCard.Controls.Add(lblNetBalanceTitle);
            pnlBalanceCard.Location = new System.Drawing.Point(640, 12);
            pnlBalanceCard.Name = "pnlBalanceCard";
            pnlBalanceCard.Size = new System.Drawing.Size(300, 82);
            pnlBalanceCard.TabIndex = 2;

            // lblNetBalanceTitle
            lblNetBalanceTitle.AutoSize = true;
            lblNetBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblNetBalanceTitle.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblNetBalanceTitle.Location = new System.Drawing.Point(16, 14);
            lblNetBalanceTitle.Name = "lblNetBalanceTitle";
            lblNetBalanceTitle.TabIndex = 0;
            lblNetBalanceTitle.Text = "NET BALANCE";

            // lblNetBalanceValue
            lblNetBalanceValue.AutoSize = true;
            lblNetBalanceValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblNetBalanceValue.ForeColor = System.Drawing.Color.FromArgb(27, 145, 75);
            lblNetBalanceValue.Location = new System.Drawing.Point(14, 36);
            lblNetBalanceValue.Name = "lblNetBalanceValue";
            lblNetBalanceValue.TabIndex = 1;
            lblNetBalanceValue.Text = "\u09F3 0";

            // pnlBody
            pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            pnlBody.TabIndex = 1;

            // pnlLeft
            pnlLeft.BackColor = System.Drawing.Color.White;
            pnlLeft.Controls.Add(btnAdd);
            pnlLeft.Controls.Add(txtNotes);
            pnlLeft.Controls.Add(lblNotes);
            pnlLeft.Controls.Add(dtDate);
            pnlLeft.Controls.Add(lblDate);
            pnlLeft.Controls.Add(pnlTypeRow);
            pnlLeft.Controls.Add(lblType);
            pnlLeft.Controls.Add(cmbCategory);
            pnlLeft.Controls.Add(lblCategory);
            pnlLeft.Controls.Add(txtAmount);
            pnlLeft.Controls.Add(lblAmount);
            pnlLeft.Controls.Add(lblFormTitle);
            pnlLeft.Location = new System.Drawing.Point(16, 8);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            pnlLeft.Size = new System.Drawing.Size(300, 620);
            pnlLeft.TabIndex = 0;

            // lblFormTitle
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 40);
            lblFormTitle.Location = new System.Drawing.Point(20, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "+ Add Transaction";

            // lblAmount
            lblAmount.AutoSize = true;
            lblAmount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblAmount.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblAmount.Location = new System.Drawing.Point(20, 58);
            lblAmount.Name = "lblAmount";
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount (\u09F3)";

            // txtAmount
            txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtAmount.Location = new System.Drawing.Point(20, 78);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new System.Drawing.Size(260, 30);
            txtAmount.TabIndex = 2;

            // lblCategory
            lblCategory.AutoSize = true;
            lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblCategory.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblCategory.Location = new System.Drawing.Point(20, 120);
            lblCategory.Name = "lblCategory";
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";

            // cmbCategory
            cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbCategory.Location = new System.Drawing.Point(20, 140);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(260, 30);
            cmbCategory.TabIndex = 4;

            // lblType
            lblType.AutoSize = true;
            lblType.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblType.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblType.Location = new System.Drawing.Point(20, 184);
            lblType.Name = "lblType";
            lblType.TabIndex = 5;
            lblType.Text = "Type";

            // pnlTypeRow
            pnlTypeRow.BackColor = System.Drawing.Color.Transparent;
            pnlTypeRow.Controls.Add(rbIncome);
            pnlTypeRow.Controls.Add(rbExpense);
            pnlTypeRow.Location = new System.Drawing.Point(20, 204);
            pnlTypeRow.Name = "pnlTypeRow";
            pnlTypeRow.Size = new System.Drawing.Size(260, 28);
            pnlTypeRow.TabIndex = 6;

            // rbIncome
            rbIncome.AutoSize = true;
            rbIncome.Checked = true;
            rbIncome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            rbIncome.ForeColor = System.Drawing.Color.FromArgb(30, 30, 40);
            rbIncome.Location = new System.Drawing.Point(0, 2);
            rbIncome.Name = "rbIncome";
            rbIncome.Size = new System.Drawing.Size(75, 25);
            rbIncome.TabIndex = 0;
            rbIncome.TabStop = true;
            rbIncome.Text = "Income";

            // rbExpense
            rbExpense.AutoSize = true;
            rbExpense.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            rbExpense.ForeColor = System.Drawing.Color.FromArgb(30, 30, 40);
            rbExpense.Location = new System.Drawing.Point(90, 2);
            rbExpense.Name = "rbExpense";
            rbExpense.Size = new System.Drawing.Size(80, 25);
            rbExpense.TabIndex = 1;
            rbExpense.Text = "Expense";

            // lblDate
            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblDate.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblDate.Location = new System.Drawing.Point(20, 246);
            lblDate.Name = "lblDate";
            lblDate.TabIndex = 7;
            lblDate.Text = "Date";

            // dtDate
            dtDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtDate.Location = new System.Drawing.Point(20, 266);
            dtDate.Name = "dtDate";
            dtDate.Size = new System.Drawing.Size(260, 30);
            dtDate.TabIndex = 8;

            // lblNotes
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblNotes.ForeColor = System.Drawing.Color.FromArgb(110, 115, 130);
            lblNotes.Location = new System.Drawing.Point(20, 310);
            lblNotes.Name = "lblNotes";
            lblNotes.TabIndex = 9;
            lblNotes.Text = "Notes (optional)";

            // txtNotes
            txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNotes.Location = new System.Drawing.Point(20, 330);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new System.Drawing.Size(260, 30);
            txtNotes.TabIndex = 10;

            // btnAdd
            btnAdd.BackColor = System.Drawing.Color.FromArgb(66, 99, 235);
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(66, 99, 235);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(20, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(260, 42);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+ Add Transaction";
            btnAdd.UseVisualStyleBackColor = false;

            // pnlRight
            pnlRight.BackColor = System.Drawing.Color.White;
            pnlRight.Controls.Add(dgvTransactions);
            pnlRight.Controls.Add(pnlDeleteRow);
            pnlRight.Location = new System.Drawing.Point(328, 8);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(640, 620);
            pnlRight.TabIndex = 1;

            // pnlDeleteRow
            pnlDeleteRow.BackColor = System.Drawing.Color.White;
            pnlDeleteRow.Controls.Add(btnDelete);
            pnlDeleteRow.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlDeleteRow.Height = 54;
            pnlDeleteRow.Name = "pnlDeleteRow";
            pnlDeleteRow.Padding = new System.Windows.Forms.Padding(0, 8, 12, 8);
            pnlDeleteRow.TabIndex = 1;

            // btnDelete
            btnDelete.BackColor = System.Drawing.Color.White;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 50, 50);
            btnDelete.FlatAppearance.BorderSize = 1;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnDelete.ForeColor = System.Drawing.Color.FromArgb(200, 50, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(150, 38);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;

            // dgvTransactions
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToResizeRows = false;
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransactions.ColumnHeadersHeight = 42;
            dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvTransactions.GridColor = System.Drawing.Color.FromArgb(220, 222, 230);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowTemplate.Height = 48;
            dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.TabIndex = 0;

            // Form1
            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 246, 250);

            ClientSize = new System.Drawing.Size(900, 600);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = true;

            Controls.Add(pnlBody);
            Controls.Add(pnlSummary);

            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Personal Finance Tracker";

            Load += Form1_Load;

            pnlSummary.ResumeLayout(false);
            pnlIncomeCard.ResumeLayout(false);
            pnlIncomeCard.PerformLayout();
            pnlExpenseCard.ResumeLayout(false);
            pnlExpenseCard.PerformLayout();
            pnlBalanceCard.ResumeLayout(false);
            pnlBalanceCard.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlTypeRow.ResumeLayout(false);
            pnlTypeRow.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlDeleteRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlIncomeCard;
        private System.Windows.Forms.Panel pnlExpenseCard;
        private System.Windows.Forms.Panel pnlBalanceCard;
        private System.Windows.Forms.Label lblTotalIncomeTitle;
        private System.Windows.Forms.Label lblTotalIncomeValue;
        private System.Windows.Forms.Label lblTotalExpensesTitle;
        private System.Windows.Forms.Label lblTotalExpensesValue;
        private System.Windows.Forms.Label lblNetBalanceTitle;
        private System.Windows.Forms.Label lblNetBalanceValue;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTypeRow;
        private System.Windows.Forms.Panel pnlDeleteRow;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.RadioButton rbExpense;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTransactions;
    }
}