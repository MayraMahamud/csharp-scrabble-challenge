using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        //public int score { get; set; }
        private int _score = 0;

        public Scrabble(string word)
        {


         

            _score = CalculateScore(word);

           
        }
        public int score() { return _score; }

        //TODO: score calculation code goes here
        public int CalculateScore(string word)
        {
            int score = 0;

            foreach (char letter in word.ToUpper())
                {

                    score += GetLetterValue(letter);
                }

                return score;

            }

  //TODO: do something with the word variable
            static int GetLetterValue(char letter) {
                switch (letter)
                {
                    case 'A': case 'E': case 'I': case 'O': case 'U': case 'L':
                    case 'N':
                    case 'R': case 'S': case 'T': return 1;

                    case 'D': case 'G': return 2;

                    case 'B': case 'C': case 'M': case 'P': return 3;

                    case 'F': case 'H': case 'V': case 'W': case 'Y': return 4;
                    case 'K': return 5;
                    case 'J': case 'X': return 8;
                    case 'Q': case 'Z': return 10;
                    default: return 0;

                }





              
            }

            

            }


        }
    

