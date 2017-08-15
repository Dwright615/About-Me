#include "stdafx.h"
#include<iostream>
#include "Fraction.h"



class FloatFraction : public Fraction
{
public:
	using Fraction::Fraction;  //This inherits constructors from the base class.

	FloatFraction(){}
	FloatFraction(double val) { set_Float(val); }

	FloatFraction operator+(const FloatFraction &other) {return addition(other);}
	FloatFraction addition(const FloatFraction &other);

	double get_Float()
	{
		double x = get_num(); return x / get_den();
	}
	void set_Float(double value)
	{
		int n = static_cast<int>(value * 100);
		set(n, 100);
	}
};

FloatFraction FloatFraction::addition(const FloatFraction &other) 
{
	int lcd = lcm(den, other.den);
	int quot1 = lcd / den;
	int quot2 = lcd / other.den;
	return 	FloatFraction(num * quot1 + other.num * quot2, lcd);
}


//GCF
int gcf(int a, int b)
{
	if (b == 0)
	{
		return abs(a);
	}
	else
	{
		return gcf(b, a%b);
	}
}

// LCM
int lcm(int a, int b)
{
	int n = gcf(a, b);
	return a / n*b;
}





int main()
{
	FloatFraction fract1, fract2;

	fract1.set(1, 2);
	std::cout << "1/2 is " << fract1.get_Float() << std::endl;

	fract1.set(3, 5);
	std::cout << "3/5 is " << fract1.get_Float() << std::endl;

	fract2.set_Float(.8);
	std::cout << ".8 is " << fract2 << std::endl;

	FloatFraction fract3(.25);
	std::cout << ".25 is " << fract3 << std::endl;

	FloatFraction f1(1, 2), f2(1, 3), f3(0);

	f3 = f1 + f2;
	std::cout << "Value of f3 is " << f3 << std::endl;
	std::cout << "Decimal format is  " << f3.get_Float() << std::endl;
	system("PAUSE");

    return 0;
}
