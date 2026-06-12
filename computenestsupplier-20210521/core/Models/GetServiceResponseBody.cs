// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert configurations of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;TemplateUrl&quot;: &quot;<a href="http://template.file.url">http://template.file.url</a>&quot;,
        ///   // Application group level alarm metadata
        ///   &quot;ApplicationGroups&quot;: [
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup1&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url1&quot;
        ///     },
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup2&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url2&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The approval type of the service usage application.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Manual: The application is manually approved.</para>
        /// </description></item>
        /// <item><description><para>AutoPass: The application is automatically approved.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// <para>The information about the build service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;RepoUrl&quot;: &quot;<a href="https://github.com/user/repo.git">https://github.com/user/repo.git</a>&quot;, &quot;Brancn&quot;: &quot;main&quot;}</para>
        /// </summary>
        [NameInMap("BuildInfo")]
        [Validation(Required=false)]
        public string BuildInfo { get; set; }

        /// <summary>
        /// <para>The parameters of the build service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;ServiceTemplateId&quot;: &quot;st-xxxxx&quot;}</para>
        /// </summary>
        [NameInMap("BuildParameters")]
        [Validation(Required=false)]
        public string BuildParameters { get; set; }

        /// <summary>
        /// <para>The service category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DevOps</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string Categories { get; set; }

        /// <summary>
        /// <para>The commodity specifications.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public GetServiceResponseBodyCommodity Commodity { get; set; }
        public class GetServiceResponseBodyCommodity : TeaModel {
            /// <summary>
            /// <para>The billing method.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PREPAY</b> (default): subscription.</para>
            /// </description></item>
            /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code of Alibaba Cloud Marketplace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmjj00xxxx</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity modules.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<string> Components { get; set; }

            /// <summary>
            /// <para>The configuration metadata of Lingxiao.</para>
            /// </summary>
            [NameInMap("CssMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityCssMetadata CssMetadata { get; set; }
            public class GetServiceResponseBodyCommodityCssMetadata : TeaModel {
                /// <summary>
                /// <para>The billing item mapping.</para>
                /// </summary>
                [NameInMap("ComponentsMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataComponentsMappings> ComponentsMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataComponentsMappings : TeaModel {
                    /// <summary>
                    /// <para>The mapping.</para>
                    /// </summary>
                    [NameInMap("Mappings")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Mappings { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>模板1</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

                /// <summary>
                /// <para>The configuration information of the metering item.</para>
                /// </summary>
                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos : TeaModel {
                    /// <summary>
                    /// <para>The metering item ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmgj0048****-Frequency-1</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// <para>The metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AvgMemory</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The custom Prometheus statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>avg_over_time(count(kube_pod_info{namespace=\&quot;default\&quot;})[1h:1m])</para>
                    /// </summary>
                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    /// <summary>
                    /// <para>The metering metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ComputeNestPrometheus</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The binding relationship between the package and the metering dimension.</para>
                /// </summary>
                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings : TeaModel {
                    /// <summary>
                    /// <para>The metering item ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmgj0015****-Frequency-1</para>
                    /// </summary>
                    [NameInMap("EntityIds")]
                    [Validation(Required=false)]
                    public string EntityIds { get; set; }

                    /// <summary>
                    /// <para>The package name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>按量付费套餐</para>
                    /// </summary>
                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>模板1</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

            }

            /// <summary>
            /// <para>The metadata of Alibaba Cloud Marketplace.</para>
            /// </summary>
            [NameInMap("MarketplaceMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityMarketplaceMetadata MarketplaceMetadata { get; set; }
            public class GetServiceResponseBodyCommodityMarketplaceMetadata : TeaModel {
                /// <summary>
                /// <para>The configuration information of the metering item.</para>
                /// </summary>
                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos : TeaModel {
                    /// <summary>
                    /// <para>The metering item ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmgj1596****-NetworkOut-2</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// <para>The name of the metering metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NetworkLantency</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The custom Prometheus statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>avg_over_time(count(kube_pod_info{namespace=\&quot;default\&quot;})[1h:1m])</para>
                    /// </summary>
                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    /// <summary>
                    /// <para>The metering metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AvgPod</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The binding relationship between the package and the metering dimension.</para>
                /// </summary>
                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings : TeaModel {
                    /// <summary>
                    /// <para>The metering item ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmgj1596****-NetworkOut-2</para>
                    /// </summary>
                    [NameInMap("EntityIds")]
                    [Validation(Required=false)]
                    public string EntityIds { get; set; }

                    /// <summary>
                    /// <para>The package name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Pay-as-you-go plan</para>
                    /// </summary>
                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>模板1</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

                /// <summary>
                /// <para>The relationship between commodity specifications and templates or packages.</para>
                /// </summary>
                [NameInMap("SpecificationMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings> SpecificationMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings : TeaModel {
                    /// <summary>
                    /// <para>The commodity specification code of Alibaba Cloud Marketplace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmjj00****</para>
                    /// </summary>
                    [NameInMap("SpecificationCode")]
                    [Validation(Required=false)]
                    public string SpecificationCode { get; set; }

                    /// <summary>
                    /// <para>The package name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Pay-as-you-go</para>
                    /// </summary>
                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template 1</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                    /// <summary>
                    /// <para>The trial type.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>Trial: Trial is supported.</para>
                    /// </description></item>
                    /// <item><description><para>NotTrial: Trial is not supported.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NotTrial</para>
                    /// </summary>
                    [NameInMap("TrialType")]
                    [Validation(Required=false)]
                    public string TrialType { get; set; }

                }

            }

            /// <summary>
            /// <para>The metering information.</para>
            /// </summary>
            [NameInMap("MeteringEntities")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommodityMeteringEntities> MeteringEntities { get; set; }
            public class GetServiceResponseBodyCommodityMeteringEntities : TeaModel {
                /// <summary>
                /// <para>The metering item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmgj5682****-NetworkOut</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The name of the metering item property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spring-boot-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The configuration metadata of SaaS Boost.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;Enabled&quot;:false
            ///     //Public access URL
            ///     &quot;PublicAccessUrl&quot;:&quot;<a href="https://example.com">https://example.com</a>&quot;
            /// }</para>
            /// </summary>
            [NameInMap("SaasBoostMetadata")]
            [Validation(Required=false)]
            public string SaasBoostMetadata { get; set; }

            /// <summary>
            /// <para>The details of the Alibaba Cloud Marketplace specifications.</para>
            /// </summary>
            [NameInMap("Specifications")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommoditySpecifications> Specifications { get; set; }
            public class GetServiceResponseBodyCommoditySpecifications : TeaModel {
                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmjj00****</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The specification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>specifications1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The purchasable duration. Unit: week or year.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Marketplace: Alibaba Cloud Marketplace.</para>
            /// </description></item>
            /// <item><description><para>Css: Lingxiao.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Marketplace</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The compliance check metadata.</para>
        /// </summary>
        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public GetServiceResponseBodyComplianceMetadata ComplianceMetadata { get; set; }
        public class GetServiceResponseBodyComplianceMetadata : TeaModel {
            /// <summary>
            /// <para>The selected compliance package.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>The time when the service was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The binding relationship of the commodity module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>componesConfigs</para>
        /// </summary>
        [NameInMap("CrossRegionConnectionStatus")]
        [Validation(Required=false)]
        public string CrossRegionConnectionStatus { get; set; }

        /// <summary>
        /// <para>The information about the service deployment configuration.</para>
        /// <para>The information varies based on the deployment type. Different deployment types use different data formats. Therefore, the information is stored as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;TemplateConfigs\&quot;:[{\&quot;Name\&quot;:\&quot;模板1\&quot;,\&quot;Url\&quot;:\&quot;oss://computenest-test/template&quot; 
        ///             + &quot;.json?RegionId=cn-beijing\&quot;,\&quot;PredefinedParameters\&quot;:[{\&quot;Name\&quot;:\&quot;低配版\&quot;,&quot; 
        ///             + &quot;\&quot;Parameters\&quot;:{\&quot;InstanceType\&quot;:\&quot;ecs.g5.large\&quot;,\&quot;DataDiskSize\&quot;:40}},{\&quot;Name\&quot;:\&quot;高配版\&quot;,&quot; 
        ///             + &quot;\&quot;Parameters\&quot;:{\&quot;InstanceType\&quot;:\&quot;ecs.g5.large\&quot;,\&quot;DataDiskSize\&quot;:200}}]}]}</para>
        /// </summary>
        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        /// <summary>
        /// <para>The deployment type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ros: The service is deployed using ROS.</para>
        /// </description></item>
        /// <item><description><para>terraform: The service is deployed using Terraform.</para>
        /// </description></item>
        /// <item><description><para>spi: The service is deployed by calling SPI.</para>
        /// </description></item>
        /// <item><description><para>operation: The service is deployed using Alibaba Cloud Managed Services.</para>
        /// </description></item>
        /// <item><description><para>container: The service is deployed using containers.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The duration of the Alibaba Cloud Managed Services. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>259200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The source of the reported data.</para>
        /// </summary>
        [NameInMap("EntitySource")]
        [Validation(Required=false)]
        public Dictionary<string, string> EntitySource { get; set; }

        /// <summary>
        /// <para>Indicates whether Alibaba Cloud Managed Services is enabled.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSupportOperated")]
        [Validation(Required=false)]
        public bool? IsSupportOperated { get; set; }

        /// <summary>
        /// <para>The license metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PayType\&quot;:\&quot;CustomFixTime\&quot;,\&quot;DefaultLicenseDays\&quot;:7,\&quot;CustomMetadata\&quot;:[{\&quot;TemplateName\&quot;:\&quot; template1\&quot;,\&quot;SpecificationName\&quot;:\&quot;bandwith-0\&quot;,\&quot;CustomData\&quot;:\&quot;1\&quot;}]}</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>The application log configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Logstores&quot;: [
        ///     {
        ///     &quot;LogstoreName&quot;: &quot;access-log&quot;,
        ///   &quot;LogPath&quot;: &quot;/home/admin/app/logs&quot;, # Not required for containers. Configure in YAML
        ///   &quot;FilePattern&quot;: &quot;access.log*&quot; # Not required for containers. Configure in YAML
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// <para>The configurations of Alibaba Cloud Managed Services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;New_Vpc_Ack_And_Jumpserver\&quot;:{}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// <para>The payment source.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>None: The service is free of charge.</para>
        /// </description></item>
        /// <item><description><para>Marketplace: The service is paid on Alibaba Cloud Marketplace.</para>
        /// </description></item>
        /// <item><description><para>Custom: The service is paid using a custom payment method.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("PayFromType")]
        [Validation(Required=false)]
        public string PayFromType { get; set; }

        /// <summary>
        /// <para>The permission type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Deployable: The service can be deployed.</para>
        /// </description></item>
        /// <item><description><para>Accessible: The service can be accessed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deployable</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The policy names.</para>
        /// <para>A policy name can be up to 128 characters in length. Multiple policy names are separated by commas (,). Only policies related to Alibaba Cloud Managed Services are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policyName1, policyName2</para>
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        /// <summary>
        /// <para>The deployment progress of the service instance. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <para>The time when the service was published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-21T00:00:00Z</para>
        /// </summary>
        [NameInMap("PublishTime")]
        [Validation(Required=false)]
        public string PublishTime { get; set; }

        /// <summary>
        /// <para>The registration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sr-1b4aabc1c9eb4109****</para>
        /// </summary>
        [NameInMap("RegistrationId")]
        [Validation(Required=false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AC8E73E-88DE-52C2-A29B-531FC13A5604</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the service can be distributed.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: The service cannot be distributed.</para>
        /// </description></item>
        /// <item><description><para>true: The service can be distributed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2jfvb7b****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The service key. It is used for digital signature encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cfc5d4649c54216****</para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The URL of the service review file.</para>
        /// </summary>
        [NameInMap("ServiceAuditDocumentUrl")]
        [Validation(Required=false)]
        public string ServiceAuditDocumentUrl { get; set; }

        /// <summary>
        /// <para>Indicates whether the service is discoverable.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>INVISIBLE: The service is not discoverable.</para>
        /// </description></item>
        /// <item><description><para>DISCOVERABLE: The service is discoverable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DISCOVERABLE</para>
        /// </summary>
        [NameInMap("ServiceDiscoverable")]
        [Validation(Required=false)]
        public string ServiceDiscoverable { get; set; }

        /// <summary>
        /// <para>The service document information.</para>
        /// </summary>
        [NameInMap("ServiceDocumentInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceDocumentInfos> ServiceDocumentInfos { get; set; }
        public class GetServiceResponseBodyServiceDocumentInfos : TeaModel {
            /// <summary>
            /// <para>The URL of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://doc.com">http://doc.com</a></para>
            /// </summary>
            [NameInMap("DocumentUrl")]
            [Validation(Required=false)]
            public string DocumentUrl { get; set; }

            /// <summary>
            /// <para>The language of the service configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>zh-CN: Chinese.</para>
            /// </description></item>
            /// <item><description><para>en-US: English.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模板1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-ca83ff3cb6b14dbc****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service information.</para>
        /// </summary>
        [NameInMap("ServiceInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceInfos> ServiceInfos { get; set; }
        public class GetServiceResponseBodyServiceInfos : TeaModel {
            /// <summary>
            /// <para>The information about the service agreement.</para>
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosAgreements> Agreements { get; set; }
            public class GetServiceResponseBodyServiceInfosAgreements : TeaModel {
                /// <summary>
                /// <para>The agreement name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The URL of the agreement.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com/xxxxxxxx.html">https://aliyun.com/xxxxxxxx.html</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The URL of the service icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f35660****.png">https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f35660****.png</a></para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The language of the service configuration.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>zh-CN: Chinese.</para>
            /// </description></item>
            /// <item><description><para>en-US: English.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            /// <summary>
            /// <para>The URL of the detailed description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
            /// </summary>
            [NameInMap("LongDescriptionUrl")]
            [Validation(Required=false)]
            public string LongDescriptionUrl { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Database B</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The summary of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B is an open-source distributed relational database independently designed and developed by Company A.</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The information about the software used in the service.</para>
            /// </summary>
            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosSoftwares> Softwares { get; set; }
            public class GetServiceResponseBodyServiceInfosSoftwares : TeaModel {
                /// <summary>
                /// <para>The software name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The software version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The multi-language configurations of the service.</para>
        /// </summary>
        [NameInMap("ServiceLocaleConfigs")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceLocaleConfigs> ServiceLocaleConfigs { get; set; }
        public class GetServiceResponseBodyServiceLocaleConfigs : TeaModel {
            /// <summary>
            /// <para>The English value of the business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Name</para>
            /// </summary>
            [NameInMap("EnValue")]
            [Validation(Required=false)]
            public string EnValue { get; set; }

            /// <summary>
            /// <para>The original value of the business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Name</para>
            /// </summary>
            [NameInMap("OriginalValue")]
            [Validation(Required=false)]
            public string OriginalValue { get; set; }

            /// <summary>
            /// <para>The Chinese value of the business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务名称</para>
            /// </summary>
            [NameInMap("ZhValue")]
            [Validation(Required=false)]
            public string ZhValue { get; set; }

        }

        /// <summary>
        /// <para>The URL of the product page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example2.com">http://example2.com</a></para>
        /// </summary>
        [NameInMap("ServiceProductUrl")]
        [Validation(Required=false)]
        public string ServiceProductUrl { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>private: The service is deployed in the user\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>managed: The service is deployed in the service provider\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>operation: The service is an Alibaba Cloud Managed Service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The sharing type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Public: The service is public. Formal and trial deployments are not restricted.</para>
        /// </description></item>
        /// <item><description><para>Restricted: The service is restricted. Formal and trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyFormalRestricted: Only formal deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyTrailRestricted: Only trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>Hidden: The service is hidden. It is not visible and you cannot apply for deployment permissions.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The sharing status of the service. &gt;Notice: This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This parameter is deprecated.</para>
        /// </summary>
        [NameInMap("ShareTypeStatus")]
        [Validation(Required=false)]
        public string ShareTypeStatus { get; set; }

        /// <summary>
        /// <para>The ID of the source service for distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-70a3b15bb6264315****</para>
        /// </summary>
        [NameInMap("SourceServiceId")]
        [Validation(Required=false)]
        public string SourceServiceId { get; set; }

        /// <summary>
        /// <para>The version of the source service for distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SourceServiceVersion")]
        [Validation(Required=false)]
        public string SourceServiceVersion { get; set; }

        /// <summary>
        /// <para>The name of the service provider of the source service for distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SourceSupplier</para>
        /// </summary>
        [NameInMap("SourceSupplierName")]
        [Validation(Required=false)]
        public string SourceSupplierName { get; set; }

        /// <summary>
        /// <para>The statistics information.</para>
        /// </summary>
        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public GetServiceResponseBodyStatistic Statistic { get; set; }
        public class GetServiceResponseBodyStatistic : TeaModel {
            /// <summary>
            /// <para>The total number of service instances. This includes deleted instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75</para>
            /// </summary>
            [NameInMap("AccumulativeInstanceCount")]
            [Validation(Required=false)]
            public int? AccumulativeInstanceCount { get; set; }

            /// <summary>
            /// <para>The total consumption amount of the trial service. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80.35</para>
            /// </summary>
            [NameInMap("AccumulativePocAmount")]
            [Validation(Required=false)]
            public double? AccumulativePocAmount { get; set; }

            /// <summary>
            /// <para>The total number of users. This includes historical users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AccumulativeUserCount")]
            [Validation(Required=false)]
            public int? AccumulativeUserCount { get; set; }

            /// <summary>
            /// <para>The average consumption amount of a trial service instance. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40.17</para>
            /// </summary>
            [NameInMap("AveragePocAmount")]
            [Validation(Required=false)]
            public double? AveragePocAmount { get; set; }

            /// <summary>
            /// <para>The average trial duration of a service instance. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AveragePocDuration")]
            [Validation(Required=false)]
            public double? AveragePocDuration { get; set; }

            /// <summary>
            /// <para>The average consumption amount of a trial service instance per unit of time. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167.9</para>
            /// </summary>
            [NameInMap("AveragePocUnitAmount")]
            [Validation(Required=false)]
            public double? AveragePocUnitAmount { get; set; }

            /// <summary>
            /// <para>The number of online service instances. This indicates the number of service instances that are successfully deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DeployedServiceInstanceCount")]
            [Validation(Required=false)]
            public int? DeployedServiceInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of online users. This indicates the number of users who have successfully deployed service instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DeployedUserCount")]
            [Validation(Required=false)]
            public int? DeployedUserCount { get; set; }

            /// <summary>
            /// <para>The number of service applications that are in the Submitted state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SubmittedUsageCount")]
            [Validation(Required=false)]
            public int? SubmittedUsageCount { get; set; }

        }

        /// <summary>
        /// <para>The service status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Draft: The service is in the draft state.</para>
        /// </description></item>
        /// <item><description><para>Submitted: The service is submitted for review. You cannot modify the service.</para>
        /// </description></item>
        /// <item><description><para>Approved: The service is approved. You cannot modify the service, but you can publish the service.</para>
        /// </description></item>
        /// <item><description><para>Launching: The service is being published.</para>
        /// </description></item>
        /// <item><description><para>Online: The service is published.</para>
        /// </description></item>
        /// <item><description><para>Offline: The service is unpublished.</para>
        /// </description></item>
        /// <item><description><para>Beta: The service is in beta.</para>
        /// </description></item>
        /// <item><description><para>Creating: The service is being created.</para>
        /// </description></item>
        /// <item><description><para>CreateFailed: The service failed to be created.</para>
        /// </description></item>
        /// <item><description><para>Updating: The service is being updated.</para>
        /// </description></item>
        /// <item><description><para>UpdateFailed: The service failed to be updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The description of the service status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deploy successfully</para>
        /// </summary>
        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// <para>The name of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Company A</para>
        /// </summary>
        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// <para>The URL of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com">http://example.com</a></para>
        /// </summary>
        [NameInMap("SupplierUrl")]
        [Validation(Required=false)]
        public string SupplierUrl { get; set; }

        /// <summary>
        /// <para>The contact information of the service provider.</para>
        /// </summary>
        [NameInMap("SupportContacts")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodySupportContacts> SupportContacts { get; set; }
        public class GetServiceResponseBodySupportContacts : TeaModel {
            /// <summary>
            /// <para>The type of the contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Email</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:supplier@test.com">supplier@test.com</a></para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The service tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyTags> Tags { get; set; }
        public class GetServiceResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tenant type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SingleTenant: single-tenant.</para>
        /// </description></item>
        /// <item><description><para>MultiTenant: multitenancy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SingleTenant</para>
        /// </summary>
        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// <para>The test status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CONFIG_IS_NULL: The test configuration does not exist.</para>
        /// </description></item>
        /// <item><description><para>SERVICE_TEST_SUCCEED: The service passed the test.</para>
        /// </description></item>
        /// <item><description><para>SERVICE_TSET_DOING: The service has not passed the test.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SERVICE_TEST_SUCCEED</para>
        /// </summary>
        [NameInMap("TestStatus")]
        [Validation(Required=false)]
        public string TestStatus { get; set; }

        /// <summary>
        /// <para>The trial duration. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public long? TrialDuration { get; set; }

        /// <summary>
        /// <para>The trial type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Trial: The service supports trial.</para>
        /// </description></item>
        /// <item><description><para>NotTrial: The service does not support trial.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Trial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

        /// <summary>
        /// <para>The time when the service was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The upgrade metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;SupportRollback\&quot;:true,\&quot;SupportUpgradeFromVersions\&quot;:[],\&quot;UpgradeComponents\&quot;:[\&quot;Configuration\&quot;]}</para>
        /// </summary>
        [NameInMap("UpgradeMetadata")]
        [Validation(Required=false)]
        public string UpgradeMetadata { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

        /// <summary>
        /// <para>Indicates whether the service is a virtual Internet service.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VirtualInternetService")]
        [Validation(Required=false)]
        public string VirtualInternetService { get; set; }

        /// <summary>
        /// <para>The virtual Internet service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-70a3b15bb6264345****</para>
        /// </summary>
        [NameInMap("VirtualInternetServiceId")]
        [Validation(Required=false)]
        public string VirtualInternetServiceId { get; set; }

    }

}
