using UnityEngine;
using Zenject;

public class PlayerLooker : MonoBehaviour
{

    // [Inject]
    [SerializeField] private PlayerMover _mover;
    private ICounter _counter;

    [Inject]
    private void Construct(PlayerMover mover, ComplexCounter.Factory counterFactory)
    {
        _counter = counterFactory.Create();
        _mover = mover;
    }

    private void Update()  
    {
        transform.rotation = Quaternion.LookRotation((_mover.transform.position - transform.position).normalized);
        _counter.Count();        
    }
}