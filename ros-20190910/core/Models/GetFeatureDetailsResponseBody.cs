// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetFeatureDetailsResponseBody : TeaModel {
        [NameInMap("DriftDetection")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyDriftDetection DriftDetection { get; set; }
        public class GetFeatureDetailsResponseBodyDriftDetection : TeaModel {
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<string> SupportedResourceTypes { get; set; }

        }

        /// <summary>
        /// The resource types that support the system tag `acs:ros:stackId`.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The names of properties that are supported by the resource type.
        /// </summary>
        [NameInMap("ResourceCleaner")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyResourceCleaner ResourceCleaner { get; set; }
        public class GetFeatureDetailsResponseBodyResourceCleaner : TeaModel {
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyResourceCleanerSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyResourceCleanerSupportedResourceTypes : TeaModel {
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("SideEffects")]
                [Validation(Required=false)]
                public List<string> SideEffects { get; set; }

                [NameInMap("SupportedFilters")]
                [Validation(Required=false)]
                public List<string> SupportedFilters { get; set; }

            }

        }

        [NameInMap("ResourceImport")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyResourceImport ResourceImport { get; set; }
        public class GetFeatureDetailsResponseBodyResourceImport : TeaModel {
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyResourceImportSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyResourceImportSupportedResourceTypes : TeaModel {
                [NameInMap("ResourceIdentifiers")]
                [Validation(Required=false)]
                public List<string> ResourceIdentifiers { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        [NameInMap("TemplateParameterConstraints")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTemplateParameterConstraints TemplateParameterConstraints { get; set; }
        public class GetFeatureDetailsResponseBodyTemplateParameterConstraints : TeaModel {
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTemplateParameterConstraintsSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTemplateParameterConstraintsSupportedResourceTypes : TeaModel {
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<string> Properties { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// The names of the side effects. The StopInstance value indicates that an instance that is related to the specified resource is stopped.
        /// </summary>
        [NameInMap("TemplateScratch")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTemplateScratch TemplateScratch { get; set; }
        public class GetFeatureDetailsResponseBodyTemplateScratch : TeaModel {
            /// <summary>
            /// The names of the side effects. The StopInstance value indicates that an instance that is related to the specified resource is stopped.
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes : TeaModel {
                /// <summary>
                /// Details of the template parameter constraint feature.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("SourceResourceGroupSupported")]
                [Validation(Required=false)]
                public bool? SourceResourceGroupSupported { get; set; }

                /// <summary>
                /// The resource types that support the template parameter constraint feature.
                /// </summary>
                [NameInMap("SourceResourcesSupported")]
                [Validation(Required=false)]
                public bool? SourceResourcesSupported { get; set; }

                /// <summary>
                /// The names of properties that are supported by the resource type.
                /// </summary>
                [NameInMap("SourceSupported")]
                [Validation(Required=false)]
                public bool? SourceSupported { get; set; }

                /// <summary>
                /// The resource types that support the template parameter constraint feature.
                /// </summary>
                [NameInMap("SourceTagSupported")]
                [Validation(Required=false)]
                public bool? SourceTagSupported { get; set; }

            }

        }

        /// <summary>
        /// The resource types that support the custom tag feature.
        /// </summary>
        [NameInMap("Terraform")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTerraform Terraform { get; set; }
        public class GetFeatureDetailsResponseBodyTerraform : TeaModel {
            /// <summary>
            /// The resource types that support the scenario feature.
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes : TeaModel {
                /// <summary>
                /// Indicates whether the resource scope can be specified by tag, resource group, or resource. Valid values:
                /// 
                /// - true
                /// - false
                /// </summary>
                [NameInMap("CustomTag")]
                [Validation(Required=false)]
                public List<string> CustomTag { get; set; }

                /// <summary>
                /// Indicates whether the resource scope can be specified by resource group. Valid values:
                /// 
                /// - true
                /// - false
                /// </summary>
                [NameInMap("EstimateCost")]
                [Validation(Required=false)]
                public List<string> EstimateCost { get; set; }

                /// <summary>
                /// Details of the resource cleaner feature.
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public List<string> ResourceGroup { get; set; }

                /// <summary>
                /// The resource type that can be cleaned up.
                /// </summary>
                [NameInMap("StackOperationRisk")]
                [Validation(Required=false)]
                public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk StackOperationRisk { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk : TeaModel {
                    /// <summary>
                    /// The filters that are used to filter resources. Valid values:
                    /// 
                    /// *   RegionId: the ID of the region.
                    /// *   ResourceId: the ID of the resource.
                    /// *   ResourceName: the name of the resource.
                    /// *   Tags: the tags of the resource.
                    /// *   ResourceGroupId: the ID of the resource group.
                    /// *   DeletionProtection: the deletion protection feature.
                    /// </summary>
                    [NameInMap("DeleteStack")]
                    [Validation(Required=false)]
                    public List<string> DeleteStack { get; set; }

                }

                /// <summary>
                /// The resource types that support the scenario feature.
                /// </summary>
                [NameInMap("SystemTag")]
                [Validation(Required=false)]
                public List<string> SystemTag { get; set; }

            }

            /// <summary>
            /// The resource types that support the custom tag feature.
            /// </summary>
            [NameInMap("SupportedVersions")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTerraformSupportedVersions> SupportedVersions { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedVersions : TeaModel {
                /// <summary>
                /// The resource types that support the price inquiry feature.
                /// </summary>
                [NameInMap("ProviderVersions")]
                [Validation(Required=false)]
                public List<GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions> ProviderVersions { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions : TeaModel {
                    /// <summary>
                    /// The resource types that support the price inquiry feature.
                    /// </summary>
                    [NameInMap("ProviderName")]
                    [Validation(Required=false)]
                    public string ProviderName { get; set; }

                    /// <summary>
                    /// The resource types that support the resource group feature.
                    /// </summary>
                    [NameInMap("SupportedVersions")]
                    [Validation(Required=false)]
                    public List<string> SupportedVersions { get; set; }

                }

                /// <summary>
                /// The resource type that support the risk check feature.
                /// </summary>
                [NameInMap("TerraformVersion")]
                [Validation(Required=false)]
                public string TerraformVersion { get; set; }

                /// <summary>
                /// The resource types that support the risk check performed to detect risks caused by a stack deletion operation.
                /// </summary>
                [NameInMap("Transform")]
                [Validation(Required=false)]
                public string Transform { get; set; }

                /// <summary>
                /// The resource types that support the risk check performed to detect risks caused by a stack deletion operation.
                /// </summary>
                [NameInMap("UpdateAllowedTransforms")]
                [Validation(Required=false)]
                public List<string> UpdateAllowedTransforms { get; set; }

            }

        }

    }

}
