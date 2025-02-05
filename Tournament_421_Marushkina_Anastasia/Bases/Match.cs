//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_421_Marushkina_Anastasia.Bases
{
    using System;
    using System.Collections.Generic;
    
    public partial class Match
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Match()
        {
            this.MatchPlayer = new HashSet<MatchPlayer>();
            this.MatchTeam = new HashSet<MatchTeam>();
        }
    
        public int Id { get; set; }
        public int TourId { get; set; }
        public System.DateTime StartTimestamp { get; set; }
        public System.DateTime EndTimestamp { get; set; }
        public Nullable<int> WinnerId { get; set; }
        public Nullable<int> Score { get; set; }
    
        public virtual Tournament Tournament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchPlayer> MatchPlayer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchTeam> MatchTeam { get; set; }
    }
}
