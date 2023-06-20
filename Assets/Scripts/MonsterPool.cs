using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPool
{
    // name, hp, attack, defense, speed, isMaigc, exp, difficulty
    public static Monster[] areaOneMonsters = {
    new Monster("Skeleton", 13, 12, 14, 10, false, 49, 1),
    new Monster("Leech", 13, 13, 15, 13, false, 56, 1),
    new Monster("Salamander", 10, 6, 8, 10, false, 34, 1),
    new Monster("Acidic Blob", 13, 12, 15, 10, false, 50, 1),
    new Monster("Giant Frog", 15, 12, 10, 12, false, 39, 1),
    new Monster("Giant Rat", 12, 8, 9, 13, false, 42, 1),
    new Monster("Wraith", 13, 12, 15, 15, false, 55, 1),
    new Monster("Cultist", 15, 10, 15, 10, true, 50, 1),
    new Monster("Cultist Shaman", 17, 12, 17, 11, true, 57, 1),
    new Monster("Cultist Brute", 23, 16, 25, 10, false, 74, 2),
    new Monster("Ghoul", 15, 12, 11, 13, false, 51, 1),
    new Monster("Bonemass", 23, 15, 25, 10, false, 73, 2),
    new Monster("Skeleton Archer", 13, 13, 16, 10, false, 52, 1),
    new Monster("Draugr", 15, 10, 13, 11, false, 49, 1),
    new Monster("Draugr Elite", 23, 16, 20, 14, false, 73, 2),
    new Monster("Witch", 18, 20, 15, 13, true, 66, 1),
    new Monster("Gremlin", 11, 8, 10, 15, false, 44, 1),
    new Monster("Shade", 15, 15, 15, 13, false, 58, 1),
    new Monster("Phantom", 18, 10, 16, 15, false, 59, 1),
    new Monster("Banshee", 21, 12, 20, 18, false, 71, 2),
    new Monster("Pondsnapper", 13, 10, 13, 13, false, 49, 1),
    new Monster("Gloomflower", 22, 10, 10, 20, true, 58, 1),
    new Monster("Serpeant", 23, 20, 30, 12, false, 85, 2),
    new Monster("Maneater", 13, 13, 18, 10, false, 54, 1),
    new Monster("Deadly Mosquito", 13, 20, 10, 20, false, 63, 2)
    };
    public static Monster areaOneBoss = new Monster("Abomination", 200, 35, 60, 15, false, 360, 3);

    public static Monster[] areaTwoMonsters = {
    new Monster("Troll", 35, 30, 85, 40, false, 190, 1),
    new Monster("Orc", 25, 25, 75, 40, false, 165, 1),
    new Monster("Giant", 65, 70, 105, 36, false, 276, 2),
    new Monster("Wyvern", 65, 55, 110, 60, true, 290, 2),
    new Monster("Ogre", 40, 35, 90, 40, false, 180, 1),
    new Monster("Drake", 40, 30, 85, 50, true, 195, 1),
    new Monster("Griffin", 40, 30, 85, 60, false, 215, 1),
    new Monster("Basilisk", 65, 60, 105, 70, false, 300, 2),
    new Monster("Black Tortoise", 30, 20, 105, 30, false, 185, 1),
    new Monster("Hydra", 75, 60, 125, 60, true, 320, 2),
    new Monster("Minotaur", 45, 55, 110, 50, false, 260, 2),
    new Monster("Golem", 35, 30, 95, 40, false, 200, 1),
    new Monster("Centaur", 40, 50, 105, 70, false, 265, 2),
    new Monster("Cyclops", 45, 55, 110, 60, false, 270, 2),
    new Monster("Hill Dwarf", 35, 30, 95, 50, false, 210, 1),
    new Monster("Dark Elf", 50, 60, 85, 70, true, 265, 2),
    new Monster("Elf", 25, 25, 75, 60, false, 185, 1),
    new Monster("Toadman", 35, 30, 85, 60, true, 210, 1),
    new Monster("Goblin", 20, 20, 70, 40, false, 150, 1),
    new Monster("Kobold", 25, 25, 75, 50, false, 175, 1),
    new Monster("Lizardman", 35, 30, 90, 50, false, 205, 1),
    new Monster("Birdman", 35, 25, 80, 60, false, 200, 1),
    new Monster("Dragonoid", 40, 50, 125, 50, false, 265, 2),
    new Monster("Treant", 40, 25, 95, 40, false, 200, 1),
    new Monster("Centipede", 40, 60, 105, 80, false, 285, 2)
    };
    public static Monster areaTwoBoss = new Monster("Naga", 300, 90, 100, 60, false, 550, 3);

    public static Monster[] areaThreeMonsters = {
    new Monster("Lesser Demon", 80, 80, 130, 80, false, 370, 1),
    new Monster("Lesser Dragon", 90, 90, 150, 70, true, 400, 1),
    new Monster("Ancient Dragon", 150, 120, 160, 80, true, 510, 2),
    new Monster("Dragon", 110, 100, 160, 75, true, 445, 1),
    new Monster("Phoneix", 100, 80, 140, 100, true, 420, 1),
    new Monster("Lich", 90, 90, 130, 70, true, 380, 1),
    new Monster("Elder Lich", 110, 110, 160, 80, true, 460, 2),
    new Monster("Devil", 80, 80, 120, 70, false, 350, 1),
    new Monster("Archdevil", 115, 110, 160, 95, false, 480, 2),
    new Monster("Imp", 80, 80, 140, 80, false, 370, 1),
    new Monster("Hellcat", 95, 90, 135, 100, false, 420, 1),
    new Monster("Hellhound", 100, 100, 140, 90, false, 430, 1),
    new Monster("Wraithworm", 120, 100, 140, 110, false, 470, 2),
    new Monster("Pit Fiend", 130, 115, 160, 110, false, 515, 2),
    new Monster("Nightmare", 140, 120, 170, 80, true, 510, 2),
    new Monster("Lemure", 120, 100, 140, 70, false, 430, 1),
    new Monster("Hordling", 100, 90, 145, 90, false, 425, 1),
    new Monster("Nighthag", 110, 100, 140, 80, true, 430, 1),
    new Monster("Doppelganger", 80, 110, 130, 170, false, 490, 2),
    new Monster("Homunculus", 90, 90, 140, 80, true, 400, 1),
    new Monster("Elemental", 100, 90, 140, 90, true, 420, 1),
    new Monster("Void", 120, 120, 170, 100, false, 460, 2),
    new Monster("Beast of Darkness", 130, 120, 160, 120, false, 530, 2),
    new Monster("Chimera", 120, 120, 160, 110, false, 510, 2),
    new Monster("Cerberus", 120, 120, 160, 110, false, 510, 2)
    };
    public static Monster areaThreeBoss = new Monster("Overlord", 600, 175, 250, 125, true, 1150, 3);
}
