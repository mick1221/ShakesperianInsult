using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Shakesperian_insult_generator
{
    public partial class Form1 : Form
    {
        //arrays for storing all three [arts of insults
        string[] column1;
        string[] column2;
        string[] column3;

        //store previously used insult indexes
        int previous1, previous2, previous3;

        private void Form1_Load(object sender, EventArgs e)
        {
            //intialize insult arrays
            column1 = new string[50]{ "artless","bawdy", "beslubbering", "bootless","churlish","cockered","clouted","craven","currish","dankish","dissembling","droning",
                    "errant","fawning","fobbing","froward","frothy","gleeking","goatish","gorbellied","imperrinent","infectious","jarring","loggerheaded","lumpish","mammering",
                    "mangled","mewling","paunchy","pribbling","puking","puny","qualling","rank","reeky","roguish","ruttish","saucy","spleeny","spongy","surly","tottering",
                    "unmuzzled","vain","venomed","villainous","warped","wayward","weedy","yeasty"};

            column2 = new string[50] {"base-court","bat-fowling","beef-witted","beetle-headed","boil-brained","clapper-clawed","clay-brained","common-kissing","crook-patted",
                    "dismal-dreaming","dizzy-eyed","doghearted","dread-bolted","earth-vexing","elf-skinned","fat-kidneyed","fen-sucked","flap-mouthed","fly-bitten","folly-fallen",
                    "fool-born","full-gorged","guts-griping","half-faced","hasty-witted","hedge-born","hell-hated","idle-headed","ill-breeding","ill-nurtured","knotty-pated",
                    "milk-livered","motley-minded","onion-minded","plume-plucked","pottle-deep","pox-marked","reeling-ripe","rough-hewn","rude-growing","rump-fed","shard-borne",
                    "sheep-biting","spur-galled","swag-bellied","tardy-gaited","tickle-brained","toad-spotted","unchin-snouted","weather-bitten"};

            column3 = new string[50] {"apple-john","baggage","barnacle","bladder","boar-pig","bugbear","bum-bailey","canker-blossom","clack-dish","clotpole","coxcomb","codpiece",
                    "death-token","dewberry","flap-dragon","flax-wench","flirt-gill","foot-licker","fustilarian","giglet","gudgeon","haggard","harpy","hedge-pig","horn-beast","hugger-mugger",
                    "joithead","lewdster","lout","maggot-pie","malt-worm","mammet","measle","minnow","miscreant","moldwarp","mumble-news","nut-hook","pigeon-egg","pignut",
                    "puttock","pumpion","ratsbane","scut","skainsmate","strumpet","varlot","vassal","whey-face","wagtail"};
        }

        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int current1;
            int current2;
            int current3;
            Random rand = new Random();
            do
            {
                current1 = rand.Next(50);
                current2 = rand.Next(50);
                current3 = rand.Next(50);
            } while (current1 == previous1 | current2 == previous2 | current3 == previous3);
            string output = column1[current1] + " " + column2[current2] + " " + column3[current3];
            previous1 = current1;
            previous2 = current2;
            previous3 = current3;

            insultOut.Text = output;
        }
    }
}
