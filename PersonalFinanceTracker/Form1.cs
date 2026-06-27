using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace PersonalFinanceTracker
{
    // ═══════════════════════════════════════════════════════════════════════════
    //  Badge cell — green "Income" / red "Expense" pill in TYPE column
    // ═══════════════════════════════════════════════════════════════════════════
    public class BadgeCell : DataGridViewTextBoxCell
    {
        protected override void Paint(
            Graphics g, Rectangle clipBounds, Rectangle cellBounds,
            int rowIndex, DataGridViewElementStates state,
            object? value, object? formattedValue, string? errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            bool selected = (state & DataGridViewElementStates.Selected) != 0;
            using var bgBrush = new SolidBrush(selected
                ? Color.FromArgb(235, 240, 255) : Color.White);
            g.FillRectangle(bgBrush, cellBounds);

            string text = formattedValue?.ToString() ?? "";
            bool isIncome = text == "Income";

            Color badgeBg = isIncome ? Color.FromArgb(220, 247, 233) : Color.FromArgb(255, 225, 225);
            Color badgeFg = isIncome ? Color.FromArgb(27, 145, 75) : Color.FromArgb(200, 50, 50);

            int bw = 72, bh = 24;
            int bx = cellBounds.X + (cellBounds.Width - bw) / 2;
            int by = cellBounds.Y + (cellBounds.Height - bh) / 2;
            Rectangle badge = new Rectangle(bx, by, bw, bh);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            using GraphicsPath path = Pill(badge, 12);
            using var fill = new SolidBrush(badgeBg);
            g.FillPath(fill, path);

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            using Font font = new Font("Segoe UI", 8.5f, FontStyle.Regular);
            using var brush = new SolidBrush(badgeFg);
            g.DrawString(text, font, brush, badge, sf);
        }

        private static GraphicsPath Pill(Rectangle b, int r)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddArc(b.X, b.Y, r * 2, r * 2, 180, 90);
            p.AddArc(b.Right - r * 2, b.Y, r * 2, r * 2, 270, 90);
            p.AddArc(b.Right - r * 2, b.Bottom - r * 2, r * 2, r * 2, 0, 90);
            p.AddArc(b.X, b.Bottom - r * 2, r * 2, r * 2, 90, 90);
            p.CloseFigure();
            return p;
        }
    }

    public class BadgeColumn : DataGridViewTextBoxColumn
    {
        public BadgeColumn() { CellTemplate = new BadgeCell(); }
    }

    // ═══════════════════════════════════════════════════════════════════════════
    //  Amount cell — "+৳ 60,000" green or "-৳ 4,200" red
    // ═══════════════════════════════════════════════════════════════════════════
    public class AmountCell : DataGridViewTextBoxCell
    {
        protected override void Paint(
            Graphics g, Rectangle clipBounds, Rectangle cellBounds,
            int rowIndex, DataGridViewElementStates state,
            object? value, object? formattedValue, string? errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            bool selected = (state & DataGridViewElementStates.Selected) != 0;
            using var bgBrush = new SolidBrush(selected
                ? Color.FromArgb(235, 240, 255) : Color.White);
            g.FillRectangle(bgBrush, cellBounds);

            string type = "";
            if (DataGridView != null && rowIndex >= 0 && rowIndex < DataGridView.Rows.Count)
                if (DataGridView.Rows[rowIndex].DataBoundItem is Transaction t)
                    type = t.Type;

            bool isIncome = type == "Income";
            string prefix = isIncome ? "+৳" : "-৳";
            Color color = isIncome ? Color.FromArgb(27, 145, 75) : Color.FromArgb(200, 50, 50);
            decimal amount = value is decimal d ? d : 0m;
            string text = $"{prefix} {amount:N0}";

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            using Font font = new Font("Segoe UI", 9f);
            using var brush = new SolidBrush(color);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawString(text, font, brush, cellBounds, sf);
        }
    }

    public class AmountColumn : DataGridViewTextBoxColumn
    {
        public AmountColumn() { CellTemplate = new AmountCell(); }
    }

    // ═══════════════════════════════════════════════════════════════════════════
    //  Main Form
    // ═══════════════════════════════════════════════════════════════════════════
    public partial class Form1 : Form
    {
        private List<Transaction> transactions = new List<Transaction>();
        public Form1()
        {
            InitializeComponent();
            SetupGridColumns();
            SetupGridStyles();
            LoadCategories();
            UpdateSummary();

            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        // ── Responsive layout — wired here, not in Designer ───────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlSummary.Resize += (s, ev) => LayoutSummaryCards();
            pnlBody.Resize += (s, ev) => LayoutBodyPanels();

            LayoutSummaryCards();
            LayoutBodyPanels();
        }

        private void LayoutSummaryCards()
        {
            int pad = 16;
            int gap = 12;
            int cw = (pnlSummary.ClientSize.Width - pad * 2 - gap * 2) / 3;
            int ch = pnlSummary.ClientSize.Height - pad;

            pnlIncomeCard.SetBounds(pad, pad, cw, ch);
            pnlExpenseCard.SetBounds(pad + cw + gap, pad, cw, ch);
            pnlBalanceCard.SetBounds(pad + (cw + gap) * 2, pad, cw, ch);
        }

        private void LayoutBodyPanels()
        {
            int pad = 8;
            int gap = 12;
            int leftW = 300;
            int w = pnlBody.ClientSize.Width - pad * 2;
            int h = pnlBody.ClientSize.Height - pad * 2;

            pnlLeft.SetBounds(pad, pad, leftW, h);
            pnlRight.SetBounds(pad + leftW + gap, pad, w - leftW - gap, h);
        }

        // ── Grid setup (custom columns cannot go in Designer) ─────────────────
        private void SetupGridColumns()
        {
            dgvTransactions.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "DATE",
                FillWeight = 90
            };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";

            BadgeColumn colType = new BadgeColumn
            {
                DataPropertyName = "Type",
                HeaderText = "TYPE",
                FillWeight = 80
            };

            DataGridViewTextBoxColumn colCat = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "CATEGORY",
                FillWeight = 100
            };

            AmountColumn colAmt = new AmountColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "AMOUNT",
                FillWeight = 90
            };
            colAmt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn colNote = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Notes",
                HeaderText = "NOTES",
                FillWeight = 140
            };

            foreach (DataGridViewColumn col in new DataGridViewColumn[]
                     { colDate, colType, colCat, colAmt, colNote })
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvTransactions.Columns.Add(col);
            }

            dgvTransactions.DataSource = transactions;
        }

        private void SetupGridStyles()
        {
            DataGridViewCellStyle hdrStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(245, 246, 250),
                ForeColor = Color.FromArgb(110, 115, 130),
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(245, 246, 250),
                SelectionForeColor = Color.FromArgb(110, 115, 130),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvTransactions.ColumnHeadersDefaultCellStyle = hdrStyle;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(30, 30, 40),
                SelectionBackColor = Color.FromArgb(235, 240, 255),
                SelectionForeColor = Color.FromArgb(30, 30, 40),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvTransactions.DefaultCellStyle = cellStyle;
        }

        // ── Categories ────────────────────────────────────────────────────────
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[]
            {
                "Salary", "Freelance", "Food", "Transport", "Utilities", "Others"
            });
            cmbCategory.SelectedIndex = 0;
        }

        // ── Add ───────────────────────────────────────────────────────────────
        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than zero.",
                    "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            transactions.Add(new Transaction
            {
                Date = dtDate.Value.Date,
                Type = rbIncome.Checked ? "Income" : "Expense",
                Category = cmbCategory.Text,
                Amount = amount,
                Notes = txtNotes.Text.Trim()
            });

            // Refresh DataGridView
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = transactions;

            ClearInputs();
            UpdateSummary();
        }

        // ── Delete ────────────────────────────────────────────────────────────
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow?.DataBoundItem is Transaction t)
            {
                transactions.Remove(t);

                // Refresh DataGridView
                dgvTransactions.DataSource = null;
                dgvTransactions.DataSource = transactions;

                UpdateSummary();
            }
            else
            {
                MessageBox.Show("Select a transaction to delete.",
                    "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ── Summary ───────────────────────────────────────────────────────────
        private void UpdateSummary()
        {
            decimal income = transactions.Where(t => t.Type == "Income").Sum(t => t.Amount);
            decimal expense = transactions.Where(t => t.Type == "Expense").Sum(t => t.Amount);
            decimal balance = income - expense;

            lblTotalIncomeValue.Text = $"৳ {income:N0}";
            lblTotalExpensesValue.Text = $"৳ {expense:N0}";
            lblNetBalanceValue.Text = $"৳ {balance:N0}";
            lblNetBalanceValue.ForeColor = balance >= 0
                ? Color.FromArgb(27, 145, 75)
                : Color.FromArgb(200, 50, 50);
        }

        // ── Clear inputs ──────────────────────────────────────────────────────
        private void ClearInputs()
        {
            txtAmount.Clear();
            txtNotes.Clear();
            cmbCategory.SelectedIndex = 0;
            rbIncome.Checked = true;
            dtDate.Value = DateTime.Today;
            txtAmount.Focus();
        }
    }
}