using UnityEngine;

public class TimerCounter : ICounter
{
    private float _time = 0;
    
    public void Count()
    {
        Debug.Log(_time);
        _time += 1;
    }
}