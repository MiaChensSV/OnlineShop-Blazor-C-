﻿using OnlineShop_CourseSubmission_CS.Components;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OnlineShop_CourseSubmission_CS.Data
{
    public class DataService
    {
        //get data from webAPI
        public async Task<Products[]> GetAllProducts()
        {
            HttpClient client = new();
            try
            {
                if (DataStorage.ProductList == null){
                        using HttpResponseMessage response = await client.GetAsync("https://fakestoreapi.com/products");
                        response.EnsureSuccessStatusCode();
                        string responseBody = response.Content.ReadAsStringAsync().Result;

                    //deserialize received json to object
                        DataStorage.ProductList = JsonSerializer.Deserialize<Products[]>(responseBody)!;
                        return DataStorage.ProductList;
                } else
                {
                    return DataStorage.ProductList;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
