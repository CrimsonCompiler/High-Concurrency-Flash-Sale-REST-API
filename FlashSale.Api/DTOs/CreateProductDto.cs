using System.ComponentModel.DataAnnotations;

namespace FlashSale.Api.DTOs;

public class CreateProductDto
{
    [Required, MaxLength(150)]
    public string Name { get; set; } = string.Empty;
    
    [Range(0.01, double.MaxValue)]
    public decimal OriginalPrice { get; set; }
    
    [Range(0.01, double.MaxValue)]
    public decimal FlashSalePrice { get; set; }
    
    [Range(1, int.MaxValue)]
    public int TotalStock { get; set; }
    
    public DateTime FlashSaleStartTime { get; set; }
    public DateTime FlashSaleEndTime { get; set; }
}