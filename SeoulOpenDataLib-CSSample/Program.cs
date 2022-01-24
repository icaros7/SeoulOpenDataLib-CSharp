using System;
using SeoulOpenDataLibCSharp;

namespace SeoulOpenDataLib_CSSample;

public static class Program {
    public static void Main(string[] args) {
        DataFront dataFront = new DataFront("7555665843686f6d33336841536642");

        Console.WriteLine(dataFront.CanIRun());
    }
}