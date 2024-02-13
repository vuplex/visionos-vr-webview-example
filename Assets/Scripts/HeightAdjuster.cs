using UnityEngine;

/// <summary>
/// Adjusts the height of the Canvas to match the height of the Main Camera when the scene launches.
/// </summary>
class HeightAdjuster : MonoBehaviour {

    void Update() {

        var height = Camera.main.transform.localPosition.y;
        if (height != 0) {
            var pos = transform.localPosition;
            transform.localPosition = new Vector3(pos.x, height, pos.z);
            enabled = false;
        }
    }
}