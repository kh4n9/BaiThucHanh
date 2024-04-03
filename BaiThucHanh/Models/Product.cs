﻿namespace BaiThucHanh.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        public List<String> Size { get; set; }
        public List<String> Color { get; set; }
        public List<String> Image { get; set; }
    }
}
