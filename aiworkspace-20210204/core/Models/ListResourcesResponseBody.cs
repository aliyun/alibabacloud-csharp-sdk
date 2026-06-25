// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e195c5116124202371861018d5bde</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListResourcesResponseBodyResources> Resources { get; set; }
        public class ListResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The encryption details. This parameter is valid only for MaxCompute resources.</para>
            /// </summary>
            [NameInMap("Encryption")]
            [Validation(Required=false)]
            public ListResourcesResponseBodyResourcesEncryption Encryption { get; set; }
            public class ListResourcesResponseBodyResourcesEncryption : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AESCTR</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                /// <summary>
                /// <para>Indicates whether encryption is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The encryption key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The environment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>dev</c>: development environment</para>
            /// </description></item>
            /// <item><description><para><c>prod</c>: production environment</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para><b>Deprecated.</b> This parameter is no longer used.</para>
            /// </summary>
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public ListResourcesResponseBodyResourcesExecutor Executor { get; set; }
            public class ListResourcesResponseBodyResourcesExecutor : TeaModel {
                /// <summary>
                /// <para><b>Deprecated.</b> This parameter is no longer used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110973******7793</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

            }

            /// <summary>
            /// <para>The time when the resource was created. The time is displayed in UTC and is formatted in ISO 8601.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The name of the resource group. The name must be unique within an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>groupName</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource is the default resource of its type. Each resource type has only one default resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The resource is the default resource.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The resource is not the default resource.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The list of labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesLabels> Labels { get; set; }
            public class ListResourcesResponseBodyResourcesLabels : TeaModel {
                /// <summary>
                /// <para>The key of the label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system.supported.dsw</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para><b>Deprecated.</b> This parameter is deprecated and will be removed in a future release. Use the <c>ResourceType</c> parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The list of quotas.</para>
            /// </summary>
            [NameInMap("Quotas")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesQuotas> Quotas { get; set; }
            public class ListResourcesResponseBodyResourcesQuotas : TeaModel {
                /// <summary>
                /// <para>The card type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>CPU</c></para>
                /// </description></item>
                /// <item><description><para><c>GPU</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CPU</para>
                /// </summary>
                [NameInMap("CardType")]
                [Validation(Required=false)]
                public string CardType { get; set; }

                /// <summary>
                /// <para>The display name of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>默认后付费Quota</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The quota ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>isolate</c>: subscription</para>
                /// </description></item>
                /// <item><description><para><c>share</c>: pay-as-you-go</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>isolate</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The quota name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QuotaName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The product code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>PAI_isolate</c>: PAI subscription resource group (PAI CPU)</para>
                /// </description></item>
                /// <item><description><para><c>PAI_share</c>: PAI pay-as-you-go resource group (PAI GPU)</para>
                /// </description></item>
                /// <item><description><para><c>MaxCompute_share</c>: MaxCompute pay-as-you-go resource group</para>
                /// </description></item>
                /// <item><description><para><c>MaxCompute_isolate</c>: MaxCompute subscription resource group</para>
                /// </description></item>
                /// <item><description><para><c>DataWorks_isolate</c>: DataWorks subscription resource group</para>
                /// </description></item>
                /// <item><description><para><c>DataWorks_share</c>: DataWorks pay-as-you-go resource group</para>
                /// </description></item>
                /// <item><description><para><c>DLC_share</c>: DLC pay-as-you-go resource group</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute_isolate</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The quota type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>PAI</c></para>
                /// </description></item>
                /// <item><description><para><c>MaxCompute</c></para>
                /// </description></item>
                /// <item><description><para><c>DLC</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("QuotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                /// <summary>
                /// <para>The list of specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;cu\&quot;:\&quot;11500\&quot;,\&quot;minCu\&quot;:\&quot;2300\&quot;,\&quot;parentId\&quot;:\&quot;0\&quot;}</para>
                /// </summary>
                [NameInMap("Specs")]
                [Validation(Required=false)]
                public List<ListResourcesResponseBodyResourcesQuotasSpecs> Specs { get; set; }
                public class ListResourcesResponseBodyResourcesQuotasSpecs : TeaModel {
                    /// <summary>
                    /// <para>The specification name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cu</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The specification value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11500</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>MaxCompute</c>: MaxCompute resources</para>
            /// </description></item>
            /// <item><description><para><c>ECS</c>: ECS resources</para>
            /// </description></item>
            /// <item><description><para><c>Lingjun</c>: Lingjun intelligent computing resources</para>
            /// </description></item>
            /// <item><description><para><c>ACS</c>: ACS computing resources</para>
            /// </description></item>
            /// <item><description><para><c>Flink</c>: Flink resources</para>
            /// </description></item>
            /// <item><description><para><c>SelfManagedAckPro</c>: self-managed cluster resources for AckPro</para>
            /// </description></item>
            /// <item><description><para><c>SelfManagedAckLingjun</c>: self-managed cluster resources for AckLingjun</para>
            /// </description></item>
            /// <item><description><para><c>SelfManagedASI</c>: self-managed cluster resources for ASI (third-party cloud)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>对于MaxCompute {&quot;Endpoint&quot;: &quot;odps.alibaba-inc.com&quot;, &quot;Project&quot;: &quot;mignshi&quot;}</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public Dictionary<string, object> Spec { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that match the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
