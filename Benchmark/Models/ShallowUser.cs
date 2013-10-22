﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.Models
{
    enum UserType : byte
    {
        unregistered = 2,
        registered = 3,
        moderator = 4,
        does_not_exist = 255
    }
    
    [ProtoContract]
    class ShallowUser
    {
        [ProtoMember(1)]
        public int? user_id { get; set; }
        [ProtoMember(2)]
        public string display_name { get; set; }
        [ProtoMember(3)]
        public int? reputation { get; set; }
        [ProtoMember(4)]
        public UserType? user_type { get; set; }
        [ProtoMember(5)]
        public string profile_image { get; set; }
        [ProtoMember(6)]
        public string link { get; set; }
        [ProtoMember(7)]
        public int? accept_rate { get; set; }
        [ProtoMember(8)]
        public User.BadgeCount badge_counts { get; set; }
    }
}
