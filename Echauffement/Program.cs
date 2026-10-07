namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle Benjamin, mon jeu préféré est Outer Wilds.");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Entrez votre prénom");
        String UserName = Console.ReadLine();

        Console.WriteLine("Entrez votre âge");
        int userAge = Convert.ToInt32(Console.ReadLine());
            
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        String AgeVerificationMess = "";
        bool isMajor;

        if (userAge < 18)
        {
            AgeVerificationMess = "Tu es mineur";
            isMajor = false;
        }
        else
        {
            AgeVerificationMess = "Tu es majeur";
            isMajor = true;
        }
        Console.WriteLine(AgeVerificationMess);

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euros possèdes-tu ?");
        float nbEuro = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        String[] WeaponsName = { "L'épée de l'abus", "L'arc de la désobligeance", "Le sabre de l'irrespect", "Le pistolet de la nonchalance" };
        int[] WeaponsPrice = { 1800, 500, 250, 800 };
        String WeaponsMessage = "";
        for(int i = 0; i<WeaponsName.Length; i++)
        {
            WeaponsMessage += $"{WeaponsName[i]} : {WeaponsPrice[i]}.00\n";
        }

        Console.WriteLine(WeaponsMessage);
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Choisissez une arme (entre 1 et 4)");
        int nbWeapon = Convert.ToInt32(Console.ReadLine());
        while (!(nbWeapon >= 1 && nbWeapon <= 4))
        {
            Console.WriteLine("Ce n'est pas une réponse valide !\nChoisissez une arme (entre 1 et 4)");
            nbWeapon = Convert.ToInt32(Console.ReadLine());
        }

        

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        
        bool hasEnoughMoney = nbEuro >= WeaponsPrice[nbWeapon - 1];
        String FinalMess = "";
        if (!(isMajor && hasEnoughMoney))
        {
            FinalMess = "Tu ne peux pas acheter cette arme";
        }
        else
        {
            nbEuro -= WeaponsPrice[nbWeapon - 1];
            FinalMess = $"{WeaponsName[nbWeapon-1]} a été acheté(e)\n{nbEuro} euro(s) restant(s). Merci {UserName}.";
            
        }
        Console.WriteLine(FinalMess);
        
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
            // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
            // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible
            
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}