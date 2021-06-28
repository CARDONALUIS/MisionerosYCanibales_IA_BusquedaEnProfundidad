using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSyDFS
{
    class Estado
    {
        private int MI;
        public int mI { get { return MI; } set { MI = value; } }

        private int CI;
        public int cI { get { return CI; } set { CI = value; } }

        private int MD;
        public int mD { get { return MD; } set { MD = value; } }

        private int CD;
        public int cD { get { return CD; } set { CD = value; } }

        private char TIPODIR;
        public char tipoDir { get { return TIPODIR; } set { TIPODIR = value; } }

        private int NIVEL;
        public int nivel { get { return NIVEL; } set { NIVEL = value; } }


        public bool visitado = false;//Ya fue visitado
        public bool edoVali = false;//Saber si ya se sacaron sus estados posibles


        //public char tipoMov;

        //public List<String> movDes = new List<string>();
        //public int nivel = 0;
        public List<Movimiento> moviAct = new List<Movimiento>();//Todos lo movimientos posibles

        public List<Estado> edoAdy = new List<Estado>();//Lista de estados los cuales si se pudieron sacar en base al estado



        public Estado(int _mI, int _cI, int _mD, int _cD, char _dir, int _nivel)
        {
            mI = _mI;
            cI = _cI;
            mD = _mD;
            cD = _cD;
            tipoDir = _dir;
            nivel = _nivel;
        }

        /*
        public void creaMovi()
        {
            Movimiento m = new Movimiento(this, "M");
            this.movi.Add(m);
            Movimiento m1 = new Movimiento(this, "C");
            this.movi.Add(m1);
            Movimiento m2 = new Movimiento(this, "MM");
            this.movi.Add(m2);
            Movimiento m3 = new Movimiento(this, "CC");
            this.movi.Add(m3);
            Movimiento m4 = new Movimiento(this, "MC");
            this.movi.Add(m4);

        }
        */


    }
}
