using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSyDFS
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;

            List<String> lisMov = new List<String>();
            lisMov.Add("M");
            lisMov.Add("C");
            lisMov.Add("MM");
            lisMov.Add("CC");
            lisMov.Add("MC");
            List<Estado> EdoBEP = new List<Estado>();
            //int i = 0;


            //Estado es = new Estado();
            Program p = new Program();

            Estado es = new Estado(3, 3, 0, 0, 'I', 0);
           Estado esNue;


            for(int i = 0;i < 5; i++)
            {
                Movimiento mo = new Movimiento(es, lisMov[i]);
                es.moviAct.Add(mo);
            }
            //Movimiento mo = new Movimiento(es, lisMov[0]);
            Arbol ar = new Arbol();
            ar.Movi = lisMov;
            ar.lisEdo.Add(es);
            int iNiv = 0;
            //ar.lisMov.Add(mo);

            Estado esIte = new Estado(3, 3, 0, 0, 'I', 0);
            p.creaMovi(esIte, lisMov);



            /*while (!ar.esTrminal(esIte))
            {
                Console.WriteLine("\nMI " + esIte.mI + " CI " + esIte.cI + "----------------MD " + esIte.mD + " CD" + esIte.cD+" Nivel "+ esIte.nivel);
                Console.ReadKey();
                //esAnt = es;
                iNiv++;
                esIte.nivel = iNiv;
                esIte = ar.aplicaRegla(esIte);               
                
                ar.lisEdo.Add(esIte);
                r = 0;
                esNue = new Estado(esIte.mI, esIte.cI, esIte.mD, esIte.cD, esIte.tipoDir, iNiv);
                p.creaMovi(esNue, lisMov);
                esIte = esNue;

                
            }*/

            ar.lisEdoBEP.Add(es);
            ar.buscaCamino(ar, es);
            r = 0;


            //Console.WriteLine("\nDebio entrar "+ esIte.mI);
            

            //p.empieza(ar);
            r = 0;


            //Console.WriteLine(es.cI);
            //Console.ReadLine();

           /* while (es.cI >= 1 && es.mI >=  1)
            {
                r = 0;
                Console.WriteLine(es.cI + "Fuera \n");
                Console.WriteLine(es.mI + "Fuera \n");
                arbol.aplicaEdo(es);  
            */                     
            
        }

        public void creaMovi(Estado act, List<String> lisMov)               
        {
            for (int i = 0; i < 5; i++)
            {
                Movimiento mo = new Movimiento(act, lisMov[i]);
                act.moviAct.Add(mo);
            }
        }

    }
}
