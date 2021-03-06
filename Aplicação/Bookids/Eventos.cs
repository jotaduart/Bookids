//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookids
{
    using System;
    using System.Collections.Generic;
    
    public partial class Eventos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eventos()
        {
            this.Inscricoes = new HashSet<Inscricoes>();
            this.Participacoes = new HashSet<Participacoes>();
            this.Colaboracoes = new HashSet<Colaboracoes>();
        }
    
        public int NrEvento { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public System.DateTime DataHora { get; set; }
        public int LimiteParticipacoes { get; set; }
        public Nullable<int> IdadeInferior { get; set; }
        public Nullable<int> IdadeSuperior { get; set; }
        public string TipoEvento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscricoes> Inscricoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participacoes> Participacoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaboracoes> Colaboracoes { get; set; }
    }
}
