using System.Xml;

namespace MatrixIDZ
{
    public class QuadricMatrix
    {
        private int[,]? _matrix = null;

        public int N => (_matrix != null) ? _matrix.GetLength(0) : 0;

        public QuadricMatrix(int n = 2)
        {
            n = Math.Max(2, n);
            _matrix = new int[n, n];
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i > N || i < 0 || j > N)
                    throw new ArgumentOutOfRangeException(nameof(i));

                return _matrix[i, j];
            }
            private set
            {
                if (i < 0 || i > N || i < 0 || j > N)
                    throw new ArgumentOutOfRangeException(nameof(i));

                _matrix[i, j] = value;
            }
        }


        public void Fill()
        {
            if (N == 0) return;

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    this[i, N - 1 - j] = j + 1 - i;
                    this[N - 1 - i, j] = j + 1 - i;
                }
            }
        }

        public void Output(DataGridView grid)
        {
            if (N == 0) return;

            grid.RowCount = N;
            grid.ColumnCount = N;

            for (int i = 0; i < N; i++)
            {
                grid.Rows[i].HeaderCell.Value = $" {i} ";
                grid.Columns[i].HeaderCell.Value = $" {i} ";

                grid.Rows[i].Height = (grid.Height - grid.ColumnHeadersHeight) / grid.RowCount;
                grid.Columns[i].Width = (grid.Width - grid.RowHeadersWidth) / grid.ColumnCount;

                for (int j = 0; j < N; j++)
                {
                    if (i == j) 
                    {
                        grid.Rows[i].Cells[N - 1 - j].Style.Font = new Font("Cascadia Code", 12, FontStyle.Bold);
                        grid.Rows[i].Cells[N - 1 - j].Style.ForeColor = Color.MediumSlateBlue;
                    }
                    else
                    {
                        grid.Rows[i].Cells[N - 1 - j].Style.Font = new Font("Cascadia Code", 12, FontStyle.Regular);
                        grid.Rows[i].Cells[N - 1 - j].Style.ForeColor = Color.Black;
                    }
                    grid.Rows[i].Cells[j].Value = this[i, j];
                }
            }
        }

        public static QuadricMatrix CreateB(QuadricMatrix A)
        {
            if (A == null) return new(2);

            QuadricMatrix B = new(A.N);

            for (int i = 0; i < A.N; i++)
            {
                for (int j = 0; j < A.N; j++)
                {           
                    B[i, j] = A[i, j] + A.RowSum(i);
                }
            }
            return B;
        }

        public static QuadricMatrix CreateC(QuadricMatrix A)
        {
            if (A == null) return new(2);

            QuadricMatrix C = new(A.N);

            for (int i = 0; i < A.N; i++)
            {
                for (int j = 0; j < A.N; j++)
                {
                    C[i, j] = A[i, j] + A.ColumnSum(j);
                }
            }
            return C;
        }

        public int RowSum(int i)
        {
            int sum = 0;

            for (int j = 0; j < N; j++)
                sum += this[i, j];
            
            return sum;
        }

        public int ColumnSum(int j)
        {
            int sum = 0;

            for (int i = 0; i < N; i++)
                sum += this[i, j];

            return sum;
        }

        public async Task<int> CalculateDeterminantAsync() 
            => await Task.Run(() => GetDeterminant());
        
        public int GetDeterminant()
        {
            if (N == 0) 
                return 0;

            if (N == 1) 
                return this[0, 0];

            if (N == 2) 
                return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];

            else
            {
                int determinant = 0;

                for (int j = 0; j < N; j++)
                {
                    int sign = (j % 2 == 0) ? 1 : -1;
                    QuadricMatrix minor = GetMinor(0, j);
                    determinant += sign * this[0, j] * minor.GetDeterminant();
                }
                return determinant;
            }
        }

        public QuadricMatrix GetMinor(int row, int column)
        {
            QuadricMatrix minor = new(N - 1);

            for (int i = 0; i < N; i++)
            {
                if (i == row) continue;

                int subRow = i < row ? i : i - 1;

                for (int k = 0; k < N; k++)
                {
                    if (k == column) continue;

                    int subColumn = k < column ? k : k - 1;
                    minor[subRow, subColumn] = this[i, k];
                }
            }
            return minor;
        }
    }
}




