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
                /// <summary>
                /// <b>Example:</b>
                /// <para>tony</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <para>true</para>
                /// </summary>
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
            public ListEventsResponseBodyEventsEnd End { get; set; }
            public class ListEventsResponseBodyEventsEnd : TeaModel {
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
            public ListEventsResponseBodyEventsExtendedProperties ExtendedProperties { get; set; }
            public class ListEventsResponseBodyEventsExtendedProperties : TeaModel {
                [NameInMap("SharedProperties")]
                [Validation(Required=false)]
                public ListEventsResponseBodyEventsExtendedPropertiesSharedProperties SharedProperties { get; set; }
                public class ListEventsResponseBodyEventsExtendedPropertiesSharedProperties : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ding*********31</para>
                    /// </summary>
                    [NameInMap("BelongCorpId")]
                    [Validation(Required=false)]
                    public string BelongCorpId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zxcv90asdf123===</para>
                    /// </summary>
                    [NameInMap("SourceOpenCid")]
                    [Validation(Required=false)]
                    public string SourceOpenCid { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cnNTbW1YbxxxxdEgvdlQrQT09</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAllDay")]
            [Validation(Required=false)]
            public bool? IsAllDay { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsLocation Location { get; set; }
            public class ListEventsResponseBodyEventsLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>room 1-2-3</para>
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
            public List<ListEventsResponseBodyEventsMeetingRooms> MeetingRooms { get; set; }
            public class ListEventsResponseBodyEventsMeetingRooms : TeaModel {
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
            public ListEventsResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsResponseBodyEventsOnlineMeetingInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5c4df21dxxxx-a6db402b9f3a</para>
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
                /// <para>dingtalk://dingtalkclient/page/videoCoxxxxndar?confId=5c4df21dxxxx2b9f3a&amp;calendarId=92xxxx36</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Organizer")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsResponseBodyEventsOrganizer : TeaModel {
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
                /// <para>true</para>
                /// </summary>
                [NameInMap("Self")]
                [Validation(Required=false)]
                public bool? Self { get; set; }

            }

            [NameInMap("OriginStart")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsOriginStart OriginStart { get; set; }
            public class ListEventsResponseBodyEventsOriginStart : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01T00:00:00Z</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
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
                    /// <para>daily</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Range")]
                [Validation(Required=false)]
                public ListEventsResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsResponseBodyEventsRecurrenceRange : TeaModel {
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
                    /// <para>noEnd</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("Reminders")]
            [Validation(Required=false)]
            public List<ListEventsResponseBodyEventsReminders> Reminders { get; set; }
            public class ListEventsResponseBodyEventsReminders : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalk</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>cnNTbWxxxxaFJZdEgvdlQrQT09</para>
            /// </summary>
            [NameInMap("SeriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsStart Start { get; set; }
            public class ListEventsResponseBodyEventsStart : TeaModel {
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
        /// <para>cnNTbW1YbxxxxdlQrQT09</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>4248DCC9-785F-5A14-8BE0-830FD52E1261</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zxcasdfvc000009</para>
        /// </summary>
        [NameInMap("syncToken")]
        [Validation(Required=false)]
        public string SyncToken { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
