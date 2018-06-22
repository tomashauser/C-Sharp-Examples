using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64 {
    class Program {
        public static void Matrix_Print(int[][] Matrix, int Rows, int Columns) {
            for (int i = 0; i < Rows; i++) {
                for (int j = 0; j < Columns; j++) {
                    Console.Write(Matrix[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public static int[][] Matrix_Assign(int[][] Matrix, int Lower_Bound, int Upper_Bound, int Rows, int Columns) {
            Random Random_Number = new Random();
            for (int i = 0; i < Rows; i++) {
                for (int j = 0; j <  Columns; j++) {
                    Matrix[i][j] = Random_Number.Next(Lower_Bound, Upper_Bound);
                }
            }
            return Matrix;
        }
        public static int[][] Matrix_Init(int Rows, int Columns) {
            int[][] Matrix = new int[Rows][];
            for (int i = 0; i < Rows; i++)
                Matrix[i] = new int[Columns];
            return Matrix;
        }
        public static void Main(string[] args) {
            int M = 3, N = 3, O = 4, P = 4, Lower_Bound = 10, Upper_Bound = 20;
            int[][] Matrix_A = Matrix_Init(M, N);
            int[][] Matrix_B = Matrix_Init(O, P);
            Matrix_A = Matrix_Assign(Matrix_A, Lower_Bound, Upper_Bound, M, N);
            Matrix_B = Matrix_Assign(Matrix_A, Lower_Bound, Upper_Bound, O, P);
            Matrix_Print(Matrix_A, M, N);
            Matrix_Print(Matrix_B, O, P);
        }
    }
}
