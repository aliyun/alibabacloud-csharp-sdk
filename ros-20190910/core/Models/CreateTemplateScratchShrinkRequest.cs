// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateTemplateScratchShrinkRequest : TeaModel {
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
        public string PreferenceParametersShrink { get; set; }

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
        public string SourceResourceGroupShrink { get; set; }

        /// <summary>
        /// <para>The source resources.</para>
        /// <para>When you set TemplateScratchType to ArchitectureDetection, you can specify SourceResources to detect the architecture data of all resources associated with the specified source resources. For example, if you set SourceResources to the ID of a Classic Load Balancer (CLB) instance, the architecture data of all resources, such as the Elastic Compute Service (ECS) instance, vSwitch, and VPC, associated with the CLB instance is detected.</para>
        /// <para>If you set TemplateScratchType to ArchitectureDetection, you can specify up to 20 source resources. In other cases, you can specify up to 200 source resources.</para>
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public string SourceResourcesShrink { get; set; }

        /// <summary>
        /// <para>The source tag.</para>
        /// </summary>
        [NameInMap("SourceTag")]
        [Validation(Required=false)]
        public string SourceTagShrink { get; set; }

        /// <summary>
        /// <para>The tags of the resource scenario.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchShrinkRequestTags> Tags { get; set; }
        public class CreateTemplateScratchShrinkRequestTags : TeaModel {
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
