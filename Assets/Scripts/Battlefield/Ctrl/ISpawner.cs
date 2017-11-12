using System.Collections.Generic ;
public interface ISpawner {

	void SetInterval( float sec ) ;
	void Start();
	void Stop();
	void SetRoles( IList<IRole> roles ) ;
}
