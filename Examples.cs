using CSharpStepByStep.DesignPatterns.Creational;

namespace CSharpStepByStep;

public static class Examples
{
  public static void Main()
  {
    #region Creational Design Patterns

    #region Factory Design Pattern
    /// <summary>
    /// It will help to create object of vehicle based on parameter. Currently Vehicle Factory only support two types of vehicles Car, and Truck
    /// </summary>
    /// <returns></returns>
    Vehicle? vehicleObject = VehicleFactory.CreateVehicle(nameof(VehicleTypes.Car));

    Console.WriteLine(vehicleObject.GetVehicleDescription());
    #endregion

    #region Singleton Design Pattern
    /// <summary>
    /// You will get the same instance because we are creating instance by using singleton design pattern. If you are getting difference instance everytime then there is flaw in your implementation
    /// </summary>
    /// <returns></returns>
    Singleton? instance1 = Singleton.GetInstance();
    Singleton? instance2 = Singleton.GetInstance();

    // true if instance1 is the same instance as instance2 or if both are null; otherwise, false
    if (ReferenceEquals(instance1, instance2))
    {
      Console.WriteLine("Singleton works because both variables contain the same instance.");
    }
    else
    {
      Console.WriteLine("Singleton failed, variables contain different instances.");
    }
    #endregion
    #endregion
  }
}
