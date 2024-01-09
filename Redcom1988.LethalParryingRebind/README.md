# Lethal Parrying Rebind

## Overview

The Lethal Parrying mod enhances your gameplay in Lethal Company by allowing you to parry almost everything. Master the art of parrying and face your enemies with confidence!

## Features

- **Parry Almost Everything**: With this mod, you can parry a wide range of attacks and threats.
- **Configurable Settings**: Customize the mod according to your preferences using the provided configuration options.

## Manual Installation Guide

1. Ensure you have [BepInEx](https://thunderstore.io/c/lethal-company/p/BepInEx/BepInExPack/) installed.
2. Download the latest release of the Lethal Parrying mod from [Thunderstore](https://github.com/Redcom1988/LethalParryingRebind).
3. Extract the contents into your Lethal Company's `BepInEx/plugins` folder.

## Configuration

### Config File: `config.cfg`

- **Drop Probability**: Probability for how often you might drop your weapon when failing to parry or holding parry keybind. (Default: 15)
- **Parry Window**: Time window to parry an attack. (Default: 0.25 seconds)
- **Parry Cooldownw**: Cooldown time for parrying. (Default: 2 seconds)
- **Keybind**: Keybind to trigger a parry. (Default: `F`)
- **Display Parry Notifications**: Enables/Disables screen notifications for parry information. (Will be removed when sounds and effects are added) (Default: true)
- **Display Parry Cooldown (Notification)**: Shows a notification if your parry is on cooldown. (Display Parry Notifications does not affect this.) (Default: true)

## How to Parry

To perform a parry, press the `parry` keybind before getting hit. Master the timing to become an unstoppable force!


## Developer Notes
**IMPORTANT NOTICE**: This mod is client-side and works on any server. Please use it responsibly and refrain from abusing its capabilities. Enjoy the enhanced gameplay experience, and ensure fair play within the community!

### Plugin Details

- **Plugin Name**: Lethal Parrying Rebind
- **Plugin Version**: 1.0.32
- **Plugin GUID**: Redcom1988.LethalParryingRebind

## Patch Notes

`Ryokune`
### Version 1.0.0
- **Added**: Lethal Parrying. Initial Release.
- **Feature**: Parry almost everything with the press of the `F` key.
- **Configurations**: Customize the mod settings through the `config.cfg` file.
- **Note**: The keybind for parrying is currently fixed and cannot be changed, but this will be addressed in a future update.
- **Client-Side**: This mod is client-side and works on any server.
- **Reminder**: Please use this mod responsibly and avoid abusing its capabilities for fair play.
### Version 1.0.1
- **I forgot to add the mod binary woops. haha**
### Version 1.0.2
- **Fixed**: Fixed mod to work in multiplayer servers.
### Version 1.0.3
- **Fixed**: Fixed [Issue #2](https://github.com/VisualError/LethalParrying/issues/2)
- **Planning next patch**: Changing keybinds.
- **Future updates (No definite patch release)**: cool parry animation and sound.
### Version 1.0.31
- **QUICK PATCH**: CHANGE PARRY WINDOW BACK TO DEFAULT


`Redcom1988`
### Version 1.0.32
- **ADDED**: Configuration for parry keybind, window, and cooldown.
### Version 1.0.33
- **Fixed**: Wrong readme.md file