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

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsOptional")]
            [Validation(Required=false)]
            public bool? IsOptional { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>needsAction</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-01-01T10:15:30+08:00</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("encryptedId")]
        [Validation(Required=false)]
        public string EncryptedId { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public CreateEventResponseBodyEnd End { get; set; }
        public class CreateEventResponseBodyEnd : TeaModel {
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
        /// <para>iiiP35sJadba8aBSgjrwPRKgiEiF</para>
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
        public CreateEventResponseBodyLocation Location { get; set; }
        public class CreateEventResponseBodyLocation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>room 1-2-3</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public CreateEventResponseBodyOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class CreateEventResponseBodyOnlineMeetingInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
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
            /// <para><a href="http://meeting">http://meeting</a></para>
            /// </summary>
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
        public CreateEventResponseBodyRecurrence Recurrence { get; set; }
        public class CreateEventResponseBodyRecurrence : TeaModel {
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public CreateEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class CreateEventResponseBodyRecurrencePattern : TeaModel {
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
            public CreateEventResponseBodyRecurrenceRange Range { get; set; }
            public class CreateEventResponseBodyRecurrenceRange : TeaModel {
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
        public List<CreateEventResponseBodyReminders> Reminders { get; set; }
        public class CreateEventResponseBodyReminders : TeaModel {
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
        public CreateEventResponseBodyRichTextDescription RichTextDescription { get; set; }
        public class CreateEventResponseBodyRichTextDescription : TeaModel {
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("start")]
        [Validation(Required=false)]
        public CreateEventResponseBodyStart Start { get; set; }
        public class CreateEventResponseBodyStart : TeaModel {
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
        public List<CreateEventResponseBodyUiConfigs> UiConfigs { get; set; }
        public class CreateEventResponseBodyUiConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>updateEventButton</para>
            /// </summary>
            [NameInMap("UiName")]
            [Validation(Required=false)]
            public string UiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("UiStatus")]
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
