namespace Observer_pattern
{
    internal class MaxSubscriber : ISubscriber
    {
        private double max = double.MinValue;

        public void Update(double rating)
        {
            if(rating > max)
            {
                max = rating;
            }
            Console.WriteLine($"[Maximum rating] = {max:F2}");
        }
    }
}
