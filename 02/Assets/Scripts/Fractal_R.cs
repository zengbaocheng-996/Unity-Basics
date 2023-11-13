using UnityEngine;

public class Fractal_R : MonoBehaviour
{
    [SerializeField, Range(1, 8)]
    int depth = 6;

    void Start()
    {
        name = "Fractal " + depth;
        if (depth <= 1)
        {
            return;
        }

        Fractal_R childA = CreateChild(Vector3.up, Quaternion.identity);
        Fractal_R childB = CreateChild(Vector3.right, Quaternion.Euler(0f, 0f, -90f));
        Fractal_R childC = CreateChild(Vector3.left, Quaternion.Euler(0f, 0f, 90f));
        Fractal_R childD = CreateChild(Vector3.forward, Quaternion.Euler(90f, 0f, 0));
        Fractal_R childE = CreateChild(Vector3.back, Quaternion.Euler(-90f, 0f, 0));

        childA.transform.SetParent(transform, false);
        childB.transform.SetParent(transform, false);
        childC.transform.SetParent(transform, false);
        childD.transform.SetParent(transform, false);
        childE.transform.SetParent(transform, false);
    }
    Fractal_R CreateChild(Vector3 direction, Quaternion rotation)
    {
        Fractal_R child = Instantiate(this);
        child.depth = depth - 1;
        child.transform.localPosition = 0.75f * direction;
        child.transform.localRotation = rotation;
        child.transform.localScale = 0.5f * Vector3.one;
        return child;
    }
    void Update()
    {
        transform.Rotate(0f, 22.5f * Time.deltaTime, 0f);
    }
}