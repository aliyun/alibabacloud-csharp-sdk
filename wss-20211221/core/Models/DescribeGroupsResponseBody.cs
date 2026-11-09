// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group-0c5ambj9yaeqjpXXX</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The list of instance information.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<DescribeGroupsResponseBodyGroupsInstances> Instances { get; set; }
            public class DescribeGroupsResponseBodyGroupsInstances : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1712418364463000</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>The expiration time. The time is in ISO 8601 format and the UTC time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-05T15:59Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>Specifies whether the instance is on a free trial.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FreeTrial")]
                [Validation(Required=false)]
                public bool? FreeTrial { get; set; }

                /// <summary>
                /// <para>The group resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GROUP_CORE_PACKAGE</para>
                /// </summary>
                [NameInMap("GroupResourceType")]
                [Validation(Required=false)]
                public string GroupResourceType { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chp-0c1g77wmw50b6cXXX</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The purchase period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// <para>The end time of the current period. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-01 00:00:00</para>
                /// </summary>
                [NameInMap("PeriodEndTime")]
                [Validation(Required=false)]
                public string PeriodEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the current period. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-01 00:00:00</para>
                /// </summary>
                [NameInMap("PeriodStartTime")]
                [Validation(Required=false)]
                public string PeriodStartTime { get; set; }

                /// <summary>
                /// <para>The period unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Year</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>Specifies whether priority deduction is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PriorityDeduction")]
                [Validation(Required=false)]
                public bool? PriorityDeduction { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GROUP_CORE_PACKAGE</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The start time. The time is in ISO 8601 format and the UTC time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-05T02:31Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEDUCTING</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The total duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000000</para>
                /// </summary>
                [NameInMap("TotalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                /// <summary>
                /// <para>The total duration with a precision factor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000.0000</para>
                /// </summary>
                [NameInMap("TotalTimeDecimal")]
                [Validation(Required=false)]
                public string TotalTimeDecimal { get; set; }

                /// <summary>
                /// <para>The usage Threshold Alerting rule.</para>
                /// </summary>
                [NameInMap("UsageAlertRule")]
                [Validation(Required=false)]
                public DescribeGroupsResponseBodyGroupsInstancesUsageAlertRule UsageAlertRule { get; set; }
                public class DescribeGroupsResponseBodyGroupsInstancesUsageAlertRule : TeaModel {
                    /// <summary>
                    /// <para>The list of contact group names.</para>
                    /// </summary>
                    [NameInMap("ContactGroupNames")]
                    [Validation(Required=false)]
                    public List<string> ContactGroupNames { get; set; }

                    /// <summary>
                    /// <para>The last trigger time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-07-23 10:20:30</para>
                    /// </summary>
                    [NameInMap("LastTriggeredAt")]
                    [Validation(Required=false)]
                    public string LastTriggeredAt { get; set; }

                    /// <summary>
                    /// <para>The percentage of the quota alert threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("ThresholdPercent")]
                    [Validation(Required=false)]
                    public int? ThresholdPercent { get; set; }

                }

                /// <summary>
                /// <para>The usage duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26959861</para>
                /// </summary>
                [NameInMap("UsedTime")]
                [Validation(Required=false)]
                public long? UsedTime { get; set; }

                /// <summary>
                /// <para>The usage duration with a precision factor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.0000</para>
                /// </summary>
                [NameInMap("UsedTimeDecimal")]
                [Validation(Required=false)]
                public string UsedTimeDecimal { get; set; }

            }

            /// <summary>
            /// <para>The core-hour usage in the last week.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85949.99</para>
            /// </summary>
            [NameInMap("LastWeekUsedCoreTime")]
            [Validation(Required=false)]
            public float? LastWeekUsedCoreTime { get; set; }

            /// <summary>
            /// <para>The remaining core-hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92511.15</para>
            /// </summary>
            [NameInMap("LeftCoreTime")]
            [Validation(Required=false)]
            public float? LeftCoreTime { get; set; }

            /// <summary>
            /// <para>The list of resource IDs.</para>
            /// </summary>
            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The total duration with a precision factor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000.0000</para>
            /// </summary>
            [NameInMap("TotalTimeDecimal")]
            [Validation(Required=false)]
            public string TotalTimeDecimal { get; set; }

            /// <summary>
            /// <para>The used core-hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7488.85</para>
            /// </summary>
            [NameInMap("UsedCoreTime")]
            [Validation(Required=false)]
            public float? UsedCoreTime { get; set; }

            /// <summary>
            /// <para>The usage duration with a precision factor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.0000</para>
            /// </summary>
            [NameInMap("UsedTimeDecimal")]
            [Validation(Required=false)]
            public string UsedTimeDecimal { get; set; }

        }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first request. For subsequent requests, use the <c>nextToken</c> value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68BD3312-53D8-123E-BB32-1A9F25E07A03</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
