// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateEventRequest : TeaModel {
        [NameInMap("Attendees")]
        [Validation(Required=false)]
        public List<CreateEventRequestAttendees> Attendees { get; set; }
        public class CreateEventRequestAttendees : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7845</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOptional")]
            [Validation(Required=false)]
            public bool? IsOptional { get; set; }

        }

        [NameInMap("CardInstances")]
        [Validation(Required=false)]
        public List<CreateEventRequestCardInstances> CardInstances { get; set; }
        public class CreateEventRequestCardInstances : TeaModel {
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
        public CreateEventRequestEnd End { get; set; }
        public class CreateEventRequestEnd : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;2020-09-21&quot;</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;2021-09-20T10:15:30+08:00&quot;</para>
            /// </summary>
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;Asia/Shanghai&quot;</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public CreateEventRequestLocation Location { get; set; }
        public class CreateEventRequestLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("OnlineMeetingInfo")]
        [Validation(Required=false)]
        public CreateEventRequestOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class CreateEventRequestOnlineMeetingInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Recurrence")]
        [Validation(Required=false)]
        public CreateEventRequestRecurrence Recurrence { get; set; }
        public class CreateEventRequestRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public CreateEventRequestRecurrencePattern Pattern { get; set; }
            public class CreateEventRequestRecurrencePattern : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;monday&quot;</para>
                /// </summary>
                [NameInMap("daysOfWeek")]
                [Validation(Required=false)]
                public string DaysOfWeek { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;last&quot;</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;daily&quot;</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("range")]
            [Validation(Required=false)]
            public CreateEventRequestRecurrenceRange Range { get; set; }
            public class CreateEventRequestRecurrenceRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;2021-12-31T10:15:30+08:00&quot;</para>
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("numberOfOccurrences")]
                [Validation(Required=false)]
                public int? NumberOfOccurrences { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;endDate&quot;</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Reminders")]
        [Validation(Required=false)]
        public List<CreateEventRequestReminders> Reminders { get; set; }
        public class CreateEventRequestReminders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("minutes")]
            [Validation(Required=false)]
            public int? Minutes { get; set; }

        }

        [NameInMap("RichTextDescription")]
        [Validation(Required=false)]
        public CreateEventRequestRichTextDescription RichTextDescription { get; set; }
        public class CreateEventRequestRichTextDescription : TeaModel {
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("UiConfigs")]
        [Validation(Required=false)]
        public List<CreateEventRequestUiConfigs> UiConfigs { get; set; }
        public class CreateEventRequestUiConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;updateEventButton&quot;</para>
            /// </summary>
            [NameInMap("uiName")]
            [Validation(Required=false)]
            public string UiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;hide&quot;</para>
            /// </summary>
            [NameInMap("uiStatus")]
            [Validation(Required=false)]
            public string UiStatus { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("calendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public CreateEventRequestStart Start { get; set; }
        public class CreateEventRequestStart : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;2021-09-20&quot;</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;2021-09-20T10:15:30+08:00&quot;</para>
            /// </summary>
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;Asia/Shanghai&quot;</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

    }

}
