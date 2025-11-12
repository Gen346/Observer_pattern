namespace Observer_pattern
{
    internal class DeltaSubscriber : ISubscriber
    {
        private double? previous = null;

        public void Update(double rating)
        {
            if (previous.HasValue)
            {
                double delta = rating - previous.Value;
                Console.WriteLine($"[Rating changes] = {delta:+0.00;-0.00;0.00}");
            }
            else
            {
                Console.WriteLine($"[Rating changes] = no previous data.");
            }
            previous = rating;
        }
    }
}
