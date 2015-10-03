using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceClass
{
    public class Player
    {
        private readonly int intSizeModifierMinimum = -8;
        private int intStrength;
        private int intDexterity;
        private int intConstitution;
        private int intIntelligence;
        private int intWisdom;
        private int intCharisma;
        private int intFortitudeBonus;
        private int intReflexBonus;
        private int intWillpowerBonus;
        private int intArmorBonus;
        private int intShieldBonus;
        private int intEnhancementBonus;
        private int intDeflectionBonus;
        private int intNaturalArmor;
        private int intDodgeBonus;
        private int intSizeModifier;
        private int intLevel;

        public readonly int IntArmorClassBase = 10;

        /// <summary>
        /// Character's Height (Feet and Inches)
        /// </summary>
        public string StrHeight { get; set; }

        /// <summary>
        /// Character's Weight (in pounds)
        /// </summary>
        public string StrWeight { get; set; }
        
        /// <summary>
        /// Character's Hair Color
        /// </summary>
        public string StrHairColor { get; set; }
        
        /// <summary>
        /// Character's Eye Color
        /// </summary>
        public string StrEyeColor { get; set; }
        
        /// <summary>
        /// Character's Size
        /// </summary>
        public string StrSize { get; set; }
        
        /// <summary>
        /// Character's Speed (In feet per round)
        /// </summary>
        public int IntSpeed { get; set; }
        
        /// <summary>
        /// Character's Vision Type
        /// </summary>
        public string StrVision { get; set; }
        
        /// <summary>
        /// Character's Gender
        /// </summary>
        public string StrGender { get; set; }
        
        /// <summary>
        /// Character's Name.
        /// </summary>
        public string StrName { get; set; }
        
        /// <summary>
        /// Character's Class 
        /// </summary>
        public int IntLevel
        {
            get { return intLevel; }
            set
            {
                if (value >= 1)
                {
                    intLevel = value;
                }
                else
                {
                    intLevel = 1;
                }
            }
        }
        
        /// <summary>
        /// Character's Strength Score
        /// </summary>
        public int IntStrength
        {
            get { return intStrength; }
            set
            {
                if (value >= 0)
                {
                    intStrength = value;
                }
                else
                {
                    intStrength = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Dexterity Score
        /// </summary>
        public int IntDexterity
        {
            get { return intDexterity; }
            set
            {
                if (value >= 0)
                {
                    intDexterity = value;
                }
                else
                {
                    intDexterity = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Constitution Score
        /// </summary>
        public int IntConstitution
        {
            get { return intConstitution; }
            set
            {
                if (value >= 0)
                {
                    intConstitution = value;
                }
                else
                {
                    intConstitution = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Intelligence Score
        /// </summary>
        public int IntIntelligence
        {
            get { return intIntelligence; }
            set
            {
                if (value >= 0)
                {
                    intIntelligence = value;
                }
                else
                {
                    intIntelligence = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Wisdom Score
        /// </summary>
        public int IntWisdom
        {
            get { return intWisdom; }
            set
            {
                if (value >= 0)
                {
                    intWisdom = value;
                }
                else
                {
                    intWisdom = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Charisma Score
        /// </summary>
        public int IntCharisma
        {
            get { return intCharisma; }
            set
            {
                if (value >= 0)
                {
                    intCharisma = value;
                }
                else
                {
                    intCharisma = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Fortitude Save Bonus
        /// </summary>
        public int IntFortitudeBonus
        {
            get { return intFortitudeBonus; }
            set
            {
                if (value >= 0)
                {
                    intFortitudeBonus = value;
                }
                else
                {
                    intFortitudeBonus = 0;
                }
            }
        }

        /// <summary>
        /// Character's Reflex Saving Bonus
        /// </summary>
        public int IntReflexBonus
        {
            get { return intReflexBonus; }
            set
            {
                if (value >= 0)
                {
                    intReflexBonus = value;
                }
                else
                {
                    intReflexBonus = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Willpower Save Bonus
        /// </summary>
        public int IntWillpowerBonus
        {
            get { return intWillpowerBonus; }
            set
            {
                if (value >= 0)
                {
                    intWillpowerBonus = value;
                }
                else
                {
                    intWillpowerBonus = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Armor Bonus
        /// </summary>
        public int IntArmorBonus
        {
            get { return intArmorBonus; }
            set
            {
                if (value >= 0)
                {
                    intArmorBonus = value;
                }
                else
                {
                    intArmorBonus = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Shield Bonus
        /// </summary>
        public int IntShieldBonus
        {
            get { return intShieldBonus; }
            set
            {
                if (value >= 0)
                {
                    intShieldBonus = value;
                }
                else
                {
                    intShieldBonus = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Enhancement Bonus
        /// </summary>
        public int IntEnhancementBonus 
        {
            get { return intEnhancementBonus; }
            set
            {
                if (value >= 0)
                {
                    intEnhancementBonus = value;
                }
                else
                {
                    intEnhancementBonus = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Deflection Bonus
        /// </summary>
        public int IntDeflectionBonus 
        {
            get { return intDeflectionBonus; }
            set
            {
                if (value >= 0)
                {
                    intDeflectionBonus = value;
                }
                else
                {
                    intDeflectionBonus = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Natural Armor Bonus
        /// </summary>
        public int IntNaturalArmor 
        {
            get { return intNaturalArmor; }
            set
            {
                if (value >= 0)
                {
                    intNaturalArmor = value;
                }
                else
                {
                    intNaturalArmor = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's Dodge Bonus
        /// </summary>
        public int IntDodgeBonus 
        {
            get { return intDodgeBonus; }
            set
            {
                if (value >= 0)
                {
                    intDodgeBonus = value;
                }
                else
                {
                    intDodgeBonus = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's size modifier.
        /// </summary>
        public int IntSizeModifier 
        {
            get { return intSizeModifier; }
            set
            {
                if (value >= intSizeModifierMinimum)
                {
                    intSizeModifier = value;
                }
                else
                {
                    intSizeModifier = 0;
                }
            }
        }
        
        /// <summary>
        /// Character Languages Spoken
        /// </summary>
        public List<string> StrLanguages { get; set; }

        /// <summary>
        /// Get the Ability Modifier Score for any Ability Score
        /// </summary>
        /// <param name="intAbilityScore"></param>
        /// <returns>A modifier of -5 or Greater</returns>
        public int GetAbilityModifierBonus(int intAbilityScore)
        {
            decimal decModifier = 0;
            int intModifier;
            decModifier = (intAbilityScore - 10) / 2;
            intModifier = (int)Math.Floor(decModifier);
            if (intModifier >= -5)
            {
                return intModifier;
            }
            else
            {
                return -5;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetCombatManeuverBonus()
        {
            int intCombatManeuverBonus = 0;

            return intCombatManeuverBonus;
        }

        /// <summary>
        /// Calculates the CombatManeuverDefense of the Player.
        /// </summary>
        /// <returns></returns>
        public int GetCombatManeuverDefense()
        {
            int intCombatManeuverDefense = 10;

            return intCombatManeuverDefense;
        }

        /// <summary>
        /// Calculates the Player's Armor class rating.
        /// </summary>
        /// <returns></returns>
        public int GetArmorClass()
        {
            int intArmorClass = IntArmorClassBase + IntArmorBonus + IntShieldBonus + IntEnhancementBonus + IntDeflectionBonus + IntNaturalArmor + IntDodgeBonus + IntSizeModifier + GetAbilityModifierBonus(IntDexterity);
            return intArmorClass;
        }

        /// <summary>
        /// Calculates the character's bonus for a willpower saving throw.
        /// </summary>
        /// <returns></returns>
        public int GetWillpowerSavingThrowModifier()
        {
            int intWillpowerSavingThrow = 0;

            return intWillpowerSavingThrow;
        }

        /// <summary>
        /// Calculates the character's bonus for a reflex saving throw.
        /// </summary>
        /// <returns></returns>
        public int GetReflexSavingThrowModifier()
        {
            int intReflexSavingThrow = 0;

            return intReflexSavingThrow;
        }

        /// <summary>
        /// Calculates the character's bonus for a fortitude saving throw.
        /// </summary>
        /// <returns></returns>
        public int GetFortitudeSavingThrowModifier()
        {
            int intFortitudeSavingThrow = 0;

            return intFortitudeSavingThrow;
        }

        /// <summary>
        /// This gets the Attribute Bonuse for any given speciality stat.
        /// </summary>
        /// <param name="intAttribute">An int that represents a physical or mental stat that a character has.</param>
        /// <returns></returns>
        private int GetAttributeBonus(int intAttribute)
        {
            int intAttributeModification = 10;
            int intAttributeDivisor = 2;
            double dblAttributeBonus = 0;
            int intAttributeBonus = 0;

            int intNewAttribute = intAttribute - intAttributeModification;

            dblAttributeBonus = intNewAttribute / intAttributeDivisor;
            if(dblAttributeBonus <= 0)
            {
                dblAttributeBonus = Math.Floor(dblAttributeBonus);
            }
            else
            {
                dblAttributeBonus = Math.Round(dblAttributeBonus);
            }
            intAttributeBonus = (int)dblAttributeBonus;

            return intAttributeBonus;
        }
    }
}
