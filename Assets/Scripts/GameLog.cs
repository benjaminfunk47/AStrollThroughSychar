using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// Halfway Point: No items, no equipment slots, game ends after third boss, no main menu


/**
Slow down game(1f, 0.7f, 0.4f?)
Main menu, save stats, inventory, gear, levels, points, kill count, area, update stats on continuing game(save current health as well as max health)
Music, sound effects?
**/

public class GameLog : MonoBehaviour 
{
    // Private VARS
    private List<string> Eventlog = new List<string>();
    private string guiText = "";

    // Public VARS
    private int maxLines = 13;
    
    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.textArea);
        style.fontSize = 24;
        style.padding = new RectOffset(10, 0, 10, 10);
        style.richText = true;
        GUI.Label(new Rect((Screen.width / 4) - 70, Screen.height - (Screen.height / 2) + 170, Screen.width / 3 + 430, Screen.height / 3), guiText, style);
    }

    public void AddEvent(string eventString)
    {
        Eventlog.Add(eventString);

        if (Eventlog.Count >= maxLines)
            Eventlog.RemoveAt(0);

        guiText = "";

        foreach (string logEvent in Eventlog)
        {
            guiText += logEvent;
            guiText += "\n";
        }
    }

    private GameLog eventLog;
    public GameManager gameManager;
    public GameObject nameBox;
    public GameObject areaTextBox;
    public GameObject areaKillBox;
    public GameObject hpTextBox;
    public GameObject attackTextBox;
    public GameObject defenseTextBox;
    public GameObject speedTextBox;
    public GameObject luckTextBox;
    public GameObject monsterNameTextBox;
    public Text nameText;
    public Text areaText;
    public Text areaKillCountText;
    public Text hpAmountText;
    public Text attackAmountText;
    public Text defenseAmountText;
    public Text speedAmountText;
    public Text monsterNameText;
    public Text luckAmountText;
    public InventoryManager invManager;
    public Monster spawnedMonster;
    public Character playerChar;
    public PlayerHealthBar playerHealthBar;
    public MonsterHealthBar monsterHealthBar;
    public EXPBar expBar;
    private string[] areaNames = {"Corrupt Swamp", "Scorched Plains", "Tormented Valley"};
    private int monsterSpawnIndex;
    private int evasionIndex;
    private int tieIndex;
    private int itemDropIndex;
    private bool firstMove;
    private int attackDamage;
    private bool playersTurn;
    private bool bossMonster;
    private bool monsterPresent;
    private string hpAmount;
    private float waitTime;
    private double speedAdvantage;
    private int firstTurnIndex;
    private float pTurn;
    private int totalSpeed;
    private bool isPaused;

    public void setSpeed(float speed){
        if(speed == 0){
            isPaused = !isPaused;
        }
        else{
            isPaused = false;
            waitTime = speed;
        }
    }

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        invManager = GameObject.FindObjectOfType<InventoryManager>().GetComponent<InventoryManager>();
        playerHealthBar = GameObject.FindObjectOfType<PlayerHealthBar>();
        monsterHealthBar = GameObject.FindObjectOfType<MonsterHealthBar>();
        playerChar = GameObject.Find("PlayerChar").GetComponent<PlayerCharacter>().playerCharacter;
        Destroy(GameObject.Find("PlayerChar"));
        //playerChar = new Character("Name", 10, 10, 10, 10, 10, "PHYSICAL", 0, 0, 0);
        eventLog = GetComponent<GameLog>();
        expBar = GameObject.FindObjectOfType<EXPBar>();
        nameBox = GameObject.Find("CharacterNameText");
        areaTextBox = GameObject.Find("AreaNameText");
        areaKillBox = GameObject.Find("MonsterKillCount");
        hpTextBox = GameObject.Find("HPStat");
        attackTextBox = GameObject.Find("AttackStat");
        defenseTextBox = GameObject.Find("DefenseStat");
        speedTextBox = GameObject.Find("SpeedStat");
        luckTextBox = GameObject.Find("LuckStat");
        monsterNameTextBox = GameObject.Find("MonsterNameText");
        nameText = nameBox.GetComponent<Text>();
        hpAmountText = hpTextBox.GetComponent<Text>();
        attackAmountText = attackTextBox.GetComponent<Text>();
        defenseAmountText = defenseTextBox.GetComponent<Text>();
        speedAmountText = speedTextBox.GetComponent<Text>();
        luckAmountText = luckTextBox.GetComponent<Text>();
        areaText = areaTextBox.GetComponent<Text>();
        areaKillCountText = areaKillBox.GetComponent<Text>();
        monsterNameText = monsterNameTextBox.GetComponent<Text>();
        nameText.text = playerChar.characterName;
        areaText.text = areaNames[playerChar.areaNumber];
        areaKillCountText.text = playerChar.areaKillCount.ToString();
        eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> have arrived at the <b><color=#FF0095>" + areaNames[playerChar.areaNumber].ToUpper() + "</color></b>.");
        eventLog.AddEvent("As <b><color=#FFBD00>YOU</color></b> enter the <b><color=#FF0095>" + areaNames[playerChar.areaNumber].ToUpper() + "</color></b>, <b><color=#FFBD00>YOU</color></b> feel the eyes of many foe stalking <b><color=#FFBD00>YOU</color></b>.");
        waitTime = 1f;
        isPaused = false;
        StartCoroutine(SpawnMonsters());
    }
    
    IEnumerator SpawnMonsters() {
        while(true){
            yield return new WaitForSeconds(waitTime);
            firstMove = true;
            monsterSpawnIndex = Random.Range(0, 25);
            if(playerChar.areaNumber == 0){
                if(playerChar.areaKillCount == 25){
                    spawnedMonster = new Monster(MonsterPool.areaOneBoss);
                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> are stopped by a large foe. It's the <b>AREA BOSS</b>, the <b><color=#A87AFF>" + spawnedMonster.monsterName.ToUpper() + "</color></b>!");
                    bossMonster = true;
                }
                else{
                    spawnedMonster = new Monster(MonsterPool.areaOneMonsters[monsterSpawnIndex]);
                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> encounter a <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color>.");
                    bossMonster = false;
                }
            }
            if(playerChar.areaNumber == 1){
                if(playerChar.areaKillCount == 25){
                    spawnedMonster = new Monster(MonsterPool.areaTwoBoss);
                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> are stopped by a large foe. It's the <b>AREA BOSS</b>, the <b><color=#A87AFF>" + spawnedMonster.monsterName.ToUpper() + "</color></b>!");
                    bossMonster = true;
                }
                else{
                    spawnedMonster = new Monster(MonsterPool.areaTwoMonsters[monsterSpawnIndex]);
                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> encounter a <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color>.");
                    bossMonster = false;
                }
            }
            if(playerChar.areaNumber == 2){
                if(playerChar.areaKillCount == 25){
                    spawnedMonster = new Monster(MonsterPool.areaThreeBoss);
                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> are stopped by a large foe. It's the <b>AREA BOSS</b>, the <b><color=#A87AFF>" + spawnedMonster.monsterName.ToUpper() + "</color></b>!");
                    bossMonster = true;
                }
                else{
                    spawnedMonster = new Monster(MonsterPool.areaThreeMonsters[monsterSpawnIndex]);
                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> encounter a <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color>.");
                    bossMonster = false;
                }
            }
            monsterNameText.text = spawnedMonster.monsterName;
            monsterHealthBar.SetMonsterMaxHealth(spawnedMonster.hp);
            monsterHealthBar.SetDifficulty(spawnedMonster.difficulty);
            monsterPresent = true;
            yield return new WaitForSeconds(waitTime);
            while(monsterPresent){
                // Pause check
                if(isPaused){
                    eventLog.AddEvent("<b>Paused...</b>");
                    while(isPaused){
                        yield return new WaitForSeconds(0.5f);
                    }
                    eventLog.AddEvent("<b>Unpaused</b>");
                }

                // Regen
                if(playerChar.hp < playerHealthBar.GetMaxHealth()){
                    playerChar.hp += 1;
                    playerHealthBar.SetHealth(playerChar.hp);
                }
                yield return new WaitForSeconds(waitTime / 2f);

                playerChar.hp = playerHealthBar.GetHealth();
                playerChar.attack = int.Parse(attackAmountText.text);
                playerChar.defense = int.Parse(defenseAmountText.text);
                playerChar.speed = int.Parse(speedAmountText.text);
                playerChar.luck = int.Parse(luckAmountText.text);
                totalSpeed = playerChar.speed + spawnedMonster.speed;
                totalSpeed += (int)((float)totalSpeed * 0.25);
                // first move
                if(firstMove){
                    firstMove = false;
                    firstTurnIndex = Random.Range(0, totalSpeed + 1);
                    pTurn = (float)playerChar.speed / (float)totalSpeed;
                    if(firstTurnIndex <= (int)(pTurn * totalSpeed)){
                        evasionIndex = Random.Range(0, totalSpeed + 1);
                        speedAdvantage = playerChar.speed / totalSpeed;
                        if(evasionIndex < (speedAdvantage * totalSpeed)){
                            attackDamage = playerChar.Attack(spawnedMonster);
                            spawnedMonster.hp -= attackDamage;
                            monsterHealthBar.SetHealth(spawnedMonster.hp);
                            eventLog.AddEvent("With speed, <b><color=#FFBD00>YOU</color></b> attack the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> and deal <b>" + attackDamage.ToString() + " <color=#00CBF6>" + playerChar.attackType + " DAMAGE.</color></b>");
                        }
                        else{
                            eventLog.AddEvent("With speed, the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> <b><color=#88FF00>DODGES</color></b> <b><color=#FFBD00>YOUR</color></b> attack.");
                        }
                        playersTurn = false;
                    }
                    else{
                        evasionIndex = Random.Range(0, totalSpeed + 1);
                        speedAdvantage = spawnedMonster.speed / totalSpeed;
                        if(evasionIndex < (speedAdvantage * totalSpeed)){
                            attackDamage = playerChar.takeDamage(spawnedMonster);
                            playerChar.hp -= attackDamage;
                            playerHealthBar.SetHealth(playerChar.hp);
                            eventLog.AddEvent("With speed, the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> attacks <b><color=#FFBD00>YOU</color></b> and deals <b>" + attackDamage.ToString() + " <color=#00CBF6>" + spawnedMonster.monsterAttackType() + " DAMAGE.</color></b>");
                        }
                        else{
                            eventLog.AddEvent("With speed, <b><color=#FFBD00>YOU</color></b> <b><color=#88FF00>DODGE</color></b> the attack of the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color>.");
                        }
                        playersTurn = true;
                    }
                }
                // moves after the first
                else{
                    if(playersTurn){
                        evasionIndex = Random.Range(0, totalSpeed);
                        if(evasionIndex > (playerChar.speed / 3)){
                            attackDamage = playerChar.Attack(spawnedMonster);
                            spawnedMonster.hp -= attackDamage;
                            monsterHealthBar.SetHealth(spawnedMonster.hp);
                            eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> attack the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> and deal <b>" + attackDamage.ToString() + " <color=#00CBF6>" + playerChar.attackType + " DAMAGE.</color></b>");
                        }
                        else{
                            eventLog.AddEvent("With speed, the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> <b><color=#88FF00>DODGES</color></b> <b><color=#FFBD00>YOUR</color></b> attack.");
                        }
                        playersTurn = false;
                    }
                    else{
                        evasionIndex = Random.Range(0, totalSpeed);
                        if(evasionIndex > (spawnedMonster.speed / 3)){
                            attackDamage = playerChar.takeDamage(spawnedMonster);
                            playerChar.hp -= attackDamage;
                            playerHealthBar.SetHealth(playerChar.hp);
                            eventLog.AddEvent("The <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> attacks <b><color=#FFBD00>YOU</color></b> and deals <b>" + attackDamage.ToString() + " <color=#00CBF6>" + spawnedMonster.monsterAttackType() + " DAMAGE.</color></b>");
                        }
                        else{
                            eventLog.AddEvent("With speed, <b><color=#FFBD00>YOU</color></b> <b><color=#88FF00>DODGE</color></b> the attack of the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color>.");
                        }
                        playersTurn = true;
                    }
                }
                // end of move
                yield return new WaitForSeconds(waitTime);
                if(spawnedMonster.hp < 1){
                    eventLog.AddEvent("The <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> falls and stops moving. <b>" + spawnedMonster.experience.ToString() + " <color=#00FFA6>EXP</color></b> points gained.");
                    if(bossMonster){
                        eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> have cleared the <b><color=#FF0095>" + areaNames[playerChar.areaNumber].ToUpper() + "</color></b> and decide to move on with <b><color=#FFBD00>YOUR</color></b> travels.");
                        yield return new WaitForSeconds(2 * waitTime);
                        itemDropIndex = Random.Range(0, 100);
                        if(itemDropIndex < 15){
                            if(invManager.isThereRoom()){
                                invManager.SpawnItem(playerChar, spawnedMonster);
                                eventLog.AddEvent("<b><color=#FFBD00>YOU</color> found an ITEM in the remains of the monster.</b>");
                            }
                            else{
                                eventLog.AddEvent("<b><color=#FFBD00>YOU'RE</color> BACKPACK is full and cannot fit anymore dropped items.</b>");
                            }
                        }
                        playerChar.areaNumber += 1;
                        if(playerChar.areaNumber == 0){
                            areaText.text = "<color=#00A215>" + areaNames[playerChar.areaNumber] + "</color>";
                        }
                        else if(playerChar.areaNumber == 1){
                            areaText.text = "<color=#A27200>" + areaNames[playerChar.areaNumber] + "</color>";
                        }
                        else{
                            areaText.text = "<color=#660003>" + areaNames[playerChar.areaNumber] + "</color>";
                        }
                        eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> enter the <b><color=#FF0095>" + areaNames[playerChar.areaNumber].ToUpper() + "</color></b> and feel the eyes of many foe stalking <b><color=#FFBD00>YOU</color></b>.");
                        playerChar.areaKillCount = 0;
                        areaKillCountText.text = playerChar.areaKillCount.ToString();
                    }
                    else{
                        itemDropIndex = Random.Range(0, 100);
                        if(itemDropIndex < (int)((float)playerChar.luck * 0.15f)){
                            if(invManager.isThereRoom()){
                                bool didItemSpawn = invManager.SpawnItem(playerChar, spawnedMonster);
                                if(didItemSpawn){
                                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color> found an ITEM in the remains of the monster.</b>");
                                }
                                else{
                                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color> found an ITEM but left it, uninterested.</b>");
                                }
                            }
                            else{
                                eventLog.AddEvent("<b><color=#FFBD00>YOU'RE</color> BACKPACK is full and cannot fit anymore dropped items.</b>");
                            }
                        }
                    }
                    //playerChar.experience += spawnedMonster.experience;
                    expBar.AddEXP(spawnedMonster.experience);
                    playerChar.areaKillCount += 1;
                    areaKillCountText.text = playerChar.areaKillCount.ToString();
                    monsterPresent = false;
                }
                if(playerChar.hp < 1){
                    if(bossMonster){
                        eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> succumb to the attacks of the <b>AREA BOSS</b>, the <b><color=#A87AFF>" + spawnedMonster.monsterName.ToUpper() + "</color></b>, and fall. Area kill count has been reset.");
                    }
                    else{
                        eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> succumb to the attacks of the <color=#FF6060>" + spawnedMonster.monsterName.ToUpper() + "</color> and fall. Area kill count has been reset.");
                    }
                    yield return new WaitForSeconds(2 * waitTime);
                    eventLog.AddEvent("<b><color=#FFBD00>YOU</color></b> <b>have awoken after some time and decide to keep moving.</b>");
                    eventLog.AddEvent("<b><color=#FFBD00>YOU'RE</color></b> <b>determined to defeat the dangerous monster reported to be in this area.</b>");
                    yield return new WaitForSeconds(2 * waitTime);
                    playerChar.hp = int.Parse(hpAmountText.text);
                    playerHealthBar.FillHealth();
                    playerChar.areaKillCount = 0;
                    areaKillCountText.text = playerChar.areaKillCount.ToString();
                    monsterPresent = false;
                }
            }
        }
    }
}