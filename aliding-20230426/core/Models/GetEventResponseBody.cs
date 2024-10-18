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
            /// <summary>
            /// <b>Example:</b>
            /// <para>jack</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

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

        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyCategories> Categories { get; set; }
        public class GetEventResponseBodyCategories : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-01-01T10:15:30+08:00</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-01-01T10:15:30+08:00</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public GetEventResponseBodyEnd End { get; set; }
        public class GetEventResponseBodyEnd : TeaModel {
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

        [NameInMap("extendedProperties")]
        [Validation(Required=false)]
        public GetEventResponseBodyExtendedProperties ExtendedProperties { get; set; }
        public class GetEventResponseBodyExtendedProperties : TeaModel {
            [NameInMap("SharedProperties")]
            [Validation(Required=false)]
            public GetEventResponseBodyExtendedPropertiesSharedProperties SharedProperties { get; set; }
            public class GetEventResponseBodyExtendedPropertiesSharedProperties : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dingd*****1231231</para>
                /// </summary>
                [NameInMap("BelongCorpId")]
                [Validation(Required=false)]
                public string BelongCorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zxcvasdfvb123====</para>
                /// </summary>
                [NameInMap("SourceOpenCid")]
                [Validation(Required=false)]
                public string SourceOpenCid { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>iiiP35sJxxxxPRKgiEiF</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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
            /// <para>--</para>
            /// </summary>
            [NameInMap("MeetingRooms")]
            [Validation(Required=false)]
            public List<string> MeetingRooms { get; set; }

        }

        [NameInMap("meetingRooms")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyMeetingRooms> MeetingRooms { get; set; }
        public class GetEventResponseBodyMeetingRooms : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>room 1-2-3</para>
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

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public GetEventResponseBodyOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class GetEventResponseBodyOnlineMeetingInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5c4df21d-xxxx-a6db402b9f3a</para>
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
            /// <para>dingtalk://dingtalkclient/page/videoxxxxalendar?confId=5c4df21d-xxxx9f3f&amp;calendarId=127xxxx124</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("organizer")]
        [Validation(Required=false)]
        public GetEventResponseBodyOrganizer Organizer { get; set; }
        public class GetEventResponseBodyOrganizer : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>tony</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
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
            /// <para>true</para>
            /// </summary>
            [NameInMap("Self")]
            [Validation(Required=false)]
            public bool? Self { get; set; }

        }

        [NameInMap("originStart")]
        [Validation(Required=false)]
        public GetEventResponseBodyOriginStart OriginStart { get; set; }
        public class GetEventResponseBodyOriginStart : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-01T00:00:00Z</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("DayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>monday</para>
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
            public GetEventResponseBodyRecurrenceRange Range { get; set; }
            public class GetEventResponseBodyRecurrenceRange : TeaModel {
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

        [NameInMap("reminders")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyReminders> Reminders { get; set; }
        public class GetEventResponseBodyReminders : TeaModel {
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

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>requestId</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("richTextDescription")]
        [Validation(Required=false)]
        public GetEventResponseBodyRichTextDescription RichTextDescription { get; set; }
        public class GetEventResponseBodyRichTextDescription : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cnNTbW1YbxxxxvdlQrQT09</para>
        /// </summary>
        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public GetEventResponseBodyStart Start { get; set; }
        public class GetEventResponseBodyStart : TeaModel {
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
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test event</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-01-01T10:15:30+08:00</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
