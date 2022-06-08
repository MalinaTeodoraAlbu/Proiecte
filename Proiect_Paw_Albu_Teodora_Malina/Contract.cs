using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Paw_Albu_Teodora_Malina
{
    class Contract
    {
        Furnizor f;
       
        private int idContract;
        public int IDContract
        {
            get => idContract;
            set
            {
                if (value > 0)
                {
                    this.idContract = value;
                }
                else
                {
                    this.idContract = 0;
                }
            }
        }

        public Contract(int iDContract)
        {
            IDContract = iDContract;
        }

        public Contract(Furnizor f, int idContract)
        {
            this.f = f;
            this.idContract = idContract;
        }
     

    }
}
