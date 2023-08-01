using System.Data.SqlClient;
namespace ContactoAdo.Datos
{
    public class Conexion
    {
        
        private string cadenaSql = string.Empty; //ES PARA QUE NO SEA VACIO EL STRING.EMPTY
       //CONSEGUIR LA DOCUMENTACION DEL JSON
        public Conexion() 
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (
                    Directory.GetCurrentDirectory()
                )
                .AddJsonFile("appsettings.json").Build();
            cadenaSql = builder.GetSection("ConnectionStrings:cadenaSql").Value;
        }

        public string getCadenaSql()
        {
            return cadenaSql;
        }
    }
}
