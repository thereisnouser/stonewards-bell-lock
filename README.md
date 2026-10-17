# Stonewards BellLock

**Control when teammates can ring the wave bell in Stonewards.** BellLock lets the host block guest bell requests until they decide to allow them, with a compact in-game control styled to match Stonewards.

## ✨ Features

- **Host-controlled access** — guests are blocked from ringing by default at the start of each hosted session.
- **Server-side enforcement** — guest bell commands are rejected while locked, even if guests have not installed the mod.
- **Instant toggle** — press **F8** or click **ALLOW / BLOCK** when the cursor is unlocked.
- **Host stays in control** — the host can still ring the bell while guests are blocked.
- **Compact in-game panel** — one-row BellLock control with a Stonewards-inspired frame and an **ALLOWED / BLOCKED** status.
- **Emote-aware placement** — the panel follows the game's **Emote** shortcut by default, with a fixed-position fallback and adjustable size and offsets.

## 🎮 How to use

1. Install BellLock on the **host's** game and launch Stonewards with the mod enabled.
2. Host a multiplayer session. Guest access starts as **BLOCKED**.
3. Press **F8** to allow guests to ring the bell. Press **F8** again to block them.
4. When the game cursor is unlocked, you can also click the panel's **ALLOW / BLOCK** button.

The panel appears only for the host. If the Emote shortcut has not appeared yet, the panel waits until it can be positioned or uses the fixed fallback for that session; **F8** continues to work even when the panel is hidden. Starting a new hosted session resets guest access to **BLOCKED**.

**Shortcut conflict:** PartyHUD uses **F8** for its build inspector by default. BellLock's F8 shortcut is fixed in the current version; rebind the PartyHUD shortcut if you use both mods.

## ⚙️ Configuration

BellLock uses the BepInEx configuration file in the active mod-manager profile:

`BepInEx/config/dev.stonewards.bellcontrol.cfg`

The legacy internal configuration name is intentional; the public Thunderstore package name is **BellLock**.

| Setting | Default | Description |
| --- | --- | --- |
| `Appearance.Anchor` | `BottomLeft` | Screen corner for manual positioning |
| `Appearance.FollowEmote` | `true` | Follow the native Emote shortcut when using `BottomLeft` |
| `Appearance.EmoteGap` | `12` | Gap above Emote, in physical pixels |
| `Appearance.EmoteHorizontalAdjust` | `0` | Horizontal adjustment relative to Emote |
| `Appearance.HorizontalOffset` | `26` | Manual horizontal inset |
| `Appearance.VerticalOffset` | `80` | Manual vertical inset |
| `Appearance.Scale` | `1.0` | Panel scale, from `0.65` to `1.60` |
| `Appearance.AvoidGoldCounter` | `true` | Avoid the game's gold HUD when positioned at the upper right |

For fixed manual placement instead of following Emote, change the following setting:

```ini
[Appearance]
FollowEmote = false
```

Existing custom positioning settings are preserved when the plugin migrates its older default layout.

## 📦 Installation

Install **BellLock** from the **Stonewards** community on Thunderstore using **r2modman** or a compatible mod manager, then launch the game through the selected modded profile. The manager installs the required BepInExPack dependency.

**Only the host needs BellLock.** Guests do not need it, and no client-side installation is required to enforce guest restrictions.

If you previously installed **BellControl**, uninstall or disable it before installing **BellLock**. These are separate Thunderstore package names but share the same internal BepInEx plugin identifier and DLL; running both can cause a duplicate-plugin conflict.

## 🔧 Compatibility

- **Game:** Stonewards **0.2.3**; later versions are not verified.
- **Mod loader:** BepInEx 5; Thunderstore dependency `BepInEx-BepInExPack-5.4.2305`.
- **Multiplayer:** Host-side controls with server-side guest-command checks; guests do not need the mod.
- **Other mods:** Independent of PartyHUD, but both use F8 by default.

## ⚠️ Known limitations

- Blocked guests may still see the game's normal bell interaction prompt; the server rejects their ring request.
- BellLock does not change the standard wave countdown or stop other mechanisms that might begin a wave.
- If the Emote HUD cannot be identified, the panel uses its configured fixed fallback for the session.
- Changes to Stonewards' networking or bell-command internals in future versions may require an update.

## 🛠️ Development

BellLock is a **BepInEx 5 + Harmony** mod. It patches the server-side handlers for the bell's ring and start-animation commands, while drawing the host's compact Unity Canvas panel locally. The panel reads the position of the game's Emote shortcut when available.

Building requires Stonewards installed locally, a .NET SDK capable of targeting `netstandard2.1`, PowerShell, and a BepInEx 5 profile. Close the game and run the following commands from the repository root:

```powershell
$gameDir = "F:\Steam\steamapps\common\Stonewards"
$profileDir = Join-Path $env:APPDATA "r2modmanPlus-local\Stonewards\profiles\stonewards-bell-lock"

powershell -ExecutionPolicy Bypass -File .\build-and-install.ps1 `
  -GameDir $gameDir `
  -ProfileDir $profileDir
```

To generate a Thunderstore upload ZIP without installing a new DLL:

```powershell
powershell -ExecutionPolicy Bypass -File .\package-thunderstore.ps1 `
  -GameDir $gameDir `
  -ProfileDir $profileDir
```

The packager checks the source/manifest versions and package contents and creates `dist/thereisnouser-BellLock-<version>.zip`. It **does not publish** the mod.

For a pre-release multiplayer checklist, see [Testing](docs/TESTING.md). Proprietary game DLLs and loader binaries are not included in the repository.

## 📄 License

Distributed under the [MIT License](LICENSE).

## 🔗 Links

[Changelog](CHANGELOG.md) · [Thunderstore description](thunderstore/README.md) · [Report an issue](https://github.com/thereisnouser/stonewards-bell-lock/issues)

---

*Made by thereisnouser*
