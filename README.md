## Mystery-Seed-Setter
A short plugin using BepInEx for setting MYSTERY? seeds in Bug Fables: The Everlasting Sapling for versions 1.0.5 and lower.

## Installing BepInEx

>_If you have aldelaro5's Speedrun Practice plugin, you have BepInEx installed and working so you can skip this part._

[Download the latest release of BepInEx](https://github.com/BepInEx/releases) and get the zip file marked "x64". Unzip this folder into your game directory. The easiest way to find this is by going to your library page for Bug Fables, clicking the cogwheel and navigating to Manage > Browse local files

## Installing the plugin

[Download the latest version of the plugin](https://github.com/Cyan627/Mystery-Seed-Setter/releases) and unzip the file directly under the plugins folder of Bepinex. Make sure that the files inside the zip file are all under the plugins folder. 

## Uninstalling

To remove the plugin, simply delete `BepInEx/plugins/Mystery-Seed-Setter.dll` from the game's directory. 

If you wish to uninstall BepInEx too, delete the following items:

* The BepInEx folder
* changelog.txt
* doorstop_config.ini
* winhttp.dll

## How to Use

First off, run Bug Fables and start a new MYSTERY? file. You can close out of the game as soon as the intro starts playing. Then head to the `BepInEx/config` folder and open the file called "seedConfig.cfg" with a text editor.

If you wish to play the game with seeds on, set the "UseSeed" setting to "true" (with no quotes). You can then insert any number in the range of 0 to 4,294,967,295 after the "=" sign for SeedNum.

## Credits

Although I'm the one publishing this, I'd like to give the hugest, biggest, largest, and most tremendously sized thanks to aldelaro5 for putting up with me throughout the lifespan of this entire project. I came into this project not even knowing any C# so this would have never been possible without his help.

## License

This plugin is under the MIT license which allows free use, modification, and distribution of this plugin as long as the license and the copyright notice is there. You can [read the full license here.](https://github.com/Cyan627/Mystery-Seed-Setter/blob/master/LICENSE)

## Final Notes

With the advent of 1.1 around the corner, I'm sorry that this came out so late. I have no clue how my plugin will react if ran on 1.1 so I would ***strongly*** advise against using it since this mod will be a base feature in the game at that point! I also cannot say that every seed here will provide the same results on 1.1, although it would be a funny coincidence if it did work out that way.

I also don't plan on working on this mod after the initial release unless it completely breaks for some reason (which would be unfortunate after all this hard work) since it will become an official feature in 1.1.

Thanks once again to aldelaro5 for carrying me through this project and thanks to Moonsprout Games for making an absolutely amazing game!
