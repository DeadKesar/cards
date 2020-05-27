using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Serializable]
    public class Card
    {
        /// <summary>
        /// вариант с неизвестным
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// правильный ответ
        /// </summary>
        public string Answer { get; set; }
        /// <summary>
        /// количество ошибок на слове.
        /// </summary>
        public int Level { get; set; }

        public Card(string quest, string answ,int levl = 0)
        {
            Question = quest;
            Answer = answ;
            Level = levl;
        }

    }
}
