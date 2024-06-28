namespace MySpace
{
    public class IncrementNumbers
    {
        public int Field1 { get; set; }
        public int Field2 { get; set; }

        public IncrementNumbers()
        {
            Field1 = 0;
            Field2 = 0;
        }

        public void Clear()
        {
            Field1 = 0;
            Field2 = 0;
        }
    }
}