// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateScratchResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scenario.
        /// </summary>
        [NameInMap("TemplateScratch")]
        [Validation(Required=false)]
        public GetTemplateScratchResponseBodyTemplateScratch TemplateScratch { get; set; }
        public class GetTemplateScratchResponseBodyTemplateScratch : TeaModel {
            /// <summary>
            /// The time at which the scenario was created.
            /// 
            /// The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the scenario.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The status code of the scenario that fails to be created.
            /// 
            /// > This parameter is returned only if you set Status to GENERATE_FAILED.
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

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
            public List<GetTemplateScratchResponseBodyTemplateScratchPreferenceParameters> PreferenceParameters { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchPreferenceParameters : TeaModel {
                /// <summary>
                /// The key of the parameter.
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// The source resource group.
            /// </summary>
            [NameInMap("SourceResourceGroup")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchSourceResourceGroup SourceResourceGroup { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceResourceGroup : TeaModel {
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
            public List<GetTemplateScratchResponseBodyTemplateScratchSourceResources> SourceResources { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceResources : TeaModel {
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
            public GetTemplateScratchResponseBodyTemplateScratchSourceTag SourceTag { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceTag : TeaModel {
                /// <summary>
                /// The source tags.
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
            /// The preset information of the stack.
            /// </summary>
            [NameInMap("StackProvision")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchStackProvision StackProvision { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchStackProvision : TeaModel {
                /// <summary>
                /// Indicates whether the resource is replicated by calling the [CreateStack](~~132086~~) operation. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("Creatable")]
                [Validation(Required=false)]
                public bool? Creatable { get; set; }

                /// <summary>
                /// Indicates whether the resource is managed by calling the [CreateChangeSet](~~131051~~) operation. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("Importable")]
                [Validation(Required=false)]
                public bool? Importable { get; set; }

            }

            /// <summary>
            /// The stacks that are associated with the scenario.
            /// </summary>
            [NameInMap("Stacks")]
            [Validation(Required=false)]
            public List<GetTemplateScratchResponseBodyTemplateScratchStacks> Stacks { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchStacks : TeaModel {
                /// <summary>
                /// The region ID of the stack.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the stack.
                /// </summary>
                [NameInMap("StackId")]
                [Validation(Required=false)]
                public string StackId { get; set; }

                /// <summary>
                /// The purpose of the stack. Valid values:
                /// 
                /// *   ResourceImport: resource management
                /// *   ArchitectureReplication: resource replication
                /// </summary>
                [NameInMap("UsageType")]
                [Validation(Required=false)]
                public string UsageType { get; set; }

            }

            /// <summary>
            /// The state of the scenario. Valid values:
            /// 
            /// *   GENERATE_IN_PROGRESS: The scenario is being created.
            /// *   GENERATE_COMPLETE: The scenario is created.
            /// *   GENERATE_FAILED: The scenario fails to be created.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the scenario fails to be created.
            /// 
            /// > This parameter is returned only if you set Status to GENERATE_FAILED.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// The scenario data.
            /// </summary>
            [NameInMap("TemplateScratchData")]
            [Validation(Required=false)]
            public Dictionary<string, object> TemplateScratchData { get; set; }

            /// <summary>
            /// The ID of the scenario.
            /// </summary>
            [NameInMap("TemplateScratchId")]
            [Validation(Required=false)]
            public string TemplateScratchId { get; set; }

            /// <summary>
            /// The type of the scenario. Valid values:
            /// 
            /// *   ResourceImport: resource management
            /// *   ArchitectureReplication: resource replication
            /// </summary>
            [NameInMap("TemplateScratchType")]
            [Validation(Required=false)]
            public string TemplateScratchType { get; set; }

            /// <summary>
            /// The time at which the scenario was updated.
            /// 
            /// The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
