// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeInstanceRefreshesResponseBody : TeaModel {
        [NameInMap("InstanceRefreshTasks")]
        [Validation(Required=false)]
        public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks> InstanceRefreshTasks { get; set; }
        public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks : TeaModel {
            [NameInMap("DesiredConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration DesiredConfiguration { get; set; }
            public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>m-uf6g5noisr****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>asc-wz91ibkhfor****</para>
                /// </summary>
                [NameInMap("ScalingConfigurationId")]
                [Validation(Required=false)]
                public string ScalingConfigurationId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The task exceeded its maximum run time of one week. So the task failed.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-22T02:09:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FinishedUpdateCapacity")]
            [Validation(Required=false)]
            public int? FinishedUpdateCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ir-1adfa123****</para>
            /// </summary>
            [NameInMap("InstanceRefreshTaskId")]
            [Validation(Required=false)]
            public string InstanceRefreshTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxHealthyPercentage")]
            [Validation(Required=false)]
            public int? MaxHealthyPercentage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("MinHealthyPercentage")]
            [Validation(Required=false)]
            public int? MinHealthyPercentage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>asg-bp16pbfcr8j9*****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-22T01:09:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalNeedUpdateCapacity")]
            [Validation(Required=false)]
            public int? TotalNeedUpdateCapacity { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
