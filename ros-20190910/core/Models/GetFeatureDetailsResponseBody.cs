// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetFeatureDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the drift detection feature.</para>
        /// </summary>
        [NameInMap("DriftDetection")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyDriftDetection DriftDetection { get; set; }
        public class GetFeatureDetailsResponseBodyDriftDetection : TeaModel {
            /// <summary>
            /// <para>The resource types that are supported by the drift detection feature.</para>
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<string> SupportedResourceTypes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EBF833DA-D0E2-52BE-92E2-59CA56BE834E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the resource cleaner feature.</para>
        /// </summary>
        [NameInMap("ResourceCleaner")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyResourceCleaner ResourceCleaner { get; set; }
        public class GetFeatureDetailsResponseBodyResourceCleaner : TeaModel {
            /// <summary>
            /// <para>The resource types that can be cleaned up.</para>
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyResourceCleanerSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyResourceCleanerSupportedResourceTypes : TeaModel {
                /// <summary>
                /// <para>The resource type that supports the resource cleaner feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS:Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The names of the side effects that may be caused by the cleanup operation performed on the resources of the specified type.</para>
                /// </summary>
                [NameInMap("SideEffects")]
                [Validation(Required=false)]
                public List<string> SideEffects { get; set; }

                /// <summary>
                /// <para>The names of the filters that are supported by the resource type.</para>
                /// </summary>
                [NameInMap("SupportedFilters")]
                [Validation(Required=false)]
                public List<string> SupportedFilters { get; set; }

            }

        }

        /// <summary>
        /// <para>Details of the resource import feature.</para>
        /// </summary>
        [NameInMap("ResourceImport")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyResourceImport ResourceImport { get; set; }
        public class GetFeatureDetailsResponseBodyResourceImport : TeaModel {
            /// <summary>
            /// <para>The resource types that are supported by the resource import feature.</para>
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyResourceImportSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyResourceImportSupportedResourceTypes : TeaModel {
                /// <summary>
                /// <para>The resource identifiers.</para>
                /// </summary>
                [NameInMap("ResourceIdentifiers")]
                [Validation(Required=false)]
                public List<string> ResourceIdentifiers { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::Disk</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>Details of the template parameter constraint feature.</para>
        /// </summary>
        [NameInMap("TemplateParameterConstraints")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTemplateParameterConstraints TemplateParameterConstraints { get; set; }
        public class GetFeatureDetailsResponseBodyTemplateParameterConstraints : TeaModel {
            /// <summary>
            /// <para>The resource types that support the template parameter constraint feature.</para>
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTemplateParameterConstraintsSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTemplateParameterConstraintsSupportedResourceTypes : TeaModel {
                /// <summary>
                /// <para>The names of properties that are supported by the resource type.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<string> Properties { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::Disk</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>Details of the scenario feature.</para>
        /// </summary>
        [NameInMap("TemplateScratch")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTemplateScratch TemplateScratch { get; set; }
        public class GetFeatureDetailsResponseBodyTemplateScratch : TeaModel {
            /// <summary>
            /// <para>The resource types that are supported by the scenario feature.</para>
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes : TeaModel {
                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::Disk</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource scope can be specified by source resource group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SourceResourceGroupSupported")]
                [Validation(Required=false)]
                public bool? SourceResourceGroupSupported { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource scope can be specified by source resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SourceResourcesSupported")]
                [Validation(Required=false)]
                public bool? SourceResourcesSupported { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource scope can be specified by source tag, resource group, or resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SourceSupported")]
                [Validation(Required=false)]
                public bool? SourceSupported { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource scope can be specified by source tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SourceTagSupported")]
                [Validation(Required=false)]
                public bool? SourceTagSupported { get; set; }

                /// <summary>
                /// <para>The scenario types that are supported.</para>
                /// </summary>
                [NameInMap("SupportedTemplateScratchTypes")]
                [Validation(Required=false)]
                public List<string> SupportedTemplateScratchTypes { get; set; }

            }

        }

        /// <summary>
        /// <para>Details of the Terraform hosting feature.</para>
        /// </summary>
        [NameInMap("Terraform")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTerraform Terraform { get; set; }
        public class GetFeatureDetailsResponseBodyTerraform : TeaModel {
            /// <summary>
            /// <para>The resource types that support the scenario feature.</para>
            /// </summary>
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes : TeaModel {
                /// <summary>
                /// <para>The resource types that support the custom tag feature.</para>
                /// </summary>
                [NameInMap("CustomTag")]
                [Validation(Required=false)]
                public List<string> CustomTag { get; set; }

                /// <summary>
                /// <para>The resource types that support the price inquiry feature.</para>
                /// </summary>
                [NameInMap("EstimateCost")]
                [Validation(Required=false)]
                public List<string> EstimateCost { get; set; }

                /// <summary>
                /// <para>The resource types that support the resource group feature.</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public List<string> ResourceGroup { get; set; }

                /// <summary>
                /// <para>The resource type that support the risk check feature.</para>
                /// </summary>
                [NameInMap("StackOperationRisk")]
                [Validation(Required=false)]
                public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk StackOperationRisk { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk : TeaModel {
                    /// <summary>
                    /// <para>The resource types that support the risk check performed to detect risks caused by a stack deletion operation.</para>
                    /// </summary>
                    [NameInMap("DeleteStack")]
                    [Validation(Required=false)]
                    public List<string> DeleteStack { get; set; }

                }

                /// <summary>
                /// <para>The resource types that support the system tag <c>acs:ros:stackId</c>.</para>
                /// </summary>
                [NameInMap("SystemTag")]
                [Validation(Required=false)]
                public List<string> SystemTag { get; set; }

            }

            /// <summary>
            /// <para>The Terraform versions.</para>
            /// </summary>
            [NameInMap("SupportedVersions")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTerraformSupportedVersions> SupportedVersions { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedVersions : TeaModel {
                /// <summary>
                /// <para>The names and versions of the providers that correspond to the Terraform versions.</para>
                /// </summary>
                [NameInMap("ProviderVersions")]
                [Validation(Required=false)]
                public List<GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions> ProviderVersions { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions : TeaModel {
                    /// <summary>
                    /// <para>The name of the provider.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alicloud</para>
                    /// </summary>
                    [NameInMap("ProviderName")]
                    [Validation(Required=false)]
                    public string ProviderName { get; set; }

                    /// <summary>
                    /// <para>The provider versions.</para>
                    /// </summary>
                    [NameInMap("SupportedVersions")]
                    [Validation(Required=false)]
                    public List<string> SupportedVersions { get; set; }

                }

                /// <summary>
                /// <para>The Terraform version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.11</para>
                /// </summary>
                [NameInMap("TerraformVersion")]
                [Validation(Required=false)]
                public string TerraformVersion { get; set; }

                /// <summary>
                /// <para>The Terraform version that is supported by ROS. The parameter value is the same as the value of the Transform parameter in a Terraform template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aliyun::Terraform-v1.0</para>
                /// </summary>
                [NameInMap("Transform")]
                [Validation(Required=false)]
                public string Transform { get; set; }

                /// <summary>
                /// <para>The Terraform versions that can be updated in ROS.</para>
                /// </summary>
                [NameInMap("UpdateAllowedTransforms")]
                [Validation(Required=false)]
                public List<string> UpdateAllowedTransforms { get; set; }

            }

        }

    }

}
