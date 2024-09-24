// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateScratchResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E0EF98-6FBD-5656-8298-FC8194F0F7B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource scenario.</para>
        /// </summary>
        [NameInMap("TemplateScratch")]
        [Validation(Required=false)]
        public GetTemplateScratchResponseBodyTemplateScratch TemplateScratch { get; set; }
        public class GetTemplateScratchResponseBodyTemplateScratch : TeaModel {
            /// <summary>
            /// <para>The time at which the resource scenario was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22T01:49:22</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the resource scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the resource scenario.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The status code of the resource scenario that fails to be created.</para>
            /// <remarks>
            /// <para>This parameter is returned only if you set Status to GENERATE_FAILED.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidZoneId</para>
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            /// <summary>
            /// <para>The policy based on which the logical ID is generated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LongTypePrefixAndIndexSuffix (default): long-type prefix + index-type suffix</description></item>
            /// <item><description>LongTypePrefixAndHashSuffix: long-type prefix + hash-type suffix</description></item>
            /// <item><description>ShortTypePrefixAndHashSuffix: short-type prefix + hash-type suffix</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LongTypePrefixAndIndexSuffix</para>
            /// </summary>
            [NameInMap("LogicalIdStrategy")]
            [Validation(Required=false)]
            public string LogicalIdStrategy { get; set; }

            /// <summary>
            /// <para>The preference parameters of the resource scenario.</para>
            /// </summary>
            [NameInMap("PreferenceParameters")]
            [Validation(Required=false)]
            public List<GetTemplateScratchResponseBodyTemplateScratchPreferenceParameters> PreferenceParameters { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchPreferenceParameters : TeaModel {
                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DeletionPolicy</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Retain</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzmhzoaad5oq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The source resource group.</para>
            /// </summary>
            [NameInMap("SourceResourceGroup")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchSourceResourceGroup SourceResourceGroup { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceResourceGroup : TeaModel {
                /// <summary>
                /// <para>The ID of the source resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzawhxxc****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The resource type filters.</para>
                /// </summary>
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }

            /// <summary>
            /// <para>The source resources.</para>
            /// </summary>
            [NameInMap("SourceResources")]
            [Validation(Required=false)]
            public List<GetTemplateScratchResponseBodyTemplateScratchSourceResources> SourceResources { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceResources : TeaModel {
                /// <summary>
                /// <para>The related resource type filters.</para>
                /// </summary>
                [NameInMap("RelatedResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> RelatedResourceTypeFilter { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5e7cv7e9mz69sszb****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::VPC</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The source tag.</para>
            /// </summary>
            [NameInMap("SourceTag")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchSourceTag SourceTag { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceTag : TeaModel {
                /// <summary>
                /// <para>The source tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;: &quot;b&quot;}</para>
                /// </summary>
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

                /// <summary>
                /// <para>The resource type filters.</para>
                /// </summary>
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }

            /// <summary>
            /// <para>The preset information of the stack.</para>
            /// </summary>
            [NameInMap("StackProvision")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchStackProvision StackProvision { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchStackProvision : TeaModel {
                /// <summary>
                /// <para>Indicates whether the resource is replicated by calling the <a href="https://help.aliyun.com/document_detail/132086.html">CreateStack</a> operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Creatable")]
                [Validation(Required=false)]
                public bool? Creatable { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource is managed by calling the <a href="https://help.aliyun.com/document_detail/131051.html">CreateChangeSet</a> operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Importable")]
                [Validation(Required=false)]
                public bool? Importable { get; set; }

            }

            /// <summary>
            /// <para>The stacks that are associated with the resource scenario.</para>
            /// </summary>
            [NameInMap("Stacks")]
            [Validation(Required=false)]
            public List<GetTemplateScratchResponseBodyTemplateScratchStacks> Stacks { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchStacks : TeaModel {
                /// <summary>
                /// <para>The region ID of the stack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The stack ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3708bf6a-3a67-44d4-9eb1-c56704b9****</para>
                /// </summary>
                [NameInMap("StackId")]
                [Validation(Required=false)]
                public string StackId { get; set; }

                /// <summary>
                /// <para>The purpose of the stack. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ResourceImport: resource management</description></item>
                /// <item><description>ArchitectureReplication: resource replication</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ArchitectureReplication</para>
                /// </summary>
                [NameInMap("UsageType")]
                [Validation(Required=false)]
                public string UsageType { get; set; }

            }

            /// <summary>
            /// <para>The state of the resource scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GENERATE_IN_PROGRESS: The resource scenario is being created.</description></item>
            /// <item><description>GENERATE_COMPLETE: The resource scenario is created.</description></item>
            /// <item><description>GENERATE_FAILED: The resource scenario fails to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GENERATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the resource scenario fails to be created.</para>
            /// <remarks>
            /// <para>This parameter is returned only if you set Status to GENERATE_FAILED.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Resource ALIYUN::ECS::VPC vpc-m5eauuq80anx59v28**** could not be found for template scratch.</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The resource scenario data.</para>
            /// </summary>
            [NameInMap("TemplateScratchData")]
            [Validation(Required=false)]
            public Dictionary<string, object> TemplateScratchData { get; set; }

            /// <summary>
            /// <para>The ID of the resource scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ts-7f7a704cf71c49a6****</para>
            /// </summary>
            [NameInMap("TemplateScratchId")]
            [Validation(Required=false)]
            public string TemplateScratchId { get; set; }

            /// <summary>
            /// <para>The type of the resource scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ResourceImport: resource management</description></item>
            /// <item><description>ArchitectureReplication: resource replication</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ArchitectureReplication</para>
            /// </summary>
            [NameInMap("TemplateScratchType")]
            [Validation(Required=false)]
            public string TemplateScratchType { get; set; }

            /// <summary>
            /// <para>The time at which the resource scenario was updated.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22T01:49:23</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
