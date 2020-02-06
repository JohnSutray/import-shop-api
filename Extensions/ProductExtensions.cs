﻿using ImportShopApi.Models.Product;

namespace ImportShopApi.Extensions
{
  public static class ProductExtensions
  {
    public static string ToProductCaption(this Product product) => string.Join(
      '\n',
      product.Name,
      product.Description,
      $"Стоимость: {product.Price}р."
    );
  }
}