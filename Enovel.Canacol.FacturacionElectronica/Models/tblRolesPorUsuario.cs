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
    using System;
    using System.Collections.Generic;
    
    public partial class tblRolesPorUsuario
    {
        public int ID { get; set; }
        public Nullable<int> IDRol { get; set; }
        public string Usuario { get; set; }
    
        public virtual tblRoles tblRoles { get; set; }
    }
}
