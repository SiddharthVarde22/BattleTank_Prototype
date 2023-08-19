using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePath_Drawer : MonoBehaviour
{
    float height, distance;
    Vector3 firstPoint, middlePoint, lastPoint;

    [SerializeField]
    LineRenderer lineRenderer;

    float vertexCount = 12;

    List<Vector3> pointList = new List<Vector3>();

    //public void DrawProjectilePath(Vector3 firstPosition, float angle, float force)
    //{
    //    distance = ProjectileMotionCalculator.Instance.CalculateProjectileMotion(angle, force, out height);
    //    lineRenderer.transform.position = firstPosition;
    //    this.firstPoint = Vector3.zero;
    //    this.lastPoint = transform.right * distance;
    //    this.middlePoint.x = lastPoint.x / 2;
    //    this.middlePoint.y = height;
    //    this.middlePoint.z = lineRenderer.transform.position.z;

    //    pointList.Clear();

    //    for(float ratio = 0; ratio <= 1; ratio += (1/vertexCount))
    //    {
    //        Vector3 tengent1 = Vector3.Lerp(firstPoint, middlePoint, ratio);
    //        Vector3 tengent2 = Vector3.Lerp(middlePoint, lastPoint, ratio);
    //        Vector3 curve = Vector3.Lerp(tengent1, tengent2, ratio);
    //        pointList.Add(curve);
    //    }

    //    lineRenderer.positionCount = pointList.Count;
    //    lineRenderer.SetPositions(pointList.ToArray());
    //}

    Vector3 gravity = Physics.gravity;

    public void DrawPath(Transform startTransform, float angle, float force)
    {
        //Vector3 initialVelocity = (startTransform.right + new Vector3(0,0,angle)) * force;

        //lineRenderer.positionCount = 20;
        //float localTime = 0;

        //for(int i = 0; i < 20; i++)
        //{
        //    float x = (initialVelocity.x * localTime) + (gravity.x / 2 * localTime * localTime);
        //    float y = (initialVelocity.y * localTime) + (gravity.y / 2 * localTime * localTime);

        //    Vector3 point = new Vector3(x, y, 0);
        //    lineRenderer.SetPosition(i, point + lineRenderer.transform.position);
        //    localTime += (1 / 20);
        //}
    }
}
