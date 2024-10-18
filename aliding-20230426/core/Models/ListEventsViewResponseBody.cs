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
                /// <summary>
                /// <b>Example:</b>
                /// <para>tony</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptional")]
                [Validation(Required=false)]
                public bool? IsOptional { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>accepted</para>
                /// </summary>
                [NameInMap("ResponseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Self")]
                [Validation(Required=false)]
                public bool? Self { get; set; }

            }

            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<ListEventsViewResponseBodyEventsCategories> Categories { get; set; }
            public class ListEventsViewResponseBodyEventsCategories : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tony</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01T10:15:30+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>something about this event</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsEnd End { get; set; }
            public class ListEventsViewResponseBodyEventsEnd : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01T10:15:30+08:00</para>
                /// </summary>
                [NameInMap("DateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dingd8*****1231</para>
                    /// </summary>
                    [NameInMap("BelongCorpId")]
                    [Validation(Required=false)]
                    public string BelongCorpId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zxcvasdfa123===</para>
                    /// </summary>
                    [NameInMap("SourceOpenCid")]
                    [Validation(Required=false)]
                    public string SourceOpenCid { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iiiP35xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAllDay")]
            [Validation(Required=false)]
            public bool? IsAllDay { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsLocation Location { get; set; }
            public class ListEventsViewResponseBodyEventsLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tony</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>tony</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>accepted</para>
                /// </summary>
                [NameInMap("ResponseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c10315a8b4e740a317813ab6fxxxxxx</para>
                /// </summary>
                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

            }

            [NameInMap("OnlineMeetingInfo")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsViewResponseBodyEventsOnlineMeetingInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5c4df2xxx</para>
                /// </summary>
                [NameInMap("ConferenceId")]
                [Validation(Required=false)]
                public string ConferenceId { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtraInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalk</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalk://dingtalkclient/page/xxx?confId=xxx&amp;calendarId=xxx</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Organizer")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsViewResponseBodyEventsOrganizer : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tony</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>accepted</para>
                /// </summary>
                [NameInMap("ResponseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Self")]
                [Validation(Required=false)]
                public bool? Self { get; set; }

            }

            [NameInMap("OriginStart")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOriginStart OriginStart { get; set; }
            public class ListEventsViewResponseBodyEventsOriginStart : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01T10:15:30+08:00</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("DayOfMonth")]
                    [Validation(Required=false)]
                    public int? DayOfMonth { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sunday</para>
                    /// </summary>
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public string DaysOfWeek { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>first</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dingtalk</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Range")]
                [Validation(Required=false)]
                public ListEventsViewResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsViewResponseBodyEventsRecurrenceRange : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-01-01T10:15:30+08:00</para>
                    /// </summary>
                    [NameInMap("EndDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("NumberOfOccurrences")]
                    [Validation(Required=false)]
                    public int? NumberOfOccurrences { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dingtalk</para>
                    /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>cnNTbxxx</para>
            /// </summary>
            [NameInMap("SeriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsStart Start { get; set; }
            public class ListEventsViewResponseBodyEventsStart : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01T10:15:30+08:00</para>
                /// </summary>
                [NameInMap("DateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>confirmed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test event</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01T10:15:30+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cnNTbWxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
