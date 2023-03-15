// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateTemplateScratchRequest : TeaModel {
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
        public List<UpdateTemplateScratchRequestPreferenceParameters> PreferenceParameters { get; set; }
        public class UpdateTemplateScratchRequestPreferenceParameters : TeaModel {
            /// <summary>
            /// The name of a request parameter.
            /// 
            /// For more information about ParameterKey, see **Additional description of request parameters**.
            /// 
            /// > 
            /// *   PreferenceParameters is optional. If you set PreferenceParameters, you must specify both ParameterKey and ParameterValue.
            /// *   If you set TemplateScratchType to ResourceImport, you must set ParameterKey to DeletionPolicy.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of a request parameter. The value of ParameterValue varies based on the value of ParameterKey.
            /// 
            /// For more information about ParameterValue, see **Additional description of request parameters**.
            /// 
            /// >  PreferenceParameters is optional. If you set PreferenceParameters, you must specify both ParameterKey and ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

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
        public UpdateTemplateScratchRequestSourceResourceGroup SourceResourceGroup { get; set; }
        public class UpdateTemplateScratchRequestSourceResourceGroup : TeaModel {
            /// <summary>
            /// The ID of the source resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The filter for resource types. If you specify this parameter, only the resources of the specified types and in the specified resource groups are scanned. If you do not specify this parameter, all the resources in the specified resource groups are scanned.
            /// 
            /// You can specify up to 20 resource types.
            /// </summary>
            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        /// <summary>
        /// The source resource.
        /// </summary>
        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public List<UpdateTemplateScratchRequestSourceResources> SourceResources { get; set; }
        public class UpdateTemplateScratchRequestSourceResources : TeaModel {
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
        public UpdateTemplateScratchRequestSourceTag SourceTag { get; set; }
        public class UpdateTemplateScratchRequestSourceTag : TeaModel {
            /// <summary>
            /// The source tags that consist of key-value pairs.
            /// 
            /// If you want to specify only the tag key, you must set the tag value to an empty string. Example: {"TagKey": ""}.
            /// 
            /// You can configure up to 10 source tags.
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
        /// The ID of the scenario.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
