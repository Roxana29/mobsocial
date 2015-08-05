﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Plugin.Widgets.MobSocial.Enums;

namespace Nop.Plugin.Widgets.MobSocial.Domain
{
    public class VideoBattleVideo : BaseEntity
    {
        public string VideoPath { get; set; }

        public string MimeType { get; set; }

        public int ParticipantId { get; set; }

        public int VideoBattleId { get; set; }

        public VideoStatus VideoStatus { get; set; }

        public DateTime DateUploaded { get; set; }

        public virtual VideoBattle VideoBattle { get; set; }
    }
}
