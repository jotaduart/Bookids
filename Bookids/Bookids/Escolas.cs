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
    
    public partial class Escolas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Escolas()
        {
            this.Filhos = new HashSet<Filhos>();
            this.Participacoes = new HashSet<Participacoes>();
        }
    
        public int IdEscola { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Telefone { get; set; }
        public string Mail { get; set; }
        public string CodPostal { get; set; }
        public string Localidade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filhos> Filhos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participacoes> Participacoes { get; set; }
    }
}
