using Task = Domain.Entities.Task;

namespace Tests;

public class TaskTest
{
    [Fact]
    public void Create_Task_Successfully()
    {
        //Arrange - Act - Assert (AAA)

        #region Arrange

        /* Brief explanation
           
           In the Arrange phase, you prepare the environment and the data required to perform the test. 
           This preparation includes:

            - Instantiating classes and objects.
            - Configuring dependencies, such as mocks or stubs.
            - Defining variables and input data.
            - Ensuring the environment is in the expected initial state.

           The goal is to create all the necessary conditions so that the test phase (Act) can be executed without issues.
         */

        string Title = "Title";
        string Description = "Description";
        DateTime DueDate = DateTime.Now;
        int Priority = 1;
        List<string> Labels = ["Label 1", "Label 2"];

        #endregion

        #region Act

        /* Brief explanation
         
           In the Act phase, you execute the action or behavior being tested. 
           This step is the central point of the test, as it is where the code under test 
           (also known as the SUT, or System Under Test) is called or invoked.

           Act Summary:

           Focus: Execute the method or behavior being tested.
           Input: Uses the data or objects configured in the Arrange phase.
           Output: Produces a result or effect that will be validated in the next step (Assert).

           The goal is to observe how the system reacts when the method or functionality is used 
           with the data and environment prepared during the Arrange phase.
         */

        Task task = new(Title, DueDate, Priority, Description, Labels);

        #endregion

        #region Assert

        /* Brief explanation
         
        



        */
        #endregion
    }
}
