using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_
{
    public class ListeTaches
    {
        public void mainMethode()
        {
            List<string> listTache = new List<string>();
            
            bool loopContinue = true;

            while (loopContinue)
            {
                int indexChoix = DisplayMenu();

                switch (indexChoix)
                {
                    case 1:
                        Console.Write("Entrez le nom de la tâche : ");
                        string NameTache = Console.ReadLine();
                        Addtache(NameTache, listTache);
                        break;
                    case 2:
                        ShowList(listTache);
                        break;
                    case 3:
                        RemoveTache(listTache);
                        break;
                    case 4:
                        EndTache(listTache);
                        break;
                    case 5:
                        Console.WriteLine("Au revoir !");
                        loopContinue = false;
                        break;
                    default:
                        Console.Write("La commande saisie est introuvable !");
                        break;
                }
                //if (loopContinue)
                  //  Console.Write("La commande saisie est introuvable !");
            }
        }

        //Modélisation du Ménu
        public int DisplayMenu() 
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("            === Menu ===           ");
            Console.WriteLine("1. Ajouter une tâche");
            Console.WriteLine("2. Afficher les tâches");
            Console.WriteLine("3. Supprimer une tâche");
            Console.WriteLine("4. Marquer une tâche comme terminée");
            Console.WriteLine("5. Quitter");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.Write("Choisissez une option : ");

            string itemString = Console.ReadLine();

            return int.Parse(itemString); 
        }

        // Ajouter des taches
        public void Addtache(string tache, List<string> list)
        {
            list.Add(tache);
        }

        // A1ffichage de la liste
        public void ShowList(List<string> list)
        {
            int nbr = 1;
            Console.WriteLine("Les taches existantes :");
            Console.WriteLine();
            foreach (string i in list)
            {
                Console.WriteLine($"{nbr} - {i}  [Non terminé]");
                nbr++;
            }
            Console.WriteLine();
        }

        // Supprimer des taches
        public void RemoveTache(List<string> list)
        {
            ShowList(list);
            Console.Write($"Quelle tache vous voulez supprimer : ");
            string item = Console.ReadLine();
            list.RemoveAt(int.Parse(item));
        }

        // Supprimer des taches
        public void EndTache(List<string> list)
        {
            ShowList(list);
            Console.Write($"Entrez le numéro de la tâche à marquer comme terminée : ");
            string input = Console.ReadLine();

            // Validation de l'entrée utilisateur
            if (int.TryParse(input, out int index) && index > 0 && index <= list.Count)
            {
                // Marquer la tâche comme terminée
                list[index - 1] = $"{list[index - 1]} [Terminée]";
                Console.WriteLine($"Tâche marquée comme terminée : {list[index - 1]}");
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un numéro de tâche valide.");
            }
        }
    }
}