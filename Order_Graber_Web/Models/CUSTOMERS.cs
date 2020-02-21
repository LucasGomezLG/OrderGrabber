using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Order_Graber_Web.Models
{
    public class CUSTOMERS
    {

        [ScaffoldColumn(false)]
        public int client_id { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres ")]
        [Display(Name = "Tipo de Documento")]
        public string document_type { get; set; }

        [Required(ErrorMessage = "El numero de documento es requerido")]
        [StringLength(20, ErrorMessage = "Maximo 20 caracteres")]
        [Display(Name = "Numero de Documento")]
        public string document_nro { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(255, ErrorMessage = "Maximo 255 caracteres")]
        [Display(Name = "Nombre")]
        public string customer_name { get; set; }

        [StringLength(255, ErrorMessage = "Maximo 255 caracteres")]
        [Display(Name = "Direccion")]
        public string address { get; set; }

        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        [Display(Name = "Telefono")]
        public string phone { get; set; }

        [StringLength(255, ErrorMessage = "Maximo 255 caracteres")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "El State es requerido")]
        [Display(Name = "State")]
        public string state { get; set; }

    }
}