# Ozone.Markdown
This library is a .Net wrapper for the [Txtmark](https://github.com/rjeschke/txtmark) markdown processor. It aims to be simple and quick to use.

###Projects Aims
Currently the project is a library that you use in your .Net applications. In the future I hope to add a **console application** version so that anyone can use the library to convert Markdown to Html.

###Background
I noticed that there were few options for converting Markdown into Html in the .Net framework, as well as in general. I found a library that made this task simple to do, however it was written in java. That is where my .Net wrapper came into play.

###How to use
Make reference to **Ozone.Markdown** in your project.

To convert Markdown to Html, use the function:

``
Ozone.Markdown.Parser.ParseMarkdown(markdown)
``

Where *markdown* is a string of Markdown text. The function returns a string, which is the converted Html.

And you're done! As simple as it gets.

###License
  Copyright 2015 Ryan O'Day

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
