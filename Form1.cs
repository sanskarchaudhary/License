// Decompiled with JetBrains decompiler
// Type: License.Form1
// Assembly: License, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6FD56FB-B46D-4870-BCF7-E8D83C1735D0
// Assembly location: License.dll inside C:\Users\sansk\Desktop\(Trial) Crypto Whale$\(Trial) Crypto Whale$.exe)

using License.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace License
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    private Form2 _form2Instance;
    private bool isGenerating;
    private int maxLines;
    private List<string> wordList;
    private int lineCount;
    private int lineCountListBox2;
    private List<Tuple<string, string>> linkValueSymbolList;
    private List<Tuple<string, string>> secondTupleList;

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.MouseClick += new MouseEventHandler(this.Form1_MouseClick);
      this._form2Instance = (Form2) null;
      this.backgroundWorker = new BackgroundWorker();
      this.isGenerating = false;
      this.maxLines = 11;
      List<string> stringList = new List<string>();
      stringList.Add("abandon");
      stringList.Add("absent");
      stringList.Add("absorb");
      stringList.Add("abstract");
      stringList.Add("abuse");
      stringList.Add("accident");
      stringList.Add("accuse");
      stringList.Add("acoustic");
      stringList.Add("acquire");
      stringList.Add("actual");
      stringList.Add("addict");
      stringList.Add("adjust");
      stringList.Add("afford");
      stringList.Add("afraid");
      stringList.Add("again");
      stringList.Add("age");
      stringList.Add("agree");
      stringList.Add("ahead");
      stringList.Add("aim");
      stringList.Add("airport");
      stringList.Add("aisle");
      stringList.Add("alarm");
      stringList.Add("alcohol");
      stringList.Add("alert");
      stringList.Add("alien");
      stringList.Add("all");
      stringList.Add("alone");
      stringList.Add("alter");
      stringList.Add("always");
      stringList.Add("amused");
      stringList.Add("ancient");
      stringList.Add("angle");
      stringList.Add("animal");
      stringList.Add("ankle");
      stringList.Add("announce");
      stringList.Add("any");
      stringList.Add("apart");
      stringList.Add("appear");
      stringList.Add("apple");
      stringList.Add("approve");
      stringList.Add("arctic");
      stringList.Add("arm");
      stringList.Add("armor");
      stringList.Add("around");
      stringList.Add("arrange");
      stringList.Add("arrive");
      stringList.Add("art");
      stringList.Add("artist");
      stringList.Add("artwork");
      stringList.Add("ask");
      stringList.Add("asthma");
      stringList.Add("athlete");
      stringList.Add("atom");
      stringList.Add("attack");
      stringList.Add("attend");
      stringList.Add("attitude");
      stringList.Add("auction");
      stringList.Add("audit");
      stringList.Add("autumn");
      stringList.Add("average");
      stringList.Add("avocado");
      stringList.Add("awake");
      stringList.Add("aware");
      stringList.Add("away");
      stringList.Add("awkward");
      stringList.Add("baby");
      stringList.Add("bachelor");
      stringList.Add("bacon");
      stringList.Add("bag");
      stringList.Add("bamboo");
      stringList.Add("bar");
      stringList.Add("beach");
      stringList.Add("bean");
      stringList.Add("beauty");
      stringList.Add("before");
      stringList.Add("begin");
      stringList.Add("behave");
      stringList.Add("believe");
      stringList.Add("below");
      stringList.Add("best");
      stringList.Add("betray");
      stringList.Add("beyond");
      stringList.Add("bid");
      stringList.Add("bike");
      stringList.Add("biology");
      stringList.Add("birth");
      stringList.Add("blade");
      stringList.Add("blame");
      stringList.Add("blast");
      stringList.Add("bleak");
      stringList.Add("bless");
      stringList.Add("blind");
      stringList.Add("blood");
      stringList.Add("blossom");
      stringList.Add("blouse");
      stringList.Add("blush");
      stringList.Add("boat");
      stringList.Add("body");
      stringList.Add("boil");
      stringList.Add("bomb");
      stringList.Add("border");
      stringList.Add("boring");
      stringList.Add("box");
      stringList.Add("brain");
      stringList.Add("brave");
      stringList.Add("brick");
      stringList.Add("bridge");
      stringList.Add("bright");
      stringList.Add("bring");
      stringList.Add("bronze");
      stringList.Add("broom");
      stringList.Add("brother");
      stringList.Add("brush");
      stringList.Add("build");
      stringList.Add("bundle");
      stringList.Add("bunker");
      stringList.Add("bus");
      stringList.Add("business");
      stringList.Add("busy");
      stringList.Add("camp");
      stringList.Add("cancel");
      stringList.Add("canvas");
      stringList.Add("canyon");
      stringList.Add("captain");
      stringList.Add("car");
      stringList.Add("cart");
      stringList.Add("case");
      stringList.Add("cash");
      stringList.Add("castle");
      stringList.Add("cat");
      stringList.Add("caught");
      stringList.Add("cause");
      stringList.Add("cave");
      stringList.Add("celery");
      stringList.Add("census");
      stringList.Add("century");
      stringList.Add("cereal");
      stringList.Add("chalk");
      stringList.Add("chapter");
      stringList.Add("charge");
      stringList.Add("check");
      stringList.Add("cheese");
      stringList.Add("chef");
      stringList.Add("chicken");
      stringList.Add("chief");
      stringList.Add("child");
      stringList.Add("choice");
      stringList.Add("churn");
      stringList.Add("cigar");
      stringList.Add("cinnamon");
      stringList.Add("circle");
      stringList.Add("city");
      stringList.Add("clap");
      stringList.Add("clever");
      stringList.Add("clinic");
      stringList.Add("clip");
      stringList.Add("clock");
      stringList.Add("clog");
      stringList.Add("cloth");
      stringList.Add("clown");
      stringList.Add("clump");
      stringList.Add("coach");
      stringList.Add("coast");
      stringList.Add("coffee");
      stringList.Add("coin");
      stringList.Add("column");
      stringList.Add("comic");
      stringList.Add("concert");
      stringList.Add("conduct");
      stringList.Add("confirm");
      stringList.Add("consider");
      stringList.Add("copper");
      stringList.Add("corn");
      stringList.Add("cost");
      stringList.Add("country");
      stringList.Add("couple");
      stringList.Add("coyote");
      stringList.Add("cradle");
      stringList.Add("cram");
      stringList.Add("crane");
      stringList.Add("crawl");
      stringList.Add("cricket");
      stringList.Add("critic");
      stringList.Add("crop");
      stringList.Add("cross");
      stringList.Add("crouch");
      stringList.Add("crowd");
      stringList.Add("cruel");
      stringList.Add("cushion");
      stringList.Add("cute");
      stringList.Add("cycle");
      stringList.Add("dad");
      stringList.Add("damp");
      stringList.Add("danger");
      stringList.Add("dash");
      stringList.Add("debate");
      stringList.Add("decade");
      stringList.Add("december");
      stringList.Add("decide");
      stringList.Add("decline");
      stringList.Add("deer");
      stringList.Add("define");
      stringList.Add("defy");
      stringList.Add("degree");
      stringList.Add("deliver");
      stringList.Add("depart");
      stringList.Add("depth");
      stringList.Add("deputy");
      stringList.Add("desk");
      stringList.Add("develop");
      stringList.Add("device");
      stringList.Add("diagram");
      stringList.Add("diary");
      stringList.Add("dice");
      stringList.Add("diesel");
      stringList.Add("diet");
      stringList.Add("digital");
      stringList.Add("dilemma");
      stringList.Add("dinosaur");
      stringList.Add("direct");
      stringList.Add("disagree");
      stringList.Add("disease");
      stringList.Add("dismiss");
      stringList.Add("disorder");
      stringList.Add("dizzy");
      stringList.Add("doctor");
      stringList.Add("document");
      stringList.Add("dolphin");
      stringList.Add("domain");
      stringList.Add("draft");
      stringList.Add("drift");
      stringList.Add("drill");
      stringList.Add("drip");
      stringList.Add("drive");
      stringList.Add("drum");
      stringList.Add("dry");
      stringList.Add("duck");
      stringList.Add("dust");
      stringList.Add("dwarf");
      stringList.Add("eager");
      stringList.Add("earth");
      stringList.Add("easily");
      stringList.Add("east");
      stringList.Add("easy");
      stringList.Add("ecology");
      stringList.Add("economy");
      stringList.Add("edit");
      stringList.Add("eight");
      stringList.Add("electric");
      stringList.Add("elegant");
      stringList.Add("element");
      stringList.Add("elephant");
      stringList.Add("elevator");
      stringList.Add("emerge");
      stringList.Add("emotion");
      stringList.Add("enable");
      stringList.Add("enact");
      stringList.Add("endless");
      stringList.Add("enhance");
      stringList.Add("enjoy");
      stringList.Add("enough");
      stringList.Add("ensure");
      stringList.Add("enter");
      stringList.Add("entry");
      stringList.Add("equip");
      stringList.Add("erase");
      stringList.Add("erosion");
      stringList.Add("erupt");
      stringList.Add("estate");
      stringList.Add("ethics");
      stringList.Add("evoke");
      stringList.Add("evolve");
      stringList.Add("exact");
      stringList.Add("example");
      stringList.Add("excess");
      stringList.Add("exclude");
      stringList.Add("excuse");
      stringList.Add("execute");
      stringList.Add("exile");
      stringList.Add("expire");
      stringList.Add("explain");
      stringList.Add("expose");
      stringList.Add("extend");
      stringList.Add("eyebrow");
      stringList.Add("face");
      stringList.Add("faculty");
      stringList.Add("fade");
      stringList.Add("faith");
      stringList.Add("family");
      stringList.Add("fancy");
      stringList.Add("fashion");
      stringList.Add("father");
      stringList.Add("favorite");
      stringList.Add("federal");
      stringList.Add("fee");
      stringList.Add("female");
      stringList.Add("festival");
      stringList.Add("fetch");
      stringList.Add("fever");
      stringList.Add("fiber");
      stringList.Add("fiction");
      stringList.Add("field");
      stringList.Add("figure");
      stringList.Add("file");
      stringList.Add("film");
      stringList.Add("final");
      stringList.Add("find");
      stringList.Add("finger");
      stringList.Add("finish");
      stringList.Add("fire");
      stringList.Add("firm");
      stringList.Add("first");
      stringList.Add("fit");
      stringList.Add("flash");
      stringList.Add("flavor");
      stringList.Add("flee");
      stringList.Add("flip");
      stringList.Add("flock");
      stringList.Add("flower");
      stringList.Add("foam");
      stringList.Add("focus");
      stringList.Add("follow");
      stringList.Add("foot");
      stringList.Add("forget");
      stringList.Add("forward");
      stringList.Add("found");
      stringList.Add("fragile");
      stringList.Add("fresh");
      stringList.Add("friend");
      stringList.Add("frog");
      stringList.Add("front");
      stringList.Add("frost");
      stringList.Add("frown");
      stringList.Add("funny");
      stringList.Add("future");
      stringList.Add("gain");
      stringList.Add("galaxy");
      stringList.Add("gallery");
      stringList.Add("garment");
      stringList.Add("gather");
      stringList.Add("gaze");
      stringList.Add("general");
      stringList.Add("genius");
      stringList.Add("gentle");
      stringList.Add("genuine");
      stringList.Add("gesture");
      stringList.Add("ginger");
      stringList.Add("giraffe");
      stringList.Add("girl");
      stringList.Add("glare");
      stringList.Add("glide");
      stringList.Add("glimpse");
      stringList.Add("glory");
      stringList.Add("glove");
      stringList.Add("glow");
      stringList.Add("goose");
      stringList.Add("gorilla");
      stringList.Add("grab");
      stringList.Add("grant");
      stringList.Add("grit");
      stringList.Add("group");
      stringList.Add("grow");
      stringList.Add("guard");
      stringList.Add("guide");
      stringList.Add("guitar");
      stringList.Add("gym");
      stringList.Add("habit");
      stringList.Add("hair");
      stringList.Add("half");
      stringList.Add("happy");
      stringList.Add("harbor");
      stringList.Add("hard");
      stringList.Add("harvest");
      stringList.Add("hat");
      stringList.Add("hazard");
      stringList.Add("heavy");
      stringList.Add("height");
      stringList.Add("high");
      stringList.Add("hill");
      stringList.Add("hip");
      stringList.Add("hockey");
      stringList.Add("hole");
      stringList.Add("holiday");
      stringList.Add("hollow");
      stringList.Add("hood");
      stringList.Add("horn");
      stringList.Add("hospital");
      stringList.Add("host");
      stringList.Add("hotel");
      stringList.Add("hour");
      stringList.Add("hub");
      stringList.Add("huge");
      stringList.Add("hundred");
      stringList.Add("hurry");
      stringList.Add("hybrid");
      stringList.Add("idea");
      stringList.Add("idle");
      stringList.Add("ignore");
      stringList.Add("illness");
      stringList.Add("image");
      stringList.Add("immune");
      stringList.Add("impact");
      stringList.Add("impose");
      stringList.Add("improve");
      stringList.Add("include");
      stringList.Add("income");
      stringList.Add("increase");
      stringList.Add("indicate");
      stringList.Add("indoor");
      stringList.Add("inform");
      stringList.Add("initial");
      stringList.Add("inject");
      stringList.Add("inmate");
      stringList.Add("inner");
      stringList.Add("inside");
      stringList.Add("intact");
      stringList.Add("isolate");
      stringList.Add("item");
      stringList.Add("jacket");
      stringList.Add("jazz");
      stringList.Add("jealous");
      stringList.Add("jeans");
      stringList.Add("jelly");
      stringList.Add("join");
      stringList.Add("joy");
      stringList.Add("judge");
      stringList.Add("jump");
      stringList.Add("just");
      stringList.Add("kangaroo");
      stringList.Add("keep");
      stringList.Add("kick");
      stringList.Add("kidney");
      stringList.Add("kit");
      stringList.Add("kite");
      stringList.Add("kiwi");
      stringList.Add("knock");
      stringList.Add("label");
      stringList.Add("lady");
      stringList.Add("lake");
      stringList.Add("lamp");
      stringList.Add("later");
      stringList.Add("laundry");
      stringList.Add("lawsuit");
      stringList.Add("leaf");
      stringList.Add("leave");
      stringList.Add("left");
      stringList.Add("legal");
      stringList.Add("lemon");
      stringList.Add("lend");
      stringList.Add("length");
      stringList.Add("lesson");
      stringList.Add("letter");
      stringList.Add("level");
      stringList.Add("liar");
      stringList.Add("liberty");
      stringList.Add("license");
      stringList.Add("lift");
      stringList.Add("light");
      stringList.Add("lion");
      stringList.Add("list");
      stringList.Add("little");
      stringList.Add("lizard");
      stringList.Add("long");
      stringList.Add("lottery");
      stringList.Add("loud");
      stringList.Add("love");
      stringList.Add("loyal");
      stringList.Add("luggage");
      stringList.Add("lumber");
      stringList.Add("lunar");
      stringList.Add("lunch");
      stringList.Add("machine");
      stringList.Add("mad");
      stringList.Add("maid");
      stringList.Add("mail");
      stringList.Add("make");
      stringList.Add("mammal");
      stringList.Add("manage");
      stringList.Add("mandate");
      stringList.Add("mango");
      stringList.Add("manual");
      stringList.Add("marine");
      stringList.Add("marriage");
      stringList.Add("mask");
      stringList.Add("mass");
      stringList.Add("math");
      stringList.Add("matter");
      stringList.Add("maximum");
      stringList.Add("meadow");
      stringList.Add("measure");
      stringList.Add("meat");
      stringList.Add("melt");
      stringList.Add("member");
      stringList.Add("mercy");
      stringList.Add("merge");
      stringList.Add("merit");
      stringList.Add("merry");
      stringList.Add("mesh");
      stringList.Add("message");
      stringList.Add("middle");
      stringList.Add("mind");
      stringList.Add("minor");
      stringList.Add("misery");
      stringList.Add("miss");
      stringList.Add("mistake");
      stringList.Add("month");
      stringList.Add("moon");
      stringList.Add("moral");
      stringList.Add("motor");
      stringList.Add("mountain");
      stringList.Add("movie");
      stringList.Add("muffin");
      stringList.Add("mule");
      stringList.Add("museum");
      stringList.Add("music");
      stringList.Add("must");
      stringList.Add("mutual");
      stringList.Add("myself");
      stringList.Add("myth");
      stringList.Add("negative");
      stringList.Add("neglect");
      stringList.Add("neither");
      stringList.Add("nephew");
      stringList.Add("nerve");
      stringList.Add("net");
      stringList.Add("network");
      stringList.Add("never");
      stringList.Add("news");
      stringList.Add("next");
      stringList.Add("nice");
      stringList.Add("night");
      stringList.Add("noise");
      stringList.Add("nominee");
      stringList.Add("notable");
      stringList.Add("notice");
      stringList.Add("now");
      stringList.Add("nurse");
      stringList.Add("nut");
      stringList.Add("oblige");
      stringList.Add("occur");
      stringList.Add("october");
      stringList.Add("odor");
      stringList.Add("olympic");
      stringList.Add("omit");
      stringList.Add("once");
      stringList.Add("onion");
      stringList.Add("online");
      stringList.Add("opera");
      stringList.Add("option");
      stringList.Add("orange");
      stringList.Add("orbit");
      stringList.Add("orchard");
      stringList.Add("organ");
      stringList.Add("other");
      stringList.Add("outdoor");
      stringList.Add("output");
      stringList.Add("oxygen");
      stringList.Add("pact");
      stringList.Add("panda");
      stringList.Add("panic");
      stringList.Add("panther");
      stringList.Add("paper");
      stringList.Add("parade");
      stringList.Add("parent");
      stringList.Add("parrot");
      stringList.Add("patch");
      stringList.Add("pause");
      stringList.Add("pave");
      stringList.Add("payment");
      stringList.Add("peanut");
      stringList.Add("peasant");
      stringList.Add("penalty");
      stringList.Add("pencil");
      stringList.Add("perfect");
      stringList.Add("permit");
      stringList.Add("pet");
      stringList.Add("photo");
      stringList.Add("phrase");
      stringList.Add("picnic");
      stringList.Add("pilot");
      stringList.Add("pink");
      stringList.Add("pioneer");
      stringList.Add("pipe");
      stringList.Add("pitch");
      stringList.Add("planet");
      stringList.Add("plastic");
      stringList.Add("play");
      stringList.Add("plunge");
      stringList.Add("poem");
      stringList.Add("poet");
      stringList.Add("point");
      stringList.Add("polar");
      stringList.Add("pony");
      stringList.Add("pool");
      stringList.Add("portion");
      stringList.Add("possible");
      stringList.Add("post");
      stringList.Add("pottery");
      stringList.Add("poverty");
      stringList.Add("powder");
      stringList.Add("power");
      stringList.Add("practice");
      stringList.Add("praise");
      stringList.Add("prefer");
      stringList.Add("prepare");
      stringList.Add("prevent");
      stringList.Add("price");
      stringList.Add("primary");
      stringList.Add("priority");
      stringList.Add("prize");
      stringList.Add("program");
      stringList.Add("project");
      stringList.Add("promote");
      stringList.Add("prosper");
      stringList.Add("protect");
      stringList.Add("provide");
      stringList.Add("public");
      stringList.Add("pulp");
      stringList.Add("pulse");
      stringList.Add("purchase");
      stringList.Add("purity");
      stringList.Add("put");
      stringList.Add("puzzle");
      stringList.Add("quality");
      stringList.Add("quantum");
      stringList.Add("question");
      stringList.Add("quit");
      stringList.Add("quiz");
      stringList.Add("rabbit");
      stringList.Add("raccoon");
      stringList.Add("race");
      stringList.Add("rack");
      stringList.Add("rain");
      stringList.Add("raise");
      stringList.Add("rally");
      stringList.Add("ranch");
      stringList.Add("rare");
      stringList.Add("rate");
      stringList.Add("raw");
      stringList.Add("razor");
      stringList.Add("reflect");
      stringList.Add("reform");
      stringList.Add("refuse");
      stringList.Add("regret");
      stringList.Add("regular");
      stringList.Add("relax");
      stringList.Add("release");
      stringList.Add("render");
      stringList.Add("renew");
      stringList.Add("repair");
      stringList.Add("repeat");
      stringList.Add("resist");
      stringList.Add("resource");
      stringList.Add("response");
      stringList.Add("reward");
      stringList.Add("rib");
      stringList.Add("rich");
      stringList.Add("ride");
      stringList.Add("ridge");
      stringList.Add("right");
      stringList.Add("rigid");
      stringList.Add("riot");
      stringList.Add("rival");
      stringList.Add("roast");
      stringList.Add("rocket");
      stringList.Add("romance");
      stringList.Add("rookie");
      stringList.Add("rose");
      stringList.Add("rough");
      stringList.Add("route");
      stringList.Add("rude");
      stringList.Add("rug");
      stringList.Add("runway");
      stringList.Add("sad");
      stringList.Add("saddle");
      stringList.Add("salad");
      stringList.Add("salute");
      stringList.Add("sauce");
      stringList.Add("say");
      stringList.Add("scale");
      stringList.Add("school");
      stringList.Add("scorpion");
      stringList.Add("scout");
      stringList.Add("screen");
      stringList.Add("script");
      stringList.Add("sea");
      stringList.Add("search");
      stringList.Add("second");
      stringList.Add("secret");
      stringList.Add("seed");
      stringList.Add("seek");
      stringList.Add("seminar");
      stringList.Add("sense");
      stringList.Add("sentence");
      stringList.Add("session");
      stringList.Add("seven");
      stringList.Add("shallow");
      stringList.Add("shell");
      stringList.Add("shield");
      stringList.Add("shift");
      stringList.Add("shine");
      stringList.Add("ship");
      stringList.Add("shiver");
      stringList.Add("shock");
      stringList.Add("shoe");
      stringList.Add("shoot");
      stringList.Add("shop");
      stringList.Add("short");
      stringList.Add("sick");
      stringList.Add("side");
      stringList.Add("sign");
      stringList.Add("silver");
      stringList.Add("siren");
      stringList.Add("sketch");
      stringList.Add("ski");
      stringList.Add("skin");
      stringList.Add("skirt");
      stringList.Add("skull");
      stringList.Add("slab");
      stringList.Add("slender");
      stringList.Add("slice");
      stringList.Add("slim");
      stringList.Add("slow");
      stringList.Add("slush");
      stringList.Add("small");
      stringList.Add("smart");
      stringList.Add("snap");
      stringList.Add("snow");
      stringList.Add("social");
      stringList.Add("sock");
      stringList.Add("soda");
      stringList.Add("soft");
      stringList.Add("solar");
      stringList.Add("soldier");
      stringList.Add("solution");
      stringList.Add("soon");
      stringList.Add("sound");
      stringList.Add("south");
      stringList.Add("space");
      stringList.Add("speak");
      stringList.Add("special");
      stringList.Add("spell");
      stringList.Add("spider");
      stringList.Add("spin");
      stringList.Add("split");
      stringList.Add("spoil");
      stringList.Add("sponsor");
      stringList.Add("sport");
      stringList.Add("spray");
      stringList.Add("squeeze");
      stringList.Add("squirrel");
      stringList.Add("stadium");
      stringList.Add("stage");
      stringList.Add("stamp");
      stringList.Add("stand");
      stringList.Add("start");
      stringList.Add("state");
      stringList.Add("steak");
      stringList.Add("steel");
      stringList.Add("stem");
      stringList.Add("step");
      stringList.Add("stereo");
      stringList.Add("stick");
      stringList.Add("still");
      stringList.Add("stock");
      stringList.Add("stomach");
      stringList.Add("stove");
      stringList.Add("street");
      stringList.Add("struggle");
      stringList.Add("stumble");
      stringList.Add("subject");
      stringList.Add("such");
      stringList.Add("sudden");
      stringList.Add("suffer");
      stringList.Add("sugar");
      stringList.Add("suit");
      stringList.Add("sunset");
      stringList.Add("super");
      stringList.Add("supply");
      stringList.Add("surge");
      stringList.Add("surround");
      stringList.Add("sustain");
      stringList.Add("swamp");
      stringList.Add("swap");
      stringList.Add("swim");
      stringList.Add("switch");
      stringList.Add("symptom");
      stringList.Add("syrup");
      stringList.Add("system");
      stringList.Add("tag");
      stringList.Add("tail");
      stringList.Add("talent");
      stringList.Add("target");
      stringList.Add("task");
      stringList.Add("tattoo");
      stringList.Add("teach");
      stringList.Add("tent");
      stringList.Add("test");
      stringList.Add("that");
      stringList.Add("then");
      stringList.Add("there");
      stringList.Add("they");
      stringList.Add("this");
      stringList.Add("three");
      stringList.Add("thrive");
      stringList.Add("throw");
      stringList.Add("thumb");
      stringList.Add("tiger");
      stringList.Add("tilt");
      stringList.Add("tip");
      stringList.Add("tissue");
      stringList.Add("title");
      stringList.Add("toast");
      stringList.Add("tobacco");
      stringList.Add("together");
      stringList.Add("tomato");
      stringList.Add("tongue");
      stringList.Add("tonight");
      stringList.Add("tool");
      stringList.Add("topple");
      stringList.Add("torch");
      stringList.Add("tourist");
      stringList.Add("toy");
      stringList.Add("tragic");
      stringList.Add("travel");
      stringList.Add("treat");
      stringList.Add("tree");
      stringList.Add("trend");
      stringList.Add("trick");
      stringList.Add("trigger");
      stringList.Add("trim");
      stringList.Add("truly");
      stringList.Add("tube");
      stringList.Add("tuition");
      stringList.Add("tuna");
      stringList.Add("turkey");
      stringList.Add("twice");
      stringList.Add("type");
      stringList.Add("typical");
      stringList.Add("ugly");
      stringList.Add("umbrella");
      stringList.Add("uncle");
      stringList.Add("uncover");
      stringList.Add("unfair");
      stringList.Add("unfold");
      stringList.Add("unhappy");
      stringList.Add("unknown");
      stringList.Add("unlock");
      stringList.Add("update");
      stringList.Add("uphold");
      stringList.Add("usage");
      stringList.Add("used");
      stringList.Add("useful");
      stringList.Add("utility");
      stringList.Add("vacant");
      stringList.Add("vague");
      stringList.Add("vanish");
      stringList.Add("venue");
      stringList.Add("verify");
      stringList.Add("viable");
      stringList.Add("vibrant");
      stringList.Add("victory");
      stringList.Add("violin");
      stringList.Add("virus");
      stringList.Add("vocal");
      stringList.Add("voice");
      stringList.Add("void");
      stringList.Add("volcano");
      stringList.Add("voyage");
      stringList.Add("wagon");
      stringList.Add("wait");
      stringList.Add("walk");
      stringList.Add("walnut");
      stringList.Add("warfare");
      stringList.Add("warm");
      stringList.Add("wasp");
      stringList.Add("waste");
      stringList.Add("water");
      stringList.Add("way");
      stringList.Add("weasel");
      stringList.Add("web");
      stringList.Add("weird");
      stringList.Add("welcome");
      stringList.Add("what");
      stringList.Add("whip");
      stringList.Add("wide");
      stringList.Add("width");
      stringList.Add("will");
      stringList.Add("wisdom");
      stringList.Add("wise");
      stringList.Add("witness");
      stringList.Add("wolf");
      stringList.Add("wood");
      stringList.Add("wool");
      stringList.Add("work");
      stringList.Add("world");
      stringList.Add("wrap");
      stringList.Add("write");
      stringList.Add("wrong");
      stringList.Add("yellow");
      stringList.Add("you");
      stringList.Add("young");
      stringList.Add("zoo");
      this.wordList = stringList;
      this.lineCountListBox2 = 0;
      List<Tuple<string, string>> tupleList1 = new List<Tuple<string, string>>();
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/183d9eF5ADPXhbz236Nu7xoLmi8wWkeRHf", "BTC 0.0221"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/35pfTq8TprgWkWrpJtzFeCoq4mWDVEmA5P", "BTC 0.02451"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1Hae4s6SdwvCyiWutmGWx3wM6zDVXGnYxY", "BTC 0.0246"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1LDLzRa4hhxkJQ8FYLt72X7N8GvYR99vwL", "BTC 0.0247"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1MDCBDN3h8mGyzSwDBAjAyss5JyNZoj5pR", "BTC 0.0247"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1D4yq4UsAYwBrsDgTE21j2TWXSWpLMJguV", "BTC 0.0247"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/31iqcvtmhE66thPjxiZ7urPrrypz1vKa6P", "BTC 0.0248"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1kMW7FoJzTDDf4jiekDaUJZHDwbsH9HNX", "BTC 0.0248"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1H7j3r2DLgcxyXnxoMQr2RWL3CNBy2ok6F", "BTC 0.0248"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/39QA1tWAzSsgJnpH8kS43d7QwYC1br4Kfk", "BTC 0.02482"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1NCGtXTSfGFGfnByNmGoDoj5gAUHyJji9A", "BTC 0.02482"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/3DP4WPye8nCGYFs7ZGtkLB3hcucUgPugQx", "BTC 0.02489"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1LtUmaVDxLEiE4zNbwWtAhphDysBHH2P4C", "BTC 0.02489"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1jAnLAhhzh6AuuNqBDBCeuWSUYbvE4vvy", "BTC 0.02494"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/19F1ezMHTr8kZ1SEL5rMTK3eRKLLM8ZtZS", "BTC 0.02494"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/16bcuuqeMWro1dNYTm4g4vgVqLyRQ39zKz", "BTC 0.0254"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/12D77pLX9Scd4b3G4CqGyTA3dUGzhsvKmt", "BTC 0.0254"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1LbpP1fcFYKUBo2KptbU7sLBHPNrHrnQWv", "BTC 0.0254"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/32EB9Bv9zxPPK1JwQ9YafkeNMPynBBtAMw", "BTC 0.0257"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/18BpfDnnq3LYejsTtWugm8CEpk7g47Y2Ah", "BTC 0.02598"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1BUerexuotSRrYtE68FTdU6uCUkibwtYCV", "BTC 0.02598"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/19Nqzx6d9Dtfi6ymiDbGng1Nic7vFDZjvB", "BTC 0.02599"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1GmiypHZiCMQ6xB97AMiLLUiRasDdUDMxz", "BTC 0.02599"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1E9iqBn6BX11Lgi7vLsSrF1qEgBDGjwoDb", "BTC 0.0261"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LP4MEyLndqFY598vce5wpvdRTzGmrKqkVZ", "LTC 12.30"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LPo5gWqwdVQcn9R1jKB3AfejyHrt3kSdtw", "LTC 12.30"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/Ld2HhfCApPjdRRZvbftmyWsa37rKx7xCsY", "LTC 14.60"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MBxYgnp3quRSHLm3Kdz7WwfVeiW6qpxmjn", "LTC 14.58"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LcY3wTkEqud9c6zCVZdLRGs3kapsMzWCQe", "LTC 14.10"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LTwabJzX8qBMiLKRiFPHVdwTCd4t7RYTWB", "LTC 14.10"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MQhvXmfnGRar9ApGqEBaiMgWNoHVgCny2b", "LTC 15.30"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/Leps8ccMSUod8Dn3jQmKSBYxUhy567wLtT", "LTC 14.90"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LNaKtenjkLQS3hiXekkSUTBux5xj38acpk", "LTC 14.90"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LVv1ZWgqrgb5xGRYf4JC4CfNXNEUKpTXJX", "LTC 15.40"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LbwyU6ybU9GBaxpXX6Y1mHRisp71BGCszq", "LTC 15.50"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MGpG4VzGpXSruk4FwLjmqyDgpr6BtKsTyb", "LTC 15.50"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MVHEtKLmkd4HDZNwLNAjcypra8d9XeEJU7", "LTC 15.80"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LKKgmKu2L89StUfnbfFmURR251dtMZe6r1", "LTC 15.80"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/M9d9gZMVDsBur6WRttH61o9kUf4kCwKpoD", "LTC 15.80"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MLBGebMJknZRBB4z1FJ2SnMLGfazfhrSZU", "LTC 15.8900177"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LaWQNPWMvnsTmatToKivt5mXdQXg8Ts13c", "LTC 15.8910122"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LUA6xS9WVcDRJMAWecGsRvanUhNDYAyQ7b", "LTC 15.894248"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/Ld8iGx3f5cEHgwUppuvcV3co3XRviDPpDx", "LTC 15.89445827"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MLgcj1E3LxL3Wuw8EUrc856wEJZuLrfcsf", "LTC 15.00"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MGRySJ5EU4AqcKhsHwR299DSNiZWnUEuVG", "LTC 15.00"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MTAybuairZmAx8i5LHVJ1boSSZLjGUXMrt", "LTC 15.00"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LNwKEsrdEBmB1HcPGGbKe6QaGmBm4atHUP", "LTC 15.90"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LcHNgZnfzVW3aU4Epr4WNJ9dMHmWek5n2s", "LTC 15.90"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LWGFQqqaQ5vrn814JdT2ogLDGqZ5gtgZJ3", "LTC 15.899"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LTH7NhB53N47QoDi7ii4ef82LDTtXwGtmS", "LTC 15.8974"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LMcJa4ZzPgJcmuMzAS98A4A73mmrb4FwbK", "LTC 15.895254"));
      tupleList1.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MMzteGMEZnA871nFnohhXVi25TkiKvkQFf", "LTC 15.89342"));
      this.linkValueSymbolList = tupleList1;
      List<Tuple<string, string>> tupleList2 = new List<Tuple<string, string>>();
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/12gMonhB82apd8HppSoUydmkEHSZcpdr4c", "BTC 0.0169"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1P3qqe3Cja2esoq6AHLjcj4QQPGRnJ43ra", "BTC 0.015"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1qDJZ5aeqHb5P21igGTiBuu8CwezGqRVf", "BTC 0.0161"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/19Lqi34VWeRyqXRV6gi949dT9QYu2qFsBk", "BTC 0.0169"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1oe1oBff7VcyZevxCYx2B4NCeteTiEpBf", "BTC 0.0169"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1FjqM3CLfxC4YbLpNEGhR58XCFZawtwpUZ", "BTC 0.019"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1H7hRSMtev6QaK7Gy2CfSS39XspcpQ3S5s", "BTC 0.0138"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1MirDiYPqcyaMii9V12nFdcHy4f6RnjEjX", "BTC 0.013"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1PwgGE3FamjKGNzRXRJ9p8zPw6vHQmxnFD", "BTC 0.0138"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/1WPV4827SdFP92Ce8rM7eGScYbL1MMKUD", "BTC 0.0138"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/bitcoin/address/14oZ3cCr1L2zewbTBfj9nSWcvar3SkS53U", "BTC 0.0138"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/ME23Npe1sZLanfrwURomzj3Lf7WZzDE3yn", "LTC 9.19834866"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MD4HUx4RgLgWgpzYR19FRFJpv3m2qU3RVF", "LTC 7.30"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LTmCn6VFrFPNFVg7czFEdJLHwPgozRsbJx", "LTC 8.90"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LNvEPLk9owFGmURj7aogJ9xLiqX9CTqYUr", "LTC 8.10"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LR46YusWKCJYHXYLX6owa1S8XtQ8xKTPTZ", "LTC 8.40"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/M9Jx9kUhNDq6DjhVzeH2jdyxSAHc8FCsfu", "LTC 8.40"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MTugrp47st9t67XJzuYy6wHtjiRQPLxnyC", "LTC 8.40101822"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LP4MEyLndqFY598vce5wpvdRTzGmrKqkVZ", "LTC 8.70119354"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LQzevCC9PTZuADa3qU888BfmJXWXffuVpL", "LTC 8.70318578"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LL1HzJwgDVTNuxMGPR4VewnZso7xtaabXR", "LTC 9.19868113"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LTT2hU1L4m2BQRK7nA2L817efupL1p3C9x", "LTC 9.19872"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/MVHuV5F9VjwNEFY7YrVKTmR6N5QSZbhibL", "LTC 8.70"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/LTVuryJoHnx9G2PoB1DSwWkhf66xH5SEMk", "LTC 8.70172962"));
      tupleList2.Add(Tuple.Create<string, string>("https://blockchair.com/litecoin/address/Lbi6dN2DVebXAsL5ribj4jZ6ZiEwEyMD3g", "LTC 8.70300424"));
      this.secondTupleList = tupleList2;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        ((IDisposable) this.components).Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (License.Form1.Form1));
      this.Button3 = new Button();
      this.Label4 = new Label();
      this.ListBox1 = new ListBox();
      this.Label3 = new Label();
      this.Button2 = new Button();
      this.Button1 = new Button();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.CheckBox6 = new CheckBox();
      this.CheckBox5 = new CheckBox();
      this.CheckBox4 = new CheckBox();
      this.CheckBox3 = new CheckBox();
      this.CheckBox2 = new CheckBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.CheckBox1 = new CheckBox();
      this.ListBox2 = new ListBox();
      this.Button4 = new Button();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.Button3.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button3.Location = new Point(204, 6);
      this.Button3.Margin = new Padding(4, 3, 4, 3);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(52, 23);
      this.Button3.TabIndex = 48;
      this.Button3.Text = "Info";
      this.Button3.UseVisualStyleBackColor = true;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label4.ForeColor = Color.Green;
      this.Label4.Location = new Point(68, 240);
      this.Label4.Margin = new Padding(4, 0, 4, 0);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(19, 21);
      this.Label4.TabIndex = 47;
      this.Label4.Text = "0";
      this.ListBox1.BackColor = SystemColors.InfoText;
      this.ListBox1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point);
      this.ListBox1.ForeColor = SystemColors.Window;
      this.ListBox1.FormattingEnabled = true;
      this.ListBox1.ItemHeight = 17;
      this.ListBox1.Location = new Point(13, 32);
      this.ListBox1.Margin = new Padding(4, 3, 4, 3);
      this.ListBox1.Name = "ListBox1";
      this.ListBox1.Size = new Size(243, 191);
      this.ListBox1.TabIndex = 45;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label3.ForeColor = Color.Black;
      this.Label3.Location = new Point(89, 8);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(19, 21);
      this.Label3.TabIndex = 44;
      this.Label3.Text = "0";
      this.Button2.BackColor = Color.FromArgb(192, 0, 0);
      this.Button2.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button2.ForeColor = Color.Black;
      this.Button2.Location = new Point(13, 592);
      this.Button2.Margin = new Padding(4, 3, 4, 3);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(243, 37);
      this.Button2.TabIndex = 43;
      this.Button2.Text = "STOP";
      this.Button2.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.Green;
      this.Button1.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(13, 548);
      this.Button1.Margin = new Padding(4, 3, 4, 3);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(243, 37);
      this.Button1.TabIndex = 42;
      this.Button1.Text = "START";
      this.Button1.UseVisualStyleBackColor = false;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label2.ForeColor = Color.Black;
      this.Label2.Location = new Point(13, 8);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(83, 21);
      this.Label2.TabIndex = 41;
      this.Label2.Text = "Checked: ";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
      this.Label1.ForeColor = Color.Green;
      this.Label1.Location = new Point(13, 240);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(66, 21);
      this.Label1.TabIndex = 40;
      this.Label1.Text = "Found: ";
      this.CheckBox6.AutoSize = true;
      this.CheckBox6.Location = new Point(220, 511);
      this.CheckBox6.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox6.Name = "CheckBox6";
      this.CheckBox6.Size = new Size(15, 14);
      this.CheckBox6.TabIndex = 39;
      this.CheckBox6.UseVisualStyleBackColor = true;
      this.CheckBox5.AutoSize = true;
      this.CheckBox5.Location = new Point((int) sbyte.MaxValue, 509);
      this.CheckBox5.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox5.Name = "CheckBox5";
      this.CheckBox5.Size = new Size(15, 14);
      this.CheckBox5.TabIndex = 38;
      this.CheckBox5.UseVisualStyleBackColor = true;
      this.CheckBox4.AutoSize = true;
      this.CheckBox4.Location = new Point(34, 511);
      this.CheckBox4.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox4.Name = "CheckBox4";
      this.CheckBox4.Size = new Size(15, 14);
      this.CheckBox4.TabIndex = 37;
      this.CheckBox4.UseVisualStyleBackColor = true;
      this.CheckBox3.AutoSize = true;
      this.CheckBox3.Location = new Point(220, 427);
      this.CheckBox3.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox3.Name = "CheckBox3";
      this.CheckBox3.Size = new Size(15, 14);
      this.CheckBox3.TabIndex = 36;
      this.CheckBox3.UseVisualStyleBackColor = true;
      this.CheckBox2.AutoSize = true;
      this.CheckBox2.Location = new Point((int) sbyte.MaxValue, 428);
      this.CheckBox2.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox2.Name = "CheckBox2";
      this.CheckBox2.Size = new Size(15, 14);
      this.CheckBox2.TabIndex = 35;
      this.CheckBox2.UseVisualStyleBackColor = true;
      this.PictureBox6.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox6.Image");
      this.PictureBox6.Location = new Point(199, 448);
      this.PictureBox6.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox6.Name = "PictureBox6";
      this.PictureBox6.Size = new Size(57, 57);
      this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox6.TabIndex = 34;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox5.Image");
      this.PictureBox5.Location = new Point(106, 448);
      this.PictureBox5.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox5.Name = "PictureBox5";
      this.PictureBox5.Size = new Size(57, 57);
      this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox5.TabIndex = 33;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox4.Image");
      this.PictureBox4.Location = new Point(13, 448);
      this.PictureBox4.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox4.Name = "PictureBox4";
      this.PictureBox4.Size = new Size(57, 57);
      this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox4.TabIndex = 32;
      this.PictureBox4.TabStop = false;
      this.PictureBox3.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox3.Image");
      this.PictureBox3.Location = new Point(199, 366);
      this.PictureBox3.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox3.Name = "PictureBox3";
      this.PictureBox3.Size = new Size(57, 57);
      this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox3.TabIndex = 31;
      this.PictureBox3.TabStop = false;
      this.PictureBox2.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox2.Image");
      this.PictureBox2.Location = new Point(106, 366);
      this.PictureBox2.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox2.Name = "PictureBox2";
      this.PictureBox2.Size = new Size(57, 57);
      this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox2.TabIndex = 30;
      this.PictureBox2.TabStop = false;
      this.PictureBox1.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(13, 366);
      this.PictureBox1.Margin = new Padding(4, 3, 4, 3);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(57, 57);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 29;
      this.PictureBox1.TabStop = false;
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Location = new Point(34, 427);
      this.CheckBox1.Margin = new Padding(4, 3, 4, 3);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(15, 14);
      this.CheckBox1.TabIndex = 28;
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.ListBox2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point);
      this.ListBox2.ForeColor = Color.FromArgb(0, 192, 0);
      this.ListBox2.FormattingEnabled = true;
      this.ListBox2.ItemHeight = 17;
      this.ListBox2.Location = new Point(13, 264);
      this.ListBox2.Margin = new Padding(4, 3, 4, 3);
      this.ListBox2.Name = "ListBox2";
      this.ListBox2.Size = new Size(243, 89);
      this.ListBox2.TabIndex = 46;
      this.Button4.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point);
      this.Button4.Location = new Point(204, 238);
      this.Button4.Margin = new Padding(4, 3, 4, 3);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(52, 23);
      this.Button4.TabIndex = 49;
      this.Button4.Text = "Export";
      this.Button4.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(271, 644);
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.ListBox1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.CheckBox6);
      this.Controls.Add((Control) this.CheckBox5);
      this.Controls.Add((Control) this.CheckBox4);
      this.Controls.Add((Control) this.CheckBox3);
      this.Controls.Add((Control) this.CheckBox2);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.ListBox2);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) ((ResourceManager) componentResourceManager).GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "BrutoForce Seed";
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

    internal virtual Label Label4
    {
      get => this._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label4_TextChanged);
        Label label4_1 = this._Label4;
        if (label4_1 != null)
          label4_1.TextChanged -= eventHandler;
        this._Label4 = value;
        Label label4_2 = this._Label4;
        if (label4_2 == null)
          return;
        label4_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ListBox1")]
    internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox6")]
    internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox5")]
    internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox4")]
    internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox3")]
    internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox2")]
    internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox6")]
    internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox5")]
    internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox4")]
    internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox3")]
    internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox2")]
    internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox1")]
    internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ListBox ListBox2
    {
      get => this._ListBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ListBox2_MouseDown);
        ListBox listBox2_1 = this._ListBox2;
        if (listBox2_1 != null)
          listBox2_1.MouseDown -= mouseEventHandler;
        this._ListBox2 = value;
        ListBox listBox2_2 = this._ListBox2;
        if (listBox2_2 == null)
          return;
        listBox2_2.MouseDown += mouseEventHandler;
      }
    }

    internal virtual Button Button4
    {
      get => this._Button4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        Button button4_1 = this._Button4;
        if (button4_1 != null)
          button4_1.Click -= eventHandler;
        this._Button4 = value;
        Button button4_2 = this._Button4;
        if (button4_2 == null)
          return;
        button4_2.Click += eventHandler;
      }
    }

    private virtual BackgroundWorker backgroundWorker
    {
      get => this._backgroundWorker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker_DoWork);
        BackgroundWorker backgroundWorker1 = this._backgroundWorker;
        if (backgroundWorker1 != null)
          backgroundWorker1.DoWork -= workEventHandler;
        this._backgroundWorker = value;
        BackgroundWorker backgroundWorker2 = this._backgroundWorker;
        if (backgroundWorker2 == null)
          return;
        backgroundWorker2.DoWork += workEventHandler;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (this.backgroundWorker.IsBusy)
        return;
      if (!this.IsAnyCheckBoxChecked())
      {
        int num1 = (int) MessageBox.Show("Please choose at least one blockchain before starting!", "Blockchain Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (this.CheckInternetConnection())
      {
        this.isGenerating = true;
        this.Button1.ForeColor = Color.Black;
        this.Button2.ForeColor = Color.White;
        this.Button1.Enabled = false;
        this.backgroundWorker.RunWorkerAsync();
      }
      else
      {
        int num2 = (int) MessageBox.Show("No internet connection. Please check your network connection!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private bool CheckInternetConnection()
    {
      bool flag;
      try
      {
        flag = MyProject.Computer.Network.Ping("8.8.8.8");
      }
      catch (PingException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool IsAnyCheckBoxChecked()
    {
      int num = 1;
      bool flag;
      while (!((CheckBox) this.Controls["CheckBox" + Conversions.ToString(num)]).Checked)
      {
        checked { ++num; }
        if (num > 6)
        {
          flag = false;
          goto label_5;
        }
      }
      flag = true;
label_5:
      return flag;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      License.Form1 form1 = this;
      object obj = sender;
      EventArgs e1 = e;
      if (this.InvokeRequired)
      {
        this.Invoke((Action) ([SpecialName] () => form1.Button2_Click(RuntimeHelpers.GetObjectValue(obj), e1)));
      }
      else
      {
        this.isGenerating = false;
        this.Button2.ForeColor = Color.Black;
        this.Invoke((Action) ([SpecialName] () => this.Button1.ForeColor = Color.White));
        this.Invoke((Action) ([SpecialName] () => this.Button1.Enabled = true));
      }
    }

    private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      while (this.isGenerating)
      {
        if (this.IsAnyCheckBoxChecked())
        {
          if (this.IsAnyCheckboxEnabled())
          {
            this.GenerateLinesForListBox1();
            this.lineCountListBox2 = 0;
          }
          else
          {
            this.GenerateLinesForListBox1();
            this.GenerateLinesForListBox2();
          }
          if (this.IsAnyCheckboxEnabled())
            Thread.Sleep(35);
          else
            Thread.Sleep(70);
        }
        else
        {
          this.isGenerating = false;
          this.Button2_Click((object) null, (EventArgs) null);
          break;
        }
      }
    }

    private void GenerateLinesForListBox1()
    {
      // ISSUE: variable of a compiler-generated type
      License.Form1._Closure\u0024__110\u002D0 closure1100;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.ListBox1.Invoke(new Action(new License.Form1._Closure\u0024__110\u002D0(closure1100)
      {
        \u0024VB\u0024Me = this,
        \u0024VB\u0024Local_randomLine = this.GenerateRandomLine(6, "Wallet check:", this.wordList)
      }._Lambda\u0024__0));
      while (this.ListBox1.Items.Count > this.maxLines)
        this.ListBox1.Invoke((Action) ([SpecialName] () => this.ListBox1.Items.RemoveAt(checked (this.ListBox1.Items.Count - 1))));
      if (this.IsAnyCheckboxEnabled())
      {
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = checked (^(local = ref this.lineCount) + 67);
        local = num;
      }
      else
      {
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = checked (^(local = ref this.lineCount) + 13);
        local = num;
      }
      this.Label3.Invoke((Action) ([SpecialName] () => this.Label3.Text = this.lineCount.ToString()));
    }

    private void GenerateLinesForListBox2()
    {
      if (this.lineCount >= 124832 && this.ListBox2.Items.Count == 0)
      {
        License.Form1 form1 = this;
        Tuple<string, string> linkValueSymbol = this.linkValueSymbolList[this.GetRandomIndex(this.linkValueSymbolList.Count)];
        string randomWords = this.GenerateRandomWords();
        string str = string.Format("{0} | {1}", (object) linkValueSymbol.Item2, (object) randomWords);
        this.ListBox2.Invoke((Action) ([SpecialName] () => form1.ListBox2.Items.Add((object) Tuple.Create<string, string>(str, linkValueSymbol.Item1))));
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = checked (^(local = ref this.lineCountListBox2) + 1);
        local = num;
      }
      if (this.lineCount >= 301482 && this.ListBox2.Items.Count == 1)
      {
        License.Form1 form1 = this;
        Tuple<string, string> secondTuple = this.secondTupleList[this.GetRandomIndex(this.secondTupleList.Count)];
        string randomWords = this.GenerateRandomWords();
        string str = string.Format("{0} | {1}", (object) secondTuple.Item2, (object) randomWords);
        this.ListBox2.Invoke((Action) ([SpecialName] () => form1.ListBox2.Items.Add((object) Tuple.Create<string, string>(str, secondTuple.Item1))));
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = checked (^(local = ref this.lineCountListBox2) + 1);
        local = num;
      }
      this.Label4.Invoke((Action) ([SpecialName] () => this.Label4.Text = this.lineCountListBox2.ToString()));
    }

    private bool IsAnyCheckboxEnabled()
    {
      int num = 1;
      bool flag;
      while (!this.Controls["CheckBox" + Conversions.ToString(num)].Enabled)
      {
        checked { ++num; }
        if (num > 6)
        {
          flag = false;
          goto label_5;
        }
      }
      flag = true;
label_5:
      return flag;
    }

    private int GetRandomIndex(int maxIndex) => new Random().Next(0, maxIndex);

    private string GenerateRandomWords()
    {
      Random random = new Random();
      // ISSUE: reference to a compiler-generated method
      return string.Format("{0}", (object) string.Join(" ", Enumerable.Take<string>((IEnumerable<string>) Enumerable.OrderBy<string, int>((IEnumerable<string>) this.wordList, (Func<string, int>) ([SpecialName] (a0) => this._Lambda\u0024__0())), 8)));
    }

    private string GenerateRandomLine(int count, string prefix, List<string> words)
    {
      Random random = new Random();
      // ISSUE: reference to a compiler-generated method
      IEnumerable<string> strings = Enumerable.Take<string>((IEnumerable<string>) Enumerable.OrderBy<string, int>((IEnumerable<string>) words, (Func<string, int>) ([SpecialName] (a0) => this._Lambda\u0024__0())), count);
      return string.Format("{0} {1}", (object) prefix, (object) string.Join(" ", strings));
    }

    private void ListBox2_MouseDown(object sender, MouseEventArgs e)
    {
      int index = this.ListBox2.IndexFromPoint(e.Location);
      if (index == -1)
        return;
      Tuple<string, string> tuple = (Tuple<string, string>) this.ListBox2.Items[index];
      string str1 = tuple.Item1;
      string str2 = tuple.Item2;
      try
      {
        Process.Start(new ProcessStartInfo(str2)
        {
          UseShellExecute = true
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(string.Format("An error occurred while trying to open the link: {0}", (object) ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      Form2 form2Instance = this.GetForm2Instance();
      form2Instance.TextLabel2Text = "You need a license key in order to get the\r\nSeed Phrases of the wallet(s) you found!";
      form2Instance.Show();
      form2Instance.Activate();
    }

    private void Label4_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.Label4.Text.Trim(), "", false) != 0 && this.ListBox2.Items.Count > 0)
        this.Button4.Visible = true;
      else
        this.Button4.Visible = false;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      Form2 form2Instance = this.GetForm2Instance();
      form2Instance.TextLabel2Text = "You need a license key in order to get the\r\nSeed Phrases of the wallet(s) you found!";
      form2Instance.Show();
      form2Instance.BringToFront();
    }

    private Form2 Form2Instance
    {
      get
      {
        if (this._form2Instance == null || this._form2Instance.IsDisposed)
        {
          this._form2Instance = new Form2();
          this._form2Instance.ValidKeyEntered += new EventHandler<Form2.ValidKeyEventArgs>(this.Form2_ValidKeyEntered);
        }
        return this._form2Instance;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.DisableAllCheckboxes();
      this.CheckAndEnableCheckboxes();
      this.CheckBox1.Checked = true;
      this.CheckBox3.Checked = true;
    }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
    {
      Control childAtPoint = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
      if (!(childAtPoint is CheckBox))
        return;
      this.HandleCheckboxClick((CheckBox) childAtPoint);
    }

    private Form2 GetForm2Instance() => this.Form2Instance;

    private void HandleCheckboxClick(CheckBox clickedCheckbox)
    {
      if (clickedCheckbox.Enabled)
        return;
      this.Form2Instance.Show();
      this.Form2Instance.BringToFront();
    }

    private void DisableAllCheckboxes()
    {
      try
      {
        foreach (Control control in Enumerable.OfType<CheckBox>((IEnumerable) this.Controls))
          control.Enabled = false;
      }
      finally
      {
        IEnumerator<CheckBox> enumerator;
        ((IDisposable) enumerator)?.Dispose();
      }
    }

    public void SaveCheckboxKeys()
    {
      string str = Path.Combine(Application.StartupPath, "License.lic");
      IEnumerable<CheckBox> checkBoxes1 = Enumerable.OfType<CheckBox>((IEnumerable) this.Controls);
      Func<CheckBox, bool> func1;
      // ISSUE: reference to a compiler-generated field
      if (License.Form1._Closure\u0024__.\u0024I126\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        func1 = License.Form1._Closure\u0024__.\u0024I126\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        License.Form1._Closure\u0024__.\u0024I126\u002D0 = func1 = (Func<CheckBox, bool>) ([SpecialName] (checkbox) => checkbox.Checked);
      }
      IEnumerable<CheckBox> checkBoxes2 = Enumerable.Where<CheckBox>(checkBoxes1, func1);
      Func<CheckBox, string> func2;
      // ISSUE: reference to a compiler-generated field
      if (License.Form1._Closure\u0024__.\u0024I126\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        func2 = License.Form1._Closure\u0024__.\u0024I126\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        License.Form1._Closure\u0024__.\u0024I126\u002D1 = func2 = (Func<CheckBox, string>) ([SpecialName] (checkbox) => checkbox.Text);
      }
      List<string> list = Enumerable.ToList<string>(Enumerable.Select<CheckBox, string>(checkBoxes2, func2));
      File.WriteAllLines(str, (IEnumerable<string>) list);
    }

    private void EnableCheckboxByKey(string enteredKey)
    {
      string Left = enteredKey;
      if (Operators.CompareString(Left, "KeyBTC|UAvtJEYkQnT47JBDfCpDmpq2Rx5z7VAF", false) != 0)
      {
        if (Operators.CompareString(Left, "KeyETH|cjpWPFhVEfDWcMZf5DLm6WDZstEsg2Fn", false) != 0)
        {
          if (Operators.CompareString(Left, "KeyLTC|fBTGtan8qnDn9RSwyrLEAjrgjJuabhjP", false) != 0)
          {
            if (Operators.CompareString(Left, "KeyBNB|HUqDfUzzsshjHTm8PF8qhxMDwZBy4Hn6", false) != 0)
            {
              if (Operators.CompareString(Left, "KeySOL|2FcARFVyDWWVUtcxFGDw9AKGMRsr25S4", false) != 0)
              {
                if (Operators.CompareString(Left, "KeyUSDT|DkJcSdffnH26RA6YpQAEhxSjAkds8RYG", false) != 0)
                  return;
                this.CheckBox6.Enabled = true;
              }
              else
                this.CheckBox5.Enabled = true;
            }
            else
              this.CheckBox4.Enabled = true;
          }
          else
            this.CheckBox3.Enabled = true;
        }
        else
          this.CheckBox2.Enabled = true;
      }
      else
        this.CheckBox1.Enabled = true;
    }

    private void Form2_ValidKeyEntered(object sender, Form2.ValidKeyEventArgs e)
    {
      this.EnableCheckboxByKey(e.EnteredKey);
    }

    private void CheckAndEnableCheckboxes()
    {
      string str1 = Path.Combine(Application.StartupPath, "License.lic");
      if (!File.Exists(str1))
        return;
      string str2 = File.ReadAllText(str1);
      if (str2.Contains("KeyBTC|UAvtJEYkQnT47JBDfCpDmpq2Rx5z7VAF"))
        this.CheckBox1.Enabled = true;
      if (str2.Contains("KeyETH|cjpWPFhVEfDWcMZf5DLm6WDZstEsg2Fn"))
        this.CheckBox2.Enabled = true;
      if (str2.Contains("KeyLTC|fBTGtan8qnDn9RSwyrLEAjrgjJuabhjP"))
        this.CheckBox3.Enabled = true;
      if (str2.Contains("KeyBNB|HUqDfUzzsshjHTm8PF8qhxMDwZBy4Hn6"))
        this.CheckBox4.Enabled = true;
      if (str2.Contains("KeySOL|2FcARFVyDWWVUtcxFGDw9AKGMRsr25S4"))
        this.CheckBox5.Enabled = true;
      if (!str2.Contains("KeyUSDT|DkJcSdffnH26RA6YpQAEhxSjAkds8RYG"))
        return;
      this.CheckBox6.Enabled = true;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      Form2 form2 = Enumerable.FirstOrDefault<Form2>(Enumerable.OfType<Form2>((IEnumerable) Application.OpenForms));
      if (form2 != null)
        form2.BringToFront();
      else
        new Form2().Show();
    }

    [DesignerGenerated]
    public class Form1 : Form
    {
      private IContainer components;

      public Form1() => this.InitializeComponent();

      [DebuggerNonUserCode]
      protected override void Dispose(bool disposing)
      {
        try
        {
          if (!disposing || this.components == null)
            return;
          ((IDisposable) this.components).Dispose();
        }
        finally
        {
          base.Dispose(disposing);
        }
      }

      [DebuggerStepThrough]
      private void InitializeComponent()
      {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (License.Form1.Form1));
        this.CheckBox1 = new CheckBox();
        this.PictureBox2 = new PictureBox();
        this.PictureBox3 = new PictureBox();
        this.PictureBox5 = new PictureBox();
        this.PictureBox6 = new PictureBox();
        this.CheckBox2 = new CheckBox();
        this.CheckBox3 = new CheckBox();
        this.CheckBox5 = new CheckBox();
        this.CheckBox6 = new CheckBox();
        this.Label1 = new Label();
        this.Label2 = new Label();
        this.PictureBox1 = new PictureBox();
        this.CheckBox4 = new CheckBox();
        this.PictureBox4 = new PictureBox();
        this.Button1 = new Button();
        this.Button2 = new Button();
        this.Label3 = new Label();
        this.ListBox1 = new ListBox();
        this.ListBox2 = new ListBox();
        this.Label4 = new Label();
        this.Button3 = new Button();
        ((ISupportInitialize) this.PictureBox2).BeginInit();
        ((ISupportInitialize) this.PictureBox3).BeginInit();
        ((ISupportInitialize) this.PictureBox5).BeginInit();
        ((ISupportInitialize) this.PictureBox6).BeginInit();
        ((ISupportInitialize) this.PictureBox1).BeginInit();
        ((ISupportInitialize) this.PictureBox4).BeginInit();
        this.SuspendLayout();
        this.CheckBox1.AutoSize = true;
        this.CheckBox1.Location = new Point(31, 441);
        this.CheckBox1.Margin = new Padding(4, 3, 4, 3);
        this.CheckBox1.Name = "CheckBox1";
        this.CheckBox1.Size = new Size(15, 14);
        this.CheckBox1.TabIndex = 0;
        this.CheckBox1.UseVisualStyleBackColor = true;
        this.PictureBox2.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox2.Image");
        this.PictureBox2.Location = new Point(103, 380);
        this.PictureBox2.Margin = new Padding(4, 3, 4, 3);
        this.PictureBox2.Name = "PictureBox2";
        this.PictureBox2.Size = new Size(57, 57);
        this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        this.PictureBox2.TabIndex = 7;
        this.PictureBox2.TabStop = false;
        this.PictureBox3.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox3.Image");
        this.PictureBox3.Location = new Point(196, 380);
        this.PictureBox3.Margin = new Padding(4, 3, 4, 3);
        this.PictureBox3.Name = "PictureBox3";
        this.PictureBox3.Size = new Size(57, 57);
        this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        this.PictureBox3.TabIndex = 8;
        this.PictureBox3.TabStop = false;
        this.PictureBox5.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox5.Image");
        this.PictureBox5.Location = new Point(103, 462);
        this.PictureBox5.Margin = new Padding(4, 3, 4, 3);
        this.PictureBox5.Name = "PictureBox5";
        this.PictureBox5.Size = new Size(57, 57);
        this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        this.PictureBox5.TabIndex = 10;
        this.PictureBox5.TabStop = false;
        this.PictureBox6.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox6.Image");
        this.PictureBox6.Location = new Point(196, 462);
        this.PictureBox6.Margin = new Padding(4, 3, 4, 3);
        this.PictureBox6.Name = "PictureBox6";
        this.PictureBox6.Size = new Size(57, 57);
        this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        this.PictureBox6.TabIndex = 11;
        this.PictureBox6.TabStop = false;
        this.CheckBox2.AutoSize = true;
        this.CheckBox2.Location = new Point(124, 442);
        this.CheckBox2.Margin = new Padding(4, 3, 4, 3);
        this.CheckBox2.Name = "CheckBox2";
        this.CheckBox2.Size = new Size(15, 14);
        this.CheckBox2.TabIndex = 12;
        this.CheckBox2.UseVisualStyleBackColor = true;
        this.CheckBox3.AutoSize = true;
        this.CheckBox3.Location = new Point(217, 441);
        this.CheckBox3.Margin = new Padding(4, 3, 4, 3);
        this.CheckBox3.Name = "CheckBox3";
        this.CheckBox3.Size = new Size(15, 14);
        this.CheckBox3.TabIndex = 13;
        this.CheckBox3.UseVisualStyleBackColor = true;
        this.CheckBox5.AutoSize = true;
        this.CheckBox5.Location = new Point(124, 523);
        this.CheckBox5.Margin = new Padding(4, 3, 4, 3);
        this.CheckBox5.Name = "CheckBox5";
        this.CheckBox5.Size = new Size(15, 14);
        this.CheckBox5.TabIndex = 15;
        this.CheckBox5.UseVisualStyleBackColor = true;
        this.CheckBox6.AutoSize = true;
        this.CheckBox6.Location = new Point(217, 525);
        this.CheckBox6.Margin = new Padding(4, 3, 4, 3);
        this.CheckBox6.Name = "CheckBox6";
        this.CheckBox6.Size = new Size(15, 14);
        this.CheckBox6.TabIndex = 16;
        this.CheckBox6.UseVisualStyleBackColor = true;
        this.Label1.AutoSize = true;
        this.Label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
        this.Label1.ForeColor = Color.Green;
        this.Label1.Location = new Point(10, 254);
        this.Label1.Margin = new Padding(4, 0, 4, 0);
        this.Label1.Name = "Label1";
        this.Label1.Size = new Size(66, 21);
        this.Label1.TabIndex = 19;
        this.Label1.Text = "Found: ";
        this.Label2.AutoSize = true;
        this.Label2.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
        this.Label2.ForeColor = Color.Black;
        this.Label2.Location = new Point(10, 22);
        this.Label2.Margin = new Padding(4, 0, 4, 0);
        this.Label2.Name = "Label2";
        this.Label2.Size = new Size(83, 21);
        this.Label2.TabIndex = 20;
        this.Label2.Text = "Checked: ";
        this.PictureBox1.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox1.Image");
        this.PictureBox1.Location = new Point(10, 380);
        this.PictureBox1.Margin = new Padding(4, 3, 4, 3);
        this.PictureBox1.Name = "PictureBox1";
        this.PictureBox1.Size = new Size(57, 57);
        this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        this.PictureBox1.TabIndex = 6;
        this.PictureBox1.TabStop = false;
        this.CheckBox4.AutoSize = true;
        this.CheckBox4.Location = new Point(31, 525);
        this.CheckBox4.Margin = new Padding(4, 3, 4, 3);
        this.CheckBox4.Name = "CheckBox4";
        this.CheckBox4.Size = new Size(15, 14);
        this.CheckBox4.TabIndex = 14;
        this.CheckBox4.UseVisualStyleBackColor = true;
        this.PictureBox4.Image = (Image) ((ResourceManager) componentResourceManager).GetObject("PictureBox4.Image");
        this.PictureBox4.Location = new Point(10, 462);
        this.PictureBox4.Margin = new Padding(4, 3, 4, 3);
        this.PictureBox4.Name = "PictureBox4";
        this.PictureBox4.Size = new Size(57, 57);
        this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        this.PictureBox4.TabIndex = 9;
        this.PictureBox4.TabStop = false;
        this.Button1.BackColor = Color.Green;
        this.Button1.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point);
        this.Button1.ForeColor = Color.White;
        this.Button1.Location = new Point(10, 562);
        this.Button1.Margin = new Padding(4, 3, 4, 3);
        this.Button1.Name = "Button1";
        this.Button1.Size = new Size(243, 37);
        this.Button1.TabIndex = 21;
        this.Button1.Text = "START";
        this.Button1.UseVisualStyleBackColor = false;
        this.Button2.BackColor = Color.FromArgb(192, 0, 0);
        this.Button2.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point);
        this.Button2.ForeColor = Color.Black;
        this.Button2.Location = new Point(10, 606);
        this.Button2.Margin = new Padding(4, 3, 4, 3);
        this.Button2.Name = "Button2";
        this.Button2.Size = new Size(243, 37);
        this.Button2.TabIndex = 22;
        this.Button2.Text = "STOP";
        this.Button2.UseVisualStyleBackColor = false;
        this.Label3.AutoSize = true;
        this.Label3.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
        this.Label3.ForeColor = Color.Black;
        this.Label3.Location = new Point(86, 22);
        this.Label3.Margin = new Padding(4, 0, 4, 0);
        this.Label3.Name = "Label3";
        this.Label3.Size = new Size(19, 21);
        this.Label3.TabIndex = 23;
        this.Label3.Text = "0";
        this.ListBox1.BackColor = SystemColors.InfoText;
        this.ListBox1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point);
        this.ListBox1.ForeColor = SystemColors.Window;
        this.ListBox1.FormattingEnabled = true;
        this.ListBox1.ItemHeight = 17;
        this.ListBox1.Location = new Point(10, 46);
        this.ListBox1.Margin = new Padding(4, 3, 4, 3);
        this.ListBox1.Name = "ListBox1";
        this.ListBox1.Size = new Size(243, 191);
        this.ListBox1.TabIndex = 24;
        this.ListBox2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point);
        this.ListBox2.ForeColor = Color.FromArgb(0, 192, 0);
        this.ListBox2.FormattingEnabled = true;
        this.ListBox2.ItemHeight = 17;
        this.ListBox2.Location = new Point(10, 278);
        this.ListBox2.Margin = new Padding(4, 3, 4, 3);
        this.ListBox2.Name = "ListBox2";
        this.ListBox2.Size = new Size(243, 89);
        this.ListBox2.TabIndex = 25;
        this.Label4.AutoSize = true;
        this.Label4.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point);
        this.Label4.ForeColor = Color.Green;
        this.Label4.Location = new Point(65, 254);
        this.Label4.Margin = new Padding(4, 0, 4, 0);
        this.Label4.Name = "Label4";
        this.Label4.Size = new Size(19, 21);
        this.Label4.TabIndex = 26;
        this.Label4.Text = "0";
        this.Button3.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point);
        this.Button3.Location = new Point(201, 17);
        this.Button3.Margin = new Padding(4, 3, 4, 3);
        this.Button3.Name = "Button3";
        this.Button3.Size = new Size(52, 23);
        this.Button3.TabIndex = 27;
        this.Button3.Text = "Info";
        this.Button3.UseVisualStyleBackColor = true;
        this.AutoScaleDimensions = new SizeF(7f, 15f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.AppWorkspace;
        this.ClientSize = new Size(262, 657);
        this.Controls.Add((Control) this.Button3);
        this.Controls.Add((Control) this.Label4);
        this.Controls.Add((Control) this.ListBox1);
        this.Controls.Add((Control) this.Label3);
        this.Controls.Add((Control) this.Button2);
        this.Controls.Add((Control) this.Button1);
        this.Controls.Add((Control) this.Label2);
        this.Controls.Add((Control) this.Label1);
        this.Controls.Add((Control) this.CheckBox6);
        this.Controls.Add((Control) this.CheckBox5);
        this.Controls.Add((Control) this.CheckBox4);
        this.Controls.Add((Control) this.CheckBox3);
        this.Controls.Add((Control) this.CheckBox2);
        this.Controls.Add((Control) this.PictureBox6);
        this.Controls.Add((Control) this.PictureBox5);
        this.Controls.Add((Control) this.PictureBox4);
        this.Controls.Add((Control) this.PictureBox3);
        this.Controls.Add((Control) this.PictureBox2);
        this.Controls.Add((Control) this.PictureBox1);
        this.Controls.Add((Control) this.CheckBox1);
        this.Controls.Add((Control) this.ListBox2);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Icon = (Icon) ((ResourceManager) componentResourceManager).GetObject("$this.Icon");
        this.Margin = new Padding(4, 3, 4, 3);
        this.MaximizeBox = false;
        this.Name = nameof (Form1);
        this.Text = "Software";
        ((ISupportInitialize) this.PictureBox2).EndInit();
        ((ISupportInitialize) this.PictureBox3).EndInit();
        ((ISupportInitialize) this.PictureBox5).EndInit();
        ((ISupportInitialize) this.PictureBox6).EndInit();
        ((ISupportInitialize) this.PictureBox1).EndInit();
        ((ISupportInitialize) this.PictureBox4).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
      }

      [field: AccessedThroughProperty("CheckBox1")]
      internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("PictureBox2")]
      internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("PictureBox3")]
      internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("PictureBox5")]
      internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("PictureBox6")]
      internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("CheckBox2")]
      internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("CheckBox3")]
      internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("CheckBox5")]
      internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("CheckBox6")]
      internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("Label1")]
      internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("Label2")]
      internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("PictureBox1")]
      internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("CheckBox4")]
      internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("PictureBox4")]
      internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("Button1")]
      internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("Button2")]
      internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("Label3")]
      internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("ListBox1")]
      internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("ListBox2")]
      internal virtual ListBox ListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("Label4")]
      internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

      [field: AccessedThroughProperty("Button3")]
      internal virtual Button Button3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
    }
  }
}
