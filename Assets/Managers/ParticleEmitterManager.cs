using UnityEngine;

public class ParticleEmitterManager : MonoBehaviour {
	
	public ParticleEmitter[] emitters;
	
	void Start ()
	{
		GameEventManager.GameStart += GameStart;	
		GameEventManager.GameOver += GameOver;
		GameOver ();
	}
	
	private void GameStart ()
	{
		for (int i=0; i<emitters.Length; i++) {
			emitters [i].ClearParticles ();
			emitters [i].emit = true;
		}
	}
	
	private void GameOver ()
	{
		for (int i=0; i<emitters.Length; i++) {
			emitters[i].emit = false;
		}
	}
}
