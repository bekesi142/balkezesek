using System;
using System.Linq;


StreamReader sr = new StreamReader("balkezesek.csv");


List<string> nev_lista = new List<string>();
List<string> elso_lista = new List<string>();
List<string> utolso_lista = new List<string>();
List<int> suly_lista = new List<int>();
List<int> magassag_lista = new List<int>();

int hanysorvan = 0;

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    hanysorvan++;
    string nev = sor.Split(";")[0];
    string elso = sor.Split(";")[1];
    string utolso = sor.Split(";")[2];
    int suly = int.Parse(sor.Split(";")[3]);
    int magassag = int.Parse(sor.Split(";")[4]);
    nev_lista.Add(nev);
    elso_lista.Add(elso);
    utolso_lista.Add(utolso);
    magassag_lista.Add(magassag);
    suly_lista.Add(suly);
    
}


List<string> szukitett_lista = new List<string>();
List<int> jodatum_index_lista = new List<int>();
List<string> jonev_index_lista = new List<string>();

foreach (string datum in utolso_lista)
{
    if (datum.Contains("1999-10"))
    {
        szukitett_lista.Add(datum);
        jodatum_index_lista.Add(utolso_lista.IndexOf(datum));
    }
}

foreach (int index in jodatum_index_lista)
{
    foreach (string nev in nev_lista)
    {
        jonev_index_lista.Add(nev_lista[index]);

    }
}



Console.WriteLine("3. feladat:  " + hanysorvan);

Console.WriteLine("4. feladat:  " + jonev_index_lista + szukitett_lista);

Console.WriteLine("5. feladat:  ");
Console.Write("Kérek egy évszámot 1990 és 1999 között:  ");
int bekeres = Convert.ToInt32(Console.ReadLine());
while (bekeres > 1999 && bekeres < 1990)
{
    Console.Write("Hibás adat! Kérek egy évszámot 1990 és 1999 között:  ");
    bekeres = Convert.ToInt32(Console.ReadLine());

}

