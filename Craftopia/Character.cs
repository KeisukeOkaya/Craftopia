using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Craftopia
{
	class Character
	{
		private readonly JObject mMake;
		private readonly JObject mStatus;

		public Character(JObject json)
		{
			mMake = (JObject)json["charaMakeData"];
			mStatus = (JObject)json["plStatusSaveData"];
		}

        public byte Sex
        {
            get => (byte)mMake["sex"];
            set => mMake["sex"] = value;
        }

        public byte Race
        {
            get => (byte)mMake["race"];
            set => mMake["race"] = value;
        }

        public byte BodyIndex
        {
            get => (byte)mMake["bodyIndex"];
            set => mMake["bodyIndex"] = value;
        }

        public byte Skin
        {
            get => (byte)mMake["skin"];
            set => mMake["skin"] = value;
        }

        public byte FaceIndex
        {
            get => (byte)mMake["faceIndex"];
            set => mMake["faceIndex"] = value;
        }

        public byte EyeColor
        {
            get => (byte)mMake["eyeColor"];
            set => mMake["eyeColor"] = value;
        }

        public byte EyeBrowColor
        {
            get => (byte)mMake["eyeBrowColor"];
            set => mMake["eyeBrowColor"] = value;
        }

        public byte HairIndex
        {
            get => (byte)mMake["hairIndex"];
            set => mMake["hairIndex"] = value;
        }

        public byte HairColor
        {
            get => (byte)mMake["hairColor"];
            set => mMake["hairColor"] = value;
        }

		public String Name
		{
			get { return (String)mMake["name"]; }
			set { mMake["name"] = value; }
		}

		public int Money
		{
			get { return (int)mStatus["Money"]; }
			set { mStatus["Money"] = value; }
		}

		public int SkillPoint
		{
			get { return (int)mStatus["SkillPoint"]; }
			set { mStatus["SkillPoint"] = value; }
		}

		public int Level
		{
			get { return (int)mStatus["Level"]; }
			set { mStatus["Level"] = value; }
		}

		public int Exp
		{
			get { return (int)mStatus["Exp"]; }
			set { mStatus["Exp"] = value; }
		}

        public int HpIncreaseCount
        {
            get { return (int)mStatus["hpIncreaseCount"]; }
            set { mStatus["hpIncreaseCount"] = value; }
        }

        public int MpIncreaseCount
        {
            get { return (int)mStatus["mpIncreaseCount"]; }
            set { mStatus["mpIncreaseCount"] = value; }
        }

        public int StIncreaseCount
        {
            get { return (int)mStatus["stIncreaseCount"]; }
            set { mStatus["stIncreaseCount"] = value; }
        }
	}
}
