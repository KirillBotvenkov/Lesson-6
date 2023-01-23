/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

const int Coefficient = 0;
const int Constant = 0;
const int X_Coord = 0;
const int Y_Coord = 0;
const int Line1 = 0;
const int Line2 = 0;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData1, lineData2))
{
    double [] coord = FindCoords(lineData1, lineData2);
    Console.Write
    ($"Точка пересечения - y={lineData1[Coefficient]} * x + {lineData1[Constant]}  и y= {lineData2[Coefficient]} * x + {lineData2[Constant]}");
        Console.WriteLine($" имеет координаты ({coord[X_Coord]},{coord[Y_Coord]})");  
}

double Prof(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coefficient] = Prof($" Введите коэффициент для {numberOfLine} прямой");
    lineData[Constant] = Prof($" Введите константу для {numberOfLine} прямой ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_Coord] = (lineData1[Constant] - lineData2[Constant])/ lineData2[Coefficient] - lineData1[Coefficient];
    coord[Y_Coord] = lineData1[Constant] * coord[X_Coord] + lineData1[Constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[Coefficient] == lineData2 [Coefficient])
    {
        if (lineData1[Constant] == lineData2[Constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралельны");
            return false;
        }
        
        }
    
return true;
}