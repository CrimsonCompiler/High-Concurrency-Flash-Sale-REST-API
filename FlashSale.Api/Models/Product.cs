using System.ComponentModel.DataAnnotations;

namespace FlashSale.Api.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required, MaxLength(150)]
    public string Name { get; set; } = string.Empty;
    
    public decimal OriginalPrice { get; set; }
    public decimal FlashSalePrice { get; set; }
    
    // Concurrency Control
    [Timestamp]
    public byte[] RowVersion { get; set; } = new byte[0]; 
    
    public int TotalStock { get; set; }
    public int SoldStock { get; set; }
    public DateTime FlashSaleStartTime { get; set; }
    public DateTime FlashSaleEndTime { get; set; }
    public bool IsActive { get; set; }
}