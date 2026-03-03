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
        }
    }
}
