// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateCalendarRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the calendar applies to all workspaces. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>true: all workspaces.</description></item>
        /// <item><description>false: the workspaces specified by ProjectIds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllProjects")]
        [Validation(Required=false)]
        public bool? AllProjects { get; set; }

        /// <summary>
        /// <para>The description of the scheduling calendar. The description must be 5 to 2,048 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekday scheduling calendar</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end date of the calendar validity period. Format: <c>yyyy-mm-dd</c>. This parameter is required when Type is set to StrongConstraint. The end date cannot be earlier than the start date, and the interval between the start date and the end date must be less than 5 years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-09</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The expiration reminder. This parameter is required when Type is set to StrongConstraint.</para>
        /// <list type="bullet">
        /// <item><description>OneMonthBefore: one month in advance.</description></item>
        /// <item><description>OneWeekBefore: one week in advance.</description></item>
        /// <item><description>ThreeDaysBefore: three days in advance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OneMonthBefore</para>
        /// </summary>
        [NameInMap("ExpirationReminder")]
        [Validation(Required=false)]
        public string ExpirationReminder { get; set; }

        /// <summary>
        /// <para>The default scheduling policy for dates that are not configured. This parameter is required when Type is set to WeakConstraint.</para>
        /// <list type="bullet">
        /// <item><description>Normal: normal scheduling.</description></item>
        /// <item><description>Pause: pause scheduling.</description></item>
        /// <item><description>Skip: dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("FallbackPolicy")]
        [Validation(Required=false)]
        public string FallbackPolicy { get; set; }

        /// <summary>
        /// <para>The name of the scheduling calendar. The name must be unique within the current tenant and can be up to 100 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work_calendar</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The scheduling policy after the calendar expires. This parameter is required when Type is set to StrongConstraint.</para>
        /// <list type="bullet">
        /// <item><description>Normal: normal scheduling.</description></item>
        /// <item><description>Pause: pause scheduling.</description></item>
        /// <item><description>Skip: dry run.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The list of applicable workspace IDs.</para>
        /// <list type="bullet">
        /// <item><description>If AllProjects is set to false or left empty: This parameter is required and cannot be empty.</description></item>
        /// <item><description>If AllProjects is set to true: Leave this parameter empty or pass an empty array.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public List<long?> ProjectIds { get; set; }

        /// <summary>
        /// <para>The date scheduling policy. For a strong constraint calendar, the normal scheduling dates and non-scheduling dates must cover every day within the validity period and cannot overlap.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SchedulePolicy")]
        [Validation(Required=false)]
        public CreateCalendarRequestSchedulePolicy SchedulePolicy { get; set; }
        public class CreateCalendarRequestSchedulePolicy : TeaModel {
            /// <summary>
            /// <para>The list of normal scheduling dates.</para>
            /// </summary>
            [NameInMap("NormalDates")]
            [Validation(Required=false)]
            public List<string> NormalDates { get; set; }

            /// <summary>
            /// <para>The list of non-scheduling dates. Tasks perform dry runs on these dates. This parameter is used only for strong constraint calendars.</para>
            /// </summary>
            [NameInMap("SkipDates")]
            [Validation(Required=false)]
            public List<string> SkipDates { get; set; }

        }

        /// <summary>
        /// <para>The start date of the calendar validity period. Format: <c>yyyy-mm-dd</c>. This parameter is required when Type is set to StrongConstraint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-08</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The type of the calendar.</para>
        /// <list type="bullet">
        /// <item><description>StrongConstraint: strong constraint calendar.</description></item>
        /// <item><description>WeakConstraint: weak constraint calendar.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StrongConstraint</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
