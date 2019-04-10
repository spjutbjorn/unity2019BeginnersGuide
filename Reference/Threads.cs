/* Create a Coroutine */
private IEnumerator CountSeconds(int count = 10)
{
  for (int i = 0; i <= count; i++) {
    Debug.Log(i + " second(s) have passed");
    yield return new WaitForSeconds(1.0f);
  }
}

/* Call a Coroutine */
StartCoroutine(CountSeconds());
StartCoroutine(CountSeconds(10));

/* Call a Coroutine that may need to be stopped */
StartCoroutine("CountSeconds");
StartCoroutine("CountSeconds", 10);

/* Stop a Coroutine */
StopCoroutine("CountSeconds");
StopAllCoroutines();

/* Store and call a Coroutine from a variable */
private IEnumerator countSecondsCoroutine;

countSecondsCoroutine = CountSeconds();
StartCoroutine(countSecondsCoroutine);

/* Stop a stored Coroutine */
StopCoroutine(countSecondsCoroutine);

/* Coroutine Return Types */
yield return null; // Waits until the next Update() call
yield return new WaitForFixedUpdate(); // Waits until the next FixedUpdate() call
yield return new WaitForEndOfFrame(); // Waits until everything this frame has executed
yield return new WaitForSeconds(float seconds); // Waits for game time in seconds
yield return new WaitUntil(() => MY_CONDITION); // Waits until a custom condition is met
yield return new WWW("MY/WEB/REQUEST"); // Waits for a web request
yield return StartCoroutine("MY_COROUTINE"); // Waits until another Coroutine is completed
