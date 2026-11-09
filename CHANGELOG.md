# Changelog

## 0.1.2 — Party HUD-style menu hiding

- Hide BellLock's panel in the same full-screen screens as Party HUD: loading, shop, inventory, character selection, global mission menu, and between-wave upgrade/ring selection.
- Hide the panel even when using manual positioning or an Emote fallback; restore it on return to gameplay.
- Keep F8 control and server-side guest bell permissions active while the panel is hidden.

## 0.1.1 — BellLock package

- Standardized GitHub and Thunderstore documentation for the BellLock release.
- Switched the Thunderstore package name from `BellControl` to `BellLock` so players can find **BellLock**.
- Updated the Stonewards Calling Bell + padlock package icon.
- Kept guest bell permission enforcement, F8 controls and the compact Emote-relative HUD unchanged.
- This package name introduces a separate Thunderstore listing; remove the former BellControl package before installing BellLock.

## 0.1.0 — Initial BellControl release

- Host-only control of guest bell ringing, with guests blocked by default each hosted session.
- Server-side guest command enforcement; the host can always ring normally.
- F8 hotkey and clickable Allow/Block action.
- Compact single-row panel with native Stonewards-inspired colors, borders and font.
- Automatic Emote-relative HUD positioning with no visible startup jump.
- Configurable scale, placement, follow behavior and fallback offsets.

Earlier internal versions were development iterations before the first public release. See [development history](docs/DEVELOPMENT_HISTORY.md).
