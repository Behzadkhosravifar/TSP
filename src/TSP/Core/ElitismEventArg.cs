using System;

namespace TSP.Core
{
    public class ElitismEventArg : EventArgs
    {
        public Chromosome ElitChromosome { get; set; }
        public int GenerationCount { get; set; }

        public ElitismEventArg(int generation, Chromosome elit)
        {
            GenerationCount = generation;
            ElitChromosome = elit;
        }
    }
}
