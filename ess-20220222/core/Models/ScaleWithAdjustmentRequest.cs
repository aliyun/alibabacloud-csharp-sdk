// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentRequest : TeaModel {
        /// <summary>
        /// The metadata of the scaling activity.
        /// </summary>
        [NameInMap("ActivityMetadata")]
        [Validation(Required=false)]
        public string ActivityMetadata { get; set; }

        /// <summary>
        /// The type of the scaling policy. Valid values:
        /// 
        /// *   QuantityChangeInCapacity: adds the specified number of ECS instances to or removes the specified number of ECS instances from the scaling group.
        /// *   PercentChangeInCapacity: adds the specified percentage of ECS instances to or removes the specified percentage of ECS instances from the scaling group.
        /// *   TotalCapacity: adjusts the number of ECS instances in the scaling group to a specified number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// The number of instances in each adjustment. The number of ECS instances in each adjustment cannot exceed 1,000.
        /// 
        /// *   Valid values if you set the AdjustmentType parameter to QuantityChangeInCapacity: -1000 to 1000.
        /// *   Valid values if you set the AdjustmentType parameter to PercentChangeInCapacity: -100 to 10000.
        /// *   Valid values if you set the AdjustmentType parameter to TotalCapacity: 0 to 2000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The context of the lifecycle hook.
        /// </summary>
        [NameInMap("LifecycleHookContext")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentRequestLifecycleHookContext LifecycleHookContext { get; set; }
        public class ScaleWithAdjustmentRequestLifecycleHookContext : TeaModel {
            /// <summary>
            /// Specifies whether to disable the Lifecycle Hook feature. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("DisableLifecycleHook")]
            [Validation(Required=false)]
            public bool? DisableLifecycleHook { get; set; }

            /// <summary>
            /// The IDs of the lifecycle hooks that you want to disable.
            /// </summary>
            [NameInMap("IgnoredLifecycleHookIds")]
            [Validation(Required=false)]
            public List<string> IgnoredLifecycleHookIds { get; set; }

        }

        /// <summary>
        /// The minimum number of instances allowed in each adjustment. This parameter takes effect only if you set the `AdjustmentType` parameter to `PercentChangeInCapacity`.
        /// </summary>
        [NameInMap("MinAdjustmentMagnitude")]
        [Validation(Required=false)]
        public int? MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// The overrides that allow you to adjust the scaling group of the Elastic Container Instance type during a scale-out.
        /// </summary>
        [NameInMap("Overrides")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentRequestOverrides Overrides { get; set; }
        public class ScaleWithAdjustmentRequestOverrides : TeaModel {
            /// <summary>
            /// The list of parameters that you want to use to override specific configurations for containers.
            /// </summary>
            [NameInMap("ContainerOverrides")]
            [Validation(Required=false)]
            public List<ScaleWithAdjustmentRequestOverridesContainerOverrides> ContainerOverrides { get; set; }
            public class ScaleWithAdjustmentRequestOverridesContainerOverrides : TeaModel {
                /// <summary>
                /// The arguments that correspond to the startup commands of the container. You can specify up to 10 arguments.
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// The startup commands of the container. You can specify up to 20 commands. Each command can contain up to 256 characters.
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// The number of vCPUs that you want to allocate to the container.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The information about the environment variables.
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<ScaleWithAdjustmentRequestOverridesContainerOverridesEnvironmentVars> EnvironmentVars { get; set; }
                public class ScaleWithAdjustmentRequestOverridesContainerOverridesEnvironmentVars : TeaModel {
                    /// <summary>
                    /// The name of the environment variable. The name can be 1 to 128 characters in length and can contain letters, underscores (_), and digits. It cannot start with a digit. Specify the value in the `[0-9a-zA-Z]` format.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the environment variable. The value can be up to 256 characters in length.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The memory size that you want to allocate to the container. Unit: GiB.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// The container name. If you specify ContainerOverrides, you must also specify Name. ContainerOverrides takes effect only when the container name specified by Name matches that specified in the scaling configuration.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The number of vCPUs that you want to allocate to the instance.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The memory size that you want to allocate to the instance. Unit: GiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// Specifies whether to trigger the scaling activity in a synchronous manner. This parameter takes effect only on scaling groups for which you specified an expected number of instances. Valid values:
        /// 
        /// *   true: triggers the scaling activity in a synchronous manner. The scaling activity is triggered at the time when the scaling rule is executed.
        /// *   false: does not trigger the scaling activity in a synchronous manner. After you change the expected number of instances for the scaling group, Auto Scaling checks whether the total number of instances in the scaling group matches the new expected number of instances and determines whether to trigger the scaling activity based on the check result.
        /// 
        /// > For more information about the Expected Number of Instances feature, see [Expected number of instances](https://help.aliyun.com/document_detail/146231.html).
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("SyncActivity")]
        [Validation(Required=false)]
        public bool? SyncActivity { get; set; }

    }

}
