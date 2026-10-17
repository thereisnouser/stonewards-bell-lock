# Stonewards BellLock

**Decide when your teammates can ring the wave bell.** BellLock gives the host an easy way to block or allow guest bell requests without restricting the host.

## ✨ Features

- **Guests blocked by default** whenever a hosted session starts.
- **Host-only control** — press **F8** or use the compact **ALLOW / BLOCK** button.
- **Server-side protection** — blocked guest ring requests are rejected even if guests do not have the mod.
- **Compact Stonewards-style HUD** — shows whether guest bell access is **ALLOWED** or **BLOCKED**.
- **Emote-aware positioning** — automatically appears near the game's Emote shortcut, with adjustable placement and scale.

## 🎮 How to use

1. Install **BellLock** on the host's game and launch modded.
2. Host a session. Guests start with bell access **BLOCKED**.
3. Press **F8** or click **ALLOW** when the cursor is unlocked to permit guest ringing.
4. Press **F8** or click **BLOCK** to lock the bell again.

**Only the host needs to install BellLock.** The host can ring normally while guests are blocked. Each new hosted session resets guest access to **BLOCKED**.

The panel may wait for the Emote UI before appearing, but the F8 shortcut works even while it is hidden.

## ⚙️ Configuration

The panel follows the Emote shortcut in the lower-left corner by default. You can customize its position and size in the active profile's BepInEx config:

`BepInEx/config/dev.stonewards.bellcontrol.cfg`

| Setting | Default | Description |
| --- | --- | --- |
| `Appearance.FollowEmote` | `true` | Follow the Emote shortcut when anchored at the bottom left |
| `Appearance.EmoteGap` | `12` | Space above the Emote shortcut |
| `Appearance.EmoteHorizontalAdjust` | `0` | Horizontal Emote alignment |
| `Appearance.Anchor` | `BottomLeft` | Manual screen corner |
| `Appearance.HorizontalOffset` | `26` | Manual horizontal inset |
| `Appearance.VerticalOffset` | `80` | Manual vertical inset |
| `Appearance.Scale` | `1.0` | Panel size multiplier |

Set `FollowEmote = false` for fixed manual positioning. **F8 is not rebindable in BellLock** in this version; if it conflicts with PartyHUD's build inspector, rebind F8 in PartyHUD.

## 📦 Installation

Install **BellLock** using **r2modman** or another compatible Thunderstore mod manager, then launch Stonewards through **Start modded**. BepInExPack is installed as a dependency.

**Important:** If you previously installed **BellControl**, uninstall or disable it before installing BellLock. The two packages share the same internal plugin ID and should not be active together.

## 🔧 Compatibility

- **Game:** Stonewards **0.2.3**.
- **Mod loader:** BepInEx 5.
- **Multiplayer:** Host-side mod; guests do not need to install it.

## ⚠️ Known limitations

Blocked guests may still see the vanilla bell interaction prompt, even though the server rejects the command. BellLock does not alter the normal wave countdown or other wave-start mechanisms. Future game updates may require compatibility changes.

## 🔗 Links

[GitHub](https://github.com/thereisnouser/stonewards-bell-lock) · [Report an issue](https://github.com/thereisnouser/stonewards-bell-lock/issues) · [Changelog](https://github.com/thereisnouser/stonewards-bell-lock/blob/main/CHANGELOG.md)

---

*Made by thereisnouser*
