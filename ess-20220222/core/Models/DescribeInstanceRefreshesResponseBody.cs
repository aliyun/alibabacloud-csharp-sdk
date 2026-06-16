// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeInstanceRefreshesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance refresh tasks.</para>
        /// </summary>
        [NameInMap("InstanceRefreshTasks")]
        [Validation(Required=false)]
        public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks> InstanceRefreshTasks { get; set; }
        public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks : TeaModel {
            /// <summary>
            /// <para>The duration for which the task pauses when a checkpoint is reached. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CheckpointPauseTime")]
            [Validation(Required=false)]
            public int? CheckpointPauseTime { get; set; }

            /// <summary>
            /// <para>The checkpoints for the refresh task. A checkpoint specifies that the task automatically pauses for CheckpointPauseTime minutes when the proportion of new instances reaches the specified value during the instance refresh.</para>
            /// </summary>
            [NameInMap("Checkpoints")]
            [Validation(Required=false)]
            public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksCheckpoints> Checkpoints { get; set; }
            public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksCheckpoints : TeaModel {
                /// <summary>
                /// <para>The percentage of new instances relative to the total instances in the scaling group. The task automatically pauses when this percentage is reached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

            }

            /// <summary>
            /// <para>The desired configuration for the instance refresh.</para>
            /// </summary>
            [NameInMap("DesiredConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration DesiredConfiguration { get; set; }
            public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration : TeaModel {
                /// <summary>
                /// <para>The list of containers included in the instance.</para>
                /// </summary>
                [NameInMap("Containers")]
                [Validation(Required=false)]
                public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfigurationContainers> Containers { get; set; }
                public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfigurationContainers : TeaModel {
                    /// <summary>
                    /// <para>The arguments for the container startup commands.</para>
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// <para>The container startup commands.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                    /// <summary>
                    /// <para>The environment variable information.</para>
                    /// </summary>
                    [NameInMap("EnvironmentVars")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfigurationContainersEnvironmentVars> EnvironmentVars { get; set; }
                    public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfigurationContainersEnvironmentVars : TeaModel {
                        /// <summary>
                        /// <remarks>
                        /// <para>This parameter is not available for use.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fieldPath</para>
                        /// </summary>
                        [NameInMap("FieldRefFieldPath")]
                        [Validation(Required=false)]
                        public string FieldRefFieldPath { get; set; }

                        /// <summary>
                        /// <para>The name of the environment variable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PATH</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the environment variable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/local/bin</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The container image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/eci_open/nginx:latest</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The custom container name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The ID of the image file used for automatic creation of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-uf6g5noisr****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The ID of the launch template from which the scaling group obtains launch configuration information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lt-2ze5x4mp*****</para>
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// <para>The instance type information that overrides the launch template.</para>
                /// </summary>
                [NameInMap("LaunchTemplateOverrides")]
                [Validation(Required=false)]
                public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfigurationLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
                public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfigurationLaunchTemplateOverrides : TeaModel {
                    /// <summary>
                    /// <para>The instance type that overrides the instance type specified in the launch template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.sn1ne.large</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                /// <summary>
                /// <para>The version of the launch template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>A fixed template version number.</description></item>
                /// <item><description>Default: always uses the default version of the template.</description></item>
                /// <item><description>Latest: always uses the latest version of the template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Latest</para>
                /// </summary>
                [NameInMap("LaunchTemplateVersion")]
                [Validation(Required=false)]
                public string LaunchTemplateVersion { get; set; }

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
            /// <para>The failure reason when the instance refresh task fails.</para>
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
            /// <para>The capacity that has been refreshed.</para>
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
            /// <para>The maximum percentage by which the number of instances in the scaling group can exceed the scaling group capacity during the instance refresh.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxHealthyPercentage")]
            [Validation(Required=false)]
            public int? MaxHealthyPercentage { get; set; }

            /// <summary>
            /// <para>The minimum percentage of instances that must remain in service in the scaling group during the instance refresh.</para>
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
            /// <para>Indicates whether instances that already match the desired configuration are skipped.</para>
            /// <remarks>
            /// <para>The system determines whether an instance matches based on the ID of the desired scaling configuration, not by comparing individual configuration items.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Skipped. When the instance refresh task starts, the system checks the configuration of each instance. Instances that were already created with the desired configuration are not refreshed.</description></item>
            /// <item><description>false: Not skipped. After the instance refresh task starts, all instances in the scaling group are refreshed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipMatching")]
            [Validation(Required=false)]
            public bool? SkipMatching { get; set; }

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
            /// <para>The current status of the instance refresh task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The instance refresh task is created and waiting to be scheduled.</description></item>
            /// <item><description>InProgress: The instance refresh task is in progress.</description></item>
            /// <item><description>Paused: The instance refresh task is paused.</description></item>
            /// <item><description>CheckpointPause: The instance refresh task is paused because the task progress reached a checkpoint (<c>Checkpoint.Percentage</c>).</description></item>
            /// <item><description>Failed: The instance refresh task failed.</description></item>
            /// <item><description>Successful: The instance refresh task succeeded.</description></item>
            /// <item><description>Cancelling: The instance refresh task is being canceled.</description></item>
            /// <item><description>Cancelled: The instance refresh task is canceled.</description></item>
            /// <item><description>RollbackInProgress: The instance refresh task is being rolled back.</description></item>
            /// <item><description>RollbackSuccessful: The instance refresh task is rolled back.</description></item>
            /// <item><description>RollbackFailed: The rollback of the instance refresh task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

            /// <summary>
            /// <para>The total capacity that needs to be refreshed.</para>
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
        /// <para>The pagination token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
