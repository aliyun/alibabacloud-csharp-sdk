// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class StartInstanceRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The duration of the pause when the refresh task checkpoint is entered.</para>
        /// <list type="bullet">
        /// <item><description>Unit: minutes</description></item>
        /// <item><description>Valid values: 1 to 2880.</description></item>
        /// <item><description>Default: 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CheckpointPauseTime")]
        [Validation(Required=false)]
        public int? CheckpointPauseTime { get; set; }

        /// <summary>
        /// <para>Refresh Task Checkpoint: specifies that the task is automatically suspended for CheckpointPauseTime minutes when the proportion of new instances reaches the specified value during instance refresh.</para>
        /// </summary>
        [NameInMap("Checkpoints")]
        [Validation(Required=false)]
        public List<StartInstanceRefreshRequestCheckpoints> Checkpoints { get; set; }
        public class StartInstanceRefreshRequestCheckpoints : TeaModel {
            /// <summary>
            /// <para>The percentage of new instances in the scaling group to the total number of instances. When this percentage is reached, the task is automatically suspended. Valid values: 1 to 100 (%).</para>
            /// <remarks>
            /// <para> Requires a small to large setting, and the last progress percentage needs to be 100.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The desired configurations of the instance refresh task.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>ScalingConfigurationId, ImageId, LaunchTemplateId, and Containers cannot be set at the same time. If you do not specify this parameter, the scaling group is refreshed based on the configurations that are in effect.</para>
        /// </description></item>
        /// <item><description><para>After the instance refresh task is complete, the scaling group uses the scaling configuration specified by this parameter.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("DesiredConfiguration")]
        [Validation(Required=false)]
        public StartInstanceRefreshRequestDesiredConfiguration DesiredConfiguration { get; set; }
        public class StartInstanceRefreshRequestDesiredConfiguration : TeaModel {
            /// <summary>
            /// <para>The containers in the elastic container instance.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter supports only scaling groups of the ECI type.</para>
            /// </description></item>
            /// <item><description><para>Only the containers in the scaling configuration list that are the same as those in the <c>Container.Name</c> are refreshed.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<StartInstanceRefreshRequestDesiredConfigurationContainers> Containers { get; set; }
            public class StartInstanceRefreshRequestDesiredConfigurationContainers : TeaModel {
                /// <summary>
                /// <para>The argument that corresponds to the startup command of the container. You can specify up to 10 arguments.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The container startup commands. You can specify up to 20 commands. Each command can contain up to 256 characters.</para>
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
                    /// <para> This parameter is unavailable for use.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fieldPath</para>
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// <para>The name of the environment variable. It can be 1 to 128 characters in length. Format requirement:[0-9a-zA-Z], and underscores, cannot start with a number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable. The value must be 0 to 256 bits in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/local/bin</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The image in the container.</para>
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
            /// <para>The image ID.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>After the instance refresh task is complete, the active scaling configuration uses the image specified by this parameter.</para>
            /// </description></item>
            /// <item><description><para>If the instance configuration source of the scaling group is a launch template, you cannot specify this parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>m-2ze8cqacj7opnf***</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The ID of the launch template that you want to enable in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-2ze2qli30u***</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The information about the instance types that are extended in the launch template.</para>
            /// </summary>
            [NameInMap("LaunchTemplateOverrides")]
            [Validation(Required=false)]
            public List<StartInstanceRefreshRequestDesiredConfigurationLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
            public class StartInstanceRefreshRequestDesiredConfigurationLaunchTemplateOverrides : TeaModel {
                /// <summary>
                /// <para>The instance type specified by using this parameter overwrites the instance type of the launch template.</para>
                /// <remarks>
                /// <para> This parameter takes effect only if you specify LaunchTemplateId.</para>
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
            /// <para>The version number of the launch template. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>A fixed template version number.</description></item>
            /// <item><description>Default: the default version of the template.</description></item>
            /// <item><description>Latest: the latest version of the template.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you set the version to Default or Latest, the instance refresh task cannot be rolled back.</para>
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
        /// <para>The ratio of instances that can exceed the upper limit of the scaling group capacity to all instances in the scaling group during instance refresh. Valid values: 100 to 200. Default value: 120.</para>
        /// <remarks>
        /// <para> If you set MinHealthyPercentage and MaxHealthyPercentage to 100, Auto Scaling refreshes the configurations of one instance each time the instance refresh task starts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxHealthyPercentage")]
        [Validation(Required=false)]
        public int? MaxHealthyPercentage { get; set; }

        /// <summary>
        /// <para>The ratio of instances that are in the In Service state to all instances in the scaling group during instance refresh. Valid values: 0 to 100. Default value: 80.</para>
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
        /// <para>Specifies whether to skip instances that match the desired scaling configuration.</para>
        /// <remarks>
        /// <para> The system determines the match based on the ID of the desired scaling configuration rather than individual configuration items.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: skips instances that match the desired scaling configuration. When you initiate an instance refresh task, the system checks the configurations of all instances. The refresh operation is skipped for instances created based on the desired scaling configuration.</description></item>
        /// <item><description>false: does not skip instances that match the desired scaling configuration. When an instance refresh task is initiated, all instances in the scaling group at the time of initiation are refreshed.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipMatching")]
        [Validation(Required=false)]
        public bool? SkipMatching { get; set; }

    }

}
