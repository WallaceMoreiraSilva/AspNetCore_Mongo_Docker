using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        public static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "65400cb75d6f472897719b9f2cbfec9b",
                    Name = "Caderno Espiral Pequeno",
                    Description = "Caderno Espiral com 100 folhas pequeno.",
                    Image = "caderno.png",
                    Price = 7.65M,
                    Category = "MaterialEscolar"
                },
                new Product()
                {
                    Id = "17f2ba934d214ff6860abceba7e6eb95",
                    Name = "Borracha Branca Pequena",
                    Description = "Borracha branca pequena para lápis.",
                    Image = "borracha.png",
                    Price = 4.55M,
                    Category = "MaterialEscolar"
                },
                new Product()
                {
                    Id = "9c1a895de49f4484ad57dc12792e94cf",
                    Name = "Estojo de Plástico Pequeno",
                    Description = "Estojo de plástico pequeno azul.",
                    Image = "estojo.png",
                    Price = 6.79M,
                    Category = "MaterialEscolar"
                },
                new Product()
                {
                    Id = "9c65739b9d9bf8450595c600ebe379703a",
                    Name = "Clips para Pápeis Pequenos",
                    Description = "Clips para pápeis pequenos 100g",
                    Image = "clips.png",
                    Price = 3.25M,
                    Category = "MaterialEscolar"
                },
                new Product()
                {
                    Id = "4acc4ed8e41a49dcb7e47e69a937e276",
                    Name = "Apontador Pequeno",
                    Description = "Apontador pequeno preto",
                    Image = "apontador.png",
                    Price = 1.25M,
                    Category = "MaterialEscolar"
                },
                new Product()
                {
                    Id = "87aebcf7d3d84bb184825bbed60a317f",
                    Name = "Papel A4",
                    Description = "Papel A4 branco",
                    Image = "papel.png",
                    Price = 5.00M,
                    Category = "MaterialEscolar"
                }
            };
        }
    }
}