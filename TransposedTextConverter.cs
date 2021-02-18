using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using leftTransposingByOne.Helpers;

namespace leftTransposingByOne.Models
{
    public class TransposedTextConverter
    {
        public TransposedTextConverter() { }
        public TransposedTextConverter(string code)
        {
            CodedText = code;
        }

        // this is the number of entries in the dictionary
        private readonly int DictionarySize = 52;
        public string CodedText { get; set; }

        public string DecodedText => DecodeText();
        public string DecodeText()
        {
            string decoded = String.Empty;
            for (int i = 0; i < CodedText.Length; i++)
            {
                // do changes if 
                if (Helper.AlphabetNumberDictionary
                    .TryGetValue(CodedText[i], out int index))
                {
                    // wraparound fix for a and A
                    if (index == 1 || index == 27)
                    {
                        index += 26;
                    }
                    index -= 1;
                    // index = Helper.Mod(index, DictionarySize);
                    decoded += Helper.AlphabetNumberDictionary
                        .FirstOrDefault(x => x.Value == index).Key;
                }
                else
                {
                    decoded += CodedText[i];
                }
            }

            return decoded;
        }


    }
}
