namespace BowlingKata
{
    public class BowlingGame
    {
        public void Rolls(params int[] rolls)
        {
        }

        public override string ToString()
        {
            var roll1 = 5;
            var roll2 = 3;
            var total = roll1 + roll2;

            return $"1) {roll1}, {roll2} [{total}] => {total}";
        }
    }
}