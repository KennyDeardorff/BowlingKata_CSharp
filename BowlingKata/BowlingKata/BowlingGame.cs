using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class BowlingGame
    {
        private List<Frame> Frames { get; } = new List<Frame>();

        public void Rolls(params int[] rolls)
        {
            var rollIndex = 0;

            for (int frameIndex = 1; frameIndex <= 1; frameIndex++)
            {
                var frame = new Frame();
                frame.Rolls.Add(rolls[rollIndex++]);
                frame.Rolls.Add(rolls[rollIndex++]);

                Frames.Add(frame);
            }
        }

        public override string ToString()
        {
            var output = new List<string>();
            var total = 0;
            var frameIndex = 0;

            foreach (var frame in Frames)
            {
                total += frame.Rolls.Sum();
                output.Add($"{frameIndex + 1}) {frame} => {total}");
            }

            return string.Join(Environment.NewLine, output);
        }
    }

    public class Frame
    {
        public List<int> Rolls { get; } = new List<int>();

        public override string ToString()
        {
            return $"{string.Join(", ", Rolls)} [{Rolls.Sum()}]";
        }
    }
}