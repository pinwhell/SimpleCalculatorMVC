using System.Windows.Forms;

namespace CalculatorMVC
{
    public partial class CalculatorForm : Form
    {
        CalculatorController mController;

        public CalculatorForm()
        {
            mController = new CalculatorController(this);

            InitializeComponent();

            btnReset.Click += OnAnyClicked;

            btnAdd.Click += OnAnyClicked;
            btnSub.Click += OnAnyClicked;
            btnMultiply.Click += OnAnyClicked;
            btnDivide.Click += OnAnyClicked;

            btnDot.Click += OnAnyClicked;

            btnN0.Click += OnAnyClicked;
            btnN1.Click += OnAnyClicked;
            btnN2.Click += OnAnyClicked;
            btnN3.Click += OnAnyClicked;
            btnN4.Click += OnAnyClicked;
            btnN5.Click += OnAnyClicked;
            btnN6.Click += OnAnyClicked;
            btnN7.Click += OnAnyClicked;
            btnN8.Click += OnAnyClicked;
            btnN9.Click += OnAnyClicked;

            btnEqual.Click += OnAnyClicked;

            btnMinimize.Click += (object? sender, EventArgs eventArgs) =>
            {
                WindowState = FormWindowState.Minimized;
            };

            btnExit.Click += (object? sender, EventArgs eventArgs) =>
            {
                Application.Exit();
            };

            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;

            headBox.MouseDown += Form1_MouseDown;
            headBox.MouseMove += Form1_MouseMove;
            headBox.MouseUp += Form1_MouseUp;

        }

        private bool isDragging = false;
        private Point dragStartPosition;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPosition = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - dragStartPosition.X, currentPos.Y - dragStartPosition.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        public void OnAnyClicked(object? sender, EventArgs e)
        {
            Control? control = sender as Control;

            if (control == null)
                return;

            mController.HandleInput(control.Text[0]);

            tvDisplayOperation.Text = mController.ComputeFullOperation();
            tvDisplayResult.Text = mController.ComputeFullResult();
        }
    }
}