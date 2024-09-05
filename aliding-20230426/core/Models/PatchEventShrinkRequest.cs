// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class PatchEventShrinkRequest : TeaModel {
        [NameInMap("Attendees")]
        [Validation(Required=false)]
        public string AttendeesShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("CardInstances")]
        [Validation(Required=false)]
        public string CardInstancesShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public string EndShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        [NameInMap("IsAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string LocationShrink { get; set; }

        [NameInMap("Recurrence")]
        [Validation(Required=false)]
        public string RecurrenceShrink { get; set; }

        [NameInMap("Reminders")]
        [Validation(Required=false)]
        public string RemindersShrink { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public string StartShrink { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
