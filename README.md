# EZTemplate
A demo app for EZAppMaker + EZForms.

In order to run this app you'll have to clone [EZAppMaker](https://github.com/derlidio/EZAppMaker) and [EZForms](https://github.com/derlidio/EZForms).

Your project's folder should look something like this:
```
C:\
|
+----> [My Projects]
       |
       +----> [EZAppMaker]
       |
       |      +----> [EZAppMaker]
       |      |
       |      +----> [EZAppMaker.Android]
       |      |
       |      +----> [EZAppMaker.iOS]
       |      |
       |      +----> EZAppMaker.sln
       |      |
       |      +----> README.md
       |
       +----> [EZForms]
       |
       +----> [EZTemplate]
              | 
              +----> [EZTemplate]
              |
              +----> [EZTemplate.Android]
              |
              +----> [EZTemplate.iOS]
```
**EZAppMaker** comprises a set of components which shows the same appearance and behavior on both,
Android and iOS. This project aims to show the basic concepts of the toolkit.

**EZForms** is a set of helper classes that integrates with EZAppMaker. It's aimed
to work with SQLite and will take care of all your CRUD needs. You won't have to write
a single SQL statement. You won't have to create models for your tables. You wont't
have to bind to Entity Framework. Just plug your SQLite database and write a markup
file (XML) to tell EZForms what you want to see, how you want to see it, and that's it.

*EZForms is still under development, but it's current version can handle single-record forms pretty well.*