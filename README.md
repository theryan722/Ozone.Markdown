# Ozone.Markdown
This library is a .Net wrapper for the [Txtmark](https://github.com/rjeschke/txtmark) markdown processor. It aims to be simple and quick to use.

###Projects Aims
Currently the project is a library that you use in your .Net applications. In the future I hope to add a **console application** version so that anyone can use the library to convert Markdown to Html.

###Background
I noticed that there were few options for converting Markdown into Html in the .Net framework, as well as in general. I found a library that made this task simple to do, however it was written in java. That is where my .Net wrapper came into play.

###How to use
Make a reference to **Ozone.Markdown** in your project.

To convert Markdown to Html, use the function:

``
Ozone.Markdown.Parser.ParseMarkdown(markdown)
``

Where *markdown* is a string of Markdown text. The function returns a string, which is the converted Html.

Make sure in the Debug folder of your application, you have all of Ozone.Markdown's required libraries as well (there are 3 of them).

###Binaries and dependencies
You can download the library and its dependencies from the [releases](https://github.com/theryan722/Ozone.Markdown/releases/) page.

Ozone.Markdown has three dependencies:

* IKVM.OpenJDK.Core.dll
* IKVM.Runtime.dll
* txtmark.dll
 
These are required in order for Ozone to work.

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
