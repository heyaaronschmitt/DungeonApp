namespace DungeonLibrary
{
    public class Character
    {
        //Funny  - Fields
        /*
            name – string
            hitChance – int
            block – int
         */
        private int _life;
        private int _maxLife;
        //People - Properties (props)
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        //Alternative shortcut, only if we don't have business rules
        //public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                //Business rule: Life should not be MORE than MaxLife
                if (value <= MaxLife)
                {
                    //good to go
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else
            }//end set
        }//end Life prop

        //Collect - Constructors (ctors)
        //1 fully qualified constructor

        //Monkeys - Methods
        //ToString()
        //CalcBlock() -> return Block
        //CalcHitChance() -> return HitChance
        //CalcDamage() -> Return 0;
    }
}