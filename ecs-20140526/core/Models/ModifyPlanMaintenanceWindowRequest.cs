// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPlanMaintenanceWindowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the maintenance window. If this parameter is not specified, the enabled status remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("MinMaintenanceInterval")]
        [Validation(Required=false)]
        public int? MinMaintenanceInterval { get; set; }

        /// <summary>
        /// <para>The ID of the maintenance window to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp1au1w8v8a1yer65g5k</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The new name of the maintenance window. If this parameter is not specified, the name remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located. You can call the DescribeRegions operation to query the most recent list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The maintenance action for the maintenance window. If this parameter is not specified, the action remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reboot</para>
        /// </summary>
        [NameInMap("SupportMaintenanceAction")]
        [Validation(Required=false)]
        public string SupportMaintenanceAction { get; set; }

        /// <summary>
        /// <para>The resources to which the maintenance window applies. If this parameter is not specified, the target resources remain unchanged.</para>
        /// </summary>
        [NameInMap("TargetResource")]
        [Validation(Required=false)]
        public ModifyPlanMaintenanceWindowRequestTargetResource TargetResource { get; set; }
        public class ModifyPlanMaintenanceWindowRequestTargetResource : TeaModel {
            /// <summary>
            /// <para>The ID of the resource group. This parameter is required when <c>Scope</c> is set to <c>ResourceGroup</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmy4cc27vsvia</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The method for specifying the target resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tag</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The resource tags. This parameter is required when <c>Scope</c> is set to <c>Tag</c>.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ModifyPlanMaintenanceWindowRequestTargetResourceTags> Tags { get; set; }
            public class ModifyPlanMaintenanceWindowRequestTargetResourceTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The recurrence schedule for the maintenance window. If this parameter is not specified, the schedule remains unchanged.</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public ModifyPlanMaintenanceWindowRequestTimePeriod TimePeriod { get; set; }
        public class ModifyPlanMaintenanceWindowRequestTimePeriod : TeaModel {
            /// <summary>
            /// <para>The unit of the recurrence cycle. Valid values: <c>Daily</c> and <c>Weekly</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The time ranges within the recurrence cycle. Times are specified in UTC.</para>
            /// </summary>
            [NameInMap("RangeList")]
            [Validation(Required=false)]
            public List<ModifyPlanMaintenanceWindowRequestTimePeriodRangeList> RangeList { get; set; }
            public class ModifyPlanMaintenanceWindowRequestTimePeriodRangeList : TeaModel {
                /// <summary>
                /// <para>The end time of the maintenance window.</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Weekly</c>, the format is <c>Day,HH:mm</c>. Valid values for <c>Day</c>: <c>Monday</c>, <c>Tuesday</c>, <c>Wednesday</c>, <c>Thursday</c>, <c>Friday</c>, <c>Saturday</c>, and <c>Sunday</c>.</para>
                /// </description></item>
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Daily</c>, the format is <c>HH:mm</c>.</para>
                /// </description></item>
                /// <item><description><para>In the time format, <c>HH</c> represents the hour (00-23) and <c>mm</c> must be <c>00</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Tuesday,03:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the maintenance window.</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Weekly</c>, the format is <c>Day,HH:mm</c>. Valid values for <c>Day</c>: <c>Monday</c>, <c>Tuesday</c>, <c>Wednesday</c>, <c>Thursday</c>, <c>Friday</c>, <c>Saturday</c>, and <c>Sunday</c>.</para>
                /// </description></item>
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Daily</c>, the format is <c>HH:mm</c>.</para>
                /// </description></item>
                /// <item><description><para>In the time format, <c>HH</c> represents the hour (00-23) and <c>mm</c> must be <c>00</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Monday,22:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

    }

}
