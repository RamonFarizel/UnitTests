using System;
namespace ConsoleApp
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 65;

        public int CalculateDemericPoints(int speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException();

            if (speed <= SpeedLimit) return 0;

            const int kmPerDemericPoint = 5;

            var demericsPoint = (speed - SpeedLimit) / kmPerDemericPoint;

            return demericsPoint;
        }
    }
}
