# Budoom.GoalSeek
.Net Goal Seek Library

Sample usage using the static method TrySeek:
void Main()
{
	Budoom.GoalSeek.TrySeek(Calculate);
}

decimal Calculate(decimal x)
{
	return 3 * x - 9;
}

Sample usage by implementing the IGoalSeek interface and then invoking the method TrySeek:
void Main()
{
    var sc = new SomeCalculation();

    var goalSeek = new ALJ.FS.Infrastructure.Core.Utils.GoalSeek(sc);
    goalSeek.TrySeek();
}

public class SomeCalculation : ALJ.FS.Infrastructure.Core.Utils.IGoalSeek
{
    public decimal Calculate(decimal x)
    {
        return 3 * x - 9;
    }
}
