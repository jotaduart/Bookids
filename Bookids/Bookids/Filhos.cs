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
    
    public partial class Filhos : Pessoas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filhos()
        {
            this.Inscricoes = new HashSet<Inscricoes>();
        }
    
        public string Sexo { get; set; }
        public string DataNascicmento { get; set; }
        public int EscolasIdEscola { get; set; }
        public int ClientesIdPessoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscricoes> Inscricoes { get; set; }
        public virtual Escolas Escolas { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
