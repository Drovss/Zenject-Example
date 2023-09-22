using UnityEngine;

namespace Zenject_Lesson.Scripts
{
    public class BulletSupper : IBullet
    {
        private readonly int _damage;

        public BulletSupper(int damage)
        {
            _damage = damage;
        }

        public int CalculateDamage()
        {
            var crete = Random.Range(2, 10);
            return _damage + crete; // дуже складні розрахунки =)
        }
    }
}