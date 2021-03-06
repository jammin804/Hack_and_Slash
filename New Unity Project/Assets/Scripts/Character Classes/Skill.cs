﻿public class Skill : ModifyStat {
	private bool _known;

	public Skill(){
		_known = false;
		ExpToLevel = 25;
		LevelModifier = 1.1f;
	}

	public bool Known{
		get{return _known;}
		set{_known = value;}
	}
	
}

public enum SkillName{
	Melee_Offence,
	Melee_Defence,
	Range_Offence,
	Range_Defence,
	Magic_Offence,
	Magic_Defence
}
