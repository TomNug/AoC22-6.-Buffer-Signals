using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string[] lines = System.IO.File.ReadAllLines(@"signal.txt");
    string line = lines[0];
    int numChars = 14;
    int firstChar = 0;
    for (int i=0; i<line.Length-numChars+1; i++) {
      HashSet<char> charSet = new HashSet<char>();
      for (int j=0; j<numChars; j++){
        charSet.Add(line[i+j]);
      }        
      if (charSet.Count == 14) {
        if (firstChar == 0) {
          firstChar = i+1;
          Console.WriteLine(i+numChars);
        }
      }
    }
  }
}