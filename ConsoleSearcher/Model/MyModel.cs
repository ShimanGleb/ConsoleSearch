namespace ConsoleSearcher.Model
{
    public class MyModel
    {
        public int Id;

        public string FirstLine { get; set; }

        public string SecondLine { get; set; }

        public string ThirdLine { get; set; }

        public MyEnum Numbers { get; set; }
    }

    public enum MyEnum : int
    {
        Zero = 0,
        One = 1,
        Two = 2,
    }
}
