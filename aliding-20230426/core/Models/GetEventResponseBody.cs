// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetEventResponseBody : TeaModel {
        [NameInMap("attendees")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyAttendees> Attendees { get; set; }
        public class GetEventResponseBodyAttendees : TeaModel {
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

        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyCategories> Categories { get; set; }
        public class GetEventResponseBodyCategories : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public GetEventResponseBodyEnd End { get; set; }
        public class GetEventResponseBodyEnd : TeaModel {
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

        [NameInMap("extendedProperties")]
        [Validation(Required=false)]
        public GetEventResponseBodyExtendedProperties ExtendedProperties { get; set; }
        public class GetEventResponseBodyExtendedProperties : TeaModel {
            [NameInMap("SharedProperties")]
            [Validation(Required=false)]
            public GetEventResponseBodyExtendedPropertiesSharedProperties SharedProperties { get; set; }
            public class GetEventResponseBodyExtendedPropertiesSharedProperties : TeaModel {
                [NameInMap("BelongCorpId")]
                [Validation(Required=false)]
                public string BelongCorpId { get; set; }

                [NameInMap("SourceOpenCid")]
                [Validation(Required=false)]
                public string SourceOpenCid { get; set; }

            }

        }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("isAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public GetEventResponseBodyLocation Location { get; set; }
        public class GetEventResponseBodyLocation : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// --
            /// </summary>
            [NameInMap("MeetingRooms")]
            [Validation(Required=false)]
            public List<string> MeetingRooms { get; set; }

        }

        [NameInMap("meetingRooms")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyMeetingRooms> MeetingRooms { get; set; }
        public class GetEventResponseBodyMeetingRooms : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("ResponseStatus")]
            [Validation(Required=false)]
            public string ResponseStatus { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public GetEventResponseBodyOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class GetEventResponseBodyOnlineMeetingInfo : TeaModel {
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
        public GetEventResponseBodyOrganizer Organizer { get; set; }
        public class GetEventResponseBodyOrganizer : TeaModel {
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

        [NameInMap("originStart")]
        [Validation(Required=false)]
        public GetEventResponseBodyOriginStart OriginStart { get; set; }
        public class GetEventResponseBodyOriginStart : TeaModel {
            [NameInMap("DateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

        }

        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public GetEventResponseBodyRecurrence Recurrence { get; set; }
        public class GetEventResponseBodyRecurrence : TeaModel {
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public GetEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class GetEventResponseBodyRecurrencePattern : TeaModel {
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
            public GetEventResponseBodyRecurrenceRange Range { get; set; }
            public class GetEventResponseBodyRecurrenceRange : TeaModel {
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
        public List<GetEventResponseBodyReminders> Reminders { get; set; }
        public class GetEventResponseBodyReminders : TeaModel {
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

        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public GetEventResponseBodyStart Start { get; set; }
        public class GetEventResponseBodyStart : TeaModel {
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

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
