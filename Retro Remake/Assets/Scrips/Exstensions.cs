using UnityEngine;

public static class Exstensions
{
    private static LayerMask layermask = LayerMask.GetMask("Default");
    public static bool Raycast(this Rigidbody2D rigidbody, Vector2 direction)
    {
        if (rigidbody.isKinematic)
        {
            return false;
        }



        float radius = 0.25f;
        float distance = 0.375f;

        Physics2D.CircleCast(rigidbody.position, radius, direction, distance, );
    }

}