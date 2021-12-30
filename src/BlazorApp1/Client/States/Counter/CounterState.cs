using Fluxor;

namespace BlazorApp1.Client.States.Counter;

[FeatureState]
public record CounterState(int Count)
{
    private CounterState() : this(0)
    {
    }
}

public record IncrementAction;
public record DecrementAction;

public static class Reducer
{
    [ReducerMethod]
    public static CounterState Handle(CounterState s, IncrementAction _) =>
        s with { Count = s.Count + 1 };

    [ReducerMethod]
    public static CounterState Handle(CounterState s, DecrementAction _) =>
        s with { Count = s.Count - 1 };
}
