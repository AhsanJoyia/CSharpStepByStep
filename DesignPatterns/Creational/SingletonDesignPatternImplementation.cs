namespace CSharpStepByStep.DesignPatterns.Creational;

/// <summary>
/// The Singleton class defines a method `GetInstance` that serves as an
/// alternative to constructor and lets clients access the same instance of
/// this class over and over. It is not necessary to use singleton as a class name. You can use whatever name you want
/// </summary>
public sealed class Singleton
{
  private static Singleton _instance = null!;

  /// <summary>
  /// The Singleton's constructor should always be private to prevent
  /// direct construction calls with the `new` operator.
  /// </summary>
  private Singleton() { }

  /// <summary>
  /// The static method that controls the access to the singleton instance.
  /// </summary>
  public static Singleton GetInstance()
  {
    return _instance ??= new Singleton();
  }

  /// <summary>
  /// Finally, any singleton should define some business logic, which can
  /// be executed on its instance.
  /// </summary>
  public static void SomeBusinessLogic()
  {
    Console.WriteLine("Here is my business logic");
  }
}
