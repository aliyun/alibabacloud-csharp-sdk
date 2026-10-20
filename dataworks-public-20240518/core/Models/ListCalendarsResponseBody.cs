// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCalendarsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListCalendarsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListCalendarsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of scheduling calendars.</para>
            /// </summary>
            [NameInMap("Calendars")]
            [Validation(Required=false)]
            public List<ListCalendarsResponseBodyPagingInfoCalendars> Calendars { get; set; }
            public class ListCalendarsResponseBodyPagingInfoCalendars : TeaModel {
                /// <summary>
                /// <para>Indicates whether the calendar is applicable to all workspaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllProjects")]
                [Validation(Required=false)]
                public bool? AllProjects { get; set; }

                /// <summary>
                /// <para>The description of the scheduling calendar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Weekday scheduling calendar</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The end date of the calendar validity period. Format: <c>yyyy-mm-dd</c>. This parameter is returned only for strongly constrained calendars.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-09</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>The expiration reminder. This parameter is returned only for strongly constrained calendars. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OneMonthBefore: One month in advance.</description></item>
                /// <item><description>OneWeekBefore: One week in advance.</description></item>
                /// <item><description>ThreeDaysBefore: Three days in advance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OneMonthBefore</para>
                /// </summary>
                [NameInMap("ExpirationReminder")]
                [Validation(Required=false)]
                public string ExpirationReminder { get; set; }

                /// <summary>
                /// <para>The default scheduling policy for dates that are not configured. This parameter is returned only for weakly constrained calendars. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: Normal scheduling.</description></item>
                /// <item><description>Pause: Pause scheduling.</description></item>
                /// <item><description>Skip: Dry run.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("FallbackPolicy")]
                [Validation(Required=false)]
                public string FallbackPolicy { get; set; }

                /// <summary>
                /// <para>The ID of the scheduling calendar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The time when the calendar was modified. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640000000000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the scheduling calendar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>work_calendar</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The scheduling policy after the calendar expires. This parameter is returned only for strongly constrained calendars. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: Normal scheduling.</description></item>
                /// <item><description>Pause: Pause scheduling.</description></item>
                /// <item><description>Skip: Dry run.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Skip</para>
                /// </summary>
                [NameInMap("OverduePolicy")]
                [Validation(Required=false)]
                public string OverduePolicy { get; set; }

                /// <summary>
                /// <para>The account ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The list of applicable workspace IDs. An empty array is returned if AllProjects is set to true.</para>
                /// </summary>
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<long?> ProjectIds { get; set; }

                /// <summary>
                /// <para>The date scheduling policy.</para>
                /// </summary>
                [NameInMap("SchedulePolicy")]
                [Validation(Required=false)]
                public ListCalendarsResponseBodyPagingInfoCalendarsSchedulePolicy SchedulePolicy { get; set; }
                public class ListCalendarsResponseBodyPagingInfoCalendarsSchedulePolicy : TeaModel {
                    /// <summary>
                    /// <para>The list of normal scheduling dates.</para>
                    /// </summary>
                    [NameInMap("NormalDates")]
                    [Validation(Required=false)]
                    public List<string> NormalDates { get; set; }

                    /// <summary>
                    /// <para>The list of non-scheduling dates. Tasks perform dry runs on these dates.</para>
                    /// </summary>
                    [NameInMap("SkipDates")]
                    [Validation(Required=false)]
                    public List<string> SkipDates { get; set; }

                }

                /// <summary>
                /// <para>The start date of the calendar validity period. Format: <c>yyyy-mm-dd</c>. This parameter is returned only for strongly constrained calendars.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-08</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                /// <summary>
                /// <para>The calendar type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>StrongConstraint: Strongly constrained calendar.</description></item>
                /// <item><description>WeakConstraint: Weakly constrained calendar.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>StrongConstraint</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of items per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
