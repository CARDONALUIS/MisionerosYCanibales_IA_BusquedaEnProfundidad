using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSyDFS
{
    class Movimiento
    {
        public bool moviVali = true;

        private Estado EDOACT;
        public Estado edoAct { get { return EDOACT; } set { EDOACT = value; } }


        /*private Estado EDOANT;
        public Estado edoAnt { get { return EDOANT; } set { EDOANT = value; } }*/

        private String TIPOMOV;
        public String tipoMov { get { return TIPOMOV; } set { TIPOMOV = value; } }

        

        /*private String DIRMOV;
        public String dirMov { get { return DIRMOV; } set { DIRMOV = value; } }*/

        
        //public Estado EdoAnt;
        //public Estado EdoAct;


        public Movimiento(Estado _edoAct, String _TipoM)
        {
            edoAct = _edoAct;
            tipoMov = _TipoM;
        }


    }
}
