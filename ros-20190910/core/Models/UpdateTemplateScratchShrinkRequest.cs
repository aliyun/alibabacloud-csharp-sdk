// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateTemplateScratchShrinkRequest : TeaModel {
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
        /// <para>The description of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the scenario.</para>
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
        /// <item><description>LongTypePrefixAndIndexSuffix: long-type prefix + index-type suffix</description></item>
        /// <item><description>LongTypePrefixAndHashSuffix: long-type prefix + hash-type suffix</description></item>
        /// <item><description>ShortTypePrefixAndHashSuffix: short-type prefix + hash-type suffix</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set TemplateScratchType to ArchitectureDetection, the default value of LogicalIdStrategy is LongTypePrefixAndHashSuffix. In other cases, the default value of LogicalIdStrategy is LongTypePrefixAndIndexSuffix.</para>
        /// </remarks>
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
        /// <para>The region ID of the scenario.</para>
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
        /// <remarks>
        /// <para> You must specify only one of the following parameters: SourceResources, SourceTag, and SourceResourceGroup.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SourceResourceGroup")]
        [Validation(Required=false)]
        public string SourceResourceGroupShrink { get; set; }

        /// <summary>
        /// <para>The source resources.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: SourceResources, SourceTag, and SourceResourceGroup.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public string SourceResourcesShrink { get; set; }

        /// <summary>
        /// <para>The source tag.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: SourceResources, SourceTag, and SourceResourceGroup.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SourceTag")]
        [Validation(Required=false)]
        public string SourceTagShrink { get; set; }

        /// <summary>
        /// <para>The ID of the resource scenario.</para>
        /// <para>The valid values of the ParameterKey and ParameterValue request parameters vary based on the IDs of different types of resource scenarios. For more information, see the &quot;Additional information about request parameters&quot; section of this topic.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/610832.html">ListTemplateScratches</a> operation to query the ID of a resource scenario.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ts-7f7a704cf71c49a6****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
