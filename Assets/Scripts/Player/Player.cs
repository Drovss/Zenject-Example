using UnityEngine;
using Zenject;

namespace Zenject_Lesson.Scripts
{
    public class Player : MonoBehaviour
    {
        [Inject(Id = "BulletSuper")]private IBullet _bullet;
        
        //[Inject] private IBullet Bullet { get; set; }

        private Gun _gun;

        [Inject]
        private void Construct(IBullet bullet)
        {
            _bullet = bullet;
        }

        private void Start()
        {
            _gun = new Gun(_bullet);
            
            Fire(_gun);
        }

        private void Fire(Gun gun)
        {
            gun.Shoot();
            // ...
        }
    }
}