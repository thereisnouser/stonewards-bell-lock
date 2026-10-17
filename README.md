# Stonewards Bell Lock 🔔🔒

A lightweight **host-side** mod for Stonewards that lets the host decide when teammates can ring the wave bell.

**Version:** `0.1.1` · **Game:** Stonewards `0.2.3` · **Loader:** BepInEx 5

## Features

- Guests are **blocked from ringing by default** when a hosted session starts.
- The host can always ring the bell.
- Toggle guest access using **F8** or the small **ALLOW / BLOCK** button.
- Server-side command checks work even when guests do not have the mod installed.
- A compact Party HUD-style panel follows the game's **Emote** shortcut in the bottom-left corner.
- Position, Emote gap, scale and fallback offsets are configurable.

## Install

Install **Bell Lock** (Thunderstore ID: `Bell_Lock`) through Thunderstore/r2modman and start Stonewards using the **same profile**. Only the **host** needs to install it. If you installed the older `BellControl` listing, remove it before installing Bell Lock: both contain the same BepInEx plugin.

Configuration file: `BepInEx/config/dev.stonewards.bellcontrol.cfg`.

```ini
[Appearance]
Anchor = BottomLeft
FollowEmote = true
EmoteGap = 12
EmoteHorizontalAdjust = 0
HorizontalOffset = 26
VerticalOffset = 80
AvoidGoldCounter = true
Scale = 1
```

When following Emote, the panel waits until the game's shortcut is available, rather than visibly moving after startup. If it cannot be found, a fixed fallback is used for that session. Press **F8** at any time, including when the panel is hidden.

**Note:** Party HUD can also use F8 for its builds window; change that mod's hotkey if the two overlap.

## Repository and r2modman profile

The GitHub repository is `stonewards-bell-lock`, and the matching r2modman profile should also be named `stonewards-bell-lock`. If you renamed the repository after cloning, you can update the old clone's remote URL:

```powershell
git remote set-url origin https://github.com/thereisnouser/stonewards-bell-lock.git
```

The Thunderstore package is **`Bell_Lock`**, displayed as **Bell Lock** in the mod browser. This is a separate listing from the older `BellControl` package and does **not** automatically update it. To avoid duplicate plugins, uninstall `BellControl` before installing `Bell_Lock`. The BepInEx plugin GUID `dev.stonewards.bellcontrol`, DLL `StonewardsBellControl.dll` and config filename are unchanged.

## Building from source

Requires a local Stonewards install, .NET SDK, and BepInEx 5. Game and framework DLLs are never redistributed.

```powershell
powershell -ExecutionPolicy Bypass -File .\build-and-install.ps1 `
  -GameDir "F:\Steam\steamapps\common\Stonewards" `
  -ProfileDir "C:\Users\user\AppData\Roaming\r2modmanPlus-local\Stonewards\profiles\stonewards-bell-lock"
```

Build the **Thunderstore upload ZIP** instead (compiles without installing):

```powershell
powershell -ExecutionPolicy Bypass -File .\package-thunderstore.ps1 `
  -GameDir "F:\Steam\steamapps\common\Stonewards" `
  -ProfileDir "C:\Users\user\AppData\Roaming\r2modmanPlus-local\Stonewards\profiles\stonewards-bell-lock"
```

Result: `dist/thereisnouser-Bell_Lock-0.1.1.zip`. The script validates the version, PNG icon, DLL and ZIP contents before finishing; it **does not upload** the package.

See [Thunderstore description](thunderstore/README.md), [multiplayer tests](docs/TESTING.md), [changelog](CHANGELOG.md), or [report an issue](https://github.com/thereisnouser/stonewards-bell-lock/issues).

## Compatibility and limitations

Designed for **Stonewards 0.2.3**. Guests may still see a normal bell interaction prompt even when the server denies their ring request. The mod does not change the normal wave countdown or protect against unrelated wave-start mechanisms. New game versions may require code updates.

[MIT License](LICENSE). This repository does not contain game assets or game binaries.
