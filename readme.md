[![Build status](https://ci.appveyor.com/api/projects/status/2shuyra61n7ntmee?svg=true)](https://ci.appveyor.com/project/tparnell8/netrunnerdb-net)

## What is this?

A simple API wrapper over the netrunner db.


## How does this work?

To put it simply


```csharp

var result = new Repository().GetCards();
var result = new Repository().GetCard("CardId (example, noise = 01001)");
var result = new Repository().GetSets();
var result = new Repository().GetSet("tsb (set code, all set codes can be found by querying GetCards())");
var result new Repository().GetDecklist("Decklist ID, can be found in the URL of the decklist")
var targetDate = new DateTime(2014, 01, 01);
new Repository().GetDecklistForDay(targetDate)

```
