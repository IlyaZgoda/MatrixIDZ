namespace MatrixIDZ
{
    public partial class Matrix : Form
    {
        QuadricMatrix? A = null;
        QuadricMatrix? B = null;
        QuadricMatrix? C = null;

        public Matrix()
        {
            InitializeComponent();
        }

        private async void dimensionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(dimensionNumericUpDown.Value);
            A = new(n);

            A.Fill();
            A.Output(dataGridA);

            B = QuadricMatrix.CreateB(A);
            C = QuadricMatrix.CreateC(A);

            B.Output(dataGridB);
            C.Output(dataGridC);

            int determinantB = await B.CalculateDeterminantAsync();
            int determinantC = await C.CalculateDeterminantAsync();

            determinantLabelB.Text = $"D = {determinantB.ToString()}";
            determinantLabelC.Text = $"D = {determinantC.ToString()}";
        }
    }
}
