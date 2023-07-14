// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowCoordinate(int x1 ,int y1 , int z1, int x2, int y2 , int z2 )
{
    double distans = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1 , 2)+ Math.Pow(z2-z1 , 2));
    Console.WriteLine ($"Расстояние межэду двух точек равно: {Math.Round(distans, 2)}");
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = GetInput("введите координаты первой точки Х: ");
int y1 = GetInput("введите координаты первой точки y: ");
int z1 = GetInput("введите координаты первой точки z: ");
int x2 = GetInput("введите координаты второй точки Х: ");
int y2 = GetInput("введите координаты второй точки y: ");
int z2 = GetInput("введите координаты второй точки z: ");


ShowCoordinate(x1 ,y1 , z1, x2, y2, z2);
