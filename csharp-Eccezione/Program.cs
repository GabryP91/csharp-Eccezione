/*
    1.  Realizzare una classe che astragga il concetto di Studente, considerando che la classe sarà
        utilizzata per il gestionale di una scuola/università. Tale classe terrà conto del numero totale
        degli studenti iscritti nella scuola (numero totale degli oggetti Studente istanziati). Si vogliano
        realizzare i seguenti metodi:

            • Un metodo che permetta di aggiungere crediti. L’implementazione di tale metodo deve
              essere fatta in modo tale che non possano essere attribuiti ulteriori crediti qualora lo
              studente avesse già completato il corso di studi (il numero di crediti massimo ottenibile è 180).

            • Un metodo che permetta di confrontare due studenti e di stabilire quale sia iscritto da più tempo.

            • Un metodo che calcola e restituisce la media dei voti di uno studente. Per l’assegnazione
              dei vari voti si utilizzi un array di n elementi (ogni cella conterrà un voto preso)

            • Un metodo che permetta di confrontare tre studenti e stabilisca quale sia lo studente con il maggiore numero di crediti

            • Un metodo che ritorni il numero totale degli studenti iscritti nella scuola

    2. Creare un programma dove si provi a dividere un numero per 0, gestendo l’eccezione risultante con un messaggio di errore appropriato.

    3. Creare un programma nel quale ci sia un cast di un oggetto da int a String. Gestire l’eccezione risultante con un messaggio di errore appropriato.
        
            Nota: per poter compilare senza errori, è necessario fare una variabile int con un valore, poi una
            variabile di tipo Object a cui si assegna il cast ad Object della variabile di interi e poi un
            Console.WriteLine di un cast a String della variabile di tipo Object.

    4. Creare un programma che chieda l’immissione di un numero double. Gestire l’eccezione risultante dall’immissione di un carattere non numerico mostrando
       un messaggio di errore appropriato.

    5. Creare un programma che preveda la stampa dei primi 5 elementi di un array di interi. Qualora l’array avesse meno di 5 elementi, gestire l’eccezione mostrando
       un messaggio di errore appropriato.

    6. Scrivere un programma che, dato un numero ed un array di sottraendi, svolga l’operazione della sottrazione e, nel caso in cui 
       la sottrazione fosse impossibile (ovvero quando il risultato è un numero negativo), sollevi un’eccezione personalizzata. 
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_Eccezione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;

            while (true) // Loop infinito fino a scelta di uscita
            {
                Console.WriteLine("\n---------------------------------------------------\n");
                Console.WriteLine("Seleziona un esercizio da 1 a 6 oppure digita 0 per uscire:");

                Console.WriteLine("Caso [1]: Creazione istanza classe Studente");
                Console.WriteLine("Caso [2]: Divisione per zero");
                Console.WriteLine("Caso [3]: Cast obj => string ");
                Console.WriteLine("Caso [4]: Numero Double");
                Console.WriteLine("Caso [5]: Stampa array");
                Console.WriteLine("Caso [6]: Sottrazione numeri di un array");


                Console.WriteLine("\nFai la tua scelta\n");

                // Controllo input utente
                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                }

                if (scelta == 0)
                {
                    Console.WriteLine("Uscita dal programma...");
                    break; // Esce dal loop e termina il programma
                }

                Console.WriteLine("\n---------------------------------------------------\n");

                switch (scelta)
                {

                    case 1:
                        Console.WriteLine("ESERCIZIO 1\n");
                        
                        // Creazione di alcuni studenti
                        Studente s1 = new Studente(50, new DateTime(2020, 9, 1), new int[] { 28, 30, 25 });

                        Studente s2 = new Studente(120, new DateTime(2019, 9, 1), new int[] { 18, 20, 25, 30 });
                        Studente s3 = new Studente(150, new DateTime(2021, 9, 1), new int[] { 30, 29, 27,22,25 });
                        Studente s4 = new Studente(90, new DateTime(2013, 5, 3), new int[] {});

                        // Stampa numero totale di studenti iscritti
                        Console.WriteLine("\nNumero totale di studenti iscritti: " + Studente.GetNumeroTotaleStudenti());

                        // Aggiunta crediti
                        s1.AggiungiCrediti(20);
                        s2.AggiungiCrediti(80); // genera errore

                        // Stampa media voti
                        Console.WriteLine("\nMedia voti studente 1: " + s1.CalcolaMediaVoti());
                        Console.WriteLine("\nMedia voti studente 2: " + s2.CalcolaMediaVoti());
                        Console.WriteLine("\nMedia voti studente 4: " + s4.CalcolaMediaVoti());

                        // Confronto iscrizione
                        Studente piuVecchio = Studente.ConfrontaIscrizione(s1, s2);
                        // Stampa data iscrizione studente più vecchio
                        Console.WriteLine($"\nLo studente più vecchio è iscritto dal: {piuVecchio.DataIscrizione}");

                        // Confronto crediti
                        Studente maxCrediti = Studente.ConfrontaCrediti(s1, s2, s3);
                        // Stampa crediti studente maggiore
                        Console.WriteLine("\nPrimo confronto:");
                        Console.WriteLine($"\nLo studente con più crediti ha {maxCrediti.Crediti} crediti.");

                        // Confronto crediti
                        Studente maxCrediti2 = Studente.ConfrontaCrediti(s2, s4, s1);
                        // Stampa crediti studente maggiore
                        Console.WriteLine("\nSecondo confronto:");
                        Console.WriteLine($"\nLo studente con più crediti ha {maxCrediti2.Crediti} crediti.");

                        break;
                    case 2:
                        Console.WriteLine("ESERCIZIO 2\n");

                        try
                        {
                            Console.Write("Inserisci un numero: ");
                            int numero = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Inserisci il divisore: ");
                            int divisore = Convert.ToInt32(Console.ReadLine());

                            // Tentativo di divisione
                            int risultato = numero / divisore;

                            Console.WriteLine($"Il risultato della divisione è: {risultato}");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Errore: Non è possibile dividere per zero!");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Errore: Inserisci solo numeri validi!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Errore generico: {ex.Message}");
                        }
                        finally
                        {
                            Console.WriteLine("Programma terminato.");
                        }

                        break;
                    case 3:
                        Console.WriteLine("ESERCIZIO 3\n");

                        try
                        {
                            //object numero = 123; // Un valore di tipo int, ma trattato come object

                            int numeroIntero = 123; // Variabile int con un valore
                            object obj = (object)numeroIntero; // Cast a Object


                            string testo = ConvertiInString(obj); // Metodo che può generare un'eccezione

                            Console.WriteLine($"Il numero convertito in stringa è: {testo}");
                        }
                        catch (InvalidCastException ex)
                        {
                            Console.WriteLine($"Errore: {ex.Message}");
                        }
                        finally
                        {
                            Console.WriteLine("Programma terminato.");
                        }

                        break;
                    case 4:
                        Console.WriteLine("ESERCIZIO 4\n");

                        try
                        {
                            Console.Write("Inserisci un numero decimale: ");
                            string input = Console.ReadLine();

                            if (!double.TryParse(input, out double numero))
                            {
                                throw new InputNonValidoException();
                            }

                            Console.WriteLine($"Hai inserito il numero: {numero}");
                        }
                        catch (InputNonValidoException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Errore generico: {ex.Message}");
                        }

                        break;
                    case 5:
                        Console.WriteLine("ESERCIZIO 5\n");
                        try
                        {
                            int[] numeri = { 1, 2, 3, 4 };

                            for (int i = 0; i < 6; i++) // Qui si cerca di accedere oltre il limite
                            {
                                if (i >= numeri.Length)
                                {
                                    throw new FuoriArrayException();
                                }

                                Console.WriteLine(numeri[i]);
                            }
                        }

                        catch (FuoriArrayException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Errore generico: {ex.Message}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("ESERCIZIO 6\n");
                        try
                        {
                            int numero = 10, risultato=0;
                            int[] sottraendi = { 5, 3, 2, 1, 32 };

                            Console.Write("\nArray:  ");

                            //stampo l'array su una sola riga
                            Console.WriteLine(string.Join(" ", sottraendi));

                            Console.Write("\nNumero da sottrarre: {0}\n",numero);

                            foreach (int sottraendo in sottraendi)
                            {
                                risultato = numero - sottraendo;

                                if (risultato < 0)
                                {
                                    throw new Exception("\nErrore: La sottrazione non può essere eseguita. Risultato negativo. "+ risultato);
                                }
                               
                                else 
                                { 
                                    Console.WriteLine($"\nIl risultato della sottrazione è: {risultato} ({numero}-{sottraendo})");
                                }
                            }
                            Console.WriteLine($"\nIl risultato della sottrazione è: {risultato}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                }

            }
        }

        static string ConvertiInString(object obj)
        {
            if (obj is string)
            {
                return (string)obj; // Se l'oggetto è già una stringa, eseguiamo il cast
            }
            else
            {
                // Se l'oggetto non è una stringa, generiamo un'eccezione personalizzata
                throw new InvalidCastException(); // Lancia un'eccezione
            }
        }


    }

    // Classe personalizzata per gestire l'errore di conversione
    public class InputNonValidoException : Exception
    {
        public InputNonValidoException() : base("Errore: Il valore inserito non è un numero valido.") { }
    }

    // Classe personalizzata per gestire l'errore di conversione
    public class FuoriArrayException : Exception
    {
        public FuoriArrayException() : base("Errore: L'array non contiene abbastanza elementi.Versione personalizzata") { }
    }


    public class Studente
    {
        private static int numeroTotaleStudenti = 0; // Contatore per il numero totale di studenti
        private int crediti;
        private DateTime dataIscrizione;
        private int[] voti;

        // Getter e Setter
        public int Crediti
        {
            get { return crediti; }
            private set { crediti = value; } // Il setter è privato per controllare l'aggiunta dei crediti dall'esterno della classe
        }

        public DateTime DataIscrizione
        {
            get { return dataIscrizione; }
        }

        public int[] Voti
        {
            get { return voti; }
            set { voti = value; }
        }

        // Costruttore con parametri
        public Studente(int crediti, DateTime dataIscrizione, int[] voti)
        {
            numeroTotaleStudenti++; // Incrementa il numero totale di studenti
            Crediti = crediti;
            this.dataIscrizione = dataIscrizione;
            Voti = voti; 
        }

        // Costruttore senza parametri
        public Studente()
        {
            numeroTotaleStudenti++;
            Crediti = 0;
            this.dataIscrizione = DateTime.Now;
            Voti = new int[0];
        }

        // Metodo per aggiungere crediti per il singolo studente
        public void AggiungiCrediti(int creditiDaAggiungere)
        {
            if (Crediti + creditiDaAggiungere <= 180)
            {
                
                Console.WriteLine($"\nCrediti aggiornati: {Crediti} + {creditiDaAggiungere}");

                Crediti += creditiDaAggiungere;
            }
            else
            {
                Console.WriteLine("\nNon è possibile aggiungere ulteriori crediti. Limite massimo raggiunto.");
            }
        }

        // Metodo per confrontare due studenti in base alla data di iscrizione
        public static Studente ConfrontaIscrizione(Studente studente1, Studente studente2)
        {
            return (studente1.dataIscrizione < studente2.dataIscrizione) ? studente1 : studente2;
        }

        // Metodo per calcolare la media dei voti
        public double CalcolaMediaVoti()
        {
            if (Voti.Length == 0) return 0;

            int somma = 0;

            foreach (int voto in voti)
            {
                somma += voto;
            }

            double media = (double)somma / Voti.Length;

            return media;
        }

        // Metodo per confrontare tre studenti e restituire quello con il maggior numero di crediti
        public static Studente ConfrontaCrediti(Studente studente1, Studente studente2, Studente studente3)
        {
            // Creo un riferimento al primo studente
            Studente maxCreditiStudente = studente1;
            // Confronto il primo studente con il secondo e terzo
            if (studente2.Crediti > maxCreditiStudente.Crediti) maxCreditiStudente = studente2;
            if (studente3.Crediti > maxCreditiStudente.Crediti) maxCreditiStudente = studente3;
            // Restituisco lo studente con il maggior numero di crediti
            return maxCreditiStudente;
        }

        // Metodo per ottenere il numero totale degli studenti iscritti
        public static int GetNumeroTotaleStudenti()
        {
            return numeroTotaleStudenti;
        }
    }

}
