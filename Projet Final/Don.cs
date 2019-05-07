using System;

public class Objet
{
    string typeMateriel;
    string refObj;
    string descriComp;

    public
}

public class Don : Objet
{
    DateTime dateRecep;
    string nomDonnateur;
    int numtel;
    string adresse;
    

	public Don(DateTime dateRecep, string typeMateriel, string refObj, string nomDonnateur, int numtel, string adresse, string descriComp)
	{
        this.dateRecep = dateRecep;
        this.nomDonnateur = nomDonnateur;
        this.numtel = numtel;
        this.adresse = adresse;
	}

    public override string ToString()
    {
        return "Date de reception : " + dateRecep.Day+"/"+dateRecep.Month+"/"+dateRecep.Year + "\nType de materiel : " + typeMateriel 
            + "\nReference objet : " + refObj + "\nNom du donnateur : " + nomDonnateur + "\nNumero de telephone : " + numtel 
            + "\nAdresse : " + adresse + "\nDescription complementaire : " + descriComp;
    }

    public static int Choix(Don don)
    {
        Console.WriteLine(don);
        char readK;
        Console.WriteLine();
        Console.WriteLine("Accepter(A), Refuser(R) : ");
        readK = Console.ReadKey().KeyChar;
        if (readK == 'A')
            return 1;
        else
            return 0;
    } 
}


