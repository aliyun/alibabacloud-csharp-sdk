// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class PatchEventResponseBody : TeaModel {
        [NameInMap("attendees")]
        [Validation(Required=false)]
        public List<PatchEventResponseBodyAttendees> Attendees { get; set; }
        public class PatchEventResponseBodyAttendees : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsOptional")]
            [Validation(Required=false)]
            public bool? IsOptional { get; set; }

            [NameInMap("ResponseStatus")]
            [Validation(Required=false)]
            public string ResponseStatus { get; set; }

            [NameInMap("Self")]
            [Validation(Required=false)]
            public bool? Self { get; set; }

        }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public PatchEventResponseBodyEnd End { get; set; }
        public class PatchEventResponseBodyEnd : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("DateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("isAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public PatchEventResponseBodyLocation Location { get; set; }
        public class PatchEventResponseBodyLocation : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MeetingRooms")]
            [Validation(Required=false)]
            public List<string> MeetingRooms { get; set; }

        }

        [NameInMap("organizer")]
        [Validation(Required=false)]
        public PatchEventResponseBodyOrganizer Organizer { get; set; }
        public class PatchEventResponseBodyOrganizer : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ResponseStatus")]
            [Validation(Required=false)]
            public string ResponseStatus { get; set; }

            [NameInMap("Self")]
            [Validation(Required=false)]
            public bool? Self { get; set; }

        }

        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public PatchEventResponseBodyRecurrence Recurrence { get; set; }
        public class PatchEventResponseBodyRecurrence : TeaModel {
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public PatchEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class PatchEventResponseBodyRecurrencePattern : TeaModel {
                [NameInMap("DayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("DaysOfWeek")]
                [Validation(Required=false)]
                public string DaysOfWeek { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Range")]
            [Validation(Required=false)]
            public PatchEventResponseBodyRecurrenceRange Range { get; set; }
            public class PatchEventResponseBodyRecurrenceRange : TeaModel {
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("NumberOfOccurrences")]
                [Validation(Required=false)]
                public int? NumberOfOccurrences { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("reminders")]
        [Validation(Required=false)]
        public List<PatchEventResponseBodyReminders> Reminders { get; set; }
        public class PatchEventResponseBodyReminders : TeaModel {
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("Minutes")]
            [Validation(Required=false)]
            public string Minutes { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public PatchEventResponseBodyStart Start { get; set; }
        public class PatchEventResponseBodyStart : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("DateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
