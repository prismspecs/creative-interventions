## Videogrep Lab

Videogrep is a project by artist [Sam Lavigne](http://lav.io/). It allows you to make 'supercuts' of videos (that have subtitle files) by search terms. For example, if you wanted to create a supercut of a CNN video that combines all of the times they say the word "government" you could do that.

Here are some examples of videos made by Sam

+ https://www.youtube.com/watch?v=D7pymdCU5NQ
+ https://vimeo.com/124950367
+ https://www.youtube.com/watch?v=PQMzOUeprlk
+ And a [Twitter bot "CSPAN5"](https://twitter.com/cspanfive) that makes these automatically

Sam is also an educator, and has graciously open sourced his classroom materials. Much of what I write here has been adapted from [his New School class syllabus](https://github.com/antiboredom/automating-video-lang/blob/master/videogrep.md)

### Installing videogrep

This process will seem fairly complex to those without a background in computer science, but I promise it's not that bad. You don't need to know what any of this stuff means.

1. First you will need to install homebrew, which is software that allows you to install stuff via terminal

```
/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
```

2. Now, using homebrew, you need to install python3, a programming language

```
brew install python3
```

3. Now you can install videogrep itself, using the python3 package downloader (pip3)
```
pip3 install videogrep
```

4. This is an idiosyncratic fix. The latest imageio package breaks videogrep, so we are going to tell it to use an earlier version
```
sudo pip3 install imageio==2.4.1
```

5. Another idiosyncratic fix (normally videogrep would do this for us), we need to install something called 'requests'
```
sudo pip3 install requests
```

6. And finally, this isn't officially part of videogrep itself, but youtube-dl is a tool that allows us to download youtube videos with subtitle files from the Terminal. We will need it
```
brew install youtube-dl
```

7. Install ffmpeg, some video software
```
brew install ffmpeg
```

### Example Useage

1. You'll want to change directory ("cd") into the Documents folder on your computer, so we know where the files end up
```
cd Documents
```

2. Search through YouTube to find a video that has a subtitle file, *ideally* one that has a word-specific subtitle file. You'll know it when you see it because words will appear as they are said rather than a sentence at a time. You then use that URL within this line of code:
```
youtube-dl https://www.youtube.com/watch?v=CWck2xoZkJM -f 22 --write-auto-sub
```

3. For clarity and brevity, rename the downloaded files to video.mp4 and video.vtt

4. Run an analysis on the subtitle file to find out what words were said and how frequently
```
videogrep --input video.mp4 --use-vtt --ngrams 1
```
5. Extract all the sentences that have the word "president" in them and save to a file called president.mp4
```
videogrep --input video.mp4 --use-vtt --search "president" --output president.mp4
```

6. Extract all the individual words "president"
```
videogrep --input video.mp4 --use-vtt --search "president" --search-type "word" --output president.mp4
```

7. Extract multiple words. Notice that there is no space between words
```
videogrep --input video.mp4 --use-vtt --search "look|not" --search-type "word" --output looknot.mp4
```

### Further Experimentation

Sam has an in-depth guide to using this in more advanced ways which [you can find here](https://github.com/antiboredom/automating-video-lang/blob/master/videogrep.md)

[The official videogrep documentation is here](https://github.com/antiboredom/videogrep)

[The documentation for youtube-dl is here](https://github.com/rg3/youtube-dl/blob/master/README.md) where you can find info about what the -f 22 command does, etc.

Here are some common commands for your reference:

+ Download and videogrep a playlist of videos. Notice the asterisk, which means use ANY and ALL mp4s in the current working folder
```
youtube-dl https://www.youtube.com/playlist?list=PLRJNAhZxtqH_3Nl-7n1vhgTUHyFSuQ0nI -f 22 --write-auto-sub

videogrep --input *.mp4 --use-vtt --search "question" --search-type "word" --output questions.mp4
```

+ Add a buffer to the beginning and end of words or phrases. The -p command works in milliseconds, so here we add half a second
```
videogrep --input video.mp4 --use-vtt --search "look|not" --search-type "word" --output looknot.mp4 -p 500
```

+ Searching for the word "men" will also return "women" by default. If you want to truly isolate words, you can use the ^ symbol and $ symbols. ^ means that the word must start with what comes next, while $ means the word must end with what came before. Therefore for single words, like "men" you can use ^men$ so that it doesn't pick up "women" or "mental"
```
videogrep --input video.mp4 --use-vtt --search "^men$" --search-type "word" --output looknot.mp4
```

+ If the video is downloading as an mkv file or something other than mp4, you can tell youtube-dl to grab the file as mp4
```
youtube-dl https://www.youtube.com/watch?v=CWck2xoZkJM -f 22 --write-auto-sub --recode-video
```

### Verified "Advanced Subtitles" links
