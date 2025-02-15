#include <iostream>
#include <string>
#include <cmath>
using namespace std;
//definicja klasy (przepis na obiekty - plan)
class Product{//domyslnie wszystko prywatne
    //pola wlasciwosci
    //todo dodac wlasciwosc kategoria jako string i poprawic metode info aby to uwzglednic
private:
    string name = "noname";
    double price = 0;
    string category;
public:
    //metody funkcje skladowe
    void Info(); //deklaracja metody Info
    Product();//deklaracja konstruktora domyslnego
    Product(string name,double price,string category);//deklaracja konstruktora z argumentami
    void SetPrice(double price){  //jesli tu definicja to metoda staje sie inline
        this->price = price < 0 ? -price : price;
    }
    void SetName(string name){
        this->name = name;
    }
    void SetCategory(string category){
        this->category = category;
    }
};
//definicja (implementacja) metody Info
void Product::Info(){
    cout << " ------- Informacje o produkcie --------------\n";
    cout << "\t\t        nazwa: "<<name<<endl;
    cout << "\t\t         cena: "<<price<<endl;
    cout << "\t\t    kategoria: "<<category<<endl;
    //todo
}
Product::Product(){
    cout << "Wywolanie konstruktora domyslnego"<<endl;
    this->category = "---";
}
Product::Product(string name,double price,string category){
    //this->name = name;
    //this->price = price;
    SetName(name);
    SetPrice(price);
    SetCategory(category);
}

/////////////////////////////////////////////////////////////
struct Point{   //domyslnie wszystko publiczne
    double x;
    double y;
    Point(){
        x=0;y=0;
    }
    Point(double x, double y){
        this->x = x;
        this->y = y;
    }
    string Info(){

        return "("+to_string(x)+","+to_string(y)+")";
    }
    double Distance(){
        return sqrt(x*x+y*y);
    }
    double Distance(Point& p){
        return sqrt((x-p.x)*(x-p.x)+(y-p.y)*(y-p.y));
    }

};
Point Dodaj(const Point& p1,const Point& p2){
    Point wynik;
    wynik.x = p1.x+p2.x;
    wynik.y = p1.y+p2.y;
    return wynik;
}
ostream & operator<<(ostream& os, const Point& p){
    os << "(" << p.x <<","<<p.y<<")";
    return os;
}
Point operator+(const Point& p1, const Point& p2){
    Point wynik;
    wynik.x = p1.x+p2.x;
    wynik.y = p1.y+p2.y;
    return wynik;
}
int main()
{
    //Product p1("Bulki z pieca",0.99,"pieczywo");
    //Product p2;
    //p2.SetPrice(-500);
    //p2.SetName("Buraki male");
    //p1.Info();
    //p2.Info();
    Point pkt1;
    Point pkt2(3,4);
    cout << pkt1 <<" pkt1 odl od (0,0) " <<pkt1.Distance()<<endl;
    cout << pkt2<<" pkt2 odl od (0,0) " <<pkt2.Distance()<<endl;
    Point pkt3(0,0);
    Point pkt4(6,6);
    cout <<"sprawdzenie: "<< pkt2.Distance(pkt3) << endl;
    cout <<"sprawdzenie: "<< " odl: "<<pkt4<<" a "<<pkt2<<" wynosi: "
       <<pkt4.Distance(pkt2) << endl;
    cout << pkt1 << endl;
    Point pkt5(9,-4);
    cout << pkt5 << " + " << pkt2 << " = "<< (pkt5+pkt2)<<endl;
    cout << pkt5 << " + " << pkt2 << " = "<< Dodaj(pkt5,pkt2)<<endl;
    return 0;
}
