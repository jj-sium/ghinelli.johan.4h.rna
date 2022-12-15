using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string rna="";
        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'G': rna = rna + "C"; break;
                case 'A': rna = rna + "U"; break;
                case 'T': rna = rna + "A"; break;
                case 'C': rna = rna + "G"; break;
            }
        }
        if(String.IsNullOrEmpty(dna))
            return "";
        
        return rna;
    }
}