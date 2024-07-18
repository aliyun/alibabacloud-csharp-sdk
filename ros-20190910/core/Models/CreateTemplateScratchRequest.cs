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
        /// For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/134212.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the resource scenario.
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
        /// The preference parameters of the resource scenario.
        /// </summary>
        [NameInMap("PreferenceParameters")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestPreferenceParameters> PreferenceParameters { get; set; }
        public class CreateTemplateScratchRequestPreferenceParameters : TeaModel {
            /// <summary>
            /// The parameter name.
            /// 
            /// For more information about the valid values of ParameterKey, see the "**Additional information about request parameters**" section of this topic.
            /// 
            /// > 
            /// 
            /// *   PreferenceParameters is optional. If you specify PreferenceParameters, you must specify ParameterKey and ParameterValue.
            /// 
            /// *   You must set ParameterKey to DeletionPolicy when TemplateScratchType is set to ResourceImport.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The parameter value. The value is an assignment to the parameter key.
            /// 
            /// For more information about the valid values of ParameterValue, see the "**Additional information about request parameters**" section of this topic.
            /// 
            /// >  PreferenceParameters is optional. If you specify PreferenceParameters, you must specify ParameterKey and ParameterValue.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The region ID of the resource scenario.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        public CreateTemplateScratchRequestSourceResourceGroup SourceResourceGroup { get; set; }
        public class CreateTemplateScratchRequestSourceResourceGroup : TeaModel {
            /// <summary>
            /// The ID of the source resource group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The resource types for filtering resources.
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// The source resources.
        /// 
        /// When you set TemplateScratchType to ArchitectureDetection, you can specify SourceResources to detect the architecture data of all resources associated with the specified source resources. For example, if you set SourceResources to the ID of a Classic Load Balancer (CLB) instance, the architecture data of all resources, such as the Elastic Compute Service (ECS) instance, vSwitch, and VPC, associated with the CLB instance is detected.
        /// 
        /// If you set TemplateScratchType to ArchitectureDetection, you can specify up to 20 source resources. In other cases, you can specify up to 200 source resources.
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestSourceResources> SourceResources { get; set; }
        public class CreateTemplateScratchRequestSourceResources : TeaModel {
            /// <summary>
            /// The region ID of the resource.
            /// 
            /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
            /// 
            /// > 
            /// 
            /// *   This parameter takes effect only when TemplateScratchType is set to ArchitectureDetection.
            /// 
            /// *   The region ID of a global resource is `global`. For example, the region ID of the ALIYUN::CDN::Domain global resource is `global`.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The related resource type filters.
            /// </summary>
            [NameInMap("RelatedResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> RelatedResourceTypeFilter { get; set; }

            /// <summary>
            /// The resource ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The resource type.
            /// 
            /// This parameter is required.
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
            /// 
            /// This parameter is required.
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
        /// The tags of the resource scenario.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestTags> Tags { get; set; }
        public class CreateTemplateScratchRequestTags : TeaModel {
            /// <summary>
            /// The tag key of the resource scenario.
            /// 
            /// > Tags is optional. If you want to specify Tags, you must specify Key.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the resource scenario.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the resource scenario. Valid values:
        /// 
        /// *   ArchitectureReplication: resource replication
        /// *   ArchitectureDetection: resource detection
        /// *   ResourceImport: resource management
        /// *   ResourceMigration: resource migration
        /// 
        /// >  The valid values of the ParameterKey and ParameterValue request parameters vary based on the value of TemplateScratchType. For more information, see the "**Additional information about request parameters**" section of this topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateScratchType")]
        [Validation(Required=false)]
        public string TemplateScratchType { get; set; }

    }

}
