// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceResponseBody : TeaModel {
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
        /// *   Manual: The application is manually approved.
        /// *   AutoPass: The application is automatically approved.
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// The information of build service information.
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
        public GetServiceResponseBodyCommodity Commodity { get; set; }
        public class GetServiceResponseBodyCommodity : TeaModel {
            /// <summary>
            /// The billing method of the service. Valid values:
            /// 
            /// *   **PREPAY** (default): subscription.
            /// *   **POSTPAY**: pay-as-you-go.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The commodity code of the service in Alibaba Cloud Marketplace.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The commodity modules.
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<string> Components { get; set; }

            /// <summary>
            /// The configuration metadata related to Lingxiao.
            /// </summary>
            [NameInMap("CssMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityCssMetadata CssMetadata { get; set; }
            public class GetServiceResponseBodyCommodityCssMetadata : TeaModel {
                /// <summary>
                /// The mapping information about the billing items.
                /// </summary>
                [NameInMap("ComponentsMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataComponentsMappings> ComponentsMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataComponentsMappings : TeaModel {
                    /// <summary>
                    /// The mappings.
                    /// </summary>
                    [NameInMap("Mappings")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Mappings { get; set; }

                    /// <summary>
                    /// The template name.
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

                /// <summary>
                /// Metering item configuration information.
                /// </summary>
                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos : TeaModel {
                    /// <summary>
                    /// The ID of the entity.
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// Name of a measurement indicator.
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// Custom PromQL.
                    /// </summary>
                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    /// <summary>
                    /// Measurement indicators.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The binding relationship between package and measurement dimension.
                /// </summary>
                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings : TeaModel {
                    /// <summary>
                    /// The ID of the entity.
                    /// </summary>
                    [NameInMap("EntityIds")]
                    [Validation(Required=false)]
                    public string EntityIds { get; set; }

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
            /// The metadata of Alibaba Cloud Marketplace.
            /// </summary>
            [NameInMap("MarketplaceMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityMarketplaceMetadata MarketplaceMetadata { get; set; }
            public class GetServiceResponseBodyCommodityMarketplaceMetadata : TeaModel {
                /// <summary>
                /// The configurations of the billable items.
                /// </summary>
                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos : TeaModel {
                    /// <summary>
                    /// The ID of the billable item.
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// The metric name.
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// The custom prometheus statement.
                    /// </summary>
                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    /// <summary>
                    /// The metric.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The billable items that are associated with the package.
                /// </summary>
                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings : TeaModel {
                    /// <summary>
                    /// The ID of the billable item.
                    /// </summary>
                    [NameInMap("EntityIds")]
                    [Validation(Required=false)]
                    public string EntityIds { get; set; }

                    /// <summary>
                    /// The name of the specification package.
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
                /// The mappings between the service specifications and the template or package.
                /// </summary>
                [NameInMap("SpecificationMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings> SpecificationMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings : TeaModel {
                    /// <summary>
                    /// The specification code of the service in Alibaba Cloud Marketplace.
                    /// </summary>
                    [NameInMap("SpecificationCode")]
                    [Validation(Required=false)]
                    public string SpecificationCode { get; set; }

                    /// <summary>
                    /// The name of the specification package.
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

                    /// <summary>
                    /// The trial policy. Valid values:
                    /// 
                    /// *   Trial: Trials are supported.
                    /// *   NotTrial: Trials are not supported.
                    /// </summary>
                    [NameInMap("TrialType")]
                    [Validation(Required=false)]
                    public string TrialType { get; set; }

                }

            }

            /// <summary>
            /// The information about the billable item.
            /// </summary>
            [NameInMap("MeteringEntities")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommodityMeteringEntities> MeteringEntities { get; set; }
            public class GetServiceResponseBodyCommodityMeteringEntities : TeaModel {
                /// <summary>
                /// The ID of the billable item.
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// The name of the billable item.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The configuration metadata related to Saas Boost.
            /// </summary>
            [NameInMap("SaasBoostMetadata")]
            [Validation(Required=false)]
            public string SaasBoostMetadata { get; set; }

            /// <summary>
            /// The specification details of the service in Alibaba Cloud Marketplace.
            /// </summary>
            [NameInMap("Specifications")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommoditySpecifications> Specifications { get; set; }
            public class GetServiceResponseBodyCommoditySpecifications : TeaModel {
                /// <summary>
                /// The commodity code.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The specification name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The subscription duration. Unit: week or year.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// The service type. Valid values:
            /// 
            /// *   marketplace: Alibaba Cloud Marketplace.
            /// *   Css: Lingxiao.
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
        /// The binding configurations of the commodity module.
        /// </summary>
        [NameInMap("CrossRegionConnectionStatus")]
        [Validation(Required=false)]
        public string CrossRegionConnectionStatus { get; set; }

        /// <summary>
        /// The validity period of the default license. Unit: day. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("DefaultLicenseDays")]
        [Validation(Required=false)]
        public long? DefaultLicenseDays { get; set; }

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
        /// The report source.
        /// </summary>
        [NameInMap("EntitySource")]
        [Validation(Required=false)]
        public Dictionary<string, string> EntitySource { get; set; }

        /// <summary>
        /// Indicates whether the hosted O\\&M feature is enabled for the service. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  This parameter is returned if you set **ServiceType** to **private**.
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
        /// The source for which fees are generated. Valid values:
        /// 
        /// *   None: No fees are generated.
        /// *   Marketplace: Fees are generated for Alibaba Cloud Marketplace.
        /// *   Custom: The custom fees.
        /// </summary>
        [NameInMap("PayFromType")]
        [Validation(Required=false)]
        public string PayFromType { get; set; }

        /// <summary>
        /// The billing method of the service. Valid values:
        /// 
        /// *   Permanent: Once you purchase the service, you can use it permanently.
        /// *   Subscription: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a subscription basis.
        /// *   PayAsYouGo: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a pay-as-you-go basis.
        /// *   CustomFixTime: You are charged for the service based on a custom duration fixed by the service provider.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The permissions on the service. Valid values:
        /// 
        /// *   Deployable: Permissions to deploy the service.
        /// *   Accessible: Permissions to access the service.
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// The policy name. The name can be up to 128 characters in length. Separate multiple names with commas (,). Only hosted O\\&M policies are supported.
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        /// <summary>
        /// The deployment progress of the service instance. Unit: percentage.
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// The time when the service was published.
        /// </summary>
        [NameInMap("PublishTime")]
        [Validation(Required=false)]
        public string PublishTime { get; set; }

        /// <summary>
        /// The registration ID.
        /// </summary>
        [NameInMap("RegistrationId")]
        [Validation(Required=false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the distribution is supported. Valid values:
        /// 
        /// *   false
        /// *   true
        /// </summary>
        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The URL of the service audit file.
        /// </summary>
        [NameInMap("ServiceAuditDocumentUrl")]
        [Validation(Required=false)]
        public string ServiceAuditDocumentUrl { get; set; }

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
        /// The URL of the service documentation.
        /// </summary>
        [NameInMap("ServiceDocUrl")]
        [Validation(Required=false)]
        public string ServiceDocUrl { get; set; }

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
        public List<GetServiceResponseBodyServiceInfos> ServiceInfos { get; set; }
        public class GetServiceResponseBodyServiceInfos : TeaModel {
            /// <summary>
            /// The agreement information about the service.
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosAgreements> Agreements { get; set; }
            public class GetServiceResponseBodyServiceInfosAgreements : TeaModel {
                /// <summary>
                /// The agreement name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The agreement URL.
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
        /// The URL of the service page.
        /// </summary>
        [NameInMap("ServiceProductUrl")]
        [Validation(Required=false)]
        public string ServiceProductUrl { get; set; }

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
        /// *   Public: All users can go to the URL to create a service instance or a trial service instance.
        /// *   Restricted: Only users in the whitelist can go to the URL to create a service instance or a trial service instance.
        /// *   OnlyFormalRestricted: Only users in the whitelist can go to the URL to create a service instance.
        /// *   OnlyTrailRestricted: Only users in the whitelist can go to the URL to create a trial service instance.
        /// *   Hidden: Users not in the whitelist cannot see the service details page when they go to the URL and cannot request deployment permissions.
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// The share status of the instance.
        /// 
        /// > This parameter is discontinued.
        /// </summary>
        [NameInMap("ShareTypeStatus")]
        [Validation(Required=false)]
        public string ShareTypeStatus { get; set; }

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
        /// The statistics.
        /// </summary>
        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public GetServiceResponseBodyStatistic Statistic { get; set; }
        public class GetServiceResponseBodyStatistic : TeaModel {
            /// <summary>
            /// The total number of service instances that belong to the service. The service instances that are deleted are counted.
            /// </summary>
            [NameInMap("AccumulativeInstanceCount")]
            [Validation(Required=false)]
            public int? AccumulativeInstanceCount { get; set; }

            /// <summary>
            /// The total amount consumed for trial service instances. Unit: CNY.
            /// </summary>
            [NameInMap("AccumulativePocAmount")]
            [Validation(Required=false)]
            public double? AccumulativePocAmount { get; set; }

            /// <summary>
            /// The total number of users who use the service. The historical users are counted.
            /// </summary>
            [NameInMap("AccumulativeUserCount")]
            [Validation(Required=false)]
            public int? AccumulativeUserCount { get; set; }

            /// <summary>
            /// The average amount consumed for trial service instances per instance. Unit: CNY.
            /// </summary>
            [NameInMap("AveragePocAmount")]
            [Validation(Required=false)]
            public double? AveragePocAmount { get; set; }

            /// <summary>
            /// The average duration for which trial service instances are in use. Unit: Hour.
            /// </summary>
            [NameInMap("AveragePocDuration")]
            [Validation(Required=false)]
            public double? AveragePocDuration { get; set; }

            /// <summary>
            /// The average amount consumed for trial service instances per a period of time. Unit: CNY.
            /// </summary>
            [NameInMap("AveragePocUnitAmount")]
            [Validation(Required=false)]
            public double? AveragePocUnitAmount { get; set; }

            /// <summary>
            /// The number of online service instances. It means the number of service instances that are successfully deployed.
            /// </summary>
            [NameInMap("DeployedServiceInstanceCount")]
            [Validation(Required=false)]
            public int? DeployedServiceInstanceCount { get; set; }

            /// <summary>
            /// The number of online users. It means the number of users who successfully deployed the service instances.
            /// </summary>
            [NameInMap("DeployedUserCount")]
            [Validation(Required=false)]
            public int? DeployedUserCount { get; set; }

            /// <summary>
            /// The number of service applications that are in the Submitted state.
            /// </summary>
            [NameInMap("SubmittedUsageCount")]
            [Validation(Required=false)]
            public int? SubmittedUsageCount { get; set; }

        }

        /// <summary>
        /// The status of the service. Valid values:
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
        /// The description of the service status.
        /// </summary>
        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

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
        public List<GetServiceResponseBodyTags> Tags { get; set; }
        public class GetServiceResponseBodyTags : TeaModel {
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
        /// The type of the tenant. Valid values:
        /// 
        /// *   SingleTenant
        /// *   MultiTenant
        /// </summary>
        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// The status of the test. Valid values:
        /// 
        /// *   `CONFIG_IS_NULL`: No test configurations exist.
        /// *   `SERVICE_TEST_SUCCEED`: The service passed the test.
        /// *   `SERVICE_TSET_DOING`: The service does not pass the test.
        /// </summary>
        [NameInMap("TestStatus")]
        [Validation(Required=false)]
        public string TestStatus { get; set; }

        /// <summary>
        /// The trial duration. Unit: day. The maximum trial duration cannot exceed 30 days.
        /// </summary>
        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public long? TrialDuration { get; set; }

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
        /// The time when the service was updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The metadata about the upgrade.
        /// </summary>
        [NameInMap("UpgradeMetadata")]
        [Validation(Required=false)]
        public string UpgradeMetadata { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// The version name.
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

        /// <summary>
        /// The ID of the virtual Internet service.
        /// </summary>
        [NameInMap("VirtualInternetServiceId")]
        [Validation(Required=false)]
        public string VirtualInternetServiceId { get; set; }

    }

}
