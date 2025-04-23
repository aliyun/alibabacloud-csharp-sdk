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
        /// <para>The resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListResourcesResponseBodyResources> Resources { get; set; }
        public class ListResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The encryption information, which is valid only for MaxCompute resources.</para>
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
                /// <para>Indicates whether the resources are encrypted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The primary key for the encryption.</para>
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
            /// <item><description>dev: development environment</description></item>
            /// <item><description>prod: production environment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>This parameter is invalid and deprecated.</para>
            /// </summary>
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public ListResourcesResponseBodyResourcesExecutor Executor { get; set; }
            public class ListResourcesResponseBodyResourcesExecutor : TeaModel {
                /// <summary>
                /// <para>This parameter is invalid and deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110973******7793</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

            }

            /// <summary>
            /// <para>The time when the resource group is created, in UTC. The time follows the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The name of the resource group, which is unique within the Alibaba Cloud account.</para>
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
            /// <para>Indicates whether the resource is the default resource. Each type of resources has a default resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesLabels> Labels { get; set; }
            public class ListResourcesResponseBodyResourcesLabels : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system.supported.dsw</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
            /// <para>**This field is no longer used and will be removed. Use the ResourceType field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The quotas.</para>
            /// </summary>
            [NameInMap("Quotas")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesQuotas> Quotas { get; set; }
            public class ListResourcesResponseBodyResourcesQuotas : TeaModel {
                /// <summary>
                /// <para>The resource group type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CPU</description></item>
                /// <item><description>GPU</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cpu</para>
                /// </summary>
                [NameInMap("CardType")]
                [Validation(Required=false)]
                public string CardType { get; set; }

                /// <summary>
                /// <para>The alias of the quota.</para>
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
                /// <item><description>isolate: subscription</description></item>
                /// <item><description>share: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>develop</para>
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
                /// <item><description>PAI_isolate: CPU subscription resource groups of PAI</description></item>
                /// <item><description>PAI_share: GPU pay-as-you-go resource groups of PAI</description></item>
                /// <item><description>MaxCompute_share: pay-as-you-go resource groups of MaxCompute</description></item>
                /// <item><description>MaxCompute_isolate: subscription resource groups of MaxCompute</description></item>
                /// <item><description>DataWorks_isolate: subscription resource groups of DataWorks</description></item>
                /// <item><description>DataWorks_share: pay-as-you-go resource groups of DataWorks</description></item>
                /// <item><description>DLC_share: pay-as-you-go resource groups of Deep Learning Containers (DLC)</description></item>
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
                /// <item><description>PAI</description></item>
                /// <item><description>MaxCompute</description></item>
                /// <item><description>DLC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("QuotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                /// <summary>
                /// <para>The quota specifications.</para>
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
                    /// <para>The specification description.</para>
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
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MaxCompute</description></item>
            /// <item><description>DLC</description></item>
            /// <item><description>FLINK</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>对于MaxCompute {&quot;Endpoint&quot;: &quot;odps.alibaba-inc.com&quot;, &quot;Project&quot;: &quot;mignshi&quot;}</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public Dictionary<string, object> Spec { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The number of resources that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
