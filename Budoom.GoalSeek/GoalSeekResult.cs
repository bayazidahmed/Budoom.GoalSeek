namespace Budoom
{
    public class GoalSeekResult
    {
        public decimal TargetValue { get; private set; }
        public decimal AccucracyLevel { get; private set; }
        public int Iterations { get; private set; }
        public bool IsGoalReached { get; private set; }
        public decimal ClosestValue { get; private set; }

        public GoalSeekResult(decimal targetValue, decimal accucracyLevel, int iterations, bool isGoalReached, decimal closestValue)
        {
            TargetValue = targetValue;
            AccucracyLevel = accucracyLevel;
            Iterations = iterations;
            IsGoalReached = isGoalReached;
            ClosestValue = closestValue;
        }

        public void Deconstruct(out bool isGoalReached, out decimal closestValue)
        {
            isGoalReached = IsGoalReached;
            closestValue = ClosestValue;
        }

        public void Deconstruct(out decimal targetValue, out decimal accucracyLevel, out int iterations, out bool isGoalReached, out decimal closestValue)
        {
            targetValue = TargetValue;
            accucracyLevel = AccucracyLevel;
            iterations = Iterations;
            isGoalReached = IsGoalReached;
            closestValue = ClosestValue;
        }
    }
}
