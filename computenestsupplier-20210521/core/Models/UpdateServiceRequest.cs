// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// The alert configurations of the service.
        /// 
        /// >  This parameter takes effect only when you specify an alert policy for **PolicyNames**.
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// The approval type of the service usage application. Valid values:
        /// 
        /// - Manual: The application is manually approved.
        /// - AutoPass: The application is automatically approved.
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Bind Commodity Information
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public UpdateServiceRequestCommodity Commodity { get; set; }
        public class UpdateServiceRequestCommodity : TeaModel {
            /// <summary>
            /// This parameter is not publicly accessible.
            /// </summary>
            [NameInMap("ComponentsMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityComponentsMappings> ComponentsMappings { get; set; }
            public class UpdateServiceRequestCommodityComponentsMappings : TeaModel {
                /// <summary>
                /// This parameter is not publicly accessible.
                /// </summary>
                [NameInMap("Mappings")]
                [Validation(Required=false)]
                public string Mappings { get; set; }

                /// <summary>
                /// This parameter is not publicly accessible.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// Metering Item Configuration Information (Cloud Marketplace - Pay-As-You-Go Use)
            /// </summary>
            [NameInMap("MeteringEntityExtraInfos")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityExtraInfos : TeaModel {
                /// <summary>
                /// The ID of the entity.
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// Metric Name, filled in when Type is ComputeNestBill or ComputeNestPrometheus
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// Custom prometheus query
                /// </summary>
                [NameInMap("Promql")]
                [Validation(Required=false)]
                public string Promql { get; set; }

                /// <summary>
                /// Type, value：
                /// 
                /// * **Custom**
                /// * **ComputeNestBill**
                /// * **ComputeNestPrometheus**
                /// * **ComputeNestTime**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Product Specifications and Template/specification mapping Relationships (Cloud Marketplace - Pay-As-You-Go Use)
            /// </summary>
            [NameInMap("MeteringEntityMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityMappings> MeteringEntityMappings { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityMappings : TeaModel {
                /// <summary>
                /// The ID of the entity.
                /// </summary>
                [NameInMap("EntityIds")]
                [Validation(Required=false)]
                public List<string> EntityIds { get; set; }

                /// <summary>
                /// The package name.
                /// </summary>
                [NameInMap("SpecificationName")]
                [Validation(Required=false)]
                public string SpecificationName { get; set; }

                /// <summary>
                /// The template name.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// Saas boost config information
            /// </summary>
            [NameInMap("SaasBoostConfig")]
            [Validation(Required=false)]
            public string SaasBoostConfig { get; set; }

            /// <summary>
            /// Product Specifications and Template/specification mapping Relationships (Cloud Marketplace - Subscription/Permanent Use)
            /// </summary>
            [NameInMap("SpecificationMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommoditySpecificationMappings> SpecificationMappings { get; set; }
            public class UpdateServiceRequestCommoditySpecificationMappings : TeaModel {
                /// <summary>
                /// Specification code.
                /// </summary>
                [NameInMap("SpecificationCode")]
                [Validation(Required=false)]
                public string SpecificationCode { get; set; }

                /// <summary>
                /// The package name.
                /// </summary>
                [NameInMap("SpecificationName")]
                [Validation(Required=false)]
                public string SpecificationName { get; set; }

                /// <summary>
                /// The template name.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

        /// <summary>
        /// The storage configurations of the service. The format in which the deployment information of a service is stored varies based on the deployment type of the service. In this case, the deployment information is stored in the JSON string format.
        /// </summary>
        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        /// <summary>
        /// The deployment type of the service. Valid values:
        /// 
        /// *   ros: The service is deployed by using Resource Orchestration Service (ROS).
        /// *   terraform: The service is deployed by using Terraform.
        /// *   spi: The service is deployed by calling a service provider interface (SPI).
        /// *   operation: The service is deployed by using a hosted O\\&M service.
        /// *   container: The service is deployed by using a container.
        /// *   pkg: The service is deployed by using a package.
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// The duration for which hosted O\\&M is implemented. Unit: seconds.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// Specifies whether to enable the hosted O\\&M feature for the service. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  This parameter is required if you set **ServiceType** to **private**.
        /// </summary>
        [NameInMap("IsSupportOperated")]
        [Validation(Required=false)]
        public bool? IsSupportOperated { get; set; }

        /// <summary>
        /// The license metadata.
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// The logging configurations.
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// The hosted O\\&M configurations.
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// The policy name. The name can be up to 128 characters in length. Separate multiple names with commas (,). Only hosted O\\&M policies are supported.
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to support distribution. Valid values:
        /// 
        /// *   false
        /// *   true
        /// </summary>
        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        /// <summary>
        /// The service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The service details.
        /// </summary>
        [NameInMap("ServiceInfo")]
        [Validation(Required=false)]
        public List<UpdateServiceRequestServiceInfo> ServiceInfo { get; set; }
        public class UpdateServiceRequestServiceInfo : TeaModel {
            /// <summary>
            /// Protocol document information about the service.
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestServiceInfoAgreements> Agreements { get; set; }
            public class UpdateServiceRequestServiceInfoAgreements : TeaModel {
                /// <summary>
                /// Protocol name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Protocol url.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The URL of the service icon.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The language of the service. Valid values:
            /// 
            /// *   zh-CN: Chinese
            /// *   en-US: English
            /// </summary>
            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            /// <summary>
            /// The URL of the detailed description of the service.
            /// </summary>
            [NameInMap("LongDescriptionUrl")]
            [Validation(Required=false)]
            public string LongDescriptionUrl { get; set; }

            /// <summary>
            /// The service name.
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
        /// The service type. Valid values:
        /// 
        /// *   private: The service is a private service and is deployed within the account of a customer.
        /// *   managed: The service is a fully managed service and is deployed within the account of a service provider.
        /// *   operation: The service is a hosted O\\&M service.
        /// *   poc: The service is a trial service.
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// The permission type of the deployment URL. Valid values:
        /// 
        /// - Public: All users can go to the URL to create a service instance or a trial service instance.
        /// - Restricted: Only users in the whitelist can go to the URL to create a service instance or a trial service instance.
        /// - OnlyFormalRestricted: Only users in the whitelist can go to the URL to create a service instance.
        /// - OnlyTrailRestricted: Only users in the whitelist can go to the URL to create a trial service instance.
        /// - Hidden: Users not in the whitelist cannot see the service details page when they go to the URL and cannot request deployment permissions.
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// The type of the tenant. Valid values:
        /// 
        /// *   SingleTenant
        /// *   MultiTenant
        /// </summary>
        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// The trial duration. Unit: day. The maximum trial duration cannot exceed 30 days.
        /// </summary>
        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public int? TrialDuration { get; set; }

        /// <summary>
        /// The options for update the service.
        /// </summary>
        [NameInMap("UpdateOption")]
        [Validation(Required=false)]
        public UpdateServiceRequestUpdateOption UpdateOption { get; set; }
        public class UpdateServiceRequestUpdateOption : TeaModel {
            /// <summary>
            /// The options for update the service. Valid values:
            /// - CODE
            /// - PARAMETERS
            /// </summary>
            [NameInMap("UpdateFrom")]
            [Validation(Required=false)]
            public string UpdateFrom { get; set; }

        }

        /// <summary>
        /// The metadata about the upgrade.
        /// </summary>
        [NameInMap("UpgradeMetadata")]
        [Validation(Required=false)]
        public string UpgradeMetadata { get; set; }

        /// <summary>
        /// The version name.
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
