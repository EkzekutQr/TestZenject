using UnityEngine;
using Zenject;

public class LookerInstaller : MonoInstaller
{
    [SerializeField] private PlayerLooker _looker;
    
    public override void InstallBindings()
    {
        BindLooker();

        // BindSimpleCounter();

        BindComplexCounter();
    }

    private void BindComplexCounter()
    {
        Container.Bind<TimeHolder>().FromNew().AsSingle();
        Container.BindFactory<ComplexCounter, ComplexCounter.Factory>();
    }

    private void BindSimpleCounter()
    {
        Container
            .Bind<ICounter>()
            .To<TimerCounter>()
            .FromNew()
            .AsSingle();
    }

    private void BindLooker() => 
        Container.BindInstance<PlayerLooker>(_looker);
}
