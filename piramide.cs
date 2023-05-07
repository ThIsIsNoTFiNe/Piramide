
namespace Piramide{

    public static class Piramide {
        
        public static int Piani( int mattoni ) //CALCOLO I PIANI
        {
            int zero=0;
           if(mattoni<=0){
            return zero;
           }
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

        public static int Rimanenti( int mattoni )
        {
            int zero=0;
            if(mattoni<=1){
                return zero;
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
    }
}