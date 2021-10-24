using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using FerreteriaAmericanaRH.Model;

namespace FerreteriaAmericanaRH
{
    /// <summary>
    /// Descripción breve de WSProcesoAutoDeterminacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSProcesoAutoDeterminacion : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string Input)
        {
            return Input;
        }
        [WebMethod]
        public List<Encabezado> GetEncabezados()
        {
            List<Encabezado> encabezados = new List<Encabezado>();

            using (var db = new Model1())
            {
                var query = from b in db.Encabezados select b;

                foreach (Encabezado item in query)
                {
                    Encabezado encabezado = new Encabezado();
                    encabezado = item;
                    encabezados.Add(encabezado);
                }
            }
            return encabezados;
        }

        [WebMethod]
        public List<Detalle> GetDetalles()
        {
            List<Detalle> detalles = new List<Detalle>();

            using (var db = new Model1())
            {
                var query = from b in db.Detalles select b;

                foreach (Detalle item in query)
                {
                    Detalle detalle = new Detalle();
                    detalle = item;
                    detalles.Add(detalle);
                }
            }
            return detalles;
        }

        [WebMethod]
        public string SetEncabezado(string TipoAutodeterminacion, string RNC, DateTime Periodo, string TipoDocumento, string Documento, string CodigoNomina, string Empleado)
        {
            Encabezado encabezado = new Encabezado();
            List<Detalle> detalles = new List<Detalle>();
            Detalle detalle = new Detalle();

            encabezado.TipoAutodeterminacion = TipoAutodeterminacion;
            encabezado.RNC = RNC;
            encabezado.Periodo = Periodo;
            
            detalle.TipoDocumento = TipoDocumento;
            detalle.Documento = Documento;
            detalle.CodigoNomina = CodigoNomina;
            detalle.Empleado = Empleado;

            detalles.Add(detalle);

            encabezado.Detalles = detalles;

            using (var db = new Model1())
            {
                db.Encabezados.Add(encabezado);
                db.SaveChanges();
            }

            return "Registrado";
        }
    }
}
