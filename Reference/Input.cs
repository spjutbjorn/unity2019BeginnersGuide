if (Input.GetKeyDown(KeyCode.Space)) { Debug.Log("Space key was Pressed"); }
if (Input.GetKeyUp(KeyCode.W)) { Debug.Log("W key was Released"); }
if (Input.GetKey(KeyCode.UpArrow)) { Debug.Log("Up Arrow key is being held down"); }

/* Button Input located under Edit >> Project Settings >> Input */
if (Input.GetButtonDown("ButtonName")) { Debug.Log("Button was pressed"); }
if (Input.GetButtonUp("ButtonName")) { Debug.Log("Button was released"); }
if (Input.GetButton("ButtonName")) { Debug.Log("Button is being held down"); }
