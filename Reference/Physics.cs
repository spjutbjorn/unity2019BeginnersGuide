/* Both objects have to have a Collider and one object has to have a Rigidbody for these Events to work */
private void OnCollisionEnter(Collision hit) { Debug.Log(gameObject.name + " just hit " + hit.gameObject.name); }
private void OnCollisionStay(Collision hit) { Debug.Log(gameObject.name + " is hitting " + hit.gameObject.name); }
private void OnCollisionExit(Collision hit) { Debug.Log(gameObject.name + " stopped hitting " + hit.gameObject.name); }

/* Trigger must be checked on one of the Colliders */
private void OnTriggerEnter(Collider hit) { Debug.Log(gameObject.name + " just hit " + hit.name); }
private void OnTriggerStay(Collider hit) { Debug.Log(gameObject.name + " is hitting " + hit.name); }
private void OnTriggerExit(Collider hit) { Debug.Log(gameObject.name + " stopped hitting " + hit.name); }
 
/* For 2D Colliders just add 2D to the Method name and the Parameter Type */
private void OnCollisionEnter2D(Collision2D hit) { }
private void OnCollisionStay2D(Collision2D hit) { }
private void OnCollisionExit2D(Collision2D hit) { }
private void OnTriggerEnter2D(Collider2D hit) { }
private void OnTriggerStay2D(Collider2D hit) { }
private void OnTriggerExit2D(Collider2D hit) { }
