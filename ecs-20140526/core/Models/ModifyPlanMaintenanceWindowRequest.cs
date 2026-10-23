// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPlanMaintenanceWindowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable the window. Leave this parameter empty if no modification is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The minimum time interval between the publish time and the scheduled time to execute scheduled O&amp;M events for the same instance. Valid values: 1 to 48. Unit: hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("MinMaintenanceInterval")]
        [Validation(Required=false)]
        public int? MinMaintenanceInterval { get; set; }

        /// <summary>
        /// <para>The ID of the O&amp;M window to be modified. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp1au1w8v8a1yer65g5k</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The name of the O&amp;M window. Leave this parameter empty if no modification is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required for Alibaba Cloud SDK routing. However, specifying any region ID for this operation makes no difference. The O&amp;M window applies to all ECS instances across the network that meet the resource filtering conditions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The supported O&amp;M actions. Leave this parameter empty if no modification is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reboot</para>
        /// </summary>
        [NameInMap("SupportMaintenanceAction")]
        [Validation(Required=false)]
        public string SupportMaintenanceAction { get; set; }

        /// <summary>
        /// <para>The resources to which the O&amp;M window applies. Leave this parameter empty if no modification is required.</para>
        /// </summary>
        [NameInMap("TargetResource")]
        [Validation(Required=false)]
        public ModifyPlanMaintenanceWindowRequestTargetResource TargetResource { get; set; }
        public class ModifyPlanMaintenanceWindowRequestTargetResource : TeaModel {
            /// <summary>
            /// <para>The ID of the resource group to which the O&amp;M window applies. This parameter is required only when Scope is set to ResourceGroup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmy4cc27vsvia</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of resources to which the O&amp;M window is configured to apply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tag</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The tags to which the O&amp;M window applies. This parameter is required only when Scope is set to Tag.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ModifyPlanMaintenanceWindowRequestTargetResourceTags> Tags { get; set; }
            public class ModifyPlanMaintenanceWindowRequestTargetResourceTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag to which the window applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag to which the window applies.</para>
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
        /// <para>The recurrence cycle of the window. Leave this parameter empty if no modification is required.</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public ModifyPlanMaintenanceWindowRequestTimePeriod TimePeriod { get; set; }
        public class ModifyPlanMaintenanceWindowRequestTimePeriod : TeaModel {
            /// <summary>
            /// <para>The type of the recurrence cycle. Valid values: Daily and Weekly.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The time ranges of the O&amp;M window recurrence cycle in the UTC time zone.</para>
            /// </summary>
            [NameInMap("RangeList")]
            [Validation(Required=false)]
            public List<ModifyPlanMaintenanceWindowRequestTimePeriodRangeList> RangeList { get; set; }
            public class ModifyPlanMaintenanceWindowRequestTimePeriodRangeList : TeaModel {
                /// <summary>
                /// <para>The end time of the O&amp;M window.</para>
                /// <list type="bullet">
                /// <item><description>If PeriodUnit is set to Weekly, the time range is in the format of Monday,22:00. Monday can be replaced with Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday.</description></item>
                /// <item><description>If PeriodUnit is set to Daily, the time range is in the format of 22:00.</description></item>
                /// <item><description>The comma (,) is used as a delimiter. The first part represents the hour, with valid values from 00 to 23. The second part represents the minute. Currently, only 00 is supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Tuesday,03:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the O&amp;M window.</para>
                /// <list type="bullet">
                /// <item><description>If PeriodUnit is set to Weekly, the time range is in the format of Monday,22:00. Monday can be replaced with Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday.</description></item>
                /// <item><description>If PeriodUnit is set to Daily, the time range is in the format of 22:00.</description></item>
                /// <item><description>The comma (,) is used as a delimiter. The first part represents the hour, with valid values from 00 to 23. The second part represents the minute. Currently, only 00 is supported.</description></item>
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
