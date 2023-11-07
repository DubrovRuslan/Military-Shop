using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data;

public static class DbInitializer
{
    public static async Task Initialize(ApplicationDbContext context)
    {
        await context.Database.EnsureCreatedAsync();

        if (!context.CatalogBrands.Any())
        {
            await context.CatalogBrands.AddRangeAsync(GetPreconfiguredCatalogBrands());

            await context.SaveChangesAsync();
        }

        if (!context.CatalogTypes.Any())
        {
            await context.CatalogTypes.AddRangeAsync(GetPreconfiguredCatalogTypes());

            await context.SaveChangesAsync();
        }

        if (!context.CatalogItems.Any())
        {
            await context.CatalogItems.AddRangeAsync(GetPreconfiguredItems());

            await context.SaveChangesAsync();
        }
    }

    private static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
    {
        return new List<CatalogBrand>()
        {
            new CatalogBrand() { Brand = "All" },
            new CatalogBrand() { Brand = "M-Tac" },
            new CatalogBrand() { Brand = "5.11" },
            new CatalogBrand() { Brand = "UF PRO" },
            new CatalogBrand() { Brand = "Under Armor" }
        };
    }

    private static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
    {
        return new List<CatalogType>()
        {
            new CatalogType() { Type = "All" },
            new CatalogType() { Type = "Trousers" },
            new CatalogType() { Type = "T-shirt" },
            new CatalogType() { Type = "Sweater" },
            new CatalogType() { Type = "Headwear" }
        };
    }

    private static IEnumerable<CatalogItem> GetPreconfiguredItems()
    {
        return new List<CatalogItem>()
        {
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Agressor Brown", Name = "M-Tac Agressor Brown", Price = 65.6M, PictureFileName = "1.png" },
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Agressor Black", Name = "M-Tac Agressor Black", Price = 65.6M, PictureFileName = "2.png" },
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 3, AvailableStock = 100, Description = "5.11 Conquistador Olive", Name = "5.11 Conquistador Olive", Price = 65.6M, PictureFileName = "3.png" },
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 3, AvailableStock = 100, Description = "5.11 Conquistador Black", Name = "5.11 Conquistador Black", Price = 63.5M, PictureFileName = "4.png" },
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Patrol Olive", Name = "M-Tac Patrol Olive", Price = 61M, PictureFileName = "5.png" },
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Agressor Olive", Name = "M-Tac Agressor Olive", Price = 63.5M, PictureFileName = "6.png" },
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 5, AvailableStock = 100, Description = "Under Armor Rubicon Olive", Name = "Under Armor Rubicon Olive", Price = 75.5M, PictureFileName = "7.png" },
            new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 3, AvailableStock = 100, Description = "5.11 Conquistador Olive", Name = "5.11 Conquistador Olive", Price = 63.5M, PictureFileName = "8.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Dark Side Olive", Name = "M-Tac Dark Side Olive", Price = 15.5M, PictureFileName = "9.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 3, AvailableStock = 100, Description = "5.11 Mavic", Name = "5.11 Mavic", Price = 14M, PictureFileName = "10.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Dark Side Brown", Name = "M-Tac Dark Side Brown", Price = 14M, PictureFileName = "11.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 4, AvailableStock = 100, Description = "UF PRO Viking Brown", Name = "UF PRO Viking Brown", Price = 17M, PictureFileName = "12.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Hetman Black", Name = "M-Tac Hetman Black", Price = 19M, PictureFileName = "13.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Hetman olive", Name = "M-Tac Hetman Olive", Price = 12M, PictureFileName = "14.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 5, AvailableStock = 100, Description = "Under Armor Sky Warrior Brown", Name = "Under Armor Sky Warrior Brown", Price = 23M, PictureFileName = "15.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Patriot Olive", Name = "M-Tac Patriot Olive", Price = 20M, PictureFileName = "16.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 5, AvailableStock = 100, Description = "Under Armor Fury Black", Name = "Under Armor Fury Black", Price = 25M, PictureFileName = "17.png" },
            new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Patriot Brown", Name = "M-Tac Patriot Brown", Price = 18M, PictureFileName = "18.png" },
            new CatalogItem { CatalogTypeId = 4, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Sweater Olive", Name = "M-Tac Sweater Olive", Price = 75.5M, PictureFileName = "19.png" },
            new CatalogItem { CatalogTypeId = 4, CatalogBrandId = 3, AvailableStock = 100, Description = "5.11 Sweater Black", Name = "5.11 Sweater Black", Price = 75.5M, PictureFileName = "20.png" },
            new CatalogItem { CatalogTypeId = 4, CatalogBrandId = 5, AvailableStock = 100, Description = "Under Armor Sweater Black", Name = "Under Armor Sweater Black", Price = 75.5M, PictureFileName = "21.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Bad Company Black", Name = "M-Tac Bad Company Black", Price = 75.5M, PictureFileName = "22.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Bad Company  Olive", Name = "M-Tac Bad Company  Olive", Price = 75.5M, PictureFileName = "23.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 3, AvailableStock = 100, Description = "5.11 Patriot Blue", Name = "5.11 Patriot Blue", Price = 75.5M, PictureFileName = "24.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 3, AvailableStock = 100, Description = "5.11 Patriot Grey", Name = "5.11 Patriot Grey", Price = 75.5M, PictureFileName = "25.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 5, AvailableStock = 100, Description = "Under Armor Black", Name = "Under Armor Black", Price = 75.5M, PictureFileName = "26.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 4, AvailableStock = 100, Description = "UF PRO Black", Name = "UF PRO Black", Price = 75.5M, PictureFileName = "27.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Tactical Olive", Name = "M-Tac Tactical Olive", Price = 75.5M, PictureFileName = "28.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Tactical Summer Black", Name = "M-Tac Tactical Summer Black", Price = 75.5M, PictureFileName = "29.png" },
            new CatalogItem { CatalogTypeId = 5, CatalogBrandId = 2, AvailableStock = 100, Description = "M-Tac Tactical Summer Brown", Name = "M-Tac Tactical Summer Brown", Price = 75.5M, PictureFileName = "30.png" }
        };
    }
}