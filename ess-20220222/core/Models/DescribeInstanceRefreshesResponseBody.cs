// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeInstanceRefreshesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance refresh tasks.</para>
        /// </summary>
        [NameInMap("InstanceRefreshTasks")]
        [Validation(Required=false)]
        public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks> InstanceRefreshTasks { get; set; }
        public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks : TeaModel {
            /// <summary>
            /// <para>The desired configurations of the instance refresh task.</para>
            /// </summary>
            [NameInMap("DesiredConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration DesiredConfiguration { get; set; }
            public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration : TeaModel {
                /// <summary>
                /// <para>The ID of the image file that provides the image resource for Auto Scaling to create instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-uf6g5noisr****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The ID of the scaling configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asc-wz91ibkhfor****</para>
                /// </summary>
                [NameInMap("ScalingConfigurationId")]
                [Validation(Required=false)]
                public string ScalingConfigurationId { get; set; }

            }

            /// <summary>
            /// <para>The reason why the instance refresh task failed to be executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The task exceeded its maximum run time of one week. So the task failed.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The end time of the instance refresh task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-22T02:09:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The refreshed number of instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FinishedUpdateCapacity")]
            [Validation(Required=false)]
            public int? FinishedUpdateCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the instance refresh task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ir-1adfa123****</para>
            /// </summary>
            [NameInMap("InstanceRefreshTaskId")]
            [Validation(Required=false)]
            public string InstanceRefreshTaskId { get; set; }

            /// <summary>
            /// <para>The ratio by which the number of instances in the scaling group can exceed the upper limit for the number of instances in the scaling group during instance refresh.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxHealthyPercentage")]
            [Validation(Required=false)]
            public int? MaxHealthyPercentage { get; set; }

            /// <summary>
            /// <para>The ratio of the number of instances that provide services to the total number of instances in the scaling group during instance refresh.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("MinHealthyPercentage")]
            [Validation(Required=false)]
            public int? MinHealthyPercentage { get; set; }

            /// <summary>
            /// <para>The region ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp16pbfcr8j9*****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The start time of the instance refresh task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-22T01:09:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the instance refresh task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The instance refresh task is created and is waiting to be scheduled.</description></item>
            /// <item><description>InProgress: The instance refresh task is being executed.</description></item>
            /// <item><description>Paused: The instance refresh task is suspended.</description></item>
            /// <item><description>Failed: The instance refresh task failed to be executed.</description></item>
            /// <item><description>Successful: The instance refresh task is successful.</description></item>
            /// <item><description>Cancelling: The instance refresh task is being canceled.</description></item>
            /// <item><description>Cancelled: The instance refresh task is canceled.</description></item>
            /// <item><description>RollbackInProgress: The instance refresh task is being rolled back.</description></item>
            /// <item><description>RollbackSuccessful: The instance refresh task is rolled back.</description></item>
            /// <item><description>RollbackFailed: The instance refresh task fails to be rolled back.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of instances whose configurations are refreshed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalNeedUpdateCapacity")]
            [Validation(Required=false)]
            public int? TotalNeedUpdateCapacity { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The total number of instance refresh tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
