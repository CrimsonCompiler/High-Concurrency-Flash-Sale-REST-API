using FlashSale.Api.DTOs;
using FlashSale.Api.Interfaces;
using FlashSale.Api.Models;

namespace FlashSale.Api.Services;

public class ProductService : IProductService
{
    private readonly IRepository<Product> _repository;

    public ProductService(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
    {
        var products = await _repository.GetAllAsync();
        return products.Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            OriginalPrice = p.OriginalPrice,
            FlashSalePrice = p.FlashSalePrice,
            TotalStock = p.TotalStock,
            SoldStock = p.SoldStock,
            FlashSaleStartTime = p.FlashSaleStartTime,
            FlashSaleEndTime = p.FlashSaleEndTime,
            IsActive = p.IsActive
        });
    }

    public async Task<ProductDto?> GetProductByIdAsync(int id)
    {
        var product = await _repository.GetByIdAsync(id);
        if (product == null) return null;

        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            OriginalPrice = product.OriginalPrice,
            FlashSalePrice = product.FlashSalePrice,
            TotalStock = product.TotalStock,
            SoldStock = product.SoldStock,
            FlashSaleStartTime = product.FlashSaleStartTime,
            FlashSaleEndTime = product.FlashSaleEndTime,
            IsActive = product.IsActive
        };
    }

    public async Task<ProductDto> CreateProductAsync(CreateProductDto dto)
    {
        var product = new Product
        {
            Name = dto.Name,
            OriginalPrice = dto.OriginalPrice,
            FlashSalePrice = dto.FlashSalePrice,
            TotalStock = dto.TotalStock,
            FlashSaleStartTime = dto.FlashSaleStartTime,
            FlashSaleEndTime = dto.FlashSaleEndTime,
            IsActive = true
        };

        await _repository.AddAsync(product);

        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            OriginalPrice = product.OriginalPrice,
            FlashSalePrice = product.FlashSalePrice,
            TotalStock = product.TotalStock,
            SoldStock = product.SoldStock,
            FlashSaleStartTime = product.FlashSaleStartTime,
            FlashSaleEndTime = product.FlashSaleEndTime,
            IsActive = product.IsActive
        };
    }
}