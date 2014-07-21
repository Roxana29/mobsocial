﻿using Nop.Core;
using Nop.Core.Domain.Seo;
using System;
using System.Collections.Generic;

namespace Nop.Plugin.Widgets.MobSocial.Domain
{
    public class EventPage : BaseEntity, ISlugSupported
    {

        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipPostalCode { get; set; }
        public string Country { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public virtual List<EventPageHotel> Hotels { get; set; }
        public virtual List<EventPagePicture> Pictures { get; set; }



    }
}