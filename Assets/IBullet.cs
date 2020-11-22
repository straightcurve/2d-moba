using UnityEngine;

public interface IBullet {

    Transform transform { get; }
    void StartMovement(Vector3 direction);
}
