using BuildingBlocks.CQRS;

namespace Catalog.API.Products.CreateProduct;

public record CraeteProductCommand(string Name, List<string> Category, string Description,
    string ImageFile, decimal Price) : ICommand<CraeteProductResult>;
public record CraeteProductResult(Guid Id);

internal class CreateProductCommandHandler : ICommandHandler<CraeteProductCommand, CraeteProductResult>
{
    public async Task<CraeteProductResult> Handle(CraeteProductCommand command, CancellationToken cancellationToken)
    {
        return new CraeteProductResult(Guid.NewGuid());
    }
}

