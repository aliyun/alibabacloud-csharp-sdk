// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePlanMaintenanceWindowsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PlanMaintenanceWindowList")]
        [Validation(Required=false)]
        public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowList> PlanMaintenanceWindowList { get; set; }
        public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-11T02:20:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-02-22 10:14:28 +0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pw-bp1bqkbjb7h4j8zqzwvp</para>
            /// </summary>
            [NameInMap("PlanWindowId")]
            [Validation(Required=false)]
            public string PlanWindowId { get; set; }

            [NameInMap("PlanWindowName")]
            [Validation(Required=false)]
            public string PlanWindowName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Reboot</para>
            /// </summary>
            [NameInMap("SupportMaintenanceAction")]
            [Validation(Required=false)]
            public string SupportMaintenanceAction { get; set; }

            [NameInMap("TargetResource")]
            [Validation(Required=false)]
            public DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResource TargetResource { get; set; }
            public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-aek2qxeteo7fr6y</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Tag</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResourceTags> Tags { get; set; }
                public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTargetResourceTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("TimePeriod")]
            [Validation(Required=false)]
            public DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriod TimePeriod { get; set; }
            public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriod : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Year</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("RangeList")]
                [Validation(Required=false)]
                public List<DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriodRangeList> RangeList { get; set; }
                public class DescribePlanMaintenanceWindowsResponseBodyPlanMaintenanceWindowListTimePeriodRangeList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Monday,22:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
