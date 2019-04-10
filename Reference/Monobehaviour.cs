private void Awake() { /* Called when the script is being loaded */ }
private void OnEnable() { /* Called every time the object is enabled */ }
private void Start() { /* Called on the frame when the script is enabled */ }
private void Update() { /* Called once per frame */ }
private void OnFixedUpdate(){ /* Called on a fixed time, good for smooth handling of pysics objects or camera*/}
private void LateUpdate() { /* Called every frame after Update */ }
private void OnBecameVisible() { /* Called when the renderer is visible by any Camera */ }
private void OnBecameInvisible() { /* Called when the renderer is no longer visible by any Camera */ }
private void OnDrawGizmos() { /* Allows you to draw Gizmos in the Scene View */ }
private void OnGUI() { /* Called multiple times per frame in response to GUI events */ }
private void OnApplicationPause() { /* Called at the end of a frame when a pause is detected */ }
private void OnDisable() { /* Called every time the object is disabled */ }
private void OnDestroy() { /* Only called on previously active GameObjects that have been destroyed */ }
