using UnityEngine ;
public interface IRole : System.IDisposable {

	void Die();
	void Move( BaseNode node );
	void Pause();
	void UpdateState( ERoleState state );
	GameObject gameObject {get;}
	Transform transform {get;}
}
