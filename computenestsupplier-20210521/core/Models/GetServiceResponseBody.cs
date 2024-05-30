// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceResponseBody : TeaModel {
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        [NameInMap("BuildInfo")]
        [Validation(Required=false)]
        public string BuildInfo { get; set; }

        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string Categories { get; set; }

        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public GetServiceResponseBodyCommodity Commodity { get; set; }
        public class GetServiceResponseBodyCommodity : TeaModel {
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<string> Components { get; set; }

            [NameInMap("CssMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityCssMetadata CssMetadata { get; set; }
            public class GetServiceResponseBodyCommodityCssMetadata : TeaModel {
                [NameInMap("ComponentsMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataComponentsMappings> ComponentsMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataComponentsMappings : TeaModel {
                    [NameInMap("Mappings")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Mappings { get; set; }

                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos : TeaModel {
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings : TeaModel {
                    [NameInMap("EntityIds")]
                    [Validation(Required=false)]
                    public string EntityIds { get; set; }

                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

            }

            [NameInMap("MarketplaceMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityMarketplaceMetadata MarketplaceMetadata { get; set; }
            public class GetServiceResponseBodyCommodityMarketplaceMetadata : TeaModel {
                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos : TeaModel {
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings : TeaModel {
                    [NameInMap("EntityIds")]
                    [Validation(Required=false)]
                    public string EntityIds { get; set; }

                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

                [NameInMap("SpecificationMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings> SpecificationMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings : TeaModel {
                    [NameInMap("SpecificationCode")]
                    [Validation(Required=false)]
                    public string SpecificationCode { get; set; }

                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                    [NameInMap("TrialType")]
                    [Validation(Required=false)]
                    public string TrialType { get; set; }

                }

            }

            [NameInMap("MeteringEntities")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommodityMeteringEntities> MeteringEntities { get; set; }
            public class GetServiceResponseBodyCommodityMeteringEntities : TeaModel {
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("SaasBoostMetadata")]
            [Validation(Required=false)]
            public string SaasBoostMetadata { get; set; }

            [NameInMap("Specifications")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommoditySpecifications> Specifications { get; set; }
            public class GetServiceResponseBodyCommoditySpecifications : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CrossRegionConnectionStatus")]
        [Validation(Required=false)]
        public string CrossRegionConnectionStatus { get; set; }

        [NameInMap("DefaultLicenseDays")]
        [Validation(Required=false)]
        public long? DefaultLicenseDays { get; set; }

        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("EntitySource")]
        [Validation(Required=false)]
        public Dictionary<string, string> EntitySource { get; set; }

        [NameInMap("IsSupportOperated")]
        [Validation(Required=false)]
        public bool? IsSupportOperated { get; set; }

        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        [NameInMap("PayFromType")]
        [Validation(Required=false)]
        public string PayFromType { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        [NameInMap("PublishTime")]
        [Validation(Required=false)]
        public string PublishTime { get; set; }

        [NameInMap("RegistrationId")]
        [Validation(Required=false)]
        public string RegistrationId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ServiceAuditDocumentUrl")]
        [Validation(Required=false)]
        public string ServiceAuditDocumentUrl { get; set; }

        [NameInMap("ServiceDiscoverable")]
        [Validation(Required=false)]
        public string ServiceDiscoverable { get; set; }

        [NameInMap("ServiceDocUrl")]
        [Validation(Required=false)]
        public string ServiceDocUrl { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceInfos> ServiceInfos { get; set; }
        public class GetServiceResponseBodyServiceInfos : TeaModel {
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosAgreements> Agreements { get; set; }
            public class GetServiceResponseBodyServiceInfosAgreements : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            [NameInMap("LongDescriptionUrl")]
            [Validation(Required=false)]
            public string LongDescriptionUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

        }

        [NameInMap("ServiceProductUrl")]
        [Validation(Required=false)]
        public string ServiceProductUrl { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        [NameInMap("ShareTypeStatus")]
        [Validation(Required=false)]
        public string ShareTypeStatus { get; set; }

        [NameInMap("SourceServiceId")]
        [Validation(Required=false)]
        public string SourceServiceId { get; set; }

        [NameInMap("SourceServiceVersion")]
        [Validation(Required=false)]
        public string SourceServiceVersion { get; set; }

        [NameInMap("SourceSupplierName")]
        [Validation(Required=false)]
        public string SourceSupplierName { get; set; }

        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public GetServiceResponseBodyStatistic Statistic { get; set; }
        public class GetServiceResponseBodyStatistic : TeaModel {
            [NameInMap("AccumulativeInstanceCount")]
            [Validation(Required=false)]
            public int? AccumulativeInstanceCount { get; set; }

            [NameInMap("AccumulativePocAmount")]
            [Validation(Required=false)]
            public double? AccumulativePocAmount { get; set; }

            [NameInMap("AccumulativeUserCount")]
            [Validation(Required=false)]
            public int? AccumulativeUserCount { get; set; }

            [NameInMap("AveragePocAmount")]
            [Validation(Required=false)]
            public double? AveragePocAmount { get; set; }

            [NameInMap("AveragePocDuration")]
            [Validation(Required=false)]
            public double? AveragePocDuration { get; set; }

            [NameInMap("AveragePocUnitAmount")]
            [Validation(Required=false)]
            public double? AveragePocUnitAmount { get; set; }

            [NameInMap("DeployedServiceInstanceCount")]
            [Validation(Required=false)]
            public int? DeployedServiceInstanceCount { get; set; }

            [NameInMap("DeployedUserCount")]
            [Validation(Required=false)]
            public int? DeployedUserCount { get; set; }

            [NameInMap("SubmittedUsageCount")]
            [Validation(Required=false)]
            public int? SubmittedUsageCount { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        [NameInMap("SupplierUrl")]
        [Validation(Required=false)]
        public string SupplierUrl { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyTags> Tags { get; set; }
        public class GetServiceResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        [NameInMap("TestStatus")]
        [Validation(Required=false)]
        public string TestStatus { get; set; }

        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public long? TrialDuration { get; set; }

        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UpgradeMetadata")]
        [Validation(Required=false)]
        public string UpgradeMetadata { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

        [NameInMap("VirtualInternetService")]
        [Validation(Required=false)]
        public string VirtualInternetService { get; set; }

        [NameInMap("VirtualInternetServiceId")]
        [Validation(Required=false)]
        public string VirtualInternetServiceId { get; set; }

    }

}
