class Program
{
    public static void Main(string[] args)
    {
        Thread _game = new Thread(SnakeControl.ListenKey);
        _game.Start();
        do
        {
            Console.Clear();
            SnakeControl.Drawboard();
            SnakeControl.setUpBoard();
            SnakeControl.MoveSnakeHead();
            SnakeControl.EatFood();
            SnakeControl.SpawnBody();
            SnakeControl.PopUpfood();
            SnakeControl.ShowPoint();
            // cài đặt time di chuyển
            Task.Delay(SnakeControl.speed).Wait();

        } while (true);

    }

}
