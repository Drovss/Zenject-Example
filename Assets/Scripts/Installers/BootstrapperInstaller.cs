using Unity.Mathematics;
using UnityEngine;
using Zenject;
using Zenject_Lesson.Scripts;

public class BootstrapperInstaller : MonoInstaller
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Transform _spawnPoint;
    
    public override void InstallBindings()
    {
        
        BindBulletSupper();

        BindBullet();

        //BindPlayer();
    }

    private void BindPlayer()
    {
        var player = Container.InstantiatePrefabForComponent<Player>(
            _playerPrefab,
            _spawnPoint.position,
            quaternion.identity,
            null);

        Container
            .Bind<Player>()
            .FromInstance(player)
            .AsSingle();
    }

    private void BindBullet()
    {
        Container
            .Bind<IBullet>()
            .To<Bullet>()
            .FromNew()
            .AsSingle()
            .WithArguments(5);
    }

    private void BindBulletSupper()
    {
        Container
            .Bind<IBullet>()
            .WithId("BulletSuper")
            .To<BulletSupper>()
            .FromNew()
            .AsSingle()
            .WithArguments(10)
            .OnInstantiated<IBullet>(Oninstantiated)
            .NonLazy()
            .IfNotBound();
    }

    private void Oninstantiated(InjectContext arg1, object arg2)
    {
        
    }
    
    private void Oninstantiated(InjectContext context, IBullet bullet)
    {
        
    }

    private BulletSupper CreateBullet()
    {
        return new BulletSupper(10);
    }
}