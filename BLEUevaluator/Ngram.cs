﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLEUevaluator
{
    public class Ngram
    {

        private List<string> toks;
        private int hash = 0;

        public Ngram(List<string> toks)
        {
            this.toks = toks;
        }

        public int hashCode()
        {
            if (hash == 0)
            {
                foreach (string tok in toks)
                {
                    hash ^= smear(tok.GetHashCode());
                }
            }
            return hash;
        }

        static int smear(int hashCode)
        {
            hashCode ^= (hashCode >> 20) ^ (hashCode >> 12);
            return hashCode ^ (hashCode >> 7) ^ (hashCode >> 4);
        }

        public bool equals(object obj)
        {
            if (obj is Ngram) {
                // TODO: Slow 
                Ngram other = (Ngram)obj;
                return toks.Equals(other.toks);
            } else {
                throw new Exception("Comparing n-gram to non-n-gram");
            }
        }

        public override string ToString()
        {
            return toks.ToString();
        }
    }
}
