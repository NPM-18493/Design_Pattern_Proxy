# Design Pattern Proxy

### Type
Structural Design Pattern

### Sub Categories
+ Virtual Proxy: Used for creating an expensive object on demand.
+ Remote Proxy: Represents an object which is in different address space.
+ Protection Proxy: Controls access to an object by implementing permission checks.
+ Smart Proxy: used to add some kind of functionality to manage the resources in an efficient manner.
+ Cache Proxy: Provides temporary storage to store result of expensive operation.
+ Logging Proxy: To implement logs in application.

### What problem it solves?
Different challenges are addressed based on what category of Proxy Design Pattern is implemented.
+ Protection Proxy: To solve security and access control
+ Virtual Proxy and Cache Proxy: To improving performance
+ Remote Proxy: To access resources with different address space
+ Decoupling and maintainability

### How it solves the problem?
Proxy Design Pattern provides an object as a surrogate or placeholder for another object to control access to it. It acts as a gatekeeper and decides whether, when, and how the real object should be accessed, improving efficiency and security while maintaining flexibility.

### Limitations
+ Limited Transparency
+ Potential overuse may reduce readability
+ Cache Proxy comes with overhead of keeping cache resource in sync with original resource.

### Diagram




