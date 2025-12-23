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

        [NameInMap("cardInstances")]
        [Validation(Required=false)]
        public List<PatchEventResponseBodyCardInstances> CardInstances { get; set; }
        public class PatchEventResponseBodyCardInstances : TeaModel {
            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

            [NameInMap("scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

        }

        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<PatchEventResponseBodyCategories> Categories { get; set; }
        public class PatchEventResponseBodyCategories : TeaModel {
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-10-25T02:26:14Z</para>
        /// </summary>
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

        [NameInMap("freeBusyStatus")]
        [Validation(Required=false)]
        public string FreeBusyStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
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
        public PatchEventResponseBodyLocation Location { get; set; }
        public class PatchEventResponseBodyLocation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MeetingRooms")]
            [Validation(Required=false)]
            public List<string> MeetingRooms { get; set; }

        }

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public PatchEventResponseBodyOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class PatchEventResponseBodyOnlineMeetingInfo : TeaModel {
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("organizer")]
        [Validation(Required=false)]
        public PatchEventResponseBodyOrganizer Organizer { get; set; }
        public class PatchEventResponseBodyOrganizer : TeaModel {
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

        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public PatchEventResponseBodyRecurrence Recurrence { get; set; }
        public class PatchEventResponseBodyRecurrence : TeaModel {
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public PatchEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class PatchEventResponseBodyRecurrencePattern : TeaModel {
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
                /// <para>daily</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Range")]
            [Validation(Required=false)]
            public PatchEventResponseBodyRecurrenceRange Range { get; set; }
            public class PatchEventResponseBodyRecurrenceRange : TeaModel {
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
        public List<PatchEventResponseBodyReminders> Reminders { get; set; }
        public class PatchEventResponseBodyReminders : TeaModel {
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
        /// <para>4248DCC9-785F-5A14-8BE0-830FD52E1261</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("richTextDescription")]
        [Validation(Required=false)]
        public PatchEventResponseBodyRichTextDescription RichTextDescription { get; set; }
        public class PatchEventResponseBodyRichTextDescription : TeaModel {
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("start")]
        [Validation(Required=false)]
        public PatchEventResponseBodyStart Start { get; set; }
        public class PatchEventResponseBodyStart : TeaModel {
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

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("uiConfigs")]
        [Validation(Required=false)]
        public List<PatchEventResponseBodyUiConfigs> UiConfigs { get; set; }
        public class PatchEventResponseBodyUiConfigs : TeaModel {
            [NameInMap("uiName")]
            [Validation(Required=false)]
            public string UiName { get; set; }

            [NameInMap("uiStatus")]
            [Validation(Required=false)]
            public string UiStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-01-01T10:15:30+08:00</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
