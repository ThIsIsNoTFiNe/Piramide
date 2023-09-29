# Piramide
L'esercizio chiede, un volta data in ingresso un numero di mattoni, di calcolare quanti piani si possono creare ed, in caso ne remangano in più quanti.

### Calcolo piani:
Prima di tutto facciamo un contrllo per verificare se il numero di mattoni è <=0 ed in caso ritorniamo 0.

```C#
if(mattoni<=0){
            return 0;
           }
```
Come seconda cosa inizializziamo le variabili ***piani, mattoniTotali*** e le due basi della piramide (la base è quadrata quindi si vorrebbe anche fare un solo lato ed elevarlo alla seconda) ***l1, l2***.
####Nota: Tutte le variabili sono inizializzate a 1 perchè si da scontato che ci sia minimo un piano, in caso non ci sia c'è un controllo che in seguito sistemerà questa possibilità.
Inseguito inizamo con il vero e proprio algoritmo per calcolare il numero di piani.
Facciamo ciclare il while finche il numero di ***mattoniTotali*** è > di quello dei mattoni dati in ingresso in modo da finire tutti i mattoni.
Dopo facciamo aumentare di due il numero di ciascun lato (facciamo aumentare prorpio di due perchè ogni volta che aumenta un piano ogni lato si allarga di due), in fine facciamo il calcolo per trovare il numero di ***mattoniTotali***.
 Una volta datto ciò tramite un if controlliamo che il numero di ***mattonTotali** sia > di ***mattoni*** oppure < di 0 ed in quel caso eliminiamo un piano.
 Facciamo questo passaggio per eliminare un possibile piano non voluto a causa di un'abbondanza di mattoni dati.
 In conclusione ritorniamo il numero di piani.

```C#
 public static int Piani( int mattoni ) 
        {
           
           int piani = 1;
           int mattoniTotali=1;
           int l1 =1;
           int l2 =1;

            while(mattoniTotali<mattoni){

                l1+=2; //3
                l2+=2; //3
                
                mattoniTotali= mattoniTotali+(l1*l2); // 35+49== 84 
                 
                piani++; //2
            }
            
            if(mattoniTotali > mattoni || mattoni < 0){
                    piani-=1;
                }
           
        return piani;   

        }
```

### Calcolo mattoni rimanenti:

Per verificare, in caso di troppi mattoni dati, quanti ce ne siano in più utilizziamo la seguente soluzione.
Come prima facciamo un controllo che il numero di ***mattoni*** dati sia ***<= 1*** ed in caso sia vero ritorna 0.
Inizializziamo le varie variabili, come prima a 1 dando scontato che un piano sia già presente, in questo caso aggiungeremo anche la variabile ***mattoniprima*** che ci serverà la soluzione.
Come terza cosa trmite lo stesso while di prima facciamo iniziare il ciclo per il callcolo dei mattoni <br>
Dopo aver fatto umentare di due i lati come prima questa volta setteremo la variabile ***mattoniprima=mattoniTotali*** in modo che mantenga il numero di mattoni precedenti a quelli del ciclo presente. <br>
In fine creiamo un if nel quale se il numero di ***mattoni==mattoniTotali*** ritorna 0.
In caso questo if sia saltato ne creiamo un altro nel quale se ***mattoni>mattoniTotali*** ritorna il numero di mattoni dati meno quello dei mattoni che c'erano il giro prima. <br>
In caso neppure quest'ultimo venga preso ci si trovera un return nel quale il risultato è uguale al numero di mattoniTotali meno la moltiplicazione dei due lati del triangolo.

```C#
 public static int Piani( int mattoni ) 
        public static int Rimanenti( int mattoni )
        {
            if(mattoni<=1){
                return 0;
            }
           int mattoniTotali=1;
           int mattoniprima=0;
           int l1 =1;
           int l2 =1;

            while(mattoniTotali<mattoni){

                l1+=2; //3
                l2+=2; //3
                mattoniprima= mattoniTotali;
                mattoniTotali= mattoniTotali+(l1*l2); // 35+49== 84 
            }   
            if(mattoni==mattoniTotali){
                return 0;
            }
            if(mattoni>mattoniprima){
                return(mattoni-mattoniprima);
            }else{
                return (mattoniTotali-(l1*l2));
            }
           

        }
```
