using System;
namespace CarInventoryApp.Shared.Models;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public float Price { get; set; }
    public int Stock { get; set; }
}

