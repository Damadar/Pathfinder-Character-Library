using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceClass
{
    public class Player
    {

        #region Private Variables

        private readonly int intSizeModifierMinimum = -8;
        private readonly int intSizeModifierMaximum = 8;
        private readonly int intBaseAttackBonusMinimum = 0;
        private readonly int intSaveBonusMinimum = 0;
        private readonly int intStatMinimum = 1;
        private readonly int intLevelMinimum = 1;
        private readonly int intAttackNumberModifier = 5;
        private readonly int intMinimumNumberOfAttacks = 1;
        private int intStrength;
        private int intDexterity;
        private int intConstitution;
        private int intIntelligence;
        private int intWisdom;
        private int intCharisma;
        private int intFortitudeBonus;
        private int intReflexBonus;
        private int intWillpowerBonus;
        private int intBaseAttackBonus;
        private int intArmorBonus;
        private int intShieldBonus;
        private int intEnhancementBonus;
        private int intDeflectionBonus;
        private int intNaturalArmor;
        private int intDodgeBonus;
        private int intSizeModifierArmor;
        private int intSizeModifierCombat;
        private int intLevel;

        #endregion

        #region Public Variables

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
                if (value >= intLevelMinimum)
                {
                    this.intLevel = value;
                }
                else
                {
                    this.intLevel = intLevelMinimum;
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
                if (value >= intStatMinimum)
                {
                    this.intStrength = value;
                }
                else
                {
                    this.intStrength = intStatMinimum;
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
                if (value >= intStatMinimum)
                {
                    this.intDexterity = value;
                }
                else
                {
                    this.intDexterity = intStatMinimum;
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
                    this.intConstitution = value;
                }
                else
                {
                    this.intConstitution = intStatMinimum;
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
                if (value >= intStatMinimum)
                {
                    this.intIntelligence = value;
                }
                else
                {
                    this.intIntelligence = intStatMinimum;
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
                if (value >= intStatMinimum)
                {
                    this.intWisdom = value;
                }
                else
                {
                    this.intWisdom = intStatMinimum;
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
                if (value >= intStatMinimum)
                {
                    this.intCharisma = value;
                }
                else
                {
                    this.intCharisma = intStatMinimum;
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
        /// The base attack bonus of the character.
        /// </summary>
        public int IntBaseAttackBonus
        {
            get { return intBaseAttackBonus; }
            set
            {
                if(value >= intBaseAttackBonusMinimum)
                {
                    this.intBaseAttackBonus = value;
                }
                else
                {
                    this.intBaseAttackBonus = intBaseAttackBonusMinimum;
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
        /// Character's size modifier for Armor.
        /// </summary>
        public int IntSizeModifierArmor 
        {
            get { return intSizeModifierArmor; }
            set
            {
                if (value >= intSizeModifierMinimum && value <= intSizeModifierMaximum)
                {
                    intSizeModifierArmor = value;
                }
                else
                {
                    intSizeModifierArmor = 0;
                }
            }
        }
        
        /// <summary>
        /// Character's size modifier for Combat.
        /// </summary>
        public int IntSizeModifierCombat
        {
            get { return intSizeModifierCombat; }
            set
            {
                if(value >= intSizeModifierMinimum && value <= intSizeModifierMaximum)
                {
                    intSizeModifierCombat = value;
                }
                else
                {
                    intSizeModifierCombat = 0;
                }
            }
        }

        /// <summary>
        /// Character Languages Spoken
        /// </summary>
        public List<string> StrLanguages { get; set; }

        /// <summary>
        /// Weapons that a character is proficient with.
        /// </summary>
        public List<string> StrWeapons { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Basic instantiation of this class.
        /// </summary>
        public Player()
        {

        }

        /// <summary>
        /// Instantiate player class with Character Name.
        /// </summary>
        /// <param name="strName">The Character's Name.</param>
        public Player(string strName)
        {
            this.StrName = strName;
        }

        /// <summary>
        /// Get the Ability Modifier Score for any Ability Score
        /// </summary>
        /// <param name="intAbilityScore"></param>
        /// <returns>A modifier of -5 or Greater</returns>
        public int GetAbilityModifierBonus(int intAbilityScore)
        {
            decimal decModifier = 0;
            int intModifier;
            int intModifierMinimum = -5;

            decModifier = (intAbilityScore - 10) / 2;
            intModifier = (int)Math.Floor(decModifier);
            if (intModifier >= intModifierMinimum)
            {
                return intModifier;
            }
            else
            {
                return intModifierMinimum;
            }
        }

        /// <summary>
        /// This gets the Combat Maneuver Bonus.
        /// </summary>
        /// <returns></returns>
        public int GetCombatManeuverBonus()
        {
            int intCombatManeuverBonus = this.IntBaseAttackBonus + this.IntSizeModifierCombat + GetAttributeBonus(this.IntStrength);

            return intCombatManeuverBonus;
        }

        /// <summary>
        /// Calculates the CombatManeuverDefense of the Player.
        /// </summary>
        /// <returns></returns>
        public int GetCombatManeuverDefense()
        {
            int intCombatManeuverDefense = IntArmorClassBase + GetAbilityModifierBonus(this.IntStrength) + GetAbilityModifierBonus(this.IntDexterity) + this.IntSizeModifierCombat;

            return intCombatManeuverDefense;
        }

        /// <summary>
        /// Calculates the Player's Armor class rating.
        /// </summary>
        /// <returns></returns>
        public int GetArmorClass()
        {
            int intArmorClass = IntArmorClassBase + IntArmorBonus + IntShieldBonus + IntEnhancementBonus + IntDeflectionBonus + IntNaturalArmor + IntDodgeBonus + IntSizeModifierArmor + GetAbilityModifierBonus(IntDexterity);
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
        /// Gets the number of attacks a player has.
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfAttacks()
        {
            int intNumberOfAttacks = this.IntBaseAttackBonus % intAttackNumberModifier;

            if (intNumberOfAttacks < intMinimumNumberOfAttacks)
            {
                intNumberOfAttacks = intMinimumNumberOfAttacks;
            }

            return intNumberOfAttacks;
        }

        /// <summary>
        /// This adds a language for the character.
        /// </summary>
        /// <param name="strLanguage"></param>
        public void AddCharacterLanguage(string strLanguage)
        {
            if(!this.StrLanguages.Contains(strLanguage))
            {
                this.StrLanguages.Add(strLanguage);
            }
        }

        /// <summary>
        /// This removes a language for the character.
        /// </summary>
        /// <param name="strLanguage"></param>
        public void RemoveCharacterLanguage(string strLanguage)
        {
            if(this.StrLanguages.Contains(strLanguage))
            {
                this.StrLanguages.Remove(strLanguage);
            }
        }

        /// <summary>
        /// Add a weapon to the character's proficiencies.
        /// </summary>
        /// <param name="strWeapon"></param>
        public void AddCharacterWeapon(string strWeapon)
        {
            if(!this.StrWeapons.Contains(strWeapon))
            {
                this.StrWeapons.Add(strWeapon);
            }
        }

        /// <summary>
        /// Remove a weapon from the character's proficiencies.
        /// </summary>
        /// <param name="strWeapon"></param>
        public void RemoveCharacterWeapon(string strWeapon)
        {
            if(this.StrWeapons.Contains(strWeapon))
            {
                this.StrWeapons.Remove(strWeapon);
            }
        }

        #endregion

        #region Private Methods

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

        #endregion

    }
}
