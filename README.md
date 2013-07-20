MapMap
======

A Windows tool to capture large pictures from online maps in a browser.

![MapMap Logo](icon/MapMap_256.png)

Usage
-----

### Preperations
1. Open an online map in the browser of your choice, 
   e.g. [OpenStreetMap](http://www.openstreetmap.org)
   If you use multiple monitors, move the browser to your main screen (the one with the task bar)
2. Check if there is a full screen mode
3. Check if the map is controllable by key strokes of the arrow keys
4. Start MapMap, if you have a second monitor move MapMap to that screen
5. Adjust the margin of the _capture region_ (default is 100 px on every border)
6. For mouse control:
	* Adjust the margin of the _drag region_. The drag region is a rectangle in the middle of the map, where the cursor hits no other control despite the map itself. 
	Usually the drag region can be equal to the capture region.
	* You need to experiment with the _step size_ for stitching precision.
	A step size of 1 is usually quite precise, but also very slow. Much faster
    is a step size of 20 but stitching is likely to be not precise.
7. For keyboard control:
	* Adjust the _step size_ of your arrow commands 
      (how much pixel is the map moved when hitting an arrow key?)
      The viewer for the OpenStreetMap currently uses a step size of 80 px in 
      both directions.
8. Adjust the timing according to your PCs performance and your network bandwidth.
   The default timings are senseful for a fast internet connection and a fast PC.
   If you determine regions of unloaded map material in your stitched results,
   raise the _tile delay time_. If the stitching is not precise enough you can
   try to raise the _step delay time_.
9. Set the _number of tiles_ in horizontal and vertical direction.
   Be careful with these settings and check the total size of the result picture.
   If you try to build a result picture to large, you will run out of memory.

### Capturing
1. Hit the _Start_ button. MapMap waits now during the _prestart delay time_.
2. If you use one monitor, use the _prestart delay time_ to switch to your browser
   and activate the full screen mode of the map, if available.
3. MapMap sends now a mouse click in the center of the drag region to activate
   the map view. Than it waits during the _start delay time_ for any full screen
   messages to disappear. After these two delays it starts capturing.
3. Watch MapMap doing its work.
   To cancel the process, press and hold the ALT modifier key.
4. After completing the stitched result picture, save the picture by hitting
   the _Save_ button.
