namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {

            if (enemy.flying ==true) { return true; }
            if (enemy.incoporial == true) { return true; }
            if(enemy.swimmer ==true) { return false; }
            if (enemy.subterranian == true) { return true; }
            else return false;
        }
        internal bool CanPassWater(Enemy enemy)
        {

            if (enemy.flying == true) { return true; }
            if (enemy.incoporial == true) { return true; }
            if (enemy.swimmer == true) { return true; }
            if (enemy.subterranian == true) { return true; }
            else return false;
        }
    }
}