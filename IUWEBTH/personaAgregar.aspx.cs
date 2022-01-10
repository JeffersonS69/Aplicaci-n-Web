using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IUWEBTH
{
    public partial class personaAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.lblMenaje.Text = "";
            if (txtcedula.Text.Length == 0)
            {
                this.lblMenaje.Text = "Registre su cedula bien...";
                this.txtcedula.Focus();
                return;

            }
            if (txtnombre.Text.Length == 0)
            {
                this.lblMenaje.Text = "Registre su Nombre bien...";
                this.txtnombre.Focus();
                return;

            }
            if (txtapellido.Text.Length == 0)
            {
                this.lblMenaje.Text = "Registre su apellido bien...";
                this.txtapellido.Focus();
                return;

            }
            if (txtfecha.Text.Length == 0)
            {
                this.lblMenaje.Text = "Registre su fecha bien...";
                this.txtfecha.Focus();
                return;

            }
            if (txtpeso.Text.Length == 0)
            {
                this.lblMenaje.Text = "Registre su peso bien...";
                this.txtpeso.Focus();
                return;

            }
            try
            {
                
                int x = BibliotecaDatos.Persona.insertar(this.txtcedula.Text, this.txtnombre.Text, this.txtapellido.Text, Convert.ToDateTime(this.txtfecha.Text), Convert.ToDouble(this.txtpeso.Text));
                if (x > 0)
                {
                    this.lblMenaje.Text = "Registrado con Exito...";
                }
            }
            catch (Exception ex)
            {
                this.lblMenaje.Text = ex.Message.ToString();
            }
            
            
        }
    }
}