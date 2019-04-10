/* The time in seconds since the start of the game */
float timeSinceStartOfGame = Time.time;

/* The scale at which the time is passing */
float currentTimeScale = Time.timeScale;
/* Pause time */
Time.timeScale = 0;

/* The time in seconds it took to complete the last frame */
/* Use with Update() and LateUpdate() */
float timePassedSinceLastFrame = Time.deltaTime;

/* The interval in seconds at which physics and fixed frame rate updates are performed */
/* Use with FixedUpdate() */
float physicsInterval =  Time.fixedDeltaTime;
