//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class APERTURA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APERTURA()
        {
            this.CIERRE = new HashSet<CIERRE>();
            this.DETALLE_MOVIMIENTO = new HashSet<DETALLE_MOVIMIENTO>();
            this.VENTA = new HashSet<VENTA>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> hora_apertura { get; set; }
        public Nullable<long> monto { get; set; }
        public string estado { get; set; }
        public Nullable<int> fk_id_usuario { get; set; }
        public Nullable<int> fk_id_caja { get; set; }
        public Nullable<int> monto_apertura { get; set; }
    
        public virtual CAJA CAJA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE> CIERRE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_MOVIMIENTO> DETALLE_MOVIMIENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
