using Datos.EstudioJuridico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstudiosJuridicos
    {

        public int consultar_idficha(string numero_ficha)
        {
            List<spFichaPredialesconsultar_Result> lstFichaPrediales = new List<spFichaPredialesconsultar_Result>();
            using (Estudio_JuridicoEntities model = new Estudio_JuridicoEntities())
            {
                lstFichaPrediales = model.spFichaPredialesconsultar(numero_ficha).ToList();
            }


            return lstFichaPrediales[0].id_ficha;

        }
    }
}
