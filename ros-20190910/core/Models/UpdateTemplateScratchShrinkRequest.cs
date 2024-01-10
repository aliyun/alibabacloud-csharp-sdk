// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateTemplateScratchShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// For more information, see [How to ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the scenario.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The execution mode. Valid values:
        /// 
        /// *   Async (default)
        /// *   Sync
        /// 
        /// > If you have a wide scope of resources, Sync takes longer. If you set ExecutionMode to Sync, we recommend that you specify ClientToken to prevent the execution timeout.
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// The policy based on which the logical ID is generated. Valid values:
        /// 
        /// *   LongTypePrefixAndIndexSuffix: long-type prefix + index-type suffix
        /// *   LongTypePrefixAndHashSuffix: long-type prefix + hash-type suffix
        /// *   ShortTypePrefixAndHashSuffix: short-type prefix + hash-type suffix
        /// 
        /// >  If you set TemplateScratchType to ArchitectureDetection, the default value of LogicalIdStrategy is LongTypePrefixAndHashSuffix. In other cases, the default value of LogicalIdStrategy is LongTypePrefixAndIndexSuffix.
        /// </summary>
        [NameInMap("LogicalIdStrategy")]
        [Validation(Required=false)]
        public string LogicalIdStrategy { get; set; }

        /// <summary>
        /// The parameters that you want to configure for the scenario.
        /// </summary>
        [NameInMap("PreferenceParameters")]
        [Validation(Required=false)]
        public string PreferenceParametersShrink { get; set; }

        /// <summary>
        /// The region ID of the scenario.
        /// 
        /// You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The source resource group.
        /// </summary>
        [NameInMap("SourceResourceGroup")]
        [Validation(Required=false)]
        public string SourceResourceGroupShrink { get; set; }

        /// <summary>
        /// The source resources.
        /// 
        /// If you specify source resources as the value of SourceResources when TemplateScratchType is set to ArchitectureDetection, the system detects the schema data of all resources that are associated with the specified source resources. For example, if you specify the ID of a Classic Load Balancer (CLB) instance as the value of SourceResources, the system detects the schema data of resources, such as Elastic Compute Service (ECS) instances, vSwitches, and VPCs, that are associated with the CLB instance.
        /// 
        /// If you set TemplateScratchType to ArchitectureDetection, you can specify up to 20 source resources for SourceResources. In other cases, you can specify up to 200 source resources.
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public string SourceResourcesShrink { get; set; }

        /// <summary>
        /// The source tag.
        /// </summary>
        [NameInMap("SourceTag")]
        [Validation(Required=false)]
        public string SourceTagShrink { get; set; }

        /// <summary>
        /// The ID of the scenario.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
