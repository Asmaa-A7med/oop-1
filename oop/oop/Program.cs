namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object car1 from class Car
            Car car1=new Car();
            //access fields
            car1.model = "toyota";
            car1.color = "red";
            car1.price = 100000;

            // claaing methodes / behaviour
            Car car2=new Car();
            car2.Move();
            car2.stop();
        }

        public class Car
        {
            //class members here 
            //1-fields || properties of the class (color-model-price)
            //2-methodes (behaviour - move , stop , breake)
            //3-properties (smart fields)
            
            //1--field
            public string color { get; set; }
            public string model;
            public double price;
    
            //2-- methodes/behaviours-->as methodes
            public void Move()
            {
                Console.WriteLine("car moving");
            }
            public void stop() {
                Console.WriteLine("stop car");
            }
        }
    }
}







//create class and access objects from class 
//what is member classes 