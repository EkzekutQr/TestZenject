using UnityEngine;
using Zenject;

public class ComplexCounter : ICounter
{
    private readonly TimeHolder _timeHolder;

    public ComplexCounter(TimeHolder timeHolder)
    {
        _timeHolder = timeHolder;
    }

    public void Count()
    {
        Debug.Log(_timeHolder.Time);
        _timeHolder.Time -= 1;
    }

    public class Factory : PlaceholderFactory<ComplexCounter>
    {
    }
}