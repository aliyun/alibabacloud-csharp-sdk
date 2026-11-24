// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentRequest : TeaModel {
        /// <summary>
        /// <para>The metadata of the scaling activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("ActivityMetadata")]
        [Validation(Required=false)]
        public string ActivityMetadata { get; set; }

        /// <summary>
        /// <para>The adjustment method for the scaling activity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: Increases or decreases a specified number of ECS instances.</description></item>
        /// <item><description>PercentChangeInCapacity: Increases or decreases a specified percentage of ECS instances.</description></item>
        /// <item><description>TotalCapacity: Adjusts the number of ECS instances in the current scaling group to a specified number.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QuantityChangeInCapacity</para>
        /// </summary>
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// <para>The adjustment value for the scaling activity. In all cases, the number of ECS instances adjusted in a single operation cannot exceed 1,000. Otherwise, the adjustment fails. Valid values vary based on the adjustment method:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: -1,000 to 1,000.</description></item>
        /// <item><description>PercentChangeInCapacity: -100 to 10,000.</description></item>
        /// <item><description>TotalCapacity: 0 to 2,000.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and can be up to 64 ASCII characters in length. The value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: Not specified. Normal scaling is performed.</description></item>
        /// <item><description>PlanOnly: Does not trigger scaling. Only elastic planning is executed. The planning results, including instance types, zone IDs, billing methods, and the number of instances to be created, are returned in PlanResult.</description></item>
        /// </list>
        /// <para>Default value: None.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlanOnly</para>
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>The context information of the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleHookContext")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentRequestLifecycleHookContext LifecycleHookContext { get; set; }
        public class ScaleWithAdjustmentRequestLifecycleHookContext : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable all lifecycle hooks for the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Disables all lifecycle hooks.</description></item>
            /// <item><description>false: Does not disable lifecycle hooks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableLifecycleHook")]
            [Validation(Required=false)]
            public bool? DisableLifecycleHook { get; set; }

            /// <summary>
            /// <para>The list of IDs of the lifecycle hooks that are disabled for the scaling activity.</para>
            /// </summary>
            [NameInMap("IgnoredLifecycleHookIds")]
            [Validation(Required=false)]
            public List<string> IgnoredLifecycleHookIds { get; set; }

            /// <summary>
            /// <para>The default execution result of the lifecycle hook in this scaling activity. If specified, this value overrides the original default execution result of the hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("LifecycleHookResult")]
            [Validation(Required=false)]
            public string LifecycleHookResult { get; set; }

        }

        /// <summary>
        /// <para>The minimum number of instances to be adjusted in the scaling activity. This parameter takes effect only when <c>AdjustmentType</c> is set to <c>PercentChangeInCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAdjustmentMagnitude")]
        [Validation(Required=false)]
        public int? MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// <para>The override parameters specified for scaling out an Elastic Container Instance (ECI) scaling group.</para>
        /// </summary>
        [NameInMap("Overrides")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentRequestOverrides Overrides { get; set; }
        public class ScaleWithAdjustmentRequestOverrides : TeaModel {
            /// <summary>
            /// <para>The override parameters for the container list.</para>
            /// </summary>
            [NameInMap("ContainerOverrides")]
            [Validation(Required=false)]
            public List<ScaleWithAdjustmentRequestOverridesContainerOverrides> ContainerOverrides { get; set; }
            public class ScaleWithAdjustmentRequestOverridesContainerOverrides : TeaModel {
                /// <summary>
                /// <para>The arguments for the container startup command. A maximum of 10 arguments can be specified.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The startup commands for the container. A maximum of 20 commands can be specified. Each command can contain up to 256 characters.</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// <para>The number of vCPUs for the container. Unit: cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The list of environment variables.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<ScaleWithAdjustmentRequestOverridesContainerOverridesEnvironmentVars> EnvironmentVars { get; set; }
                public class ScaleWithAdjustmentRequestOverridesContainerOverridesEnvironmentVars : TeaModel {
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
                    /// <para>The value of the environment variable. The value can be 0 to 256 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/local/tomcat</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The memory size of the container. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The name of the container. When you need to override container parameters, you must specify the container name. The container parameters can be overridden only when the container name matches the container name in the scaling configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>container-1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The number of vCPUs at the instance level. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The memory size at the instance level. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The user data of the ECS instance. The user data must be encoded in Base64. The maximum size of the raw data before encoding is 32 KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the current scaling task supports concurrent execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ParallelTask")]
        [Validation(Required=false)]
        public bool? ParallelTask { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-j6c1o397427hyjdc****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronously execute the scaling activity. This parameter is valid only for scaling groups that have the expected number of instances configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Synchronous process. When the scaling rule is executed, the scale-out or scale-in activity of the scaling group is directly triggered.</description></item>
        /// <item><description>false: Asynchronous process. When the expected number of instances in the scaling group is modified, the actual scale-out or scale-in activity of the scaling group is not immediately triggered. The system automatically detects the difference between the expected number of instances and the current number of instances in the scaling group, and then triggers the scale-out or scale-in activity.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the expected number of instances, see <a href="https://help.aliyun.com/document_detail/146231.html">Expected number of instances</a>.</para>
        /// </remarks>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncActivity")]
        [Validation(Required=false)]
        public bool? SyncActivity { get; set; }

    }

}
