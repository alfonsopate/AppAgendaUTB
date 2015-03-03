using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAgendaUTB.Modelo
{

    public class Personas
    {

        private string id;
        private string nombres;
        private string apellidos;
        private string emailP;
        private string emailW;
        private string telefonoP;
        private string telefonoW;


        #region "Propiedades"
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string EmailP
        {
            get { return emailP; }
            set { emailP = value; }
        }
        public string EmailW
        {
            get { return emailW; }
            set { emailW = value; }
        }
        public string TelefonoP
        {
            get { return telefonoP; }
            set { telefonoP = value; }
        }
        public string TelefonoW
        {
            get { return telefonoW; }
            set { telefonoW = value; }
        }
        #endregion

        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Personas
        ///</summary>
        public Personas()
        {
            this.id = "T000XXXX";
            this.nombres = "";
            this.apellidos = "";
            this.emailP = "";
            this.emailW = "";
            this.telefonoP = "";
            this.telefonoW = "";
        }

        ///<summary>
        ///Contructor de inicialización Personas
        ///</summary>
        ///<param name="codigo"> Identificacion de Personas</param>
        ///<param name="nombre"> Nombres y Apaellidos de Persona</param>
        ///
        public Personas(string id, string nombre, string apellido, string emailp, string emailw, string telefonoP, string telefonow)
        {
            this.id = id;
            this.nombres = nombre;
            this.apellidos = apellido;
            this.emailP = emailp;
            this.emailW = emailw;
            this.telefonoP = telefonoP;
            this.telefonoW = telefonow;
        }
        #endregion

        #region "Métodos Sobre Escritos"
        /// <summary>
        /// Retorna el valor del objeto representado en una cadena
        /// </summary>
        /// 
        public override string ToString()
        {
            return "\n=============================================\n" +
                     "Identificación:  " + this.id + "\n" +
                     "Nombres:  " + this.nombres + "\n" +
                     "Apellidos:  " + this.apellidos + "\n" +
                     "email personal:" + this.emailP + "\n" +
                     "email trabajo:" + this.emailW + "\n" +
                     "telefono personal:" + this.telefonoP + "\n" +
                     "telefono trabajo:" + this.telefonoW;
        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            Personas o = (Personas)obj;
            bool result = false;

            /*if ((this.identificacion == o.identificacion) &&
                (this.balance == o.balance) &&
                (this.idcliente == o.idcliente))
                result = true;*/

            return result;
        }

        /// <summary>
        /// Devuelve la identificación del objecto
        /// </summary>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion


    }
}