using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.XPath;
using System.Windows.Forms;
using CQE.Datas;

namespace CQE.Classes
{
    class Language
    {
        // Dictionary
        public static Dictionary<string, Dictionary<string, string>> Dictionary = new Dictionary<string, Dictionary<string, string>>();

        // UI Strings
        private static Dictionary<string, string> dict_menu = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_pages = new Dictionary<string, string>();

        // Pages Strings
        private static Dictionary<string, string> dict_questinfo = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_questmonster = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_questminion = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_questsupply = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_questgath = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_questreward = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_questchallenge = new Dictionary<string, string>();

        // Game Strings
        private static Dictionary<string, string> dict_areas = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_zones = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_game = new Dictionary<string,string>();
        private static Dictionary<string, string> dict_skills = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_skillsys = new Dictionary<string, string>();
        
        // Other Strings
        private static Dictionary<string, string> dict_other = new Dictionary<string,string>();
        private static Dictionary<string, string> dict_edit = new Dictionary<string, string>();

        // Messages Strings
        private static Dictionary<string, string> dict_messages = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_errors = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_updater = new Dictionary<string, string>();

        // Challenge Strings
        private static Dictionary<string, string> dict_helms = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_plates = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_arms = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_waists = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_legs = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_decorations = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_charms = new Dictionary<string, string>();

        private static Dictionary<string, string> dict_greatswords = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_shieldandswords = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_hammers = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_lances = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_heavygun = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_lightgun = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_longswords = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_axes = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_gunlances = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_bows = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_dualswords = new Dictionary<string, string>();
        private static Dictionary<string, string> dict_horns = new Dictionary<string, string>();

        // Initialize main dictionary
        public static void InitDictionary()
        {
            Dictionary.Clear();
            Dictionary.Add("menu", dict_menu);
            Dictionary.Add("pages", dict_pages);
            Dictionary.Add("areas", dict_areas);
            Dictionary.Add("zones", dict_zones);
            Dictionary.Add("questinfo", dict_questinfo);
            Dictionary.Add("game", dict_game);
            Dictionary.Add("other", dict_other);
            Dictionary.Add("edit", dict_edit);
            Dictionary.Add("questmonster", dict_questmonster);
            Dictionary.Add("questminion", dict_questminion);
            Dictionary.Add("questsupply", dict_questsupply);
            Dictionary.Add("questgath", dict_questgath);
            Dictionary.Add("questreward", dict_questreward);
            Dictionary.Add("questchallenge", dict_questchallenge);
            Dictionary.Add("messages", dict_messages);
            Dictionary.Add("errors", dict_errors);
            Dictionary.Add("updater", dict_updater);
            Dictionary.Add("helms", dict_helms);
            Dictionary.Add("plates", dict_plates);
            Dictionary.Add("arms", dict_arms);
            Dictionary.Add("waists", dict_waists);
            Dictionary.Add("legs", dict_legs);
            Dictionary.Add("decorations", dict_decorations);
            Dictionary.Add("skills", dict_skills);
            Dictionary.Add("skillsys", dict_skillsys);
            Dictionary.Add("charms", dict_charms);

            Dictionary.Add("greatswords", dict_greatswords);
            Dictionary.Add("shieldandswords", dict_shieldandswords);
            Dictionary.Add("hammers", dict_hammers);
            Dictionary.Add("lances", dict_lances);
            Dictionary.Add("heavygun", dict_heavygun);
            Dictionary.Add("lightgun", dict_lightgun);
            Dictionary.Add("longswords", dict_longswords);
            Dictionary.Add("axes", dict_axes);
            Dictionary.Add("gunlances", dict_gunlances);
            Dictionary.Add("bows", dict_bows);
            Dictionary.Add("dualswords", dict_dualswords);
            Dictionary.Add("horns", dict_horns);
        }

        public static void InitDictionary(string langId)
        {
            InitDictionary();
            LoadLanguageEx(langId);
        }

        // Clear all Dictionaries
        public static void CleanDictionary()
        {
            foreach (Dictionary<string, string> dict in Dictionary.Values)
            {
                dict.Clear();
            }
        }

