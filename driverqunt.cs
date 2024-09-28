using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumQRNG
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                // Define the range of the random numbers
                double a = 0.0;
                double b = 10.0;

                // Run the QRandom operation
                var result = QRandom.Run(sim, a, b, 2).Result;

                Console.WriteLine($"Random value: {result.Item1}");
            }
        }
    }
}
