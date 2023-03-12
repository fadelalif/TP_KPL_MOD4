// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> kodepos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string getKodePos(string kelurahan)
    {
        if (kodepos.ContainsKey(kelurahan))
        {
            return "Kode posnya adalah: "+kodepos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        KodePos kodepos = new KodePos();
        Console.WriteLine(kodepos.getKodePos("Margasari"));
    }
}
