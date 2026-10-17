# Bell Lock 0.1.1 — release smoke tests

Target game: Stonewards 0.2.3 (BepInEx 5). Use the **stonewards-bell-lock** r2modman profile.

- [ ] Release DLL loads without BepInEx errors, and logs version `0.1.1`.
- [ ] Panel is visible only to the host and displays one line near Emote.
- [ ] The panel first appears in the correct Emote-relative position, with no visible jump.
- [ ] At 1920×1080 and 2560×1440, the HUD stays readable and does not cover Emote, gold, Party HUD or Daily Quest Tracker.
- [ ] F8 switches permission state between BLOCKED and ALLOWED.
- [ ] When the cursor is free, the button also switches permission state.
- [ ] With the cursor locked, the panel does not intercept gameplay input.
- [ ] Guests cannot ring while BLOCKED, even without installing Bell Control.
- [ ] Host can ring normally while guests are blocked.
- [ ] Guests can ring after ALLOWED; blocking again prevents subsequent attempts.
- [ ] After the host leaves and starts a new session, guest permissions reset to BLOCKED.
- [ ] Normal wave progression, countdown and player saves behave as before.
- [ ] Confirm the Thunderstore listing is displayed as **Bell Lock** (`Bell_Lock`) and can be found by searching for Bell Lock.
- [ ] Verify the old BellControl package is not installed alongside Bell Lock, since both share the same plugin ID.
- [ ] Test the final Thunderstore ZIP in a **clean mod-manager profile** before publishing.
- [ ] Confirm ZIP contains `manifest.json`, `icon.png`, `README.md`, `CHANGELOG.md`, `LICENSE` and `plugins/StonewardsBellControl.dll`.

The release package includes only the plugin DLL, not any Unity, game, BepInEx or Harmony assemblies.
