// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateCalendarShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the calendar applies to all workspaces. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: All workspaces.</description></item>
        /// <item><description>false: The workspaces specified by ProjectIds.</description></item>
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
        /// <para>The end date of the calendar validity period, in the <c>yyyy-mm-dd</c> format. Required when Type is set to StrongConstraint. The end date cannot be earlier than the start date, and the interval between the start date and the end date must be less than 5 years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-09</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The expiration reminder. Required when Type is set to StrongConstraint. Valid values:</para>
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
        /// <para>The default scheduling policy for dates that are not configured. Required when Type is set to WeakConstraint. Valid values:</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The scheduling policy after the calendar expires. Required when Type is set to StrongConstraint. Valid values:</para>
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
        /// <item><description>Required and cannot be empty when AllProjects is set to false or left unspecified.</description></item>
        /// <item><description>Leave empty or pass an empty array when AllProjects is set to true.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public string ProjectIdsShrink { get; set; }

        /// <summary>
        /// <para>The date scheduling policy. For a strong constraint calendar, the normal scheduling dates and non-scheduling dates must cover every day within the validity period and cannot overlap.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SchedulePolicy")]
        [Validation(Required=false)]
        public string SchedulePolicyShrink { get; set; }

        /// <summary>
        /// <para>The start date of the calendar validity period, in the <c>yyyy-mm-dd</c> format. Required when Type is set to StrongConstraint.</para>
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
        /// <item><description>StrongConstraint: Strong constraint calendar.</description></item>
        /// <item><description>WeakConstraint: Weak constraint calendar.</description></item>
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
