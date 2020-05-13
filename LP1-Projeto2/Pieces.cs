namespace LP1_Projeto2
{
    public class Pieces
    {
        private string name;
        private int [] pos;
        private bool alive;

        public Pieces(string name ,int [] pos)
        {
            SetName(name);
            SetPos(pos);
            alive = true;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public int [] GetPos()
        {
            return pos;
        }
        public void SetPos(int [] pos)
        {
            this.pos = pos;
        }

        public bool GetAlive()
        {
            return alive;
        }

    }
}