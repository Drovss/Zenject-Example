namespace Zenject_Lesson.Scripts
{
    public class Bullet : IBullet
    {
        private readonly int _damage;

        public Bullet(int damage)
        {
            _damage = damage;
        }

        public int CalculateDamage()
        {
            return _damage;
        }
    }
}