// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class StartInstanceRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The duration for which the task is paused when a checkpoint is reached.</para>
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
        /// <para>The checkpoints for the refresh task. When the percentage of new instances reaches a specified value during the instance refresh, the task is automatically paused for CheckpointPauseTime minutes.</para>
        /// </summary>
        [NameInMap("Checkpoints")]
        [Validation(Required=false)]
        public List<StartInstanceRefreshRequestCheckpoints> Checkpoints { get; set; }
        public class StartInstanceRefreshRequestCheckpoints : TeaModel {
            /// <summary>
            /// <para>The percentage of new instances relative to the total number of instances in the scaling group. The task is automatically paused when this percentage is reached. Valid values: 1 to 100 (%).</para>
            /// <remarks>
            /// <para>The values must be specified in ascending order, and the last value must be 100.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
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
        /// <item><description>You cannot specify ScalingConfigurationId, ImageId, LaunchTemplateId, and Containers at the same time. If this parameter is left empty, the currently active configuration of the scaling group is used for the refresh.</description></item>
        /// <item><description>After the instance refresh task is completed, the active scaling configuration of the scaling group is updated to this configuration.</description></item>
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
            /// <item><description>Only the container configurations that match <c>Container.Name</c> in the current scaling configuration container list are refreshed.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<StartInstanceRefreshRequestDesiredConfigurationContainers> Containers { get; set; }
            public class StartInstanceRefreshRequestDesiredConfigurationContainers : TeaModel {
                /// <summary>
                /// <para>The arguments of the container startup command. You can specify up to 10 arguments.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The startup commands of the container. You can specify up to 20 commands. Each command can contain up to 256 characters.</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// <para>The environment variable information.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<StartInstanceRefreshRequestDesiredConfigurationContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class StartInstanceRefreshRequestDesiredConfigurationContainersEnvironmentVars : TeaModel {
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
                    /// <para>The name of the environment variable. The name must be 1 to 128 characters in length and can contain digits, letters, and underscores (_). It cannot start with a digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable. The value can be 0 to 256 characters in length.</para>
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
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The image ID.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>After the instance refresh task is completed, the image in the currently active configuration of the scaling group is updated to this image.</description></item>
            /// <item><description>This parameter is not supported when the instance configuration source of the scaling group is a launch template.</description></item>
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
            /// <para>The ID of the launch template from which the scaling group obtains launch configuration information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-2ze2qli30u***</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The instance type information that overrides the launch template.</para>
            /// </summary>
            [NameInMap("LaunchTemplateOverrides")]
            [Validation(Required=false)]
            public List<StartInstanceRefreshRequestDesiredConfigurationLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
            public class StartInstanceRefreshRequestDesiredConfigurationLaunchTemplateOverrides : TeaModel {
                /// <summary>
                /// <para>The instance type that overrides the instance type specified in the launch template.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the LaunchTemplateId parameter specifies a launch template.</para>
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
            /// <item><description>A fixed template version number.</description></item>
            /// <item><description>Default: always uses the default version of the template.</description></item>
            /// <item><description>Latest: always uses the latest version of the template.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When the version is set to Default or Latest, the instance refresh task does not support rollback.</para>
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
        /// <para>When MinHealthyPercentage = MaxHealthyPercentage = 100, one instance is refreshed at a time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxHealthyPercentage")]
        [Validation(Required=false)]
        public int? MaxHealthyPercentage { get; set; }

        /// <summary>
        /// <para>The minimum percentage of instances that must remain in service in the scaling group during the instance refresh. Valid values: 0 to 100.
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
        /// <para>Specifies whether to skip instances that already match the desired configuration.</para>
        /// <remarks>
        /// <para>The system determines whether an instance matches based on the ID of the desired scaling configuration, not by comparing individual configuration items.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Instances that were already created with the desired configuration are skipped.</description></item>
        /// <item><description>false: All instances in the scaling group are refreshed when the instance refresh task starts.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipMatching")]
        [Validation(Required=false)]
        public bool? SkipMatching { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
