﻿using System;
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

            for (var frameIndex = 1; frameIndex <= 3; frameIndex++)
            {
                var frame = new Frame();
                frame.Rolls.Add(rolls[rollIndex++]);
                frame.Rolls.Add(rolls[rollIndex++]);

                if (frame.Score == 10)
                    frame.AdditionalRolls.Add(rolls[rollIndex]);

                Frames.Add(frame);
            }
        }

        public override string ToString()
        {
            var output = new List<string>();
            var total = 0;
            var frameIndex = 1;

            foreach (var frame in Frames)
            {
                total += frame.Score;
                output.Add($"{frameIndex++}) {frame} => {total}");
            }

            return string.Join(Environment.NewLine, output);
        }
    }

    public class Frame
    {
        public List<int> Rolls { get; } = new List<int>();
        public List<int> AdditionalRolls { get; } = new List<int>();

        public int Score => Rolls.Sum() + AdditionalRolls.Sum();

        public override string ToString()
        {
            return $"{string.Join(", ", Rolls)} [{Score}]";
        }
    }
}