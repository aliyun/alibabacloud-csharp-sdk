// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>false</c> (default): Auto-renewal is disabled.</para>
        /// </description></item>
        /// <item><description><para><c>true</c>: Auto-renewal is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PrePaid</c>: subscription.</para>
        /// </description></item>
        /// <item><description><para><c>PostPaid</c>: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <c>ResourceType</c> is set to <c>Dedicated</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The number of instances.</para>
        /// <remarks>
        /// <para>This parameter is required when <c>ResourceType</c> is set to <c>Dedicated</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EcsInstanceCount")]
        [Validation(Required=false)]
        public int? EcsInstanceCount { get; set; }

        /// <summary>
        /// <para>The ECS instance type.</para>
        /// <remarks>
        /// <para>This parameter is required when <c>ResourceType</c> is set to <c>Dedicated</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.8xlarge</para>
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        /// <summary>
        /// <para>The user-defined labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyResource</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Dedicated</c>: a dedicated resource group.</para>
        /// </description></item>
        /// <item><description><para><c>SelfManaged</c>: a self-managed resource group.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must be whitelisted to use self-managed resource groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Dedicated</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The configuration options for the self-managed resource group.</para>
        /// </summary>
        [NameInMap("SelfManagedResourceOptions")]
        [Validation(Required=false)]
        public CreateResourceRequestSelfManagedResourceOptions SelfManagedResourceOptions { get; set; }
        public class CreateResourceRequestSelfManagedResourceOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the self-managed cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cf0386f250f2545689ca7fdd1cd******</para>
            /// </summary>
            [NameInMap("ExternalClusterId")]
            [Validation(Required=false)]
            public string ExternalClusterId { get; set; }

            /// <summary>
            /// <para>The node labels to match, specified as key-value pairs.</para>
            /// </summary>
            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            /// <summary>
            /// <para>A list of tolerations for node taints.</para>
            /// </summary>
            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<CreateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class CreateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                /// <summary>
                /// <para>The effect of the toleration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoSchedule</para>
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The key of the toleration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The toleration operator, which defines the relationship between the key and value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Equal</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The toleration value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the RAM role that grants PAI-EAS the required permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clusterrole</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>The size of the system disk, in GiB. The value must be between 200 and 2,000. If unspecified, the default is 200 GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("UsageMode")]
        [Validation(Required=false)]
        public string UsageMode { get; set; }

        /// <summary>
        /// <para>The zone in which to create the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
