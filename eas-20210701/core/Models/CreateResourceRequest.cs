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
        /// <item><description>false (default)</description></item>
        /// <item><description>true</description></item>
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
        /// <item><description>PrePaid: the subscription billing method.</description></item>
        /// <item><description>PostPaid: the pay-as-you-go billing method.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required when the ResourceType parameter is set to Dedicated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The number of ECS instances.</para>
        /// <remarks>
        /// <para> This parameter is required when the ResourceType parameter is set to Dedicated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EcsInstanceCount")]
        [Validation(Required=false)]
        public int? EcsInstanceCount { get; set; }

        /// <summary>
        /// <para>The type of the Elastic Compute Service (ECS) instance.</para>
        /// <remarks>
        /// <para> This parameter is required when the ResourceType parameter is set to Dedicated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.8xlarge</para>
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MyResource</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dedicated: the dedicated resource group.</description></item>
        /// <item><description>SelfManaged: the self-managed resource group.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you use a self-managed resource group, you must configure a whitelist.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Dedicated</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The configurations of the self-managed resource group.</para>
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
            /// <para>The tag key-value pairs of the node.</para>
            /// </summary>
            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            /// <summary>
            /// <para>The tolerations for the node taint.</para>
            /// </summary>
            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<CreateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class CreateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                /// <summary>
                /// <para>The effect.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PreferNoSchedule</description></item>
                /// <item><description>NoSchedule</description></item>
                /// <item><description>NoExecute</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSchedule</para>
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The key name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The relationship between key names and key values.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Equal</description></item>
                /// <item><description>Exists</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Equal</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The key value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the RAM user to which the permissions on Elastic Algorithm Service (EAS) of Platform for AI (PAI) are granted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clusterrole</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>The size of the system disk. Unit: GiB. Valid values: 200 to 2000. Default value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
