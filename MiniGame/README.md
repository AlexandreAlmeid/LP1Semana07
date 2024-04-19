---
title: MiniGame
---
classDiagram
    Character <|-- Player
    Character <|-- Enemy
    Weapon <|-- Gun
    Weapon <|-- Sword
    Character : +string Name
    Character : #Weapon[] weapons
    Character : +Flight(): void
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
        +FireGun(): void
    }
    class Sword{
        +float BladeLength
        +Sword(float,float)
        +AttackWithSword(): void
    }