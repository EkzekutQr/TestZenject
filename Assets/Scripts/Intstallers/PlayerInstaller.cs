using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private PlayerMover _playerMoverPrefab;
    [SerializeField] private PlayerSpawner _playerSpawner;
    
    public override void InstallBindings()
    {
        Container.Bind<PlayerMover>()
            .FromComponentInNewPrefab(_playerMoverPrefab)
            .AsSingle(); 
    }
}
