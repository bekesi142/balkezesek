using System;
using System.Linq;


StreamReader sr = new StreamReader("balkezesek.csv");


List<string> nev_lista = new List<string>();
List<int> suly_lista = new List<int>();
List<int> magassag_lista = new List<int>();


int hanysorvan = 0;

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    hanysorvan++;
    string nev = sor.Split(";")[0];
    int suly = int.Parse(sor.Split(";")[3]);
    int magassag = int.Parse(sor.Split(";")[4]);
    nev_lista.Add(nev);
    magassag_lista.Add(magassag);
    suly_lista.Add(suly);
    
}

Console.WriteLine("3. feladat:  " + hanysorvan);
