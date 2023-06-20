using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPool
{
    // Rarities will be: "Common", "Uncommon", "Relic", "Mythical", "Legendary"
    // Equipment slots will be: "Mainhand", "Offhand", "Feet", "Legs", "Chest", "Gloves", "Head", "Jewelery"
    // Items will be ordered: Feet, Gloves, Head, Legs, Mainhand/Offhand, Chest, Jewelry
    // Rarity colors: Grey, Blue, Purple, Pink, Red, Yellow
    // name, hp, attack, defense, speed, luck, isMagic, rarity, itemSlot
    public static Item[] areaOneItems = {
        // Common
        new Item("Tattered Footwraps", 0, 0, 1, 2, 0, false, "Common", "Feet"),
        new Item("Tattered Sandals", 0, 0, 2, 1, 0, false, "Common", "Feet"),
        new Item("Twig Footarmor", 0, 0, 2, 1, 0, false, "Common", "Feet"),

        new Item("Tattered Handwraps", 0, 0, 1, 2, 0, false, "Common", "Gloves"),
        new Item("Tattered Gloves", 0, 0, 2, 1, 0, false, "Common", "Gloves"),
        new Item("Twig Gloves", 0, 0, 2, 1, 0, false, "Common", "Gloves"),

        new Item("Twig Mask", 0, 0, 2, 2, 0, false, "Common", "Head"),
        new Item("Twig Helm", 0, 0, 3, 0, 0, false, "Common", "Head"),
        new Item("Wooden Mask", 0, 0, 3, 2, 0, false, "Common", "Head"),
        new Item("Bone Mask", 0, 0, 4, 2, 0, false, "Common", "Head"),
        new Item("Fibrous Mask", 0, 0, 4, 2, 0, false, "Common", "Head"),
        new Item("Snakeleather Mask", 0, 0, 5, 2, 0, false, "Common", "Head"),

        new Item("Tattered Trousers", 0, 0, 2, 2, 0, false, "Common", "Legs"),
        new Item("Tattered Greaves", 0, 0, 2, 1, 0, false, "Common", "Legs"),
        new Item("Twig Greaves", 0, 0, 3, 1, 0, false, "Common", "Legs"),
        
        new Item("Twig", 0, 2, 1, 1, 0, false, "Common", "Mainhand"),
        new Item("Bone", 0, 3, 1, 0, 0, false, "Common", "Mainhand"),
        new Item("Sharpened Stick", 0, 3, 1, 1, 0, false, "Common", "Mainhand"),
        new Item("Branch", 0, 1, 2, 1, 0, false, "Common", "Offhand"),
        new Item("Stone", 0, 1, 2, 0, 0, false, "Common", "Offhand"),
        new Item("Twig Shield", 0, 1, 3, 1, 0, false, "Common", "Offhand"),

        new Item("Tattered Robes", 0, 0, 2, 2, 0, false, "Common", "Chest"),
        new Item("Tattered Shirt", 0, 0, 1, 3, 0, false, "Common", "Chest"),
        new Item("Tattered Chestpiece", 0, 0, 3, 1, 0, false, "Common", "Chest"),
        new Item("Twig Chestpiece", 0, 0, 4, 0, 0, false, "Common", "Chest"),

        new Item("Bone Necklace", 4, 0, 5, 0, 3, false, "Common", "Jewelry"),
        new Item("Black Willow Necklace", 5, 0, 4, 0, 2, false, "Common", "Jewelry"),

        // Uncommon
        new Item("Wooden Footarmor", 0, 0, 3, 1, 0, false, "Uncommon", "Feet"),
        new Item("Fibrous Footwraps", 0, 0, 3, 2, 0, false, "Uncommon", "Feet"),
        new Item("Bone Footarmor", 0, 0, 4, 1, 0, false, "Uncommon", "Feet"),
        new Item("Snakeleather Footwraps", 0, 0, 4, 2, 0, false, "Uncommon", "Feet"),
        new Item("Enchanted Footwraps", 2, 1, 3, 2, 0, true, "Uncommon", "Feet"),
        new Item("Enchanted Footarmor", 2, 1, 5, 1, 0, true, "Uncommon", "Feet"),
        new Item("Frog's Feet", 0, 0, 2, 10, 0, false, "Uncommon", "Feet"),

        new Item("Wooden Mittens", 0, 0, 3, 1, 0, false, "Uncommon", "Gloves"),
        new Item("Fibrous Handwraps", 0, 0, 3, 2, 0, false, "Uncommon", "Gloves"),
        new Item("Bone Mittens", 0, 0, 4, 1, 0, false, "Uncommon", "Gloves"),
        new Item("Snakeleather Handwraps", 0, 0, 5, 2, 0, false, "Uncommon", "Gloves"),
        new Item("Enchanted Handwraps", 2, 1, 5, 2, 0, true, "Uncommon", "Gloves"),
        new Item("Enchanted Mittens", 2, 1, 6, 1, 0, true, "Uncommon", "Gloves"),

        new Item("Fibrous Hood", 0, 0, 4, 1, 0, false, "Uncommon", "Head"),
        new Item("Wooden Helm", 0, 0, 5, 0, 0, false, "Uncommon", "Head"),
        new Item("Bone Helm", 0, 0, 6, 0, 0, false, "Uncommon", "Head"),
        new Item("Snakeleather Hood", 0, 0, 6, 1, 0, false, "Uncommon", "Head"),
        new Item("Enchanted Mask", 2, 1, 4, 2, 0, true, "Uncommon", "Head"),

        new Item("Wooden Greaves", 0, 0, 4, 1, 0, false, "Uncommon", "Legs"),
        new Item("Fibrous Chausses", 0, 0, 5, 1, 0, false, "Uncommon", "Legs"),
        new Item("Bone Greaves", 0, 0, 6, 1, 0, false, "Uncommon", "Legs"),
        new Item("Snakeleather Chausses", 0, 0, 7, 1, 0, false, "Uncommon", "Legs"),
        new Item("Enchanted Greaves", 2, 1, 6, 1, 0, true, "Uncommon", "Legs"),
        new Item("Enchanted Chausses", 2, 1, 7, 1, 0, true, "Uncommon", "Legs"),

        new Item("Crude Bow", 0, 4, 1, 1, 0, false, "Uncommon", "Mainhand"),
        new Item("Spellbook", 0, 5, 0, 2, 0, true, "Uncommon", "Mainhand"),
        new Item("Shovel", 0, 3, 3, 1, 0, false, "Uncommon", "Mainhand"),
        new Item("Wood Club", 0, 4, 2, 1, 0, false, "Uncommon", "Mainhand"),
        new Item("Stone Spear", 0, 5, 0, 2, 0, false, "Uncommon", "Mainhand"),
        new Item("Bone Club", 0, 5, 3, 0, 0, false, "Uncommon", "Mainhand"),
        new Item("Chain", 0, 6, 1, 0, 0, false, "Uncommon", "Mainhand"),
        new Item("Frog's Tongue", 0, 4, 4, 1, 0, false, "Uncommon", "Offhand"),
        new Item("Rat's Claw", 0, 3, 1, 3, 0, false, "Uncommon", "Offhand"),
        new Item("Tome", 0, 6, 0, 3, 0, true, "Uncommon", "Mainhand"),
        new Item("Wooden Staff", 0, 6, 1, 2, 0, true, "Uncommon", "Offhand"),
        new Item("Wooden Shield", 0, 1, 5, 1, 0, false, "Uncommon", "Offhand"),

        new Item("Wooden Chestplate", 0, 0, 5, 0, 0, false, "Uncommon", "Chest"),
        new Item("Fibrous Chestpiece", 0, 0, 6, 1, 0, false, "Uncommon", "Chest"),
        new Item("Bone Chestplate", 0, 0, 7, 0, 0, false, "Uncommon", "Chest"),
        new Item("Snakeleather Chestpiece", 0, 0, 8, 1, 0, false, "Uncommon", "Chest"),
        new Item("Enchanted Chestpiece", 2, 1, 6, 1, 0, true, "Uncommon", "Chest"),
        new Item("Enchanted Robes", 2, 1, 4, 2, 0, true, "Uncommon", "Chest"),

        new Item("Draugr's Locket", 6, 6, 0, 0, 4, false, "Uncommon", "Jewelry"),
        new Item("Shade's Necklace", 7, 0, 0, 6, 5, false, "Uncommon", "Jewelry"),

        // Relic
        new Item("Enchanted Sabatons", 2, 1, 7, 0, 0, true, "Relic", "Feet"),
        new Item("Phantismic Footwraps", 3, 1, 3, 2, 0, true, "Relic", "Feet"),
        new Item("Spectre Footwraps", 1, 4, 4, 2, 0, true, "Relic", "Feet"),
        new Item("Brutish Footarmor", 0, 1, 8, 1, 0, false, "Relic", "Feet"),
        new Item("Spiked Footarmor", 0, 5, 6, 1, 0, false, "Relic", "Feet"),
        new Item("Leachleather Footwraps", 0, 0, 8, 2, 0, false, "Relic", "Feet"),

        new Item("Enchanted Gauntlets", 2, 1, 7, 0, 0, true, "Relic", "Gloves"),
        new Item("Phantismic Handwraps", 3, 1, 4, 3, 0, true, "Relic", "Gloves"),
        new Item("Spectre Gloves", 1, 4, 5, 1, 0, true, "Relic", "Gloves"),
        new Item("Brutish Mittens", 0, 1, 8, 1, 0, false, "Relic", "Gloves"),
        new Item("Spiked Gloves", 0, 5, 6, 1, 0, false, "Relic", "Gloves"),
        new Item("Leachleather Handwraps", 0, 0, 8, 2, 0, false, "Relic", "Gloves"),

        new Item("Wraith's Veil", 5, 0, 7, 4, 0, true, "Relic", "Head"),
        new Item("Spiked Helm", 0, 6, 7, 0, 0, false, "Relic", "Head"),
        new Item("Enchanted Helm", 2, 1, 7, 0, 0, true, "Relic", "Head"),
        new Item("Leechleather Helm", 0, 0, 9, 0, 0, false, "Relic", "Head"),

        new Item("Enchanted Platelegs", 2, 1, 8, 0, 0, true, "Relic", "Legs"),
        new Item("Phantismic Leggings", 4, 2, 6, 4, 0, true, "Relic", "Legs"),
        new Item("Spectre Leggings", 2, 4, 7, 2, 0, true, "Relic", "Legs"),
        new Item("Brutish Greaves", 0, 2, 10, 1, 0, false, "Relic", "Legs"),
        new Item("Spiked Greaves", 0, 5, 8, 1, 0, false, "Relic", "Legs"),
        new Item("Leachleather Chausses", 0, 0, 11, 1, 0, false, "Relic", "Legs"),

        new Item("Bow", 0, 8, 2, 3, 0, false, "Relic", "Mainhand"),
        new Item("Sickle", 0, 7, 2, 4, 0, false, "Relic", "Mainhand"),
        new Item("Draugr's Sword", 0, 9, 4, 3, 0, false, "Relic", "Mainhand"),
        new Item("Banshee's Claws", 0, 11, 0, 3, 0, false, "Relic", "Mainhand"),
        new Item("Witch's Hand", 0, 12, 0, 2, 0, true, "Relic", "Mainhand"),
        new Item("Stone Shield", 0, 2, 9, 0, 0, false, "Relic", "Offhand"),
        new Item("Bone Shield", 0, 1, 7, 1, 0, false, "Relic", "Offhand"),
        new Item("Mosquito's Needle", 3, 11, 0, 5, 0, false, "Relic", "Offhand"),
        new Item("Leech Skin Shield", 0, 2, 11, 0, 0, false, "Relic", "Offhand"),

        new Item("Enchanted Chestplate", 2, 1, 11, 0, 0, true, "Relic", "Chest"),
        new Item("Phantismic Drapes", 5, 2, 8, 6, 0, true, "Relic", "Chest"),
        new Item("Spectre Robes", 3, 5, 9, 2, 0, true, "Relic", "Chest"),
        new Item("Brutish Chainmail", 0, 3, 12, 0, 0, false, "Relic", "Chest"),
        new Item("Spiked Chestpiece", 0, 7, 9, 0, 0, false, "Relic", "Chest"),
        new Item("Leachleather Chestpiece", 0, 0, 13, 1, 0, false, "Relic", "Chest"),

        new Item("Witch Skin Amulet", 8, 7, 0, 2, 7, false, "Relic", "Jewelry"),
        new Item("Cultist Ring", 9, 12, 0, 0, 6, false, "Relic", "Jewelry"),

        // Mythical
        new Item("Cursed Footwraps", 3, 2, 9, 2, 0, true, "Mythical", "Feet"),
        new Item("Brutish Sabatons", 0, 4, 12, 0, 0, false, "Mythical", "Feet"),

        new Item("Cursed Handwraps", 3, 2, 9, 2, 0, true, "Mythical", "Gloves"),
        new Item("Brutish Gauntlets", 0, 3, 12, 0, 0, false, "Mythical", "Gloves"),

        new Item("Cursed Mask", 5, 3, 12, 3, 0, true, "Mythical", "Head"),
        new Item("Brutish Helm", 0, 5, 14, 0, 0, false, "Mythical", "Head"),

        new Item("Cursed Greaves", 4, 3, 10, 1, 0, true, "Mythical", "Legs"),
        new Item("Brutish Platelegs", 0, 4, 15, 0, 0, false, "Mythical", "Legs"),

        new Item("Venemous Executioner", 0, 15, 6, 2, 0, false, "Mythical", "Mainhand"),
        new Item("Brutish Shield", 5, 5, 12, 5, 0, true, "Mythical", "Offhand"),

        new Item("Cursed Robes", 5, 4, 10, 3, 0, true, "Mythical", "Chest"),
        new Item("Brutish Chestplate", 0, 5, 17, 0, 0, false, "Mythical", "Chest"),
        
        new Item("Sledovik", 12, 2, 10, 0, 8, false, "Mythical", "Jewelry"),
        new Item("Gjöll", 15, 12, 3, 0, 8, false, "Mythical", "Jewelry")
    };

    public static Item[] areaOneBossItems = {
        new Item("Distorting Atrocity", 0, 22, 10, 5, 0, true, "Legendary", "Mainhand"),
        new Item("Consuming Monstrosity", 0, 10, 19, 5, 0, true, "Legendary", "Offhand"),
        new Item("Wicked Demonthorn", 4, 5, 18, 5, 0, true, "Legendary", "Head"),
        new Item("Twisted Aegis", 4, 5, 20, 5, 0, true, "Legendary", "Chest"),
        new Item("Aberrant Vigor", 8, 0, 19, 5, 0, true, "Legendary", "Legs")
    };

    // Rarities will be: "Common", "Uncommon", "Relic", "Mythical", "Legendary", "Divine"
    // Equipment slots will be: "Mainhand", "Offhand", "Feet", "Legs", "Chest", "Gloves", "Head", "Jewelery"
    // Items will be ordered: Feet, Gloves, Head, Legs, Mainhand/Offhand, Chest, Jewelry
    // name, hp, attack, defense, speed, luck, isMagic, rarity, itemSlot
    public static Item[] areaTwoItems = {
        // Common
        new Item("Steel Sabatons", 0, 2, 9, 0, 0, false, "Common", "Feet"),
        new Item("Black Sabatons", 0, 2, 11, 0, 0, false, "Common", "Feet"),
        new Item("Treant Footarmor", 0, 1, 6, 2, 0, false, "Common", "Feet"),
        new Item("Scale Footwraps", 0, 0, 9, 3, 0, false, "Common", "Feet"),
        new Item("Nordic Carved Sabatons", 0, 2, 13, 0, 0, false, "Common", "Feet"),
        new Item("Caster's Sandals", 0, 1, 9, 8, 0, true, "Common", "Feet"),
        new Item("Birdfeather Footwraps", 0, 3, 11, 3, 0, false, "Common", "Feet"),
        
        new Item("Steel Gauntlets", 0, 0, 11, 3, 0, false, "Common", "Gloves"),
        new Item("Black Gauntlets", 0, 0, 13, 0, 0, false, "Common", "Gloves"),
        new Item("Treant Gloves", 0, 0, 9, 4, 0, false, "Common", "Gloves"),
        new Item("Scale Handwraps", 0, 0, 11, 6, 0, false, "Common", "Gloves"),
        new Item("Nordic Carved Gauntlets", 0, 0, 15, 0, 0, false, "Common", "Gloves"),
        new Item("Caster's Gloves", 0, 3, 8, 8, 0, true, "Common", "Gloves"),
        new Item("Birdfeather Handwraps", 0, 4, 10, 6, 0, false, "Common", "Gloves"),
        
        new Item("Steel Helm", 0, 0, 13, 2, 0, false, "Common", "Head"),
        new Item("Black Helm", 0, 0, 16, 0, 0, false, "Common", "Head"),
        new Item("Treant Mask", 0, 0, 11, 7, 0, false, "Common", "Head"),
        new Item("Scale Helm", 0, 0, 14, 3, 0, false, "Common", "Head"),
        new Item("Nordic Carved Helm", 0, 0, 18, 0, 0, false, "Common", "Head"),
        new Item("Caster's Hood", 0, 4, 10, 8, 0, true, "Common", "Head"),
        new Item("Bird Mask", 0, 6, 13, 5, 0, false, "Common", "Head"),

        new Item("Steel Platelegs", 0, 0, 15, 0, 0, false, "Common", "Legs"),
        new Item("Black Greaves", 0, 0, 17, 0, 0, false, "Common", "Legs"),
        new Item("Treant Greaves", 0, 0, 13, 4, 0, false, "Common", "Legs"),
        new Item("Scale Platelegs", 0, 0, 16, 1, 0, false, "Common", "Legs"),
        new Item("Nordic Carved Platelegs", 0, 0, 20, 0, 0, false, "Common", "Legs"),
        new Item("Caster's Trousers", 0, 2, 12, 4, 0, true, "Common", "Legs"),
        new Item("Bird Feather Chausses", 0, 3, 16, 3, 0, false, "Common", "Legs"),
        
        new Item("Great Club", 0, 15, 6, 0, 0, false, "Common", "Mainhand"),
        new Item("Dwarven Battleaxe", 0, 17, 0, 2, 0, false, "Common", "Mainhand"),
        new Item("Dwarven Warhammer", 0, 20, 1, 0, 0, false, "Common", "Mainhand"),
        new Item("Dwarven Mace", 0, 18, 0, 1, 0, false, "Common", "Mainhand"),
        new Item("Talons", 0, 16, 0, 5, 0, false, "Common", "Mainhand"),
        new Item("Golem's Core", 0, 19, 0, 2, 0, true, "Common", "Mainhand"),
        new Item("Fine Bow", 0, 18, 0, 2, 0, false, "Common", "Mainhand"),
        new Item("Small Club", 0, 12, 2, 6, 0, false, "Common", "Mainhand"),
        new Item("Worn Club", 0, 15, 4, 2, 0, false, "Common", "Mainhand"),
        new Item("Treant's Limb", 0, 12, 5, 0, 0, false, "Common", "Mainhand"),
        new Item("Black Tail", 0, 14, 7, 0, 0, false, "Common", "Mainhand"),
        new Item("Rock Sling", 0, 15, 0, 3, 0, false, "Common", "Mainhand"),
        new Item("Black Shield", 0, 3, 16, 0, 0, false, "Common", "Offhand"),
        new Item("Steel Shield", 0, 5, 14, 2, 0, false, "Common", "Offhand"),
        new Item("Hardwood Shield", 0, 2, 12, 4, 0, false, "Common", "Offhand"),
        new Item("Bird's Beak", 0, 14, 0, 6, 0, false, "Common", "Offhand"),

        new Item("Steel Platearmor", 0, 0, 16, 0, 0, false, "Common", "Chest"),
        new Item("Black Chestpiece", 0, 0, 19, 0, 0, false, "Common", "Chest"),
        new Item("Treant Chestpiece", 0, 0, 14, 5, 0, false, "Common", "Chest"),
        new Item("Scale Platearmor", 0, 0, 17, 1, 0, false, "Common", "Chest"),
        new Item("Nordic Carved Armor", 0, 0, 22, 0, 0, false, "Common", "Chest"),
        new Item("Caster's Robes", 0, 2, 14, 5, 0, true, "Common", "Chest"),
        new Item("Bird Feather Vest", 0, 3, 18, 3, 0, false, "Common", "Chest"),

        new Item("Draconite Necklace", 6, 8, 8, 5, 6, true, "Common", "Jewelry"),
        new Item("Philosopher's stone", 2, 2, 2, 2, 16, true, "Common", "Jewelry"),


        // Uncommon
        new Item("Chitin Sabatons", 0, 3, 17, 0, 0, false, "Uncommon", "Feet"),
        new Item("Giant Sabatons", 0, 5, 14, 0, 0, false, "Uncommon", "Feet"),
        new Item("Minotaur Hide Footwraps", 0, 2, 15, 3, 0, false, "Uncommon", "Feet"),
        new Item("Venom Needle Footarmor", 0, 10, 11, 2, 0, false, "Uncommon", "Feet"),

        new Item("Chitin Gauntlets", 0, 3, 19, 0, 0, false, "Uncommon", "Gloves"),
        new Item("Giant Gauntlets", 0, 5, 15, 5, 0, false, "Uncommon", "Gloves"),
        new Item("Minotaur Hide Handwraps", 0, 4, 17, 5, 0, false, "Uncommon", "Gloves"),
        new Item("Venom Needle Gloves", 0, 6, 12, 8, 0, false, "Uncommon", "Gloves"),

        new Item("Chitin Helm", 0, 2, 23, 0, 0, false, "Uncommon", "Head"),
        new Item("Giant Helm", 0, 4, 18, 3, 0, false, "Uncommon", "Head"),
        new Item("Minotaur's Head", 0, 6, 19, 3, 0, false, "Uncommon", "Head"),
        new Item("Venom Needle Helm", 0, 8, 14, 6, 0, false, "Uncommon", "Head"),

        new Item("Chitin Platelegs", 0, 0, 25, 0, 0, false, "Uncommon", "Legs"),
        new Item("Giant Platelegs", 0, 2, 21, 0, 0, false, "Uncommon", "Legs"),
        new Item("Minotaur Hide Chausses", 0, 2, 20, 1, 0, false, "Uncommon", "Legs"),
        new Item("Venom Needle Greaves", 0, 10, 16, 2, 0, false, "Uncommon", "Legs"),

        new Item("Giant Club", 0, 22, 3, 0, 0, false, "Uncommon", "Mainhand"),
        new Item("Venemous Fangs", 0, 18, 0, 8, 0, false, "Uncommon", "Mainhand"),
        new Item("Draconic Claws", 0, 20, 0, 6, 0, false, "Uncommon", "Mainhand"),
        new Item("Draconic Tongue", 0, 15, 9, 0, 0, false, "Uncommon", "Mainhand"),
        new Item("Draconic Tail", 0, 18, 6, 2, 0, false, "Uncommon", "Mainhand"),
        new Item("Great Hammer", 0, 25, 2, 0, 0, false, "Uncommon", "Mainhand"),
        new Item("Great Bow", 0, 22, 0, 3, 0, false, "Uncommon", "Mainhand"),
        new Item("Poisonous Tongue", 0, 18, 6, 0, 0, false, "Uncommon", "Mainhand"),
        new Item("Dark Elf's Hand", 0, 20, 0, 9, 0, true, "Uncommon", "Offhand"),

        new Item("Chitin Chestplate", 0, 0, 26, 0, 0, false, "Uncommon", "Chest"),
        new Item("Giant Chestplate", 0, 2, 22, 0, 0, false, "Uncommon", "Chest"),
        new Item("Minotaur Hide Vest", 0, 2, 22, 2, 0, false, "Uncommon", "Chest"),
        new Item("Venom Needle Chestpiece", 0, 10, 17, 3, 0, false, "Uncommon", "Chest"),

        new Item("Gem of Kukulkan", 14, 14, 0, 0, 9, true, "Uncommon", "Jewelry"),
        new Item("Batrachite Ring", 0, 22, 0, 4, 7, true, "Uncommon", "Jewelry"),


        // Relic
        new Item("Snakescale Footarmor", 0, 2, 16, 3, 0, false, "Relic", "Feet"),
        new Item("Drakescale Footarmor", 0, 2, 19, 4, 0, true, "Relic", "Feet"),
        new Item("Wyvernscale Footarmor", 0, 3, 21, 5, 0, true, "Relic", "Feet"),
        new Item("Hydrascale Footarmor", 0, 4, 23, 6, 0, true, "Relic", "Feet"),

        new Item("Snakescale Gloves", 0, 2, 18, 4, 0, false, "Relic", "Gloves"),
        new Item("Drakescale Gloves", 0, 1, 21, 4, 0, true, "Relic", "Gloves"),
        new Item("Wyvernscale Gloves", 0, 2, 23, 5, 0, true, "Relic", "Gloves"),
        new Item("Hydrascale Gloves", 0, 3, 25, 6, 0, true, "Relic", "Gloves"),

        new Item("Snakehead Helm", 0, 4, 23, 2, 0, false, "Relic", "Head"),
        new Item("Drakescale Helm", 0, 2, 25, 3, 0, true, "Relic", "Head"),
        new Item("Wyvernscale Helm", 0, 3, 27, 5, 0, true, "Relic", "Head"),
        new Item("Hydrascale Helm", 0, 4, 29, 7, 0, true, "Relic", "Head"),

        new Item("Snakeskin Chausses", 0, 2, 25, 3, 0, false, "Relic", "Legs"),
        new Item("Drakescale Greaves", 0, 2, 26, 2, 0, true, "Relic", "Legs"),
        new Item("Wyvernscale Greaves", 0, 3, 28, 4, 0, true, "Relic", "Legs"),
        new Item("Hydrascale Greaves", 0, 4, 29, 6, 0, true, "Relic", "Legs"),

        new Item("Draconic Teeth", 0, 24, 5, 7, 0, false, "Relic", "Mainhand"),
        new Item("Wyvern Scaleshield", 0, 5, 18, 5, 0, true, "Relic", "Offhand"),
        new Item("Draconic Shield", 0, 3, 23, 3, 0, true, "Relic", "Offhand"),
        new Item("Hydra Scales", 0, 6, 16, 8, 0, true, "Relic", "Offhand"),

        new Item("Snakeskin Vest", 0, 2, 27, 4, 0, false, "Relic", "Chest"),
        new Item("Drakescale Chestpiece", 0, 2, 28, 3, 0, true, "Relic", "Chest"),
        new Item("Wyvernscale Chestpiece", 0, 3, 30, 5, 0, true, "Relic", "Chest"),
        new Item("Hydrascale Chestpiece", 0, 4, 31, 7, 0, true, "Relic", "Chest"),

        new Item("Adder stone", 13, 0, 22, 0, 12, true, "Relic", "Jewelry"),
        new Item("Vaidurya", 25, 0, 13, 0, 12, true, "Relic", "Jewelry"),


        // Mythical
        new Item("Drakescale Sabatons", 0, 5, 25, 2, 0, true, "Mythical", "Feet"),
        new Item("Wyvernscale Sabatons", 0, 6, 27, 3, 0, true, "Mythical", "Feet"),
        new Item("Hydrascale Sabatons", 0, 7, 29, 4, 0, true, "Mythical", "Feet"),

        new Item("Drakescale Gauntlets", 0, 2, 27, 2, 0, true, "Mythical", "Gloves"),
        new Item("Wyvernscale Gauntlets", 0, 4, 29, 3, 0, true, "Mythical", "Gloves"),
        new Item("Hydrascale Gauntlets", 0, 6, 31, 4, 0, true, "Mythical", "Gloves"),

        new Item("Drake Head Helm", 0, 4, 30, 1, 0, true, "Mythical", "Head"),
        new Item("Wyvern Head Helm", 0, 6, 32, 2, 0, true, "Mythical", "Head"),
        new Item("Hydra Head Helm", 0, 8, 34, 3, 0, true, "Mythical", "Head"),

        new Item("Drakescale Platelegs", 0, 4, 31, 1, 0, true, "Mythical", "Legs"),
        new Item("Wyvernscale Platelegs", 0, 6, 33, 2, 0, true, "Mythical", "Legs"),
        new Item("Hydrascale Platelegs", 0, 8, 35, 3, 0, true, "Mythical", "Legs"),

        new Item("Razor's Edge", 5, 30, 0, 10, 0, true, "Mythical", "Mainhand"),
        new Item("Hydrascale Shield", 0, 4, 27, 6, 0, true, "Mythical", "Offhand"),

        new Item("Drakescale Chestplate", 0, 4, 33, 1, 0, true, "Mythical", "Chest"),
        new Item("Wyvernscale Chestplate", 0, 6, 35, 2, 0, true, "Mythical", "Chest"),
        new Item("Hydrascale Chestplate", 0, 8, 37, 3, 0, true, "Mythical", "Chest"),

        new Item("Andvaranaut", 7, 5, 7, 5, 40, true, "Mythical", "Jewelry"),
        new Item("Ring of Gyges", 0, 5, 6, 35, 16, true, "Mythical", "Jewelry"),

        
        // Legendary
        new Item("Talaria", 0, 5, 23, 20, 0, true, "Legendary", "Feet"),
        new Item("Shoes of Víðarr", 0, 10, 35, 3, 0, true, "Legendary", "Feet"),

        new Item("Járngreipr", 0, 5, 33, 10, 0, true, "Legendary", "Gloves"),
        new Item("Plaguesowers", 0, 10, 37, 3, 0, true, "Legendary", "Gloves"),

        new Item("Tarnhelm", 0, 5, 32, 20, 0, true, "Legendary", "Head"),
        new Item("Helmet of Rostam", 0, 5, 46, 3, 0, false, "Legendary", "Head"),

        new Item("Obsidian Platelegs", 0, 0, 56, 0, 0, false, "Legendary", "Legs"),
        new Item("Nábrók", 0, 0, 33, 15, 15, true, "Legendary", "Legs"),

        new Item("Meteorite Staff", 0, 40, 5, 5, 0, true, "Legendary", "Mainhand"),
        new Item("Durandal", 0, 36, 9, 4, 0, true, "Legendary", "Mainhand"),

        new Item("Babr-e Bayan", 0, 5, 45, 5, 0, true, "Legendary", "Chest"),
        new Item("Armor of Achilles", 0, 0, 55, 0, 0, true, "Legendary", "Chest"),

        new Item("Band of Hollow Whispers", 6, 34, 0, 26, 23, true, "Legendary", "Jewelry"),
        new Item("Halo of Arlyse", 11, 0, 43, 3, 25, true, "Legendary", "Jewelry")
    };

    public static Item[] areaTwoBossItems = {
        new Item("Imhullu", 0, 53, 9, 14, 0, true, "Legendary", "Mainhand"),
        new Item("Dubán", 0, 12, 48, 13, 0, true, "Legendary", "Offhand"),
        new Item("Huliðshjálmr", 5, 5, 29, 38, 0, true, "Legendary", "Head"),
        new Item("Armor of Beowulf", 5, 5, 50, 5, 0, true, "Legendary", "Chest"),
        new Item("Ragnar's Pants", 0, 0, 52, 17, 0, true, "Legendary", "Legs")
    };


    // Rarities will be: "Common", "Uncommon", "Relic", "Mythical", "Legendary", "Divine"
    // Equipment slots will be: "Mainhand", "Offhand", "Feet", "Legs", "Chest", "Gloves", "Head", "Jewelery"
    // Items will be ordered: Feet, Gloves, Head, Legs, Mainhand/Offhand, Chest, Jewelry
    // name, hp, attack, defense, speed, luck, isMagic, rarity, itemSlot
    public static Item[] areaThreeItems = {
        // Common
        new Item("Phoenixfeather Footwraps", 0, 0, 31, 6, 0, true, "Common", "Feet"),
        new Item("Demonleather Footarmor", 0, 1, 34, 5, 0, false, "Common", "Feet"),
        new Item("Lichbone Footarmor", 0, 1, 36, 4, 0, true, "Common", "Feet"),
        new Item("Lesser Dragonscale Sabatons", 0, 2, 37, 0, 0, true, "Common", "Feet"),
        new Item("Elemental Sabatons", 0, 0, 28, 4, 0, true, "Common", "Feet"),
        new Item("Apparition's Socks", 0, 1, 26, 11, 0, true, "Common", "Feet"),

        new Item("Phoenixfeather Handwraps", 0, 0, 34, 4, 0, true, "Common", "Gloves"),
        new Item("Demonleather Gloves", 0, 0, 37, 3, 0, false, "Common", "Gloves"),
        new Item("Lichbone Gloves", 0, 0, 38, 2, 0, true, "Common", "Gloves"),
        new Item("Lesser Dragonscale Gauntlets", 0, 0, 40, 0, 0, true, "Common", "Gloves"),
        new Item("Elemental Gauntlets", 0, 0, 31, 2, 0, true, "Common", "Gloves"),
        new Item("Apparition's Gloves", 0, 1, 29, 8, 0, true, "Common", "Gloves"),

        new Item("Phoenixfeather Hood", 0, 0, 36, 6, 0, true, "Common", "Head"),
        new Item("Demonleather Hood", 0, 0, 40, 5, 0, false, "Common", "Head"),
        new Item("Lich Mask", 0, 0, 41, 5, 0, true, "Common", "Head"),
        new Item("Lesser Dragonscale Helm", 0, 0, 44, 0, 0, true, "Common", "Head"),
        new Item("Elemental Helm", 0, 0, 35, 4, 0, true, "Common", "Head"),
        new Item("Apparition's Veil", 0, 3, 33, 12, 0, true, "Common", "Head"),

        new Item("Phoenixfeather Chausses", 0, 0, 37, 5, 0, true, "Common", "Legs"),
        new Item("Demonleather Chausses", 0, 0, 43, 4, 0, false, "Common", "Legs"),
        new Item("Lich Greaves", 0, 0, 43, 4, 0, true, "Common", "Legs"),
        new Item("Lesser Dragonscale Platelegs", 0, 0, 47, 0, 0, true, "Common", "Legs"),
        new Item("Elemental Platelegs", 0, 0, 36, 3, 0, true, "Common", "Legs"),
        new Item("Apparition's Leggings", 0, 2, 35, 10, 0, true, "Common", "Legs"),

        new Item("Wraithworm Tooth", 0, 36, 8, 0, 0, false, "Common", "Mainhand"),
        new Item("Lich Hand", 0, 40, 0, 5, 0, true, "Common", "Mainhand"),
        new Item("Pit Fiend's Mace", 0, 33, 9, 1, 0, false, "Common", "Mainhand"),
        new Item("Nighthag's Claw", 0, 25, 0, 20, 0, false, "Common", "Mainhand"),
        new Item("Elemental Core", 0, 35, 3, 7, 0, true, "Common", "Mainhand"),
        new Item("Voidstone", 0, 43, 0, 2, 0, true, "Common", "Mainhand"),
        new Item("Cerberus's Tail", 0, 27, 15, 0, 0, false, "Common", "Mainhand"),
        new Item("Hellhound's Foot", 0, 23, 6, 10, 0, false, "Common", "Mainhand"),
        new Item("Archdevil's Axe", 0, 37, 2, 6, 0, false, "Common", "Mainhand"),
        new Item("Devil's Pitchfork", 0, 33, 12, 3, 0, false, "Common", "Mainhand"),
        new Item("Chimera's Horns", 0, 28, 5, 8, 0, false, "Common", "Offhand"),
        new Item("Hellcat's Fangs", 0, 24, 7, 12, 0, false, "Common", "Offhand"),
        new Item("Fiery Talons", 0, 38, 0, 7, 0, true, "Common", "Offhand"),
        new Item("Obsidian Shield", 0, 7, 31, 0, 0, false, "Common", "Offhand"),
        new Item("Magic Core Shield", 0, 4, 35, 2, 0, true, "Common", "Offhand"),
        new Item("Diamond Shield", 0, 5, 37, 0, 0, false, "Common", "Offhand"),

        new Item("Phoenixfeather Robes", 0, 0, 41, 4, 0, true, "Common", "Chest"),
        new Item("Demonleather Vest", 0, 0, 43, 3, 0, false, "Common", "Chest"),
        new Item("Lichbone Chestpiece", 0, 0, 45, 2, 0, true, "Common", "Chest"),
        new Item("Lesser Dragonscale Chestplate", 0, 0, 50, 0, 0, true, "Common", "Chest"),
        new Item("Elemental Chestpiece", 0, 0, 37, 3, 0, true, "Common", "Chest"),
        new Item("Apparition's Robes", 0, 3, 35, 8, 0, true, "Common", "Chest"),

        new Item("Seer Stone", 0, 0, 0, 0, 60, true, "Common", "Jewelry"),
        new Item("Charmstone", 5, 0, 20, 34, 14, true, "Common", "Jewelry"),

        // Uncommon
        new Item("Nightmare Skin Footwraps", 0, 0, 44, 1, 0, false, "Uncommon", "Feet"),
        new Item("Devil Skin Footwraps", 0, 0, 42, 5, 0, false, "Uncommon", "Feet"),
        new Item("Dragonscale Sabatons", 0, 2, 46, 0, 0, true, "Uncommon", "Feet"),
        new Item("Doppelganger's Boots", 0, 0, 24, 23, 0, true, "Uncommon", "Feet"),

        new Item("Nightmare Skin Handwraps", 0, 2, 47, 1, 0, false, "Uncommon", "Gloves"),
        new Item("Devil Skin Handwraps", 0, 0, 45, 3, 0, false, "Uncommon", "Gloves"),
        new Item("Dragonscale Gauntlets", 0, 0, 49, 0, 0, true, "Uncommon", "Gloves"),
        new Item("Doppelganger's Gloves", 0, 0, 28, 19, 0, true, "Uncommon", "Gloves"),

        new Item("Nightmare's Face", 0, 4, 50, 3, 0, false, "Uncommon", "Head"),
        new Item("Dragonscale Helm", 0, 0, 53, 0, 0, true, "Uncommon", "Head"),
        new Item("Devil Skin Helm", 0, 0, 48, 6, 0, false, "Uncommon", "Head"),
        new Item("Doppelganger's Head", 0, 0, 31, 22, 0, true, "Uncommon", "Head"),

        new Item("Nightmare Skin Chausses", 0, 3, 52, 2, 0, false, "Uncommon", "Legs"),
        new Item("Dragonscale Platelegs", 0, 0, 55, 0, 0, true, "Uncommon", "Legs"),
        new Item("Devil Skin Chausses", 0, 0, 51, 5, 0, false, "Uncommon", "Legs"),
        new Item("Doppelganger's Leggings", 0, 0, 33, 20, 0, true, "Uncommon", "Legs"),

        new Item("Secace", 0, 45, 7, 4, 0, false, "Uncommon", "Mainhand"),
        new Item("Legbiter", 0, 39, 5, 3, 0, false, "Uncommon", "Mainhand"),
        new Item("Brainbiter", 0, 42, 3, 6, 0, false, "Uncommon", "Mainhand"),
        new Item("Ascalon", 0, 48, 10, 5, 0, true, "Uncommon", "Mainhand"),
        new Item("Bleeding Lance", 0, 46, 2, 4, 0, true, "Uncommon", "Mainhand"),
        new Item("Bradamante's Lance", 0, 49, 0, 5, 0, true, "Uncommon", "Mainhand"),
        new Item("Shield of El Cid", 0, 0, 45, 5, 0, true, "Uncommon", "Offhand"),

        new Item("Nightmare Skin Vest", 0, 3, 54, 2, 0, false, "Uncommon", "Chest"),
        new Item("Dragonscale Chestplate", 0, 0, 58, 0, 0, true, "Uncommon", "Chest"),
        new Item("Devil Skin Vest", 0, 0, 52, 4, 0, false, "Uncommon", "Chest"),
        new Item("Doppelganger's Vest", 0, 0, 36, 25, 0, true, "Uncommon", "Chest"),

        new Item("Seal of Solomon", 0, 33, 30, 0, 18, true, "Uncommon", "Jewelry"),
        new Item("Flaming Pearl", 25, 0, 10, 0, 15, true, "Uncommon", "Jewelry"),

        // Relic
        new Item("Wraithwormleather Footarmor", 0, 2, 47, 7, 0, false, "Relic", "Feet"),
        new Item("Beastfur Footarmor", 0, 1, 48, 8, 0, false, "Relic", "Feet"),
        new Item("Ancient Dragonscale Sabatons", 0, 2, 58, 0, 0, true, "Relic", "Feet"),
        new Item("Archdevil Skin Footwraps", 0, 0, 51, 9, 0, false, "Relic", "Feet"),

        new Item("Wraithwormleather Handwraps", 0, 2, 51, 4, 0, false, "Relic", "Gloves"),
        new Item("Beastfur Gloves", 0, 2, 52, 4, 0, false, "Relic", "Gloves"),
        new Item("Ancient Dragonscale Gauntlets", 0, 0, 62, 0, 0, true, "Relic", "Gloves"),
        new Item("Archdevil Skin Handwraps", 0, 0, 55, 6, 0, false, "Relic", "Gloves"),

        new Item("Archdevil Skin Helm", 0, 0, 58, 8, 0, false, "Relic", "Head"),
        new Item("Ancient Dragonscale Helm", 0, 0, 65, 0, 0, true, "Relic", "Head"),
        new Item("Wraithworm Helm", 0, 3, 55, 5, 0, false, "Relic", "Head"),
        new Item("Beast's Head", 0, 4, 57, 7, 0, false, "Relic", "Head"),

        new Item("Archdevil Skin Chausses", 0, 0, 60, 6, 0, false, "Relic", "Legs"),
        new Item("Ancient Dragonscale Platelegs", 0, 0, 68, 0, 0, true, "Relic", "Legs"),
        new Item("Wraithworm Greaves", 0, 2, 56, 4, 0, false, "Relic", "Legs"),
        new Item("Beast's Chausses", 0, 3, 58, 5, 0, false, "Relic", "Legs"),

        new Item("Tyrfing", 0, 56, 5, 7, 0, true, "Relic", "Mainhand"),
        new Item("Hrotti", 0, 59, 0, 9, 0, true, "Relic", "Mainhand"),
        new Item("Hrunting", 0, 62, 0, 5, 0, true, "Relic", "Mainhand"),
        new Item("Nægling", 0, 70, 0, 3, 0, true, "Relic", "Mainhand"),
        new Item("Xiuhcoatl", 0, 56, 0, 17, 0, true, "Relic", "Offhand"),

        new Item("Wraithwormleather Chestpiece", 0, 2, 59, 4, 0, false, "Relic", "Chest"),
        new Item("Ancient Dragonscale Chestplate", 0, 0, 70, 0, 0, true, "Relic", "Chest"),
        new Item("Beastfur Vest", 0, 3, 60, 5, 0, false, "Relic", "Chest"),
        new Item("Archdevil Skin Vest", 0, 0, 62, 5, 0, false, "Relic", "Chest"),

        new Item("Syamantaka", 26, 0, 12, 31, 17, true, "Relic", "Jewelry"),
        new Item("Myrrh Bracelet", 0, 5, 5, 35, 20, true, "Relic", "Jewelry"),


        // Mythical
        new Item("Voidstone Sabatons", 0, 11, 50, 9, 0, true, "Mythical", "Feet"),
        new Item("Drukscale Sabatons", 0, 4, 65, 3, 0, true, "Mythical", "Feet"),
        new Item("Pukscale Sabatons", 0, 3, 67, 4, 0, true, "Mythical", "Feet"),

        new Item("Voidstone Gauntlets", 0, 9, 55, 7, 0, true, "Mythical", "Gloves"),
        new Item("Drukscale Gauntlets", 0, 2, 60, 1, 0, true, "Mythical", "Gloves"),
        new Item("Pukscale Gauntlets", 0, 1, 72, 2, 0, true, "Mythical", "Gloves"),

        new Item("Voidstone Helm", 0, 13, 59, 8, 0, true, "Mythical", "Head"),
        new Item("Drukscale Helm", 0, 5, 74, 3, 0, true, "Mythical", "Head"),
        new Item("Pukscale Helm", 0, 3, 75, 5, 0, true, "Mythical", "Head"),

        new Item("Voidstone Platelegs", 0, 11, 61, 7, 0, true, "Mythical", "Legs"),
        new Item("Drukscale Platelegs", 0, 4, 74, 2, 0, true, "Mythical", "Legs"),
        new Item("Pukscale Platelegs", 0, 2, 77, 4, 0, true, "Mythical", "Legs"),

        new Item("Gram", 0, 65, 10, 6, 0, true, "Mythical", "Mainhand"),
        new Item("Holy Lance", 0, 68, 2, 8, 0, true, "Mythical", "Offhand"),

        new Item("Voidstone Chestplate", 0, 7, 66, 5, 0, true, "Mythical", "Chest"),
        new Item("Drukscale Chestplate", 0, 2, 79, 1, 0, true, "Mythical", "Chest"),
        new Item("Pukscale Chestplate", 0, 1, 81, 2, 0, true, "Mythical", "Chest"),

        new Item("Caloric Stone", 34, 27, 0, 0, 26, true, "Mythical", "Jewelry"),
        new Item("Cintamani", 6, 6, 6, 6, 72, true, "Mythical", "Jewelry"),


        // Legendary
        new Item("Ǒusībùyúnlǚ", 5, 0, 70, 11, 0, true, "Legendary", "Feet"),
        new Item("Helskór", 8, 8, 66, 5, 10, true, "Legendary", "Feet"),

        new Item("Daedric Gauntlets", 0, 5, 74, 6, 0, false, "Legendary", "Gloves"),
        new Item("Demonic Gauntlets of Maiming", 0, 16, 70, 3, 0, true, "Legendary", "Gloves"),

        new Item("Goswhit", 0, 0, 79, 9, 0, false, "Legendary", "Head"),
        new Item("Kuzuryūscale Helm", 0, 8, 86, 7, 0, true, "Legendary", "Head"),

        new Item("Daedric Platelegs", 0, 4, 79, 4, 0, false, "Legendary", "Legs"),
        new Item("Downfall", 0, 18, 76, 7, 0, true, "Legendary", "Legs"),

        new Item("Kunwu", 0, 78, 17, 0, 0, true, "Legendary", "Mainhand"),
        new Item("Hauteclere", 0, 73, 8, 8, 0, true, "Legendary", "Mainhand"),
        new Item("Téngkōng", 0, 69, 3, 18, 0, true, "Legendary", "Offhand"),
        new Item("Apollo's Arrow", 0, 71, 0, 12, 0, true, "Legendary", "Offhand"),

        new Item("Golden Coat of Chainmail", 0, 0, 90, 9, 0, true, "Legendary", "Chest"),
        new Item("Robe of the Fire-rat", 0, 7, 84, 12, 0, true, "Legendary", "Chest"),

        new Item("Kaustubha", 20, 19, 15, 21, 29, true, "Legendary", "Jewelry"),
        new Item("World Egg", 25, 23, 24, 3, 31, true, "Legendary", "Jewelry"),


        // Divine
        new Item("Ardor", 5, 11, 74, 9, 5, true, "Divine", "Feet"),
        new Item("Sloth", 41, 0, 77, 0, 0, true, "Divine", "Feet"),

        new Item("Avarice", 0, 21, 77, 4, 25, true, "Divine", "Gloves"),
        new Item("Generosity", 28, 0, 84, 13, 0, true, "Divine", "Gloves"),

        new Item("Helm of Awe", 0, 19, 86, 14, 0, true, "Divine", "Head"),
        new Item("Ariadne's diadem", 9, 13, 80, 17, 0, true, "Divine", "Head"),

        new Item("Nature and Society", 19, 0, 86, 14, 0, true, "Divine", "Legs"),
        new Item("Castle and Country", 0, 8, 100, 3, 0, true, "Divine", "Legs"),

        new Item("Kaladanda", 0, 98, 0, 7, 0, true, "Divine", "Mainhand"),
        new Item("Gáe Bulg", 0, 88, 10, 5, 0, true, "Divine", "Mainhand"),
        new Item("Svalinn", 0, 0, 80, 0, 0, true, "Divine", "Offhand"),
        new Item("Shield of Evalach", 0, 0, 75, 7, 0, true, "Divine", "Offhand"),

        new Item("Tarnkappe", 0, 0, 74, 37, 0, true, "Divine", "Chest"),
        new Item("Sun robe", 0, 32, 80, 9, 0, true, "Divine", "Chest"),

        new Item("Alatyr", 92, 0, 0, 0, 45, true, "Divine", "Jewelry"),
        new Item("Sesshō-seki", 0, 91, 0, 0, 43, true, "Divine", "Jewelry")
    };

    public static Item[] areaThreeBossItems = {
        new Item("Shield of Galaxia", 0, 12, 104, 8, 25, true, "Legendary", "Offhand"),
        new Item("Demonshade Veil", 5, 18, 88, 54, 25, true, "Legendary", "Head"),
        new Item("Auric Leggings", 39, 0, 100, 25, 25, true, "Legendary", "Legs"),

        new Item("Zenith", 10, 129, 29, 77, 30, true, "Divine", "Mainhand"),
        new Item("World Champion's Armor", 24, 11, 104, 43, 30, true, "Divine", "Chest")
    };
}
