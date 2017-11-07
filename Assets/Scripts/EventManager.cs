public static class EventManager
{
	public delegate void GamePausedEventHandler (bool paused);
	public static event GamePausedEventHandler OnGamePaused;
	public static void InvokeOnGamePaused (bool paused)
	{
		if (OnGamePaused != null)
			OnGamePaused (paused);
	}

	public delegate void TargetDestroyedEventHandler ();
	public static event TargetDestroyedEventHandler OnTargetDestroyed;
	public static void InvokeTargetDestroyed ()
	{
		if (OnTargetDestroyed != null)
			OnTargetDestroyed ();
	}

	public delegate void WorldHitEventHandler ();
	public static event WorldHitEventHandler OnWorldHit;
	public static void InvokeWorldHit ()
	{
		if (OnWorldHit != null)
			OnWorldHit ();
	}

	public delegate void WorldDestroyedEventHandler ();
	public static event WorldDestroyedEventHandler OnWorldDestroyed;
	public static void InvokeWorldDestroyed ()
	{
		if (OnWorldDestroyed != null)
			OnWorldDestroyed ();
	}
}