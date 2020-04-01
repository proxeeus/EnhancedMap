# Ultima Online spawn mapping tool

Disclaimer: this tool is a fork of *EnhancedMap*, an open-source, UOAM-like tool that wasn't developed by me, I'm merely using their engine to represent map data.

Please see the original project @ https://github.com/andreakarasho/EnhancedMap if you're interested in learning more !

# Purpose

The purpose of this application is to have a visual tool that'll help server administrators implementing spawns across their UO worlds.

# Building the code

Clone the git repo, launch the .sln, do a "full rebuild" and then tweak the app.config settings to your liking. Then, hit "Run".

## Basic workflow

* select a type of Mobile you want to spawn
* assign a couple of infos about the spawner object
* type the MobileType you want to spawn in the corresponding text box
* type Add
* repeat if you want to have multiple Mobiles sharing the same spawn point
* once you're happy, double-click anywhere on the map where you want to add the spawn point
* rinse & repeat
* save your work to a .map file

## Using the spawn data

The tool reads & writes .map files, which are text files containing all the spawn data that'll be injected into a shard.

## Spawn workflow

* copy the \Core\SpawnData\SpawnerDev.cs_ (todo: change name) into your runuo\scripts\commands directory
* copy any .map files you need into your runuo\data\ directory
* restart your server if needed
* with an Administrator character, use [spawner dev add map_filename
* Congrats ! Your spawns have been added

## Tips

The tool & its data output have been made with modularity in mind. Since it is possible to either add or remove spawns (in both cases, the code will read data from .map files and add/remove accordingly), do not hesitate to separate your spawns into smaller "units of work", so that you have full control over the spawn data granularity.

