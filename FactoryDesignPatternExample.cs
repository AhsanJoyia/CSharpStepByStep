namespace CSharpStepByStep
{
  public static class FactoryDesignPatternExample
  {
    public static void Main()
    {
      /// <summary>
      /// It will help to create object of vehicle based on parameter. Currently Vehicle Factory only support two types of vehicles Car, and Truck
      /// </summary>
      /// <returns></returns>
      var vehicleObject = VehicleFactory.CreateVehicle(nameof(VehicleTypes.Car));
      Console.WriteLine(vehicleObject.GetVehicleDescription());
    }
  }
}