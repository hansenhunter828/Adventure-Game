﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        int scene = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_0;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M) //Red Button Press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2 || scene == 3 || scene == 4 || scene == 5 || scene == 6) { scene = 8; }
                else if (scene == 7) { scene = 99; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 10) { scene = 11; }

                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 15) { scene = 18; }
                else if (scene == 16) { scene = 18; }
                else if (scene == 17) { scene = 16; }
                else if (scene == 18) { scene = 20; }
                else if (scene == 19) { scene = 99; }
                else if (scene == 20) { scene = 99; }
                else if (scene == 21) { scene = 23; }
                else if (scene == 23) { scene = 24; }
                else if (scene == 24)
                {
                    Random ranGen = new Random();
                    int ranNum = ranGen.Next(1, 101);

                    if (ranNum <= 15) { scene = 27; }
                    else { scene = 30; }; 
                }
                else if (scene == 25) { scene = 99; }
                else if (scene == 26) { scene = 30; }
                else if (scene == 27) { scene = 28; }
                else if (scene == 28) { scene = 27; }
                else if (scene == 29) { scene = 27; }
                else if (scene == 30) { scene = 32; }

                else if (scene == 31) { scene = 32; }
                else if (scene == 32) { scene = 33; }
                else if (scene == 33) { scene = 35; }
                else if (scene == 35) { scene = 99; }
                else if (scene == 37) { scene = 99; }
                else if (scene == 38) { scene = 12; }

                else if (scene == 99) { scene = 0; }
            }
            else if (e.KeyCode == Keys.N)  //Yellow Button Press
            {
                if (scene == 0) { }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2 || scene == 3 || scene == 4 || scene == 5 || scene == 6) { scene = 9; }
                else if (scene == 9) { scene = 11; }
            }
            else if (e.KeyCode == Keys.B)  //Blue Button Press
            {
                if (scene == 0) { }
                else if (scene == 1) { scene = 6; }
                else if (scene == 2 || scene == 3 || scene == 4 || scene == 5 || scene == 6) { scene = 7; }
                else if (scene == 8) { scene = 11; }
                else if (scene == 11) { scene = 21; }
                else if (scene == 12) { scene = 38; }

                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 17; }
                else if (scene == 18) { scene = 19; }
                else if (scene == 19) { scene = 99; }

                else if (scene == 21) { scene = 22; }
                else if (scene == 22) { scene = 99; }
                else if (scene == 23) { scene = 37; }
                else if (scene == 24) { scene = 25; }
                else if (scene == 25) { scene = 99; }
                else if (scene == 26) { scene = 31; }
                else if (scene == 27) { scene = 29; }
                else if (scene == 29) { scene = 30; }
                else if (scene == 32) { scene = 34; }
                else if (scene == 33) { scene = 36; }
                else if (scene == 34) { scene = 99; }
                else if (scene == 36) { scene = 99; }
                else if (scene == 99) { scene = 100; }
            }
            else if (e.KeyCode == Keys.Space) //Green Button Press
            {
                if (scene == 0) { }
                else if (scene == 1) { scene = 5; }
            }
            else if (e.KeyCode == Keys.V)  //Brown Button Press
            {
                if (scene == 0) { }
                else if (scene == 1) { scene = 4; }
            }
            else if (e.KeyCode == Keys.P) 
            { 
                if (scene == 0) { scene = 39; } 
            }

            SoundPlayer vomit = new SoundPlayer(Properties.Resources.vomit);
            SoundPlayer victoryCry = new SoundPlayer(Properties.Resources.victory_cry);
            SoundPlayer hey = new SoundPlayer(Properties.Resources.hey);
            SoundPlayer battleCry = new SoundPlayer(Properties.Resources.battleCry);
            SoundPlayer death = new SoundPlayer(Properties.Resources.death);
            SoundPlayer orcGrowl = new SoundPlayer(Properties.Resources.orc_noise);
            SoundPlayer thankYou = new SoundPlayer(Properties.Resources.thank_you);

            switch (scene) 
            {
                case 0:
                    break;
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_1;

                    outputLabel.Text = "Hey who are you? Your not on the list says a guard.";
                    outputLabel.Text += "\nWhat species are you?";

                    redLabel.Text = "Dark Elf";
                    blueLabel.Text = "Orc";
                    yellowLabel.Text = "Argonian";
                    greenLabel.Text = "Khajiit";
                    brownLabel.Text = "Nord";
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_2_6;
                    vomit.Play();

                    outputLabel.Text = "You better not use any magic to get out of this you witch says the guard. What do you do?";

                    redLabel.Text = "My my, you are looking so good today kind sir.";
                    blueLabel.Text = "Shut up! Your a no good nord!";
                    yellowLabel.Text = "(Remain Silent)";
                    greenLabel.Text = "";
                    brownLabel.Text = "";
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_2_6;
                    vomit.Play();

                    outputLabel.Text = "Argonian ey? what are you doing so far from the waters?";

                    redLabel.Text = "My my, you are looking so good today kind sir.";
                    blueLabel.Text = "Shut up! Your a no good nord!";
                    yellowLabel.Text = "(Remain Silent)";
                    greenLabel.Text = "";
                    brownLabel.Text = "";
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_2_6;

                    outputLabel.Text = "Im sorry brother you have to go this way";

                    redLabel.Text = "My my, you are looking so good today kind sir.";
                    blueLabel.Text = "Shut up! Your a no good nord!";
                    yellowLabel.Text = "(Remain Silent)";
                    greenLabel.Text = "";
                    brownLabel.Text = "";
                    break;
                case 5:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_2_6;
                    vomit.Play();

                    outputLabel.Text = "Your a khajit you thief! you deserve this";

                    redLabel.Text = "My my, you are looking so good today kind sir.";
                    blueLabel.Text = "Shut up! Your a no good nord!";
                    yellowLabel.Text = "(Remain Silent)";
                    greenLabel.Text = "";
                    brownLabel.Text = "";
                    break;
                case 6:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_2_6;
                    vomit.Play();

                    outputLabel.Text = "An orc? weve been at war with your people for years. Your one less to deal with now says the guard. What do you do?";

                    redLabel.Text = "My my, you are looking so good today kind sir.)";
                    blueLabel.Text = "Shut up! Your a no good nord!";
                    yellowLabel.Text = "(Remain Silent)";
                    greenLabel.Text = "";
                    brownLabel.Text = "";
                    break;
                case 7:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_7;
                    SoundPlayer laugh = new SoundPlayer(Properties.Resources.laugh);
                    laugh.Play();

                    outputLabel.Text = "Haha very  funny your first now.";
                    
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 8:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_8_and_9;
                    SoundPlayer groan = new SoundPlayer(Properties.Resources.groan);
                    groan.Play();

                    outputLabel.Text = "Thanks but your still on the list. Get in line.";

                    redLabel.Text = "Please no! I dont want to die.";
                    blueLabel.Text = "(Remain Silent)";

                    yellowLabel.Text = "";
                    break;
                case 9:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_8_and_9;
                    SoundPlayer hmmm = new SoundPlayer(Properties.Resources.hmmm);
                    hmmm.Play();

                    outputLabel.Text = "Your a quite one ey?(Press M to continue)";
                    
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 10:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_8_and_9;
                    SoundPlayer grunt = new SoundPlayer(Properties.Resources.grunt);
                    grunt.Play();

                    outputLabel.Text = "Save it for the block the guards tells you.";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 11:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_11;
                    battleCry.Play();

                    outputLabel.Text = "An orc army attacks the compound. The guards get distracted and give you time to escape. What do you do?";

                    redLabel.Text = "Join the nords";
                    blueLabel.Text = "Join the orcs";
                    yellowLabel.Text = "";
                    break;
                case 12:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_12;
                    hey.Play();

                    outputLabel.Text = "Look I know you were about to be executed but Ill pardon you if you aid us says a guard. What do you do?";

                    redLabel.Text = "Yes I will help you defeat the orcs.";
                    blueLabel.Text = "No I will never accept your pardon";
                    break;
                case 13:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_12;
                    thankYou.Play();

                    outputLabel.Text = "Thank you Ill make sure my higher ups know what you have done. We must hurry to aid the men at the front gate";
                    outputLabel.Text += " You arrive at the front gate. Do you help the men on the wall or do you aid the men on the ground?";

                    redLabel.Text = "Help them men ground";
                    blueLabel.Text = "Help the men on the wall";
                    break;
                case 14:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_14;
                    SoundPlayer killThemAll = new SoundPlayer(Properties.Resources.kill_them_all);
                    killThemAll.Play();

                    outputLabel.Text = "A soldier hands you a bow and tells you to start shooting the orcs. Do you take time to aim or fire as fast as you can";

                    redLabel.Text = "Hit your target";
                    blueLabel.Text = "Fire willy nilly";
                    break;
                case 15:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_15;
                    victoryCry.Play();

                    outputLabel.Text = "You run to help the soldiers on the ground and after tons of hacking and slashing the orc army finally retreats";
                    outputLabel.Text = "Press M to continue";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 16:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_16;
                    victoryCry.Play();

                    outputLabel.Text = "You take time to aim and you manage to fend of the orc attack(press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 17:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_17;
                    hey.Play();

                    outputLabel.Text = "HEY take your time to aim a soldier yells at you(press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 18:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_19;
                    hey.Play();

                    outputLabel.Text = "The soldier that promised you pardon walks up to you and says good job. Now i can offer you two things.";
                    outputLabel.Text += "The first one is the pardon I promised you and the other one is the pardon and an offer to join our army.";
                    outputLabel.Text += "What do you do?";

                    redLabel.Text = "I would never join your army!";
                    blueLabel.Text = "Yes I would be happy to join your army!";
                    break;
                case 19:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_18;
                    SoundPlayer stab = new SoundPlayer(Properties.Resources.stab);
                    stab.Play();

                    outputLabel.Text = "Thats great to hear but I lied I can never let a criminal scum like you live he says as you feel something cold plunge into you stomach as you fall over and die";
                    outputLabel.Text += "Press M to continue";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 20:
                    pictureBox1.BackgroundImage = Properties.Resources.adventurea_game_scene_20;
                    SoundPlayer ok = new SoundPlayer(Properties.Resources.ok);
                    ok.Play();

                    outputLabel.Text = "well that sucks, well Im a man of my word you have been pardoned just make sure you dont do anything else bad";
                    outputLabel.Text += "Or we will be meeting again";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 21:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_21;
                    orcGrowl.Play();

                    outputLabel.Text = "You see an orc brutally cut down the executioner down and then he says to you are you friend or foe?";

                    redLabel.Text = "I am on your side";
                    blueLabel.Text = "I am not your friend! In fact I am your worst nigtmare";
                    break;
                case 22:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_18;
                    death.Play();

                    outputLabel.Text = "The orc takes his axe chops your head off(Press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 23:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_21;
                    battleCry.Play();
                    outputLabel.Text = "Good he says he hands you a spare battle axe and tells you to aid them in defeating the nords. What do you do?";

                    redLabel.Text = "Fight the nords";
                    blueLabel.Text = "Run away";
                    break;
                case 37:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_18;
                    death.Play();

                    outputLabel.Text = "As you start running away you feel a sharp pain in your back as you fall to the ground and die(Press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 24:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_21;
                    orcGrowl.Play();

                    outputLabel.Text = "You fight with the orcs hacking and slashing at every nord you see until the battle is won.";
                    outputLabel.Text = "You fight pretty well. Would you like to join our army?";

                    redLabel.Text = "Yes I would love to!";
                    blueLabel.Text = "No I would hate to.";
                    break;
                case 25:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_21;
                    orcGrowl.Play();

                    outputLabel.Text = "Ah well ok then but you really are a great fighter.";
                    outputLabel.Text += "I wish you well and if you ever want to join we would be happy to recruit you(Press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 26:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_21;
                    orcGrowl.Play();

                    outputLabel.Text = "Thats great hear lets get you some armor for out next raid on the next nord compound";
                    outputLabel.Text += "You get your armor and you head off for the next battle do you small talk with some orcs or stay quite?";

                    redLabel.Text = "Small talk with some orcs";
                    blueLabel.Text = "Dont talk to the orcs";
                    break;
                case 27:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_ame_scene_27;
                    SoundPlayer wolf = new SoundPlayer(Properties.Resources.wolf);
                    wolf.Play();

                    outputLabel.Text = "You party gets ambushed by wolves do you attack them or tend the wounded?";

                    redLabel.Text = "Attack the wolves";
                    blueLabel.Text = "Tend the wounded";
                    break;
                case 28:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_28;
                    SoundPlayer sword = new SoundPlayer(Properties.Resources.sword);
                    sword.Play();

                    outputLabel.Text = "You attack and slaughter the pack of wolves and let the wounded orc bleed out and die.(Press M to continue";

                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 29:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_29;
                    thankYou.Play();

                    outputLabel.Text = "You tend the wounded orc and he thanks you.(Press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 30:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_ame_scene_30;
                    SoundPlayer hmph = new SoundPlayer(Properties.Resources.hmph);
                    hmph.Play();

                    outputLabel.Text = "You try to talk to the orcs but none of them seem to want to talk so you spend the travel alone.(Press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 31:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_ame_scene_31;
                    SoundPlayer whistle = new SoundPlayer(Properties.Resources.whistle);
                    whistle.Play();

                    outputLabel.Text = "You stay quite the entire travel(Press M to continue";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 32:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_32;

                    outputLabel.Text = "You see the compound on the horizon and all of the orcs start charging. Do you charge with them or stay behind?";

                    redLabel.Text = "I charge at the front gate full speed";
                    blueLabel.Text = "I stay behind and let the orcs go first";
                    break;
                case 33:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_33;
                    battleCry.Play();

                    outputLabel.Text = "As you charge at the compound you see the air fill with arrows and you see your allies falling until your the last one alive";
                    outputLabel.Text += "\nYou see nords surrounding you do you fight them or surrender?";

                    redLabel.Text = "I surrender please dont hurt me";
                    blueLabel.Text = "I will never surrender";
                    break;
                case 34:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_34;

                    outputLabel.Text = "as you stay behind and watch the charge you hear a growl and as you turn around you see a hungry saber cat.(Press M to continue)";
                    SoundPlayer saberCat = new SoundPlayer(Properties.Resources.saberCat);
                    saberCat.Play();

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 35:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_1;
                    SoundPlayer soldierMarch = new SoundPlayer(Properties.Resources.soldierMarch);
                    soldierMarch.Play();

                    outputLabel.Text = "you surrender to the nords and notice that you are in the same position you were when the orcs saved you but";
                    outputLabel.Text += "\nthis time you know no one will save you. The executioner chops your head off and you die(Press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 36:
                    pictureBox1.BackgroundImage = Properties.Resources.Adventure_game_scene_18;
                    battleCry.Play();

                    outputLabel.Text = "You yell I will never surrender as you get hit with arrow after arrow after arrow and you die(Press M to continue)";

                    blueLabel.Text = "";
                    redLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 38:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_99;
                    outputLabel.Text = "Only one mission is available in this demo.Please buy the full game to get the full experience(Press M to continue";
                    break;
                case 39:
                    pictureBox1.BackgroundImage = Properties.Resources.adventire_game_scene_39;

                    outputLabel.Text = "";
                    linkLabel1.Text = "https://www.youtube.com/watch?v=d1YBv2mWll0";
                    break;
                case 99:
                    pictureBox1.BackgroundImage = Properties.Resources.adventure_game_scene_99;
                    thankYou.Play();

                    outputLabel.Text = "Thank you for playing! Do you want to play again?";

                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 100:
                    Application.Exit();
                    break;




            }
        }
    }
}
