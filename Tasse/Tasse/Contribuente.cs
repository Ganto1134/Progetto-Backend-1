namespace Tasse
{
    public enum Sesso // enum per limitare le risposte alal domanda sul sesso
    {
        Uomo,
        Donna,
        NonBinary
    }

    internal class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public Sesso Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public int RedditoAnnuale { get; set; }

        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, Sesso sesso, string comuneResidenza, int redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        public double CalcolaImposta()
        {
            int reddito = RedditoAnnuale;
            double imposta = 0;

            if (reddito <= 15000)
            {
                imposta = reddito * 0.23;
            }
            else if (reddito <= 28000)
            {
                imposta = 3450 + (reddito - 15000) * 0.27;
            }
            else if (reddito <= 55000)
            {
                imposta = 6960 + (reddito - 28000) * 0.38;
            }
            else if (reddito <= 75000)
            {
                imposta = 17220 + (reddito - 55000) * 0.41;
            }
            else
            {
                imposta = 25420 + (reddito - 75000) * 0.43;
            }
            // calcolo dell'imposta dovuta in base agli scaglioni
            return imposta;
        }

        public override string ToString()
        {
            return $"Contribuente: {Nome} {Cognome},\n" +
                   $"nato il {DataNascita:dd/MM/yyyy} ({Sesso}),\n" +
                   $"residente in {ComuneResidenza},\n" +
                   $"codice fiscale: {CodiceFiscale}\n" +
                   $"Reddito dichiarato: {RedditoAnnuale:F2}\n" +
                   $"IMPOSTA DA VERSARE: € {CalcolaImposta():F2}"; // la schermata finale con il riepilogo di tutti i dati inseriti 
        }
    }
}
