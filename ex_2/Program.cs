// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int ans = int.Parse(strInput);
    return ans;
}

int x1 = prompt("Введите координаты х первой точки: ");
int y1 = prompt("Введите координаты y первой точки: ");
int z1 = prompt("Введите координаты z первой точки: ");

int x2 = prompt("Введите координаты х второй точки: ");
int y2 = prompt("Введите координаты y второй точки: ");
int z2 = prompt("Введите координаты z второй точки: ");

double G1 = Math.Pow(x2-x1, 2);
double G2 = Math.Pow(y2-y1, 2);
double G3 = Math.Pow(z2-z1, 2);

double ans = Math.Sqrt(G1+G2+G3);

Console.WriteLine(ans);