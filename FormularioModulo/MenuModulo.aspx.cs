using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioModulo
{
    public partial class MenuModulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void _btnCalcularMod_Click(object sender, EventArgs e)
        {
            //Crear referencia a servicio
            RefServicioModulo.IServicioModulo sm = new RefServicioModulo.ServicioModuloClient();
            //Crear variables para validar conversión
            int primerNum = 0;
            int segundoNum = 0;
            bool primNumVal = Int32.TryParse(_txbxPrimNum.Text, out primerNum);
            bool segNumVal = Int32.TryParse(_txbxSegNum.Text, out segundoNum);

            if(primNumVal && segNumVal)
            {
                int resultado = sm.calcularModulo(primerNum, segundoNum);
                _lblRes.Text = string.Format("El módulo de sus dos números es: {0}", resultado.ToString());
            }
            else
            {
                Response.Write("<script>alert('Uno de los números ingresados no está en formato de número válido.')</script>");
                _lblRes.Text = "";
            }  
            
        }
    }
}