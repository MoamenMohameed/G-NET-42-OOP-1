namespace Taks{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Explain with code example how class and struct behave differently 
            /*
              Class : 
              A class is a blueprint that defines the structure and behavior of objects
              it groups related data(fields) and actions(methods) together.
              - Stored on the heap — reference type
              - Supports inheritance and polymorphism

              Struct :    
              A struct is a lightweight value type that holds related data together 
              ideal for small, simple objects like coordinates or colors.
              - Stored on the stack — fast access
              - Cannot inherit from other structs or classes
            */
            #endregion

            #region Q2 : Explain the difference between public and private access modifiers with an example. 
            /*
              private : 
              Accessibility: The member is only accessible within the class or struct it is defined in. It cannot be accessed from outside the class.
              Usage: Use for members that should only be accessible within the class, often for internal implementation details.
              
              public :
              Accessibility: The member is accessible from anywhere in the application, both within the same assembly (project) and from other assemblies.
              Usage: Use when you want to expose a class or method to other code.

            */
            #endregion

            #region Q3 : Describe the steps to create and use a class library in Visual    Studio.
            /*
                1- make a new project and select class library template
                2- add your classes and methods to the class library project
                3- build the class library project to generate the .dll file
                4- In your main project, add a reference to the class library by right-clicking on the project in the Solution Explorer,
                   selecting "Add" > "Reference", and then browsing to the .dll file of the class library.
                5- Import the namespace of the class library in your main project using the "using" directive.
                6- can create objects and call methods from the class library in your main
             */
            #endregion

            #region Q4 : What is a class library? Why do we use class libraries?
            /*
                A Class Library is a separate project that contains reusable classes,
                but has no Main method and cannot run on its own. It compiles into a .dll file
             */
            #endregion


            #region TicketApp
            // Get movie name from user input
            Console.Write("Enter Movie Name: ");
                string movieName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(movieName))
                {
                    Console.Write("Movie Name cannot be empty. Please enter a valid movie name.");
                    return;
                }
                // Get ticket type from user input
                Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX):  ");
                int  ticketType = int.Parse(Console.ReadLine());
                if(Enum.IsDefined(typeof(TicketType), ticketType) == false)
                {
                    Console.Write("Invalid Ticket Type. Please enter 0 for Standard, 1 for VIP, or 2 for IMAX.");
                    return;
                }

                // Get seat row and number from user input
                Console.Write("Enter Seat Row (A, B, C...): ");
                Char seatRow = char.Parse(Console.ReadLine());

                Console.Write("Enter Seat Number: ");
                int seatNumber = int.Parse(Console.ReadLine());

                // Get price and discount from user input
                Console.Write("Enter Price: ");
                int price = int.Parse(Console.ReadLine());

                Console.Write("Enter Discount Amount: ");
                int discount = int.Parse(Console.ReadLine());

            
                // Make a ticket object and print the ticket details
                Ticket ticket = new Ticket(movieName, new Seat(seatRow, seatNumber), (TicketType) ticketType, price);
            
            
                ticket.Print();
                ticket.Disccount(ref discount);
            #endregion



        }
    }
}   