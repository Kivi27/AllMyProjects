using System;
using MyGameSnake.UserElement.MainCharacter;

namespace MyGameSnake.UserElement.Foods
{
    public class Apple : GameObject
    {
        private const char SymbolFood = '@';
        private readonly Random rand;

        public event EventHandler<EventEatFood> Eat;
        
        public Apple(int x, int y) : base(x, y, SymbolFood)
        {
            rand = new Random();
        }

        public void ChangePlace(int widthArea, int heightArea)
        {
            X = rand.Next(1, widthArea - 1);
            Y = rand.Next(1, heightArea - 1);
        }

        public void OnEatenFood(Snake growthSnake)
        {
            EventEatFood eatFood = new EventEatFood {EatApple = this, GrowthSnake = growthSnake};
            Eat?.Invoke(this, eatFood);
        }
    }
}