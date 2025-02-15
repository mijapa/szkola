#include <iostream>
#include <cstdlib>
#include "Point.h"
#include "Circle.h"

using namespace std;
void cw1();
void cw2();
int main() {
	//cw1();
	cw2();
	return 0;
}

void cw1() {
	Point p1(3, 4);
	Point p2(2, 6);
	cout << p1 << endl;
	cout << p1 << " + " << p2 << " = " << (p1 + p2) << endl;
	cout << p1 << " - " << p2 << " = " << (p1 - p2) << endl;
	cout << "odleglosc " << p1 << " (0,0) " << " = " << p1.Distance() << endl;
	cout << "odleglosc " << p1 << " i " << p2 << " = " << p1.Distance(p2) << endl;
}
void cw2() {
	Circle c1;

	Point p2(2, 1); //p1
	Point p6(2, 1); //p2

	Circle c2(1, p2); //c1
	Circle c6(1, p6); //c2
	
	Point p3(5, 5);
	Circle c4 = c2;
	Circle* c3 = new Circle(4, p3);
	cout << c1 << endl;
	cout << c2 << endl;
	cout << (*c3) << endl;
	cout << "======================================" << endl;
//	c1.Info();
//	c2.Info();
//	c3->Info();
//	(*c3).Info();

	if((*c3).IsCenterInside(c2)) {
		cout << "Srodek " << c2 << " wewnatrz " << (*c3) << endl;
	}else {
		cout << "Srodek " << c2 << " nie wewnatrz " << (*c3) << endl;
	}

	if (c2.IsCenterInside((*c3))) {
		cout << "Srodek " << (*c3) << " wewnatrz " << c2 << endl;
	}
	else {
		cout << "Srodek " << (*c3) << " nie wewnatrz " << c2 << endl;
	}
	cout << "==============================================" << endl;
	if(c2.IsWholeInside(c1)) {
		cout << c1 << endl << " Zawiera sie wewnatrz" << endl << c2 << endl;
	}else {
		cout << c1 << endl << " Niezawiera sie wewnatrz" << endl << c2 << endl;
	}
	cout << "----------------------------------------------" << endl;
	if (c2.IsThisCircleInside(c1)) {
		cout << c2 << endl << " Zawiera sie wewnatrz" << endl << c1 << endl;
	}
	else {
		cout << c2 << endl << " Niezawiera sie wewnatrz" << endl << c1 << endl;
	}
	//todo dynamiczny obiekt Kolo i uzycie << oraz metody Info()

	cout << "========================================================\n\n";
	cout << c2 << endl;
	cout << c4 << endl;
	cout << "     zmieniam promien c4 " << endl;
	cout << c2.IsWholeInside(c4) << endl;
	cout << c2.IsThisCircleInside(c4) << endl;
	cout << "======================================" << endl;
	c4.SetRadius(5);
	cout << c2 << endl;
	cout << c4 << endl;
	cout << "======================================" << endl;

	cout << "c2 = " << c2 << endl;
	cout << "c6 = " << c6 << endl;

	cout << "======================================" << endl;
	
	//cout << "Czy maja wsplna czesc (1=Tak, 0=Nie)" << endl;
	//cout << c2.CommonParts(c6) << endl;
	//cout << "----------------------------------------------" << endl;
	
	cout << "Czy maja wszystkie punkty wspolne (1=Tak, 0=Nie)" << endl;
	cout << c2.CommonPartsAll(c6) << endl;
	cout << "----------------------------------------------" << endl;

	cout << "Czy maja 1 punkt wspolny (1=Tak, 0=Nie)" << endl;
	cout << c2.CommonPoint(c6) << endl;
	cout << "----------------------------------------------" << endl;

	cout << "Czy maja 2 punkty wspolne (1=Tak, 0=Nie)" << endl;
	cout << c2.CommonPointss(c6) << endl;
	cout << "----------------------------------------------" << endl;

	delete c3;
	c3 = nullptr;
}