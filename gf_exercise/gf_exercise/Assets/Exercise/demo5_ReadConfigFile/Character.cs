using GameFramework.DataTable;
using UnityGameFramework.Runtime;

namespace demo5
{
    public class Character: DataRowBase
    {
        
        public override bool ParseDataRow(string dataRowString, object userData)
        {
            string[] text = dataRowString.Split('\t');
            int index = 0;
            index++; // 跳过#注释列
            index++;
            //Id = int.Parse(text[index++]);
            Name = text[index++];
            Department = text[index++];
            Atk = int.Parse(text[index++]);
            Def = int.Parse(text[index++]);
            Spd = int.Parse(text[index++]);
            return true;
        }
        
        public override int Id { get; }
        public string Name { get; private set; }
        public string Department { get; private set; }
        public int Atk { get; private set; }
        public int Def { get; private set; }
        public int Spd { get; private set; }

    }
}