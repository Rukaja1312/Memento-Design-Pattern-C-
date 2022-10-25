using System;
namespace MamentoSanAndreas
{
    public class SaveGame
    {
       // private List<HeroMemento> savesList = new List<HeroMemento>();
        private Stack<HeroMemento> saves = new Stack<HeroMemento>();

        public void Add(HeroMemento cj)
        {
            saves.Push(cj);
            //savesList.Add(cj);
        }

        public HeroMemento GetSave()//int index)
        {
            return saves.Pop();
            //return saveList[index];
        }
    }
}

