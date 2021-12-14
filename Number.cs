using System;

namespace Number
{
	public class Number
	{
        static string NumberToString(int X)
        {
            string S;
            S = "";
            if (0 == X) S = "Zero"; else
            {
                Boolean Skip;
                int Unite, Dizaine, Centaine, Millier;
                Skip = false;
                Unite = X % 10;
                Dizaine = (X / 10) % 10;
                Centaine = (X / 100) % 10;
                Millier = (X / 1000) % 10;
                switch (Millier) {
                    case 1: 
                        S += "mille ";
                        break;
                    case 2: 
                        S += "deux mille ";
                        break;
                    case 3: 
                        S += "trois mille ";
                        break;
                    case 4: 
                        S += "quatre mille ";
                        break;
                    case 5: 
                        S += "cinq mille ";
                        break;
                    case 6: 
                        S += "six mille ";
                        break;
                    case 7: 
                        S += "sept mille ";
                        break;
                    case 8: 
                        S += "huit mille ";
                        break;
                    case 9: 
                        S += "neuf mille ";
                        break;
                }
                switch (Centaine) {
                    case 1: 
                        S += "cent ";
                        break;
                    case 2: 
                        S += "deux cents ";
                        break;
                    case 3: 
                        S += "trois cents ";
                        break;
                    case 4: 
                        S += "quatre cents ";
                        break;
                    case 5: 
                        S += "cinq cents ";
                        break;
                    case 6: 
                        S += "six cents ";
                        break;
                    case 7: 
                        S += "sept cents ";
                        break;
                    case 8: 
                        S += "huit cents ";
                        break;
                    case 9: 
                        S += "neuf cents ";
                        break;
                }
                switch (Dizaine) {
                    case 1:
                        if ((Unite >= 1) && (Unite <= 6)) {
                            switch (Unite) {
                                case 1:
                                    S += "onze";
                                    break;
                                case 2:
                                    S += "douze";
                                    break;
                                case 3:
                                    S += "treize";
                                    break;
                                case 4:
                                    S += "quatorze";
                                    break;
                                case 5:
                                    S += "quinze";
                                    break;
                                case 6:
                                    S += "seize";
                                    break;
                            }
                            Skip = true;
                        }
                        else
                            S += "dix";
                        break;
                    case 2:
                        S += "vingt";
                        if (1 == Unite) {
                            S += " et un";
                            Skip = true;
                        }
                        break;
                    case 3:
                        S += "trente";
                        break;
                    case 4:
                        S += "quarante";
                        break;
                    case 5:
                        S += "cinquante";
                        break;
                    case 6:
                        S += "soixante";
                        break;
                    case 7:
                        S += "soixante-dix";
                        break;
                    case 8:
                        S += "quatre-vingt";
                        break;
                    case 9:
                        S += "quatre-vingt-dix";
                        break;
                }
                if (!Skip) {
                    if((Dizaine != 0)&&(Unite > 1)) S += '-';
                    switch(Unite % 10 ) {
                        case 1:
                            S += "un";
                            break;
                        case 2:
                            S += "deux";
                            break;
                        case 3:
                            S += "trois";
                            break;
                        case 4:
                            S += "quatre";
                            break;
                        case 5:
                            S += "cinq";
                            break;
                        case 6:
                            S += "six";
                            break;
                        case 7:
                            S += "sept";
                            break;
                        case 8:
                            S += "huit";
                            break;
                        case 9:
                            S += "neuf";
                            break;
                    }
                }
            }
            return S;
        }

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (("/?" == args[0]) || ("--help" == args[0]) || ("-" == args[0]))
                {
                    Console.WriteLine("NUMBER : Cette commande permet d''afficher un nombre en texte.");
                    Console.WriteLine();
                    Console.WriteLine("Syntaxe : NUMBER chiffre");
                }
                else
                {
                    int Value;
                    Value = int.Parse(args[0]);
                    Console.WriteLine(Number.NumberToString(Value));
                }
            }
        }
	}
}
