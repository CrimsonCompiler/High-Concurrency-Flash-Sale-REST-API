namespace FlashSale.Api.DTOs;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal OriginalPrice { get; set; }
    public decimal FlashSalePrice { get; set; }
    public int TotalStock { get; set; }
    public int SoldStock { get; set; }
    public DateTime FlashSaleStartTime { get; set; }
    public DateTime FlashSaleEndTime { get; set; }
    public bool IsActive { get; set; }
}