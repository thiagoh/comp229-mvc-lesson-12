namespace comp229_mvc_lesson_12.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album {

        public Album() {

        }

        /// <summary>
        /// This constructor takes one argument title which sets the Title property to its value
        /// </summary>
        /// <param name="title"></param>
        public Album(string title) {
            this.Title = title;
        }


        public virtual int AlbumId { get; set; }

        // Genre foreign key
        public virtual int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        // Artist foreign key
        public virtual int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        [Required]
        [StringLength(160)]
        [Display(Name = "Album Title")]
        public virtual string Title { get; set; }

        [Column(TypeName = "numeric")]
        public virtual decimal Price { get; set; }

        [StringLength(1024)]
        [Display(Name = "Album Art URL")]
        [ScaffoldColumn(false)]
        public virtual string AlbumArtUrl { get; set; }




    }
}
