﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StUtil.Parser
{
    public abstract class BaseParser<T> : BaseParser
    {
        public abstract object GetResults(char c);

    }
    public abstract class BaseParser
    {
        public string ParseString { get; set; }
        public int ParseIndex { get; set; }
        public List<Token> Tokens { get; set; }

        protected string CurrentToken { get; set; }
        protected int CurrentTokenIndex { get; set; }

        public bool IsEOF
        {
            get
            {
                return ParseIndex == ParseString.Length;
            }
        }
       
        public bool IsBOF
        {
            get
            {
                return ParseIndex == 0;
            }
        }

        public void Parse(string text)
        {
            ParseIndex = 0;
            ParseString = text;
            Tokens = new List<Token>();

            while (!IsEOF)
            {
                Char? c = HandleCharacter(NextCharacter());
                if (c.HasValue)
                {
                    AppendToCurrentToken(c.Value);
                }
            }
            StoreCurrentToken(CurrentToken);
        }

        public char NextCharacter(int count = 1, bool consume = true)
        {
            if (IsEOF)
            {
                throw new IndexOutOfRangeException("EOF");
            }
            char c = '\0';
            if (consume)
            {
                for (int i = 0; i < count; i++)
                {
                    c = ParseString[ParseIndex++];
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    c = ParseString[ParseIndex];
                }
            }
            return c;
        }

        public char PreviousCharacter(int count)
        {
            if (IsBOF)
            {
                throw new IndexOutOfRangeException("BOF");
            }
            return ParseString[ParseIndex - count];
        }

        public void ConsumeCharacters(int count)
        {
            ParseIndex += count;
        }

        public virtual void StoreCurrentToken(string type = null, object tag = null)
        {
            if (CurrentToken == null)
            {
                return;
            }
            if (CurrentTokenIndex == -1)
            {
                throw new FormatException("CurrentTokenIndex not set");
            }
          
            Tokens.Add(new Token { Index = CurrentTokenIndex, Value = CurrentToken, Type = type, Tag = tag });
            CurrentToken = null;
            CurrentTokenIndex = -1;
        }

        public void AppendToCurrentToken(char c)
        {
            if (CurrentToken == null)
            {
                CurrentToken = c.ToString();
                CurrentTokenIndex = ParseIndex;
            }
            else
            {
                CurrentToken += c;
            }
        }
            
        public abstract char? HandleCharacter(char c);
        public abstract T GetResults<T>() where T : class;
    }
}