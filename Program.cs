using static test.rectangle;

namespace test
{
    class A

    {
        public int employee_id;
        public string employee_name;
        private string employee_dep;

        A()
        {
            this.employee_id = 07;
            this.employee_name = "Rahul";
            this.employee_dep = "Sales";

        }
        A(int id, string emp_name, string emp_dep)//parameterized constructor
        {
            employee_id = id;
            employee_name = emp_name;
            employee_dep = emp_dep;

        }

        A(A ob1)//copy constructor
        {
            this.employee_id = ob1.employee_id;
            this.employee_name = ob1.employee_name;
            this.employee_dep = ob1.employee_dep;
        }

        public int add(int a, int b)//overloading
        {
            Console.WriteLine("integer addition");
            return a + b;
        }
        public double add(double a, double b)//overloaded function
        {
            Console.WriteLine("double addition");
            return a + b;
        }

        enum levels
        {
            low = 0,
            medium = 5,
            high = 10
        }
        public void display()
        {
            Console.WriteLine(employee_id);
            Console.WriteLine(employee_name);
            Console.WriteLine(employee_dep);

        }
        public static void Main(string[] args)
        {
            A ob1 = new A(7, "varun", "development");
            Console.WriteLine(ob1.add(4, 5));
            Console.WriteLine(ob1.add(5.4, 3));//overloading

            ob1.display();
            A ob2 = new A(ob1);//copy constructor
            ob2.display();
            //int f = levels.high; //error problm

            B obj = new B();
            Console.WriteLine(obj.divide(15, 0));//exception handling

            rectangle rect = new rectangle();

            rectDelegate rectdele = new rectDelegate(rect.area);

            // also can be written as
            // rectDelegate rectdele = rect.area;

            // call 2nd method perimeter
            // Multicasting
            rectdele += rect.perimeter;
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            // call the methods with
            // different values
            rectdele.Invoke(16.3, 10.3);





        }
    }
    class B
    {
        public double divide(int a, int b)
        {
            try//exception handling
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return 0;
            }

        }
        //[modifier] delegate [return_type] [delegate_name] ([parameter_list]); syntax for delegates
        // public delegate void addnum(int a, int b);

        //addnum del_obj1 = new addnum(obj.sum);

    }
    class rectangle
    {

        // declaring delegate
        public delegate void rectDelegate(double height,
                                          double width);

        // "area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }


    }
}