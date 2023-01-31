class Program
{
  static void Main(string[] args)
  {
    Console.Clear();

    //Bài 1. Nhập vào hai số a, b => Tính tổng, hiệu, tích và thương của a và b
    /*float a;
    float b;
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
    Console.WriteLine("{0}/{1}={2}", a, b, thuong);*/

    //Bài 2. |a-b|, a, b là hai số thực cho trước
    /*float a;
    float b;
    Console.WriteLine("Nhập hai số a, b: ");
    string s_a = Console.ReadLine();//"123"=>123
    string s_b = Console.ReadLine();
    a = float.Parse(s_a);
    b = float.Parse(s_b);

    float gttd;
    gttd = (a>=b)?(a-b):(b-a);
    System.Console.WriteLine($"|{a}-{b}|={gttd}");*/

    //Bài 3. Tìm số lớn nhất trong 2 số a, b
    /*float a;
    float b;
    Console.WriteLine("Nhập hai số a, b: ");
    string s_a = Console.ReadLine();//"123"=>123
    string s_b = Console.ReadLine();
    a = float.Parse(s_a);
    b = float.Parse(s_b);
    float max;
    max = (a>b)?a:b;
    System.Console.WriteLine($"max({a}, {b})={max}");*/

    //Bài 4. Tìm số lớn nhất trong 3 số a, b, c
    /*float a, b, c;
    Console.WriteLine("Nhập hai số a, b, c: ");
    string s_a = Console.ReadLine();//"123"=>123
    string s_b = Console.ReadLine();
    string s_c = Console.ReadLine();
    a = float.Parse(s_a);
    b = float.Parse(s_b);
    c = float.Parse(s_c);
    float max = (a>=b)?a:b;
    max = (max>=c)?max:c;
    //max = (a>=b)?((a>c)?a:c):((b>=c)?b:c);
    System.Console.WriteLine($"max({a}, {b}, {c})={max}");*/

    //Bài 5. Tìm số lớn nhất trong 4 số a, b, c, d
    /*float a, b, c, d;
    Console.WriteLine("Nhập hai số a, b, c, d: ");
    string s_a = Console.ReadLine();//"123"=>123
    string s_b = Console.ReadLine();
    string s_c = Console.ReadLine();
    string s_d = Console.ReadLine();
    a = float.Parse(s_a);
    b = float.Parse(s_b);
    c = float.Parse(s_c);
    d = float.Parse(s_d);
    float max1 = (a>=b)?a:b;
    float max2 = (c>=d)?c:d;
    float max = (max1>=max2)?max1:max2;
    System.Console.WriteLine($"max({a}, {b}, {c}, {d})={max}");*/

    //Bài 6. Nhập vào 3 số a, b, c. Kiểm tra xem có phải là ba cạnh của tam giác
    float a, b, c;
    Console.WriteLine("Nhập hai số a, b, c: ");
    string s_a = Console.ReadLine();//"123"=>123
    string s_b = Console.ReadLine();
    string s_c = Console.ReadLine();
    a = float.Parse(s_a);
    b = float.Parse(s_b);
    c = float.Parse(s_c);
    bool dk0 = (a>0)&&(b>0)&&(c>0);
    bool dk1 = (a+b>c);
    bool dk2 = (b+c>a);
    bool dk3 = (c+a>b);
    bool dk = dk0&&dk1&&dk2&&dk3;
    string kq = (dk==true)?($"{a}, {b}, {c} là ba cạnh của tam giác"):"Không phải";
    System.Console.WriteLine(kq);

    Console.ReadKey();
  }
}