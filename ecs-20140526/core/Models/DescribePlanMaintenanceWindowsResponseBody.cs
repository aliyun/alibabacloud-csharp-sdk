// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePlanMaintenanceWindowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page in a paging query. Maximum value: 100. Default value: 10. If no value is specified or the specified value is less than 10, the default value 10 is used. If the specified value is greater than 100, the default value 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token returned by this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// </summary>
        [NameInMap("PlanMaintenanceWindowList")]
        [Validation(Required=false)]
        public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowList> PlanMaintenanceWindowList { get; set; }
        public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowList : TeaModel {
            /// <summary>
            /// <para>The time when the O&amp;M window was created. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-11T02:20:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the O&amp;M window is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The minimum interval for scheduled O&amp;M.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinMaintenanceInterval")]
            [Validation(Required=false)]
            public int? MinMaintenanceInterval { get; set; }

            /// <summary>
            /// <para>The time when the O&amp;M window was modified. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-22 10:14:28 +0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the O&amp;M window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pw-bp1bqkbjb7h4j8zqzwvp</para>
            /// </summary>
            [NameInMap("PlanWindowId")]
            [Validation(Required=false)]
            public string PlanWindowId { get; set; }

            /// <summary>
            /// <para>The name of the O&amp;M window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WindowName</para>
            /// </summary>
            [NameInMap("PlanWindowName")]
            [Validation(Required=false)]
            public string PlanWindowName { get; set; }

            /// <summary>
            /// <para>The supported O&amp;M actions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reboot</para>
            /// </summary>
            [NameInMap("SupportMaintenanceAction")]
            [Validation(Required=false)]
            public string SupportMaintenanceAction { get; set; }

            /// <summary>
            /// <para>The resources to which the O&amp;M window applies.</para>
            /// </summary>
            [NameInMap("TargetResource")]
            [Validation(Required=false)]
            public DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResource TargetResource { get; set; }
            public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResource : TeaModel {
                /// <summary>
                /// <para>The ID of the resource group to which the O&amp;M window applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2qxeteo7fr6y</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The type of the resource for which the O&amp;M window is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The tags to which the O&amp;M window applies.</para>
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
            /// <para>The recurrence period of the window.</para>
            /// </summary>
            [NameInMap("TimePeriod")]
            [Validation(Required=false)]
            public DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriod TimePeriod { get; set; }
            public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriod : TeaModel {
                /// <summary>
                /// <para>The type of the recurrence period. Valid values: Daily and Weekly.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Year</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The time ranges of the recurrence period of the O&amp;M window in UTC.</para>
                /// </summary>
                [NameInMap("RangeList")]
                [Validation(Required=false)]
                public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriodRangeList> RangeList { get; set; }
                public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriodRangeList : TeaModel {
                    /// <summary>
                    /// <para>The end time of the maintenance time window. The format is DayOfWeek,HH:mm, such as Monday,22:00.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Monday,22:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the maintenance time window. The format is DayOfWeek,HH:mm, such as Monday,22:00.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned for the current request. This parameter is optional and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
