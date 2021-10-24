using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FerreteriaAmericanaRH.Model
{
    public class Model1 : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Model1' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'FerreteriaAmericanaRH.Model.Model1' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Model1'  en el archivo de configuración de la aplicación.
        public Model1()
            : base("name=Model2")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Encabezado> Encabezados { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
    }
}