        // Load the selected language
        public static void LoadLanguageEx(string langId)
        {
            CleanDictionary();

            // Check if the file exists
            string path = Path.Combine("Lang", Path.Combine(langId, langId + ".xml"));
            if (File.Exists(path))
            {
                XPathDocument doc = new XPathDocument(path);
                XPathNavigator nav = doc.CreateNavigator();

                try
                {
                    // Obtaining main informations
                    nav.MoveToRoot();
                    nav.MoveToFirstChild();
                    string id = nav.GetAttribute("id", "");
                    string version = nav.GetAttribute("version", "");
                    Configs.LanguageTranslater = nav.GetAttribute("translater", "");

                    // Xml Header Check
                    if (id.ToUpper() != langId.ToUpper())
                    {
                        MessageBox.Show("Invalid Language pack. Language ID does not match the Language folder.", "CQE - ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (File.Exists(Configs.ConfigFile))
                            File.Delete(Configs.ConfigFile);
                        Environment.Exit(0);
                    }
                    else if (version != Params.CurrentVersion)
                    {
                        MessageBox.Show("This language pack is for an older version of CQE. Please update it.", "CQE - Older Language", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (File.Exists(Configs.ConfigFile))
                            File.Delete(Configs.ConfigFile);
                        Environment.Exit(0);
                    }
                    else
                    {
                        // Creating the iterator
                        XPathExpression expr = nav.Compile("/*/*");
                        XPathNodeIterator iterator = nav.Select(expr);

                        // Analyzing all 
                        while (iterator.MoveNext())
                        {
                            XPathNavigator typeNavigator = iterator.Current.Clone();
                            XPathNavigator singleNavigator = iterator.Current.Clone();
                            singleNavigator.MoveToFirstChild();
                            if (typeNavigator.Name.ToLower() == "faq")
                            {
                                XPathNodeIterator faqiterator = nav.Select(nav.Compile("/*/faq/*"));
                                while (faqiterator.MoveNext())
                                {
                                    XPathNavigator faqtypeNavigator = faqiterator.Current.Clone();
                                    XPathNavigator faqsingleNavigator = faqiterator.Current.Clone();
                                    faqsingleNavigator.MoveToFirstChild();

                                    if (Dictionary.ContainsKey(faqtypeNavigator.Name))
                                    {
                                        Dictionary[faqtypeNavigator.Name].Add("faq-" + faqsingleNavigator.Name, faqsingleNavigator.Value.Replace("\\n", "\n"));
                                        while (faqsingleNavigator.MoveToNext())
                                        {
                                            Dictionary[faqtypeNavigator.Name].Add("faq-" + faqsingleNavigator.Name, faqsingleNavigator.Value.Replace("\\n", "\n"));
                                        }
                                    }
                                }
                            }
                            else if (Dictionary.ContainsKey(typeNavigator.Name))
                            {
                                if (typeNavigator.HasAttributes)
                                {
                                    if (typeNavigator.GetAttribute("special", "") == "true")
                                    {
                                        // Special attributes checks
                                    }
                                }
                                else
                                {
                                    // Checking specials command lines
                                    if (singleNavigator.HasAttributes)
                                    {
                                        XPathNavigator attributeNavigator = singleNavigator.Clone();
                                        attributeNavigator.MoveToFirstAttribute();
                                        if (attributeNavigator.Name == "key")
                                        {   // Menu Alt Key
                                            int value = int.Parse(attributeNavigator.Value);
                                            string toinsert = singleNavigator.Value;
                                            toinsert = toinsert.Insert(value - 1, "&");
                                            Dictionary[typeNavigator.Name].Add(singleNavigator.Name, toinsert);
                                        }
                                        else if (attributeNavigator.Name == "newline")
                                        {   // Need to replace \n
                                            Dictionary[typeNavigator.Name].Add(singleNavigator.Name, singleNavigator.Value.Replace("\\n", "\n"));
                                        }
                                        else
                                        {   // To avoid errors
                                            Dictionary[typeNavigator.Name].Add(singleNavigator.Name, singleNavigator.Value);
                                        }
                                    }
                                    else
                                    {
                                        Dictionary[typeNavigator.Name].Add(singleNavigator.Name, singleNavigator.Value);
                                    }
                                    // Adding all other strings to the specified dictionary
                                    while (singleNavigator.MoveToNext())
                                    {
                                        // Checking specials command lines
                                        if (singleNavigator.HasAttributes)
                                        {
                                            XPathNavigator attributeNavigator = singleNavigator.Clone();
                                            attributeNavigator.MoveToFirstAttribute();
                                            if (attributeNavigator.Name == "key")
                                            {   // Menu Alt Key
                                                int value = int.Parse(attributeNavigator.Value);
                                                string toinsert = singleNavigator.Value;
                                                toinsert.Insert(value - 1, "&");
                                                Dictionary[typeNavigator.Name].Add(singleNavigator.Name, toinsert);
                                            }
                                            else if (attributeNavigator.Name == "newline")
                                            {   // Need to replace \n
                                                Dictionary[typeNavigator.Name].Add(singleNavigator.Name, singleNavigator.Value.Replace("\\n", "\n"));
                                            }
                                            else
                                            {   // To avoid errors
                                                Dictionary[typeNavigator.Name].Add(singleNavigator.Name, singleNavigator.Value);
                                            }
                                        }
                                        else
                                        {
                                            Dictionary[typeNavigator.Name].Add(singleNavigator.Name, singleNavigator.Value);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Corrupted Language pack.", "CQE - Corrupted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (File.Exists(Configs.ConfigFile))
                                    File.Delete(Configs.ConfigFile);
                                Environment.Exit(0);
                            }
                        }

                        string[] monsters = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Monsters.txt", Encoding.UTF8);
                        for (int i = 0; i < DataClass.strMonsterNamesSimple.Length; i++)
                        {
                            DataClass.strMonsterNamesSimple[i] = monsters[i].Trim();
                        }

                        string[] items = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Items.txt", Encoding.UTF8);
                        for (int i = 0; i < DataClass.ResouresNameSimple.Length; i++)
                        {
                            DataClass.ResouresNameSimple[i] = items[i].Trim();
                        }

                        string[] skills = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Skills.txt", Encoding.UTF8);
                        for (int i = 0; i < skills.Length; i++)
                        {
                            dict_skills.Add(i.ToString(), skills[i].Trim());
                        }

                        skills = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "SkillSystem.txt", Encoding.UTF8);
                        for (int i = 0; i < skills.Length-1; i++)
                        {
                            dict_skillsys.Add("S" + i, skills[i].Trim());
                        }
                        dict_skillsys.Add("ST", skills[skills.Length - 1]);

                        // Challenge Loader
                        string[] equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Helms.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_helms.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Plates.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_plates.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Arms.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_arms.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Waists.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_waists.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Legs.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_legs.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Decorations.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_decorations.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Charms.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_charms.Add(i.ToString(), equips[i].Trim());
                        }


                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "GreatSwords.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_greatswords.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "ShiledAndSwords.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_shieldandswords.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Hammers.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_hammers.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Lances.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_lances.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "HeavyBowguns.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_heavygun.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "LightBowguns.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_lightgun.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "LongSwords.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_longswords.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "SwitchAxes.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_axes.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Gunlances.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_gunlances.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Bows.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_bows.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "DualSwords.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_dualswords.Add(i.ToString(), equips[i].Trim());
                        }

                        equips = File.ReadAllLines("Lang" + Path.DirectorySeparatorChar + langId + Path.DirectorySeparatorChar + "Horns.txt", Encoding.UTF8);
                        for (int i = 0; i < equips.Length; i++)
                        {
                            dict_horns.Add(i.ToString(), equips[i].Trim());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "CQE - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (File.Exists(Configs.ConfigFile))
                        File.Delete(Configs.ConfigFile);
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show("Language pack \"" + langId + "\" not found. Please check for it.", "CQE - Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (File.Exists(Configs.ConfigFile))
                    File.Delete(Configs.ConfigFile);
                Environment.Exit(0);
            }
        }


    }
}