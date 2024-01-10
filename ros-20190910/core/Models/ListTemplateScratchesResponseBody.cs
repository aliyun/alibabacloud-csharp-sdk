// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplateScratchesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scenarios.
        /// </summary>
        [NameInMap("TemplateScratches")]
        [Validation(Required=false)]
        public List<ListTemplateScratchesResponseBodyTemplateScratches> TemplateScratches { get; set; }
        public class ListTemplateScratchesResponseBodyTemplateScratches : TeaModel {
            /// <summary>
            /// The time when the scenario was created.
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
            /// The status code that is returned if the scenario failed to be generated.
            /// 
            /// >  This parameter is returned only if Status is set to GENERATE_FAILED.
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
            /// The parameters that are configured for the scenario.
            /// </summary>
            [NameInMap("PreferenceParameters")]
            [Validation(Required=false)]
            public List<ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters> PreferenceParameters { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters : TeaModel {
                /// <summary>
                /// The name of the parameter.
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
            public ListTemplateScratchesResponseBodyTemplateScratchesSourceResourceGroup SourceResourceGroup { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceResourceGroup : TeaModel {
                /// <summary>
                /// The ID of the source resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The filters for resource types.
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
            public List<ListTemplateScratchesResponseBodyTemplateScratchesSourceResources> SourceResources { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceResources : TeaModel {
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
            public ListTemplateScratchesResponseBodyTemplateScratchesSourceTag SourceTag { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceTag : TeaModel {
                /// <summary>
                /// The source tags.
                /// </summary>
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

                /// <summary>
                /// The filters for resource types.
                /// </summary>
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }

            /// <summary>
            /// The state of the scenario.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the scenario failed to be generated.
            /// 
            /// >  This parameter is returned only if Status is set to GENERATE_FAILED.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// The tags of the scenario.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTemplateScratchesResponseBodyTemplateScratchesTags> Tags { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesTags : TeaModel {
                /// <summary>
                /// The tag key of the scenario.
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
            /// The scenario ID.
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
            /// The time when the scenario was updated.
            /// 
            /// The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The total number of scenarios.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
