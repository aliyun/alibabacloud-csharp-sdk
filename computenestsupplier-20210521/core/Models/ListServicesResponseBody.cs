// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServicesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The services.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyServices> Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// The approval type for applications for using the service. Valid values:
            /// 
            /// *   Manual: The applications are manual reviewed.
            /// *   AutoPass: The applications are automatically approved.
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public string ApprovalType { get; set; }

            /// <summary>
            /// The ID of the artifact.
            /// </summary>
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// The version of the artifact.
            /// </summary>
            [NameInMap("ArtifactVersion")]
            [Validation(Required=false)]
            public string ArtifactVersion { get; set; }

            /// <summary>
            /// The informathon for build service.
            /// </summary>
            [NameInMap("BuildInfo")]
            [Validation(Required=false)]
            public string BuildInfo { get; set; }

            /// <summary>
            /// The category of the service.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public string Categories { get; set; }

            /// <summary>
            /// The commodity details.
            /// </summary>
            [NameInMap("Commodity")]
            [Validation(Required=false)]
            public ListServicesResponseBodyServicesCommodity Commodity { get; set; }
            public class ListServicesResponseBodyServicesCommodity : TeaModel {
                /// <summary>
                /// The commodity code.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The configuration metadata related to Saas Boost.
                /// </summary>
                [NameInMap("SaasBoostMetadata")]
                [Validation(Required=false)]
                public string SaasBoostMetadata { get; set; }

                /// <summary>
                /// The platform type. Valid values:
                /// 
                /// *   marketplace: Alibaba Cloud Marketplace.
                /// *   Css: Lingxiao.
                /// *   SaasBoost: Saas Boost.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The commodity code of the service in Alibaba Cloud Marketplace.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The time when the service was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Indicates whether the version is the default version. Valid values:
            /// 
            /// *   false
            /// *   true
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            /// <summary>
            /// The deployment type of the service. Valid values:
            /// 
            /// *   ros: The service is deployed by using Resource Orchestration Service (ROS).
            /// *   terraform: The service is deployed by using Terraform.
            /// *   spi: The service is deployed by calling the Service Provider Interface (SPI).
            /// *   operation: The service is deployed by using a hosted O\\&M service.
            /// *   container: The service is deployed by using a container.
            /// *
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// Indicates whether the service has a beta version. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("HasBeta")]
            [Validation(Required=false)]
            public bool? HasBeta { get; set; }

            /// <summary>
            /// Indicates whether the service has a draft version. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("HasDraft")]
            [Validation(Required=false)]
            public bool? HasDraft { get; set; }

            /// <summary>
            /// The latest version of the distribution source service.
            /// </summary>
            [NameInMap("LatestResellSourceServiceVersion")]
            [Validation(Required=false)]
            public string LatestResellSourceServiceVersion { get; set; }

            /// <summary>
            /// The time when the service was published.
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// The purpose of the artifact. Valid values:
            /// 
            /// *   ServiceDeployment: The artifact is used to create service instances.
            /// *   ServiceUpgrade: The artifact is used to upgrade service instances.
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// The state of distribution authorization of the service. Valid values:
            /// 
            /// *   CanApply: Distributors can apply for distribution permissions.
            /// *   Applied: The application for distribution permissions is submitted.
            /// *   Approved: The application for distribution permissions is approved.
            /// </summary>
            [NameInMap("ResellApplyStatus")]
            [Validation(Required=false)]
            public string ResellApplyStatus { get; set; }

            /// <summary>
            /// The ID of the distribution service.
            /// </summary>
            [NameInMap("ResellServiceId")]
            [Validation(Required=false)]
            public string ResellServiceId { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether the service is visible. Valid values:
            /// 
            /// *   INVISIBLE
            /// *   DISCOVERABLE
            /// </summary>
            [NameInMap("ServiceDiscoverable")]
            [Validation(Required=false)]
            public string ServiceDiscoverable { get; set; }

            /// <summary>
            /// The service ID.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// The information about the service.
            /// </summary>
            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesServiceInfos> ServiceInfos { get; set; }
            public class ListServicesResponseBodyServicesServiceInfos : TeaModel {
                /// <summary>
                /// The URL of the service icon.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The language of the service. Valid values:
                /// 
                /// *   zh-CN: Chinese.
                /// *   en-US: English.
                /// </summary>
                [NameInMap("Locale")]
                [Validation(Required=false)]
                public string Locale { get; set; }

                /// <summary>
                /// The name of the service.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The description of the service.
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

            }

            /// <summary>
            /// The type of the service. Valid values:
            /// 
            /// *   private: The service is a private service and is deployed within the account of a customer.
            /// *   managed: The service is a fully managed service and is deployed within the account of a service provider.
            /// *   operation: The service is a hosted O\\&M service.
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// The permission type of the deployment URL. Valid values:
            /// 
            /// *   Public: All users can go to the URL to create a formal service instance or a trial service instance.
            /// *   Restricted: Only users in the whitelist can go to the URL to create a formal service instance or a trial service instance.
            /// *   OnlyFormalRestricted: Only users in the whitelist can go to the URL to create a formal service instance.
            /// *   OnlyTrailRestricted: Only users in the whitelist can go to the URL to create a trial service instance.
            /// *   Hidden: Users not in the whitelist cannot see the service details page when they go to the URL and cannot request deployment permissions.
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// The source image.
            /// </summary>
            [NameInMap("SourceImage")]
            [Validation(Required=false)]
            public string SourceImage { get; set; }

            /// <summary>
            /// The ID of the distribution source service.
            /// </summary>
            [NameInMap("SourceServiceId")]
            [Validation(Required=false)]
            public string SourceServiceId { get; set; }

            /// <summary>
            /// The version of the distribution source service.
            /// </summary>
            [NameInMap("SourceServiceVersion")]
            [Validation(Required=false)]
            public string SourceServiceVersion { get; set; }

            /// <summary>
            /// The name of the distribution source service provider.
            /// </summary>
            [NameInMap("SourceSupplierName")]
            [Validation(Required=false)]
            public string SourceSupplierName { get; set; }

            /// <summary>
            /// The state of the service. Valid values:
            /// 
            /// *   Draft: The service is a draft.
            /// *   Submitted: The service is submitted for review. You cannot modify services in this state.
            /// *   Approved: The service is approved. You cannot modify services in this state. You can publish services in this state.
            /// *   Launching: The service is being published.
            /// *   Online: The service is published.
            /// *   Offline: The service is unpublished.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the service provider.
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// The URL of the service provider.
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

            /// <summary>
            /// The service tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesTags> Tags { get; set; }
            public class ListServicesResponseBodyServicesTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The tenant type of the managed service. Valid values:
            /// 
            /// *   SingleTenant
            /// *   MultiTenant
            /// </summary>
            [NameInMap("TenantType")]
            [Validation(Required=false)]
            public string TenantType { get; set; }

            /// <summary>
            /// The trial policy. Valid values:
            /// 
            /// *   Trial: Trials are supported.
            /// *   NotTrial: Trials are not supported.
            /// </summary>
            [NameInMap("TrialType")]
            [Validation(Required=false)]
            public string TrialType { get; set; }

            /// <summary>
            /// The time when the service was modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The version of the service.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The custom version name defined by the service provider.
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// Indicates whether the service is a virtual Internet service. Valid values:
            /// 
            /// *   false
            /// *   true
            /// </summary>
            [NameInMap("VirtualInternetService")]
            [Validation(Required=false)]
            public string VirtualInternetService { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
