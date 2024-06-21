using System.Text;

namespace Tasse 
{
    internal class Program 
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // encoding per poter utilizzare il simbolo dell'euro

            Console.Write("Inserisci il nome: "); //tutti i campi in cui inserire i dati cche verranno utilizzanti con check che siano corretti
            string nome = Console.ReadLine();

            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Inserisci la data di nascita (gg/mm/aaaa): ");
            DateTime dataNascita;
            while (!DateTime.TryParse(Console.ReadLine(), out dataNascita))
            {
                Console.Write("Data non valida. Inserisci la data di nascita (gg/mm/aaaa): ");
            }

            Console.Write("Inserisci il codice fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Inserisci il sesso (Uomo/Donna/NonBinary): ");
            Sesso sesso;
            while (!Enum.TryParse(Console.ReadLine(), true, out sesso) || !Enum.IsDefined(typeof(Sesso), sesso))
            {
                Console.Write("Sesso non valido. Inserisci il sesso (Uomo/Donna/NonBinary): ");
            }

            Console.Write("Inserisci il comune di residenza: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Inserisci il reddito annuale: ");
            int redditoAnnuale;
            while (!int.TryParse(Console.ReadLine(), out redditoAnnuale))
            {
                Console.Write("Importo non valido. Inserisci il reddito annuale: ");
            }

            Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

            Console.WriteLine("==================================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine(contribuente);
        }
    }
}
