//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enovel.Canacol.FacturacionElectronica.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblUsuariosProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsuariosProveedor()
        {
            this.tblRadicado = new HashSet<tblRadicado>();
        }
    
        public int ID { get; set; }
        [DisplayName("Usuario")]
        [Required(ErrorMessage = "El usuario es requerido")]
        public string UsuarioNit { get; set; }

        [DisplayName("Clave")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La clave es requerida")]
        public string Password { get; set; }

        [DisplayName("Confirmar clave")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La clave es requerida")]
        public string ConfirmarPassword { get; set; }

        [DisplayName("Razón social")]
        [Required(ErrorMessage = "La razón social es requerida")]
        public string RazonSocial { get; set; }

        [DisplayName("Calidad tributaria")]
        [Required(ErrorMessage = "La calidad tributaria es requerida")]
        public int IDCalidadTributaria { get; set; }

        [DisplayName("Empresa")]
        [Required(ErrorMessage = "La empresa es requerida")]
        public int IDEmpresa { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "El email es requerido")]
        public string Email { get; set; }

        [DisplayName("Teléfono")]
        [Required(ErrorMessage = "El teléfono es requerido")]
        public string Telefono { get; set; }

        [DisplayName("Dirección")]
        [Required(ErrorMessage = "La dirección es requerido")]
        public string Direccion { get; set; }

        [DisplayName("Represente Legal")]
        [Required(ErrorMessage = "El representante legal es requerido")]
        public string RepresentanteLegal { get; set; }

        [DisplayName("Rut")]
        [Required(ErrorMessage = "El rut es requerido")]
        public string RutaRut { get; set; }

        [DisplayName("Cámara de comercio")]
        [Required(ErrorMessage = "La cámara de comercio es requerida")]
        public string RutaCamaraComercio { get; set; }

        [DisplayName("Estado")]
        public string Estado { get; set; }
    
        public virtual tblCalidadTributaria tblCalidadTributaria { get; set; }
        public virtual tblEmpresa tblEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRadicado> tblRadicado { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}
