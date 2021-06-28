using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSyDFS
{
    class Arbol
    {
        public List<Estado> lisEdo = new List<Estado>();
        public List<Movimiento> lisMov = new List<Movimiento>();
        public List<String> Movi = new List<String>();

        public List<Estado> lisEdoBEP = new List<Estado>();


        bool bandPasEdo = false;
        int nivel = 1;
        int r = 0;


        bool bandTer = false;


        public void buscaCamino(Arbol ar, Estado es)
        {
            r = 0;
            foreach(Estado a in lisEdo)
            {
                r = 0;
                if(a == es)
                {
                    r = 0;
                    nivel = 1;
                    es.visitado = true;
                    Console.WriteLine("\nMI " + es.mI + " CI " + es.cI + "----------------MD " + es.mD + " CD " + es.cD + " Nivel " + es.nivel);
                    asignaVisitado(ar, es);
                    break;
                }
            }

            if(!bandTer)
            foreach(Estado b in lisEdo)
            {
                    r = 0;
                if(b.visitado == false)
                {
                        r = 0;
                    nivel = 1;
                    b.nivel = nivel;
                    buscaCamino(ar, es);
                    break;
                }
            }
            r = 0;

        }

        public void asignaVisitado(Arbol ar, Estado es)
        {

            r = 0;
            if (!es.edoVali)
                sacaEdoValidos(es);


            r = 0;
            if(!bandTer)
            foreach (Estado a in es.edoAdy)
            {
                    r = 0;
                nivel = es.nivel;

                if (a.visitado == true)
                {



                }
                else//decencientes directos
                {
                        r = 0;
                    nivel++;

                    a.visitado = true;
                    a.nivel = nivel;
                    lisEdo.Add(a);
                    buscaRepyRemp(a, lisEdoBEP);
                    Console.WriteLine("\nMI " + a.mI + " CI " + a.cI + "----------------MD " + a.mD + " CD " + a.cD + " Nivel " + a.nivel);
                    asignaVisitado(ar, a);

                }
            }
            //foreach(Estado a in )
        }

        public void buscaRepyRemp(Estado es , List<Estado> lisEdo)
        {
            bool banEnco = false;
            r = 0;

            for(int i = 0; i < lisEdo.Count; i++)
            {

                if (es.nivel == lisEdo[i].nivel)
                {
                    r = 0;

                    lisEdo.RemoveAll(x => x.nivel >= es.nivel);

                    /*for (int j = 0; j < lisEdo.Count; j++)
                    {
                        r = 0;
                        if (es.nivel <= lisEdo[j].nivel)
                        {
                            r = 0;
                            
                            lisEdo.RemoveAt(j);
                        }
                    }*/
                    //for(int j= 0; i <)

                    //
                    r = 0;
                    lisEdoBEP.Add(es);
                    r = 0;
                    banEnco = true;
                    break;
                }
            }
            
            if(banEnco == false)
            {
                r = 0;
                //lisEdo.Add(es);
                lisEdoBEP.Add(es);
                r= 0;
            }
            /*else
                lisEdoBEP.Add(es);*/

        }


        public void sacaEdoValidos(Estado es)
        {
            r = 0;
            for (int i = 0; i < 5; i++)
            {
                //es = esAnt;
                Estado esAux = new Estado(es.mI, es.cI, es.mD, es.cD, es.tipoDir, es.nivel);

                r = 0;
                switch (es.moviAct[i].tipoMov)
                {

                    case "M":
                        r = 0;
                        if (es.tipoDir == 'I')
                        {
                            r = 0;
                            if (es.mI >= 1 && es.mD <= 2)
                            {
                                esAux.mI--;//
                                esAux.mD++;
                                r = 0;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) && !estaEnRaiz(esAux))
                                    {

                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nIda M");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nRegreso M");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                if(esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nIda M");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nRegreso M");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }
                                //cout << "M: ";
                            }

                        }
                        else
                        {
                            r = 0;
                            if (es.mD >= 1 && es.mI <= 2)
                            {
                                r = 0;
                                esAux.mD--;
                                esAux.mI++;

                                if (esAux.nivel > 0)
                                {
                                    r = 0;
                                    if (esValido(esAux) &&!estaEnRaiz(esAux))
                                    {
                                        r = 0;
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nRegreso M");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIda M");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                    else
                                        r = 0;
                                }
                                else
                                {
                                    if (esValido(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nRegreso M");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIda M");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                //cout << "M: ";
                            }

                        }
                        break;

                    case "C":
                        if (es.tipoDir == 'I')
                        {
                            if (es.cI >= 1 && es.cD <= 2)
                            {
                                r = 0;
                                esAux.cI--;//3-1=2
                                esAux.cD++;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) &&  !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nIda C");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nRegreso C");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nIda C");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nRegreso C");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }

                                //cout << "C: ";
                            }


                        }
                        else
                        {
                            r = 0;
                            if (es.cD >= 1 && es.cI <= 2)
                            {
                                r = 0;
                                esAux.cD--;
                                esAux.cI++;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) &&  !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nRegreso C");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIda C");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nRegreso C");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nIda C");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }


                                //cout << "C: ";
                                r = 0;
                            /*
                                if (es.cD == lisEdo.ElementAt(es.nivel - 2).cD && es.cI == lisEdo.ElementAt(es.nivel - 2).cI)
                                {
                                    r = 0;
                                    es.moviAct[i].moviVali = false;
                                    es.cD = lisEdo.ElementAt(lisEdo.Count - 1).cD;
                                    es.cI = lisEdo.ElementAt(lisEdo.Count - 1).cI;
                                    //es.nivel = es.nivel + 1;

                                    aplicaRegla(es);
                                }
                                */
                            }

                        }
                        break;

                    case "MM":

                        if (es.tipoDir == 'I')
                        {
                            if (es.mI >= 2 && es.mD <= 1)
                            {
                                esAux.mI -= 2;
                                esAux.mD += 2;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) &&  !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nIda MM");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nRegreso MM");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nIda MM");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nRegreso MM");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }



                                //cout << "MM: ";
                            }


                        }
                        else
                        {
                            if (es.mD >= 2 && es.mI <= 1)
                            {
                                esAux.mD -= 2;
                                esAux.mI += 2;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) &&  !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nRegreso MM");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIda MM");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                    if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nRegreso MM");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nIda MM");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }
                                //cout << "MM: ";
                            }

                        }
                        break;

                    case "CC":

                        if (es.tipoDir == 'I')
                        {
                            if (es.cI >= 2 && es.cD <= 1)
                            {
                                esAux.cI -= 2;
                                esAux.cD += 2;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) &&  !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nIda CC");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nRegreso CC");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                    if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nIda CC");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nRegreso CC");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }

                                //cout << "CC: ";
                            }


                        }
                        else
                        {
                            if (es.cD >= 2 && es.cI <= 1)
                            {
                                esAux.cD -= 2;
                                esAux.cI += 2;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) &&  !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nRegreso CC");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIda CC");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nRegreso CC");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nIda CC");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }

                                //cout << "CC: ";
                            }

                        }
                        break;

                    case "MC":
                        r = 0;
                        if (es.tipoDir == 'I')
                        {
                            if (es.mI >= 1 && es.cI >= 1 && es.mD <= 2 && es.cD <= 2)
                            {
                                esAux.mI--;
                                esAux.cI--;
                                esAux.mD++;
                                esAux.cD++;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) &&  !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nIda MC");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nRegreso MC");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }else
                                    if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nIda MC");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nRegreso MC");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }
                                //cout << "MC: ";
                            }


                        }
                        else
                        {
                            if (es.mD >= 1 && es.cD >= 1 && es.mI <= 2 && es.cI <= 2)
                            {
                                esAux.mD--;
                                esAux.cD--;
                                esAux.mI++;
                                esAux.cI++;
                                if (esAux.nivel > 0)
                                {
                                    if (esValido(esAux) && !estaEnRaiz(esAux))
                                    {
                                        if (esAux.tipoDir == 'I')
                                        {
                                            Console.WriteLine("\nRegreso MC");
                                            esAux.tipoDir = 'D';
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIda MC");
                                            esAux.tipoDir = 'I';
                                        }
                                        creaMovi(esAux);
                                        es.edoAdy.Add(esAux);
                                    }
                                }
                                else
                                    if (esValido(esAux))
                                {
                                    if (esAux.tipoDir == 'I')
                                    {
                                        Console.WriteLine("\nRegreso MC");
                                        esAux.tipoDir = 'D';
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nIda MC");
                                        esAux.tipoDir = 'I';
                                    }
                                    creaMovi(esAux);
                                    es.edoAdy.Add(esAux);
                                }

                                //cout << "MC: ";
                            }

                        }
                        break;

                }

                r = 0;

                //if(es.edoAdy.Count!= 0)
                /*
                if (es.tipoDir == 'I')
                    es.tipoDir = 'D';
                else
                    es.tipoDir = 'I';
                    */

                /*if (esAux.mI == 0 && esAux.cI == 0)
                    r = 0;*/

                if (esTrminal(esAux))
                    bandTer = true;

            }
            r = 0;


            
            es.edoVali = true;
        }

        public bool estaEnRaiz(Estado es)
        {
            r = 0;
            foreach (Estado a in lisEdoBEP)
            {
                if (a.cI == es.cI && a.cD == es.cD && a.mD == es.mD && a.mI == es.mI && es.tipoDir != a.tipoDir)
                {
                    r = 0;
                    return true;
                }
                    
            }


            return false;
        }

        public void creaMovi(Estado act)
        {
            for (int i = 0; i < 5; i++)
            {
                Movimiento mo = new Movimiento(act, Movi[i]);
                act.moviAct.Add(mo);
            }
        }

        
        public Estado aplicaRegla(Estado es)
        {
            //int r = rand() % (5);
            int r = 0;
            Estado esAnt = new Estado(lisEdo.ElementAt(lisEdo.Count - 1).mI, lisEdo.ElementAt(lisEdo.Count - 1).cI, lisEdo.ElementAt(lisEdo.Count - 1).mD, lisEdo.ElementAt(lisEdo.Count - 1).cD, lisEdo.ElementAt(lisEdo.Count - 1).tipoDir, lisEdo.ElementAt(lisEdo.Count - 1).nivel);
            //Estado esAnt = new Estado(3, 3, 0, 0, 'I', 0);
            bandPasEdo = false;

            r = 0;
            for(int i = 0; i< 5;i++)
            {
                //es = esAnt;

                if (bandPasEdo)
                    break;
                r = 0;
                if (es.moviAct[i].moviVali)
                {
                    r = 0;
                    switch (es.moviAct[i].tipoMov)
                    {

                        case "M":
                            if (es.tipoDir == 'I')
                            {
                                r = 0;
                                if (es.mI >= 1 && es.mD <= 2 )
                                {
                                    es.mI--;//
                                    es.mD++;
                                    r = 0;
                                    
                                    //cout << "M: ";
                                }
                                else
                                {
                                    es.moviAct[i].moviVali = false;
                                    Console.WriteLine("!!!Entre!!!");
                                }

                            }
                            else
                            {
                                r = 0;
                                if (es.mD >= 1 && es.mI <= 2)
                                {
                                    r = 0;
                                    es.mD--;
                                    es.mI++;
                                    //cout << "M: ";
                                }
                                else
                                    es.moviAct[i].moviVali = false;
                            }
                            break;

                        case "C":
                            if (es.tipoDir == 'I')
                            {
                                if (es.cI >= 1 && es.cD <= 2)
                                {
                                    r = 0;
                                    es.cI--;//3-1=2
                                    es.cD++;
                                    //cout << "C: ";
                                }
                                else
                                    es.moviAct[i].moviVali = false;

                            }
                            else
                            {
                                r = 0;
                                if (es.cD >= 1 && es.cI <= 2)
                                {
                                    r = 0;
                                    es.cD--;
                                    es.cI++;
                                    //cout << "C: ";
                                    r = 0;
                                    if (es.cD == lisEdo.ElementAt(es.nivel - 2).cD && es.cI == lisEdo.ElementAt(es.nivel - 2).cI)
                                    {
                                        r = 0;
                                        es.moviAct[i].moviVali = false;
                                        es.cD = lisEdo.ElementAt(lisEdo.Count-1).cD;
                                        es.cI = lisEdo.ElementAt(lisEdo.Count - 1).cI;
                                        //es.nivel = es.nivel + 1;

                                        aplicaRegla(es);
                                    }
                                }
                                else
                                    es.moviAct[i].moviVali = false;
                            }
                            break;

                        case "MM":

                            if (es.tipoDir == 'I')
                            {
                                if (es.mI >= 2 && es.mD <= 1)
                                {
                                    es.mI -= 2;
                                    es.mD += 2;
                                    //cout << "MM: ";
                                }
                                else
                                    es.moviAct[i].moviVali = false;

                            }
                            else
                            {
                                if (es.mD >= 2 && es.mI <= 1)
                                {
                                    es.mD -= 2;
                                    es.mI += 2;
                                    //cout << "MM: ";
                                }
                                else
                                    es.moviAct[i].moviVali = false;
                            }
                            break;

                        case "CC":

                            if (es.tipoDir == 'I')
                            {
                                if (es.cI >= 2 && es.cD <= 1)
                                {
                                    es.cI -= 2;
                                    es.cD += 2;
                                    //cout << "CC: ";
                                }
                                else
                                    es.moviAct[i].moviVali = false;

                            }
                            else
                            {
                                if (es.cD >= 2 && es.cI <= 1)
                                {
                                    es.cD -= 2;
                                    es.cI += 2;
                                    //cout << "CC: ";
                                }
                                else
                                    es.moviAct[i].moviVali = false;
                            }
                            break;

                        case "MC":
                            if (es.tipoDir == 'I')
                            {
                                if (es.mI >= 1 && es.cI >= 1 && es.mD <= 2 && es.cD <= 2)
                                {
                                    es.mI--;
                                    es.cI--;
                                    es.mD++;
                                    es.cD++;
                                    //cout << "MC: ";
                                }
                                es.moviAct[i].moviVali = false;

                            }
                            else
                            {
                                if (es.mD >= 1 && es.cD >= 1 && es.mI <= 2 && es.cI <= 2)
                                {
                                    es.mD--;
                                    es.cD--;
                                    es.mI++;
                                    es.cI++;
                                    //cout << "MC: ";
                                }
                                else
                                    es.moviAct[i].moviVali = false;
                            }
                            break;

                    }

                    /*if (!esValido(es, es.moviAct[i]) || !es.moviAct[i].moviVali)
                    {
                        r = 0;
                        es.cD = esAnt.cD;
                        es.mD = esAnt.mD;
                        es.cI = esAnt.cI;
                        es.mI = esAnt.mI;
                        aplicaRegla(es);
                    }
                    else
                    {
                        r = 0;
                        if (es.tipoDir == 'I')
                            es.tipoDir = 'D';
                        else
                            es.tipoDir = 'I';

                        bandPasEdo = true;
                    }*/
                }
                /*else
                {
                    r = 0;
                    es = esAnt;
                }*/
                    
            }
            r = 0;

            

            return es;
        }


        public bool esValido(Estado es/*, Movimiento mo*/)
        {
            int r = 0;

            if (es.mI == 0 || es.mD == 0)
            {
               // cout << endl << "!!No puede comer" << endl; 
               
                return true;
            }
            else
            {
                if (es.mI >= es.cI && es.mD >= es.cD)
                {
                    r = 0;
                  //  cout << endl << "!!No puede comer" << endl; ;
                    return true;

                }
                else
                {
                    r = 0;
                    // cout << endl << endl << "!!Si puede comer" << endl;
                    //mo.moviVali = false;
                    return false;

                }
            }
            r = 0;
        }

        public bool esTrminal(Estado es)
        {
            if (es.mI == 0 && es.cI == 0)
            {
                //cout << endl << "ESTADO VALIDO!!!!! ";
                Console.WriteLine("\nMI " + es.mI + " CI " + es.cI + "----------------MD " + es.mD + " CD " + es.cD + " Nivel " + (es.nivel+1));
                Console.WriteLine("\n!!!!EstadoEncontrado!!!");
                Console.ReadKey();
                return true;
            }
            else
                return false;
        }


    }
}
