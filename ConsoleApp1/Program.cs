using ConsoleApp1;

Fraction f1 = new Fraction(3,25);
Fraction f2 = new Fraction(4,26);
Fraction f3 = new Fraction(32,452);
Fraction f4 = new Fraction(12,32);
Fraction f5 = new Fraction(23,45);
Fraction f6 = new Fraction(11,34);
Fraction f7 = new Fraction(10,66);
Fraction f8 = new Fraction(7,40);

f1.Toplama(f2);
f1.Show();

f3.Cixma(f4);
f3.Show();


f5.Vurma(f6);
f5.Show();

f7.Bolme(f8);
f7.Show();

//------------------------------------------------

Counter c1 = new Counter(5, 15);

c1.Increment();
c1.Increment();
c1.Increment();
c1.Increment();
Console.WriteLine(c1.CurrentData);
Console.WriteLine(c1);

//-----------------------------------------------




