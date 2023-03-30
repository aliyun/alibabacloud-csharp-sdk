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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the resource cleaner feature.
        /// </summary>
        [NameInMap("ResourceCleaner")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyResourceCleaner ResourceCleaner { get; set; }
        public class GetFeatureDetailsResponseBodyResourceCleaner : TeaModel {
            /// <summary>
            /// The resource types that can be cleaned up.
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyResourceCleanerSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyResourceCleanerSupportedResourceTypes : TeaModel {
                /// <summary>
                /// The resource type that can be cleaned up.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The names of the side effects. The StopInstance value indicates that an instance that is related to the specified resource is stopped.
                /// </summary>
                [NameInMap("SideEffects")]
                [Validation(Required=false)]
                public List<string> SideEffects { get; set; }

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

        /// <summary>
        /// Details of the template parameter constraint feature.
        /// </summary>
        [NameInMap("TemplateParameterConstraints")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTemplateParameterConstraints TemplateParameterConstraints { get; set; }
        public class GetFeatureDetailsResponseBodyTemplateParameterConstraints : TeaModel {
            /// <summary>
            /// The resource types that support the template parameter constraint feature.
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTemplateParameterConstraintsSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTemplateParameterConstraintsSupportedResourceTypes : TeaModel {
                /// <summary>
                /// The names of properties that are supported by the resource type.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<string> Properties { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// Details of the scenario feature.
        /// </summary>
        [NameInMap("TemplateScratch")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTemplateScratch TemplateScratch { get; set; }
        public class GetFeatureDetailsResponseBodyTemplateScratch : TeaModel {
            /// <summary>
            /// The resource types that support the scenario feature.
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes : TeaModel {
                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// Indicates whether the resource scope can be specified by resource group. Valid values:
                /// 
                /// - true
                /// - false
                /// </summary>
                [NameInMap("SourceResourceGroupSupported")]
                [Validation(Required=false)]
                public bool? SourceResourceGroupSupported { get; set; }

                /// <summary>
                /// Indicates whether the resource scope can be specified by tag, resource group, or resource. Valid values:
                /// 
                /// - true
                /// - false
                /// </summary>
                [NameInMap("SourceResourcesSupported")]
                [Validation(Required=false)]
                public bool? SourceResourcesSupported { get; set; }

                /// <summary>
                /// Indicates whether the resource scope can be specified by resource. Valid values:
                /// 
                /// - true
                /// - false
                /// </summary>
                [NameInMap("SourceSupported")]
                [Validation(Required=false)]
                public bool? SourceSupported { get; set; }

                /// <summary>
                /// Indicates whether the resource scope can be specified by tag. Valid values:
                /// 
                /// - true
                /// - false
                /// </summary>
                [NameInMap("SourceTagSupported")]
                [Validation(Required=false)]
                public bool? SourceTagSupported { get; set; }

            }

        }

        /// <summary>
        /// Details of the Terraform hosting feature.
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
                /// The resource types that support the custom tag feature.
                /// </summary>
                [NameInMap("CustomTag")]
                [Validation(Required=false)]
                public List<string> CustomTag { get; set; }

                /// <summary>
                /// The resource types that support the price inquiry feature.
                /// </summary>
                [NameInMap("EstimateCost")]
                [Validation(Required=false)]
                public List<string> EstimateCost { get; set; }

                /// <summary>
                /// The resource types that support the resource group feature.
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public List<string> ResourceGroup { get; set; }

                /// <summary>
                /// The resource type that support the risk check feature.
                /// </summary>
                [NameInMap("StackOperationRisk")]
                [Validation(Required=false)]
                public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk StackOperationRisk { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk : TeaModel {
                    /// <summary>
                    /// The resource types that support the risk check performed to detect risks caused by a stack deletion operation.
                    /// </summary>
                    [NameInMap("DeleteStack")]
                    [Validation(Required=false)]
                    public List<string> DeleteStack { get; set; }

                }

                /// <summary>
                /// The resource types that support the system tag `acs:ros:stackId`.
                /// </summary>
                [NameInMap("SystemTag")]
                [Validation(Required=false)]
                public List<string> SystemTag { get; set; }

            }

            /// <summary>
            /// The Terraform versions.
            /// </summary>
            [NameInMap("SupportedVersions")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTerraformSupportedVersions> SupportedVersions { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedVersions : TeaModel {
                /// <summary>
                /// The names and versions of the providers that correspond to the Terraform versions.
                /// </summary>
                [NameInMap("ProviderVersions")]
                [Validation(Required=false)]
                public List<GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions> ProviderVersions { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions : TeaModel {
                    /// <summary>
                    /// The name of the provider.
                    /// </summary>
                    [NameInMap("ProviderName")]
                    [Validation(Required=false)]
                    public string ProviderName { get; set; }

                    /// <summary>
                    /// The versions of the provider.
                    /// </summary>
                    [NameInMap("SupportedVersions")]
                    [Validation(Required=false)]
                    public List<string> SupportedVersions { get; set; }

                }

                /// <summary>
                /// The Terraform version.
                /// </summary>
                [NameInMap("TerraformVersion")]
                [Validation(Required=false)]
                public string TerraformVersion { get; set; }

                /// <summary>
                /// The Terraform version that is supported by ROS. The parameter value is the same as the value of the Transform parameter in a Terraform template.
                /// </summary>
                [NameInMap("Transform")]
                [Validation(Required=false)]
                public string Transform { get; set; }

                /// <summary>
                /// The versions to which Terraform can be updated in ROS.
                /// </summary>
                [NameInMap("UpdateAllowedTransforms")]
                [Validation(Required=false)]
                public List<string> UpdateAllowedTransforms { get; set; }

            }

        }

    }

}
