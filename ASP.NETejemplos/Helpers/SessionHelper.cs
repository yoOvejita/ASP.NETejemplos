using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace ASP.NETejemplos.Helpers
{
    public static class SessionHelper
    {
        public static void setObjetoToJson(this ISession sesion, string clave, object valor) {
            sesion.SetString(clave, JsonConvert.SerializeObject(valor));
        }

        public static T getJsonToObjeto<T>(this ISession sesion, string clave) {
            var valor = sesion.GetString(clave);
            return valor == null ? default(T) : JsonConvert.DeserializeObject<T>(valor);
        }
    }
}
