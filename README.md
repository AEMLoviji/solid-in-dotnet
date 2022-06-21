# About the repo

The repo contains code examples written in C# to give understanding about how we can archive each SOLID idea during development.

## What is SOLID

Source: [Wikipedia](https://en.wikipedia.org/wiki/SOLID)

In software engineering, __SOLID__ is a mnemonic acronym for five design principles intended to make object-oriented designs more

- understandable
- flexible
- maintainable

The principles are a subset of many principles promoted by American software engineer and instructor Robert C. Martin, first introduced in his 2000 paper [Design Principles and Design Patterns](https://web.archive.org/web/20150906155800/http://www.objectmentor.com/resources/articles/Principles_and_Patterns.pdf).

The SOLID ideas are

- [x] The __S__ ingle-responsibility principle: _"There should never be more than one reason for a class to change." In other words, every class should have only one responsibility._
  - [Code. Violated](./SOLID_NET/Ideas/S/Violated/Store.cs)
  - [Code. Fixed](./SOLID_NET/Ideas/S/Fixed/Store.cs)
- [ ] The __O__ pen-closed principle: _"Software entities ... should be open for extension, but closed for modification."_
- [ ] The __L__ iskov substitution principle: _"Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it."_
- [x] The __I__ nterface segregation principle: _"Many client-specific interfaces are better than one general-purpose interface."_
  - [Code. Violated](./SOLID_NET/Ideas/I/Violated/MyOldGoodFriend.cs)
  - [Code. Fixed](./SOLID_NET/Ideas/I/Fixed/MyOldGoodFriend.cs)
- [x] The __D__ ependency inversion principle: _"Depend upon abstractions, __not__ concretions."_
  - [Code. Violated](./SOLID_NET/Ideas/D/Violated/Product.cs)
  - [Code. Fixed](./SOLID_NET/Ideas/D/Fixed/Product.cs)

The SOLID acronym was introduced later, around 2004, by Michael Feathers.

## Techniques for detecting violations of the principle

### Single responsibility principle (SRP)

- Method/Property/Class contains a lot of functionality which belong to different layer. For instance
  - Read data from console
  - make some input validation
  - based on entered input grab data from Datasource
  - write to the log directly wihtout refering any other module/class
  - send metrics directly wihtout refering any other module/class  

### Interface segregation principle (ISP)

- Too big interfaces
- Weak cohesion between components (i.e. Methods, Properties) in interface (smell violation of SRP)
- Methods wihtout implementation (smell violation of LSP)
