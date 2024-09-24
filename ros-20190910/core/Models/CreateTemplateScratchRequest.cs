// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateTemplateScratchRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the resource scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Replicate a VPC.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Async (default)</description></item>
        /// <item><description>Sync</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you have a wide scope of resources, Sync takes longer. If you set ExecutionMode to Sync, we recommend that you specify ClientToken to prevent the execution timeout.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

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
        public List<CreateTemplateScratchRequestPreferenceParameters> PreferenceParameters { get; set; }
        public class CreateTemplateScratchRequestPreferenceParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// <para>For more information about the valid values of ParameterKey, see the &quot;<b>Additional information about request parameters</b>&quot; section of this topic.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>PreferenceParameters is optional. If you specify PreferenceParameters, you must specify ParameterKey and ParameterValue.</para>
            /// </description></item>
            /// <item><description><para>You must set ParameterKey to DeletionPolicy when TemplateScratchType is set to ResourceImport.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DeletionPolicy</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The parameter value. The value is an assignment to the parameter key.</para>
            /// <para>For more information about the valid values of ParameterValue, see the &quot;<b>Additional information about request parameters</b>&quot; section of this topic.</para>
            /// <remarks>
            /// <para> PreferenceParameters is optional. If you specify PreferenceParameters, you must specify ParameterKey and ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Retain</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the resource scenario.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The source resource group.</para>
        /// </summary>
        [NameInMap("SourceResourceGroup")]
        [Validation(Required=false)]
        public CreateTemplateScratchRequestSourceResourceGroup SourceResourceGroup { get; set; }
        public class CreateTemplateScratchRequestSourceResourceGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the source resource group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzawhxxc****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource types for filtering resources.</para>
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// <para>The source resources.</para>
        /// <para>When you set TemplateScratchType to ArchitectureDetection, you can specify SourceResources to detect the architecture data of all resources associated with the specified source resources. For example, if you set SourceResources to the ID of a Classic Load Balancer (CLB) instance, the architecture data of all resources, such as the Elastic Compute Service (ECS) instance, vSwitch, and VPC, associated with the CLB instance is detected.</para>
        /// <para>If you set TemplateScratchType to ArchitectureDetection, you can specify up to 20 source resources. In other cases, you can specify up to 200 source resources.</para>
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestSourceResources> SourceResources { get; set; }
        public class CreateTemplateScratchRequestSourceResources : TeaModel {
            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when TemplateScratchType is set to ArchitectureDetection.</para>
            /// </description></item>
            /// <item><description><para>The region ID of a global resource is <c>global</c>. For example, the region ID of the ALIYUN::CDN::Domain global resource is <c>global</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The related resource type filters.</para>
            /// </summary>
            [NameInMap("RelatedResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> RelatedResourceTypeFilter { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1m6fww66xbntjyc****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>This parameter is required.</para>
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
        public CreateTemplateScratchRequestSourceTag SourceTag { get; set; }
        public class CreateTemplateScratchRequestSourceTag : TeaModel {
            /// <summary>
            /// <para>The source tags that consist of key-value pairs. If you want to specify only the tag key, you must leave the tag value empty. Example: <c>{&quot;TagKey&quot;: &quot;&quot;}</c>.</para>
            /// <para>You can add up to 10 source tags.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;a&quot;: &quot;b&quot;}</para>
            /// </summary>
            [NameInMap("ResourceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceTags { get; set; }

            /// <summary>
            /// <para>The resource types for filtering resources.</para>
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// <para>The tags of the resource scenario.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestTags> Tags { get; set; }
        public class CreateTemplateScratchRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource scenario.</para>
            /// <remarks>
            /// <para>Tags is optional. If you want to specify Tags, you must specify Key.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the resource scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ArchitectureReplication: resource replication</description></item>
        /// <item><description>ArchitectureDetection: resource detection</description></item>
        /// <item><description>ResourceImport: resource management</description></item>
        /// <item><description>ResourceMigration: resource migration</description></item>
        /// </list>
        /// <remarks>
        /// <para> The valid values of the ParameterKey and ParameterValue request parameters vary based on the value of TemplateScratchType. For more information, see the &quot;<b>Additional information about request parameters</b>&quot; section of this topic.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ArchitectureReplication</para>
        /// </summary>
        [NameInMap("TemplateScratchType")]
        [Validation(Required=false)]
        public string TemplateScratchType { get; set; }

    }

}
