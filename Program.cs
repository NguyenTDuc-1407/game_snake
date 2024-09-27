class Program
{
    public static void Main(string[] args)
    {
        SnakeControl snakeControl = new SnakeControl();
        Thread _game = new Thread(snakeControl.ListenKey);
        _game.Start();
        do
        {
            snakeControl.Drawboard();
            snakeControl.setUpBoard();
            snakeControl.MoveSnakeHead();
            snakeControl.EatFood();
            snakeControl.SpawnBody();
            snakeControl.PopUpfood();
            snakeControl.ShowPoint();
            snakeControl.savePoint();
            // cài đặt time di chuyển
            try
            {
                Task.Delay(snakeControl.speed).Wait();
            }
            catch (ArgumentException e)
            {
                
                Console.WriteLine(e);
                break;
            }
            Console.Clear();

        } while (!snakeControl.endGame);

    }

}
