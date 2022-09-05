// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetFeatureDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        [NameInMap("TemplateScratch")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTemplateScratch TemplateScratch { get; set; }
        public class GetFeatureDetailsResponseBodyTemplateScratch : TeaModel {
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes> SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTemplateScratchSupportedResourceTypes : TeaModel {
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("SourceResourceGroupSupported")]
                [Validation(Required=false)]
                public bool? SourceResourceGroupSupported { get; set; }

                [NameInMap("SourceResourcesSupported")]
                [Validation(Required=false)]
                public bool? SourceResourcesSupported { get; set; }

                [NameInMap("SourceSupported")]
                [Validation(Required=false)]
                public bool? SourceSupported { get; set; }

                [NameInMap("SourceTagSupported")]
                [Validation(Required=false)]
                public bool? SourceTagSupported { get; set; }

            }

        }

        [NameInMap("Terraform")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTerraform Terraform { get; set; }
        public class GetFeatureDetailsResponseBodyTerraform : TeaModel {
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes : TeaModel {
                [NameInMap("CustomTag")]
                [Validation(Required=false)]
                public List<string> CustomTag { get; set; }

                [NameInMap("EstimateCost")]
                [Validation(Required=false)]
                public List<string> EstimateCost { get; set; }

                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public List<string> ResourceGroup { get; set; }

                [NameInMap("StackOperationRisk")]
                [Validation(Required=false)]
                public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk StackOperationRisk { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypesStackOperationRisk : TeaModel {
                    [NameInMap("DeleteStack")]
                    [Validation(Required=false)]
                    public List<string> DeleteStack { get; set; }

                }

                [NameInMap("SystemTag")]
                [Validation(Required=false)]
                public List<string> SystemTag { get; set; }

            }

            [NameInMap("SupportedVersions")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTerraformSupportedVersions> SupportedVersions { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedVersions : TeaModel {
                [NameInMap("ProviderVersions")]
                [Validation(Required=false)]
                public List<GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions> ProviderVersions { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions : TeaModel {
                    [NameInMap("ProviderName")]
                    [Validation(Required=false)]
                    public string ProviderName { get; set; }

                    [NameInMap("SupportedVersions")]
                    [Validation(Required=false)]
                    public List<string> SupportedVersions { get; set; }

                }

                [NameInMap("TerraformVersion")]
                [Validation(Required=false)]
                public string TerraformVersion { get; set; }

                [NameInMap("Transform")]
                [Validation(Required=false)]
                public string Transform { get; set; }

                [NameInMap("UpdateAllowedTransforms")]
                [Validation(Required=false)]
                public List<string> UpdateAllowedTransforms { get; set; }

            }

        }

    }

}
