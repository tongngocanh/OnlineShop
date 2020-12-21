namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        [Key]
        [DisplayName("Mã danh mục")]
        [Required(ErrorMessage = "Mã danh mục không được để trống!")]
        public long ID { get; set; }

        [StringLength(250)]
        [DisplayName("Tên danh mục")]
        public string Name { get; set; }

        [StringLength(250)]
        [DisplayName("Tiêu đề")]
        public string MetaTitle { get; set; }

        [DisplayName("Mã parent")]
        public long? ParentID { get; set; }

        [DisplayName("Hiển thị")]
        public int? DisplayOrder { get; set; }

        [StringLength(250)]
        [DisplayName("Tiêu đề SEO")]
        public string SeoTitle { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        [DisplayName("Người tạo")]
        public string CreatedBy { get; set; }

        [DisplayName("Ngày sửa đổi")]
        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        [DisplayName("Ngày sửa đổi")]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        [DisplayName("Từ khóa")]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        [DisplayName("Mô tả")]
        public string MetaDescriptions { get; set; }

        [DisplayName("Trạng thái")]
        public bool? Status { get; set; }

        [DisplayName("Hiển thị trên Home")]
        public bool? ShowOnHome { get; set; }
    }
}
