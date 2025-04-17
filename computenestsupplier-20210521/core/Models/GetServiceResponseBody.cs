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
        /// <remarks>
        /// <para> This parameter takes effect only when you specify an alert policy for <b>PolicyNames</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;TemplateUrl&quot;: &quot;<a href="http://template.file.url">http://template.file.url</a>&quot;,
        ///   // 应用分组级别告警元数据
        ///   &quot;ApplicationGroups&quot;: [
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup1&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url1&quot;
        ///     },
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup2&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url2&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The approval type of the service usage application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manual: The application is manually approved.</description></item>
        /// <item><description>AutoPass: The application is automatically approved.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// <para>The information of build service information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;RepoUrl&quot;: &quot;<a href="https://github.com/user/repo.git">https://github.com/user/repo.git</a>&quot;, &quot;Brancn&quot;: &quot;main&quot;}</para>
        /// </summary>
        [NameInMap("BuildInfo")]
        [Validation(Required=false)]
        public string BuildInfo { get; set; }

        [NameInMap("BuildParameters")]
        [Validation(Required=false)]
        public string BuildParameters { get; set; }

        /// <summary>
        /// <para>The category of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DevOps</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string Categories { get; set; }

        /// <summary>
        /// <para>The commodity details.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public GetServiceResponseBodyCommodity Commodity { get; set; }
        public class GetServiceResponseBodyCommodity : TeaModel {
            /// <summary>
            /// <para>The billing method of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b> (default): subscription.</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code of the service in Alibaba Cloud Marketplace.</para>
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
            /// <para>The configuration metadata related to Lingxiao.</para>
            /// </summary>
            [NameInMap("CssMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityCssMetadata CssMetadata { get; set; }
            public class GetServiceResponseBodyCommodityCssMetadata : TeaModel {
                /// <summary>
                /// <para>The mapping information about the billing items.</para>
                /// </summary>
                [NameInMap("ComponentsMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataComponentsMappings> ComponentsMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataComponentsMappings : TeaModel {
                    /// <summary>
                    /// <para>The mappings.</para>
                    /// </summary>
                    [NameInMap("Mappings")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Mappings { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template 1</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

                /// <summary>
                /// <para>Metering item configuration information.</para>
                /// </summary>
                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityExtraInfos : TeaModel {
                    /// <summary>
                    /// <para>The ID of the entity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmgj0048****-Frequency-1</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// <para>Name of a measurement indicator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AvgMemory</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>Custom PromQL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>avg_over_time(count(kube_pod_info{namespace=\&quot;default\&quot;})[1h:1m])</para>
                    /// </summary>
                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    /// <summary>
                    /// <para>Measurement indicators.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ComputeNestPrometheus</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The binding relationship between package and measurement dimension.</para>
                /// </summary>
                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataMeteringEntityMappings : TeaModel {
                    /// <summary>
                    /// <para>The ID of the entity.</para>
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
                /// <para>The configurations of the billable items.</para>
                /// </summary>
                [NameInMap("MeteringEntityExtraInfos")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityExtraInfos : TeaModel {
                    /// <summary>
                    /// <para>The ID of the billable item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmgjxxxxxxxx-NetworkOut-2</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// <para>The metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NetworkLantency</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The custom prometheus statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>avg_over_time(count(kube_pod_info{namespace=\&quot;default\&quot;})[1h:1m])</para>
                    /// </summary>
                    [NameInMap("Promql")]
                    [Validation(Required=false)]
                    public string Promql { get; set; }

                    /// <summary>
                    /// <para>The metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AvgPod</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The billable items that are associated with the package.</para>
                /// </summary>
                [NameInMap("MeteringEntityMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings> MeteringEntityMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataMeteringEntityMappings : TeaModel {
                    /// <summary>
                    /// <para>The ID of the billable item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmgjxxxxxxxx-NetworkOut-2</para>
                    /// </summary>
                    [NameInMap("EntityIds")]
                    [Validation(Required=false)]
                    public string EntityIds { get; set; }

                    /// <summary>
                    /// <para>The name of the specification package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Pay-as-you-go Package</para>
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

                }

                /// <summary>
                /// <para>The mappings between the service specifications and the template or package.</para>
                /// </summary>
                [NameInMap("SpecificationMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings> SpecificationMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings : TeaModel {
                    /// <summary>
                    /// <para>The specification code of the service in Alibaba Cloud Marketplace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmjj00xxxx</para>
                    /// </summary>
                    [NameInMap("SpecificationCode")]
                    [Validation(Required=false)]
                    public string SpecificationCode { get; set; }

                    /// <summary>
                    /// <para>The name of the specification package.</para>
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
                    /// <para>The trial policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Trial: Trials are supported.</description></item>
                    /// <item><description>NotTrial: Trials are not supported.</description></item>
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
            /// <para>The information about the billable item.</para>
            /// </summary>
            [NameInMap("MeteringEntities")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommodityMeteringEntities> MeteringEntities { get; set; }
            public class GetServiceResponseBodyCommodityMeteringEntities : TeaModel {
                /// <summary>
                /// <para>The ID of the billable item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmgjxxxxxxxx-NetworkOut</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The name of the billable item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spring-boot-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The configuration metadata related to Saas Boost.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Enabled&quot;:false // The public endpoint of the SaaS Boost instance. &quot;PublicAccessUrl&quot;:&quot;<a href="https://example.com">https://example.com</a>&quot; }</para>
            /// </summary>
            [NameInMap("SaasBoostMetadata")]
            [Validation(Required=false)]
            public string SaasBoostMetadata { get; set; }

            /// <summary>
            /// <para>The specification details of the service in Alibaba Cloud Marketplace.</para>
            /// </summary>
            [NameInMap("Specifications")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommoditySpecifications> Specifications { get; set; }
            public class GetServiceResponseBodyCommoditySpecifications : TeaModel {
                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmjj00xxxx</para>
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
                /// <para>The subscription duration. Unit: week or year.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>marketplace: Alibaba Cloud Marketplace.</description></item>
            /// <item><description>Css: Lingxiao.</description></item>
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
        /// <para>Compliance check metadata.</para>
        /// </summary>
        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public GetServiceResponseBodyComplianceMetadata ComplianceMetadata { get; set; }
        public class GetServiceResponseBodyComplianceMetadata : TeaModel {
            /// <summary>
            /// <para>The compliance package is selected.</para>
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
        /// <para>The binding configurations of the commodity module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>componesConfigs</para>
        /// </summary>
        [NameInMap("CrossRegionConnectionStatus")]
        [Validation(Required=false)]
        public string CrossRegionConnectionStatus { get; set; }

        /// <summary>
        /// <para>The storage configurations of the service. The format in which the deployment information of a service is stored varies based on the deployment type of the service. In this case, the deployment information is stored in the JSON string format.</para>
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
        /// <para>The deployment type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
        /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
        /// <item><description>spi: The service is deployed by calling a service provider interface (SPI).</description></item>
        /// <item><description>operation: The service is deployed by using a hosted O\&amp;M service.</description></item>
        /// <item><description>container: The service is deployed by using a container.</description></item>
        /// <item><description>pkg: The service is deployed by using a package.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The duration for which hosted O\&amp;M is implemented. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>259200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The report source.</para>
        /// </summary>
        [NameInMap("EntitySource")]
        [Validation(Required=false)]
        public Dictionary<string, string> EntitySource { get; set; }

        /// <summary>
        /// <para>Indicates whether the hosted O\&amp;M feature is enabled for the service. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned if you set <b>ServiceType</b> to <b>private</b>.</para>
        /// </remarks>
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
        /// <para>{&quot;renewType&quot;:&quot;MONTHLY&quot;}</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>The logging configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Logstores&quot;: [ { &quot;LogstoreName&quot;: &quot;access-log&quot;, &quot;LogPath&quot;: &quot;/home/admin/app/logs&quot;, # This parameter is not required for containers. Configure the parameter in the YAML file. &quot;FilePattern&quot;: &quot;access.log\*&quot; # This parameter is not required for containers. Configure the parameter in the YAML file. } ] }</para>
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// <para>The hosted O\&amp;M configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;New_Vpc_Ack_And_Jumpserver\&quot;:{}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// <para>The source for which fees are generated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: No fees are generated.</description></item>
        /// <item><description>Marketplace: Fees are generated for Alibaba Cloud Marketplace.</description></item>
        /// <item><description>Custom: The custom fees.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("PayFromType")]
        [Validation(Required=false)]
        public string PayFromType { get; set; }

        /// <summary>
        /// <para>The permissions on the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Deployable: Permissions to deploy the service.</description></item>
        /// <item><description>Accessible: Permissions to access the service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deployable</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The policy name. The name can be up to 128 characters in length. Separate multiple names with commas (,). Only hosted O\&amp;M policies are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policyName1, policyName2</para>
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        /// <summary>
        /// <para>The deployment progress of the service instance. Unit: percentage.</para>
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
        /// <para>sr-04056c2ab4b94bxxxxxx</para>
        /// </summary>
        [NameInMap("RegistrationId")]
        [Validation(Required=false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1A0198B-F316-1B72-B8DD-28B6F6D6XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the distribution is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzuqyxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The URL of the service audit file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://service-info-public.oss-cn-hangzhou.aliyuncs.com/1690707531xxxxxx/service-document/be3382cd-xxxx-xxxx-xxxx-f8707ec12879.docx">https://service-info-public.oss-cn-hangzhou.aliyuncs.com/1690707531xxxxxx/service-document/be3382cd-xxxx-xxxx-xxxx-f8707ec12879.docx</a></para>
        /// </summary>
        [NameInMap("ServiceAuditDocumentUrl")]
        [Validation(Required=false)]
        public string ServiceAuditDocumentUrl { get; set; }

        /// <summary>
        /// <para>Indicates whether the service is visible. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INVISIBLE</description></item>
        /// <item><description>DISCOVERABLE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DISCOVERABLE</para>
        /// </summary>
        [NameInMap("ServiceDiscoverable")]
        [Validation(Required=false)]
        public string ServiceDiscoverable { get; set; }

        /// <summary>
        /// <para>Service document information.</para>
        /// </summary>
        [NameInMap("ServiceDocumentInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceDocumentInfos> ServiceDocumentInfos { get; set; }
        public class GetServiceResponseBodyServiceDocumentInfos : TeaModel {
            /// <summary>
            /// <para>The URL that is used to access the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://docurl">http://docurl</a></para>
            /// </summary>
            [NameInMap("DocumentUrl")]
            [Validation(Required=false)]
            public string DocumentUrl { get; set; }

            /// <summary>
            /// <para>The language of the return data. Valid values: zh-CN and en-US.</para>
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
            /// <para>Default Template.</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-70a3b15bb62643xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The information about the service.</para>
        /// </summary>
        [NameInMap("ServiceInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceInfos> ServiceInfos { get; set; }
        public class GetServiceResponseBodyServiceInfos : TeaModel {
            /// <summary>
            /// <para>The agreement information about the service.</para>
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
                /// <para>The agreement URL.</para>
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
            /// <para><a href="https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png">https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png</a></para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The language of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh-CN: Chinese</description></item>
            /// <item><description>en-US: English</description></item>
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
            /// <para>WordPress</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B是A公司自主设计并研发的开源分布式的关系型数据库</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The list of the information about the software in the service.</para>
            /// </summary>
            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosSoftwares> Softwares { get; set; }
            public class GetServiceResponseBodyServiceInfosSoftwares : TeaModel {
                /// <summary>
                /// <para>The name of the software</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The version of the software.</para>
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
        /// <para>The URL of the service page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example2.com">http://example2.com</a></para>
        /// </summary>
        [NameInMap("ServiceProductUrl")]
        [Validation(Required=false)]
        public string ServiceProductUrl { get; set; }

        /// <summary>
        /// <para>The type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
        /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
        /// <item><description>operation: The service is a hosted O\&amp;M service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The permission type of the deployment URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: All users can go to the URL to create a service instance or a trial service instance.</description></item>
        /// <item><description>Restricted: Only users in the whitelist can go to the URL to create a service instance or a trial service instance.</description></item>
        /// <item><description>OnlyFormalRestricted: Only users in the whitelist can go to the URL to create a service instance.</description></item>
        /// <item><description>OnlyTrailRestricted: Only users in the whitelist can go to the URL to create a trial service instance.</description></item>
        /// <item><description>Hidden: Users not in the whitelist cannot see the service details page when they go to the URL and cannot request deployment permissions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The share status of the instance.</para>
        /// <remarks>
        /// <para>This parameter is discontinued.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>This parameter is discontinued.</para>
        /// </summary>
        [NameInMap("ShareTypeStatus")]
        [Validation(Required=false)]
        public string ShareTypeStatus { get; set; }

        /// <summary>
        /// <para>The ID of the distribution source service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-70a3b15bb62643xxxxxx</para>
        /// </summary>
        [NameInMap("SourceServiceId")]
        [Validation(Required=false)]
        public string SourceServiceId { get; set; }

        /// <summary>
        /// <para>The version of the distribution source service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SourceServiceVersion")]
        [Validation(Required=false)]
        public string SourceServiceVersion { get; set; }

        /// <summary>
        /// <para>The name of the distribution source service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SourceSupplier</para>
        /// </summary>
        [NameInMap("SourceSupplierName")]
        [Validation(Required=false)]
        public string SourceSupplierName { get; set; }

        /// <summary>
        /// <para>The statistics.</para>
        /// </summary>
        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public GetServiceResponseBodyStatistic Statistic { get; set; }
        public class GetServiceResponseBodyStatistic : TeaModel {
            /// <summary>
            /// <para>The total number of service instances that belong to the service. The service instances that are deleted are counted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75</para>
            /// </summary>
            [NameInMap("AccumulativeInstanceCount")]
            [Validation(Required=false)]
            public int? AccumulativeInstanceCount { get; set; }

            /// <summary>
            /// <para>The total amount consumed for trial service instances. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80.35</para>
            /// </summary>
            [NameInMap("AccumulativePocAmount")]
            [Validation(Required=false)]
            public double? AccumulativePocAmount { get; set; }

            /// <summary>
            /// <para>The total number of users who use the service. The historical users are counted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AccumulativeUserCount")]
            [Validation(Required=false)]
            public int? AccumulativeUserCount { get; set; }

            /// <summary>
            /// <para>The average amount consumed for trial service instances per instance. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40.17</para>
            /// </summary>
            [NameInMap("AveragePocAmount")]
            [Validation(Required=false)]
            public double? AveragePocAmount { get; set; }

            /// <summary>
            /// <para>The average duration for which trial service instances are in use. Unit: Hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AveragePocDuration")]
            [Validation(Required=false)]
            public double? AveragePocDuration { get; set; }

            /// <summary>
            /// <para>The average amount consumed for trial service instances per a period of time. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167.9</para>
            /// </summary>
            [NameInMap("AveragePocUnitAmount")]
            [Validation(Required=false)]
            public double? AveragePocUnitAmount { get; set; }

            /// <summary>
            /// <para>The number of online service instances. It means the number of service instances that are successfully deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DeployedServiceInstanceCount")]
            [Validation(Required=false)]
            public int? DeployedServiceInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of online users. It means the number of users who successfully deployed the service instances.</para>
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
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Draft: The service is a draft.</description></item>
        /// <item><description>Submitted: The service is submitted for review. You cannot modify services in this state.</description></item>
        /// <item><description>Approved: The service is approved. You cannot modify services in this state. You can publish services in this state.</description></item>
        /// <item><description>Launching: The service is being published.</description></item>
        /// <item><description>Online: The service is published.</description></item>
        /// <item><description>Offline: The service is unpublished.</description></item>
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
        /// <para>Alibaba Cloud</para>
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

        [NameInMap("SupportContacts")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodySupportContacts> SupportContacts { get; set; }
        public class GetServiceResponseBodySupportContacts : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// <para>The type of the tenant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SingleTenant</description></item>
        /// <item><description>MultiTenant</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SingleTenant</para>
        /// </summary>
        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// <para>The status of the test. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CONFIG_IS_NULL</c>: No test configurations exist.</description></item>
        /// <item><description><c>SERVICE_TEST_SUCCEED</c>: The service passed the test.</description></item>
        /// <item><description><c>SERVICE_TSET_DOING</c>: The service does not pass the test.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SERVICE_TEST_SUCCEED</para>
        /// </summary>
        [NameInMap("TestStatus")]
        [Validation(Required=false)]
        public string TestStatus { get; set; }

        /// <summary>
        /// <para>The trial duration. Unit: day. The maximum trial duration cannot exceed 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public long? TrialDuration { get; set; }

        /// <summary>
        /// <para>The trial policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Trial: Trials are supported.</description></item>
        /// <item><description>NotTrial: Trials are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Trial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

        /// <summary>
        /// <para>The time when the service was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The metadata about the upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Description\&quot;:\&quot;xxx\&quot;,\&quot;SupportRollback\&quot;:true,\&quot;SupportUpgradeFromVersions\&quot;:[],\&quot;UpgradeComponents\&quot;:[\&quot;Configuration\&quot;]}</para>
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
        /// <para>Indicates whether the service is a virtual Internet service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VirtualInternetService")]
        [Validation(Required=false)]
        public string VirtualInternetService { get; set; }

        /// <summary>
        /// <para>The ID of the virtual Internet service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-70a3b15bb62643xxxxxx</para>
        /// </summary>
        [NameInMap("VirtualInternetServiceId")]
        [Validation(Required=false)]
        public string VirtualInternetServiceId { get; set; }

    }

}
