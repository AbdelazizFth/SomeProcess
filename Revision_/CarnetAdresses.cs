using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_
{
    public class CarnetAdresses
    {
        public void mainMethode()
        {
            List<Contact> listTache = new List<Contact>();

            bool loopContinue = true;

            while (loopContinue)
            {
                string indexChoix = DisplayMenu();

                switch (indexChoix)
                {
                    case "1":
                        AddContact(listTache);
                        break;
                    case "2":
                        ShowContacts(listTache);
                        break;
                    case "3":
                        SearchContact(listTache);
                        break;
                    case "4":
                        RemoveContact(listTache);
                        break;
                    case "5":
                        Console.WriteLine("Au revoir !");
                        loopContinue = false;
                        break;
                    default:
                        Console.Write("La commande saisie est introuvable !");
                        break;
                }
            }
        }

        //Modélisation du Ménu
        public string DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("     === Carnet d'Adresses ===           ");
            Console.WriteLine("1. Ajouter un contact");
            Console.WriteLine("2. Afficher tous les contacts");
            Console.WriteLine("3. Rechercher un contact");
            Console.WriteLine("4. Supprimer une tâche");
            Console.WriteLine("5. Quitter");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.Write("Choisissez une option : ");

            string itemString = Console.ReadLine();

            return itemString;
        }

        // Méthode pour ajouter un Contact
        public void AddContact(List<Contact> list)
        {
            Console.Write("Entrez le nom : ");
            string name = Console.ReadLine();

            Console.Write("Entrez le numéro de téléphone : ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Entrez l'email : ");
            string email = Console.ReadLine();

            // Validation basique
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Erreur : Tous les champs sont obligatoires. Le contact n'a pas été ajouté.");
                return;
            }

            // Ajout du contact à la liste
            list.Add(new Contact
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Email = email
            });

            Console.WriteLine("Contact ajouté avec succès !");

        }

        // Méthode pour afficher toutes les Contacts
        public void ShowContacts(List<Contact> list)
        {
            int compt = 0;
            Console.WriteLine("List des contacts :");
            foreach(Contact item in list)
            {
                Console.WriteLine($"{compt} . Nom : {item.Name}, Téléphone : {item.PhoneNumber}, Email : {item.Email}.");
                compt++;
            }
        }

        // Méthode pour rechercher un Contact
        public void SearchContact(List<Contact> list)
        {
            Console.Write("Entrez le nom à rechercher : ");
            string searchName = Console.ReadLine();

            // Recherche du contact correspondant
            Contact contact = list.FirstOrDefault(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                // Si le contact est trouvé
                Console.WriteLine("Résultat :");
                Console.WriteLine($"Nom : {contact.Name}, Téléphone : {contact.PhoneNumber}, Email : {contact.Email}");
            }
            else
            {
                // Si aucun contact ne correspond
                Console.WriteLine("Aucun contact trouvé avec ce nom.");
            }
        }

        // Méthode pour supprimer un Contact
        public void RemoveContact(List<Contact> list)
        {
            Console.Write("Entrez le nom du contact à supprimer: ");
            string itemToRemove = Console.ReadLine(); //si par ex : aa

            // Vérification du contact correspondant
            Contact contact = list.FirstOrDefault(c => c.Name.Equals(itemToRemove, StringComparison.OrdinalIgnoreCase));

            // Suppression du contact correspondant
            list.Remove(contact);


            if (contact == null)
            {
                // Si aucun contact ne correspond
                Console.WriteLine("Aucun contact trouvé avec ce nom.");
            }

            
        }
    }
}
