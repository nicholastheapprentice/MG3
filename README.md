# MG3
## Devlog
1. The default values are 0, 0, False and Null as for floats, ints, bools and strings.

2. I first didn't realize that it is a built-in method in Unity and wrote a wrong method name, so the scene is not updating. I searched online, checked the Unity documentation and found that this method described in the comment should be named Update. My code used this method to detect the time remaining and update the in-game texts.

3. The TimerText class uses the timer by calling it out in the Update method to detect whether the time has ran out and update in-game texts.

## Open-Source assets
- [Cat fighter spritesheet](https://opengameart.org/content/cat-fighter-sprite-sheet)
- [Food sprites](https://rcpstd.itch.io/pixel-food-pack)

