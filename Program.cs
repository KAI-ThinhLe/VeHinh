using System;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            // Hiển thị menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (Bottom-Left)");
            Console.WriteLine("3. Print the square triangle (Top-Left)");
            Console.WriteLine("4. Print the square triangle (Bottom-Right)");
            Console.WriteLine("5. Print the square triangle (Top-Right)");
            Console.WriteLine("6. Print isosceles triangle");
            Console.WriteLine("7. Print rhombus");
            Console.WriteLine("8. Print diamond");
            Console.WriteLine("9. Exit");
            Console.Write("Please enter your choice: ");
            
            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1: // Hình chữ nhật
                    int rectRows = 4, rectCols = 6;
                    for (int i = 0; i < rectRows; i++)
                    {
                        for (int j = 0; j < rectCols; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 2: // Tam giác vuông (Góc vuông ở Bottom-Left)
                    int triBL = 5;
                    for (int i = 1; i <= triBL; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 3: // Tam giác vuông (Góc vuông ở Top-Left)
                    int triTL = 5;
                    for (int i = triTL; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 4: // Tam giác vuông (Góc vuông ở Bottom-Right)
                    int triBR = 5;
                    for (int i = 1; i <= triBR; i++)
                    {
                        for (int j = triBR; j > i; j--)
                        {
                            Console.Write("  "); // Khoảng trắng để căn chỉnh
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 5: // Tam giác vuông (Góc vuông ở Top-Right)
                    int triTR = 5;
                    for (int i = 1; i <= triTR; i++)
                    {
                        for (int j = 1; j <= (triTR - i); j++)
                        {
                            Console.Write("  "); // Khoảng trắng để căn chỉnh
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 6: // Tam giác cân
                    int isoTri = 5;
                    for (int i = 1; i <= isoTri; i++)
                    {
                        for (int j = isoTri; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i - 1); j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 7: // Hình bình hành
                    int rhombusSize = 5;
                    // Phần trên của hình bình hành
                    for (int i = 1; i <= rhombusSize; i++)
                    {
                        for (int j = rhombusSize; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= rhombusSize; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    // Phần dưới của hình bình hành
                    for (int i = 1; i < rhombusSize; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = rhombusSize; j > i; j--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 8: // Hình thoi
                    int diamondSize = 5;
                    // Phần trên của hình thoi
                    for (int i = 1; i <= diamondSize; i++)
                    {
                        for (int j = diamondSize; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i - 1); j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    // Phần dưới của hình thoi
                    for (int i = diamondSize - 1; i >= 1; i--)
                    {
                        for (int j = diamondSize; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i - 1); j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 9:
                    Console.WriteLine("Exiting...");
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 9);
    }
}
