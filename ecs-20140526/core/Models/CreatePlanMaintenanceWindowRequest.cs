// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreatePlanMaintenanceWindowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the window. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The minimum interval between two scheduled O&amp;M events for the same instance. Valid values: 1 to 48. Unit: hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("MinMaintenanceInterval")]
        [Validation(Required=false)]
        public int? MinMaintenanceInterval { get; set; }

        /// <summary>
        /// <para>The name of the O&amp;M window. You can customize the name. The name can be up to 200 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required for Alibaba Cloud SDK routing. However, specifying any region ID for this operation yields the same result. The O&amp;M window applies to all ECS instances across the network that meet the resource filtering conditions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The O&amp;M operations supported by the O&amp;M window.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reboot</para>
        /// </summary>
        [NameInMap("SupportMaintenanceAction")]
        [Validation(Required=false)]
        public string SupportMaintenanceAction { get; set; }

        /// <summary>
        /// <para>The resources to which the O&amp;M window applies.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetResource")]
        [Validation(Required=false)]
        public CreatePlanMaintenanceWindowRequestTargetResource TargetResource { get; set; }
        public class CreatePlanMaintenanceWindowRequestTargetResource : TeaModel {
            /// <summary>
            /// <para>The ID of the resource group. This parameter is required when Scope is set to ResourceGroup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzhm7pmnvcbty</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of resources configured for the O&amp;M window.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tag</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The tags to which the O&amp;M window applies. This parameter is required when Scope is set to Tag.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreatePlanMaintenanceWindowRequestTargetResourceTags> Tags { get; set; }
            public class CreatePlanMaintenanceWindowRequestTargetResourceTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag to which the window applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vms_qualification_Mr. Sun ID card_e5590864-1fef-4db2-b2a7-bd2d657fed43.png</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag to which the window applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21.137.18.60</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The recurrence cycle of the window.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public CreatePlanMaintenanceWindowRequestTimePeriod TimePeriod { get; set; }
        public class CreatePlanMaintenanceWindowRequestTimePeriod : TeaModel {
            /// <summary>
            /// <para>The type of the recurrence cycle. Valid values: Daily and Weekly.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weekly</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The time ranges of the O&amp;M window recurrence cycle in the UTC time zone.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RangeList")]
            [Validation(Required=false)]
            public List<CreatePlanMaintenanceWindowRequestTimePeriodRangeList> RangeList { get; set; }
            public class CreatePlanMaintenanceWindowRequestTimePeriodRangeList : TeaModel {
                /// <summary>
                /// <para>The end time of the O&amp;M window.</para>
                /// <list type="bullet">
                /// <item><description>If PeriodUnit is set to Weekly, the format is Monday,22:00. You can replace Monday with Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday.</description></item>
                /// <item><description>If PeriodUnit is set to Daily, the format is 22:00.</description></item>
                /// <item><description>The comma (,) is used as a delimiter. The first part represents the hour, which ranges from 00 to 23. The second part represents the minute. Currently, only 00 is supported.</description></item>
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
                /// <item><description>If PeriodUnit is set to Weekly, the format is Monday,22:00. You can replace Monday with Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday.</description></item>
                /// <item><description>If PeriodUnit is set to Daily, the format is 22:00.</description></item>
                /// <item><description>The comma (,) is used as a delimiter. The first part represents the hour, which ranges from 00 to 23. The second part represents the minute. Currently, only 00 is supported.</description></item>
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
