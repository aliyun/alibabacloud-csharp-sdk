// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateTemplateScratchRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// For more information, see [Ensure idempotence](~~134212~~).
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
        /// >  If a wide scope of resources exist, the synchronous mode takes a longer period of time than the asynchronous mode. If you set the ExecutionMode parameter to Sync, we recommend that you configure the ClientToken parameter to prevent a timeout error.
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// The policy based on which the logical ID is generated. Default value: LongTypePrefixAndIndexSuffix. Valid values:
        /// 
        /// *   LongTypePrefixAndIndexSuffix: long-type prefix + index-type suffix
        /// *   LongTypePrefixAndHashSuffix: long-type prefix + hash-type suffix
        /// *   ShortTypePrefixAndHashSuffix: short-type prefix + hash-type suffix
        /// </summary>
        [NameInMap("LogicalIdStrategy")]
        [Validation(Required=false)]
        public string LogicalIdStrategy { get; set; }

        /// <summary>
        /// The parameters that you want to configure for the scenario.
        /// </summary>
        [NameInMap("PreferenceParameters")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestPreferenceParameters> PreferenceParameters { get; set; }
        public class CreateTemplateScratchRequestPreferenceParameters : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// 
            /// For more information about the valid values of the ParameterKey parameter, see the "**Additional information about request parameters**" section of this topic.
            /// 
            /// > 
            /// *   The PreferenceParameters parameter is optional. If you want to specify the PreferenceParameters parameter, you must specify both the ParameterKey and ParameterValue parameters.
            /// *   If you set the TemplateScratchType parameter to ResourceImport, you must set the ParameterKey parameter to DeletionPolicy.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of the parameter. The value of the ParameterValue parameter varies based on the value of the ParameterKey parameter.
            /// 
            /// For more information about the valid values of the ParameterValue parameter, see the "**Additional information about request parameters**" section of this topic.
            /// 
            /// >  The PreferenceParameters parameter is optional. If you want to specify the PreferenceParameters parameter, you must specify both the ParameterKey and ParameterValue parameters.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The ID of the region in which you want to create the scenario.
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
        public CreateTemplateScratchRequestSourceResourceGroup SourceResourceGroup { get; set; }
        public class CreateTemplateScratchRequestSourceResourceGroup : TeaModel {
            /// <summary>
            /// The ID of the source resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The filter for resource types. If you specify this parameter, only the resources of the specified types and in the specified resource groups are scanned. If you do not specify this parameter, all resources in the specified resource groups are scanned.
            /// 
            /// You can specify up to 20 resource types.
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
        public CreateTemplateScratchRequestSourceTag SourceTag { get; set; }
        public class CreateTemplateScratchRequestSourceTag : TeaModel {
            /// <summary>
            /// The source tags that consist of key-value pairs.
            /// 
            /// If you want to specify only the tag key, you must leave the tag value empty. Example: `{"TagKey": ""}`.
            /// 
            /// You can add up to 10 source tags.
            /// </summary>
            [NameInMap("ResourceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceTags { get; set; }

            /// <summary>
            /// The filter for resource types. If you specify this parameter, only the resources of the specified types and have the specified tags are scanned. If you do not specify this parameter, all resources that have the specified tags are scanned.
            /// 
            /// You can specify up to 20 resource types.
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestTags> Tags { get; set; }
        public class CreateTemplateScratchRequestTags : TeaModel {
            /// <summary>
            /// The key of tag N that you want to add to the scenario.
            /// 
            /// >  The Tags parameter is optional. If you specify the Tags parameter, you must specify the Tags.N.Key parameter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that you want to add to the scenario.
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
