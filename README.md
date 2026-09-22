# FF4FE.Tracker

A tracker for Free Enterprise, using [SNI](#sni) for connections. While the tracker does connect and read the metadata document from the ROM, it does not do any autotracking. When the tracker detects a ROM for FFIV: Free Enterprise, it will load the objectives for that seed. Loading a different FE rom will reset the KI Tracker state and all objectives.

## Features
* Key item tracker
* 4.x and 5.0 objectives automatically loaded when an FE rom is loaded on to a device connected to SNI
  * tested with both an FxPak Pro and [snes9x-emunwa](https://github.com/Skarsnik/snes9x-emunwa/releases). BizHawk and snes9x-rr should work with the lua bridge, but have not been tested.
* lists the loaded ROM name (tested as working with an FxPak Pro)

## Possible Roadmap Items
The following are some likely additions and improvements to the tracker
* Indicate Key Items required for objectives
* Indicate the Hard Required objectives, when that setting is used on the Galeswift fork
* Settings and Setting storage
  * host/port for SNI
  * background color
  * font color
  * KI indication on/off
  * Displaying flags
  * Displaying flag annotations
    * Possible: customizing flag annotations
* Flags displayed - flags are currently obtained but never displayed. This probably never shows the objective section, since the current seed objectives will be displayed on the tracker.
* Version displayed - version is currently obtained but never displayed
* Some flag annotations
* 5.0 objective completion cascade. e.g. if Objecive Group B has an objective that requires an objective in Group A to be completed, when the first objective in Group A is marked, that Group B objective automatically is marked as completed.

## SNI
* [Get SNI](https://github.com/alttpo/sni/releases)
* [SNI ReadMe/Install info](https://github.com/alttpo/sni#sni---super-nintendo-interface)
