//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nwd.BackOffice.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artist
    {
        public Artist()
        {
            this.Albums = new HashSet<Album>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public Nullable<int> Song_Id { get; set; }
    
        public virtual ICollection<Album> Albums { get; set; }
        public virtual Song Song { get; set; }
    }
}
