// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateTemplateScratchRequest : TeaModel {
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
        /// *   LongTypePrefixAndIndexSuffix (default): long-type prefix + index-type suffix
        /// *   LongTypePrefixAndHashSuffix: long-type prefix + hash-type suffix
        /// *   ShortTypePrefixAndHashSuffix: short-type prefix + hash-type suffix
        /// </summary>
        [NameInMap("LogicalIdStrategy")]
        [Validation(Required=false)]
        public string LogicalIdStrategy { get; set; }

        /// <summary>
        /// The preference parameters of the scenario.
        /// </summary>
        [NameInMap("PreferenceParameters")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestPreferenceParameters> PreferenceParameters { get; set; }
        public class CreateTemplateScratchRequestPreferenceParameters : TeaModel {
            /// <summary>
            /// The key of the parameter.
            /// 
            /// For information about the valid values of ParameterKey, see the **Additional information about request parameters** section of this topic.
            /// > - PreferenceParameters is optional. If you want to specify PreferenceParameters, you must specify ParameterKey and ParameterValue.
            /// > -  If you set TemplateScratchType to ResourceImport, you must set ParameterKey to DeletionPolicy.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of the parameter. The value of ParameterValue varies based on the value of ParameterKey.
            /// 
            /// For information about the valid values of ParameterValue, see the **Additional information about request parameters** section of this topic.
            /// 
            /// > PreferenceParameters is optional. If you want to specify PreferenceParameters, you must specify ParameterKey and ParameterValue.
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

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The source resource group.
        /// </summary>
        [NameInMap("SourceResourceGroup")]
        [Validation(Required=false)]
        public CreateTemplateScratchRequestSourceResourceGroup SourceResourceGroup { get; set; }
        public class CreateTemplateScratchRequestSourceResourceGroup : TeaModel {
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
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestSourceResources> SourceResources { get; set; }
        public class CreateTemplateScratchRequestSourceResources : TeaModel {
            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource.
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
        public CreateTemplateScratchRequestSourceTag SourceTag { get; set; }
        public class CreateTemplateScratchRequestSourceTag : TeaModel {
            /// <summary>
            /// The source tags that consist of key-value pairs. If you want to specify only the tag key, you must leave the tag value empty. Example: `{"TagKey": ""}`.
            /// 
            /// You can add up to 10 source tags.
            /// </summary>
            [NameInMap("ResourceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceTags { get; set; }

            /// <summary>
            /// The resource types.
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// The tags of the scenario.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestTags> Tags { get; set; }
        public class CreateTemplateScratchRequestTags : TeaModel {
            /// <summary>
            /// The tag key of the scenario.
            /// 
            /// > Tags is optional. If you want to specify Tags, you must specify Key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the scenario.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the scenario. Valid values:
        /// 
        /// *   ResourceImport: resource management
        /// *   ArchitectureReplication: resource replication
        /// *   ResourceMigration: resource migration
        /// </summary>
        [NameInMap("TemplateScratchType")]
        [Validation(Required=false)]
        public string TemplateScratchType { get; set; }

    }

}
