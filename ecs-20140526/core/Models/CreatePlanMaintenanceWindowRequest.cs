// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreatePlanMaintenanceWindowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the maintenance window.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the maintenance window.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables the maintenance window.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("MinMaintenanceInterval")]
        [Validation(Required=false)]
        public int? MinMaintenanceInterval { get; set; }

        /// <summary>
        /// <para>The name of the maintenance window. The name can be up to 200 characters long.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the DescribeRegions operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The maintenance operation supported by the maintenance window.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reboot</para>
        /// </summary>
        [NameInMap("SupportMaintenanceAction")]
        [Validation(Required=false)]
        public string SupportMaintenanceAction { get; set; }

        /// <summary>
        /// <para>The resources to which the maintenance window applies.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetResource")]
        [Validation(Required=false)]
        public CreatePlanMaintenanceWindowRequestTargetResource TargetResource { get; set; }
        public class CreatePlanMaintenanceWindowRequestTargetResource : TeaModel {
            /// <summary>
            /// <para>The ID of the resource group. This parameter is required if <c>Scope</c> is set to <c>ResourceGroup</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzhm7pmnvcbty</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The scope of resources to which the maintenance window applies.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tag</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The tags of the resources to which the maintenance window applies. This parameter is required if <c>Scope</c> is set to <c>Tag</c>.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreatePlanMaintenanceWindowRequestTargetResourceTags> Tags { get; set; }
            public class CreatePlanMaintenanceWindowRequestTargetResourceTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vms_qualification_孙总身份证_e5590864-1fef-4db2-b2a7-bd2d657fed43.png</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
        /// <para>The recurring schedule for the maintenance window.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public CreatePlanMaintenanceWindowRequestTimePeriod TimePeriod { get; set; }
        public class CreatePlanMaintenanceWindowRequestTimePeriod : TeaModel {
            /// <summary>
            /// <para>Specifies how often the maintenance window recurs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weekly</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The time ranges of the recurring maintenance window. All times are in UTC.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RangeList")]
            [Validation(Required=false)]
            public List<CreatePlanMaintenanceWindowRequestTimePeriodRangeList> RangeList { get; set; }
            public class CreatePlanMaintenanceWindowRequestTimePeriodRangeList : TeaModel {
                /// <summary>
                /// <para>The end time of the maintenance window.</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Weekly</c>, use the format <c>Day,HH:mm</c>. Valid values for <c>Day</c> are <c>Monday</c>, <c>Tuesday</c>, <c>Wednesday</c>, <c>Thursday</c>, <c>Friday</c>, <c>Saturday</c>, and <c>Sunday</c>.</para>
                /// </description></item>
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Daily</c>, use the format <c>HH:mm</c>.</para>
                /// </description></item>
                /// <item><description><para>The time is in <c>HH:mm</c> format, where <c>HH</c> is the hour (00-23) and <c>mm</c> is the minute. Only <c>00</c> is supported for the minute.</para>
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
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Weekly</c>, use the format <c>Day,HH:mm</c>. Valid values for <c>Day</c> are <c>Monday</c>, <c>Tuesday</c>, <c>Wednesday</c>, <c>Thursday</c>, <c>Friday</c>, <c>Saturday</c>, and <c>Sunday</c>.</para>
                /// </description></item>
                /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Daily</c>, use the format <c>HH:mm</c>.</para>
                /// </description></item>
                /// <item><description><para>The time is in <c>HH:mm</c> format, where <c>HH</c> is the hour (00-23) and <c>mm</c> is the minute. Only <c>00</c> is supported for the minute.</para>
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
