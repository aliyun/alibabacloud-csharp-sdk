// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListEventsResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsResponseBodyEvents> Events { get; set; }
        public class ListEventsResponseBodyEvents : TeaModel {
            [NameInMap("Attendees")]
            [Validation(Required=false)]
            public List<ListEventsResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsResponseBodyEventsAttendees : TeaModel {
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

            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<ListEventsResponseBodyEventsCategories> Categories { get; set; }
            public class ListEventsResponseBodyEventsCategories : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsEnd End { get; set; }
            public class ListEventsResponseBodyEventsEnd : TeaModel {
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

            [NameInMap("ExtendedProperties")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsExtendedProperties ExtendedProperties { get; set; }
            public class ListEventsResponseBodyEventsExtendedProperties : TeaModel {
                [NameInMap("SharedProperties")]
                [Validation(Required=false)]
                public ListEventsResponseBodyEventsExtendedPropertiesSharedProperties SharedProperties { get; set; }
                public class ListEventsResponseBodyEventsExtendedPropertiesSharedProperties : TeaModel {
                    [NameInMap("BelongCorpId")]
                    [Validation(Required=false)]
                    public string BelongCorpId { get; set; }

                    [NameInMap("SourceOpenCid")]
                    [Validation(Required=false)]
                    public string SourceOpenCid { get; set; }

                }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsAllDay")]
            [Validation(Required=false)]
            public bool? IsAllDay { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsLocation Location { get; set; }
            public class ListEventsResponseBodyEventsLocation : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("MeetingRooms")]
                [Validation(Required=false)]
                public List<string> MeetingRooms { get; set; }

            }

            [NameInMap("MeetingRooms")]
            [Validation(Required=false)]
            public List<ListEventsResponseBodyEventsMeetingRooms> MeetingRooms { get; set; }
            public class ListEventsResponseBodyEventsMeetingRooms : TeaModel {
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

            [NameInMap("OnlineMeetingInfo")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsResponseBodyEventsOnlineMeetingInfo : TeaModel {
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

            [NameInMap("Organizer")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsResponseBodyEventsOrganizer : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("ResponseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                [NameInMap("Self")]
                [Validation(Required=false)]
                public bool? Self { get; set; }

            }

            [NameInMap("OriginStart")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsOriginStart OriginStart { get; set; }
            public class ListEventsResponseBodyEventsOriginStart : TeaModel {
                [NameInMap("DateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            [NameInMap("Recurrence")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsResponseBodyEventsRecurrence : TeaModel {
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public ListEventsResponseBodyEventsRecurrencePattern Pattern { get; set; }
                public class ListEventsResponseBodyEventsRecurrencePattern : TeaModel {
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
                public ListEventsResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsResponseBodyEventsRecurrenceRange : TeaModel {
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

            [NameInMap("Reminders")]
            [Validation(Required=false)]
            public List<ListEventsResponseBodyEventsReminders> Reminders { get; set; }
            public class ListEventsResponseBodyEventsReminders : TeaModel {
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Minutes")]
                [Validation(Required=false)]
                public string Minutes { get; set; }

            }

            [NameInMap("RichTextDescription")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsRichTextDescription RichTextDescription { get; set; }
            public class ListEventsResponseBodyEventsRichTextDescription : TeaModel {
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("SeriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsStart Start { get; set; }
            public class ListEventsResponseBodyEventsStart : TeaModel {
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

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("syncToken")]
        [Validation(Required=false)]
        public string SyncToken { get; set; }

    }

}
