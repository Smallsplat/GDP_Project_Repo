using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class ShowHingeAnchor : MonoBehaviour {
	public float Radius = 0.1f;
	public float Length = 1.0f;
	public Color SphereColor = Color.green;
	public Color LineColor = Color.green;
	public bool Wireframe = false;
	
	void OnDrawGizmos() {
		var hinge = GetComponent<HingeJoint>();
		
		var dir = hinge.axis;
		var ws = transform.localToWorldMatrix * hinge.anchor;
		var pos = transform.position + new Vector3(ws.x, ws.y, ws.z);

		Gizmos.color = LineColor;
		Gizmos.DrawLine(pos, pos + dir * Length);
		
		Gizmos.color = SphereColor;
		if(Wireframe) {
			Gizmos.DrawWireSphere(pos, Radius);
		} else {
			Gizmos.DrawSphere(pos, Radius);
		}
	}
}
