# csharp-Eccezione

1.  Realizzare una classe che astragga il concetto di Studente, considerando che la classe sarà
    utilizzata per il gestionale di una scuola/università. Tale classe terrà conto del numero totale
    degli studenti iscritti nella scuola (numero totale degli oggetti Studente istanziati). Si vogliano
    realizzare i seguenti metodi:
    
              • Un metodo che permetta di aggiungere crediti. L’implementazione di tale metodo deve
              essere fatta in modo tale che non possano essere attribuiti ulteriori crediti qualora lo
              studente avesse già completato il corso di studi (il numero di crediti massimo ottenibile è
              180).
    
              • Un metodo che permetta di confrontare due studenti e di stabilire quale sia iscritto da più tempo.
    
              • Un metodo che calcola e restituisce la media dei voti di uno studente. Per l’assegnazione
                dei vari voti si utilizzi un array di n elementi (ogni cella conterrà un voto preso)
    
              • Un metodo che permetta di confrontare tre studenti e stabilisca quale sia lo studente con il maggiore numero di crediti
    
              • Un metodo che ritorni il numero totale degli studenti iscritti nella scuola
    
2. Creare un programma dove si provi a dividere un numero per 0, gestendo l’eccezione risultante
   con un messaggio di errore appropriato.
   
3. Creare un programma nel quale ci sia un cast di un oggetto da int a String. Gestire l’eccezione
   risultante con un messaggio di errore appropriato.
   
    Nota: per poter compilare senza errori, è necessario fare una variabile int con un valore, poi una
    variabile di tipo Object a cui si assegna il cast ad Object della variabile di interi e poi un
    Console.WriteLine di un cast a String della variabile di tipo Object.
   
4. Creare un programma che chieda l’immissione di un numero double. Gestire l’eccezione
   risultante dall’immissione di un carattere non numerico mostrando un messaggio di errore appropriato.
   
5. Creare un programma che preveda la stampa dei primi 5 elementi di un array di interi. Qualora
   l’array avesse meno di 5 elementi, gestire l’eccezione mostrando un messaggio di errore appropriato.
   
6. Scrivere un programma che, dato un numero ed un array di sottraendi, svolga l’operazione della
   sottrazione e, nel caso in cui la sottrazione fosse impossibile (ovvero quando il risultato è un
   numero negativo), sollevi un’eccezione personalizzata.
