﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExerciseOrderBy
{
    public class ArrayFormat
    {
        public string FormatSpecialCharacters(string text)
        {
            Regex expression = new Regex("[^a-z0-9]");
            text = expression.Replace(text, " ");
            return text;
        }

        public string[] TextToFormattedArray(string text)
        {
            string formattedText = FormatSpecialCharacters(text);
            string[] array = formattedText.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return array;
        }

        public string[] OrderByAscending(string[] array)
        {
            string[] orderedArray = array.OrderBy(x => x.ToLower()).ToArray();
            return orderedArray;
        }
    }
}
