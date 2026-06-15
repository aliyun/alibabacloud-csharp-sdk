// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePlanMaintenanceWindowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries to return per page. The default value is 10, and the maximum value is 100. If you omit this parameter or specify a value less than 10, the default value is used. If you specify a value greater than 100, the maximum value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>A list of maintenance windows.</para>
        /// </summary>
        [NameInMap("PlanMaintenanceWindowList")]
        [Validation(Required=false)]
        public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowList> PlanMaintenanceWindowList { get; set; }
        public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowList : TeaModel {
            /// <summary>
            /// <para>The creation time of the maintenance window.</para>
            /// <para>The time is in UTC and follows the ISO 8601 standard, formatted as yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-11T02:20:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the maintenance window is enabled.</para>
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
            /// <para>The modification time of the maintenance window.</para>
            /// <para>The time is in UTC and follows the ISO 8601 standard, formatted as yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-22 10:14:28 +0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pw-bp1bqkbjb7h4j8zqzwvp</para>
            /// </summary>
            [NameInMap("PlanWindowId")]
            [Validation(Required=false)]
            public string PlanWindowId { get; set; }

            /// <summary>
            /// <para>The name of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WindowName</para>
            /// </summary>
            [NameInMap("PlanWindowName")]
            [Validation(Required=false)]
            public string PlanWindowName { get; set; }

            /// <summary>
            /// <para>The supported maintenance action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reboot</para>
            /// </summary>
            [NameInMap("SupportMaintenanceAction")]
            [Validation(Required=false)]
            public string SupportMaintenanceAction { get; set; }

            /// <summary>
            /// <para>The resources targeted by the maintenance window.</para>
            /// </summary>
            [NameInMap("TargetResource")]
            [Validation(Required=false)]
            public DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResource TargetResource { get; set; }
            public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResource : TeaModel {
                /// <summary>
                /// <para>The ID of the target resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2qxeteo7fr6y</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The scope of the target resources. Valid values: Tag, ResourceGroup, Instance, and AliUid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The target tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResourceTags> Tags { get; set; }
                public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResourceTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tagKey</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
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
            /// <para>The recurrence schedule of the maintenance window.</para>
            /// </summary>
            [NameInMap("TimePeriod")]
            [Validation(Required=false)]
            public DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriod TimePeriod { get; set; }
            public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriod : TeaModel {
                /// <summary>
                /// <para>The recurrence frequency. Valid values: Daily and Weekly.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Year</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The recurring UTC time ranges for the maintenance window.</para>
                /// </summary>
                [NameInMap("RangeList")]
                [Validation(Required=false)]
                public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriodRangeList> RangeList { get; set; }
                public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriodRangeList : TeaModel {
                    /// <summary>
                    /// <para>The end time of the time range.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Monday,22:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the time range.</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query. This parameter is optional and not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
