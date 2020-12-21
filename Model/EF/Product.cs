﻿namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [DisplayName("Mã sản phẩm")]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        public long ID { get; set; }

        [StringLength(250)]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        [StringLength(10)]
        [DisplayName("Mã code")]
        public string Code { get; set; }

        [StringLength(250)]
        [DisplayName("Tiêu đề")]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [StringLength(250)]
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        [DisplayName("Các hình ảnh")]
        public string MoreImages { get; set; }

        [DisplayName("Giá")]
        public decimal? Price { get; set; }

        [DisplayName("Giá khuyến mãi")]
        public decimal? PromotionPrice { get; set; }

        [DisplayName("Bao gồm VAT")]
        public bool? IncludedVAT { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [DisplayName("Mã danh mục")]
        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        [DisplayName("Chi tiết")]
        public string Detail { get; set; }

        [DisplayName("Bảo đảm")]
        public int? Warranty { get; set; }

        [DisplayName("Ngày thêm")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        [DisplayName("Người thêm")]
        public string CreatedBy { get; set; }

        [DisplayName("Ngày sửa đổi")]
        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        [DisplayName("Người sửa đổi")]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        [DisplayName("Từ khóa")]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        [DisplayName("Mô tả meta")]
        public string MetaDescriptions { get; set; }

        [DisplayName("Trạng thái")]
        public bool? Status { get; set; }

        [DisplayName("Thời gian hot")]
        public DateTime? TopHot { get; set; }

        [DisplayName("Số lượt xem")]
        public int? ViewCount { get; set; }

        [StringLength(250)]
        [DisplayName("Màu sắc")]
        public string Color { get; set; }

        [StringLength(250)]
        [DisplayName("Nhiên liệu")]
        public string Fuels { get; set; }

        [StringLength(250)]
        [DisplayName("Hộp số")]
        public string Gear { get; set; }

    }
}
