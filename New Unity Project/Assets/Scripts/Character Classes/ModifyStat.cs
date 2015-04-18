using System.Collections.Generic;

public class ModifyStat : BaseStat {
	private List<ModifyingAttribute> _mods;		//List of Attributes that modify the stat
	private int _modValue;						//Store the amount added to the baseValue from the modifiers

	public ModifyStat(){
		_mods = new List<ModifyingAttribute> ();
		_modValue = 0;
	}

	public void AddModifier(ModifyingAttribute mod){
		_mods.Add(mod);
	}

	private void CalulateModValue(){
		_modValue = 0;

		if (_mods.Count > 0) {
			foreach(ModifyingAttribute att in _mods)
				_modValue += (int)(att.attribute.AdjustedBaseValue * att.ratio);
		}
	}

	public new int AdjustedBaseValue{
		get{ return BaseValue + BuffValue + _modValue;}
	}

	public void Update(){
		CalulateModValue();
	}
}

public struct ModifyingAttribute {
	public Attribute attribute;
	public float ratio;
}