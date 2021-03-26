using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageCrypter
{
    public class Cryptage
    {   

        private int[] GetTailleColonneCle(string cle)
        {
            // Tout mettre en capital pour éviter les erreurs
            char[] lettre = cle.ToUpper().ToCharArray();

            //Tri des lettres dans l'ordre alphabétique
            Array.Sort(lettre);

            int[] numbers = new int[cle.Length];
            for (int i = 0; i < lettre.Length; i++)
            {
                char c = cle.ToUpper()[i];
                int pos = Array.IndexOf(lettre, c);
                numbers[i] = pos;
                lettre[pos] = ' ';
            }

            return numbers;
        }

        public string Crypter(string t, string cle)
        {
            int[] tailleColonne = GetTailleColonneCle(cle);
            char[,] transpositionMatrice = InitialisationMatrice(t, cle);

            return CryptMatrice(tailleColonne, transpositionMatrice, t.Length);
        }

        private char[,] InitialisationMatrice(string text, string key)
        {
            int nb_colonne = key.Length;
            int nombreDeLignes = Convert.ToInt32(Math.Ceiling((double)text.Length / nb_colonne));

            int index = 0;
            char[,] grid = new char[nombreDeLignes, nb_colonne];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = index < text.Length ? text[index] : '@';
                    index++;
                }
            }

            return grid;
        }

        private char[,] InitialisationMatriceDecrypte(string text, int[] tailleColonne)
        {
            int nb_colonnes = tailleColonne.Length;
            int nb_ligne = Convert.ToInt32(Math.Ceiling((double)text.Length / nb_colonnes));

            List<int> listeIndex = new List<int>();
            for (int i = nb_colonnes - (nb_colonnes * nb_ligne - text.Length); i < nb_colonnes; i++)
            {
                listeIndex.Add(tailleColonne[i] * nb_ligne + nb_ligne - 1);
            }

            listeIndex.Sort();
            listeIndex.ForEach(ind => text = text.Insert(ind, "@"));

            int cpt = 0;
            char[,] grille = new char[nb_ligne, Convert.ToInt32(nb_colonnes)];
            for (int i = 0; i < tailleColonne.Length; i++)
            {
                int pos = Array.IndexOf(tailleColonne, i);
                for (int j = 0; j < grille.GetLength(0); j++)
                {
                    if (text[cpt] != '@')
                    {
                        grille[j, pos] = text[cpt];
                    }
                    cpt++;
                }
            }

            return grille;
        }

        private string CryptMatrice(int[] tailleColonne, char[,] matrice, int tailletexte)
        {
            string t = "";

            for (int i = 0; i < tailleColonne.Length; i++)
            {
                int pos = Array.IndexOf(tailleColonne, i);
                for (int j = 0; j < matrice.GetLength(0); j++)
                {
                    if (matrice[j, pos] != '@')
                    {
                        t += matrice[j, pos];
                    }
                }
            }

            return t;
        }

        public string Decrypter(string text, string key)
        {
            int[] nb_char = GetTailleColonneCle(key);
            char[,] tg = InitialisationMatriceDecrypte(text, nb_char);

            return DecrypteDMatrice(tg);
        }

        private string DecrypteDMatrice(char[,] grille)
        {
            string t = "";

            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    t += grille[i, j];
                }
            }

            return t;
        }
    }
}
