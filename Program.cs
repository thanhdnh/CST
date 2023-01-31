class Program
{
  static void Main(string[] args)
  {
    Console.Clear();

    //Nhập vào hai số a, b => Tính tổng, hiệu, tích và thương của a và b
    float a;
    float b;
    //float a, b;
    Console.WriteLine("Nhập hai số a, b: ");
    string s_a = Console.ReadLine();//"123"=>123
    string s_b = Console.ReadLine();
    a = float.Parse(s_a);
    b = float.Parse(s_b);

    float tong = a + b;
    float hieu = a - b;
    float tich = a * b;
    float thuong = a / b;

    Console.WriteLine("{0}+{1}={2}", a, b, tong);
    Console.WriteLine($"{a}-{b}={hieu}");
    Console.WriteLine(a + "*" + b + "=" + tich);
    Console.WriteLine("{0}/{1}={2}", a, b, thuong);

    Console.ReadKey();
  }
}