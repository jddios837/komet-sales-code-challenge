namespace Sales.ManagementSystem.Shared.Product.InputModels;

public class CreateProductInputModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int? Code { get; set; }
    public int CategoryId { get; set; }
}