using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTable : MonoBehaviour
{
    [Header("Chest Types")]

    public int woodenChest = 300;

    public int bronzeChest = 250;

    public int silverChest = 200;

    public int goldChest = 100;

    public int platinumChest = 25;
    
    private int totalChestValue;

    [Header("Wooden Chest")]
    public int woodenChestCommon = 180;
    public int woodenChestUncommon = 45;
    public int woodenChestRare = 20;
    public int woodenChestEpic = 5;
    public int woodenChestLegendary = 1;
    private int totalWoodValue;

    [Header("Bronze Chest")]
    public int bronzeChestCommon = 150;
    public int bronzeChestUncommon = 65;
    public int bronzeChestRare = 35;
    public int bronzeChestEpic = 9;
    public int bronzeChestLegendary = 2;
    private int totalBronzeValue;

    [Header("Silver Chest")]
    public int silverChestCommon = 100;
    public int silverChestUncommon = 95;
    public int silverChestRare = 60;
    public int silverChestEpic = 24;
    public int silverChestLegendary = 7;
    private int totalSilverValue;

    [Header("Gold Chest")]
    public int goldChestCommon = 20;
    public int goldChestUncommon = 30;
    public int goldChestRare = 50;
    public int goldChestEpic = 30;
    public int goldChestLegendary = 10;
    private int totalGoldValue;

    [Header("Platinum Chest")]
    public int platinumChestCommon = 20;
    public int platinumChestUncommon = 20;
    public int platinumChestRare = 45;
    public int platinumChestEpic = 40;
    public int platinumChestLegendary = 20;
    private int totalPlatinumValue;

    //Rarities
    private int common;
    private int uncommon;
    private int rare;
    private int epic;
    private int legendary;
    private int totalRarity;



    // Start is called before the first frame update
    void Start()
    {
        totalChestValue = woodenChest + bronzeChest + silverChest + goldChest + platinumChest;
        totalWoodValue = woodenChestCommon + woodenChestUncommon + woodenChestRare + woodenChestEpic + woodenChestLegendary;
        totalBronzeValue = bronzeChestCommon + bronzeChestUncommon + bronzeChestRare + bronzeChestEpic + bronzeChestLegendary;
        totalSilverValue = silverChestCommon + silverChestUncommon + silverChestRare + silverChestEpic + silverChestLegendary;
        totalGoldValue = goldChestCommon + goldChestUncommon + goldChestRare + goldChestEpic + goldChestLegendary;
        totalPlatinumValue = platinumChestCommon + platinumChestUncommon + platinumChestRare + platinumChestEpic + platinumChestLegendary;
    }

    // Update is called once per frame
    void Update()
    {
        int chestPicked = UnityEngine.Random.Range(0, totalChestValue);

        string currentChestType = "Hello";

        string printThis = "Hello";

        //
        //Calculate Chest Type
        //
        if (Input.GetKeyDown("space"))
        {
            if (chestPicked <= woodenChest)
            {
                currentChestType = "Wooden Chest";
                printThis = ("Wooden Chest");
            }
            else if (chestPicked >= woodenChest + 1 && chestPicked <= woodenChest + bronzeChest)
            {
                currentChestType = "Bronze Chest";
                printThis = ("Bronze Chest");
            }
            else if (chestPicked >= woodenChest + bronzeChest + 1 && chestPicked <= woodenChest + bronzeChest + silverChest  )
            {
                currentChestType = "Silver Chest";
                printThis = ("Silver Chest");
            }
            else if (chestPicked >= woodenChest + bronzeChest + silverChest + 1 && chestPicked <= woodenChest + bronzeChest + silverChest + goldChest)
            {
                currentChestType = "Gold Chest";
                printThis = ("Gold Chest");
            }
            else if (chestPicked >= woodenChest + bronzeChest + silverChest + goldChest + 1 && chestPicked <= woodenChest + bronzeChest + silverChest + goldChest + platinumChest)
            {
                currentChestType = "Platinum Chest";
                printThis = ("Platinum Chest");
            }

            //
            //Give weight to rarities based on chest type
            //
            if (currentChestType == "Wooden Chest")
            {
                common = woodenChestCommon;
                uncommon = woodenChestUncommon;
                rare = woodenChestRare;
                epic = woodenChestEpic;
                legendary = woodenChestLegendary;
                totalRarity = totalWoodValue;
            }
            else if (currentChestType == "Bronze Chest")
            {
                common = bronzeChestCommon;
                uncommon = bronzeChestUncommon;
                rare = bronzeChestRare;
                epic = bronzeChestEpic;
                legendary = bronzeChestLegendary;
                totalRarity = totalBronzeValue;
            }
            else if (currentChestType == "Silver Chest")
            {
                common = silverChestCommon;
                uncommon = silverChestUncommon;
                rare = silverChestRare;
                epic = silverChestEpic;
                legendary = silverChestLegendary;
                totalRarity = totalSilverValue;
            }
            else if (currentChestType == "Gold Chest")
            {
                common = goldChestCommon;
                uncommon = goldChestUncommon;
                rare = goldChestRare;
                epic = goldChestEpic;
                legendary = goldChestLegendary;
                totalRarity = totalGoldValue;
            }
            else if (currentChestType == "Platinum Chest")
            {
                common = platinumChestCommon;
                uncommon = platinumChestUncommon;
                rare = platinumChestRare;
                epic = platinumChestEpic;
                legendary = platinumChestLegendary;
                totalRarity = totalPlatinumValue;
            }


            int rarityPicked = UnityEngine.Random.Range(0, totalRarity);

            //
            //Calculate Rarity
            //
            if (rarityPicked <= common)
            {
                
                Debug.Log(printThis + ": Common!");
            }
            else if (rarityPicked >= common + 1 && rarityPicked <= common + uncommon)
            {
                
                Debug.Log(printThis + ": Uncommon!");
            }
            else if (rarityPicked >= common + uncommon + 1 && rarityPicked <= common + uncommon + rare)
            {
                
                Debug.Log(printThis + ": Rare!");
            }
            else if (rarityPicked >= common + uncommon + rare + 1 && rarityPicked <= common + uncommon + rare + epic)
            {
                
                Debug.Log(printThis + ": Epic!");
            }
            else if (rarityPicked >= common + uncommon + rare + epic + 1 && rarityPicked <= common + uncommon + rare + epic + legendary)
            {
                
                Debug.Log(printThis + ": Legendary!");
            }
        }
    }



        //Debug.Log("Hello");
    

}
