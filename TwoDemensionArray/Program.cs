using System.Runtime.InteropServices.ComTypes;
using System;

namespace TwoDemensionArray;

class Program
{
    public static void IniArr(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row,col] = 1+row*col;
            }
        }
    }

    public static void DispArr(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        } 
    }

    public static void IniArr(Point[,] pts)
    {
        const int MAX = 100;
        const int MIN = 0;
        Random random = new Random();

        for (int row = 0; row < pts.GetLength(0); row++)
        {
            for (int col = 0; col <pts.GetLength(1); col++)
            {
                pts[row, col] = new Point();
                pts[row, col].x = random.Next(MIN, MAX);
                pts[row, col].y = random.Next(MIN, MAX);
            }
        }
    }

    public static void DispArr(Point[,] pts)
    {
        for (int row = 0; row < pts.GetLength(0); row++)
        {
            for (int col = 0; col < pts.GetLength(1); col++)
            {
                Console.Write($"({pts[row, col].x}, {pts[row, col].y}) ");
            }
            Console.WriteLine();
        }
    }


    static void Main(string[] args)
    {
        //int[] nums = new int[3];

        int[,] matrix = new int[3, 4];
        // 예를 들어서 정의역과 치역이 제한된 좌표라 생각하면 편하다.
        // 3*4로 제한된 함수영역에서 각 좌표당 할당된 값이 있다고 생각하면 된다.
        // [ 1, 2, 3, 4]
        // [ 5, 6, 7, 8]
        // [ 9, 10 ,11 ,12]
        // 라고 하였을 때 [0,0] =1 / [1,2] =6 으로 보면 된다.
        
        Point[,] pts = new Point[5, 5];
        // 얘는 matrix랑 같은 점은 matrix도 마찬가지로 그 배열 저장공간에 값을 설정해줘야된다는 점.
        // 그러나 얘는 배열 저장공간이 int가 아니라 25개의 각각의 객체를 생성해줘야된다는점.
        // x, y로 설정한 이유는 한 데이터저장공간에 두개의 값을 설정할 수 있다.
        // ex) pts[2,4] = new Point();
        // pts[2,4].x = 15; pts[2,4].y = 20;
        
        
        IniArr(matrix);
        DispArr(matrix);
        IniArr(pts);
        DispArr(pts);
        

        //matrix[0, 0] = 100;
        
        //Console.WriteLine(matrix[0, 0]);
        //Console.WriteLine(matrix.GetLength(0));
        //Console.ReadKey();
    }
}