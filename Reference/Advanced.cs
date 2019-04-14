Transform target;
Transform partToRotate;
float range = 15f;

/// <summary>
/// Callback to draw gizmos only if the object is selected.
/// </summary>
void OnDrawGizmosSelected()
{
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, range);
}

// Call function on a specific time
InvokeRepeating("name", 0f, 1f);

// Aim with math
Vector3 dir = target.position - transform.position;
Quaternion rotation = Quaternion.LookRotation(dir);
Vector3 rotation = lookRotation.eulerAngles;
// Slow aiming
Quaternion.Lerp(partToRotate.rotation,lookRotation.eulerAngles, 0.4f);
partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);





