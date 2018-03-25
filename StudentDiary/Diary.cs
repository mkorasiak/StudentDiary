using System;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// Klasa opisująca dzienniczek studenta z danymi i statystykami
/// </summary>
namespace StudentDiary
{
    class Diary
    {
        //stan - zmienne i pola
        List<float> ratings;

        //zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        public float CalculateAvarage()
        {
            float Sum=0, Avg=0;
            foreach (var rating in ratings)
            {
                Sum += rating;
            }
            return Avg = Sum / ratings.Count;

        }
    }
}
