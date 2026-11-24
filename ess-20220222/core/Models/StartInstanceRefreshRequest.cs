// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class StartInstanceRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The pause duration when a checkpoint of the refresh task is reached.</para>
        /// <list type="bullet">
        /// <item><description>Unit: minutes.</description></item>
        /// <item><description>Valid values: 1 to 2880.</description></item>
        /// <item><description>Default value: 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CheckpointPauseTime")]
        [Validation(Required=false)]
        public int? CheckpointPauseTime { get; set; }

        /// <summary>
        /// <para>The checkpoints for the refresh task. This parameter specifies that the task is automatically paused for the duration specified by CheckpointPauseTime in minutes when the percentage of new instances reaches the specified value during the instance refresh.</para>
        /// </summary>
        [NameInMap("Checkpoints")]
        [Validation(Required=false)]
        public List<StartInstanceRefreshRequestCheckpoints> Checkpoints { get; set; }
        public class StartInstanceRefreshRequestCheckpoints : TeaModel {
            /// <summary>
            /// <para>The percentage of new instances out of the total instances in the scaling group. When this percentage is reached, the task is automatically paused. Valid values: 1 to 100. Unit: %.</para>
            /// <remarks>
            /// <para>The values must be set in ascending order, and the last percentage must be 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

        }

        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate the value on the client to ensure that the value is unique across different requests. The value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The desired configuration for the instance refresh.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ScalingConfigurationId, ImageId, LaunchTemplateId, and Containers cannot be specified at the same time. If this parameter is left empty, the instances are refreshed based on the active configuration of the scaling group.</description></item>
        /// <item><description>After the instance refresh task is successfully executed, the active scaling configuration of the scaling group is updated to this configuration.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("DesiredConfiguration")]
        [Validation(Required=false)]
        public StartInstanceRefreshRequestDesiredConfiguration DesiredConfiguration { get; set; }
        public class StartInstanceRefreshRequestDesiredConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of containers included in the instance.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for Elastic Container Instance (ECI) scaling groups.</description></item>
            /// <item><description>Only the container configurations whose Container.Name matches the container names in the current scaling configuration are refreshed.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<StartInstanceRefreshRequestDesiredConfigurationContainers> Containers { get; set; }
            public class StartInstanceRefreshRequestDesiredConfigurationContainers : TeaModel {
                /// <summary>
                /// <para>The arguments for the container startup commands. You can specify up to 10 arguments.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The startup commands for the container. You can specify up to 20 commands. Each command can contain up to 256 characters.</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// <para>The environment variables.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<StartInstanceRefreshRequestDesiredConfigurationContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class StartInstanceRefreshRequestDesiredConfigurationContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para>This parameter is not available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fieldPath</para>
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// <para>The name of the environment variable. The name must be 1 to 128 characters in length. It can contain letters, digits, and underscores (_), and cannot start with a digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable. The value must be 0 to 256 characters in length.</para>
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
                /// <para>The custom name of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>After the instance refresh task is successfully executed, the image configuration in the active configuration of the scaling group is updated to this image.</description></item>
            /// <item><description>This parameter is not supported if the source of the active configuration of the scaling group is a launch template.</description></item>
            /// <item><description>Images that contain data cloud disks are not supported.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>m-2ze8cqacj7opnf***</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The ID of the launch template. This parameter is used to specify that the scaling group obtains launch configurations from the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-2ze2qli30u***</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The instance type overrides for the launch template.</para>
            /// </summary>
            [NameInMap("LaunchTemplateOverrides")]
            [Validation(Required=false)]
            public List<StartInstanceRefreshRequestDesiredConfigurationLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
            public class StartInstanceRefreshRequestDesiredConfigurationLaunchTemplateOverrides : TeaModel {
                /// <summary>
                /// <para>This parameter is used to specify the instance type, which overrides the instance type in the launch template.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the LaunchTemplateId parameter is specified.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c5.2xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            /// <summary>
            /// <para>The version of the launch template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>A specific template version number.</description></item>
            /// <item><description>Default: always uses the default version of the template.</description></item>
            /// <item><description>Latest: always uses the latest version of the template.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the version is set to Default or Latest, the instance refresh task cannot be rolled back.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// <para>The ID of the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc-2zed7lqn4ts4****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

        }

        /// <summary>
        /// <para>The maximum percentage by which the number of instances in the scaling group can exceed the scaling group capacity during the instance refresh. Valid values: 100 to 200.
        /// Default value: 120.</para>
        /// <remarks>
        /// <para>If both MinHealthyPercentage and MaxHealthyPercentage are set to 100, one instance is refreshed at a time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxHealthyPercentage")]
        [Validation(Required=false)]
        public int? MaxHealthyPercentage { get; set; }

        /// <summary>
        /// <para>The minimum percentage of the scaling group capacity that must remain in service during the instance refresh. Valid values: 0 to 100.
        /// Default value: 80.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("MinHealthyPercentage")]
        [Validation(Required=false)]
        public int? MinHealthyPercentage { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip instances that match the desired configuration.</para>
        /// <remarks>
        /// <para>The system determines whether an instance matches the desired configuration based on the ID of the desired scaling configuration, without comparing specific configuration items.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: skips the instances. When the instance refresh task is started, the system checks the configuration of each instance. Instances that are already created with the desired configuration are not refreshed.</description></item>
        /// <item><description>false: does not skip the instances. After the instance refresh task is started, all instances in the scaling group are refreshed.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipMatching")]
        [Validation(Required=false)]
        public bool? SkipMatching { get; set; }

        /// <summary>
        /// <para>The execution strategy for the instance refresh task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Rolling: refreshes instances by creating new instances and releasing old instances.</para>
        /// </description></item>
        /// <item><description><para>ReplaceSystemDisk: updates the system cloud disks of existing instances by specifying DesiredConfiguration.image.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Rolling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rolling</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
