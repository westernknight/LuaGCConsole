



GameManager.instance:EmptyMoney()
GameManager.instance:AppendMoney(10000);

headquarter = GameObject.FindObjectOfType(Headquarter.GetClassType())
headquarter.status.hp = 2000
headquarter:AutoUpdateAttribute();
headquarter:ResetHPAndMP();


hero = GameObject.FindObjectOfType(Hero.GetClassType());
print(hero)