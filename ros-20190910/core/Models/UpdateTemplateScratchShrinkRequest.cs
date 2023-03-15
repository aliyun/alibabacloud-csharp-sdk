// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateTemplateScratchShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among the different requests. The token can be up to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
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
        /// The execution mode. Default value: Async. Valid values:
        /// 
        /// *   Async: asynchronous mode
        /// *   Sync: synchronous mode
        /// 
        /// >  If you have a wide scope of resources, Sync takes longer. If you set ExecutionMode to Sync, we recommend that you set ClientToken to prevent the execution from timing out.
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// The generation policy of the logical ID. Default value: LongTypePrefixAndIndexSuffix. Valid values:
        /// 
        /// *   LongTypePrefixAndIndexSuffix: long-type prefix + index-type suffix
        /// *   LongTypePrefixAndHashSuffix: long-type prefix + hash-type suffix
        /// *   ShortTypePrefixAndHashSuffix: short-type prefix + hash-type suffix
        /// </summary>
        [NameInMap("LogicalIdStrategy")]
        [Validation(Required=false)]
        public string LogicalIdStrategy { get; set; }

        /// <summary>
        /// The parameters that are configured in the scenario.
        /// </summary>
        [NameInMap("PreferenceParameters")]
        [Validation(Required=false)]
        public string PreferenceParametersShrink { get; set; }

        /// <summary>
        /// The ID of the region in which the scenario is created.
        /// 
        /// You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The source resource group.
        /// </summary>
        [NameInMap("SourceResourceGroup")]
        [Validation(Required=false)]
        public string SourceResourceGroupShrink { get; set; }

        /// <summary>
        /// The source resource.
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
