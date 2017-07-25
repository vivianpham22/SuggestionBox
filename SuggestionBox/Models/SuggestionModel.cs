﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SuggestionBox.Models
{
    public class SuggestionModel
    {
        private string topic;
        private string suggestion;

        [Key]
        public int RecordNum { get; set; }

        public string Topic
        {
            get { return this.topic; }
            set { this.topic = value; }
        }
        public string Suggestion
        {
            get { return this.suggestion; }
            set { this.suggestion = value; }
        }



    }
}