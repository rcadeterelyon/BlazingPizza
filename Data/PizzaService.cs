namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        // Simulating an asynchronous operation, such as fetching data from a database or API
        await Task.Delay(1000); // Simulating a delay
        
        var pizzas = new[]
        {
            new Pizza { PizzaId = 1, Name = "The Baconatorizor", Price = 11.99M, Description = "It has EVERY kind of bacon" },
            new Pizza { PizzaId = 2, Name = "Buffalo chicken", Price = 12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up"},
            new Pizza { PizzaId = 3, Name = "Veggie Delight", Price = 11.5M, Description = "It's like salad, but on a pizza" },
            new Pizza { PizzaId = 4, Name = "Margherita", Price = 9.99M, Description = "Traditional Italian pizza with tomatoes and basil"},
            new Pizza { PizzaId = 5, Name = "Basic Cheese Pizza", Price = 11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?" },
            new Pizza { PizzaId = 6, Name = "Classic pepperoni", Price = 10.5M, Description = "It's the pizza you grew up with, but Blazing hot!"}
        };
        return pizzas;
    }
}