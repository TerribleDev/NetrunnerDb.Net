[![Build status](https://ci.appveyor.com/api/projects/status/2shuyra61n7ntmee?svg=true)](https://ci.appveyor.com/project/tparnell8/netrunnerdb-net)

## What is this?

A simple API wrapper over the netrunner db.


## How does this work?

To put it simply


```
new Repository().GetRequest<Cards>()

OR

new Repository().GetCards()

new Repository().GetRequest<Card>(01001)


```
