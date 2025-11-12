namespace Observer_pattern
{
    internal class AverageSubscriber : ISubscriber
    {
        private List<double> history = new List<double>();

        public void Update(double rating)
        {
            history.Add(rating);
            double avarage = 0.0;

            foreach(double r in history)
            {
                avarage += r;
            }
            avarage /= history.Count;
            Console.WriteLine($"[Avarage rating] = {avarage:F2}");
        }
    }
}
