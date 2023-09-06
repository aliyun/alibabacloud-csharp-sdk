// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateEventResponseBody : TeaModel {
        [NameInMap("attendees")]
        [Validation(Required=false)]
        public List<CreateEventResponseBodyAttendees> Attendees { get; set; }
        public class CreateEventResponseBodyAttendees : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

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
        public CreateEventResponseBodyEnd End { get; set; }
        public class CreateEventResponseBodyEnd : TeaModel {
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
        public CreateEventResponseBodyLocation Location { get; set; }
        public class CreateEventResponseBodyLocation : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public CreateEventResponseBodyOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class CreateEventResponseBodyOnlineMeetingInfo : TeaModel {
            [NameInMap("ConferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfo { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("organizer")]
        [Validation(Required=false)]
        public CreateEventResponseBodyOrganizer Organizer { get; set; }
        public class CreateEventResponseBodyOrganizer : TeaModel {
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
        public CreateEventResponseBodyRecurrence Recurrence { get; set; }
        public class CreateEventResponseBodyRecurrence : TeaModel {
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public CreateEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class CreateEventResponseBodyRecurrencePattern : TeaModel {
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
            public CreateEventResponseBodyRecurrenceRange Range { get; set; }
            public class CreateEventResponseBodyRecurrenceRange : TeaModel {
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
        public List<CreateEventResponseBodyReminders> Reminders { get; set; }
        public class CreateEventResponseBodyReminders : TeaModel {
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
        public CreateEventResponseBodyStart Start { get; set; }
        public class CreateEventResponseBodyStart : TeaModel {
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

        [NameInMap("uiConfigs")]
        [Validation(Required=false)]
        public List<CreateEventResponseBodyUiConfigs> UiConfigs { get; set; }
        public class CreateEventResponseBodyUiConfigs : TeaModel {
            [NameInMap("UiName")]
            [Validation(Required=false)]
            public string UiName { get; set; }

            [NameInMap("UiStatus")]
            [Validation(Required=false)]
            public string UiStatus { get; set; }

        }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
