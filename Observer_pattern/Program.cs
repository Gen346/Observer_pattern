using Observer_pattern;

class Program
{
    static void Main()
    {
        Newspaper newspaper = new Newspaper();

        AverageSubscriber avg = new AverageSubscriber();
        MaxSubscriber max = new MaxSubscriber();
        DeltaSubscriber delta = new DeltaSubscriber();

        newspaper.Subscribe(avg);
        newspaper.Subscribe(max);
        newspaper.Subscribe(delta);

        // Моделюємо публікації нових числових рейтингів
        newspaper.Publish(5.2);
        newspaper.Publish(6.8);
        newspaper.Publish(4.9);
        newspaper.Publish(7.5);

        // Відписуємо одного підписника
        newspaper.Unsubscribe(delta);

        newspaper.Publish(8.1);
    }
}