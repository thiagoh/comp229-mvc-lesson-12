namespace comp229_mvc_lesson_12.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Genre")]
    public partial class Genre {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genre() {
            Albums = new HashSet<Album>();
        }

        /// <summary>
        /// This constructor takes one argument of type string and assigns the value to the Name property
        /// </summary>
        /// <param name="name"></param>
        public Genre(string name) {
            this.Name = name;
        }

        public int GenreId { get; set; }

        [StringLength(120)]
        [Display(Name = "Genre")]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Albums { get; set; }
    }
}
