// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateScratchResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
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
            /// <para>The time when the resource scenario was created. The time is displayed in UTC+0 and follows the ISO 8601 standard without the trailing Z. Format: YYYY-MM-DDThh:mm:ss.</para>
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
            /// <para>复制VPC资源。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The status code that indicates why the resource scenario failed to be generated.</para>
            /// <remarks>
            /// <para>This parameter is returned only when Status is set to GENERATE_FAILED.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidZoneId</para>
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            /// <summary>
            /// <para>The logical ID generation strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LongTypePrefixAndIndexSuffix (default): long type prefix with index suffix.</para>
            /// </description></item>
            /// <item><description><para>LongTypePrefixAndHashSuffix: long type prefix with hash suffix.</para>
            /// </description></item>
            /// <item><description><para>ShortTypePrefixAndHashSuffix: short type prefix with hash suffix.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LongTypePrefixAndIndexSuffix</para>
            /// </summary>
            [NameInMap("LogicalIdStrategy")]
            [Validation(Required=false)]
            public string LogicalIdStrategy { get; set; }

            /// <summary>
            /// <para>The configuration parameters of the resource scenario.</para>
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
            /// <para>The resource group ID.</para>
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
                /// <para>The resource type filter.</para>
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
                /// <para>The filter for related resource types.</para>
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
                /// <para>The source tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;: &quot;b&quot;}</para>
                /// </summary>
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

                /// <summary>
                /// <para>The resource type filter.</para>
                /// </summary>
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }

            /// <summary>
            /// <para>The stack provisioning information.</para>
            /// </summary>
            [NameInMap("StackProvision")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchStackProvision StackProvision { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchStackProvision : TeaModel {
                /// <summary>
                /// <para>Indicates whether you can call <a href="https://help.aliyun.com/document_detail/132086.html">CreateStack</a> to create a stack for resource replication. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Supported.</para>
                /// </description></item>
                /// <item><description><para>false: Not supported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Creatable")]
                [Validation(Required=false)]
                public bool? Creatable { get; set; }

                /// <summary>
                /// <para>Indicates whether you can call <a href="https://help.aliyun.com/document_detail/131051.html">CreateChangeSet</a> to create a change set for resource management. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Supported.</para>
                /// </description></item>
                /// <item><description><para>false: Not supported.</para>
                /// </description></item>
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
            /// <para>The list of stacks associated with the resource scenario.</para>
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
                /// <item><description><para>ResourceImport: resource management.</para>
                /// </description></item>
                /// <item><description><para>ArchitectureReplication: resource replication.</para>
                /// </description></item>
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
            /// <para>The status of the resource scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>GENERATE_IN_PROGRESS: being generated.</para>
            /// </description></item>
            /// <item><description><para>GENERATE_COMPLETE: generated.</para>
            /// </description></item>
            /// <item><description><para>GENERATE_FAILED: failed to be generated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GENERATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the resource scenario failed to be generated.</para>
            /// <remarks>
            /// <para>This parameter is returned only when Status is set to GENERATE_FAILED.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>参见返回示例</para>
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
            /// <item><description><para>ResourceImport: resource management.</para>
            /// </description></item>
            /// <item><description><para>ArchitectureReplication: resource replication.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ArchitectureReplication</para>
            /// </summary>
            [NameInMap("TemplateScratchType")]
            [Validation(Required=false)]
            public string TemplateScratchType { get; set; }

            /// <summary>
            /// <para>The time when the resource scenario was last updated. The time is displayed in UTC+0 and follows the ISO 8601 standard without the trailing Z. Format: YYYY-MM-DDThh:mm:ss.</para>
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
