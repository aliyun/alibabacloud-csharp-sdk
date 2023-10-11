// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListEventsViewResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsViewResponseBodyEvents> Events { get; set; }
        public class ListEventsViewResponseBodyEvents : TeaModel {
            [NameInMap("Attendees")]
            [Validation(Required=false)]
            public List<ListEventsViewResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsViewResponseBodyEventsAttendees : TeaModel {
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

            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<ListEventsViewResponseBodyEventsCategories> Categories { get; set; }
            public class ListEventsViewResponseBodyEventsCategories : TeaModel {
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
            public ListEventsViewResponseBodyEventsEnd End { get; set; }
            public class ListEventsViewResponseBodyEventsEnd : TeaModel {
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
            public ListEventsViewResponseBodyEventsExtendedProperties ExtendedProperties { get; set; }
            public class ListEventsViewResponseBodyEventsExtendedProperties : TeaModel {
                [NameInMap("SharedProperties")]
                [Validation(Required=false)]
                public ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties SharedProperties { get; set; }
                public class ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties : TeaModel {
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
            public ListEventsViewResponseBodyEventsLocation Location { get; set; }
            public class ListEventsViewResponseBodyEventsLocation : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("MeetingRooms")]
                [Validation(Required=false)]
                public List<string> MeetingRooms { get; set; }

            }

            [NameInMap("MeetingRooms")]
            [Validation(Required=false)]
            public List<ListEventsViewResponseBodyEventsMeetingRooms> MeetingRooms { get; set; }
            public class ListEventsViewResponseBodyEventsMeetingRooms : TeaModel {
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
            public ListEventsViewResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsViewResponseBodyEventsOnlineMeetingInfo : TeaModel {
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
            public ListEventsViewResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsViewResponseBodyEventsOrganizer : TeaModel {
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

            [NameInMap("OriginStart")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOriginStart OriginStart { get; set; }
            public class ListEventsViewResponseBodyEventsOriginStart : TeaModel {
                [NameInMap("DateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            [NameInMap("Recurrence")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsViewResponseBodyEventsRecurrence : TeaModel {
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public ListEventsViewResponseBodyEventsRecurrencePattern Pattern { get; set; }
                public class ListEventsViewResponseBodyEventsRecurrencePattern : TeaModel {
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
                public ListEventsViewResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsViewResponseBodyEventsRecurrenceRange : TeaModel {
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

            [NameInMap("RichTextDescription")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsRichTextDescription RichTextDescription { get; set; }
            public class ListEventsViewResponseBodyEventsRichTextDescription : TeaModel {
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("SeriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsStart Start { get; set; }
            public class ListEventsViewResponseBodyEventsStart : TeaModel {
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

    }

}
