using System;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random = new Random();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void HideRandomWords(int numberToHide = 3)
        {
            var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            for (int i = 0; i < numberToHide && visibleWords.Any(); i++)
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }

        public string GetDisplayText()
        {
            string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            return $"{_reference.GetDisplayText()}\n{scriptureText}";
        }
    }
}
