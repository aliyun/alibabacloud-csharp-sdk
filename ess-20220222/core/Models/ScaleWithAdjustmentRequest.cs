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
        /// <para>The type of the scaling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: adds the specified number of ECS instances to or removes the specified number of ECS instances from the scaling group.</description></item>
        /// <item><description>PercentChangeInCapacity: adds the specified percentage of ECS instances to or removes the specified percentage of ECS instances from the scaling group.</description></item>
        /// <item><description>TotalCapacity: adjusts the number of ECS instances in the scaling group to a specified number.</description></item>
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
        /// <para>The number of instances in each adjustment. The number of ECS instances in each adjustment cannot exceed 1,000.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set the AdjustmentType parameter to QuantityChangeInCapacity: -1000 to 1000.</description></item>
        /// <item><description>Valid values if you set the AdjustmentType parameter to PercentChangeInCapacity: -100 to 10000.</description></item>
        /// <item><description>Valid values if you set the AdjustmentType parameter to TotalCapacity: 0 to 2000.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <item><description>None: If this is not specified, auto scaling is performed.</description></item>
        /// <item><description>PlanOnly: Scaling is not triggered. Only elastic planning is performed. The planning result is returned in PlanResult, including the instance type, zone ID, billing type, and number of created instances.</description></item>
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
        /// <para>The context of the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleHookContext")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentRequestLifecycleHookContext LifecycleHookContext { get; set; }
        public class ScaleWithAdjustmentRequestLifecycleHookContext : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable the lifecycle hook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableLifecycleHook")]
            [Validation(Required=false)]
            public bool? DisableLifecycleHook { get; set; }

            /// <summary>
            /// <para>The IDs of the lifecycle hooks that you want to disable.</para>
            /// </summary>
            [NameInMap("IgnoredLifecycleHookIds")]
            [Validation(Required=false)]
            public List<string> IgnoredLifecycleHookIds { get; set; }

            [NameInMap("LifecycleHookResult")]
            [Validation(Required=false)]
            public string LifecycleHookResult { get; set; }

        }

        /// <summary>
        /// <para>The minimum number of instances allowed in each adjustment. This parameter takes effect only if you set the <c>AdjustmentType</c> parameter to <c>PercentChangeInCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAdjustmentMagnitude")]
        [Validation(Required=false)]
        public int? MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// <para>The overrides that allow you to adjust the scaling group of the Elastic Container Instance (ECI) type during a scale-out event.</para>
        /// </summary>
        [NameInMap("Overrides")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentRequestOverrides Overrides { get; set; }
        public class ScaleWithAdjustmentRequestOverrides : TeaModel {
            /// <summary>
            /// <para>The list of parameters that you want to use to override specific configurations for containers.</para>
            /// </summary>
            [NameInMap("ContainerOverrides")]
            [Validation(Required=false)]
            public List<ScaleWithAdjustmentRequestOverridesContainerOverrides> ContainerOverrides { get; set; }
            public class ScaleWithAdjustmentRequestOverridesContainerOverrides : TeaModel {
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
                /// <para>The number of vCPUs that you want to allocate to the container. Unit: vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The information about the environment variables.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<ScaleWithAdjustmentRequestOverridesContainerOverridesEnvironmentVars> EnvironmentVars { get; set; }
                public class ScaleWithAdjustmentRequestOverridesContainerOverridesEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable. The name must be 1 to 128 characters in length. Format requirement: <c>[0-9a-zA-Z]</c> and underscores (_). It cannot start with a digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable. The value can be up to 256 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/local/tomcat</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The memory size that you want to allocate to the container. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The name of the container. If you specify ContainerOverrides, you must also specify Name. ContainerOverrides takes effect only when the container name specified by Name matches that specified in the scaling configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>container-1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The number of vCPUs that you want to allocate to the instance. Unit: vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The memory size that you want to allocate to the instance. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The user data of the Elastic Compute Service (ECS) instance. The user data must be encoded in Base64 format. The size of raw data before Base64 encoding cannot exceed 32 KB.</para>
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
        /// <para>Whether the current scale-out task supports concurrency.</para>
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
        /// <para>Specifies whether to trigger the scaling task in a synchronous manner. This parameter takes effect only on scaling groups for which you specified an expected number of instances. Valid Values:</para>
        /// <list type="bullet">
        /// <item><description>true: triggers the scaling task in a synchronous manner. A scaling activity is triggered at the time when the scaling rule is executed.</description></item>
        /// <item><description>false: does not trigger the scaling task in a synchronous manner. After you change the expected number of instances for the scaling group, Auto Scaling checks whether the total number of instances in the scaling group matches the new expected number and determines whether to trigger the scaling activity based on the check result.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/146231.html">Expected number of instances</a>.</para>
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
