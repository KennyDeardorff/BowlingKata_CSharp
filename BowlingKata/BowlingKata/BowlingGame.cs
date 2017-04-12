using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class BowlingGame
    {
        private List<int> _rolls;

        public void Rolls(params int[] rolls)
        {
            _rolls = rolls.ToList();
        }

        public override string ToString()
        {
            var rollIndex = 0;
            var output = new List<string>();

            for (int frameIndex = 1; frameIndex <= 1; frameIndex++)
            {
                var total = _rolls[0] + _rolls[1];

                output.Add($"{frameIndex}) {_rolls[0]}, {_rolls[1]} [{total}] => {total}");
            }

            return string.Join(Environment.NewLine, output);
        }
    }
}