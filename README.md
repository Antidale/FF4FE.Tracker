# FF4FE.Tracker

A tracker for Free Enterprise, using [SNI](#sni) for connections. While the tracker does connect and read the metadata document from the ROM, it does not do any autotracking. When the tracker detects a ROM for FFIV: Free Enterprise, it will load the objectives for that seed. Loading a different FE rom will reset the KI Tracker state and all objectives.

## Setup
* Make sure you have [SNI](https://github.com/alttpo/sni/releases) installed.
* Use an SNI compatible device/emulator
  * FxPak/SD2SNES connected via USB and runnig usb2snes-compatible firmware
  * [snes9x-emunwa](https://github.com/Skarsnik/snes9x-emunwa/releases)
  * Lua Bridge compatible emulators e.g. Snes9x-rr, BizHawk
* Make sure your emulator can connect to SNI ([SNI ReadMe/Install info](https://github.com/alttpo/sni#sni---super-nintendo-interface))
* Load a seed
* Load the site, wait up to 5 seconds or so
* The objectives should load.

If you switch to a different seed, the tracker will reset the key items state and populate the new seed's objectives after a few seconds. (The process that's continually checking in on what ROM is loaded is on a five second timer)

## Features
* Key item tracker
* 4.x and 5.0 objectives automatically loaded when an FE rom is loaded on to a device connected to SNI
  * tested with both an FxPak Pro and [snes9x-emunwa](https://github.com/Skarsnik/snes9x-emunwa/releases). BizHawk and snes9x-rr should work with the lua bridge, but have not been tested.
* lists the loaded ROM name (tested as working with an FxPak Pro)
* settings menu to customize (values are kept in localStorage on your browser):
  * if the tracker should connect at all
  * polling interval
  * background color
  * text/border color
  * SNI host and port information
  * Show helpers for tracking
    * Boss at Baigan Spot
    * Knofree
* Allows marking the boss seen at the Baigan spot at the start of the seed
* Allows tracking of the state of Knofree, in a similar manner to KI state changes

## Possible Roadmap Items
The following are some likely additions and improvements to the tracker
* Indicate Key Items required for objectives
* Indicate the Hard Required objectives, when that setting is used on the Galeswift fork
* KI indication on/off
* Displaying flags
* Displaying flag annotations
  * Possible: customizing flag annotations
* Version displayed - version is currently obtained but never displayed
* 5.0 objective completion cascade. e.g. if Objecive Group B has an objective that requires an objective in Group A to be completed, when the first objective in Group A is marked, that Group B objective automatically is marked as completed.
* Additional Boss Preview locations
* Ability to track if D.Mist has been defeated, when D.Mist can be a KI check. (and/or handle Knofree:package or Knofree:dwarf)
* 4.x seeds: display a "do x of y for {game | crystal}" underneath the objectives


## SNI
* [Get SNI](https://github.com/alttpo/sni/releases)
* [SNI ReadMe/Install info](https://github.com/alttpo/sni#sni---super-nintendo-interface)
