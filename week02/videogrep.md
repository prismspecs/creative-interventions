## Videogrep Lab

Videogrep is a project by artist Sam Lavigne. It allows you to make 'supercuts' of videos (that have subtitle files) by search terms. For example, if you wanted to create a supercut of a CNN video that combines all of the times they say the word "government" you could do that.

Here are some examples of videos made by Sam

+
+
+

Sam is also an educator, and has graciously open sourced his classroom materials. Much of what I write here has been adapted from [his New School class syllabus](https://github.com/antiboredom/automating-video-lang/blob/master/videogrep.md)

This process will seem fairly complex to those without a background in computer science...

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
