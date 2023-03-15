namespace CSharpStepByStep;

/// <summary>
/// Vehicle Types, I am avoiding to hardcode values
/// </summary>
public enum VehicleTypes
{
  Car,
  Truck
}

/// <summary>
/// Abstract base class for vehicles.
/// </summary>
public abstract class Vehicle
{
  /// <summary>
  /// Gets the description of the vehicle.
  /// </summary>
  /// <returns>A string representing the description of the vehicle.</returns>
  public abstract string GetVehicleDescription();
}

/// <summary>
/// Concrete class for cars.
/// </summary>
public class Car : Vehicle
{
  public static readonly Car Instance = new Car();
  /// <summary>
  /// Gets the description of the car.
  /// </summary>
  /// <returns>A string representing the description of the car.</returns>
  public override string GetVehicleDescription()
  {
    return "This is a car.";
  }
}

/// <summary>
/// Concrete class for trucks.
/// </summary>
public class Truck : Vehicle
{
  public static readonly Truck Instance = new Truck();
  /// <summary>
  /// Gets the description of the truck.
  /// </summary>
  /// <returns>A string representing the description of the truck.</returns>
  public override string GetVehicleDescription()
  {
    return "This is a truck.";
  }
}

/// <summary>
/// Factory class for creating vehicles without exposing creation logic to the client.
/// </summary>
public static class VehicleFactory
{
  /// <summary>
  /// Creates a new vehicle object of the specified type.
  /// </summary>
  /// <param name="vehicleType">The type of vehicle to create.</param>
  /// <returns>A new vehicle object of the specified type.</returns>
  public static Vehicle CreateVehicle(string vehicleType)
  {
    return vehicleType switch
    {
      nameof(VehicleTypes.Car) => Car.Instance,
      nameof(VehicleTypes.Truck) => Truck.Instance,
      _ => throw new ArgumentException("Invalid vehicle type"),
    };
  }
}
