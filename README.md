# Week 7 — Practice 1: Using Adobe Mixamo Model

Unity **6000.5.10f1**, Universal Render Pipeline.

Open this folder in Unity Hub, open `Assets/Scenes/SampleScene.unity`, then press Play.
The `character` model automatically plays the looping **Swing Dancing** animation.
Press **Space** with the Game view focused, or use the on-screen button, to switch
between Idle and Swing Dancing. Stop Play Mode before changing scene assets.

## Animation setup

- `Assets/Models/character.fbx`: Humanoid; Create From This Model;
  valid `characterAvatar` with Humanoid bone mapping.
- `Assets/Animations/Swing Dancing.fbx`: Humanoid; Copy From Other Avatar
  references `characterAvatar`. Clip `mixamo.com`: approximately 20.9 seconds,
  30 FPS, Loop Time and Loop Pose enabled. Root transform rotation/position
  are baked into pose; the scene Animator disables Apply Root Motion.
- `Assets/Animations/CharacterAnimatorController.controller`: default state
  `Swing Dancing`, Bool `IsDancing` defaults to true.
  `Swing Dancing -> Idle` when false; `Idle -> Swing Dancing` when true.
  Both transitions take 0.2 seconds without Exit Time.
- `Assets/Animations/Idle.anim`: a two-second looping hold of the dance clip's
  first pose, generated from its animation curves. This is a simple stationary
  practice Idle, not a separately downloaded Mixamo Idle animation.
- `Assets/Scripts/DanceToggle.cs`: keyboard and on-screen transition controls;
  supports the project's Input System configuration.

## Sharing the project

Keep `Assets/` (including both original FBX files and all `.meta` files),
`Packages/manifest.json`, `Packages/packages-lock.json`, and `ProjectSettings/`.
The local `.gitignore` excludes generated Library/Temp/Logs/UserSettings and IDE files.
The MCP package is pinned to its resolved Git revision for repeatable restoration.
Restoring packages on another machine requires network access and Git.

This folder has its own independent Git repository on branch `main`.
Remote: `git@github.com:VanSonNek/Week7_Practice1_Animation.git`.
Only this Unity project belongs in this repository; sibling projects are excluded.
