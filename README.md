# RhythmPong Co-op

![RhythmPong Coop](https://github.com/user-attachments/assets/11b0ba30-00ae-4ee8-83a1-e2d2cec07c11)

It's only a Pong Game....right?
Well, how about we make its cooperative? But here's the deal, we slap a rhythm game on top of it to make is spicy!
Survive.

## About Game
RhythmPong coop is a cooperative game where 2 players play Pong and try to juggle the ball on the screen, while at the same time play a rhythm game where they have to play the note in time.
Each time passes, the ball increases it's speed. Decrease it's speed by hitting the note, the more it's in time the more the ball speed decreases. The players have 3 lives. They lose their life if the ball
get off from the screen. The players win if they survive until the end of the song.
### <a href="https://jeje8.itch.io/rhythmpong-coop">Play it here</a>

## Mechanics

### Note Points

![RhythmPong CoopNote](https://github.com/user-attachments/assets/d6dd252a-83ca-4f3c-887c-341ca67d8eff)

The players have to hit the note in time. The more in time it is, the more score the players got and the more the ball slows down. There's also an indicator showing how in time the note hit is;
Bad, Mid, Good, and Perfect.

### Score
When the game ends, either by winning or losing, the players will be shown total score from many aspects of the game including note hit time, lives remaining and win or losing.

![image](https://github.com/user-attachments/assets/c9747ee4-c56f-4661-8c44-e1ccb1352eb0)

Try to get the highest score on each song!

### Music BPM
Each song has it's own note speed, where the bpm is used to deterimine the spawn rate and the speed of notes.

![RhythmPong CoopBPM](https://github.com/user-attachments/assets/7606ea2e-9ff7-4431-b035-1b19c7fb4cd6)

Comparison between 2 songs with different BPM.

## Scripts

| Script | Description |
| --- | --- |
| `GameManager.cs` | Manages the game's flow, including the score, ball speed, start and end level, etc |
| `Keys.cs` | Determine the timing of note hit on keys; Perfect, good, mid, and bad. |
| `NoteSpawner.cs` | Handles the spawn rate and speed of notes based on the music's BPM. |
| `PongBoard.cs` | Handles the control movement of both PongBoards. |
| `etc` | |

## Assets

All of the art assets were created by me. The only assets that I used from other people is the music and audio, which can be downloaded from here:
- Free royalty music playlist: https://www.youtube.com/playlist?list=PLHEabrqpFr0PlkzCTrgZ6ChhrtKSAgqyj
- Free sfx: https://freesound.org



