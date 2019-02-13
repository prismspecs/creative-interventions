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

7. ... try multiple words

### Further Experimentation

Sam has an in-depth guide to using this in more advanced ways which [you can find here](https://github.com/antiboredom/automating-video-lang/blob/master/videogrep.md)

------ OLD SHIT ------


1. The following commands needs to be entered into the Terminal, which is like what hackers in movies use to do fancy things

1. Install homebrew, which is a ...
```
/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
```

2. You have to install something called "pip" on your machine, which you can do by typing
```
sudo easy_install pip
```
It will likely prompt you for your password, enter it. For those of you on lab machines, I will do this.

3. sudo pip install setuptools --upgrade --ignore-installed

4. pip install videogrep



1. First you will need to install homebrew, which is software that allows you to install stuff via terminal
```
/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
```
It will likely prompt you for your password, enter it. For those of you on lab machines, I will do this.

2. Now, using homebrew, you need to install python3, a programming language
```
brew install python3
```

3.
```
pip3 install videogrep
```

4.
```
sudo pip3 install imageio==2.4.1
```

sudo pip3 install requests

### How to rip a video with subtitles from YouTube

1. Find a youtube video you like that has Closed Captioning and copy the URL, I'm using https://www.youtube.com/watch?v=oJuvNMLBcQk

2. Goto [http://www.lilsubs.com](http://www.lilsubs.com), paste the URL and hit enter

3. Download the video AND the subtitle file, move them into the same folder and make sure they have the same name, such as: video.mp4 and video.srt. You will likely need to rename them to accomplish this

4.

OR use the Terminal method

1. ```
brew install youtube-dl
```

2. ```
youtube-dl "https://www.youtube.com/watch?v=oJuvNMLBcQk" -f 18 --write-auto-sub
```

3.

### Example all the way through

1. youtube-dl https://www.youtube.com/watch?v=pzmvnD97g2k -f 22 --write-auto-sub

2. rename the files to 'video.mp4' and 'video.vtt' for brevity

### Verified working YouTube links
https://www.youtube.com/watch?v=pzmvnD97g2k
