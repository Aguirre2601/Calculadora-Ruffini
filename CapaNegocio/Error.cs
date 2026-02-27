using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Error
    {
        private string ErrorControl;
        private string ErrorMensaje;
        public string Control //La propiedad Control específica donde debería mostrarse el mensaje que es manejada por 
        {                      //la propiedad Mensaje.
            get { return this.ErrorControl; }
            set { this.ErrorControl = value; }
        }
        public string Mensaje
        {
            get { return this.ErrorMensaje; }
            set { this.ErrorMensaje = value; }
        }
    }
}
