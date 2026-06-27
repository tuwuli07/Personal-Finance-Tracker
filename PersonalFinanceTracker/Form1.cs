using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PersonalFinanceTracker
{
    public partial class Form1 : Form
    {
        private BindingList<Transaction> transactions = new BindingList<Transaction>();

        public Form1()
        {
            InitializeComponent();

            LoadCategories();

            dgvTransactions.AutoGenerateColumns = true;
            dgvTransactions.DataSource = transactions;

            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;

            UpdateSummary();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.AddRange(new string[]
            {
                "Salary",
                "Food",
                "Transport",
                "Shopping",
                "Bills",
                "Entertainment",
                "Health",
                "Education",
                "Investment",
                "Others"
            });

            cmbCategory.SelectedIndex = 0;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                MessageBox.Show(
                    "Please enter a valid amount.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAmount.Focus();
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show(
                    "Amount must be greater than zero.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Transaction transaction = new Transaction
            {
                Date = dtDate.Value.Date,
                Type = rbIncome.Checked ? "Income" : "Expense",
                Category = cmbCategory.Text,
                Amount = amount,
                Notes = txtNotes.Text.Trim()
            };

            transactions.Add(transaction);

            ClearInputs();

            UpdateSummary();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow == null)
            {
                MessageBox.Show(
                    "Select a transaction first.",
                    "Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            Transaction transaction =
                (Transaction)dgvTransactions.CurrentRow.DataBoundItem;

            transactions.Remove(transaction);

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            decimal income = transactions
                .Where(t => t.Type == "Income")
                .Sum(t => t.Amount);

            decimal expense = transactions
                .Where(t => t.Type == "Expense")
                .Sum(t => t.Amount);

            decimal balance = income - expense;

            lblTotalIncomeValue.Text = income.ToString("C2");
            lblTotalExpensesValue.Text = expense.ToString("C2");
            lblNetBalanceValue.Text = balance.ToString("C2");

            if (balance >= 0)
                lblNetBalanceValue.ForeColor = System.Drawing.Color.ForestGreen;
            else
                lblNetBalanceValue.ForeColor = System.Drawing.Color.Red;
        }

        private void ClearInputs()
        {
            txtAmount.Clear();
            txtNotes.Clear();

            cmbCategory.SelectedIndex = 0;

            rbIncome.Checked = true;

            dtDate.Value = DateTime.Today;

            txtAmount.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Transaction
    {
        public DateTime Date { get; set; }

        public string Type { get; set; } = "";

        public string Category { get; set; } = "";

        public decimal Amount { get; set; }

        public string Notes { get; set; } = "";
    }
}