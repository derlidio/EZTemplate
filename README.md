# EZTemplate
A demo app for EZAppMaker + EZForms.

In order to run this app you'll have to clone [EZAppMaker](https://github.com/derlidio/EZAppMaker) and [EZForms](https://github.com/derlidio/EZForms).

Your project's folder should look something like this:
```
C:\
|
+----> [My Projects]
       |
       +----> [Your_App]
       |      | 
       |      +----> [Your_App]
       |      |      |
       |      |      +----> [Platforms]
       |      |      |
       |      |      +----> [Properties]
       |      |      |
       |      |      +----> [Resources]
       |      |
       |      +----> [Your_App.sln]
       |
       +----> [EZAppMaker]
       |      |
       |      +----> [EZAppMaker]
       |      |
       |      +----> [EZAppMaker.sln]
       |
       +----> [EZForms]
       |      |
       |      +----> [EZAppForms]
       .      |
       .      +----> [EZForms.sln]
```
**EZAppMaker** comprises a set of components which shows the same appearance and behavior on both,
Android and iOS. This project aims to show the basic concepts of the toolkit.

**EZForms** is a set of helper classes that integrates with EZAppMaker. It's aimed
to work with SQLite and will take care of all your CRUD needs.