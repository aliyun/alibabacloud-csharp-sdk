// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateTemplateScratchRequest : TeaModel {
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
        /// The preference parameters of the resource scenario.
        /// </summary>
        [NameInMap("PreferenceParameters")]
        [Validation(Required=false)]
        public List<UpdateTemplateScratchRequestPreferenceParameters> PreferenceParameters { get; set; }
        public class UpdateTemplateScratchRequestPreferenceParameters : TeaModel {
            /// <summary>
            /// The parameter name.
            /// 
            /// For more information about the valid values of ParameterKey, see the "**Additional information about request parameters**" section of this topic.
            /// 
            /// >- PreferenceParameters is optional. If you specify PreferenceParameters, you must specify both ParameterKey and ParameterValue.
            /// > - If you set TemplateScratchType to ResourceImport, you must set ParameterKey to DeletionPolicy.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The parameter value. The value of ParameterValue varies based on the value of ParameterKey.
            /// 
            /// For more information about the valid values of ParameterKey, see the "**Additional information about request parameters**" section of this topic.
            /// 
            /// >  PreferenceParameters is optional. If you specify PreferenceParameters, you must specify both ParameterKey and ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

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
        public UpdateTemplateScratchRequestSourceResourceGroup SourceResourceGroup { get; set; }
        public class UpdateTemplateScratchRequestSourceResourceGroup : TeaModel {
            /// <summary>
            /// The ID of the source resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The resource types.
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// The source resources.
        /// 
        /// If you specify SourceResources when TemplateScratchType is set to ArchitectureDetection, the system detects the architecture of all resources that are associated with the specified source resources. For example, if you set the value of SourceResources to an ID of a Classic Load Balancer (CLB) instance, the system detects the architecture of resources, such as Elastic Compute Service (ECS) instances, vSwitches, and virtual private clouds (VPCs), that are associated with the CLB instance.
        /// 
        /// If you set TemplateScratchType to ArchitectureDetection, you can specify up to 20 source resources for SourceResources. In other cases, you can specify up to 200 source resources.
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public List<UpdateTemplateScratchRequestSourceResources> SourceResources { get; set; }
        public class UpdateTemplateScratchRequestSourceResources : TeaModel {
            /// <summary>
            /// The resource ID.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The source tag.
        /// </summary>
        [NameInMap("SourceTag")]
        [Validation(Required=false)]
        public UpdateTemplateScratchRequestSourceTag SourceTag { get; set; }
        public class UpdateTemplateScratchRequestSourceTag : TeaModel {
            /// <summary>
            /// The source tags that consist of key-value pairs.
            /// 
            /// If you want to specify only the tag key, you must set the tag value to an empty string. Example: {"TagKey": ""}.
            /// 
            /// If you set TemplateScratchType to ArchitectureDetection, you can add up to five source tags. In other cases, you can add up to 10 source tags.
            /// </summary>
            [NameInMap("ResourceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceTags { get; set; }

            /// <summary>
            /// The resource types for filtering resources.
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// The ID of the scenario.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
