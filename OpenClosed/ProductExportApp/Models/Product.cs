namespace ProductExportApp.Models;

public record Product(
  int Id,
  string Name,
  decimal Price,
  string Category
);