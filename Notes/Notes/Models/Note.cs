﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Model
{
    public class Note
    {
        [PrimaryKey]
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }

        public Note()
        {
            NoteId = -1;

            Title = null;
            Text = null;
            CreationDate = DateTime.Now;
        }
        public Note(string title, string text, DateTime date)
        {
            NoteId = -1;

            Title = title;
            Text = text;
            CreationDate = date;
        }
        public override string ToString()
        {
            return $"{Title}; {Text}; {CreationDate}";
        }
    }
}