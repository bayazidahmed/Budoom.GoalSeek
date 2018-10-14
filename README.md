# Budoom.GoalSeek
.Net Goal Seek Library

Sample usage of using the static method TrySeek:
```
void Main()
{
    var goalSeekResult = Budoom.GoalSeek.TrySeek(Calculate);
}

decimal Calculate(decimal x)
{
    return 3 * x - 9;
}
```

Sample usage of implementing the interface IGoalSeek and invoking the method TrySeek:
```
void Main()
{
    var sc = new SomeCalculation();

    var goalSeek = new Budoom.GoalSeek(sc);
    var goalSeekResult = goalSeek.TrySeek();
}

public class SomeCalculation : Budoom.IGoalSeek
{
    public decimal Calculate(decimal x)
    {
        return 3 * x - 9;
    }
}
```
