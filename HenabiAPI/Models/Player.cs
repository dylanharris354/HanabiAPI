﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HenabiAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public List<GameCard> CurrentHand { get; set; }
    }
}
