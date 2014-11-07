using System.Reflection;
using System.Resources;

namespace Manager.Negocio
{
    public class Constantes
    {
        /// <summary>
        /// Roles
        /// </summary>
        public struct ROLES
        {
            /// <summary>
            /// Indica nombre rol administrador de sistema
            /// </summary>
            public static readonly string SISTEMA = "sistema";

            /// <summary>
            /// Indica nombre rol administrador de tiendas
            /// </summary>
            public static readonly string ADMIN = "administrador";

            /// <summary>
            /// Inidica nombre rol otro usuario del sistema
            /// </summary>
            public static readonly string USUARIO = "usuario";
        }

        /// <summary>
        /// Inidica acceso a recursos locales
        /// </summary>
        public struct RESOURCES
        {
            /// <summary>
            /// Recursos locales para mensajes de errores en el sistema
            /// </summary>
            public struct ERRORES
            {
                /// <summary>
                /// Nombre de recurso local para mensajes de error
                /// </summary>
                public static readonly string NAME = "Manager.Negocio.RecursosLocales.ErroresResource";

                /// <summary>
                /// Administrador de recursos locales para mensajes de error
                /// </summary>
                public static readonly ResourceManager MANAGER = new ResourceManager("Manager.Negocio.RecursosLocales.ErroresResource", Assembly.GetExecutingAssembly());
            }

            /// <summary>
            /// Recursos locales para mensajes del sistema
            /// </summary>
            public struct MENSAJES
            {
                /// <summary>
                /// Nombre de recurso local para mensajes
                /// </summary>
                public static readonly string NAME = "Manager.Negocio.RecursosLocales.MensajesResource";

                /// <summary>
                /// Administrador de recursos locales para mensajes
                /// </summary>
                public static readonly ResourceManager MANAGER = new ResourceManager("Manager.Negocio.RecursosLocales.MensajesResource", Assembly.GetExecutingAssembly());
            }
        }

        /// <summary>
        /// Indica string de conexion activo
        /// </summary>
        public static readonly string BD_CONNECTION_NAME = System.Configuration.ConfigurationManager.AppSettings["BD_CONNECTION_NAME"];

        /// <summary>
        /// Indica constantes en vistas del sistema
        /// </summary>
        public struct VISTA
        {
            /// <summary>
            /// Titulo predeterminado para las paginas
            /// </summary>
            public static readonly string TITULO = System.Configuration.ConfigurationManager.AppSettings["TITULO"];

            /// <summary>
            /// Version del producto .. dependiente del ambiente
            /// </summary>
            public static readonly string VERSION = System.Configuration.ConfigurationManager.AppSettings["VERSION"];

            /// <summary>
            /// Indica ambiente de instalacion: Desarrollo, Pruebas o Produccion
            /// </summary>
            public static readonly string AMBIENTE = System.Configuration.ConfigurationManager.AppSettings["AMBIENTE"];

            /// <summary>
            /// Indica URL Govic
            /// </summary>
            public static readonly string URL_CONTACTO = System.Configuration.ConfigurationManager.AppSettings["URL_CONTACTO"];

            /// <summary>
            /// Indica correo contacto Govic
            /// </summary>
            public static readonly string EMAIL_CONTACTO = System.Configuration.ConfigurationManager.AppSettings["EMAIL_CONTACTO"];

            /// <summary>
            /// Indica telefono contacto Govic
            /// </summary>
            public static readonly string TELEFONO_CONTACTO = System.Configuration.ConfigurationManager.AppSettings["TELEFONO_CONTACTO"];

            /// <summary>
            /// Indica texto para mostrar como referencia contacto Govic
            /// </summary>
            public static readonly string TEXTO_CONTACTO = System.Configuration.ConfigurationManager.AppSettings["TEXTO_CONTACTO"];
        }

        /// <summary>
        /// Mensajes de error
        /// </summary>
        public struct MENSAJE_ERROR
        {
            /// <summary>
            /// Vista Login
            /// </summary>
            public struct LOGIN
            {
                /// <summary>
                /// Nombre de usuario o cotraseña incorrectos.
                /// </summary>
                //public static readonly string ERR_LOG_001 = Manager.Negocio.RecursosLocales.ErroresResource.ERR_LOG_001;
                public static readonly string ERR_001 = RESOURCES.ERRORES.MANAGER.GetString("ERR_LOG_001");

                /// <summary>
                /// El nombre de usuario es obligatorio.
                /// </summary>
                public static readonly string ERR_002 = RESOURCES.ERRORES.MANAGER.GetString("ERR_LOG_002");

                /// <summary>
                /// El nombre de usuario debe tener entre 6 y 20 caracteres.
                /// </summary>
                public static readonly string ERR_003 = RESOURCES.ERRORES.MANAGER.GetString("ERR_LOG_003");

                /// <summary>
                /// La contraseña es obligatoria.
                /// </summary>
                public static readonly string ERR_004 = RESOURCES.ERRORES.MANAGER.GetString("ERR_LOG_004");
            }
        }
    }
}