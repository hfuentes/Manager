using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Manager.Models
{
    [Table("Tienda")]
    public class Tienda
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessageResourceType=typeof(Manager.Negocio.RecursosLocales.ErroresResource), ErrorMessageResourceName="ERR_TIE_001")]
        public string Referencia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Manager.Negocio.RecursosLocales.ErroresResource), ErrorMessageResourceName = "ERR_TIE_002")]
        public string AdministradorId { get; set; }

        /// <summary>
        /// Indica el administrador de la tienda
        /// </summary>
        [ForeignKey("AdministradorId")]
        public ApplicationUser Administrador { get; set; }
    }
}