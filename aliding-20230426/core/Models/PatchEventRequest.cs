// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class PatchEventRequest : TeaModel {
        [NameInMap("Attendees")]
        [Validation(Required=false)]
        public List<PatchEventRequestAttendees> Attendees { get; set; }
        public class PatchEventRequestAttendees : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isOptional")]
            [Validation(Required=false)]
            public bool? IsOptional { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("CardInstances")]
        [Validation(Required=false)]
        public List<PatchEventRequestCardInstances> CardInstances { get; set; }
        public class PatchEventRequestCardInstances : TeaModel {
            [NameInMap("OutTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public PatchEventRequestEnd End { get; set; }
        public class PatchEventRequestEnd : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        [NameInMap("IsAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public PatchEventRequestLocation Location { get; set; }
        public class PatchEventRequestLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("Recurrence")]
        [Validation(Required=false)]
        public PatchEventRequestRecurrence Recurrence { get; set; }
        public class PatchEventRequestRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public PatchEventRequestRecurrencePattern Pattern { get; set; }
            public class PatchEventRequestRecurrencePattern : TeaModel {
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("daysOfWeek")]
                [Validation(Required=false)]
                public string DaysOfWeek { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("range")]
            [Validation(Required=false)]
            public PatchEventRequestRecurrenceRange Range { get; set; }
            public class PatchEventRequestRecurrenceRange : TeaModel {
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("numberOfOccurrences")]
                [Validation(Required=false)]
                public int? NumberOfOccurrences { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Reminders")]
        [Validation(Required=false)]
        public List<PatchEventRequestReminders> Reminders { get; set; }
        public class PatchEventRequestReminders : TeaModel {
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("minutes")]
            [Validation(Required=false)]
            public int? Minutes { get; set; }

        }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public PatchEventRequestStart Start { get; set; }
        public class PatchEventRequestStart : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<PatchEventRequestCategories> Categories { get; set; }
        public class PatchEventRequestCategories : TeaModel {
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("freeBusyStatus")]
        [Validation(Required=false)]
        public string FreeBusyStatus { get; set; }

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public PatchEventRequestOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class PatchEventRequestOnlineMeetingInfo : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("richTextDescription")]
        [Validation(Required=false)]
        public PatchEventRequestRichTextDescription RichTextDescription { get; set; }
        public class PatchEventRequestRichTextDescription : TeaModel {
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("uiConfigs")]
        [Validation(Required=false)]
        public List<PatchEventRequestUiConfigs> UiConfigs { get; set; }
        public class PatchEventRequestUiConfigs : TeaModel {
            [NameInMap("uiName")]
            [Validation(Required=false)]
            public string UiName { get; set; }

            [NameInMap("uiStatus")]
            [Validation(Required=false)]
            public string UiStatus { get; set; }

        }

    }

}
