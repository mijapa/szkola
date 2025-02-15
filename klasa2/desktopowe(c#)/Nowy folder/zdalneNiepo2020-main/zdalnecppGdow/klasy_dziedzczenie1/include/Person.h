#ifndef PERSON_H
#define PERSON_H
#include <string>
#include <iostream>
using namespace std;
class Person
{
    public:
        Person();
        Person(string firstName,string lastName,int age);
        virtual ~Person();
        virtual void Info();
        friend ostream& operator<<(ostream& os, const Person& p);
        void SetAge(int age){
            this->age = age<0 ? -age : age;
        }
    protected:
        string firstName;
        string lastName;
        int age;



};

#endif // PERSON_H
