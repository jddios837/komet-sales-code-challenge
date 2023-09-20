using FluentValidation.TestHelper;
using Sales.ManagementSystem.API.Product.Validators;
using Sales.ManagementSystem.Shared.Product.InputModels;

namespace Sales.ManagementSystem.API.UnitTest.Validators.Product;

public class CreateProductInputModelValidatorTest
{
    private readonly CreateProductInputModelValidator _validator = new CreateProductInputModelValidator();
    private readonly CreateProductInputModel _model = new CreateProductInputModel();

    [Fact]
    public void Should_Not_Have_Error_When_Name_Is_Present()
    {
        _model.Name = "Product Name"; // Set a valid name
        var result = _validator.TestValidate(_model);

        result.ShouldNotHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public void Should_Have_Error_When_Name_Is_Empty()
    {
        _model.Name = ""; // Set an empty name
        var result = _validator.TestValidate(_model);

        result.ShouldHaveValidationErrorFor(x => x.Name)
            .WithErrorMessage("'Name' must not be empty.");
    }

    [Fact]
    public void Should_Have_Error_When_Name_Exceeds_Maximum_Length()
    {
        _model.Name = new string('A', 201); // Set a name that exceeds the maximum length
        var result = _validator.TestValidate(_model);

        result.ShouldHaveValidationErrorFor(x => x.Name)
            .WithErrorMessage("The length of 'Name' must be 200 characters or fewer. You entered 201 characters.");
    }

    [Fact]
    public void Should_Not_Have_Error_When_Description_Is_Present()
    {
        _model.Description = "Product Description"; // Set a valid description
        var result = _validator.TestValidate(_model);

        result.ShouldNotHaveValidationErrorFor(x => x.Description);
    }

    [Fact]
    public void Should_Have_Error_When_Description_Is_Empty()
    {
        _model.Description = ""; // Set an empty description
        var result = _validator.TestValidate(_model);

        result.ShouldHaveValidationErrorFor(x => x.Description)
            .WithErrorMessage("'Description' must not be empty.");
    }

    [Fact]
    public void Should_Have_Error_When_Description_Exceeds_Maximum_Length()
    {
        _model.Description = new string('A', 5001); // Set a description that exceeds the maximum length
        var result = _validator.TestValidate(_model);

        result.ShouldHaveValidationErrorFor(x => x.Description)
            .WithErrorMessage("The length of 'Description' must be 5000 characters or fewer. You entered 5001 characters.");
    }

    [Fact]
    public void Should_Not_Have_Error_When_Code_Is_Valid()
    {
        _model.Code = 1; // Set a valid code
        var result = _validator.TestValidate(_model);

        result.ShouldNotHaveValidationErrorFor(x => x.Code);
    }

    [Fact]
    public void Should_Have_Error_When_Code_Is_Less_Than_One()
    {
        _model.Code = 0; // Set a code less than 1
        var result = _validator.TestValidate(_model);

        result.ShouldHaveValidationErrorFor(x => x.Code)
            .WithErrorMessage($"'{nameof(_model.Code)}' must be greater than or equal to '1'.");
    }

    [Fact]
    public void Should_Not_Have_Error_When_CategoryId_Is_Present()
    {
        _model.CategoryId = 2; // Set a valid CategoryId
        var result = _validator.TestValidate(_model);

        result.ShouldNotHaveValidationErrorFor(x => x.CategoryId);
    }

    [Fact]
    public void Should_Have_Error_When_CategoryId_Is_Empty()
    {
        _model.CategoryId = 0; // Set an empty CategoryId
        var result = _validator.TestValidate(_model);

        result.ShouldHaveValidationErrorFor(x => x.CategoryId);
    }
}