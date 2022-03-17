1. Update, FixedUpdate, LateUpdate

Update will be executed every frame, but the time interval is not fixed

LateUpdate will be executed each time after the Update

FixedUpdate will be executed everytime with a fixed time interval.

2.StreamingAssets

The StramingAssets contain the assets that the developer don't want to be pacaged in the Unity Project when they building the Project.

3."Special Folders"

 - Resources

The Resources folder can contain the assets that can be easily use by using Reources API, like Resources.Load("blabla")

4.Script Execution Order

The order that the Unity defined what order the different "Functions", like Start(), Update(), etc, will be executed.

The order can be optimized in the project settings.