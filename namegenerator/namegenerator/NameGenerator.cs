using System;
using System.Collections.Generic;
using System.Text;

namespace namegenerator
{
    class NameGenerator
    {
        public NameGenerator(int maxSylables)
        {
            // return a random name from 1 to maxSyllables syllables
            choose = new Random();
            Maximum_syllables = maxSylables;
        }


        public string generate_name(bool isPlaceName, bool dividesyllables)
        {
            return generate_name(Maximum_syllables, isPlaceName, dividesyllables);
        }

        public string generate_name(int maxSyllables, bool placeName, bool dividesyllables)
        {
            int choice;
            string result = Assemble_Name(maxSyllables, dividesyllables);
            if (placeName)
            {
                choice = choose.Next(place_suffixes.Length);
                result += place_suffixes[choice];
                if (choose.Next(3) == 0)
                {
                    result = "New " + capitalize_string(result);
                }
                return capitalize_string(result);
            }
            else
            {
                return capitalize_string(result);
            }
        }

        public string generate_demon_name(int maxSyllables)
        {
            string result = "";
            switch (choose.Next(8))
            {
                case 0:
                    result = generate_name(maxSyllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 1:
                    result = generate_name(maxSyllables, false, false) + ", The " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 2:
                    result = generate_name(maxSyllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)];
                    break;
                case 3:
                    result = generate_name(maxSyllables, false, false) + ", The " + titles[choose.Next(titles.Length)] + " of " + adjectives[choose.Next(adjectives.Length)] + " " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 4:
                    result = generate_name(maxSyllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)] + " of " + adjectives[choose.Next(adjectives.Length)] + " " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 5:
                    result = generate_name(maxSyllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + ", " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)];
                    break;
                case 6:
                    result = generate_name(maxSyllables, false, false) + ", The " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)] + " and " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 7:
                    result = generate_name(maxSyllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)] + " and " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
            }
            return result;
        }

        public string generate_demon_name()
        {
            string result = "";
            switch (choose.Next(8))
            {
                case 0:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 1:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 2:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)];
                    break;
                case 3:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + titles[choose.Next(titles.Length)] + " of " + adjectives[choose.Next(adjectives.Length)] + " " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 4:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)] + " of " + adjectives[choose.Next(adjectives.Length)] + " " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 5:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + ", " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)];
                    break;
                case 6:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)] + " and " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
                case 7:
                    result = generate_name(Maximum_syllables, false, false) + ", The " + adjectives[choose.Next(adjectives.Length)] + " " + titles[choose.Next(titles.Length)] + " of " + domains_evil[choose.Next(domains_evil.Length)] + " and " + domains_evil[choose.Next(domains_evil.Length)];
                    break;
            }
            return result;
        }

        public long total_demon_titles()
        {
            long total = 
                (long)(adjectives.Length * titles.Length * domains_evil.Length) +                         // case 0
                (long)(titles.Length * domains_evil.Length) +                                             // case 1
                (long)(adjectives.Length * titles.Length) +                                               // case 2
                (long)(titles.Length * adjectives.Length * domains_evil.Length) +                         // case 3
                (long)(adjectives.Length * titles.Length * adjectives.Length * domains_evil.Length) +     // case 4
                (long)(adjectives.Length * adjectives.Length * titles.Length) +                           // case 5
                (long)(titles.Length * domains_evil.Length * domains_evil.Length) +                       // case 6
                (long)(adjectives.Length * titles.Length * domains_evil.Length * domains_evil.Length);    // case 7
            return total;
        }

        //public int total_demon_titles()
        //{
        //    return (adjectives.Length * titles.Length * domains_evil.Length) +                      // case 0
        //        (titles.Length * domains_evil.Length) +                                             // case 1
        //        (adjectives.Length * titles.Length) +                                               // case 2
        //        (titles.Length * adjectives.Length * domains_evil.Length) +                         // case 3
        //        (adjectives.Length * titles.Length * adjectives.Length * domains_evil.Length) +     // case 4
        //        (adjectives.Length * adjectives.Length * titles.Length);
        //}
        private string capitalize_string(string in_string)
        {
            string result;
            char[] result_chararray = in_string.ToCharArray();
            result_chararray[0] = (((result_chararray[0].ToString() as string).ToUpper()).ToCharArray())[0];
            StringBuilder sb = new StringBuilder();
            result = sb.Append(result_chararray).ToString();
            return result;
        }

        private string Assemble_Name(int maxClusters, bool dividesyllables)
        {
            int i;
            string result = "";
            int choice;
            Clustertypes current_clustertype;
            choice = choose.Next(2);
            // generate the first part of the word
            bool capitalize = false;
            current_clustertype = generate_first(ref result);
            int nextHyphenPosition = choose.Next(2, 4);
            int iterHyphenPos = 0; // counts the number of clusters since we last placed a hyphen
            for (i = 1; i < (maxClusters - 1); i++)
            {
                if (dividesyllables)
                {
                    result += "-";
                }
                else
                {   // Break up words with hyphens between the clusters
                    if ((i < (maxClusters - 2)) && (iterHyphenPos == nextHyphenPosition))
                    {
                        result += "-";
                        capitalize = true;
                        nextHyphenPosition = choose.Next(2, 4);
                        iterHyphenPos = 0;
                    }
                    else
                    {
                        iterHyphenPos++;
                        capitalize = false;
                    }
                }

                if (current_clustertype == Clustertypes.forward)
                {
                    current_clustertype = generate_forwards(ref result, capitalize);
                }
                else if (current_clustertype == Clustertypes.shortforward)
                {
                    current_clustertype = generate_backwards(ref result, capitalize);
                }
                else if (current_clustertype == Clustertypes.backwards)
                {
                    current_clustertype = generate_backwards(ref result, capitalize);
                }
                else if (current_clustertype == Clustertypes.shortbackwards)
                {
                    current_clustertype = generate_forwards(ref result, capitalize);
                }
                else
                {
                    throw new Exception("what the hell just happended?");
                }
            }
            if (current_clustertype == Clustertypes.shortforward) // word can't end with a vowel or forward consonant
            {
                result += choose_vowel() + choose_backwards_consonant();
            }
            else if (current_clustertype == Clustertypes.forward ||
                current_clustertype == Clustertypes.shortbackwards)
            {
                result += choose_backwards_consonant();
            }
            return result;
        }

        private Clustertypes generate_forwards(ref string in_string, bool capitalize)
        {
            int choice = choose.Next(2);
            Clustertypes result;
            if (choice == 1)
            {
                if (capitalize)
                {
                    in_string += capitalize_string(choose_forwards_consonant());
                }
                else
                {
                    in_string += choose_forwards_consonant();
                }
                result = Clustertypes.shortforward;
            }
            else
            {
                if (capitalize)
                {
                    in_string += capitalize_string(choose_forwards_consonant());
                }
                else
                {
                    in_string += choose_forwards_consonant();
                }
                in_string += choose_vowel();
                result = Clustertypes.forward;
            }

            return result;
        }

        private Clustertypes generate_backwards(ref string in_string, bool capitalize)
        {
            int choice = choose.Next(2);
            Clustertypes result;
            if (choice == 1)
            {
                if (capitalize)
                {
                    in_string += capitalize_string(choose_vowel());
                }
                else
                {
                    in_string += choose_vowel();
                }
                result = Clustertypes.shortbackwards;
            }
            else
            {
                if (capitalize)
                {
                    in_string += capitalize_string(choose_vowel());
                }
                else
                {
                    in_string += choose_vowel();
                }
                in_string += choose_backwards_consonant();
                result = Clustertypes.backwards;
            }

            return result;
        }

        private Clustertypes generate_first(ref string in_string)
        {
            int choice = choose.Next(2);
            Clustertypes result;
            if (choice == 1)
            {
                in_string += vowels[choose.Next(vowels.Length)];
                result = Clustertypes.shortbackwards;
            }
            else
            {
                in_string += choose_forwards_consonant();
                in_string += choose_vowel();
                result = Clustertypes.forward;
            }
            return result;
        }

        private string choose_backwards_consonant()
        {
            int choice = choose.Next(0, 10);
            if (choice > 3)
            {
                return consonants[choose.Next(consonants.Length)];
            }
            else
            {
                return backwards_consonants[choose.Next(backwards_consonants.Length)];
            }
        }

        private string choose_forwards_consonant()
        {
            int choice = choose.Next(0, 10);
            if (choice > 3)
            {
                return consonants[choose.Next(consonants.Length)];
            }
            else
            {
                return forward_consonants[choose.Next(forward_consonants.Length)];
            }
        }

        private string choose_vowel()
        {
            //int choice = choose.Next(2);
            //if (choice == 0)
            //{
            //    return vowel_pairs[choose.Next(vowel_pairs.Length)];
            //}
            //else
            //{
            //    return vowels[choose.Next(vowels.Length)];
            //}
           return vowels[choose.Next(vowels.Length)];
        }

        private string[] vowels = {
            "a","e","i","o","u"};
        private string[] vowel_pairs = {
            "aa", "ae", "au", "ai",
            "ee", "eu", "ie", 
            "oa", "oi", "oo", "ou"
            };

        private string[] consonants = { 
            "b", "c", "d", "f", "g", "h", 
            "j", "k", "l", "m", "n", "p", 
            "r", "s", "t", "v", "w", 
            "x", "y", "z" };
        // pairs which are valid at the beginning of a syllable
        private string[] forward_consonants = {
            "th", "st", "gh", "sh", "wh", 
            "ch", "tr", "fl", "fr", "sl",
            "cl", "br", "dr", "kl", "vr",
            "kr", "pl", "pr", "bl", "sp",
            "gr", "gl", "qw"};
        // pairs which are valid at the end of a syllable
        private string[] backwards_consonants = { 
            "th", "nd", "st", "gh", "sh", 
            "ht", "ch", "rt", "ng", 
            "ll", "ly", "ld", "ck", "rch",
            "lch", "rth", "nt", "sp", "nch"
            };
        private string[] place_suffixes = {
            "ton", "ington", "ville", "side", "port",
            "borough", "burg", "fax", "opolis", "y",
            "bury", "glen", "dale", "vale", "hurst", 
            "mere", "mead", "burn", "brook", "mont", 
            "wood", " Creek", " Gap", " Pointe", "town" 
        };
             
                                           

        // Creepy Adjectives
        private string[] adjectives = { 
            "Dark", "Foul", "Ravenous", "Malevolent", "Ashen",
            "Burning", "Grinning", "Firey", "Twisted", "Unclean",
            "Infernal", "Obscene", "Profane", "Inhuman", "Gruesome",
            "Screaming", "Howling", "Bleeding", "Depraved", "Senseless",
            "Laughing", "Shrouded", "Weeping", "Secretive", "Seeping",
            "Unknowable", "Festering", "Vengeful", "Wrathful",
            "Eerie", "Bloated", "Oozing", "Dancing", "Cursed", "Accursed",
            "Mourning", "Eternal", "Unending", "Possessed", "Mysterious",
            "Black", "Red", "Abhorrent", "Dead", "Ghostly", "Sightless",
            "Lumbering", "Shadowy", "Infinite", "Chilling", "Perfidious",
            "Formless", "Unbound", "Gaunt", "Hateful", "Stygian",
            "Wailing", "Dreaming", "Silent", "Morbid", "Evil",
            "Odius", "Malignant", "Hidden", "Hungering", "Scarlet",
            "Diabolical", "Scheming", "Jabbering", "Grasping",
            "Vulgar", "Wretched", "Blind", "Devious", "Final",
            "Tainted", "Lurid", "Barren", "Clutching", "Demonic",
            "Noxious", "Grim", "Cryptic", "Ancient", "Faceless",
            "Braying", "Forgotten", "Forsaken", "Undead", "Wanton",
            "Bloody", "Delirious", "Chattering", "Cruel",
            "Bitter", "Cold", "Skulking", "Frozen", "Elder",
            "Dire", "Iron", "Baneful", "Ruthless", "Uncaring",
            "Merciless", "Unfeeling", "Relentless", "Slavering",
            "Insane", "Wicked", "Vile", "Unliving", "Sordid",
            "Unyielding", "Creeping", "Crawling", "Icy", "Doomed",
            "Blind", "Mad", "Impassive", "Awakened", "Fallen",
            "Feasting", "Unholy", "Wandering", "Lost", "Duplicitous",
            "Immortal", "Unformed", "Slumbering", "Sinister",
            "Shapeless", "Grotesque", "Dread", "Moaning", "Secret",
            "Unsettling", "Disquieting", "Terrible", "Awoken",
            "Soulless", "Misshapen", "Unnatural", "Alien",
            "Forbidden", "Unchained", "Blasphemous", "Low",
            "Revolting", "Fell", "Execrable", "Jibbering",
            "Schreeching", "Unnameable", "Pale", "Horrifying", "Mindless",
            "Unthinkable", "Spiteful", "Baleful", "Cloaked", "Writhing",
            "Chained", "Unrelenting", "Rancorous", "Churlish", "Malformed",
            "Abominable", "Odious", "Loathsome", "Supernatural"
                                      };
        
        private string[] NickAffixes = {
            "Dark", "Foul", "Ash", "Fire",
            "Fester", "Fell", "Grim", "Cold",
            "Bitter", "Chatter", "Red", "Dire",
            "Shadow", "Skitter", "Bale", "Filth",
            "Hell"
            };

        private string[] NickSuffixes = {
            "tooth", "claw", "maw", "eye", "soul",
            "fist", "wing", "jaw", "skull", "sight",
            "scream", "cloak", "crown", "belly",
            "bones", "guts", "grin", "blade", "wolf",
            "beast", "feast", "hand", "spite", "chain",
            "grave", "scale", "fur", "horn", "snout",
            "shell", "hide", "mouth"
             };

        private string[] titles = { 
            "Arbiter", "Regeant", "Prince", "Priest", "Hierophant",
            "Lord", "Aspect", "Overseer", "Praetor", "Torturer",
            "Mouth", "Spirit", "Executor", "Primeval",
            "Bringer", "Minister", "Ambassator", "Maw",
            "Emboidiment", "Avatar", "Apostle", "Shepherd",
            "Manifistation", "Exemplar", "Angel", "Pitboss",
            "King", "Overlord", "Beast", "Singer", "Hierarch",
            "Jester", "Maleficar", "Baron", "Bride", "Majesty",
            "Servant", "Imperator", "Herald", "Mask",
            "Effigy", "Symbol", "Visionary", "Messenger", "Counselor",
            "Chanter", "Captain", "Visage", "Face", "Ancient",
            "Horror", "Mother", "Father", "Reaper", "Penitent",
            "Prophet", "Pilgrim", "Tendrils", "Blighter",
            "Brother", "Emblem", "Shadow", "Count", "Eater",
            "Paragon", "Hand", "Berzerker", "Force", "Forger",
            "Reveler", "Archfiend", "Viceroy", "Incubus", "Elder",
            "Sister", "Sign", "Architect", "Jarl", "Butcher",
            "Afflicter", "Archangel", "Vessel", "Gatekeeper", 
            "Imp", "Matron", "Poet", "Wretch", "Sower",
            "Weaver", "Ritualist", "Profaner", "Archvile", "Maiden",
            "Marquis", "Duke", "Ghost", "Harbinger", "Host",
            "Fanatic", "Fiend", "Keeper", "Watcher", "Hostess",
            "Savant", "Agent", "Devout", "Undertaker",
            "Midwife", "Idol", "Figure", "Harvister",
            "Dragon", "Reaver", "Warlord", "Precursor",
            "Scarecrow", "Magnate", "Incantor", "Monarch",
            "Marauder", "Skull", "Pretender", "Seraph",
            "Graveborn", "Lorekeeper", "Pricipal", "Collector",
            "Sentinel", "Whore", "Rider", "Harborer",
            "Gatherer", "Hoarder", "Scavenger", "Flayer",
            "Joker", "Beholder", "Dervish", "Warlock",
            "Crier", "Goat", "Visitor", "Daemon", "Dreamwalker",
            "Totem", "Zealot", "Child", "Abettor",
            "Prodigy", "Caitiff", "Traveller", "Deliverer", "Pontif",
            "Being", "Entity", "Wildling", "Configuration",
            "Machine", "Delver", "Jailor", "Embodiment", "Incarnate",
            "Mutant", "Monstrosity", "UnderLord", "Potentate",
            "Mummer", "Paramount", "Essence", "Monster", "Madman",
            "Freak", "Steward", "Thing", "Merchant", "Sultan",
            "Caliph", "Demon", "Creature", "Brute", "Sorcerer",
            "Countenance", "Emperor", "Blackguard", "Augur",
            "Auspice", "Walker", "Cenobite", "Priestess",
            "Mentor", "Courtesan", "Warden", "Golem",
            "Vision", "Patriarch", "Mongrel", "Icon", "Snake",
            "Puzzler", "Bearer", "Riddler", "Speaker",
            "Rector", "Khan", "Leviathan", "Ronin", "Flame",
            "Vicar", "Master", "Seeker", "Wolf", "Hag",
            "Justicar", "Crow", "One", "Fetish", "Presence",
            "Guide", "Puppet-Master", "Spectre", "Spider",
            "Malefactor", "Devourer", "Hermit", "Revenant", "Glutton",
            "Crone", "Raven", "Witch", "Abberation", "Despot",
            "Queen", "Den Mother", "Madame", "Earl", "Ruler",
            "Gypsy", "Wanderer", "Old Man", "Abomination",
            "Phantasm", "Hellborn", "Taskmaster", "Villain", 
            "Mistress", "Apostate", "Usher", "Vanguard",
            "Councillor", "Seer", "Diviner", "Oracle", "Prognosticator",
            "Instrument", "Lady", "Magistrate", "Maniac",
            "Mastermind", "Dreamer", "Counsel", "Counsellor",
            "Consul", "Delegate", "Emmisary", "Orchestrator",
            "Conductor", "Marshal", "Watchman", "Judge",
            "Courtier", "Advocate", "Abbetor", "Proctor",
            "Broker", "Ambassador", "Wizard", "Shaman",
            "Hound", "Tormentor", "Lunatic", "Matriarch"
                                  };

        private string[] domains_evil = { 
            "Pain", "Suffering", "Wrath", "Gluttony", "Panic",
            "Greed", "Envy", "Murder", "Atrocity", "Brimstone",
            "Ruin", "Misfortune", "Disease", "War",
            "Torture", "Blood", "Bile", "Filth", "Obliteration",
            "Annihilation", "Death", "Insanity", "Pestilence",
            "Famine", "Hatred", "Misery", "Lies", "Desperation",
            "Agony", "Bones", "Viscera", "Rage", "Duplicity",
            "Despair", "Darkness", "Emptiness", "Damnation",
            "Corruption", "Depravity", "Vice", "Atrocity",
            "Ruin", "Deformity", "Ashes", "Flame",
            "Blades", "Graves", "Flies", "Decay",
            "Worms", "Maggots", "Silence", "Affliction",
            "Fire", "Massacre", "Carnage", "Treachery",
            "Deceit", "Dusk", "Delirium", "Nightmares",
            "Terror", "Fear", "Prophecies", "Sadness",
            "Solitude", "Desolation", "Undeath", "Venom",
            "Infection", "Havoc", "Treason", "Vanity",
            "Shadow", "Puppets", "Perversion", "Shackles",
            "Souls", "Secrets", "Enigmas", "Demons",
            "Devils", "Monsters", "Sacrifice", "Loss",
            "Rancor", "Stone", "Ichor", "Skulls", "Ruination",
            "Freaks", "Torment", "Dismay", "Wanderers",
            "Oblivion", "Nothingness", "Horror", "Decimation",
            "Blight", "Armegeddon", "Rapacity", "Sin",
            "Hysteria", "Thorns", "Abberations", "Voracity",
            "Storms", "Doom", "Ravens", "Ice", "Limbo",
            "Eyes", "Delusion", "Degenerates", "Violation",
            "Vermin", "Flesh", "Lust", "Regret", "Teeth", "Waste",
            "Violence", "Spiders", "Abaddon", "Pandemonium", "Plagues",
            "Anguish", "Twilight", "Sorrow", "Razors",
            "Sickness", "Whispers", "Slime", "Revenge", "Avarice",
            "Pride", "Plots", "Rot", "Night", "Corruption",
            "Riddles", "Indifference", "Lament", "Leeches",
            "Discord", "Sloth", "Mutilation", "Confusion",
            "Hellfire", "Malevolence", "Beasts", "Dementia",
            "Imps", "Crows", "Destruction", "Murderers", "Evil",
            "Madness", "Cruelty", "Pandemonium", "Anarchy",
            "Bedlam", "Chaos", "Oppression", "Scars", "Toads",
            "Mysteries", "Sabotage", "Traitors", "Poison",
            "Entrails", "Fury", "Purgatory", "Infernos", "Larceny",
            "Flames", "Vengance", "Rats", "Snakes", "Turmoil",
            "Shadows", "Delerium", "Profanity", "Slaughter", "Rancor",
            "Sorcery", "Witchcraft", "Hate"
                                   };

        private int Maximum_syllables;
        private Random choose;
        private enum Clustertypes
        {
            forward,
            shortforward,
            backwards,
            shortbackwards
        }
    }
}
