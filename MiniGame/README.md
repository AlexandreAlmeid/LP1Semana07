```mermaid
---
title: MiniGame
---
classDiagram
    Character o-- Weapon
    Character <|-- Player
    Character <|-- Enemy
    Weapon <|-- Gun
    Weapon <|-- Sword
    Character : +string Name
    Character : #Weapon[] weapons
    Character : +Flight()
    Weapon : #float power
    Weapon : +Weapon(float)
    class Player{
        +Player(string)
    }
    class Enemy{
        +Enemy(string)
    }
    class Gun{
        +int Ammo
        +Gun(float,int)
        +FireGun()
    }
    class Sword{
        +float BladeLength
        +Sword(float,float)
        +AttackWithSword()
    }
```