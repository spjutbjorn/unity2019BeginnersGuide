// Math on vectors is calculated on CPU, square magnitudes on GPU
if((pointa - pointB).sqrMagnitude < dist * dist) {
    Debug.log("Getting close");
}

Profiler.BeginSample(“sampleid”);
Profiler.EndSample();