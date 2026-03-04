namespace Assignment_session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            #region A
            // a =>  Composition
            // Reason: Department cannot exist independently without the University.
            // If the University is closed, all Departments are destroyed.
            #endregion

            #region B
            // b =>  Association
            // Reason: Driver uses a Car but does not own it.
            // There is no whole-part relationship between them.
            #endregion

            #region C
            // c => Inheritance
            // Reason: A Dog is an Animal, which represents an IS-A relationship.
            #endregion

            #region D
            // d =>  Aggregation
            // Reason: Players can exist independently of the Team.
            // If the Team is deleted, Players still exist.
            #endregion

            #region e
            // e =>  Dependency
            // Reason: Logger is used only as a method parameter temporarily
            // and is not stored as a field. This represents the weakest relationship.
            #endregion

            #endregion

            #region Part 2
            #region A
            /*
                
               A =>  Yes, a child class in a different assembly can access a protected field 
                because protected allows access through inheritance.
                
                However, it cannot be accessed through an object instance from outside 
                the class hierarchy. Protected members are only accessible inside the 
                class itself or inside derived classes.
           */
            #endregion

            #region B
            /*
                
               B => protected internal:
                Accessible either from the same assembly OR from derived classes (even if they are in a different assembly).
                
              private protected:

                Accessible only within the same assembly AND only through inheritance.
                

            */
            #endregion

            #region C
            /*
            c => Sealed is a modifier that can be applied to classes and methods in C#.
            When sealed is applied to a class:
            It prevents the class from being inherited.
            
            Example:
            sealed class MyClass { }
            
            When sealed is applied to a method:
            It prevents further overriding in derived classes.
            It must be used with an overridden method.
            
            So:
            sealed class → no inheritance
            sealed method → no further override
            */
            #endregion

           

            #endregion
        }
    }
}
